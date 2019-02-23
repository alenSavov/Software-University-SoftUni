<h1 align="center">
    Exercises: Table Relations
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a
        href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016"
    >
        "Databases Basics - MSSQL" course @ Software University.
    </a>
</p>
<h2>
    Problem 1. One-To-One Relationship
</h2>
<p>
    Create two tables as follows. Use appropriate data types.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="319" colspan="4" valign="top">
                <p align="center">
                    <strong>Persons</strong>
                </p>
            </td>
            <td width="34" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="211" colspan="2" valign="top">
                <p align="center">
                    <strong>Passports</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="80" valign="top">
                <p>
                    <strong>PersonID</strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    <strong>FirstName</strong>
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    <strong>Salary</strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    <strong>PassportID</strong>
                </p>
            </td>
            <td width="34" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    <strong>PassportID</strong>
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    <strong>PassportNumber</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="80" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    Roberto
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    43300.00
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="34" valign="top">
            </td>
            <td width="82" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    N34FG21B
                </p>
            </td>
        </tr>
        <tr>
            <td width="80" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    Tom
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    56100.00
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="34" valign="top">
            </td>
            <td width="82" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    K65LO4R7
                </p>
            </td>
        </tr>
        <tr>
            <td width="80" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    Yana
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    60200.00
                </p>
            </td>
            <td width="82" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="34" valign="top">
            </td>
            <td width="82" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    ZE657QP2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Insert </strong>
    the data from the example above.
</p>
<p>
Alter the <strong>customers</strong> table and make<strong>PersonID </strong>a <strong>primary key</strong>. Create a<strong>foreign key</strong> between <strong>Persons</strong> and    <strong>Passports </strong>by using <strong>PassportID</strong> column.
</p>
<h2>
    Problem 2. One-To-Many Relationship
</h2>
<p>
    Create two tables as follows. Use appropriate data types.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="253" colspan="3" valign="top">
                <p align="center">
                    <strong>Models</strong>
                </p>
            </td>
            <td width="21" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="286" colspan="3" valign="top">
                <p align="center">
                    <strong>Manufacturers</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    <strong>ModelID</strong>
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    <strong>ManufacturerID</strong>
                </p>
            </td>
            <td width="21" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="119" valign="top">
                <p>
                    <strong>ManufacturerID</strong>
                </p>
            </td>
            <td width="58" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    <strong>EstablishedOn</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    X1
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="119" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="58" valign="top">
                <p>
                    BMW
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    07/03/1916
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    i6
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="119" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="58" valign="top">
                <p>
                    Tesla
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    01/01/2003
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Model S
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="119" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="58" valign="top">
                <p>
                    Lada
                </p>
            </td>
            <td width="109" valign="top">
                <p>
                    01/05/1966
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    104
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Model X
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="286" colspan="3" valign="top">
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    105
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Model 3
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="286" colspan="3" valign="top">
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    106
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Nova
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="21" valign="top">
            </td>
            <td width="286" colspan="3" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Insert</strong>
the data from the example above. Add <strong>primary keys </strong>and    <strong>foreign keys</strong>.
</p>
<h2>
    Problem 3. Many-To-Many Relationship
</h2>
<p>
    Create three tables as follows. Use appropriate data types.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="142" colspan="2" valign="top">
                <p align="center">
                    <strong>Students</strong>
                </p>
            </td>
            <td width="27" rowspan="8" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="156" colspan="2" valign="top">
                <p align="center">
                    <strong>Exams</strong>
                </p>
            </td>
            <td width="24" rowspan="8" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="151" colspan="2" valign="top">
                <p align="center">
                    <strong>StudentsExams</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p align="center">
                    <strong>StudentID</strong>
                </p>
            </td>
            <td width="57" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    <strong>ExamID</strong>
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    <strong>StudentID</strong>
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    <strong>ExamID</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="57" valign="top">
                <p>
                    Mila
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    SpringMVC
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    101
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="57" valign="top">
                <p>
                    Toni
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    Neo4j
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    102
                </p>
            </td>
        </tr>
        <tr>
            <td width="85" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="57" valign="top">
                <p>
                    Ron
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    Oracle 11g
                </p>
            </td>
            <td width="83" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    101
                </p>
            </td>
        </tr>
        <tr>
            <td width="142" colspan="2" rowspan="3" valign="top">
            </td>
            <td width="156" colspan="2" rowspan="3" valign="top">
            </td>
            <td width="83" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    103
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    102
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    103
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Insert the data from the example above.
    <br/>
    Add <strong>primary keys</strong> and <strong>foreign keys</strong>. Have
in mind that table <strong>StudentsExams</strong> should have a    <strong>composite primary key</strong>.
</p>
<h2>
    Problem 4. Self-Referencing
</h2>
<p>
    Create a single table as follows. Use appropriate data types.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="312" colspan="3" valign="top">
                <p align="center">
                    <strong>Teachers</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    <strong>TeacherID</strong>
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    <strong>Name</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    <strong>ManagerID</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    John
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    NULL
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    102
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Maya
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    106
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    103
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Silvia
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    106
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    104
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Ted
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    105
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    105
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Mark
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    101
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    106
                </p>
            </td>
            <td width="95" valign="top">
                <p>
                    Greta
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    101
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Insert the data from the example above. Add <strong>primary keys</strong>
    and <strong>foreign keys</strong>. The <strong>foreign key</strong> should
    be between <strong>ManagerId</strong> and <strong>TeacherId</strong>.
</p>
<h2>
    Problem 5. Online Store Database
</h2>
<p>
    Create a new database and design the following structure:
</p>
<h2>
    Problem 6. University Database
</h2>
<p>
    Create a new database and design the following structure:
</p>
<h2>
    Problem 7. SoftUni Design
</h2>
<p>
    Create an <strong>E/R Diagram</strong> of the SoftUni Database. There are
some <strong>special relations</strong> you should    <strong>check out</strong>: Employees are <strong>self-referenced</strong>
    (ManagerID) and Departments have <strong>One-to-One</strong> with the
    Employees (ManagerID) while the Employees have <strong>One-to-Many</strong>
    (DepartmentID). You might find it interesting how it looks on the diagram.
    J
</p>
<h2>
    Problem 8. Geography Design
</h2>
<p>
    Create an <strong>E/R Diagram</strong> of the Geography Database.
</p>
<h2>
    Problem 9. *Peaks in Rila
</h2>
<p>
    Display <strong>all peaks</strong> for <strong>"Rila"</strong> mountain.
    Include:
</p>
<ul>
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
Peaks should be <strong>sorted</strong> by    <strong>elevation descending</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="120" valign="top">
                <p>
                    <strong>MountainRange</strong>
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    <strong>PeakName</strong>
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    <strong>Elevation</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="120" valign="top">
                <p>
                    Rila
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    Musala
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    2925
                </p>
            </td>
        </tr>
        <tr>
            <td width="120" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    …
                </p>
            </td>
            <td width="88" valign="top">
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>