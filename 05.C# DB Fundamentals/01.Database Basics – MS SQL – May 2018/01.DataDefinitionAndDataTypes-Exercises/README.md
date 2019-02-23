<h1 align="center">
    Exercises: Data Definition and Data Types
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        "Databases Basics - MSSQL" course @ Software University.
    </a>
</p>
<h2>
    Problem 1. Create Database
</h2>
<p>
    You now know how to create database using the GUI of the SSMS. Now it’s
    time to create it using SQL queries. In that task (and the several
    following it) you will be required to create the database from the previous
exercise <strong>using only SQL queries</strong>. Firstly, just    <strong>create new database named Minions.</strong>
</p>
<h2>
    Problem 2. Create Tables
</h2>
<p>
In the newly created database Minions add table<strong>Minions (Id, Name, Age)</strong>. Then add new table    <strong>Towns (Id, Name).</strong> Set <strong>Id</strong> columns of both
    tables to be <strong>primary key </strong>as<strong> constraint</strong>.
</p>
<h2>
    Problem 3. Alter Minions Table
</h2>
<p>
Change the structure of the Minions table to have<strong>new column TownId</strong> that would be of the same type as the<strong>Id </strong>column of <strong>Towns table</strong>. Add<strong>new constraint</strong> that makes <strong>TownId</strong>    <strong>foreign key</strong> and references to <strong>Id </strong>column
    of <strong>Towns</strong> table.
</p>
<h2>
    Problem 4. Insert Records in Both Tables
</h2>
<p>
    <strong>Populate both tables</strong>
    with sample records given in the table below.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="208" colspan="4" valign="top">
                <p align="center">
                    <strong>Minions</strong>
                </p>
            </td>
            <td width="19" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="104" colspan="2" valign="top">
                <p align="center">
                    <strong>Towns</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="26" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    <strong>Age</strong>
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    <strong>TownId</strong>
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="28" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="26" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Kevin
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    22
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="28" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Sofia
                </p>
            </td>
        </tr>
        <tr>
            <td width="26" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Bob
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    15
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="28" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Plovdiv
                </p>
            </td>
        </tr>
        <tr>
            <td width="26" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Steward
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    NULL
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="28" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Varna
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Use only SQL queries. Insert the Id manually (don’t use identity).
</p>
<h2>
    Problem 5. Truncate Table Minions
</h2>
<p>
    <strong>Delete all the data</strong>
    from the Minions table using <strong>SQL query.</strong>
</p>
<h2>
    Problem 6. Drop All Tables
</h2>
<p>
    <strong>Delete all tables</strong>
    from the Minions database using <strong>SQL query</strong>.
</p>
<h2>
    Problem 7. Create Table People
</h2>
<p>
    Using <strong>SQL query</strong> create table <strong>People</strong> with
    columns:
</p>
<ul>
    <li>
        <strong>Id </strong>
– unique number for every person there will be<strong>no more than 2<sup>31</sup>-1</strong>        <strong>people. </strong>(Auto incremented)
    </li>
    <li>
        <strong>Name</strong>
– full name of the person will be        <strong>no more than 200 Unicode characters</strong>. (Not null)
    </li>
    <li>
        <strong>Picture</strong>
        – image with <strong>size up to</strong> <strong>2 MB. </strong>(Allow
        nulls)
    </li>
    <li>
        <strong>Height</strong>
        – In meters. Real number precise up to <strong>2 digits </strong>after
        floating point. (Allow nulls)
    </li>
    <li>
        <strong>Weight</strong>
        – In kilograms. Real number precise up to <strong>2 digits </strong>
        after floating point. (Allow nulls)
    </li>
    <li>
        <strong>Gender </strong>
        – Possible states are <strong>m</strong> or <strong>f. </strong>(Not
        null)
    </li>
    <li>
        <strong>Birthdate – </strong>
        (Not null)<strong></strong>
    </li>
    <li>
        <strong>Biography</strong>
– detailed biography of the person it can contain        <strong>max allowed Unicode characters. </strong>(Allow nulls)
    </li>
</ul>
<p>
Make <strong>Id</strong> primary key. Populate the table with only<strong>5 records</strong>. Submit your <strong>CREATE</strong> and<strong>INSERT statements</strong> as Run queries &amp; check DB.    <strong></strong>
</p>
<h2>
    Problem 8. Create Table Users
</h2>
<p>
    Using <strong>SQL query</strong> create table <strong>Users</strong> with
    columns:
</p>
<ul>
    <li>
        <strong>Id </strong>
– unique number for every user. There will be        <strong>no more than 2<sup>63</sup>-1 users. </strong>(Auto
        incremented)
    </li>
    <li>
        <strong>Username</strong>
– unique identifier of the user will be<strong>no more than 30 characters (non Unicode). </strong>(Required)        <strong></strong>
    </li>
    <li>
        <strong>Password </strong>
– password will be<strong>no longer than 26 characters (non Unicode). </strong>(Required)        <strong></strong>
    </li>
    <li>
        <strong>ProfilePicture</strong>
        – image with <strong>size up to 900 KB. </strong>
    </li>
    <li>
        <strong>LastLoginTime</strong>
    </li>
    <li>
        <strong>IsDeleted </strong>
– shows if the user deleted his/her profile. Possible states are        <strong> true </strong>or<strong> false</strong>.
    </li>
</ul>
<p>
Make <strong>Id</strong> primary key. Populate the table with exactly<strong>5 records</strong>. Submit your <strong>CREATE</strong> and<strong>INSERT statements</strong> as Run queries &amp; check DB.    <strong></strong>
</p>
<h2>
    Problem 9. Change Primary Key
</h2>
<p>
    Using <strong>SQL queries</strong> modify table <strong>Users</strong> from
    the previous task. First <strong>remove current primary key</strong> then
create <strong>new primary key</strong> that would be the<strong>combination</strong> of fields <strong>Id</strong> and    <strong>Username</strong>.
</p>
<h2>
    Problem 10. Add Check Constraint
</h2>
<p>
Using <strong>SQL queries</strong> modify table <strong>Users</strong>. Add    <strong>check constraint</strong> to ensure that the values in the Password
    field are <strong>at least 5 symbols</strong> long.
</p>
<h2>
    Problem 11. Set Default Value of a Field
</h2>
<p>
    Using <strong>SQL queries </strong>modify table <strong>Users</strong>.
    Make the <strong>default value</strong> of <strong>LastLoginTime</strong>
    field to be the <strong>current time.</strong>
</p>
<h2>
    Problem 12. Set Unique Field
</h2>
<p>
    Using <strong>SQL queries</strong> modify table <strong>Users</strong>.
    Remove <strong>Username</strong> field from the primary key so only the
field <strong>Id</strong> would be primary key. Now    <strong>add unique constraint</strong> to the <strong>Username</strong>
field to ensure that the values there are    <strong>at least 3 symbols</strong> long.
</p>
<h2>
    Problem 13. Movies Database
</h2>
<p>
    Using <strong>SQL queries</strong> create <strong>Movies</strong> database
    with the following entities:
</p>
<ul>
    <li>
        <strong>Directors</strong>
        (Id, DirectorName, Notes)
    </li>
    <li>
        <strong>Genres</strong>
        (Id, GenreName, Notes)
    </li>
    <li>
        <strong>Categories</strong>
        (Id, CategoryName, Notes)
    </li>
    <li>
        <strong>Movies</strong>
        (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId,
        Rating, Notes)
    </li>
</ul>
<p>
Set most <strong>appropriate data types</strong> for each column.    <strong>Set primary key</strong> to each table. Populate each table with
    exactly <strong>5 records</strong>. Make sure the columns that are present
    in 2 tables would be of the <strong>same data type</strong>. Consider which
fields are always required and which are optional. Submit your    <strong> CREATE TABLE</strong> and <strong>INSERT statements</strong> as
    Run queries &amp; check DB.<strong></strong>
</p>
<h2>
    Problem 14. Car Rental Database
</h2>
<p>
    Using <strong>SQL queries</strong> create <strong>CarRental</strong>
    database with the following entities:
</p>
<ul>
    <li>
        <strong>Categories</strong>
        (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
    </li>
    <li>
        <strong>Cars</strong>
        (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors,
        Picture, Condition, Available)
    </li>
    <li>
        <strong>Employees</strong>
        (Id, FirstName, LastName, Title, Notes)
    </li>
    <li>
        <strong>Customers</strong>
        (Id, DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)
    </li>
    <li>
        <strong>RentalOrders</strong>
        (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart,
        KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays,
        RateApplied, TaxRate, OrderStatus, Notes)
    </li>
</ul>
<p>
Set most <strong>appropriate data types</strong> for each column.    <strong>Set primary key</strong> to each table. Populate each table with
    only <strong>3 records</strong>. Make sure the columns that are present in
    2 tables would be of the <strong>same data type</strong>. Consider which
fields are always required and which are optional. Submit your    <strong>CREATE TABLE</strong> and <strong>INSERT statements</strong> as Run
    queries &amp; check DB.<strong></strong>
</p>
<h2>
    Problem 15. Hotel Database
</h2>
<p>
    Using <strong>SQL queries</strong> create <strong>Hotel</strong> database
    with the following entities:
</p>
<ul>
    <li>
        <strong>Employees</strong>
        (Id, FirstName, LastName, Title, Notes)
    </li>
    <li>
        <strong>Customers </strong>
        (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName,
        EmergencyNumber, Notes)
    </li>
    <li>
        <strong>RoomStatus</strong>
        (RoomStatus, Notes)
    </li>
    <li>
        <strong>RoomTypes </strong>
        (RoomType, Notes)
    </li>
    <li>
        <strong>BedTypes</strong>
        (BedType, Notes)
    </li>
    <li>
        <strong>Rooms </strong>
        (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
    </li>
    <li>
        <strong>Payments </strong>
        (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied,
        LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount,
        PaymentTotal, Notes)
    </li>
    <li>
        <strong>Occupancies</strong>
        (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied,
        PhoneCharge, Notes)
    </li>
</ul>
<p>
Set most <strong>appropriate data types</strong> for each column.    <strong>Set primary key</strong> to each table. Populate each table with
    only <strong>3 records</strong>. Make sure the columns that are present in
    2 tables would be of the <strong>same data type</strong>. Consider which
fields are always required and which are optional. Submit your    <strong>CREATE TABLE</strong> and <strong>INSERT statements</strong> as Run
    queries &amp; check DB.<strong></strong>
</p>
<h2>
    Problem 16. Create SoftUni Database
</h2>
<p>
    Now create bigger database called <strong>SoftUni.</strong> You will use
    same database in the future tasks. It should hold information about
</p>
<ul>
    <li>
        <strong>Towns </strong>
        (Id, Name)<strong></strong>
    </li>
    <li>
        <strong>Addresses </strong>
        (Id, AddressText, TownId)
    </li>
    <li>
        <strong>Departments </strong>
        (Id, Name)<strong></strong>
    </li>
    <li>
        <strong>Employees </strong>
        (Id, FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate,
        Salary, AddressId)
    </li>
</ul>
<p>
    <strong>Id</strong>
    columns are <strong>auto incremented</strong> starting from 1 and increased
by 1 (1, 2, 3, 4…). Make sure you<strong>use appropriate data types</strong> for each column. Add<strong>primary </strong>and<strong> foreign keys</strong><strong>as constraints</strong> for each table. Use    <strong>only SQL queries</strong>. Consider which fields are always
    required and which are optional.
</p>
<h2>
    Problem 17. Backup Database
</h2>
<p>
    Backup the database <strong>SoftUni </strong>from the previous tasks into a
    file named “<strong>softuni-backup.bak</strong>”. Delete your database from
    SQL Server Management Studio. Then restore the database from the created
    backup.
</p>
<h2>
    Problem 18. Basic Insert
</h2>
<p>
Use the <strong>SoftUni</strong> database and insert some data    <strong>using SQL queries</strong>.
</p>
<ul>
    <li>
        <strong>Towns:</strong>
        Sofia, Plovdiv, Varna, Burgas
    </li>
    <li>
        <strong>Departments:</strong>
        Engineering, Sales, Marketing, Software Development, Quality Assurance
    </li>
    <li>
        <strong>Employees:</strong>
    </li>
</ul>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="127">
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="111">
                <p align="center">
                    <strong>Job Title</strong>
                </p>
            </td>
            <td width="139">
                <p align="center">
                    <strong>Department</strong>
                </p>
            </td>
            <td width="90">
                <p align="center">
                    <strong>Hire Date</strong>
                </p>
            </td>
            <td width="72">
                <p align="center">
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="127">
                <p>
                    Ivan Ivanov Ivanov
                </p>
            </td>
            <td width="111">
                <p>
                    .NET Developer
                </p>
            </td>
            <td width="139">
                <p>
                    Software Development
                </p>
            </td>
            <td width="90">
                <p>
                    01/02/2013
                </p>
            </td>
            <td width="72">
                <p>
                    3500.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="127">
                <p>
                    Petar Petrov Petrov
                </p>
            </td>
            <td width="111">
                <p>
                    Senior Engineer
                </p>
            </td>
            <td width="139">
                <p>
                    Engineering
                </p>
            </td>
            <td width="90">
                <p>
                    02/03/2004
                </p>
            </td>
            <td width="72">
                <p>
                    4000.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="127">
                <p>
                    Maria Petrova Ivanova
                </p>
            </td>
            <td width="111">
                <p>
                    Intern
                </p>
            </td>
            <td width="139">
                <p>
                    Quality Assurance
                </p>
            </td>
            <td width="90">
                <p>
                    28/08/2016
                </p>
            </td>
            <td width="72">
                <p>
                    525.25
                </p>
            </td>
        </tr>
        <tr>
            <td width="127">
                <p>
                    Georgi Teziev Ivanov
                </p>
            </td>
            <td width="111">
                <p>
                    CEO
                </p>
            </td>
            <td width="139">
                <p>
                    Sales
                </p>
            </td>
            <td width="90">
                <p>
                    09/12/2007
                </p>
            </td>
            <td width="72">
                <p>
                    3000.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="127">
                <p>
                    Peter Pan Pan
                </p>
            </td>
            <td width="111">
                <p>
                    Intern
                </p>
            </td>
            <td width="139">
                <p>
                    Marketing
                </p>
            </td>
            <td width="90">
                <p>
                    28/08/2016
                </p>
            </td>
            <td width="72">
                <p>
                    599.88
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 19. Basic Select All Fields
</h2>
<p>
    Use the <strong>SoftUni</strong> database and first select all records from
    the <strong>Towns</strong>, then from <strong>Departments </strong>and
    finally from <strong>Employees</strong> table. Use SQL queries and submit
    them to Judge at once. Submit your query statements as Prepare DB &amp; Run
    queries.
</p>
<h2>
    Problem 20. Basic Select All Fields and Order Them
</h2>
<p>
    Modify queries from previous problem by sorting:
</p>
<ul>
    <li>
        <strong>Towns </strong>
        - alphabetically by name
    </li>
    <li>
        <strong>Departments </strong>
        - alphabetically by name
    </li>
    <li>
        <strong>Employees </strong>
        - descending by salary
    </li>
</ul>
<p>
    Submit your query statements as Prepare DB &amp; Run queries.
</p>
<h2>
    Problem 21. Basic Select Some Fields
</h2>
<p>
Modify queries from previous problem to show only    <strong>some of the columns</strong>. For table:
</p>
<ul>
    <li>
        <strong>Towns</strong>
        – Name
    </li>
    <li>
        <strong>Departments</strong>
        – Name
    </li>
    <li>
        <strong>Employees</strong>
        – FirstName, LastName, JobTitle, Salary
    </li>
</ul>
<p>
    <strong>Keep the ordering</strong>
    from the previous problem. Submit your query statements as Prepare DB &amp;
    Run queries.
</p>
<h2>
    Problem 22. Increase Employees Salary
</h2>
<p>
Use <strong>SoftUni </strong>database and<strong>increase the salary</strong> of all employees by    <strong>10%. </strong>Then show <strong>only Salary</strong> column for all
    in the <strong>Employees</strong> table. Submit your query statements as
    Prepare DB &amp; Run queries.
</p>
<h2>
    Problem 23. Decrease Tax Rate
</h2>
<p>
Use <strong>Hotel </strong>database and    <strong>decrease tax rate by</strong> <strong>3%</strong> to all payments.
Then select <strong>only</strong> <strong>TaxRate</strong> column from the    <strong>Payments</strong> table. Submit your query statements as Prepare DB
    &amp; Run queries.
</p>
<h2>
    Problem 24. Delete All Records
</h2>
<p>
    Use <strong>Hotel </strong>database and <strong>delete all records</strong>
    from the <strong>Occupancies </strong>table. Use SQL query. Submit your
    query statements as Run skeleton, run queries &amp; check DB.
</p>