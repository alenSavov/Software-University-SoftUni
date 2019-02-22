<h1 align="center">
    TODO List – Exam Preparation
</h1>
<p>
    You have been tasked to create a simple <strong>TODO List</strong>
    application. The application should hold <strong>tasks</strong>, which are
    the main app <strong>entities</strong>.
</p>
<p>
The functionality of the application should support<strong>creating</strong>, <strong>listing</strong> and    <strong>deleting</strong> tasks.
</p>
<p>
The application should <strong>persist</strong> the data into a    <strong>database</strong>.
</p>
<h2>
    Overview
</h2>
<p>
Your application should be built on <strong>each one </strong>of the    <strong>following technologies</strong>:
</p>
<h3>
    PHP
</h3>
<ul>
    <li>
        <strong>Symfony </strong>
        framework<strong></strong>
    </li>
    <li>
        <strong>Twig </strong>
        view engine<strong></strong>
    </li>
    <li>
        <strong>Doctrine</strong>
        ORM<strong></strong>
    </li>
    <li>
        <strong>MySQL </strong>
        database<strong></strong>
    </li>
</ul>
<h3>
    JavaScript
</h3>
<ul>
    <li>
        <strong>NodeJS </strong>
        +<strong> ExpressJS </strong>frameworks<strong></strong>
    </li>
    <li>
        <strong>Handlebars.js </strong>
        view engine<strong></strong>
    </li>
    <li>
        <strong>Mongoose </strong>
        data access library<strong></strong>
    </li>
    <li>
        <strong>MongoDB </strong>
        database<strong></strong>
    </li>
</ul>
<h3>
    Java
</h3>
<ul>
    <li>
        <strong>Spring </strong>
framework (<strong>Spring MVC</strong> + <strong>Spring Boot</strong> +        <strong>Spring Data</strong>)<strong></strong>
    </li>
    <li>
        <strong>Thymeleaf </strong>
        view engine<strong></strong>
    </li>
    <li>
        <strong>JPA </strong>
        / <strong>Hibernate ORM </strong>+<strong> Spring Data </strong>data
        access<strong></strong>
    </li>
    <li>
        <strong>MySQL </strong>
        database<strong></strong>
    </li>
</ul>
<h3>
    C#
</h3>
<ul>
    <li>
        <strong>ASP.NET </strong>
framework (<strong>ASP.NET MVC</strong> +        <strong>Entity Framework</strong>)
    </li>
    <li>
        <strong>Razor </strong>
        view engine<strong></strong>
    </li>
    <li>
        <strong>Entity Framework </strong>
        ORM<strong></strong>
    </li>
    <li>
        <strong>MS SQL Server </strong>
        database<strong></strong>
    </li>
</ul>
<h2>
    Data Model
</h2>
<p>
    The Task entity holds <strong>3 properties</strong>:
</p>
<p>
    · id – technology-dependent identifier (ObjectID for JavaScript, int for
    all other technologies)
</p>
<ul>
    <li>
        title – non-empty text
    </li>
    <li>
        comments – non-empty text
    </li>
</ul>
<h2>
    Project Skeletons
</h2>
<p>
You will be given the applications’ skeletons, which holds about<strong>90%</strong> of the logic. You’ll be given some<strong>files</strong> (<strong>controllers</strong>,<strong>models</strong>, <strong>views</strong>, etc.). The files will have    <strong> partially implemented logic</strong>, so you’ll need to write some
    code for the application to <strong>function properly</strong>.
</p>
<p>
    The application’s views will be given to you fully implemented. You only
    need to include them in your business logic.
</p>
<p>
    <strong>Each technology</strong>
will have its <strong>own skeleton</strong>, and the<strong>different</strong> <strong>skeletons</strong> may<strong>differ</strong> in <strong>terms</strong> of<strong>what is given to you</strong> and    <strong>what is to be implemented</strong>.
</p>
<p>
Everything that has been given to you inside the skeleton is<strong>correctly implemented </strong>and if you write your code    <strong>correctly</strong>, the application should work just fine. You are
    free to change anything in the Skeleton on your account.
</p>
<h2>
    User Interface
</h2>
<p>
    This is the user interface or how the application’s pages should look in
    their final form (fully implemented). You have several pages, described
    below:
</p>
<h3>
    Index Page
</h3>
<h4>
    Route: “/”
</h4>
<h3>
    Create Page
</h3>
<h4>
    Route: “/create”
</h4>
<h3>
    Delete Page
</h3>
<h4>
    Route: “/delete/{id}”
</h4>
<h2>
    Problem
</h2>
<p>
    As you can see the different pages are on different routes. Most of the
    routing logic will be given to you in the <strong>Skeleton</strong>, but
    you should make sure that the application <strong>works properly</strong>.
</p>
<p>
Implement the <strong>TODO List app</strong> using all the above described    <strong>4 technologies</strong>.
</p>
<h2>
    Setup
</h2>
<p>
Before you start working, make sure you    <strong>download all the dependencies</strong> (packages) required for each
    technology and <strong>set up</strong> the <strong>databases</strong>!
    Below are instructions on how to do this:
</p>
<h3>
    PHP and Symfony
</h3>
<p>
    1. Go into the <strong>root directory</strong> of the project (where the
    bin folder resides)
</p>
<p>
2. Make sure you’ve started your <strong>MySQL server</strong> (either from    <strong>XAMPP</strong> or standalone)
</p>
<p>
3. Open a <strong>shell</strong> / <strong>command prompt</strong> /    <strong> PowerShell</strong> window in the <strong>root directory</strong>:
    [Shift] + [Right click] è [Open command window here]
</p>
<p>
4. Enter the “php composer.phar install” command to restore its    <strong>Composer dependencies</strong> (described in composer.json)
</p>
<p>
    5. Enter the “php bin/console doctrine:database:create --if-not-exists”
    command
</p>
<p>
    6. Done!
</p>
<h3>
    JavaScript and Node.js
</h3>
<p>
    1. Go into the <strong>root directory</strong> of the project (where the
    bin folder resides)
</p>
<p>
    2. Make sure you’ve started your <strong>MongoDB server</strong>
    (mongod.exe --dbpath path/to/db/directory)
</p>
<p>
3. Open a <strong>shell</strong> / <strong>command prompt</strong> /    <strong> PowerShell</strong> window in the <strong>root directory</strong>:
    [Shift] + [Right click] è [Open command window here]
</p>
<p>
4. Enter the “npm install” command to restore its    <strong>Node.js dependencies</strong> (described in package.json)
</p>
<p>
    5. Done!
</p>
<h3>
    C# and ASP.NET MVC
</h3>
<p>
The C# project will automatically resolve its    <strong>NuGet dependencies</strong> (described in packages.config) using
    the NuGet package restore when the project is built.
</p>
<h3>
    Java and Spring MVC
</h3>
<p>
The Java project will automatically resolve its    <strong>Maven dependencies</strong> (described in pom.xml) when the project
    is built.
</p>