<h1 align="center">
    Exercises: Basic CRUD
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        "Databases Basics - MSSQL" course @ Software University.
    </a>
</p>
<h2>
    1. Examine the Databases
</h2>
<p>
Download and get familiar with the <strong>SoftUni</strong>,    <strong>Diablo</strong> and <strong>Geography </strong>database schemas and
    tables. You will use them in the current and following exercises to write
    queries.
</p>
<h1>
    Part I – Queries for SoftUni Database
</h1>
<h2>
    2. Find All Information About Departments
</h2>
<p>
Write a SQL query to find    <strong>all available information about the Departments. </strong>Submit
    your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>DepartmentID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>ManagerID</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Engineering
                </p>
            </td>
            <td width="85" valign="top">
                <p align="center">
                    12
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Tool Design
                </p>
            </td>
            <td width="85" valign="top">
                <p align="center">
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Sales
                </p>
            </td>
            <td width="85" valign="top">
                <p align="center">
                    273
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="85" valign="top">
                <p align="center">
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Find all Department Names
</h2>
<p>
    Write SQL query to find <strong>all Department names</strong>. Submit your
    query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Engineering
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Tool Design
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Sales
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Find Salary of Each Employee
</h2>
<p>
Write SQL query to find the <strong>first name</strong>,    <strong>last name</strong> and <strong>salary</strong> of each employee.
    Submit your query statements as Prepare DB &amp; run queries.
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
            <td width="76" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Guy
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Gilbert
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    12500.00
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
            <td width="76" valign="top">
                <p>
                    13500.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Roberto
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Tamburello
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    43300.00
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
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Find Full Name of Each Employee
</h2>
<p>
    Write SQL query to find the <strong>first</strong>, <strong>middle</strong>
    and <strong>last name</strong> of each employee. Submit your query
    statements as Prepare DB &amp; run queries.
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
            <td width="94" valign="top">
                <p>
                    <strong>MiddleName</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Guy
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    R
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Gilbert
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Kevin
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    F
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Brown
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Roberto
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    NULL
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Tamburello
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="94" valign="top">
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
    6. Find Email Address of Each Employee
</h2>
<p>
    Write a SQL query to find the <strong>email address</strong> of each
    employee. (by his <strong>first and last name</strong>). Consider that the
    email domain is <strong>softuni.bg</strong>. Emails should look like
“John.Doe@softuni.bg". The <strong>produced column</strong> should be named    <strong>"Full Email Address"</strong>. Submit your query statements as
    Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="217" valign="top">
                <p>
                    <strong>Full Email Address</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="217" valign="top">
                <p>
                    Guy.Gilbert@softuni.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="217" valign="top">
                <p>
                    Kevin.Brown@softuni.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="217" valign="top">
                <p>
                    Roberto.Tamburello@softuni.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="217" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Find All Different Employee’s Salaries
</h2>
<p>
Write a SQL query to find    <strong>all different employee’s salaries</strong>. Show only the salaries.
    Submit your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="76" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    9000.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    9300.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    9500.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Find all Information About Employees
</h2>
<p>
    Write a SQL query to find <strong>all information</strong> about the
employees whose <strong>job title</strong> is    <strong>“Sales Representative”. </strong>Submit your query statements as
    Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    <strong>ID</strong>
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    <strong>First</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="64" valign="top">
                <p align="center">
                    <strong>Last</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    <strong>Middle</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="108" valign="top">
                <p align="center">
                    <strong>Job Title</strong>
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    <strong>DeptID</strong>
                </p>
            </td>
            <td width="50" valign="top">
                <p align="center">
                    <strong>Mngr</strong>
                </p>
                <p align="center">
                    <strong>ID</strong>
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    <strong>HireDate</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Salary</strong>
                </p>
            </td>
            <td width="79" valign="top">
                <p align="center">
                    <strong>AddressID</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    275
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    Michael
                </p>
            </td>
            <td width="64" valign="top">
                <p align="center">
                    Blythe
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    G
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Sales Representative
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="50" valign="top">
                <p align="center">
                    268
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    23100.00
                </p>
            </td>
            <td width="79" valign="top">
                <p align="center">
                    60
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    276
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    Linda
                </p>
            </td>
            <td width="64" valign="top">
                <p align="center">
                    Mitchell
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    C
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Sales Representative
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="50" valign="top">
                <p align="center">
                    268
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    23100.00
                </p>
            </td>
            <td width="79" valign="top">
                <p align="center">
                    170
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    277
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    Jillian
                </p>
            </td>
            <td width="64" valign="top">
                <p align="center">
                    Carson
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    NULL
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Sales Representative
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="50" valign="top">
                <p align="center">
                    268
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    23100.00
                </p>
            </td>
            <td width="79" valign="top">
                <p align="center">
                    61
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="64" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="50" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="79" valign="top">
                <p align="center">
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Find Names of All Employees by Salary in Range
</h2>
<p>
Write a SQL query to find the <strong>first name</strong>,    <strong>last name</strong> and <strong>job title</strong> of all employees
whose <strong>salary is in the</strong>    <strong>range [20000, 30000]. </strong>Submit your query statements as
    Prepare DB &amp; run queries.
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
            <td width="151" valign="top">
                <p>
                    <strong>JobTitle</strong>
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
            <td width="151" valign="top">
                <p>
                    Senior Tool Designer
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Thierry
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    D'Hers
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Tool Designer
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    JoLynn
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Dobney
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Production Supervisor
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
            <td width="151" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Find Names of All Employees
</h2>
<p>
    Write a SQL query to find the <strong>full name</strong> of all employees
whose <strong>salary</strong> is<strong>25000, 14000, 12500 or 23600</strong>. Full Name is combination of    <strong>first</strong>, <strong>middle</strong> and <strong>last</strong>
name (separated with <strong>single space</strong>) and they should be    <strong>in one column</strong> called <strong>“Full Name”. </strong>Submit
    your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Guy R Gilbert
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Thierry B D'Hers
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    JoLynn M Dobney
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Find All Employees Without Manager
</h2>
<p>
    Write a SQL query to find <strong>first and last names</strong> about those
    employees that <strong>does not have a manager</strong>. Submit your query
    statements as Prepare DB &amp; run queries.
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
                    Ken
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Sanchez
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Svetlin
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Nakov
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
    12. Find All Employees with Salary More Than 50000
</h2>
<p>
Write a SQL query to find <strong>first name</strong>,    <strong>last name</strong> and <strong>salary</strong> of those employees
    who has salary more than 50000. Order them in decreasing order by salary.
    Submit your query statements as Prepare DB &amp; run queries.
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
            <td width="85" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Ken
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Sanchez
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    125500.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    James
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Hamilton
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    84100.00
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
            <td width="85" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Find 5 Best Paid Employees.
</h2>
<p>
Write SQL query to find <strong>first and last names </strong>about<strong>5 best paid Employees</strong> ordered    <strong>descending by their salary. </strong>Submit your query statements
    as Prepare DB &amp; run queries.
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
                    Ken
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Sanchez
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    James
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Hamilton
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
    14. Find All Employees Except Marketing
</h2>
<p>
Write a SQL query to find the <strong>first </strong>and<strong> last names</strong> of all employees whose    <strong>department ID is different from 4. </strong>Submit your query
    statements as Prepare DB &amp; run queries.
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
                    Guy
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Gilbert
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Roberto
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Tamburello
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    Rob
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Walters
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Sort Employees Table
</h2>
<p>
    Write a SQL query to sort all records in the Employees table by the
    following criteria:
</p>
<ul>
    <li>
        First by <strong>salary</strong> in <strong>decreasing</strong> order
    </li>
    <li>
        Then by <strong>first name</strong> <strong>alphabetically</strong>
    </li>
    <li>
        Then by <strong>last name descending</strong>
    </li>
    <li>
        Then by <strong>middle name alphabetically</strong>
    </li>
</ul>
<p>
    Submit your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    <strong>ID</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>First</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    <strong>Last</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    <strong>Middle</strong>
                </p>
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Job Title</strong>
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    <strong>DeptID</strong>
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    <strong>Mngr</strong>
                </p>
                <p align="center">
                    <strong>ID</strong>
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    <strong>HireDate</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    <strong>Salary</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    <strong>AddressID</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    109
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    Ken
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    Sanchez
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    J
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    Chief Executive Officer
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    16
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    NULL
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    125500.00
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    177
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    148
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    James
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    Hamilton
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    R
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    Vice President of Production
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    7
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    109
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    84100.00
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    158
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    273
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    Brian
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    Welcker
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    S
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    Vice President of Sales
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    109
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    72100.00
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    134
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="63" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="57" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="69" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p align="center">
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    16. Create View Employees with Salaries
</h2>
<p>
    Write a SQL query to create a view <strong>V_EmployeesSalaries</strong>
with <strong>first name</strong>, <strong>last name</strong> and    <strong>salary</strong> for each employee. Submit your query statements as
    Run skeleton, run queries &amp; check DB.
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
            <td width="76" valign="top">
                <p>
                    <strong>Salary</strong>
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
            <td width="76" valign="top">
                <p>
                    12500.00
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
            <td width="76" valign="top">
                <p>
                    13500.00
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
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    17. Create View Employees with Job Titles
</h2>
<p>
    Write a SQL query to create view <strong>V_EmployeeNameJobTitle </strong>
    with <strong>full employee name</strong> and <strong>job title</strong>.
When middle name is <strong>NULL</strong> replace it with    <strong>empty string (‘’)</strong>. Submit your query statements as Run
    skeleton, run queries &amp; check DB.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="151" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    <strong>Job Title</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Guy R Gilbert
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Production Technician
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Kevin F Brown
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Marketing Assistant
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    Roberto Tamburello
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Engineering Manager
                </p>
            </td>
        </tr>
        <tr>
            <td width="151" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    18. Distinct Job Titles
</h2>
<p>
    Write a SQL query to find <strong>all distinct job titles</strong>. Submit
    your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="180" valign="top">
                <p>
                    <strong>JobTitle</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="180" valign="top">
                <p>
                    Accountant
                </p>
            </td>
        </tr>
        <tr>
            <td width="180" valign="top">
                <p>
                    Accounts Manager
                </p>
            </td>
        </tr>
        <tr>
            <td width="180" valign="top">
                <p>
                    Accounts Payable Specialist
                </p>
            </td>
        </tr>
        <tr>
            <td width="180" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Find First 10 Started Projects
</h2>
<p>
    Write a SQL query to find <strong>first 10 started projects</strong>.
Select <strong>all information about them</strong> and<strong>sort</strong> them <strong>by start date</strong>,    <strong>then by name</strong>. Submit your query statements as Prepare DB
    &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="34" valign="top">
                <p>
                    <strong>ID</strong>
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="235" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    <strong>StartDate</strong>
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    <strong>EndDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="34" valign="top">
                <p align="center">
                    6
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    HL Road Frame
                </p>
            </td>
            <td width="235" valign="top">
                <p>
                    Research, design and development of HL Road …
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    1998-05-02 00:00:00
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2003-06-01 00:00:00
                </p>
            </td>
        </tr>
        <tr>
            <td width="34" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    Cycling Cap
                </p>
            </td>
            <td width="235" valign="top">
                <p>
                    Research, design and development of C…
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    2001-06-01 00:00:00
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2003-06-01 00:00:00
                </p>
            </td>
        </tr>
        <tr>
            <td width="34" valign="top">
                <p align="center">
                    5
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    HL Mountain Frame
                </p>
            </td>
            <td width="235" valign="top">
                <p>
                    Research, design and development of HL M…
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    2001-06-01 00:00:00
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2003-06-01 00:00:00
                </p>
            </td>
        </tr>
        <tr>
            <td width="34" valign="top">
                <p align="center">
                    …
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="235" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    20. Last 7 Hired Employees
</h2>
<p>
Write a SQL query to find <strong>last 7 hired employees</strong>. Select    <strong>their first, last name and their hire date. </strong>Submit your
    query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="113" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    <strong>HireDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Rachel
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Valdez
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    2005-07-01 00:00:00
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Lynn
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Tsoflias
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    2005-07-01 00:00:00
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Syed
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Abbas
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    2005-04-15 00:00:00
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
            <td width="189" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    21. Increase Salaries
</h2>
<p>
Write a SQL query to increase salaries of all employees that are in the<strong>Engineering</strong>, <strong>Tool Design</strong>,    <strong>Marketing</strong> or <strong>Information Services</strong>
department by <strong>12%</strong>. Then    <strong>select Salaries column</strong> from the <strong>Employees</strong>
    table. After that exercise restore your database to revert those changes.
    Submit your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="76" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    12500.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    15120.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    48496.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    33376.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
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
    22. All Mountain Peaks
</h2>
<p>
    Display all <strong>mountain peaks </strong>in alphabetical order. Submit
    your query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="123" valign="top">
                <p>
                    <strong>PeakName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Aconcagua
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Banski Suhodol
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Batashki Snezhnik
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    23. Biggest Countries by Population
</h2>
<p>
    Find the 30 biggest countries by population <strong>from Europe</strong>.
    Display the country name and population. Sort the results by population
    (from biggest to smallest), then by country alphabetically. Submit your
    query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>Population</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Russia
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    140702000
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Germany
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    81802257
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    France
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    64768389
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
    24. *Countries and Currency (Euro / Not Euro)
</h2>
<p>
    Find all countries along with information about their currency. Display the
country code, country name and information about its currency: either "    <strong>Euro</strong>" or "<strong>Not Euro</strong>". Sort the results by
    country name alphabetically. Submit your query statements as Prepare DB
    &amp; run queries.
</p>
<p>
    *Hint: Use <strong>CASE</strong> … <strong>WHEN</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>CountryCode</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Currency</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Afghanistan
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    AF
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Not Euro
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Åland
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    AX
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Euro
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Albania
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    AL
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Not Euro
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="95" valign="top">
                <p>
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
<h1>
    Part III – Queries for Diablo Database
</h1>
<h2>
    25. All Diablo Characters
</h2>
<p>
    Display all <strong>characters </strong>in alphabetical order. Submit your
    query statements as Prepare DB &amp; run queries.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="123" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Amazon
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Assassin
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    Barbarian
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>