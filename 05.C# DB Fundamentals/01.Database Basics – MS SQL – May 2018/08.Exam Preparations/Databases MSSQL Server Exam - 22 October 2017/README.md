<h1 align="center">
    Database Basics MS SQL Exam – 22 Oct 2017
</h1>
<p>
    Exam problems for the
    <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">
        “Database Basics” course @ SoftUni
    </a>
    .
</p>
<p>
    Submit your solutions in the SoftUni Judge system at
    <a href="https://judge.softuni.bg/Contests/819">
        https://judge.softuni.bg/Contests/819
    </a>
</p>
<h1 align="center">
    Report Service
</h1>
<p>
    <em>
        --Mrs. F.Y, the city’s mayor, came up with the idea to create an online
        platform where all the citizens can report about different problems and
        a special organization will work to resolve all the incoming reports.
        This organization has a few departments each of which is responsible
        for a set of problem’s categories in which users can submit a report.
        In each department there are employees who get assigned to a report. Of
        course
    </em>
    <em>
        , this huge platform needs a reliable database to store and process the
        information and Mrs. Y has asked for the best specialist in this area.
        That’s why you got chosen! Congratulations and good luck!
    </em>
</p>
<h1>
    Section 1. DDL (30 pts)
</h1>
<p>
    You have been given the E/R Diagram of the Report Service:
</p>
<p align="center">
    <img
        border="0"
        width="752"
        height="392"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image002.jpg"
    />
</p>
<p>
Crеate a database called <strong>ReportService</strong>. You need to create    <strong>6 tables</strong>:
</p>
<p>
    ● <strong>Users</strong> – contains information about the people who submit
    reports
</p>
<p>
    ● <strong>Reports</strong> - contains information about the submitted
    problems
</p>
<p>
    ● <strong>Employees</strong> – contains information about the people
    employees who work on reports
</p>
<p>
    ● <strong>Departments</strong> – contains information about the departments
</p>
<p>
    ● <strong>Categories</strong> – contains information about categories
    inside the departments.
</p>
<p>
    ● <strong>Status </strong>- contains information about the possible
    statuses of a report
</p>
<p>
    <strong>Users</strong>
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
                    Username
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
                    is <strong>not</strong> allowed, <strong>Unique</strong>
                    values only
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Password
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>String</strong>
                    up to 50 symbols, Unicode
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
                    Name
                </p>
            </td>
            <td width="212" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>50</strong> symbols, Unicode<strong></strong>
                </p>
            </td>
            <td width="358" valign="top">
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
                    DateTime
                </p>
            </td>
            <td width="358" valign="top">
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
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
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
    <strong>Departments</strong>
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
    <strong>Employees</strong>
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
                    Unique table identificator, <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    FirstName
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>25</strong> symbols, Unicode
                </p>
            </td>
            <td width="269" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    LastName
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>25</strong> symbols, Unicode
                </p>
            </td>
            <td width="269" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Gender
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>Character</strong>
                    with <strong>exactly</strong> 1 symbol
                </p>
            </td>
            <td width="269" valign="top">
                <p>
Could be: '<strong><em>M</em></strong>' or '                    <strong><em>F</em></strong>'<em></em>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    BirthDate
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    DateTime
                </p>
            </td>
            <td width="269" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Age
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
                    DepartmentId
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
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Departments
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Categories</strong>
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
                    up to <strong>50</strong> symbols
                </p>
            </td>
            <td width="307" valign="top">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125">
                <p>
                    DepartmentId
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
                    Relationship with table Departments
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
    <strong>Status</strong>
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
                    Unique table identificator, <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    Label
                </p>
            </td>
            <td width="264" valign="top">
                <p>
                    <strong>String</strong>
                    up to <strong>30</strong> symbols
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
    <strong>Reports</strong>
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
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="324" valign="top">
                <p>
                    Unique table identificator, <strong>Identity</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CategoryId
                </p>
            </td>
            <td width="247">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="324">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Categories
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    StatusId
                </p>
            </td>
            <td width="247">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="324">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Status
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    OpenDate
                </p>
            </td>
            <td width="247">
                <p>
                    DateTime
                </p>
            </td>
            <td width="324">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    CloseDate
                </p>
            </td>
            <td width="247">
                <p>
                    DateTime
                </p>
            </td>
            <td width="324">
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
                    <strong>String</strong>
                    up to <strong>200</strong> symbols
                </p>
            </td>
            <td width="324" valign="top">
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    UserId
                </p>
            </td>
            <td width="247">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="324">
                <p>
                    <strong>NULL</strong>
                    is <strong>not</strong> allowed, Relationship with table
                    Users
                </p>
            </td>
        </tr>
        <tr>
            <td width="125" valign="bottom">
                <p>
                    EmployeeId
                </p>
            </td>
            <td width="247">
                <p>
                    <strong>Integer</strong>
                    from <strong>0</strong> to <strong>2,147,483,647</strong>
                </p>
            </td>
            <td width="324">
                <p>
                    Relationship with table Employees
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
    <strong><u>Before you start you have to import “DataSet</u></strong>
    <strong>
        <u>
            -ReportService.sql”. If you have created the structure correctly
            the data should be successfully inserted.
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
    should be auto-generated. Replace names that relate to other tables with
    the appropriate ID (look them up manually, there is no need to perform
    table joins).
</p>
<p>
    <strong>Emlpoyees</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="144">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="150">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="72">
                <p>
                    <strong>Gender</strong>
                </p>
            </td>
            <td width="176">
                <p>
                    <strong>Birthdate</strong>
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    <strong>Department Id</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="144">
                <p>
                    Marlo
                </p>
            </td>
            <td width="150">
                <p>
                    O’Malley
                </p>
            </td>
            <td width="72">
                <p>
                    M
                </p>
            </td>
            <td width="176">
                <p>
                    9/21/1958
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Infrastructure
                </p>
            </td>
        </tr>
        <tr>
            <td width="144">
                <p>
                    Niki
                </p>
            </td>
            <td width="150">
                <p>
                    Stanaghan
                </p>
            </td>
            <td width="72">
                <p>
                    F
                </p>
            </td>
            <td width="176">
                <p>
                    11/26/1969
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Emergency
                </p>
            </td>
        </tr>
        <tr>
            <td width="144">
                <p>
                    Ayrton
                </p>
            </td>
            <td width="150">
                <p>
                    Senna
                </p>
            </td>
            <td width="72">
                <p>
                    M
                </p>
            </td>
            <td width="176">
                <p>
                    03/21/1960
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Event Management
                </p>
            </td>
        </tr>
        <tr>
            <td width="144">
                <p>
                    Ronnie
                </p>
            </td>
            <td width="150">
                <p>
                    Peterson
                </p>
            </td>
            <td width="72">
                <p>
                    M
                </p>
            </td>
            <td width="176">
                <p>
                    02/14/1944
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Event Management
                </p>
            </td>
        </tr>
        <tr>
            <td width="144">
                <p>
                    Giovanna
                </p>
            </td>
            <td width="150">
                <p>
                    Amati
                </p>
            </td>
            <td width="72">
                <p>
                    F
                </p>
            </td>
            <td width="176">
                <p>
                    07/20/1959
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Roads Maintenance
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Reports</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="108">
                <p>
                    <strong>CategoryId</strong>
                </p>
            </td>
            <td width="83">
                <p>
                    <strong>StatusId</strong>
                </p>
            </td>
            <td width="85">
                <p>
                    <strong>OpenDate</strong>
                </p>
            </td>
            <td width="85">
                <p>
                    <strong>CloseDate</strong>
                </p>
            </td>
            <td width="187" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    <strong>UserId</strong>
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    <strong>EmployeeId</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="108" valign="top">
                <p>
                    Snow Removal
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    waiting
                </p>
            </td>
            <td width="85">
                <p>
                    04/13/2017
                </p>
            </td>
            <td width="85">
            </td>
            <td width="187" valign="top">
                <p>
                    Stuck Road on Str.133
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="108" valign="top">
                <p>
                    Sports Events
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    completed
                </p>
            </td>
            <td width="85">
                <p>
                    09/05/2015
                </p>
            </td>
            <td width="85">
                <p>
                    12/06/2015
                </p>
            </td>
            <td width="187" valign="top">
                <p>
                    Charity trail running
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="108" valign="top">
                <p>
                    Dangerous Building
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    in progress
                </p>
            </td>
            <td width="85">
                <p>
                    09/07/2015
                </p>
            </td>
            <td width="85">
            </td>
            <td width="187" valign="top">
                <p>
                    Falling bricks on Str.58
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="108" valign="top">
                <p>
                    Streetlight
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    completed
                </p>
            </td>
            <td width="85">
                <p>
                    07/03/2017
                </p>
            </td>
            <td width="85">
                <p>
                    07/06/2017
                </p>
            </td>
            <td width="187" valign="top">
                <p>
                    Cut off streetlight on Str.11
                </p>
            </td>
            <td width="54" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="87" valign="top">
                <p>
                    1
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
Switch <strong>all report’s</strong> <strong>status</strong> to “<strong>in progress</strong>” where it is <strong>currently</strong> “<strong>waiting</strong>” for the “<strong>Streetlight</strong>”    <strong>category</strong> (look up the category ID and status ID’s
    manually, there is no need to use table joins).
</p>
<h2>
    4. Delete
</h2>
<p>
Delete <strong>all reports</strong> who have a <strong>status</strong> “    <strong>blocked</strong>”.
</p>
<h1>
    Section 3. Querying (40 pts)
</h1>
<p>
    <strong>
        <u>
            You need to start with a fresh dataset, so recreate your DB and
            import the sample data again (DataSet_ReportService.sql).
        </u>
    </strong>
</p>
<p>
    <strong><u>If not specified the ordering will be ascending.</u></strong>
</p>
<h2>
    5. Users by Age
</h2>
<p>
    Select all <strong>Usernames</strong> with their <strong>age</strong>
ordered by <strong>age</strong> (<strong>ascending</strong>) then by    <strong>username</strong> (<strong>descending</strong>).
</p>
<p>
    Required columns:
</p>
<p>
    ● Username
</p>
<p>
    ● Age
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="174" valign="top">
                <p>
                    <strong>Username</strong>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    <strong>Age</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    5omarkwelleyc
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    19
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    bkaasg
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    21
                </p>
            </td>
        </tr>
        <tr>
            <td width="174" valign="top">
                <p>
                    dfinicj5
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    24
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
    6. Unassigned Reports
</h2>
<p>
Find all <strong>reports</strong> that <strong>don’t </strong>have an<strong>assigned employee</strong>. <strong>Order</strong> the results by<strong>open date</strong> in <strong>ascending</strong> order, then by    <strong>description </strong>(<strong>ascending</strong>).
</p>
<p>
    Required columns:
</p>
<p>
    ● Description
</p>
<p>
    ● OpenDate
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="322" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    <strong>OpenDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Art exhibition on July 24
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    2014-12-17 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Stuck Road on Str.133
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    2015-06-20 00:00:00.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="322" valign="top">
                <p>
                    Burned facade on Str.560
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    2015-08-26 00:00:00.000
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
    7. Employees &amp; Reports
</h2>
<p>
Select <strong>only employees</strong> who <strong>have</strong> an<strong>assigned</strong> <strong>report</strong> and show<strong>all reports</strong> of <strong>each </strong>found<strong> employee</strong>. Show the open date column in the format “    <strong>yyyy-MM-dd</strong>”. Order them by <strong>employee id</strong>
    (ascending) <strong>then</strong> by <strong>open date </strong>(ascending)
    and then by <strong>report Id</strong> (again ascending).
</p>
<p>
    Required columns:
</p>
<p>
    ● FirstName
</p>
<p>
    ● LastName
</p>
<p>
    ● Description
</p>
<p>
    ● OpenDate
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="86" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    <strong>LastName</strong>
                </p>
            </td>
            <td width="245" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    <strong>OpenDate</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="86" valign="top">
                <p>
                    Marlo
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    O'Malley
                </p>
            </td>
            <td width="245" valign="top">
                <p>
                    Fallen streetlight columns on Str.14
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    2017-09-12
                </p>
            </td>
        </tr>
        <tr>
            <td width="86" valign="top">
                <p>
                    Gregory
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    Stithe
                </p>
            </td>
            <td width="245" valign="top">
                <p>
                    Stuck Road on Str.14
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    2017-04-13
                </p>
            </td>
        </tr>
        <tr>
            <td width="86" valign="top">
                <p>
                    Humphrey
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    Tamblyn
                </p>
            </td>
            <td width="245" valign="top">
                <p>
                    Burned facade on Str.793
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    2016-07-20
                </p>
            </td>
        </tr>
        <tr>
            <td width="86" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="245" valign="top">
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
    8. Most reported Category
</h2>
<p>
Select <strong>ALL categories</strong> and <strong>order</strong> them<strong>by</strong> the number of<strong> reports</strong><strong>per category</strong> in <strong>descending</strong> order and then    <strong>alphabetically</strong> by name.
</p>
<p>
    Required columns:
</p>
<p>
    ● CategoryName
</p>
<p>
    ● ReportsNumber
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>CategoryName</strong>
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    <strong>ReportsNumber</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Recycling
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Snow Removal
                </p>
            </td>
            <td width="114" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Streetlight
                </p>
            </td>
            <td width="114" valign="top">
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
            <td width="114" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Employees in Category
</h2>
<p>
    Select <strong>ALL categories</strong> and the number of employees in each
    category and <strong>order</strong> them <strong>alphabetically</strong> by
    category name.
</p>
<p>
    Required columns:
</p>
<p>
    ● CategoryName
</p>
<p>
    ● Employees Number
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    <strong>CategoryName</strong>
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    <strong>Employees Number</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Animal in Danger
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    3
                </p>
            </td>
        </tr>
        <tr>
            <td width="132" valign="top">
                <p>
                    Art Events
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
                    Dangerous Building
                </p>
            </td>
            <td width="138" valign="top">
                <p>
                    1
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
    10. Users per Employee
</h2>
<p>
Select <strong>all</strong> <strong>employees</strong> and show how many    <strong>unique</strong> users each of them have served to.
</p>
<p>
    Required columns:
</p>
<p>
    ● Employee’s name - Full name consisting of FirstName and LastName and a
    space between them
</p>
<p>
    ● User’s number
</p>
<p>
Order by Users Number <strong>descending</strong> and then by Name    <strong>ascending</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="144" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    <strong>Users Number</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Bron Ledur
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    3
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Adelind Benns
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="144" valign="top">
                <p>
                    Dick Wentworth
                </p>
            </td>
            <td width="102" valign="top">
                <p>
                    2
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
        </tr>
    </tbody>
</table>
<h2>
    11. Emergency Patrol
</h2>
<p>
Select <strong>all</strong> <strong>reports</strong> which    <strong>satisfy</strong> <strong>all</strong> the following criteria:
</p>
<p>
    ● are <strong>not</strong> <strong>closed</strong> yet (they don’t have a
    CloseDate)
</p>
<p>
● the <strong>description</strong> is longer than<strong>20 symbols</strong> and the word “    <strong>str” is mentioned anywhere</strong>
</p>
<p>
● are <strong>assigned</strong> to one of the <strong>following</strong>    <strong>departments</strong>: “Infrastructure”, “Emergency”, “Roads
    Maintenance”
</p>
<p>
    <strong>Order</strong>
    the results by<strong> OpenDate </strong>(ascending), <strong>then</strong>
    by <strong>Reporter’s Email </strong>(ascending)<strong> </strong>and then
    by <strong>Report Id</strong> (ascending).
</p>
<p>
    Required columns:
</p>
<p>
    ● OpenDate
</p>
<p>
    ● Description
</p>
<p>
    ● Reporter Email
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="186" valign="top">
                <p>
                    <strong>OpenDate</strong>
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    <strong>Description</strong>
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    <strong>Reporter Email</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    2015-06-20 00:00:00.000
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    Stuck Road on Str.133
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    bkaasg@g.co
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    2015-08-26 00:00:00.000
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    Burned facade on Str.560
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    dpennid@arizona.edu
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    2015-11-17 00:00:00.000
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    Gigantic crater ?n Str.19
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    ealpine0@squarespace.com
                </p>
            </td>
        </tr>
        <tr>
            <td width="186" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Birthday Report
</h2>
<p>
Select <strong>all categories</strong> in which users have<strong>submitted</strong> a <strong>report</strong> on<strong>their birthday</strong>. Order them by name    <strong>alphabetically.</strong>
</p>
<p>
    Required columns:
</p>
<p>
    ● Category Name
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="139" valign="top">
                <p>
                    <strong>Category Name</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Dangerous Trees
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Homeless Elders
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Snow Removal
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Numbers Coincidence
</h2>
<p>
    Select all<strong> unique usernames</strong> which:
</p>
<p>
    ● <strong>starts</strong> with a <strong>digit</strong> and have reported
in a <strong>category</strong> with <strong>id equal</strong> to the    <strong>digit</strong>
</p>
<p>
    <strong><u>OR</u></strong>
</p>
<p>
    ● <strong>ends</strong> with a <strong>digit</strong> and have reported in
a <strong>category</strong> with <strong>id equal</strong> to the    <strong>digit</strong>
</p>
<p>
    Required columns:
</p>
<p>
    ● Username
</p>
<p>
    Order them <strong>alphabetically</strong>.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>Username</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    1qiskowf
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    5omarkwelleyc
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    fdenrico3
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Open/Closed Statistics
</h2>
<p>
Select <strong>all</strong> <strong>employees </strong>who<strong> </strong>have<strong> at</strong> <strong>least</strong>    <strong>one</strong> assigned<strong> </strong>closed<strong> or </strong>
open<strong> </strong>report <strong>through</strong> year    <strong>2016 </strong>and <strong>their total sum</strong>. Open reports
don’t have a <strong>CloseDate</strong>. Reports that have been    <strong>opened before</strong> 2016 but were <strong>closed in</strong>
2016 are counted as <strong>closed only</strong>! Order by    <strong>Name</strong> (ascending), and then by employee Id
</p>
<p>
    Required columns:
</p>
<p>
    ● Name - name - Full name consisting of FirstName and LastName and a space
    between them
</p>
<p>
    ● Closed /Open reports number
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>Closed Open Reports</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Dick Wentworth
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    1/1
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Eldon Gaze
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    0/1
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Hewet Juschke
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    0/1
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
<h2>
    15. Average Closing Time
</h2>
<p>
    Select <strong>all</strong> <strong>departments</strong> that have been
reported in and <strong>the average time </strong>for    <strong> closing </strong>a <strong>report </strong>for each department
rounded to the closest integer part<strong>.</strong> If there is<strong>no information</strong> (e.g. none closed reports) about any<strong>department</strong> fill in the Average Duration column “    <strong>no info</strong>”.
</p>
<p>
    Required columns:
</p>
<p>
    ● Department Name
</p>
<p>
    ● Average Duration - in days
</p>
<p>
    Order them by department name.
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
                <p>
                    <strong>Department Name</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>Average Duration</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Aged Care
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    no info
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Animals Care
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    17
                </p>
            </td>
        </tr>
        <tr>
            <td width="226" valign="top">
                <p>
                    Emergency
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    no info
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
        </tr>
    </tbody>
</table>
<h2>
    16. Favorite Categories
</h2>
<p>
Select <strong>all</strong> <strong>departments</strong> with<strong>their categories</strong> where <strong>users</strong> have<strong>submitted</strong> a <strong>report</strong>. Show the<strong>distribution</strong> of reports <strong>among</strong> the<strong>categories</strong> of each department in    <strong>percentages </strong>without decimal part.
</p>
<p>
    Required columns:
</p>
<p>
    ● Department Name
</p>
<p>
    ● Category Name
</p>
<p>
    ● Percentage
</p>
<p>
Order them by <strong>department</strong> name, then by<strong>category</strong> name and <strong>then</strong> by    <strong>percentage</strong> (all in <strong>ascending</strong> order).
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p>
                    <strong>Department Name</strong>
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    <strong>Category Name</strong>
                </p>
            </td>
            <td width="236" valign="top">
                <p>
                    <strong>Percentage</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Aged Care
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Homeless Elders
                </p>
            </td>
            <td width="236" valign="top">
                <p>
                    100
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Animals Care
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Animal in Danger
                </p>
            </td>
            <td width="236" valign="top">
                <p>
                    75
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Animals Care
                </p>
            </td>
            <td width="238" valign="top">
                <p>
                    Street animal
                </p>
            </td>
            <td width="236" valign="top">
                <p>
                    25
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
            <td width="236" valign="top">
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
    17. Employee’s Load
</h2>
<p>
Create a <strong>user defined function</strong> with the name    <strong>udf_GetReportsCount(@employeeId, @statusId)</strong> that receives
    an <strong>employee’s Id</strong> and a <strong>status Id </strong>returns
the sum of the reports he is assigned to with the given status.    <strong></strong>
</p>
<p>
    Parameters:
</p>
<p>
    ● Employee’s Id
</p>
<p>
    ● Status Id
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
                    <strong>Id,</strong>
                    <strong>
                        FirstName, Lastname, dbo.udf_GetReportsCount(Id, 2) AS
                        ReportsCount
                    </strong>
                </p>
                <p>
                    <strong>FROM</strong>
                    <strong> </strong>
                    <strong>Employees</strong>
                </p>
                <p>
                    <strong>ORDER</strong>
                    <strong> </strong>
                    <strong>BY</strong>
                    <strong> </strong>
                    <strong>Id</strong>
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
            <td width="224" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Marlo
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    O'Malley
                </p>
            </td>
            <td width="206" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="1">
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Nolan
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    Meneyer
                </p>
            </td>
            <td width="206" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="1">
            </td>
        </tr>
        <tr>
            <td width="224" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="107" valign="top">
                <p>
                    Tarah
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    McWaters
                </p>
            </td>
            <td width="206" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="1">
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
            <td width="119" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="206" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="1">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    18. Assign Employee
</h2>
<p>
Create a <strong>user defined stored procedure </strong>with the name    <strong>usp_AssignEmployeeToReport(@employeeId, @reportId)</strong> that
receives an <strong>em</strong><strong>ployee’s Id</strong> and a<strong>report’s Id </strong>and assigns the employee to the report    <strong>only if</strong> the department of the employee and the department
of the report’s category are the same. If the assigning is not successful<strong>rollback</strong> any changes and throw an    <strong>exception</strong> with message: “Employee doesn't belong to the
    appropriate department!”.
</p>
<p>
    Parameters:
</p>
<p>
    ● Employee’s Id
</p>
<p>
    ● Report’s Id
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
                    <strong> usp_AssignEmployeeToReport 17, 2;</strong>
                </p>
                <p>
                    <strong>SELECT</strong>
                    <strong> EmployeeId FROM Reports WHERE id = 2</strong>
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
                    17
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    19. Close Reports
</h2>
<p>
Create a <strong>trigger</strong> which changes the StatusId to “<strong>completed</strong>” of each report after a    <strong>CloseDate</strong> is <strong>entered </strong>for the report.
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
                    <strong> Reports</strong>
                </p>
                <p>
                    <strong>SET</strong>
                    <strong> CloseDate = GETDATE()</strong>
                </p>
                <p>
                    <strong>WHERE</strong>
                    <strong> EmployeeId = 5;</strong>
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
    Section 5. Bonus (10 pts)
</h1>
<h2>
    20. Categories Revision
</h2>
<p>
    Select <strong>all categories</strong> which have <strong>reports</strong>
with <strong>status</strong> “<strong>waiting</strong>” or “<strong>in</strong> <strong>progress</strong>” and show their<strong>total number</strong> in the column “<strong>Reports Number</strong>”. In the <strong>third</strong><strong>column</strong> fill the <strong>main</strong> status    <strong>type</strong> of reports for the category (e.g. <strong>2</strong>
    reports with status “<strong>waiting</strong>” and <strong>3</strong>
reports with status “<strong>in progress</strong>” <strong>result</strong>    <strong>in</strong> value “<strong>in progress</strong>”). If they are
equal just fill in “<strong>equal</strong>”. Order by category<strong>Name</strong>, then by <strong>Reports Number</strong> and then by    <strong>Main Status.</strong>
</p>
<p>
    Required columns:
</p>
<p>
    ● Category Name
</p>
<p>
    ● Reports Number
</p>
<p>
    ● Main Status
</p>
<h3>
    Example:
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="141" valign="top">
                <p>
                    <strong>Category Name</strong>
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    <strong>Reports Number</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    <strong>Main Status</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Animal in Danger
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    in progress
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Art Events
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    equal
                </p>
            </td>
        </tr>
        <tr>
            <td width="141" valign="top">
                <p>
                    Dangerous Building
                </p>
            </td>
            <td width="158" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    waiting
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
        </tr>
    </tbody>
</table>