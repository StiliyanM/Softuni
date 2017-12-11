using System;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
        }

        private static void ResetDatabase(StudentSystemContext context)
        {
            context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            Seed(context);
        }

        private static void Seed(StudentSystemContext context)
        {
            var resources = new[]
            {
                new Resource
                {
                    Name = "Wikipedia Article",
                    ResourceType = ResourceType.Presentation,

                },
                new Resource
                {
                     Name = "Some Video",
                     ResourceType = ResourceType.Video,

                }
            };

            context.Resources.AddRange(resources);

            var homeworks = new[]
            {
                new Homework
                {
                    Content = "First Lab",
                    ContentType = ContentType.Application,
                    SubmissionTime = new DateTime(2018,1,15)
                },

                new Homework
            {
                    Content = "Second Lab",
                    ContentType = ContentType.Pdf,
                    SubmissionTime = new DateTime(2018,1,20)

            }
            };

            context.HomeworkSubmissions.AddRange(homeworks);

            var courses = new[]
          {
                new Course
                {
                    Name = "Engineering",
                    Description = "Some engineering classes",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2018,03,13),
                    Price = 400,
                    Resources = new[]
                    {
                        resources[0],resources[1]
                    },
                    HomeworkSubmissions = new []{ homeworks[0]},

                },

                new Course
                {
                    Name = "Swimming",
                    Description = "Basic Stroke",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2018,05,13),
                    Price = 600,
                    Resources = new[]
                    {
                        resources[0]
                    },
                    HomeworkSubmissions = new []{ homeworks[1]},
                }
            };

            context.Courses.AddRange(courses);

            var students = new[]
            {
                new Student
                {
                    Name = "Ivan",
                    Birthday = new DateTime(2015,12,13),
                    PhoneNumber = "0312345",
                    RegisteredOn = DateTime.Now,
                },

                new Student
                {
                    Name = "Georgi",
                    Birthday = new DateTime(1992,12,13),
                    PhoneNumber = "031234512",
                    RegisteredOn = DateTime.Now,

                    HomeworkSubmissions = new [] {homeworks[1]}
                }
};

            context.Students.AddRange(students);

            context.SaveChanges();
        }
    }
}
