function solve(input) {
    let pattern = /\b[A-Z]+\b/;
    let matches =input.match(pattern);
    console.log(matches);

}
solve([ 'We start by HTML, CSS, JavaScript, JSON and REST.',
    'Later we touch some PHP, MySQL and SQL.',
    'Later we play with C#, EF, SQL Server and ASP.NET MVC.',
    'Finally, we touch some Java, Hibernate and Spring.MVC.' ]
);