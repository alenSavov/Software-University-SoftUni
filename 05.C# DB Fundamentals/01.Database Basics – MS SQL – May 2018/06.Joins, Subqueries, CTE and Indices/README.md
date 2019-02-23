<h1 align="center">
    Exercises: Joins, Subqueries, CTE and Indices
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        "Databases Basics - MSSQL" course @ Software University.
    </a>
    For problems from 1 to 11 (inclusively) use "<strong>SoftUni</strong>"
    database and for the other problems – "<strong>Geography</strong>".
</p>
<h2>
    Problem 1. Employee Address
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeId</strong>
    </li>
    <li>
        <strong>JobTitle</strong>
    </li>
    <li>
        <strong>AddressId</strong>
    </li>
    <li>
        <strong>AddressText</strong>
    </li>
</ul>
<p>
Return the <strong>first 5</strong> rows <strong>sorted</strong> by    <strong>AddressId</strong> in <strong>ascending</strong> order.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="94" valign="top">
                <p>
                    <strong>EmployeeId</strong>
                </p>
            </td>
            <td width="186" valign="top">
                <p>
                    <strong>JobTitle</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>AddressId</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>AddressText</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" valign="top">
                <p>
                    142
                </p>
            </td>
            <td width="186" valign="top">
                <p>
                    Production Technician
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    108 Lakeside Court
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" valign="top">
                <p>
                    30
                </p>
            </td>
            <td width="186" valign="top">
                <p>
                    Human Resources Manager
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    1341 Prospect St
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="186" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="76" valign="top">
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
    Problem 2. Addresses with Towns
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>LastName</strong>
    </li>
    <li>
        <strong>Town</strong>
    </li>
    <li>
        <strong>AddressText</strong>
    </li>
</ul>
<p>
    <strong>Sorted</strong>
by <strong>FirstName</strong> in <strong>ascending</strong> order then by    <strong>LastName</strong>. Select <strong>first 50</strong> employees.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="84" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    <strong>Town</strong>
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    <strong>AddressText</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    A.Scott
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Wright
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Newport Hills
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    1400 Gate Drive
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Alan
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Brewer
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Kenmore
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    8192 Seagull Court
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Sales Employee
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>LastName</strong>
    </li>
    <li>
        <strong>DepartmentName</strong>
    </li>
</ul>
<p>
    <strong>Sorted</strong>
    by <strong>EmployeeID</strong> in <strong>ascending</strong> order. Select
    only <strong>employees</strong> from “<strong>Sales</strong>” department.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>DepartmentName</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    268
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Stephen
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Jiang
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Sales
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    273
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Brian
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Welcker
                </p>
            </td>
            <td width="132" valign="top">
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
            <td width="82" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="103" valign="top">
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
    Problem 4. Employee Departments
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>Salary</strong>
    </li>
    <li>
        <strong>DepartmentName</strong>
    </li>
</ul>
<p>
Filter only <strong>employees</strong> with<strong>salary higher than 15000</strong>. Return the<strong>first 5</strong> rows <strong>sorted</strong> by<strong>DepartmentID</strong> in <strong>ascending</strong>    <strong> </strong>order.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    <strong>DepartmentName</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Roberto
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    43300.00
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Engineering
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Gail
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    32700.00
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    Engineering
                </p>
            </td>
        </tr>
        <tr>
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
            <td width="95" valign="top">
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
    Problem 5. Employees Without Project
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
</ul>
<p>
Filter only <strong>employees</strong> <strong>without</strong> a<strong>project</strong>. Return the<strong> first 3</strong> rows<strong>sorted</strong> by <strong>EmployeeID</strong> in    <strong>ascending</strong> order.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Kevin
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    David
                </p>
            </td>
        </tr>
        <tr>
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
<h2>
    Problem 6. Employees Hired After
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>LastName</strong>
    </li>
    <li>
        <strong>HireDate</strong>
    </li>
    <li>
        <strong>DeptName</strong>
    </li>
</ul>
<p>
Filter only <strong>employees</strong><strong>hired after 1.1.1999</strong> and are from either<strong>"Sales"</strong> or <strong>"Finance"</strong> departments, s<strong>orted</strong> by <strong>HireDate</strong> (    <strong>ascending</strong>).
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="101" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="146" valign="top">
                <p>
                    <strong>HireDate</strong>
                    <strong></strong>
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    <strong>DeptName</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    Debora
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Poe
                </p>
            </td>
            <td width="146" valign="top">
                <p>
                    2001-01-19 00:00:00
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    Finance
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    Wendy
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Kahn
                </p>
            </td>
            <td width="146" valign="top">
                <p>
                    2001-01-26 00:00:00
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    Finance
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="146" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Employees with Project
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>ProjectName</strong>
    </li>
</ul>
<p>
Filter only <strong>employees</strong> <strong>with</strong> a<strong>project</strong> which has<strong>started after 13.08.2002</strong> and it is still    <strong>ongoing</strong> (no end date). Return the <strong>first 5</strong>
rows <strong>sorted</strong> by <strong>EmployeeID</strong> in    <strong>ascending</strong> order.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    <strong>ProjectName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Guy
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    Racing Socks
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Guy
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    Road Bottle Cage
                </p>
            </td>
        </tr>
        <tr>
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
            <td width="124" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Employee 24
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>ProjectName</strong>
    </li>
</ul>
<p>
Filter all the <strong>projects</strong> of <strong>employee</strong> with<strong>Id 24</strong>. If the project has<strong>started during or</strong> <strong>after</strong><strong>2005</strong> the <strong>returned</strong> value should be    <strong>NULL</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>ProjectName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    24
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    David
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    24
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    David
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Road-650
                </p>
            </td>
        </tr>
        <tr>
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
            <td width="95" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. Employee Manager
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>FirstName</strong>
    </li>
    <li>
        <strong>ManagerID</strong>
    </li>
    <li>
        <strong>ManagerName</strong>
    </li>
</ul>
<p>
    Filter all <strong>employees</strong> with a <strong>manager</strong> who
    has <strong>ID</strong> equals to <strong>3 or 7</strong>. Return all the
rows, <strong>sorted</strong> by <strong>EmployeeID</strong> in    <strong>ascending</strong> order.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>ManagerID</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>ManagerName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Rob
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Roberto
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Gail
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Roberto
                </p>
            </td>
        </tr>
        <tr>
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
            <td width="95" valign="top">
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
<h2>
    Problem 10. Employee Summary
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>EmployeeID</strong>
    </li>
    <li>
        <strong>EmployeeName</strong>
    </li>
    <li>
        <strong>ManagerName</strong>
    </li>
    <li>
        <strong>DepartmentName</strong>
    </li>
</ul>
<p>
Show <strong>first 50 employees</strong> with their    <strong>managers</strong> and the <strong>departments</strong> they are in
(show the departments of the employees). <strong>Order</strong> by    <strong>EmployeeID</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>EmployeeID</strong>
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    <strong>EmployeeName</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>ManagerName</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>DepartmentName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Guy Gilbert
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Jo Brown
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Production
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Kevin Brown
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    David Bradley
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Marketing
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="142" valign="top">
                <p>
                    Roberto Tamburello
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    Terri Duffy
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    Engineering
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
            <td width="113" valign="top">
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
    Problem 11. Min Average Salary
</h2>
<p>
Write a query that <strong>returns</strong> the value of the    <strong>lowest</strong> <strong>average</strong> <strong>salary</strong> of
    all <strong>departments</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="133" valign="top">
                <p>
                    <strong>MinAverageSalary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="133" valign="top">
                <p>
                    10866.6666
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 12. Highest Peaks in Bulgaria
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>CountryCode</strong>
    </li>
    <li>
        <strong>MountainRange</strong>
    </li>
    <li>
        <strong>PeakName</strong>
    </li>
    <li>
        <strong>Elevation</strong>
    </li>
</ul>
<p>
Filter all <strong>peaks</strong> in <strong>Bulgaria</strong> with<strong>elevation</strong> <strong>over</strong> <strong>2835</strong>.<strong>Return</strong> all the rows <strong>sorted</strong> by    <strong>elevation</strong> in <strong>descending</strong> order.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="101" valign="top">
                <p>
                    <strong>CountryCode</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    <strong>MountainRange</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>PeakName</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>Elevation</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    BG
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Rila
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Musala
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    2925
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    BG
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    Pirin
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Vihren
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    2914
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="95" valign="top">
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
    Problem 13. Count Mountain Ranges
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>CountryCode</strong>
    </li>
    <li>
        <strong>MountainRanges</strong>
    </li>
</ul>
<p>
Filter the <strong>count</strong> of the <strong>mountain</strong><strong>ranges</strong> in the <strong>United</strong><strong>States</strong>, <strong>Russia</strong> and    <strong>Bulgaria</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="101" valign="top">
                <p>
                    <strong>CountryCode</strong>
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    <strong>MountainRanges</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    BG
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    RU
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 14. Countries with Rivers
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>CountryName</strong>
    </li>
    <li>
        <strong>RiverName</strong>
    </li>
</ul>
<p>
Find the <strong>first</strong> <strong>5</strong><strong>countries</strong> with or without <strong>rivers</strong> in<strong>Africa</strong>. <strong>Sort</strong> them by    <strong>CountryName</strong> in <strong>ascending</strong> order.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="107" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    <strong>RiverName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Algeria
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    Niger
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Angola
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    Congo
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Benin
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    Niger
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Botswana
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Burkina Faso
                </p>
            </td>
            <td width="89" valign="top">
                <p>
                    Niger
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 15. *Continents and Currencies
</h2>
<p>
    Write a query that selects:
</p>
<ul>
    <li>
        <strong>ContinentCode</strong>
    </li>
    <li>
        <strong>CurrencyCode</strong>
    </li>
    <li>
        <strong>CurrencyUsage</strong>
    </li>
</ul>
<p>
Find all <strong>continents</strong> and their <strong>most</strong><strong>used</strong> <strong>currency</strong>. Filter any<strong>currency</strong> that is used in <strong>only</strong>    <strong>one</strong> <strong>country</strong>. <strong>Sort</strong> your
    results by <strong>ContinentCode</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="113" valign="top">
                <p>
                    <strong>ContinentCode</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    <strong>CurrencyCode</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>CurrencyUsage</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    AF
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    XOF
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    AS
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    AUD
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    AS
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    ILS
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    EU
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    EUR
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    NA
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    XCD
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    OC
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    USD
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 16. Countries without any Mountains
</h2>
<p>
    Write a query that selects <strong>CountryCode</strong><strong>.</strong>
    Find all the <strong>count</strong> of all <strong>countries,</strong>
which <strong>don’t</strong> <strong>have</strong> a    <strong>mountain</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="101" valign="top">
                <p>
                    <strong>CountryCode</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="101" valign="top">
                <p>
                    231
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 17. Highest Peak and Longest River by Country
</h2>
<p>
    For each country, find the elevation of <strong>the highest peak</strong>
and <strong>the length of the longest river</strong>,    <strong>sorted</strong> by the <strong>highest peak elevation</strong>
    (from highest to lowest), then by the <strong>longest river length</strong>
    (from longest to smallest), then by <strong>country name</strong>
    (alphabetically). Display <strong>NULL</strong> when no data is available
    in some of the columns. Limit only the <strong>first 5</strong> rows.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="107" valign="top">
                <p>
                    <strong>CountryName</strong>
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    <strong>HighestPeakElevation</strong>
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    <strong>LongestRiverLength</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    China
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    8848
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    6300
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    India
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    8848
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    3180
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Nepal
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    8848
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    2948
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Pakistan
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    8611
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    3180
                </p>
            </td>
        </tr>
        <tr>
            <td width="107" valign="top">
                <p>
                    Argentina
                </p>
            </td>
            <td width="147" valign="top">
                <p>
                    6962
                </p>
            </td>
            <td width="134" valign="top">
                <p>
                    4880
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 18. * Highest Peak Name and Elevation by Country
</h2>
<p>
For each country, find the <strong>name </strong>and    <strong>elevation</strong> of <strong>the highest peak</strong>, along with
    its <strong>mountain</strong>. When no peaks are available in some country,
    display elevation<strong> 0</strong>, "<strong>(no highest peak)</strong>"
as <strong>peak name</strong> and "<strong>(no mountain)</strong>" as    <strong>mountain name</strong>. When <strong>multiple peaks</strong> in
some country have the <strong>same elevation</strong>, display<strong>all of them</strong>. <strong>Sort</strong> the results by<strong>country name alphabetically</strong>, then by<strong>highest peak name alphabetically</strong>. Limit only the    <strong>first 5</strong> rows.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="102" valign="top">
                <p>
                    <strong>Country</strong>
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    <strong>Highest Peak Name</strong>
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    <strong>Highest Peak Elevation</strong>
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    <strong>Mountain</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Afghanistan
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    (no highest peak)
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    (no mountain)
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Argentina
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    Aconcagua
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    6962
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Andes
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Bulgaria
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    Musala
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    2925
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Rila
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    Burkina Faso
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    (no highest peak)
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    (no mountain)
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="102" valign="top">
                <p>
                    United States
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    Mount McKinley
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    6194
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Alaska Range
                </p>
            </td>
        </tr>
    </tbody>
</table>