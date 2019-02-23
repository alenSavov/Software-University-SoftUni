<h1 align="center">
    Database Basics MS SQL Exam – 24 Jun 2018
</h1>
<p>
    Exam problems for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        “Database Basics” course @ SoftUni
    </a>
    .
</p>
<p>
Submit your solutions in the SoftUni Judge system at    <a href="https://judge.softuni.bg/">https://judge.softuni.bg/</a>
</p>
<h1 align="center">
    Supermarket
</h1>
<p>
After feeling extremely disappointed with your previous job at “    <strong>Krivodol Trip Service LLC</strong>”, you have now started working
for a new and much better company<strong> </strong>– “    <strong>Pustinqk Software</strong>”. From the very beginning your new boss
    saw a huge potential in you and has assigned you a very exciting project.
    In <strong>6 hours</strong>, you must develop a complicated system for a
    small shop, which has now grown bigger. <strong></strong>
</p>
<h1>
    Your database must contain information about the employees and their work
    hours. You must also include information about the products and their
    orders.
</h1>
<h1>
    Section 1. DDL (30 pts)
</h1>
<p>
    You are given an E/R Diagram of the Trip Service:
</p>
<p>
Crеate a database called <strong>Supermarket</strong>. You need to create    <strong>6 tables</strong>:
</p>
<p>
● <strong>Categories</strong> – contains information about the    <strong>item</strong> <strong>categories</strong>.
</p>
<p>
    ● Items – contains information about the items and their categories.
</p>
<p>
● Orders – contains information about all of the store orders.    <strong></strong>
</p>
<p>
● OrderItems – contains information about every order’s items.    <strong></strong>
</p>
<p>
    ● Employees – contains information about the employees.<strong></strong>
</p>
<p>
    ● Shifts – contains information about <strong>check-in</strong> tracking
    for <strong>employees</strong>.<strong></strong>
</p>
<h3>
    Categories
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="105">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="242">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="344">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="105">
                <p>
                    Id
                </p>
            </td>
            <td width="242">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="344">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="105">
                <p>
                    Name
                </p>
            </td>
            <td width="242">
                <p>
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="344">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Items
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="344" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Id
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="344" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Name
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="344" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Price
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Decimal </strong>
                    number with <strong>two-digit</strong> precision
                </p>
            </td>
            <td width="344" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    CategoryId
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="344" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Categories
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Employees
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Id
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    FirstName
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>String</strong>
                    up to 50 symbols, Unicode
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    LastName
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>String</strong>
                    up to 50 symbols, Unicode<strong></strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Phone
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>String </strong>
                    with <strong>exactly 12</strong> symbols<strong></strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Salary
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Decimal </strong>
number with <strong>two-digit</strong> precision                    <strong></strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Orders
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Id
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    DateTime
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    EmployeeId
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Employees<strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    OrderItems
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="104" valign="top">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="347" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    OrderId
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="347" valign="top">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, Relationship with table                    <strong>Orders</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    ItemId
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="347" valign="top">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, Relationship with table                    <strong>Items</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Quantity
                </p>
            </td>
            <td width="242" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="347" valign="top">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, must be                    <strong>at least 1</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Shifts
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="103" valign="top">
                <p>
                    <strong>Column</strong>
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="103" valign="top">
                <p>
                    Id
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="103" valign="top">
                <p>
                    EmployeeId
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    Unique table <strong>identificator</strong> , Relationship
                    with table <strong>Employees</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="103" valign="top">
                <p>
                    CheckIn
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="103" valign="top">
                <p>
                    CheckOut
                </p>
            </td>
            <td width="243" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="346" valign="top">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, must be after CheckIn date                    <strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    1. Database Design
</h2>
<p>
    <a name="_gjdgxs"></a>
    Submit all of yours <strong>create</strong> <strong>statements</strong> to
    the <strong>Judge</strong> system.
</p>
<h1>
    Section 2. DML (10 pts)
</h1>
<p>
    <strong><u>Before you start, you must import “</u></strong>
    <u>DataSet-Supermarket.sql</u>
    <strong>
        <u>
            ”. If you have created the structure correctly, the data should be
            successfully inserted without any errors.
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
    <strong>Insert</strong>
    some sample data into the database. Write a query to add the following
records into the corresponding tables.    <strong>All Ids should be auto-generated</strong>.
</p>
<p>
    <strong>Employees</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="51%">
    <tbody>
        <tr>
            <td width="23%">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="22%" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="29%" valign="top">
                <p>
                    <strong>Phone</strong>
                </p>
            </td>
            <td width="24%" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="23%" valign="top">
                <p>
                    Stoyan
                </p>
            </td>
            <td width="22%" valign="top">
                <p>
                    Petrov
                </p>
            </td>
            <td width="29%" valign="top">
                <p>
                    888-785-8573
                </p>
            </td>
            <td width="24%" valign="top">
                <p>
                    500.25
                </p>
            </td>
        </tr>
        <tr>
            <td width="23%" valign="top">
                <p>
                    Stamat
                </p>
            </td>
            <td width="22%" valign="top">
                <p>
                    Nikolov
                </p>
            </td>
            <td width="29%" valign="top">
                <p>
                    789-613-1122
                </p>
            </td>
            <td width="24%" valign="top">
                <p>
                    999995.25
                </p>
            </td>
        </tr>
        <tr>
            <td width="23%" valign="top">
                <p>
                    Evgeni
                </p>
            </td>
            <td width="22%" valign="top">
                <p>
                    Petkov
                </p>
            </td>
            <td width="29%" valign="top">
                <p>
                    645-369-9517
                </p>
            </td>
            <td width="24%" valign="top">
                <p>
                    1234.51
                </p>
            </td>
        </tr>
        <tr>
            <td width="23%" valign="top">
                <p>
                    Krasimir
                </p>
            </td>
            <td width="22%" valign="top">
                <p>
                    Vidolov
                </p>
            </td>
            <td width="29%" valign="top">
                <p>
                    321-471-9982
                </p>
            </td>
            <td width="24%" valign="top">
                <p>
                    50.25
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Items</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="115" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>Price</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    <strong>CategoryId</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Tesla battery
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    154.25
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Chess
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    30.25
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Juice
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    5.32
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Glasses
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Bottle of water
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="132" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Update
</h2>
<p>
Make all items’ prices <strong>27% more expensive</strong> where the<strong>category ID </strong>is either <strong>1</strong>,    <strong>2</strong> or <strong>3.</strong>
</p>
<h2>
    4. Delete
</h2>
<p>
    Delete all order items where the order id is 48 (be careful with the
    relationships)
</p>
<h1>
    Section 3. Querying (40 pts)
</h1>
<p>
    <strong>
        <u>
            You need to start with a fresh dataset, so recreate your DB and
            import the sample data again (
        </u>
    </strong>
    <u>DataSet-Supermarket.sql</u>
    <strong><u>).</u></strong>
</p>
<h2>
    5. Richest People
</h2>
<p>
    Select all <strong>employees</strong> who have a <strong>salary</strong>
    above <strong>6500</strong>. Order them by <strong>first name</strong>,
    then by <strong>employee</strong> <strong>id</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="37" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    19
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Arney
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    32
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Arther
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Celie
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    11
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Emlynn
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
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
    6. Cool Phone Numbers
</h2>
<p>
    Select all <strong>full names</strong> from employees,<strong> </strong>
    whose phone number start with ‘<strong>3</strong>’.
</p>
<p>
    Order them by <strong>first name</strong> <strong>(ascending)</strong>,
    then by phone number <strong>(ascending)</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="170" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    <strong>Phone Number</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Adolphe Leacock
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    339-446-1263
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Audie Risebarer
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    341-873-1275
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Demeter Langdale
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    312-175-3209
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Jordanna Asmus
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    323-785-5898
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Employee Statistics
</h2>
<p>
    Select all <strong>employees</strong> who have orders with the total count
of the orders they processed. Order them by their<strong>orders count (descending)</strong>, then by<strong>first name</strong>. Select their <strong>first name</strong>,<strong>last name</strong> and <strong>total count</strong> of    <strong>orders</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="111" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    <strong>Count</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Bart
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Jozwiak
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    123
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Beverlee
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Raveau
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    116
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Ashley
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Topliss
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    106
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Gayler
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Wike
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    103
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Celie
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    De Cruce
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    96
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Hard Workers Club
</h2>
<p>
Select all <strong>employees</strong> whose workday is<strong>over 7 hours long on average</strong>, based on their<strong>check in/check out times</strong>. Select their<strong>first, last name</strong> and <strong>average</strong>    <strong>work hours</strong>.<strong></strong>
</p>
<p>
    Order them by <strong>work hours</strong> <strong>(descending), </strong>
    then by<strong> employee ID</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
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
            <td width="90" valign="top">
                <p>
                    <strong>Work hours</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Gill
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Wasiela
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    9
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Celie
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    De Cruce
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Jordanna
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Asmus
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Lucie
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Dickinson
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    8
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
            <td width="90" valign="top">
                <p>
                    ...
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. The Most Expensive Order
</h2>
<p>
    Find the most expensive order. Select its <strong>id</strong> and total
    item price. Consider the item <strong>quantity </strong>when calculating
    the price.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="85" valign="top">
                <p>
                    <strong>OrderId</strong>
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    <strong>TotalPrice</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    479
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    14087.84
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Rich Item, Poor Item
</h2>
<p>
Find the top 10 <strong>most expensive</strong> and    <strong>cheapest</strong> item in <strong>each order.</strong>
</p>
<p>
Order the results by <strong>most expensive item’s price</strong> (<strong>descending),</strong> then by order id (<strong>ascending</strong>)    <strong>.</strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="81" valign="top">
                <p>
                    <strong>OrderId</strong>
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    <strong>ExpensivePrice</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>CheapPrice</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="81" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    360.00
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    3.14
                </p>
            </td>
        </tr>
        <tr>
            <td width="81" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    360.00
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    1.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="81" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    360.00
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    1.23
                </p>
            </td>
        </tr>
        <tr>
            <td width="81" valign="top">
                <p>
                    39
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    360.00
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    2.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="81" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="95" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Cashiers
</h2>
<p>
    Find all employees who have orders. Select their id, first name and last
    name. Order them by <strong>employee id</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="36" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    <strong>First Name</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    <strong>Last Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    Celie
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    De Cruce
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    Lucie
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Dickinson
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    Adaline
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    Gilogly
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Lazy Employees
</h2>
<p>
    Find all employees, who have below 4 work hours per day.
</p>
<p>
    Order them by employee id.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="36" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Krishnah Lalor
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Jasmine Forsdike
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Ole De la Feld
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Sellers
</h2>
<p>
    Find the top 10 employees with their full name, orders’ total price and
    item count.
</p>
<p>
Count only orders which were <strong>ordered</strong>    <strong>before 2018-06-15</strong>.
</p>
<p>
Order them by <strong>total sum (descending)</strong>, then by    <strong>item count (descending)</strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="115" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    <strong>Total Price</strong>
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    <strong>Items</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Bart Jozwiak
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    37612.33
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    2497
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Adaline Gilogly
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    26989.77
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    1765
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Celie De Cruce
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    25692.80
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    1773
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Gayler Wike
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    24754.87
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    2350
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    Lucie Dickinson
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    23707.26
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    1223
                </p>
            </td>
        </tr>
        <tr>
            <td width="115" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="69" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Tough days
</h2>
<p>
    Find all records of the employees who don’t have orders and who work over
    12 hours.
</p>
<p>
    Select only their full name and day of the week.
</p>
<p>
    Order the results by <strong>employee id</strong>.
</p>
<p>
    <strong>
        Note: By the American Standards, Sunday is the first day of week.
    </strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    <strong>Day of week</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Krishnah Lalor
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Sunday
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Jordanna Asmus
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Monday
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Ole De la Feld
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Friday
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Ole De la Feld
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Thursday
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Top Order per Employee
</h2>
<p>
    Find all information of the employees who have orders. Select their full
    name, duration of the work day (<strong>in hours</strong>) and total price
    of all sold products. Find only the <strong>top orders</strong> (top orders
    with highest total price).
</p>
<p>
Sort them by <strong>full name</strong> (ascending),    <strong>work hours</strong> (descending) and <strong>total price</strong>
    (descending)
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="149" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="91" valign="top">
                <p>
                    <strong>WorkHours</strong>
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    <strong>TotalPrice</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    Adaline Gilogly
                </p>
            </td>
            <td width="91" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    9460.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    Adolphe Leacock
                </p>
            </td>
            <td width="91" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    14087.84
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    Anatola Lydon
                </p>
            </td>
            <td width="91" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    4090.80
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="91" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    16. Average Profit per Day
</h2>
<p>
    Find the <strong>average</strong> <strong>profit</strong> for each day.
Select the <strong>day of month</strong> and    <strong>average daily profit</strong> of sold products.
</p>
<p>
    Sort them by <strong>day of month</strong> (ascending) and format the
    profit to the <strong>second digit</strong> after the decimal point.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="57" valign="top">
                <p>
                    <strong>Day</strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    <strong>Total profit</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    254.79
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    211.49
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    115.89
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    83.26
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    111.47
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    101.49
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    140.65
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    90.17
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    11
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    281.59
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    12
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    162.31
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    13
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    127.65
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    17. Top Products
</h2>
<p>
    Find information about <strong>all products</strong>. Select their name,
    category, how many of them were sold and the total profit they produced.
</p>
<p>
    Sort them by <strong>total profit</strong> (<strong>descending</strong>)
    and <strong>their count</strong> (<strong>descending</strong>)
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="75" valign="top">
                <p>
                    <strong>Item</strong>
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    <strong>Category</strong>
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    <strong>Count</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>TotalPrice</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="75" valign="top">
                <p>
                    TV
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Miscellaneous
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    308
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    110880.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="75" valign="top">
                <p>
                    Tires
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Miscellaneous
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    524
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    78600.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="75" valign="top">
                <p>
                    Mattress
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Miscellaneous
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    298
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    29800.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="75" valign="top">
                <p>
                    Camera
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Miscellaneous
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    352
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    28160.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="75" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="97" valign="top">
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
<h1>
    Section 4. Programmability (20 pts)
</h1>
<h2>
    18. Promotion days
</h2>
<p>
    Create a <strong>user defined function</strong>, named
    <strong>
        udf_GetPromotedProducts(@CurrentDate, @StartDate, @EndDate, @Discount,
        @FirstItemId, @SecondItemId, @ThirdItemId)
    </strong>
, that receives a <strong>current date</strong>, a    <strong>start date </strong>for the promotion, an <strong>end date</strong>
for the promotion, a <strong>discount</strong>, a<strong>first item id</strong>, a <strong>second item id</strong> and    <strong>third item id</strong>.
</p>
<p>
    The function should print the discounted price of the items, based on these
    conditions:
</p>
<p>
    · The first, second and third items must exist in the database.
</p>
<p>
    · The current date must be between the start date and end date.
</p>
<p>
    If both conditions are true, you must discount the price and print the
    following message in the format:
</p>
<ul>
    <li>
        “
        <strong>
            {FirstItemName} price: {@FirstItemPrice} &lt;-&gt; {SecondItemName}
            price: {@SecondItemPrice} &lt;-&gt; {ThirdItemName} price:
            {@ThirdItemPrice}
        </strong>
        ”
    </li>
</ul>
<p>
    If one of the items is not in the database, the function should return “One
    of the items does not exists!”
    <br/>
    If the current date is not between the start date and end date, the
    function should return “The current date is not within the promotion
    dates!”
</p>
<p>
    <strong>Note: Do not update any records in the database!</strong>
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="655" valign="top">
                <p>
                    <strong>Query </strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="655" valign="top">
                <p>
                    <strong>SELECT</strong>
                    <strong> dbo.udf_</strong>
                    <strong>GetPromotedProducts</strong>
                    <strong>(</strong>
                    <strong>'201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>02</strong>
                    <strong>'</strong>
                    <strong>,</strong>
                    <strong> '201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>01</strong>
                    <strong>'</strong>
                    <strong>, </strong>
                    <strong>'201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>03</strong>
                    <strong>'</strong>
                    <strong>,</strong>
                    <strong>13</strong>
                    <strong>, </strong>
                    <strong>3</strong>
                    <strong>,</strong>
                    <strong>4</strong>
                    <strong>,</strong>
                    <strong>5</strong>
                    <strong>)</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="655" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="655" valign="top">
                <p>
                    <strong>
                        Water price: 0.74 &lt;-&gt; Juice price: 1.31 &lt;-&gt;
                        Ayran price: 4.35
                    </strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="656" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="656" valign="top">
                <p>
                    <strong>SELECT</strong>
                    <strong> dbo.udf_</strong>
                    <strong>GetPromotedProducts</strong>
                    <strong>(</strong>
                    <strong>'201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>01</strong>
                    <strong>'</strong>
                    <strong>,</strong>
                    <strong> '201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>02</strong>
                    <strong>'</strong>
                    <strong>, </strong>
                    <strong>'201</strong>
                    <strong>8</strong>
                    <strong>-</strong>
                    <strong>08</strong>
                    <strong>-</strong>
                    <strong>03</strong>
                    <strong>'</strong>
                    <strong>,</strong>
                    <strong>13</strong>
                    <strong>,</strong>
                    <strong>3</strong>
                    <strong> ,</strong>
                    <strong>4</strong>
                    <strong>,</strong>
                    <strong>5</strong>
                    <strong>)</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="656" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="656" valign="top">
                <p>
The current date is not within the promotion dates!                    <strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Cancel order
</h2>
<p>
Create a <strong>user defined stored procedure</strong>, named<strong>usp_CancelOrder(@OrderId, @CancelDate)</strong>, that receives an<strong>order id</strong> and <strong>date</strong>, and attempts to    <strong>delete the current order</strong>. An order will only be deleted if
    all of these conditions <strong>pass</strong>:
</p>
<ul>
    <li>
If the <strong>order </strong>doesn’t exists, then it        <strong>cannot be deleted.</strong> <strong>Raise an error</strong>
        with the message “The order does not exist!”
    </li>
    <li>
If the<strong> cancel date</strong> is 3 days after the issue date,        <strong>raise an error</strong> with the message “You cannot cancel the
        order!”
    </li>
</ul>
<p>
    If all the above conditions pass,<strong> delete the order</strong>.
</p>
<h3>
    Example usage:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="343" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="343" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_CancelOrder 1, '2018-06-02'</strong>
                </p>
                <p>
                    <strong>SELECT</strong>
                    <strong> COUNT(*) FROM Orders</strong>
                </p>
                <p>
                    <strong>SELECT</strong>
                    <strong> COUNT(*) FROM OrderItems</strong>
                    <strong></strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    <strong>998</strong>
                </p>
                <p>
                    <strong>2455</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="343" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_CancelOrder 1, '2018-06-15'</strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    <strong>You cannot cancel the order!</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="343" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_CancelOrder 124231, '2018-06-15'</strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    <strong>The order does not exist!</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    20. Deleted Order
</h2>
<p>
Create a new table <strong>“DeletedOrders</strong>” with columns<strong> (OrderId, ItemId, ItemQuantity)</strong>. Create a    <strong>trigger</strong>, which fires when order is deleted. After deleting
the order,    <strong>insert all of the data into the new table “DeletedOrders”</strong>.
</p>
<p>
    <br/>
    Note: Submit only your <strong>CREATE TRIGGER</strong> statement!
</p>
<h3>
    Example usage:
</h3>
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
                    <strong>DELETE FROM</strong>
                    <strong> OrderItems</strong>
                </p>
                <p>
                    <strong>WHERE </strong>
                    <strong>OrderId = 5</strong>
                </p>
                <p>
                    <strong></strong>
                </p>
                <p>
                    <strong>DELETE FROM</strong>
                    <strong> Orders</strong>
                </p>
                <p>
                    <strong>WHERE </strong>
                    <strong>Id = 5 </strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696">
                <p>
                    <strong>Response</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="696" valign="top">
                <p>
                    <strong>(5 rows affected)</strong>
                </p>
                <p>
                    <strong></strong>
                </p>
                <p>
                    <strong>(5 rows affected)</strong>
                </p>
                <p>
                    <strong></strong>
                </p>
                <p>
                    <strong>(1 rows affected)</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>