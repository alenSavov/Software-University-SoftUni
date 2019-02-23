<h1 align="center">
    Database Basics MS SQL Exam – 19 Feb 2017
</h1>
<p>
    Exam problems for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        “Database Basics” course @ SoftUni
    </a>
    . Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/469/">
        https://judge.softuni.bg/Contests/469/
    </a>
    .
</p>
<p>
    <strong>Database Fundamentals MSSQL – Bakery</strong>
</p>
<p>
    <em>
        Your friend is opening his “bio” bakery. Since he is a lucky one to
        have you as a friend/programmer you decide to take part of his new
        journey – selling healthy food to people. Based on his requirements you
        should create the initial database frame. Then you have to do some data
        manipulations. Finally, you have to do some work on the programmability
        part.
    </em>
</p>
<h1>
    Section 1. DDL (25 pts)
</h1>
<p>
    <strong>
        <u>
For this section put your queries in judge and use: “            <em>SQL Server run queries and check DB</em>”.
        </u>
    </strong>
</p>
<p>
    You have been given the E/R Diagram of the bakery:
</p>
<p>
Crate a database called <strong>Bakery</strong>. You need to create    <strong>7 tables</strong>:
</p>
<ul type="disc">
    <li>
        <strong>Products</strong>
        – contains information about the products that are being sold in our
        bakery.
    </li>
    <li>
        <strong>Ingredients</strong>
        – contains information about concrete fruits, vegetables, spices and so
        on. Has relation to both products and distributors.
    </li>
    <li>
        <strong>ProductsIngredients</strong>
        – mapping table between products and ingredients.
    </li>
    <li>
        <strong>Distributors</strong>
        – contains information about distributors – organizations that deliver
        ingredients.
    </li>
    <li>
        <strong>Customers</strong>
        – contains information about the customers that use our products.
    </li>
    <li>
        <strong>Countries</strong>
        – contains info for origin place (ingredients), general
        office(distributors) or homeland (customers).
    </li>
    <li>
        <strong>Feedbacks</strong>
        – contains information about the feedback that the customers give while
        evaluating some of the products
    </li>
</ul>
<p>
    <strong>Customers</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="212">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td valign="top">
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    FirstName
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    String up to 25 symbols, Unicode
                </p>
            </td>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    LastName
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    String up to 25 symbols, Unicode
                </p>
            </td>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Gender
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>Character</strong>
                    with <strong>exactly</strong> 1 symbol
                </p>
            </td>
            <td valign="top">
                <p>
                    Could be: '<em>M</em>' or '<em>F</em>'<em></em>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Age
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    PhoneNumber
                </p>
            </td>
            <td width="212">
                <p>
                    String 10 <strong>characters</strong> long.
                </p>
            </td>
            <td valign="top">
                <p>
String length is <strong>exactly</strong> 10                    <strong>chars</strong> long.
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CountryId
                </p>
            </td>
            <td width="212">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td valign="top">
                <p>
                    Relationship with table Countries
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Feedbacks</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="264">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td valign="top">
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Description
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    String up to 255 symbols, Unicode
                </p>
            </td>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Rate
                </p>
            </td>
            <td width="264">
                <p>
                    <strong>Decimal</strong>
                    number with two-digit precision
                </p>
            </td>
            <td>
                <p>
                    Rate is between 0 and 10
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    ProductId
                </p>
            </td>
            <td width="264">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td>
                <p>
                    Relationship with table Products
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CustomerId
                </p>
            </td>
            <td width="264">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td>
                <p>
                    Relationship with table Customers
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Products</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="302">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td>
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    String up to 25 symbols, Unicode
                </p>
            </td>
            <td valign="top">
                <p>
                    Unique
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Description
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    String up to 250 symbols, Unicode
                </p>
            </td>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Recipe
                </p>
            </td>
            <td width="302">
                <p>
String with unlimited number of symbols (                    <strong>max</strong>),
                </p>
                <p>
                    Unicode
                </p>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Price
                </p>
            </td>
            <td width="302">
                <p>
                    Decimal number used for <strong>money</strong> calculations
                </p>
            </td>
            <td>
                <p>
                    <strong>Non-positive</strong>
                    numbers are not allowed
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>Ingredients</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="247" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="247">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="247" valign="top">
                <p>
                    String up to 30 symbols, Unicode
                </p>
            </td>
            <td width="324" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Description
                </p>
            </td>
            <td width="247" valign="top">
                <p>
                    String up to 200 symbols, Unicode
                </p>
            </td>
            <td width="324" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    OriginCountryId
                </p>
            </td>
            <td width="247">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Relationship with table Countries
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    DistributorId
                </p>
            </td>
            <td width="247">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Relationship with table Distributors
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>ProductsIngredients</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    ProductId
                </p>
            </td>
            <td width="212">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="358">
                <p>
                    Unique table identificator, Relationship with table
                    Products
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    IngredientId
                </p>
            </td>
            <td width="212">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="358">
                <p>
                    Unique table identificator, Relationship with table
                    Ingredients
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Distributors</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="241" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="330" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="241">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="330">
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="241" valign="top">
                <p>
                    String up to 25 symbols, Unicode
                </p>
            </td>
            <td width="330" valign="top">
                <p>
                    Unique
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    AddressText
                </p>
            </td>
            <td width="241" valign="top">
                <p>
                    String up to 30 symbols, Unicode
                </p>
            </td>
            <td width="330" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Summary
                </p>
            </td>
            <td width="241" valign="top">
                <p>
                    String up to 200 symbols, Unicode
                </p>
            </td>
            <td width="330" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CountryId
                </p>
            </td>
            <td width="241">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="330">
                <p>
                    Relationship with table Countries
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Countries</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="247" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Id
                </p>
            </td>
            <td width="247">
                <p>
                    Integer from 0 to 2,147,483,647
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Unique table identificator, Identity
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="247" valign="top">
                <p>
                    String up to 50 characters, Unicode
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Unique
                </p>
            </td>
        </tr>
    </tbody>
</table>
<br clear="all"/>
<h2>
    1. Database design
</h2>
<p>
    Submit all of your create statements to Judge.
</p>
<h1>
    Section 2. DML (15 pts)
</h1>
<p>
    <strong>
        <u>
For this section put your queries in judge and use: “            <em>SQL Server run skeleton, run queries and check DB</em>”.
        </u>
    </strong>
</p>
<p>
    <strong><u>Before you start you have to import “</u></strong>
    <strong>
        <em><u>Скелет</u></em>
        <u>
            ”. If you have created the structure correctly the data should be
            successfully inserted.
        </u>
    </strong>
</p>
<p>
    In this section, you have to do some data manipulations:
</p>
<h2>
    2. Insert
</h2>
<p>
    Let’s <strong>insert</strong> some sample data into the database. Write a
    query to add the following records into the corresponding tables. All Id’s
    should be auto-generated.
</p>
<p>
    <strong>Distributors</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="158">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="82">
                <p>
                    <strong>CountryId</strong>
                </p>
            </td>
            <td width="126">
                <p>
                    <strong>AddressText</strong>
                </p>
            </td>
            <td>
                <p>
                    <strong>Summary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="158">
                <p>
                    Deloitte &amp; Touche
                </p>
            </td>
            <td width="82">
                <p>
                    2
                </p>
            </td>
            <td width="126">
                <p>
                    6 Arch St #9757
                </p>
            </td>
            <td>
                <p>
                    Customizable neutral traveling
                </p>
            </td>
        </tr>
        <tr>
            <td width="158">
                <p>
                    Congress Title
                </p>
            </td>
            <td width="82">
                <p>
                    13
                </p>
            </td>
            <td width="126">
                <p>
                    58 Hancock St
                </p>
            </td>
            <td>
                <p>
                    Customer loyalty
                </p>
            </td>
        </tr>
        <tr>
            <td width="158">
                <p>
                    Kitchen People
                </p>
            </td>
            <td width="82">
                <p>
                    1
                </p>
            </td>
            <td width="126">
                <p>
                    3 E 31st St #77
                </p>
            </td>
            <td>
                <p>
                    Triple-buffered stable delivery
                </p>
            </td>
        </tr>
        <tr>
            <td width="158">
                <p>
                    General Color Co Inc
                </p>
            </td>
            <td width="82">
                <p>
                    21
                </p>
            </td>
            <td width="126">
                <p>
                    6185 Bohn St #72
                </p>
            </td>
            <td>
                <p>
                    Focus group
                </p>
            </td>
        </tr>
        <tr>
            <td width="158">
                <p>
                    Beck Corporation
                </p>
            </td>
            <td width="82">
                <p>
                    23
                </p>
            </td>
            <td width="126">
                <p>
                    21 E 64th Ave
                </p>
            </td>
            <td>
                <p>
                    Quality-focused 4th generation hardware
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Customers</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="151">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="151">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td>
                <p>
                    <strong>Age</strong>
                </p>
            </td>
            <td>
                <p>
                    <strong>Gender</strong>
                </p>
            </td>
            <td valign="top">
                <p>
                    <strong>PhoneNumber</strong>
                </p>
            </td>
            <td valign="top">
                <p>
                    <strong>CountryId</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Francoise
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Rautenstrauch
                </p>
            </td>
            <td>
                <p>
                    15
                </p>
            </td>
            <td>
                <p>
                    M
                </p>
            </td>
            <td valign="top">
                <p>
                    0195698399
                </p>
            </td>
            <td valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Kendra
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Loud
                </p>
            </td>
            <td>
                <p>
                    22
                </p>
            </td>
            <td>
                <p>
                    F
                </p>
            </td>
            <td valign="top">
                <p>
                    0063631526
                </p>
            </td>
            <td valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Lourdes
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Bauswell
                </p>
            </td>
            <td>
                <p>
                    50
                </p>
            </td>
            <td>
                <p>
                    M
                </p>
            </td>
            <td valign="top">
                <p>
                    0139037043
                </p>
            </td>
            <td valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Hannah
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Edmison
                </p>
            </td>
            <td>
                <p>
                    18
                </p>
            </td>
            <td>
                <p>
                    F
                </p>
            </td>
            <td valign="top">
                <p>
                    0043343686
                </p>
            </td>
            <td valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Tom
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Loeza
                </p>
            </td>
            <td>
                <p>
                    31
                </p>
            </td>
            <td>
                <p>
                    M
                </p>
            </td>
            <td valign="top">
                <p>
                    0144876096
                </p>
            </td>
            <td valign="top">
                <p>
                    23
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Queenie
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Kramarczyk
                </p>
            </td>
            <td>
                <p>
                    30
                </p>
            </td>
            <td>
                <p>
                    F
                </p>
            </td>
            <td valign="top">
                <p>
                    0064215793
                </p>
            </td>
            <td valign="top">
                <p>
                    29
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Hiu
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Portaro
                </p>
            </td>
            <td>
                <p>
                    25
                </p>
            </td>
            <td>
                <p>
                    M
                </p>
            </td>
            <td valign="top">
                <p>
                    0068277755
                </p>
            </td>
            <td valign="top">
                <p>
                    16
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Josefa
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Opitz
                </p>
            </td>
            <td>
                <p>
                    43
                </p>
            </td>
            <td>
                <p>
                    F
                </p>
            </td>
            <td valign="top">
                <p>
                    0197887645
                </p>
            </td>
            <td valign="top">
                <p>
                    17
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<h2>
    3. Update
</h2>
<p>
    We’ve decided to switch some of our ingredients to a local distributor.
Update the table <strong>Ingredients</strong> and change the    <strong>DistributorId</strong> of "Bay Leaf", "Paprika" and "Poppy" to 35.
Change the <strong>OriginCountryId</strong> to 14 of all ingredients with    <strong>OriginCountryId equal to</strong> 8.
</p>
<h2>
    4. Delete
</h2>
<p>
Delete all <strong>Feedbacks</strong> which relate to<strong>Customer</strong> with <strong>Id</strong> 14 or to    <strong>Product</strong> with <strong>Id</strong> 5.
</p>
<h1>
    Section 3. Querying (40 pts)
</h1>
<p>
    <strong>
        <u>
            You need to start with a fresh dataset, so recreate your DB and
            import the sample data again.
        </u>
    </strong>
</p>
<p>
    <strong>
        <u>
For this section put your queries in judge and use: “            <em>SQL Server prepare DB and run queries</em>”.
        </u>
    </strong>
</p>
<h2>
    5. Products by Price
</h2>
<p>
    Select all <strong>products</strong> ordered by <strong>price</strong>
    (descending) then by name (ascending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        Name
    </li>
    <li>
        Price
    </li>
    <li>
        Description
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="102" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>Price</strong>
                </p>
            </td>
            <td width="233" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Oxygen bread
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    27.39
                </p>
            </td>
            <td width="233" valign="top">
                <p>
                    Morbi ut odio.
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Pizza(small)
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    27.27
                </p>
            </td>
            <td width="233" valign="top">
                <p>
                    In sagittis dui vel nisl. Duis ac nibh.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Ingredients
</h2>
<p>
Find all ingredients coming from the countries with Id’s of    <strong>1, 10, 20</strong>. Order them by ingredient Id (ascending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        Name
    </li>
    <li>
        Description
    </li>
    <li>
        OriginCountryId
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="152" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="253" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    <strong>OriginCountryId</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="152" valign="top">
                <p>
                    Bouket
                </p>
            </td>
            <td width="253" valign="top">
                <p>
                    Small bundle of herbs wrapped in a cheesecloth bag or tied
                    together and added in soups to add flavor (parsley thyme
                    and bay<em>…</em>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    10
                </p>
            </td>
        </tr>
        <tr>
            <td width="152" valign="top">
                <p>
                    Chives
                </p>
            </td>
            <td width="253" valign="top">
                <p>
                    Belongs to the onion and leek family. Source of vitamin A.
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    10
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Ingredients from Bulgaria and Greece
</h2>
<p>
    Select <strong>top 15</strong> ingredients coming from Bulgaria and Greece.
    Order them by ingredient name then by country name (both ascending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        Name
    </li>
    <li>
        Description
    </li>
    <li>
        CountryName
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="91" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="373" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="91" valign="top">
                <p>
                    Anise
                </p>
            </td>
            <td width="373" valign="top">
                <p>
                    The Greek name of anise “glykanissos” betrays its sweet
                    character [glýka means sweetness]. It’s best known use is
                    in the famous ouzo, the Greeks’ favorite drink for the
                    summertime.
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Greece
                </p>
            </td>
        </tr>
        <tr>
            <td width="91" valign="top">
                <p>
                    Cardamom
                </p>
            </td>
            <td width="373" valign="top">
                <p>
                    Cardamom has a strong piquant taste with lemon and pine
                    notes. It is considered one of the most expensive spices
                    and it is famous for its stimulating properties.
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Greece
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Best Rated Products
</h2>
<p>
    Select top 10 best rated products ordered by average rate (descending) then
    by amount of feedbacks (descending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        Name
    </li>
    <li>
        Description
    </li>
    <li>
        AverageRate – average Rate for each product
    </li>
    <li>
        FeedbacksAmount – number of feedbacks for each product
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    <strong>AverageRate</strong>
                </p>
            </td>
            <td width="144" valign="top">
                <p>
                    <strong>FeedbacksAmount</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Titanium breakfast
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    Proin risus.
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    9.920000
                </p>
            </td>
            <td width="144" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Octinoxate
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    Octocrylene
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    9.650000
                </p>
            </td>
            <td width="144" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Negative Feedback
</h2>
<p>
    Select all <strong>feedbacks</strong> alongside with the customers which
gave them. Filter only feedbacks which have <strong>rate</strong> below    <strong>5.0</strong>. Order results by ProductId (descending) then by Rate
    (ascending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        ProductId
    </li>
    <li>
        Rate
    </li>
    <li>
        Description
    </li>
    <li>
        CustomerId
    </li>
    <li>
        Age
    </li>
    <li>
        Gender
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>ProductId</strong>
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    <strong>Rate</strong>
                </p>
            </td>
            <td width="168" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    <strong>CustomerId</strong>
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    <strong>Age</strong>
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    <strong>Gender</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    30
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    2.04
                </p>
            </td>
            <td width="168" valign="top">
                <p>
                    I did not like the product
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    23
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    27
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    M
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    27
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    4.16
                </p>
            </td>
            <td width="168" valign="top">
                <p>
                    Meh..
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    20
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    57
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    F
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Customers without Feedback
</h2>
<p>
    Select all customers <strong>without</strong> feedbacks. Order them by
    customer id (ascending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        CustomerName – customer’s first and last name, concatenated with space
    </li>
    <li>
        PhoneNumber
    </li>
    <li>
        Gender
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="110" valign="top">
                <p>
                    <strong>CustomerName</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>PhoneNumber</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>Gender</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="110" valign="top">
                <p>
                    Rachel Bishop
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    0779574407
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    F
                </p>
            </td>
        </tr>
        <tr>
            <td width="110" valign="top">
                <p>
                    Irene Peters
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    0995086966
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    F
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Honorable Mentions
</h2>
<p>
    Select <strong>all</strong> feedbacks given by <strong>customers</strong>
    which have at least <strong>3</strong> <strong>feedbacks</strong>. Order
    them by product Id then by customer name and lastly by feedback id – all
    ascending.
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        ProductId
    </li>
    <li>
        CustomerName – customer’s first and last name, concatenated with space
    </li>
    <li>
        FeedbackDescription
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="90" valign="top">
                <p>
                    <strong>ProductId</strong>
                </p>
            </td>
            <td width="162" valign="top">
                <p>
                    <strong>CustomerName</strong>
                </p>
            </td>
            <td width="314" valign="top">
                <p>
                    <strong>FeedbackDescription</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="90" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="162" valign="top">
                <p>
                    Lisa Green
                </p>
            </td>
            <td width="314" valign="top">
            </td>
        </tr>
        <tr>
            <td width="90" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="162" valign="top">
                <p>
                    Lisa Green
                </p>
            </td>
            <td width="314" valign="top">
                <p>
                    First food was not ok. Second I do not like sombreros.
                    Third the music was bad.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Customers by Criteria
</h2>
<p>
Select customers that are <strong>either</strong> at least 21 old<strong>and</strong> contain “<strong>an</strong>” in their first name    <strong>or</strong> their phone number ends with “38” <strong>and</strong>
    are <strong>not</strong> from Greece. Order by first name (ascending), then
    by age(descending).
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        FirstName
    </li>
    <li>
        Age
    </li>
    <li>
        PhoneNumber
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="92" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>Age</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>PhoneNumber</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    Amanda
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    30
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    0886609909
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    Antonio
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    49
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    0781375797
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    Edward
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    55
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    0988359338
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Middle Range Distributors
</h2>
<p>
    Select all distributors which distribute <strong>ingredients</strong> used
in the making process of all products having average rate between    <strong>5</strong><strong> </strong>and<strong> 8 </strong>(inclusive).
    Order by distributor name, ingredient name and product name all ascending.
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        DistributorName
    </li>
    <li>
        IngredientName
    </li>
    <li>
        ProductName
    </li>
    <li>
        AverageRate
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="117" valign="top">
                <p>
                    <strong>DistributorName</strong>
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    <strong>IngredientName</strong>
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    <strong>ProductName</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>AverageRate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="117" valign="top">
                <p>
                    Alprazolam
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    Cinnamon
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    Nicotine Pleasure
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    5.260000
                </p>
            </td>
        </tr>
        <tr>
            <td width="117" valign="top">
                <p>
                    Arinase
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    Peppercorn
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    Panetone
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    5.400000
                </p>
            </td>
        </tr>
        <tr>
            <td width="117" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. The Most Positive Country
</h2>
<p>
    Select the country which gave the most positive feedbacks. If there are
    several – print them all. Required columns:
</p>
<ul type="disc">
    <li>
        CountryName
    </li>
    <li>
        FeedbackRate – average feedback rate for each country
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    <strong>FeedbackRate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Serbia
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    9.570000
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Country Representative
</h2>
<p>
    Select all countries with their most active distributor (the one with the
    greatest number of ingredients). If there are several distributors with
    most ingredients delivered, list them all. Order by country name then by
    distributor name.
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        CountryName
    </li>
    <li>
        DistributorName
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>DisributorName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Albania
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    Arinase
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Andorra
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    Allopurinol
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Andorra
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    SPF 17
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Section 4. Programmability (20 pts)
</h1>
<p>
    <strong>
        <u>
For this section put your queries in judge and use: “            <em>SQL Server run skeleton, run queries and check DB</em>”.
        </u>
    </strong>
</p>
<h2>
    16. Customers with Countries
</h2>
<p>
Create a view named <strong>v_UserWithCountries</strong> which selects all<strong>customers</strong> with <strong>their</strong>    <strong>countries</strong>.
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        CustomerName – first name plus last name, with space between them
    </li>
    <li>
        Age
    </li>
    <li>
        Gender
    </li>
    <li>
        CountryName
    </li>
</ul>
<p>
    Example usage:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="696" colspan="4" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" colspan="4" valign="top">
                <p>
                    SELECT TOP 5 *
                </p>
                <p>
                    FROM v_UserWithCountries
                </p>
                <p>
                    ORDER BY Age
                </p>
            </td>
        </tr>
        <tr>
            <td width="224">
                <p>
                    CustomerName
                </p>
            </td>
            <td width="107">
                <p>
                    Age
                </p>
            </td>
            <td width="140">
                <p>
                    Gender
                </p>
            </td>
            <td width="224">
                <p>
                    CountryName
                </p>
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    Paul Wells
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    M
                </p>
            </td>
            <td width="224" valign="top">
                <p>
                    Philippines
                </p>
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    Jeremy Banks
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    M
                </p>
            </td>
            <td width="224" valign="top">
                <p>
                    Brazil
                </p>
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    Marie Hudson
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    F
                </p>
            </td>
            <td width="224" valign="top">
                <p>
                    Bulgaria
                </p>
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="224" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    17. Feedback by Product Name
</h2>
<p>
    Create a <strong>user defined function</strong> that receives a product’s
    name and returns its rating as a word, based on its average Rate. For rates
    lower than 5, return "<strong>Bad</strong>", for rates between 5 and 8
return "<strong>Average</strong>" and for rates above 8, return "<strong>Good</strong>". If a product has no feedback, return "    <strong>No rating</strong>".<strong></strong>
</p>
<p>
    Parameters:
</p>
<ul type="disc">
    <li>
        ProductName
    </li>
</ul>
<p>
    Example usage:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="696" colspan="3" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" colspan="3" valign="top">
                <p>
                    SELECT TOP 5 Id, Name, dbo.udf_GetRating(Name)
                </p>
                <p>
                    FROM Products
                </p>
                <p>
                    ORDER BY Id
                </p>
            </td>
        </tr>
        <tr>
            <td width="66">
                <p>
                    Id
                </p>
            </td>
            <td width="265">
                <p>
                    Name
                </p>
            </td>
            <td width="364">
                <p>
                    (No column name)
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="265" valign="top">
                <p>
                    Octinoxate
                </p>
            </td>
            <td width="364" valign="top">
                <p>
                    Good
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="265" valign="top">
                <p>
                    Tobacco Cake
                </p>
            </td>
            <td width="364" valign="top">
                <p>
                    No rating
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="265" valign="top">
                <p>
                    Musaka
                </p>
            </td>
            <td width="364" valign="top">
                <p>
                    Good
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="265" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="364" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    18. Send Feedback
</h2>
<p>
Each <strong>Customer</strong> should not have more than    <strong>3 feedbacks</strong> per <strong>product</strong>. Your task is to
    create a user defined procedure (<strong>usp_SendFeedback</strong>) which
    accepts customer’s id, product’s id, rate and description. You should
insert the data <strong>but</strong> if the user already has 3 feedbacks –<strong>rollback</strong> any changes and throw an<strong>exception</strong> with message “    <strong>You are limited to only 3 feedbacks per product!</strong>” with
    Severity = <strong>16</strong> and State = <strong>1</strong>.
</p>
<p>
    Parameters:
</p>
<ul type="disc">
    <li>
        CustomerId
    </li>
    <li>
        ProductId
    </li>
    <li>
        Rate
    </li>
    <li>
        Description
    </li>
</ul>
<p>
    Example usage:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="696" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" valign="top">
                <p>
                    EXEC usp_SendFeedback 1, 5, 7.50, 'Average experience';
                </p>
                <p>
                    SELECT COUNT(*) FROM Feedbacks WHERE CustomerId = 1 AND
                    ProductId = 5;
                </p>
            </td>
        </tr>
        <tr>
            <td width="696">
                <p>
                    Response
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Delete Products
</h2>
<p>
    Create a trigger that deletes all of the relations of a product upon its
    deletion.
</p>
<p>
    Example usage:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="696" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" valign="top">
                <p>
                    DELETE FROM Products WHERE Id = 7
                </p>
            </td>
        </tr>
        <tr>
            <td width="696">
                <p>
                    Response
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" valign="top">
                <p>
                    (1 row(s) affected)
                </p>
                <p>
                    (3 row(s) affected)
                </p>
                <p>
                    (1 row(s) affected)
                </p>
                <p>
                    (1 row(s) affected)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Section 5. Bonus (10 pts)
</h1>
<p>
    <strong>
        <u>
For this section put your queries in judge and use: “            <em>SQL Server prepare DB and run queries</em>”.
        </u>
    </strong>
</p>
<h2>
    20. Products by One Distributor
</h2>
<p>
    Select all products which ingredients are delivered by only one
    distributor. Order them by product Id.
</p>
<p>
    Required columns:
</p>
<ul type="disc">
    <li>
        ProductName
    </li>
    <li>
        ProductAverageRate
    </li>
    <li>
        DistributorName
    </li>
    <li>
        DistributorCountry
    </li>
</ul>
<p>
    Example:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="141" valign="top">
                <p>
                    <strong>ProductName</strong>
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    <strong>ProductAverageRate</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    <strong>DistributorName</strong>
                </p>
            </td>
            <td width="199" valign="top">
                <p>
                    <strong>DistributorCountry</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Octinoxate
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    9.650000
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Lovastatin
                </p>
            </td>
            <td width="199" valign="top">
                <p>
                    Brazil
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Salad
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    6.475000
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Frova
                </p>
            </td>
            <td width="199" valign="top">
                <p>
                    South Korea
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Banitsa
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    5.540000
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Rabbitbush
                </p>
            </td>
            <td width="199" valign="top">
                <p>
                    Serbia
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="199" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>