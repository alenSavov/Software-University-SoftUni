<h1 align="center">
    Exercises: Built-in Functions
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        "Databases Basics - MSSQL" course @ Software University.
    </a>
</p>
<h1>
    Part I – Queries for SoftUni Database
</h1>
<h2>
    Problem 1. Find Names of All Employees by First Name
</h2>
<p>
Write a SQL query to find <strong>first</strong> and<strong>last names</strong> of all employees whose    <strong>first name starts with</strong> <strong>“SA”. </strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Sariya
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Harnpadoungsataya
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Sandra
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Reategui Alayo
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Find Names of All employees by Last Name
</h2>
<p>
Write a SQL query to find <strong>first</strong> and<strong>last names</strong> of all employees whose    <strong>last name contains “ei”. </strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Kendall
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Keil
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Christian
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Kleinerman
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Find First Names of All Employees
</h2>
<p>
    Write a SQL query to find the <strong>first names</strong> of all employees
    in the <strong>departments</strong> with <strong>ID 3 or 10</strong> and
whose <strong>hire year</strong> is    <strong>between 1995 and 2005 inclusive</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Deborah
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Wendy
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Candy
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. Find All Employees Except Engineers
</h2>
<p>
Write a SQL query to find the <strong>first </strong>and<strong> last names</strong> of all employees whose    <strong>job titles does not contain</strong> “<strong>engineer</strong>”.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Guy
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Gilbert
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Kevin
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Brown
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Rob
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Walters
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. Find Towns with Name Length
</h2>
<p>
Write a SQL query to find town names that are <strong>5</strong> or<strong>6 symbols long</strong> and <strong>order</strong> them    <strong>alphabetically by town name</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="66" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    Berlin
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    Duluth
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    Duvall
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 6. Find Towns Starting With
</h2>
<p>
    Write a SQL query to find all towns that <strong>start with</strong>
letters <strong>M</strong>, <strong>K</strong>, <strong>B</strong> or    <strong>E</strong>. Order them <strong>alphabetically</strong> by town
    name.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="66" valign="top">
                <p>
                    <strong>TownID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    5
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Bellevue
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    31
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Berlin
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    30
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Bordeaux
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Find Towns Not Starting With
</h2>
<p>
Write a SQL query to find all towns that<strong>does not start with</strong> letters <strong>R</strong>,<strong>B</strong> or <strong>D</strong>. Order them    <strong>alphabetically</strong> by name.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="66" valign="top">
                <p>
                    <strong>TownID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Calgary
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    23
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Cambridge
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    15
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Carnation
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Create View Employees Hired After 2000 Year
</h2>
<p>
    Write a SQL query to create view <strong>V_EmployeesHiredAfter2000</strong>
with <strong>first and last name</strong> to all employees    <strong>hired after 2000 year. </strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Steven
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Selikoff
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Peter
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Krebs
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Stuart
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Munson
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    ...
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    ...
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. Length of Last Name
</h2>
<p>
Write a SQL query to find the <strong>names of all employees</strong> whose<strong>last name</strong> is <strong>exactly</strong>    <strong>5 characters long.</strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Kevin
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Brown
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Terri
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Duffy
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Jo
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Brown
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Diane
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Glimp
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Part II – Queries for Geography Database
</h1>
<h2>
    Problem 10. Countries Holding ‘A’ 3 or More Times
</h2>
<p>
    Find all countries that holds the letter 'A' in their name at least 3 times
    (case insensitively), sorted by ISO code. Display the country name and ISO
    code.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Country Name</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>ISO Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Afghanistan
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    AFG
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Albania
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    ALB
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 11. Mix of Peak and River Names
</h2>
<p>
Combine all peak names with all river names, so that the<strong>last letter</strong> of each <strong>peak name</strong> is the<strong>same</strong> <strong>as</strong> the<strong>first letter </strong>of its corresponding <strong>river</strong>    <strong>name</strong>. Display the peak names, river names, and the
    obtained mix (mix should be in lowercase). <strong>Sort</strong> the
    results <strong>by</strong> the <strong>obtained mix</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="113" valign="top">
                <p>
                    <strong>PeakName</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>RiverName</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>Mix</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Aconcagua
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Amazon
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    aconcaguamazon
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Aconcagua
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Amur
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    aconcaguamur
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Banski Suhodol
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Lena
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    banski suhodolena
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Part III – Queries for Diablo Database
</h1>
<h2>
    Problem 12. Games from 2011 and 2012 year
</h2>
<p>
    Find the top 50 games ordered by start date, then by name of the game.
    Display only games from 2011 and 2012 year. Display start date in the
    format “<strong>yyyy-MM-dd</strong>”.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>Start</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Rose Royalty
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    2011-01-05
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    London
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    2011-01-13
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Broadway
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    2011-01-16
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 13. User Email Providers
</h2>
<p>
    Find all users along with information about their email providers. Display
    the username and email provider. Sort the results by email provider
    alphabetically, then by username.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Username</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>Email Provider</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Pesho
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    abv.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    monoxidecos
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    astonrasuna.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    bashsassafras
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    balibless
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 14. Get Users with IPAdress Like Pattern
</h2>
<p>
    Find all users along with their IP addresses sorted by username
alphabetically. Display only rows that IP address matches the pattern: “    <strong>***.1^.^.***</strong>”.
</p>
<p>
    Legend: <strong>* </strong>- one symbol, <strong>^</strong> - one or more
    symbols
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>Username</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    <strong>IP Address</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    bindbawdy
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    192.157.20.222
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    evolvingimportant
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    223.175.227.173
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    inguinalself
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    255.111.250.207
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 15. Show All Games with Duration and Part of the Day
</h2>
<p>
    Find all games with part of the day and duration sorted by game name
    alphabetically then by duration (alphabetically, not by the timespan) and
    part of the day (all ascending). <strong>Parts of the day</strong> should
be <strong>Morning</strong> (time is &gt;= 0 and &lt; 12),<strong>Afternoon</strong> (time is &gt;= 12 and &lt; 18),<strong>Evening</strong> (time is &gt;= 18 and &lt; 24).<strong>Duration</strong> should be <strong>Extra</strong>    <strong>Short </strong>(smaller or equal to 3), <strong>Short </strong>
(between 4 and 6 including), <strong>Long</strong> (greater than 6) and    <strong>Extra Long </strong>(without duration).
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="113" valign="top">
                <p>
                    <strong>Game</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    <strong>Part of the Day</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>Duration</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Ablajeck
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Morning
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Long
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Ablajeck
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Afternoon
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Short
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Abregado Rae
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Afternoon
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Long
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Abrion
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Morning
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Extra Short
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Acaeria
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Evening
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Long
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Part IV – Date Functions Queries
</h1>
<h2>
    Problem 16. Orders Table
</h2>
<p>
    You are given a table <strong>Orders(Id, ProductName, OrderDate)</strong>
    filled with data. Consider that the <strong>payment</strong> for that order
    must be accomplished <strong>within 3 days after the order date</strong>.
    Also the <strong>delivery date is up to 1 month</strong>. Write a query to
show each product’s <strong>name</strong>, <strong>order date</strong>,    <strong>pay and deliver due dates</strong>.
</p>
<h3>
    Original Table
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    <strong>Id</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    <strong>ProductName</strong>
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    <strong>OrderDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Butter
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2016-09-19 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Milk
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2016-09-30 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Cheese
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2016-09-04 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    4
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Bread
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2015-12-20 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    5
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Tomatoes
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2015-12-30 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Output
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="115" valign="top">
                <p>
                    <strong>ProductName</strong>
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    <strong>OrderDate</strong>
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    <strong>Pay Due</strong>
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    <strong>Deliver Due</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Butter
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-09-19 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-09-22 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-10-19 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Milk
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-09-30 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-10-03 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-10-30 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Cheese
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-09-04 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-09-07 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-10-04 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Bread
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2015-12-20 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2015-12-23 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-01-20 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Tomatoes
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2015-12-30 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-01-02 00:00:00.000
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    2016-01-30 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 17. People Table
</h2>
<p>
Create a table <strong>People(Id, Name</strong><strong>, Birthdate).</strong> Write a query to <strong>find</strong><strong>age in years</strong>, <strong>months</strong>,<strong>days</strong> and <strong>minutes</strong> for each person for the    <strong>current time</strong> of executing the query.
</p>
<h3>
    Original Table
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    <strong>Id</strong>
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    <strong>Birthdate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Victor
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2000-12-07 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Steven
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    1992-09-10 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Stephen
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    1910-09-19 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    4
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    John
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    2010-01-06 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="38" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="170" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Example Output
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="76" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Age in Years</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    <strong>Age in Months</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>Age in Days</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>Age in Minutes</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    Victor
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    16
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    189
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    5754
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    8286787
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    Steven
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    24
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    288
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    8764
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    12621187
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    Stephen
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    106
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    1272
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    38706
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    55737667
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    John
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    80
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    2437
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    3510307
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>