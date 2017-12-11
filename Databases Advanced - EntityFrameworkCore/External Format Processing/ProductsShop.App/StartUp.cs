using System;
using System.IO;
using Newtonsoft.Json;
using ProductsShop.Models;
using System.Linq;
using System.Collections.Generic;
using ProductsShop.Data;
using System.Xml.Linq;

namespace ProductsShop.App
{
    class StartUp
    {
        static void Main()
        {
            SeedFromJsonFiles();

            //Json Queries
            GetProductsInRange();
            GetSuccessfullySoldProducts();
            GetCategoriesByProductsCount();
            GetUsersAndProducts();

            SeedFromXmlFiles();

            XmlExportProductsInRange();
            XmlExportSoldProducts();
            XmlExportCategoriesByProductsCount();
            XmlExportUsersAndProducts();
        }

        private static void XmlExportUsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context.Users
                    .Where(b => b.ProductsSold.Any())
                    .OrderByDescending(e => e.ProductsSold.Count())
                    .ThenBy(e => e.LastName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = u.ProductsSold.Select(e => new
                        {
                            count = e.Seller.ProductsSold.Count,
                            name = e.Name,
                            price = e.Price
                        })
                    }).ToList();

                var xmlDoc = new XDocument(new XElement("users", new XAttribute("count", users.Count())));

                foreach (var e in users)
                {
                    List<XElement> list = new List<XElement>();

                    foreach (var p in e.soldProducts)
                    {
                        var products = new XElement("product",
                                        new XAttribute("name", p.name),
                                        new XAttribute("price", p.price));

                        list.Add(products);
                    }
                    xmlDoc.Root.Add(new XElement("user",
                                    new XAttribute("first-name", e.firstName ?? "Empty"),
                                    new XAttribute("last-name", e.lastName),
                                    new XAttribute("age", e.age ?? 0),
                                    new XElement("sold-products",
                                    new XAttribute("count", e.soldProducts.Count()), list)));

                }

                xmlDoc.Save("Results/users-and-products.xml");
            }
        }

        private static void XmlExportCategoriesByProductsCount()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context.Categories
                    .OrderByDescending(c => c.Products.Count)
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.Products.Count,
                        averagePrice = c.Products.Average(p => p.Product.Price),
                        totalRevenue = c.Products.Sum(p => p.Product.Price)
                    }).ToArray();

                var xmlDoc = new XDocument(new XElement("categories"));

                foreach (var c in categories)
                {
                    xmlDoc.Root.Add(new XElement("category", new XAttribute("name", c.name),
                        new XElement("products-count", c.productsCount),
                        new XElement("average-price", c.averagePrice),
                        new XElement("total-revenue", c.totalRevenue)
                        ));
                }

                xmlDoc.Save("Results/categories-by-products.xml");
            }
        }

        private static void XmlExportSoldProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var userProducts = context.Users
                    .Where(u => u.ProductsSold.Any(ps => ps.BuyerId != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        productName = u.ProductsSold.Select(p => p.Name),
                        price = u.ProductsSold.Select(p => p.Price),
                    }).ToArray();

                var xmlDoc = new XDocument();

                xmlDoc.Add(new XElement("users"));

                foreach (var u in userProducts)
                {
                    xmlDoc.Root.Add(new XElement("user",
                               new XAttribute("first-name", u.FirstName ?? ""),
                               new XAttribute("last-name", u.LastName),
                               new XElement("sold-products",
                               new XElement("product",
                               new XElement("name", u.productName),
                               new XElement("price", u.price)))));
                }

                xmlDoc.Save("Results/categories-by-products.xml");
            }
        }

        private static void XmlExportProductsInRange()
        {
            using (var context = new ProductsShopContext())
            {
                var products = context.Products
                    .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.BuyerId != null)
                    .OrderBy(p => p.Price)
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        BuyerFullName = p.Buyer.FirstName ?? "" + " " + p.Buyer.LastName
                    }).ToArray();

                var xDoc = new XDocument();

                xDoc.Add(new XElement("products"));
                foreach (var p in products)
                {
                    xDoc.Root.Add(
                        new XElement("product", new XAttribute("name", p.Name),
                        new XAttribute("price", p.Price),
                        new XAttribute("buyer", p.BuyerFullName)));
                }

                xDoc.Save("Results/products-in-range.xml");
            }
        }

        private static void SeedFromXmlFiles()
        {
            ResetDatabase();

            ImportUsersFromXml();
            ImportCategoriesFromXml();
            ImportProductsFromXml();
        }

        private static void ImportProductsFromXml()
        {
            var productsXml = XDocument.Load("Resources/products.xml");

            var rnd = new Random();

            var elements = productsXml.Root.Elements();

            var products = new List<Product>();
            using (var context = new ProductsShopContext())
            {
                var userIds = context.Users.Select(u => u.Id).ToArray();
                var categoryIds = context.Categories.Select(c => c.Id).ToArray();

                foreach (var e in elements)
                {
                    int sellerIndex = rnd.Next(0, userIds.Length);

                    var name = e.Element("name").Value;
                    var price = decimal.Parse(e.Element("price").Value);
                    int sellerId = userIds[sellerIndex];
                    int? buyerId = null;

                    if (rnd.Next(0, 3) == 1)
                    {
                        int buyerIndex = rnd.Next(0, userIds.Length);

                        buyerId = userIds[buyerIndex];
                    }
                    var product = new Product
                    {
                        BuyerId = buyerId,
                        Name = name,
                        Price = price,
                        SellerId = sellerId,
                    };

                    products.Add(product);
                }
                context.Products.AddRange(products);
                context.SaveChanges();
                var categoryProducts = GetCategories(rnd);

                context.CategoryProducts.AddRange(categoryProducts);

                context.SaveChanges();
            }
        }

        private static void ImportCategoriesFromXml()
        {
            var categoriesXml = XDocument.Load("Resources/categories.xml");

            var elements = categoriesXml.Root.Elements();

            var categories = new List<Category>();
            foreach (var e in elements)
            {
                var name = e.Element("name").Value;

                var category = new Category
                {
                    Name = name
                };

                categories.Add(category);
            }

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        private static void ImportUsersFromXml()
        {
            var usersXml = XDocument.Load("Resources/users.xml");

            var elements = usersXml.Root.Elements();

            var users = new List<User>();

            foreach (var e in elements)
            {
                var firstName = e.Attribute("firstName")?.Value;
                var lastName = e.Attribute("lastName").Value;
                int? age = null;

                if (e.Attribute("age") != null)
                {
                    age = int.Parse(e.Attribute("age").Value);
                }

                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                users.Add(user);
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        private static void GetUsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var result = context.Users
                    .Where(u => u.ProductsSold.Count >= 1)
                    .OrderByDescending(u => u.ProductsSold.Count)
                    .ThenBy(u => u.LastName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,

                        count = u.ProductsSold.Count,

                        soldProducts = u.ProductsSold.Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                    });

                var jsonString = JsonConvert.SerializeObject(result, Formatting.Indented,
                        new JsonSerializerSettings
                        {
                            DefaultValueHandling = DefaultValueHandling.Ignore
                        });

                File.WriteAllText("Results/users-and-products.json", jsonString);
            }
        }

        private static void GetCategoriesByProductsCount()
        {
            using (var context = new ProductsShopContext())
            {
                var result = context.Categories
                    .OrderBy(c => c.Name)
                    .Select(c => new
                    {
                        category = c.Name,
                        productsCount = c.Products.Count,
                        averagePrice = c.Products.Average(p => p.Product.Price),
                        totalRevenue = c.Products.Sum(p => p.Product.Price)
                    }).ToArray();

                var jsonString = JsonConvert.SerializeObject(result, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore
                    });

                File.WriteAllText("Results/categories-by-products.json", jsonString);
            }
        }

        private static void GetSuccessfullySoldProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var userProducts = context.Users
                    .Where(u => u.ProductsSold.Any(ps => ps.BuyerId != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        SoldProducts = u.ProductsSold.Select(ps => new
                        {
                            name = ps.Name,
                            price = ps.Price,
                            buyerFirstName = ps.Buyer.FirstName,
                            buyerLastName = ps.Buyer.LastName
                        })
                    }).ToArray();

                var userProductsJson = JsonConvert.SerializeObject(userProducts, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore
                    });

                File.WriteAllText("Results/users-sold-products.json", userProductsJson);
            }
        }

        private static void SeedFromJsonFiles()
        {
            var rand = new Random();

            ResetDatabase();

            var usersJson = File.ReadAllText("Resources/users.json");
            var categoriesJson = File.ReadAllText("Resources/categories.json");
            var productsJson = File.ReadAllText("Resources/products.json");


            var users = JsonConvert.DeserializeObject<User[]>(usersJson);
            var categories = JsonConvert.DeserializeObject<Category[]>(categoriesJson);
            var products = JsonConvert.DeserializeObject<Product[]>(productsJson);

            foreach (var p in products)
            {
                p.Seller = users[rand.Next(0, users.Length)];

                if (rand.Next(0, 3) == 1)
                    p.Buyer = users[rand.Next(0, users.Length)];
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.Categories.AddRange(categories);
                context.Products.AddRange(products);

                context.SaveChanges();
            }

            var cats = GetCategories(rand);

            using (var context = new ProductsShopContext())
            {
                context.CategoryProducts.AddRange(cats);

                context.SaveChanges();
            }
        }

        private static void GetProductsInRange()
        {
            using (var context = new ProductsShopContext())
            {
                var products = context.Products
                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                    .OrderBy(p => p.Price)
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        SellerFullName = p.Seller.FirstName ?? "" + " " + p.Seller.LastName
                    }).ToArray();

                var productsJson = JsonConvert.SerializeObject(products, Formatting.Indented);


                File.WriteAllText("Results/products-in-range.json", productsJson);
            }

        }

        private static void ResetDatabase()
        {
            using (var context = new ProductsShopContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        private static CategoryProduct[] GetCategories(Random rand)
        {

            using (var context = new ProductsShopContext())
            {
                var productIds = context.Products.Select(p => p.Id).ToArray();
                var categoryIds = context.Categories.Select(c => c.Id).ToArray();

                var categoryProducts = new List<CategoryProduct>();

                foreach (var p in productIds)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var index = rand.Next(0, categoryIds.Length);

                        while (categoryProducts.Any(cp => cp.ProductId == p
                                                 && cp.CategoryId == categoryIds[index]))
                        {
                            index = rand.Next(0, categoryIds.Length);
                        }

                        var categoryProduct = new CategoryProduct
                        {
                            ProductId = p,
                            CategoryId = categoryIds[index]
                        };

                        categoryProducts.Add(categoryProduct);
                    }
                }
                return categoryProducts.ToArray();
            }
        }
    }
}
