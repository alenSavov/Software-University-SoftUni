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
    Trip Service
</h1>
<p>
    You’ve been an intern at <strong>Krivodol Trip Service LLC </strong>ever
    since you finished high school. The Krivodol Trip Service doesn’t really
    pay much, but it’s the only trip company within a 50km radius in
    northwestern Bulgaria.
</p>
<p>
    You’ve recently been appointed as <strong>Chief Database Engineer</strong>.
    The Chief Database Engineer’s job is to keep track of every single city,
    account, trip, hotel and hotel room – all on a giant ledger (paper, not
    blockchain), which has been passed down for the last 3 generations.
</p>
<p>
    Word around the office is that the company is going to hire a few
    programmers to try and automate the entire process. As you know, the
    holidays are coming up, and of course, you want to go to the overpopulated,
    overpriced and overbuilt seaside just to post a couple of photos of your
rakia-hardened beach body on your Instagram. So, you decided to<strong>design a relational database</strong> in    <strong>SQL Server</strong> and let the new code monkeys take care of
    everything else.
</p>
<h1>
    Section 1. DDL (30 pts)
</h1>
<p>
    You are given an E/R Diagram of the Trip Service:
</p>
<p>
Crеate a database called TripService. You need to create    <strong>6 tables</strong>:
</p>
<p>
    ● Cities – contains information about cities and their countries.
</p>
<p>
    ● Hotels – contains information about the hotels in the system.
</p>
<p>
    ● Rooms<strong> </strong>– contains information about the rooms each hotel
    has.<strong></strong>
</p>
<p>
● Trips<strong> </strong>– contains information about each trip.    <strong></strong>
</p>
<p>
● Accounts – contains information about the trip service users.    <strong></strong>
</p>
<p>
● AccountsTrips<strong> </strong>– contains information about all<strong>accounts</strong> and their <strong>trips</strong>.    <strong></strong>
</p>
<p>
    <strong> Cities</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="320">
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
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="320">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Name
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 20 symbols, Unicode
                </p>
            </td>
            <td width="320">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CountryCode
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String </strong>
                    with <strong>exactly 2</strong> symbols
                </p>
            </td>
            <td width="320">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong> Hotels</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="320">
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
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="320">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Name
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 30 symbols, Unicode
                </p>
            </td>
            <td width="320">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CityId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="320">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Cities<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    EmployeeCount
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="320">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    BaseRate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Decimal </strong>
number with <strong>two-digit</strong> precision                    <strong></strong>
                </p>
            </td>
            <td width="320">
                <p>
                    <strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong> </strong>
</p>
<p>
    <strong>Rooms</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="319">
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
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="319">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Price
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Decimal </strong>
                    number with<strong> two-digit </strong>precision
                </p>
            </td>
            <td width="319">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Type
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 20 symbols, Unicode
                </p>
            </td>
            <td width="319">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Beds
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="319">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    HotelId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="319">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Hotels<strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Trips</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="322">
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
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="322">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    RoomId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="322">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Rooms
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    BookDate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Date</strong>
                </p>
            </td>
            <td width="322">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, <strong>must be</strong>                    <strong>before ArrivalDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    ArrivalDate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Date</strong>
                </p>
            </td>
            <td width="322">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, <strong>must be</strong>                    <strong>before ReturnDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    ReturnDate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Date</strong>
                </p>
            </td>
            <td width="322">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CancelDate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Date</strong>
                </p>
            </td>
            <td width="322">
                <p>
                    <strong></strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Accounts</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="323">
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
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="323">
                <p>
Unique table <strong>identificator</strong>,                    <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    FirstName
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 50 symbols, Unicode
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    MiddleName
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 20 symbols, Unicode<strong></strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    LastName
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 50 symbols, Unicode<strong></strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    CityId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Cities
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    BirthDate
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Date</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Email
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>String</strong>
                    up to 100 symbols<strong></strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, <strong>Unique</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>AccountsTrips</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="125">
                <p>
                    <strong>Column Name</strong>
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Data Type</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>Constraints</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    AccountId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Accounts
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    TripId
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Trips
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    Luggage
                </p>
            </td>
            <td width="268">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="323">
                <p>
                    <strong>NULL</strong>
is <strong>not</strong> allowed, must be                    <strong>at least</strong> 0<strong></strong>
                </p>
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
    <strong><u>Before you start, you must import “</u></strong>
    <u>DataSet-TripService.sql</u>
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
    <strong>Accounts</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="95">
                <p>
                    FirstName
                </p>
            </td>
            <td width="103">
                <p>
                    MiddleName
                </p>
            </td>
            <td width="127" valign="top">
                <p>
                    LastName
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    CityId
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    BirthDate
                </p>
            </td>
            <td width="179" valign="top">
                <p>
                    Email
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    John
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Smith
                </p>
            </td>
            <td width="127" valign="top">
                <p>
                    Smith
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    34
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    1975-07-21
                </p>
            </td>
            <td width="179" valign="top">
                <p>
                    j_smith@gmail.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Gosho
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    NULL
                </p>
            </td>
            <td width="127" valign="top">
                <p>
                    Petrov
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    11
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    1978-05-16
                </p>
            </td>
            <td width="179" valign="top">
                <p>
                    g_petrov@gmail.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Ivan
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Petrovich
                </p>
            </td>
            <td width="127" valign="top">
                <p>
                    Pavlov
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    59
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    1849-09-26
                </p>
            </td>
            <td width="179" valign="top">
                <p>
                    i_pavlov@softuni.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Friedrich
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    Wilhelm
                </p>
            </td>
            <td width="127" valign="top">
                <p>
                    Nietzsche
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    1844-10-15
                </p>
            </td>
            <td width="179" valign="top">
                <p>
                    f_nietzsche@softuni.bg
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Trips</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="71" valign="top">
                <p>
                    RoomId
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    BookDate
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    ArrivalDate
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    ReturnDate
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    CancelDate
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2015-04-12
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    2015-04-14
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2015-04-20
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2015-02-02
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2015-07-07
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    2015-07-15
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2015-07-22
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2015-04-29
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2013-07-17
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    2013-07-23
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2013-07-24
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    104
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2012-03-17
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    2012-03-31
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2012-04-01
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2012-01-10
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    109
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    2017-08-07
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    2017-08-28
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    2017-08-29
                </p>
            </td>
            <td width="103" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Update
</h2>
<p>
Make all rooms’ prices <strong>14% more expensive</strong> where the    <strong>hotel ID </strong>is either <strong>5</strong>, <strong>7</strong>
    or <strong>9</strong>.
</p>
<h2>
    4. Delete
</h2>
<p>
Delete <strong>all </strong>of Account ID <strong>47</strong>’s    <strong>account’s</strong> <strong>trips </strong>from the mapping table.
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
    <u>DataSet-TripService.sql</u>
    <strong><u>).</u></strong>
</p>
<h2>
    5. Bulgarian Cities
</h2>
<p>
    Select all <strong>cities</strong> in <strong>Bulgaria</strong>. Order them
    by <strong>city name</strong>.
</p>
<h3>
    Examples
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
                    <strong>Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    15
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Blagoevgrad
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Burgas
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Dobrich
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    18
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Gabrovo
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
    6. People Born After 1991
</h2>
<p>
    Select all <strong>full names</strong> and <strong>birth years</strong>
    from accounts,<strong> </strong>who are born after <strong>1991</strong>.
</p>
<p>
    Order them by <strong>birth year</strong> <strong>(descending)</strong>,
    then by first name <strong>(ascending)</strong>. Keep in mind that middle
    names can be <strong>NULL</strong> 😊
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="170" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    <strong>BirthYear</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Claudia Keely Lotze
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1994
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Jourdan Marketa Fawcitt
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1994
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Nealson Waiter Villalta
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1994
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Palm Van
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1994
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Xever Leoine Santi
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1994
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    Cornell Alidia Grieg
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    1993
                </p>
            </td>
        </tr>
        <tr>
            <td width="170" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="79" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. EEE-Mails
</h2>
<p>
Select <strong>accounts</strong> whose <strong>emails</strong>    <strong>start</strong> with the <strong>letter</strong> “<strong>e</strong>
”. Select their <strong>first and last name</strong>, their<strong>birthdate</strong> in the format "MM-dd-yyyy", and their    <strong>city name</strong>.
</p>
<p>
    Order them by <strong>city name</strong> <strong>(descending)</strong>
</p>
<h3>
    Examples
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
                    <strong>BirthDate</strong>
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    <strong>Hometown</strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    <strong>Email</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Evvie
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Covolini
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    01-11-1979
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Wolverhampton
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    e_covolini@softuni.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Eward
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Prigg
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    12-10-1982
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Shumen
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    e_prigg@gmail.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Eadith
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Gull
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    03-03-1983
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Haskovo
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    e_gull@outlook.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="84" valign="top">
                <p>
                    Edgardo
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    Slessar
                </p>
            </td>
            <td width="90" valign="top">
                <p>
                    12-29-1983
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Glasgow
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    e_slessar@outlook.com
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. City Statistics
</h2>
<p>
Select all <strong>cities</strong> with the<strong>count of hotels</strong> in them. Order them by the<strong>hotel count (descending)</strong>, then by<strong>city name</strong>. Include cities, which have <strong>no</strong>    <strong>hotels</strong> in them as well.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="111" valign="top">
                <p>
                    <strong>City</strong>
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    <strong>Hotels</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Belfast
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Cardiff
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Chelyabinsk
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Phoenix
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    San Francisco
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Seattle
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Veliko Tarnovo
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    Houston
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    10
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Expensive First-Class Rooms
</h2>
<p>
Find all First-Class rooms and select the <strong>Id</strong>,<strong>Price</strong>, <strong>Hotel name</strong> and    <strong>City name</strong>.
</p>
<p>
Order them by <strong>Price (descending)</strong>, then by    <strong>Room ID</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="44" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    <strong>Price</strong>
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    <strong>Hotel</strong>
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    <strong>City</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    51
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    90.90
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Recreation Hotel &amp; Spa
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Ruse
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    863
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    90.90
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Exalted Resort &amp; Spa
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Volgograd
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    427
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    90.20
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Stargaze Hotel &amp; Spa
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    New York
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    727
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    90.20
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Enterprise Hotel
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Yekaterinburg
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    777
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    90.00
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Nimbus Hotel &amp; Spa
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Chelyabinsk
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    729
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    89.90
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    History Resort
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Yekaterinburg
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    512
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    89.70
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Nimbus Hotel &amp; Spa
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    San Diego
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    901
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    89.70
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Diorama Resort
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Tyumen
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    116
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    89.50
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    Holiday Resort
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Blagoevgrad
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="160" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Longest and Shortest Trips
</h2>
<p>
Find the <strong>longest</strong> and <strong>shortest</strong><strong>trip</strong> for each <strong>account</strong>, in<strong>days</strong>. Filter the results to <strong>accounts</strong> with<strong>no middle name </strong>and    <strong>trips, which aren’t cancelled </strong>(<strong>CancelDate</strong>
    is <strong>null</strong>).
</p>
<p>
Order the results by <strong>Longest Trip days</strong> (    <strong>descending),</strong> then by<strong> Account ID.</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="83" valign="top">
                <p>
                    <strong>AccountId</strong>
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    <strong>FullName</strong>
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    <strong>LongestTrip</strong>
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    <strong>ShortestTrip</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    40
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    Winna Maisey
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    47
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    Evvie Covolini
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    56
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    Tillie Windress
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    57
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    Eadith Gull
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Metropolis
</h2>
<p>
    Find the <strong>top 5</strong> cities, which have the most registered
accounts in them. Order them by the <strong>count of</strong>    <strong>accounts (descending)</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="37" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    <strong>City</strong>
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    <strong>Country</strong>
                </p>
            </td>
            <td width="77" valign="top">
                <p>
                    <strong>Accounts</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    76
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Tyumen
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    RU
                </p>
            </td>
            <td width="77" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    12
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Haskovo
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    BG
                </p>
            </td>
            <td width="77" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    33
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Belfast
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    UK
                </p>
            </td>
            <td width="77" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="77" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Romantic Getaways
</h2>
<p>
Find all accounts, which have had <strong>one or more</strong> trips to    <strong>a hotel in</strong> <strong>their hometown</strong>.
</p>
<p>
Order them by the <strong>trips count (descending)</strong>, then by    <strong>Account ID</strong>.
</p>
<h3>
    Examples
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
                    <strong>Email</strong>
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    <strong>City</strong>
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    <strong>Trips</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    50
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    t_joules@mail.com
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    New York
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    19
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    m_stango@yahoo.com
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Burgas
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="36" valign="top">
                <p>
                    48
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    n_revitt@softuni.bg
                </p>
            </td>
            <td width="94" valign="top">
                <p>
                    Bradford
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    1
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
            <td width="94" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Lucrative Destinations
</h2>
<p>
    Find the <strong>top 10</strong> cities’ <strong>Total Revenue Sum</strong>
(<strong>Hotel Base Rate + Room Price</strong>) and    <strong>trip count</strong>.
</p>
<p>
Count only trips, which were <strong>booked</strong>    <strong>in 2016</strong>.
</p>
<p>
Order them by <strong>Total Revenue (descending)</strong>, then by    <strong>Trip count (descending)</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="37" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    <strong>Total Revenue</strong>
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    <strong>Trips</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    56
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    Seattle
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    795.80
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    47
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    Dallas
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    649.40
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    17
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    Vratsa
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    536.60
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    28
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    Cardiff
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    504.30
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    65
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    Chelyabinsk
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    386.30
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    3
                </p>
            </td>
        </tr>
        <tr>
            <td width="37" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="93" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Trip Revenues
</h2>
<p>
Find all trips’ <strong>revenue</strong><strong>(hotel base rate + room price)</strong>. If a trip is<strong>canceled</strong>, its <strong>revenue</strong> is<strong>always 0</strong>. Extract the <strong>trip’s ID</strong>, the<strong>hotel’s name</strong>, the <strong>room type</strong> and the    <strong>revenue</strong>.
</p>
<p>
Order the results by <strong>Room type</strong>, then by the    <strong>Trip ID</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="83" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    <strong>HotelName</strong>
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    <strong>RoomType</strong>
                </p>
            </td>
            <td width="75" valign="top">
                <p>
                    <strong>Revenue</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    Cloud Resort
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="75" valign="top">
                <p>
                    51.10
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    14
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    Lethargy Hotel &amp; Spa
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="75" valign="top">
                <p>
                    39.90
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    43
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    Courtyard Hotel
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="75" valign="top">
                <p>
                    82.20
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    49
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    Ranch Hotel
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    Economy
                </p>
            </td>
            <td width="75" valign="top">
                <p>
                    0.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    …
                </p>
            </td>
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
            <td width="75" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Top Travelers
</h2>
<p>
Find the<strong> top</strong> <strong>traveler</strong> for<strong>each country</strong>. The top traveler is the<strong>account</strong>, which has the <strong>most trips</strong> to that    <strong>country</strong>.
</p>
<p>
    Order the results by the <strong>count of trips (descending)</strong>, then
    by <strong>Account ID</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="83" valign="top">
                <p>
                    <strong>AccountId</strong>
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    <strong>Email</strong>
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    <strong>CountryCode</strong>
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    <strong>Trips</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    80
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    a_flucks@gmail.com
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    RU
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    14
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    t_ludwikiewicz@outlook.com
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    UK
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    32
                </p>
            </td>
            <td width="198" valign="top">
                <p>
                    a_roskell@softuni.bg
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    US
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    …
                </p>
            </td>
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
            <td width="52" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    16. Luggage Fees
</h2>
<p>
    Apart from its base rate and room price, each hotel also has a hidden
    “luggage fee”. It’s in the terms and conditions, but nobody reads those…
</p>
<p>
The luggage fee only comes into action if a trip has<strong>more than 5 items of luggage</strong> and it’s equal to the    <strong>number of luggage items,</strong> <strong>multiplied by 5</strong>.
</p>
<p>
    Take into account only trips, which have <strong>more than 0</strong>
    luggage.
</p>
<p>
Order the results by the <strong>count of luggage</strong>    <strong>(descending)</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="57" valign="top">
                <p>
                    <strong>TripId</strong>
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    <strong>Luggage</strong>
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    <strong>Fee</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    632
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $35
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    617
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    833
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    264
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    273
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    306
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    323
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    330
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    428
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    457
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $30
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    405
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    $0
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="44" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    17. GDPR Violation
</h2>
<p>
    Retrieve the following information about each trip:
</p>
<ul>
    <li>
        Trip ID
    </li>
    <li>
        Account Full Name
    </li>
    <li>
        From – Account hometown
    </li>
    <li>
        To – Hotel city
    </li>
    <li>
Duration – the <strong>duration</strong> between the<strong>arrival date</strong> and <strong>return date</strong> in        <strong>days</strong>. If a trip is cancelled, the value is “Canceled”
    </li>
</ul>
<p>
Order the results by <strong>full name</strong>, then by    <strong>Trip ID</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="44" valign="top">
                <p>
                    <strong>Id</strong>
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    <strong>Full Name</strong>
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    <strong>From</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <strong>To</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    <strong>Duration</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    273
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Adah Douglass Lathaye
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    Stara Zagora
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    Cardiff
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    Canceled
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    491
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Adah Douglass Lathaye
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    Stara Zagora
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    Houston
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    4 days
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    776
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Adah Douglass Lathaye
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    Stara Zagora
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    Chelyabinsk
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    3 days
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
                <p>
                    133
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Allissa Rickey Gigg
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    Austin
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    Veliko Tarnovo
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    6 days
                </p>
            </td>
        </tr>
        <tr>
            <td width="44" valign="top">
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
            <td width="76" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Section 4. Programmability (14 pts)
</h1>
<h2>
    18. Available Room
</h2>
<p>
Create a <strong>user defined function</strong>, named    <strong>udf_GetAvailableRoom(@HotelId, @Date, @People)</strong>, that
    receives a <strong>hotel ID</strong>, a desired<strong> date</strong>, and
    the count of <strong>people</strong> that are going to be signing up.
</p>
<p>
    The total price of the room can be calculated by using this formula:
</p>
<p>
    · (HotelBaseRate + RoomPrice) * PeopleCount
</p>
<p>
    The function should find a suitable room in the provided hotel, based on
    these conditions:
</p>
<ul>
    <li>
        The room must <strong>not be already occupied</strong>. A room is
occupied if the <strong>date</strong> the customers want to book is<strong>between</strong> the <strong>arrival</strong> and<strong>return dates </strong>of a trip to that room and the trip is        <strong>not canceled</strong>.
    </li>
    <li>
The room must be <strong>in</strong> the provided        <strong>hotel</strong>.
    </li>
    <li>
The room must have enough <strong>beds</strong> for all the        <strong>people</strong>.
    </li>
</ul>
<p>
    If any rooms in the desired hotel <strong>satisfy </strong>the customers’
    conditions, find the <strong>highest priced room (by total price) </strong>
    of all of them and provide them with that room.
</p>
<p>
The function must return a <strong>message</strong> in the    <strong>format</strong>:
</p>
<p>
    · “Room {Room Id}: {Room Type} ({Beds} beds) - ${Total Price}”
</p>
<p>
    If no room could be found, the function should return “No rooms available”.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>SELECT</strong>
                    <strong>
                        dbo.udf_GetAvailableRoom(112, '2011-12-17', 2)
                    </strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>Room 211: First Class (5 beds) - $202.80</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>Query</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>SELECT</strong>
                    <strong>
                        dbo.udf_GetAvailableRoom(94, '2015-07-26', 3)
                    </strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="489" valign="top">
                <p>
                    <strong>No rooms available</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Switch Room
</h2>
<p>
Create a <strong>user defined stored procedure</strong>, named<strong>usp_SwitchRoom(@TripId, @TargetRoomId)</strong>, that receives a<strong>trip</strong> and a <strong>target room</strong>, and attempts to<strong>move</strong> the <strong>trip</strong> to    <strong>the target room</strong>. A room will only be switched if all of
    these conditions are true:
</p>
<ul>
    <li>
If the <strong>target room </strong>ID is in        <strong>a different hotel</strong>, than the <strong>trip</strong> is
        in, <strong>raise an exception</strong> with the message “Target room
        is in another hotel!”.
    </li>
    <li>
If the <strong>target room </strong>doesn’t have<strong>enough beds</strong> for all the        <strong>trip’s accounts</strong>, <strong>raise an exception</strong>
        with the message “Not enough beds in target room!”.
    </li>
</ul>
<p>
If all the above conditions pass, <strong>change </strong>the    <strong>trip’s room ID</strong> to the <strong>target room ID</strong>.
</p>
<h3>
    Example usage:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="329" valign="top">
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
            <td width="329" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_SwitchRoom 10, 11</strong>
                </p>
                <p>
                    <strong>SELECT</strong>
                    <strong> RoomId FROM Trips WHERE Id = 10</strong>
                    <strong></strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    11
                </p>
            </td>
        </tr>
        <tr>
            <td width="329" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_SwitchRoom 10, 7</strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    Target room is in another hotel!
                </p>
            </td>
        </tr>
        <tr>
            <td width="329" valign="top">
                <p>
                    <strong>EXEC</strong>
                    <strong> usp_SwitchRoom 10, 8</strong>
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    Not enough beds in target room!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Section 5. Bonus (6 pts)
</h1>
<h2>
    20. Cancel Trip
</h2>
<p>
Create a <strong>trigger</strong>, which fires<strong>when a trip is deleted</strong>. Instead of deleting a trip,<strong>set its cancel date to the current date</strong> and<strong>IGNORE </strong>trips, which have    <strong>already been canceled</strong>.
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
                    DELETE FROM Trips
                </p>
                <p>
                    WHERE Id IN (48, 49, 50)
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
                    <strong>(2 rows affected)</strong>
                </p>
                <p>
                    <strong></strong>
                </p>
                <p>
                    <strong>(3 rows affected)</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>