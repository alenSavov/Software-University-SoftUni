<h1 align="center">
    Database Basics MS SQL Exam – 3 Jan 2018
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
    Rent a Car
</h1>
<h1>
    Section 1. DDL (30 pts)
</h1>
<p>
    You have been given the E/R Diagram of the Report Service:
</p>
<p>
Crеate a database called <strong>RentACar</strong>. You need to create    <strong>6 tables</strong>:
</p>
<p>
    ● <strong>Clients</strong> – contains information about the people who get
    cars on rent
</p>
<p>
    ● <strong>Orders</strong> - contains information about the client’s orders
</p>
<p>
    ● <strong>Towns</strong> – contains information about the towns
</p>
<p>
    ● <strong>Offices </strong>- contains information about the offices in the
    different towns
</p>
<p>
    ● <strong>Vehicles</strong> – contains information about the vehicles which
    could be rented
</p>
<p>
    ● <strong>Models </strong>– contains information about the
</p>
<p>
    <strong>Clients</strong>
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
                    Id
                </p>
            </td>
            <td width="212">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="358" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
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
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
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
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
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
                    with <strong>exactly</strong> <strong>1</strong> symbol
                </p>
            </td>
            <td width="358" valign="top">
                <p>
Could be: '<strong><em>M</em></strong>' or '                    <strong><em>F</em>'</strong><em></em>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    BirthDate
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="358" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CreditCard
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CardValidity
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="358" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Email
                </p>
            </td>
            <td width="212">
                <p>
                    <strong>String</strong>
                    up to <strong>50</strong> symbols, Unicode
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Towns</strong>
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
            <td width="307" valign="top">
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
            <td width="264" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>50</strong> symbols, Unicode
                </p>
            </td>
            <td width="307" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Offices</strong>
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
            <td width="307" valign="top">
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
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Name
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>40</strong> symbols, Unicode
                </p>
            </td>
            <td width="307" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    ParkingPlaces
                </p>
            </td>
            <td width="264">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    TownId
                </p>
            </td>
            <td width="264">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Towns
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Models</strong>
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
            <td width="269" valign="top">
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
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="269">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Manufacturer
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>50</strong> symbols, Unicode
                </p>
            </td>
            <td width="269" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Model
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>50</strong> symbols, Unicode
                </p>
            </td>
            <td width="269" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    ProductionYear
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>DateTime</strong>
                </p>
            </td>
            <td width="269" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Seats
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="269" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Class
                </p>
            </td>
            <td width="302">
                <p>
                    <strong>String</strong>
                    up to <strong>10</strong> symbols, Unicode
                </p>
            </td>
            <td width="269">
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Consumption
                </p>
            </td>
            <td width="302">
                <p>
                    <strong>Decimal </strong>
up to<strong> 14 </strong>digits<strong> </strong>with                    <strong> 2 </strong>digits<strong> precision </strong>after
                    the decimal point<strong></strong>
                </p>
            </td>
            <td width="269">
                <p>
                    <strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Vehicles</strong>
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
            <td width="307" valign="top">
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
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    ModelId
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Models
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    OfficeId
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Offices
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Mileage
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="307" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Orders</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125" valign="top">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="236" valign="top">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="334" valign="top">
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
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334" valign="top">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    ClientId
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Clients
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    TownId
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Towns
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    VehicleId
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Vehicles
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CollectionDate
                </p>
            </td>
            <td width="236">
                <p>
                    DateTime
                </p>
            </td>
            <td width="334">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CollectionOfficeId
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Offices
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    ReturnDate
                </p>
            </td>
            <td width="236">
                <p>
                    DateTime
                </p>
            </td>
            <td width="334">
                <p>
                    Relationship with table Offices
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    ReturnOfficeId
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
                <p>
                    Relationship with table Offices
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Bill
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Decimal </strong>
up to<strong> 14 </strong>digits<strong> </strong>with                    <strong> 2 </strong>digits<strong> precision </strong>after
                    the decimal point
                </p>
            </td>
            <td width="334">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    TotalMileage
                </p>
            </td>
            <td width="236">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="334">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    1. Database design
</h2>
<p>
    <a name="_gjdgxs"></a>
    Submit all of yours <strong>create</strong> <strong>statements</strong> to
    Judge (only creation of tables).
</p>
<h1>
    Section 2. DML (10 pts)
</h1>
<p>
    <strong><u>Before you start you have to import “DataSet</u></strong>
    <strong>
        <u>
            -RentACar.sql”. If you have created the structure correctly the
            data should be successfully inserted.
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
    <strong>Models</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="144">
                <p>
                    <strong>Manufacturer</strong>
                </p>
            </td>
            <td width="158">
                <p>
                    <strong>Model</strong>
                </p>
            </td>
            <td width="138">
                <p>
                    <strong>ProductionYear</strong>
                </p>
            </td>
            <td width="48">
                <p>
                    <strong>Seats</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p align="center">
                    <strong>Class</strong>
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    <strong>Consumption</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Chevrolet
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    Astro
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    2005-07-27 00:00:00.000
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    12.60
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Toyota
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    Solara
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    2009-10-15 00:00:00.000
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Family
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    13.80
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Volvo
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    S40
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    2010-10-12 00:00:00.000
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Average
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    11.30
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Suzuki
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    Swift
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    2000-02-03 00:00:00.000
                </p>
            </td>
            <td width="48" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    16.20
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Orders</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="55" valign="top">
                <p>
                    <strong>Client Id</strong>
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    <strong>Town Id</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    <strong>Vehicle Id</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    <strong>Collection Date</strong>
                </p>
            </td>
            <td width="78" valign="top">
                <p>
                    <strong>Collection Office Id</strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    <strong>Return Date</strong>
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    <strong>Return Office Id</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    <strong>Bill</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    <strong>Total Mileage</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    17
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    52
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    2017-08-08
                </p>
            </td>
            <td width="78" valign="top">
                <p>
                    30
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    2017-09-04
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    42
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    2360.00
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    7434
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    78
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    17
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    50
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    2017-04-22
                </p>
            </td>
            <td width="78" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    2017-05-09
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    12
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    2326.00
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    7326
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    27
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    13
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    28
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    2017-04-25
                </p>
            </td>
            <td width="78" valign="top">
                <p>
                    21
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    2017-05-09
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    34
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    597.00
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    1880
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
Set <strong>all Model’s</strong> <strong>class</strong> to “    <strong>Luxury</strong>” where the consumption is over <strong>20</strong>.
</p>
<h2>
    4. Delete
</h2>
<p>
Delete <strong>all orders</strong> which don’t have a    <strong>Return Date</strong>.
</p>
<h1>
    Section 3. Querying (40 pts)
</h1>
<p>
    <strong>
        <u>
            You need to start with a fresh dataset, so recreate your DB and
            import the sample data again (DataSet_RentACar.sql).
        </u>
    </strong>
</p>
<h2>
    5. Showroom
</h2>
<p>
Select all <strong>Manufacturers</strong> with their<strong>Models </strong>ordered by <strong>Manufacturer name</strong> (<strong>ascending</strong>) then by <strong>Model Id</strong> (    <strong>descending</strong>).
</p>
<p>
    Required columns:
</p>
<p>
    ● Manufacturer
</p>
<p>
    ● Model
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="174" valign="top">
                <p>
                    <strong>Manufacturer</strong>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    <strong>Model</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    Acura
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    TL
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    Buick
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    Park Avenue
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    Cadillac
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    Eldorado
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Y Generation
</h2>
<p>
Find all <strong>clients</strong> who are born between 1977 and 1994.    <strong>Order</strong> the clients by <strong>First Name </strong>and then
    by<strong> Last Name</strong> in <strong>ascending</strong> order, and
    finally by <strong>Id </strong>(<strong>ascending</strong>).
</p>
<p>
    Required columns:
</p>
<p>
    ● First Name
</p>
<p>
    ● Last Name
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="322" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Agretha
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    Bumphries
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Alene
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    Bernocchi
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Alicea
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    Elphinston
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Spacious Office
</h2>
<p>
Select <strong>all offices</strong> which have a<strong>parking lot </strong>with<strong> more than 25 </strong>places    <strong>.</strong> Order them by <strong>their Town’s name</strong>
    (ascending) and <strong>then</strong> by <strong>Office Id </strong>
    (ascending).
</p>
<p>
    Required columns:
</p>
<p>
    ● TownName
</p>
<p>
    ● OfficeName
</p>
<p>
    ● ParkingPlaces
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="187" valign="top">
                <p>
                    <strong>TownName</strong>
                </p>
            </td>
            <td width="216" valign="top">
                <p>
                    <strong>OfficeName</strong>
                </p>
            </td>
            <td width="133" valign="top">
                <p>
                    <strong>ParkingPlaces</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="187" valign="top">
                <p>
                    Betrr
                </p>
            </td>
            <td width="216" valign="top">
                <p>
                    Robel, Krajcik and Olson
                </p>
            </td>
            <td width="133" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
        <tr>
            <td width="187" valign="top">
                <p>
                    Czarna Dabrówka
                </p>
            </td>
            <td width="216" valign="top">
                <p>
                    Cassin, Heathcote and Kuhlman
                </p>
            </td>
            <td width="133" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
        <tr>
            <td width="187" valign="top">
                <p>
                    Gaohong
                </p>
            </td>
            <td width="216" valign="top">
                <p>
                    Champlin Inc
                </p>
            </td>
            <td width="133" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
        <tr>
            <td width="187" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="216" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="133" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Available Vehicles
</h2>
<p>
    Show all <strong>available</strong> vehicles. (A vehicle is not available
if it is <strong>reserved</strong> <strong>for</strong> an<strong>order</strong> <strong>and</strong> is <strong>not</strong>    <strong>turned</strong> <strong>back</strong> yet)
</p>
<p>
    Required columns:
</p>
<p>
    ● Model
</p>
<p>
    ● Seats
</p>
<p>
    ● Mileage
</p>
<p>
    Order the results by <strong>Mileage</strong> (<strong>ascending</strong>),
then by the Model’s <strong>number of seats</strong> (<strong>descending</strong>) and finally by <strong>Model Id</strong> (    <strong>ascending</strong>).
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>Model</strong>
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    <strong>Seats</strong>
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    <strong>Milage</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Eldorado
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    23188
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    J
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    29281
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Swift
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    29940
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Offices per Town
</h2>
<p>
Select all towns and show the <strong>total number</strong> of    <strong>offices</strong> per <strong>each</strong> <strong>town</strong>.
</p>
<p>
    Required columns:
</p>
<p>
    ● TownName
</p>
<p>
    ● OfficesNumber
</p>
<p>
Order the results by <strong>OfficesNumber</strong><strong>descending</strong> and then by <strong>TownName</strong>    <strong>ascending</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>TownName</strong>
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    <strong>OfficesNumber</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    La Escondida
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Budapest
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Gaohong
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Buyers Best Choice
</h2>
<p>
Select <strong>all</strong> <strong>vehicle models</strong> and show    <strong>how many</strong> <strong>times</strong> each of them have been
    ordered.
</p>
<p>
    Required columns:
</p>
<p>
    ● Manufacturer
</p>
<p>
    ● Model
</p>
<p>
    ● TimesOrdered
</p>
<p>
    Order by total<strong> TimesOrdered</strong> <strong>descending,</strong>
    then by<strong> Manufacturer</strong> <strong>descending and </strong>then
    by<strong> Model</strong> (<strong>ascending</strong>).
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="144" valign="top">
                <p>
                    <strong>Manufacturer</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    <strong>Model</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    <strong>TimesOrdered</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Kia
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Forte
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    15
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Chevrolet
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Astro
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    12
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Toyota
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    Solara
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Kinda Person
</h2>
<p>
Select the <strong>clients</strong> who <strong>have placed</strong> an    <strong>order</strong> and print their <strong>most frequent</strong>
    choice of <strong>vehicle’s class</strong>. If a client’s most frequent
    choice is <strong>equally spread</strong> over <strong>different</strong>
vehicle <strong>classes</strong> show <strong>all the choices</strong> on    <strong>separate</strong> lines.
</p>
<p>
    Required columns:
</p>
<p>
    ● Names - Clients first and last name separated by space
</p>
<p>
    ● Class - Most frequent class choice
</p>
<p>
Order them by <strong>client’s Names</strong>, then by<strong>Class</strong> and <strong>then</strong> by    <strong>Client Id</strong> (all in <strong>ascending</strong> order).
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p>
                    <strong>Names</strong>
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    <strong>Class</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Agnella Adamiec
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Family
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Alayne Morville
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Average
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Albie Pinshon
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Economy
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Albie Pinshon
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Luxury
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Age Groups Revenue
</h2>
<p>
Show the <strong>clients</strong> who have <strong>placed</strong><strong>an</strong> <strong>order</strong> distributed in<strong>age groups</strong> according to the <strong>year</strong> they are    <strong>born</strong> <strong>in</strong>:
</p>
<p>
    ● from 1970 until 1979 - labeled “<strong>70’s</strong>”
</p>
<p>
    ● from 1980 until 1989 - labeled “<strong>80’s</strong>”
</p>
<p>
    ● from 1990 until 1999 - labeled “<strong>90’s</strong>”
</p>
<p>
    ● all clients who doesn’t fall in none of the above groups should be put in
    the group “<strong>Others</strong>”
</p>
<p>
For <strong>each group</strong> show the Revenue (sum of<strong>bills</strong> <strong>paid</strong>) and the    <strong>average</strong> driven <strong>mileage</strong>.
</p>
<p>
    <strong>Order</strong>
    the results by<strong> Age Group </strong>(ascending).
</p>
<p>
    Required columns:
</p>
<p>
    ● Age Group
</p>
<p>
    ● Revenue
</p>
<p>
    ● AverageMileage
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="186" valign="top">
                <p>
                    <strong>AgeGroup</strong>
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    <strong>Revenue</strong>
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    <strong>AverageMileage</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    70's
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    28803.00
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    156277
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    80's
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    26836.00
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    135366
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    90's
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    34684.00
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    147137
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    Others
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    35893.00
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    142563
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Consumption in Mind
</h2>
<p>
Select the<strong> seven most ordered </strong>vehicle<strong> models</strong>. <strong>Group</strong> them by    <strong>manufacturers </strong>and<strong> show only </strong>these who
    have<strong> average </strong>fuel<strong> consumption between 5 </strong>
    and<strong> 15</strong>.
</p>
<p>
    Required columns:
</p>
<p>
    ● Manufacturer
</p>
<p>
    ● AverageConsumption
</p>
<p>
Order them by <strong>Manufacturer</strong><strong>alphabetically </strong>and then by    <strong> AverageConsumption ascending</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>Manufacturer</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>AverageConsumption</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Chevrolet
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    12.600000
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Toyota
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    13.800000
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Volkswagen
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    14.900000
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Debt Hunter
</h2>
<p>
Select the clients who have <strong>placed </strong>an<strong>order</strong> with <strong>invalid credit card</strong>. Show<strong>only</strong> the <strong>first two</strong> clients    <strong>per town</strong> with the biggest <strong>Bill</strong>. An order
is invalid when the <strong>card’s validity date</strong> is    <strong>before</strong> the <strong>collection date</strong>.
</p>
<p>
    Order them by <strong>Town’s Name</strong> <strong>alphabetically</strong>,
    then by <strong>Bill Amount</strong> (<strong>descending</strong>) and then
    by <strong>Client Id</strong> (<strong>ascending</strong>).
</p>
<p>
    Required columns:
</p>
<p>
    ● Names
</p>
<p>
    ● Email
</p>
<p>
    ● Bill
</p>
<p>
    ● Town
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="113" valign="top">
                <p>
                    <strong>Category Name</strong>
                </p>
            </td>
            <td width="231" valign="top">
                <p>
                    <strong>Email</strong>
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    <strong>Bill</strong>
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    <strong>Town</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Mikael MacIlhargy
                </p>
            </td>
            <td width="231" valign="top">
                <p>
                    mmacilhargyn@chicagotribune.com
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    385.00
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Al Ghariyah
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Ulick Rountree
                </p>
            </td>
            <td width="231" valign="top">
                <p>
                    urountree1l@time.com
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    2196.00
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Betrr
                </p>
            </td>
        </tr>
        <tr>
            <td width="113" valign="top">
                <p>
                    Anabal Mistry
                </p>
            </td>
            <td width="231" valign="top">
                <p>
                    amistryg@buzzfeed.com
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    2360.00
                </p>
            </td>
            <td width="108" valign="top">
                <p>
                    Betrr
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Town Statistics
</h2>
<p>
Select <strong>all towns</strong> and show the<strong>distribution</strong> of the <strong>placed orders</strong> between<strong>male</strong> and <strong>female</strong>    <strong>clients in percentages</strong>.
</p>
<p>
    Required columns:
</p>
<p>
    ● TownName
</p>
<p>
    ● MalePercent
</p>
<p>
    ● FemalePercent
</p>
<p>
    Order them by <strong>TownName</strong> <strong>alphabetically </strong>and
    then by<strong> Town Id ascending</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>TownName</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>MalePercent</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>FemalePercent</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Al Ghariyah
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    100
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Betrr
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    50
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    50
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Budapest
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    33
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    66
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
                    ….
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
<h2>
    16. Home Sweet Home
</h2>
<p>
Select all<strong> vehicles </strong>and show their    <strong>current</strong> location:
</p>
<ul>
    <li>
        If a vehicle has <strong>never been on a rent,</strong> it’s location
        should be labeled as “<strong>home</strong>”
    </li>
</ul>
<p>
● If a vehicle has been <strong>turned back</strong> from rent to an<strong>office different</strong> <strong>from</strong> it’s<strong>home</strong> one - print the <strong>name</strong> of the<strong>town</strong> and the <strong>name</strong> of the    <strong>office,</strong> it was <strong>turned back to</strong> in the
following <strong>format</strong> - “<strong>TownName</strong>    <strong>- OfficeName</strong>”
</p>
<p>
● If a <strong>vehicle</strong> is <strong>rented</strong> and still<strong>not turned back, </strong>it’s location should be labeled as “    <strong>on a rent</strong>”
</p>
<p>
    Required columns:
</p>
<p>
    ● Vehicle - print the manufacturer’s name and the model’s name in the
    following format - “<strong>Manufacturer - Model</strong>”
</p>
<p>
    ● Location
</p>
<p>
Order them by vehicle <strong>alphabetically </strong>and then by    <strong> vehicle Id (ascending)</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>Vehicle</strong>
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    <strong>Location</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Acura - TL
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Betrr - Rodriguez, Lebsack and Kub
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Acura - TL
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Gaohong - Dietrich Inc
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Acura - TL
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Oakland - Gusikowski-Lindgren
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Acura - TL
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Seboruco - Padberg, Schuppe and Kassulke
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Acura - TL
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Betrr - Rodriguez, Lebsack and Kub
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="325" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Section 4. Programmability (14 pts)
</h1>
<h2>
    17. Find My Ride
</h2>
<p>
Create a <strong>user defined function</strong> with the name    <strong>udf_CheckForVehicle(@townName, @seatsNumber)</strong> that receives
    a <strong>town’s name</strong> and a <strong>seats number </strong>and
checks if there is <strong>any vehicle</strong> with the<strong>given seats</strong> at an <strong>office</strong> of the    <strong>given</strong> <strong>town</strong>.
</p>
<ul>
    <li>
If <strong>there is</strong> a <strong>vehicle</strong> print the<strong>output</strong> in the following <strong>format</strong>: “        <strong>OfficeName - Model</strong>”.
    </li>
</ul>
<p>
    · If there is no vehicle found print the following message: “NO SUCH
    VEHICLE FOUND”
</p>
<ul>
    <li>
If there is <strong>more than one</strong> vehicle available<strong>order </strong>the results by <strong>office name</strong><strong>ascending</strong> and <strong>return</strong> the        <strong>first</strong> <strong>one</strong>
    </li>
</ul>
<p>
    Parameters:
</p>
<p>
    ● Town’s name
</p>
<p>
    ● Seats number
</p>
<h3>
    Example usage:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="656" colspan="5" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="656" colspan="5" valign="top">
                <p>
                    <strong>SELECT</strong>
                    <strong>dbo.</strong>
                    <strong>udf_ CheckForVehicle ('La Escondida', 9) </strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="224">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="107">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="119">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="206">
                <p>
                    <strong>ReportsCount</strong>
                </p>
            </td>
            <td width="1">
            </td>
        </tr>
        <tr>
            <td width="655" colspan="4" valign="top">
                <p>
                    Green, Jaskolski and Blick - TL
                </p>
            </td>
            <td width="1">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    18. Move a Vehicle
</h2>
<p>
Create a <strong>user defined stored procedure </strong>with the name<strong>usp_MoveVehicle(@vehicleId, @officeId)</strong> that receives a<strong>vehicle’s</strong><strong> Id</strong> and an<strong>office’s</strong> <strong>Id </strong>and changes the vehicle’s    <strong>OfficeId </strong>to the given value <strong>only if</strong> there
are <strong>free</strong> <strong>ParkingPlaces</strong> in the<strong>given office</strong>. If the move is not successful<strong>rollback</strong> any changes and throw an    <strong>exception</strong> with message: “Not enough room in this office!”.
</p>
<p>
    Parameters:
</p>
<p>
    ● Vehicle’s Id
</p>
<p>
    ● Office’s Id
</p>
<h3>
    Example usage:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="678" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="678" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_MoveVehicle 7, 32;</strong>
                </p>
                <p>
                    <strong>SELECT</strong>
                    <strong> OfficeId FROM Vehicles WHERE Id = 7</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="678">
                <p>
                    <strong>Response</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="678" valign="top">
                <p>
                    32
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Move the Tally
</h2>
<p>
    Create a <strong>trigger</strong> which adds the Total Mileage from an
    order to the Mileage of the vehicle from that order.
</p>
<p>
    <strong>IMPORTANT</strong>
: <strong>Total Mileage</strong> should be <strong>added</strong> to the<strong>Mileage</strong> of the vehicle <strong>only</strong> when it is<strong>given</strong> a <strong>value</strong> for the<strong>first</strong> <strong>time</strong> i.e. the trigger should<strong>not</strong> <strong>get fired</strong> if the<strong>Total Mileage</strong> in an order is <strong>edited</strong><strong>after</strong> it is <strong>already</strong>    <strong>having</strong> a <strong>value</strong>.
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
                    <strong>UPDATE</strong>
                    <strong> Orders</strong>
                </p>
                <p>
                    <strong>SET</strong>
                    <strong></strong>
                </p>
                <p>
                    <strong>TotalMileage = 100</strong>
                </p>
                <p>
                    <strong>WHERE</strong>
                    <strong> Id = 40;</strong>
                    <strong></strong>
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
                    (1 row affected)
                </p>
                <p>
                    (1 row affected)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
</h1>