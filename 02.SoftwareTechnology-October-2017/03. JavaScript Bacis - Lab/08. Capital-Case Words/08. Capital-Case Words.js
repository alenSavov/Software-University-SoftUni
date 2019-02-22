function solution(input){

    let inputString = input.join(" ");
    let pattern = /\b[A-Z]+\b/g;
    var matches = [];
    var match = pattern.exec(inputString);
    while (match != null){
        matches.push(match[0])
        match = pattern.exec(inputString);
    }

    console.log(matches.join(", "));
}
solution(["We start by HTML, CSS, JavaScript, JSON and REST.\n" +
"Later we touch some PHP, MySQL and SQL.\n" +
"Later we play with C#, EF, SQL Server and ASP.NET MVC.\n" +
"Finally, we touch some Java, Hibernate and Spring.MVC.\n"]);

