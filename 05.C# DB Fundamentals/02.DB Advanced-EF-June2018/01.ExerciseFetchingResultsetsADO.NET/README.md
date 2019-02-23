<h1 align="center">
    Exercises: Introduction to DB Apps
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a
        href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017"
    >
        "Databases Advanced – EF Core" course @ Software University
    </a>
    .
</p>
<h2>
    1. Initial Setup
</h2>
<p>
    Write a program that connects to your <strong>localhost</strong> server.
    Create <strong>new database </strong>called <strong>MinionsDB</strong>
    where we will keep information about our minions and villains.
</p>
<p>
For each <strong>minion</strong> we should keep information about its<strong>name</strong>, <strong>age</strong> and <strong>town</strong>. Each<strong>town</strong> has information about <strong>the</strong><strong>country</strong> where it’s located. <strong>Villains</strong> have    <strong>name</strong> and <strong>evilness</strong> <strong>factor</strong>
(<strong>super good</strong>, <strong>good</strong>, <strong>bad</strong>,<strong>evil</strong>, <strong>super</strong> <strong>evil</strong>). Each<strong>minion</strong> can <strong>serve</strong> <strong>several</strong><strong>villains</strong> and <strong>each</strong><strong>villain</strong> can <strong>have</strong> <strong>several</strong>    <strong>minions</strong> <strong>serving</strong> <strong>him</strong>.
    Fill all tables with at least 5 records each.
</p>
<p>
    In the end you shoud have the following tables:
</p>
<ul>
    <li>
        Countries
    </li>
    <li>
        Towns
    </li>
    <li>
        Minions
    </li>
    <li>
        EvilnessFactors
    </li>
    <li>
        Villains
    </li>
    <li>
        MinionsVillains
    </li>
</ul>
<h2>
    2. Villain Names
</h2>
<p>
Write a program that prints on the console<strong>all villains’ names</strong> and their<strong>number of minions</strong> of those who have more than 3 minions    <strong>ordered descending</strong> by number of minions.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="103" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="103" valign="top">
                <p>
                    Gru - 6
                </p>
                <p>
                    Victor - 4
                </p>
                <p>
                    Jilly – 4
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Minion Names
</h2>
<p>
Write a program that prints on the console<strong>all minion names</strong> and age for a given<strong>villain id</strong>, ordered by <strong>name</strong>    <strong>alphabetically.</strong>
</p>
<p>
If there is no villain with the given ID, print "No villain with ID &lt;    <strong>VillainId</strong>&gt; exists in the database.".
    <br/>
    If the selected villain has no minions, print "(no minions)" on the second
    row.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="56" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="121" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="56" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="139" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="56" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="169" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="56" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="121" valign="top">
                <p>
                    Villain: Gru
                </p>
                <p>
                    1. Bob 13
                </p>
                <p>
                    2. Kevin 14
                </p>
                <p>
                    3. Steward 19
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="56" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="139" valign="top">
                <p>
                    Villain: Victor
                </p>
                <p>
                    1. Bob 13
                </p>
                <p>
                    2. Simon 22
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="56" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="169" valign="top">
                <p>
                    Villain: Victor Jr.
                </p>
                <p>
                    (no minions)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="57" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="57" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    No villain with ID 10 exists in the database.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Add Minion
</h2>
<p>
    Write a program that <strong>reads</strong> <strong>information</strong>
    about a minion and its villain and <strong>adds it to the database</strong>
. In case the town of the minion is not in the database,    <strong>insert</strong> it as well. In case the villain is not present in
the database, add him too with a default <strong>evilness</strong>    <strong>factor</strong> of "evil". Finally set the new minion to be a
    servant of the villain. Print appropriate messages after each operation.
</p>
<h3>
    Input
</h3>
<p>
    The input comes in two lines:
</p>
<p>
· On the first line, you will receive the <strong>minion</strong><strong>information</strong> in the format "Minion: &lt;<strong>Name</strong>&gt; &lt;<strong>Age</strong>&gt; &lt;    <strong>TownName</strong>&gt;"
</p>
<p>
    · On the second – the <strong>villain</strong> <strong>information</strong>
    in the format "Villain: &lt;<strong>Name</strong>&gt;"
</p>
<h3>
    Output
</h3>
<p>
    After completing an operation, you must print one of the following
    messages:
</p>
<p>
· After adding a new <strong>town</strong> to the database: "Town &lt;    <strong>TownName</strong>&gt; was added to the database."
</p>
<p>
    · After adding a new <strong>villain</strong> to the database: "Villain
    &lt;<strong>VillainName</strong>&gt; was added to the database."
</p>
<p>
    · Finally, after successfully adding the <strong>minion</strong> to the
    database and making it a <strong>servant</strong> of a villain:
    "Successfully added &lt;<strong>MinionName</strong>&gt; to be minion of
    &lt;<strong>VillainName</strong>&gt;."<strong></strong>
</p>
<p>
    <strong>*Bonus task:</strong>
    Make sure all operations are executed successfully. In case of an error do
    not change the database.<strong></strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="255" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="425" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    Minion: Bob 14 Berlin
                </p>
                <p>
                    Villain: Gru
                </p>
            </td>
            <td width="425" valign="top">
                <p>
                    Successfully added Robert to be minion of Gru.
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    Minion: Cathleen 20 Liverpool
                </p>
                <p>
                    Villain: Gru
                </p>
            </td>
            <td width="425" valign="top">
                <p>
                    Town Liverpool was added to the database.
                </p>
                <p>
                    Successfully added Cathleen to be minion of Gru.
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    Minion: Mars 23 Sofia
                </p>
                <p>
                    Villain: Poppy
                </p>
            </td>
            <td width="425" valign="top">
                <p>
                    Villain Poppy was added to the database.
                </p>
                <p>
                    Successfully added Mars to be minion of Poppy.
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    Minion: Carry 20 Eindhoven
                </p>
                <p>
                    Villain: Jimmy
                </p>
            </td>
            <td width="425" valign="top">
                <p>
                    Town Eindhoven was added to the database.
                </p>
                <p>
                    Villain Jimmy was added to the database.
                </p>
                <p>
                    Successfully added Carry to be minion of Jimmy.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Change Town Names Casing
</h2>
<p>
    Write a program that <strong>changes all town names to uppercase</strong>
    for a given country.
</p>
<p>
    You will receive one line of input with the <strong>name</strong> of the
    country.
</p>
<p>
    <strong>Print the</strong>
    <strong>number of towns that were changed</strong>
    in the format "&lt;<strong>ChangedTownsCount</strong>&gt; town names were
affected.". On a second line, <strong>print</strong> the    <strong>names that were changed</strong>, separated with a comma and a
    space.
</p>
<p>
    If <strong>no</strong> <strong>towns</strong> were affected (the country
does not exist in the database or has no cities connected to it),    <strong>print </strong>"<strong>No town names were affected.</strong>".
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="95" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Bulgaria
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    3 town names were affected.
                </p>
                <p>
                    [SOFIA, VARNA, BURGAS]
                </p>
            </td>
        </tr>
        <tr>
            <td width="95" valign="top">
                <p>
                    Germany
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    No town names were affected.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. *Remove Villain
</h2>
<p>
Write a program that receives the <strong>ID</strong> of a villain,<strong>deletes him from the database</strong> and<strong>releases his minions</strong> from serving to him. Print on    <strong>two</strong> <strong>lines</strong> the name of the deleted villain
in format "&lt;<strong>Name</strong>&gt; <strong>was</strong>    <strong>deleted</strong>." and the number of minions released in format
"&lt;<strong>MinionCount</strong>&gt; <strong>minions</strong>    <strong>were</strong> <strong>released</strong>.". Make sure all operations
    go as planned, otherwise do not make any changes in the database.
</p>
<p>
If there is no villain in the database with the given ID, print "    <strong>No such villain was found</strong>.".
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="217" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    Gru was deleted.
                </p>
                <p>
                    6 minions were released.
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    Victor was deleted.
                </p>
                <p>
                    0 minions were released.
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    101
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    No such villain was found.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Print All Minion Names
</h2>
<p>
    Write a program that <strong>prints all minion names</strong> from the
    minions table <strong>in the following order:</strong> first record, last
    record, first + 1, last - 1, first + 2, last - 2 … first + n, last - n.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="22" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="29" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="29" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="23" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="22" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="104">
                <p align="center">
                    <strong>Original Order</strong>
                </p>
            </td>
            <td width="85">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="104" valign="top">
                <p>
                    Bob
                </p>
                <p>
                    Kevin
                </p>
                <p>
                    Steward
                </p>
                <p>
                    Jimmy
                </p>
                <p>
                    Vicky
                </p>
                <p>
                    Becky
                </p>
                <p>
                    Jully
                </p>
            </td>
            <td width="85" valign="top">
                <p>
                    Bob
                </p>
                <p>
                    Jully
                </p>
                <p>
                    Kevin
                </p>
                <p>
                    Becky
                </p>
                <p>
                    Steward
                </p>
                <p>
                    Vicky
                </p>
                <p>
                    Jimmy
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Increase Minion Age
</h2>
<p>
Read from the console minion IDs separated by space.    <strong> Increment the age</strong> of those minions <strong>by 1</strong>
and make their <strong>names title case</strong>. Finally,    <strong>print the name and the age of all minions</strong> in the database,
    each on a new row in format <strong>"&lt;Name&gt; &lt;Age&gt;</strong>".
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="208" colspan="3">
                <p align="center">
                    <strong>Minions</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="32">
                <p align="center">
                    <strong>Id</strong>
                </p>
            </td>
            <td width="129">
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    <strong>Age</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    bob
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    14
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    stuart
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    22
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    kevin
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    13
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    4
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    jimmy
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    49
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    5
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    vicky jackson
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="64">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="153">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td width="19" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="57">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="151">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    2 1 4
                </p>
            </td>
            <td width="153" valign="top">
                <p>
                    Bob 15
                </p>
                <p>
                    Stuart 23
                </p>
                <p>
                    kevin 13
                </p>
                <p>
                    Jimmy 50
                </p>
                <p>
                    vicky jackson 26
                </p>
            </td>
            <td width="19" valign="top">
            </td>
            <td width="57" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="151" valign="top">
                <p>
                    bob 14
                </p>
                <p>
                    stuart 22
                </p>
                <p>
                    kevin 13
                </p>
                <p>
                    jimmy 49
                </p>
                <p>
                    Vicky Jackson 27
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Increase Age Stored Procedure
</h2>
<p>
Create stored procedure <a name="OLE_LINK1"></a><a name="OLE_LINK2"><strong>usp_GetOlder</strong> </a>(<strong>directly in the database</strong> using<strong>Management Studio</strong> or any other similar tool) that receives<strong>MinionId</strong> and<strong>increases that minion’s age by 1</strong>. Write a program that    <strong>uses that stored procedure to increase the age</strong> of a minion
whose id will be given as input from the console. After that    <strong>print the name and the age</strong> of that minion.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="208" colspan="3">
                <p align="center">
                    <strong>Minions</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="32">
                <p align="center">
                    <strong>Id</strong>
                </p>
            </td>
            <td width="129">
                <p align="center">
                    <strong>Name</strong>
                </p>
            </td>
            <td width="47" valign="top">
                <p align="center">
                    <strong>Age</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    1
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    bob
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    14
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    2
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    steward
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    22
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    3
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    kevin
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    13
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    4
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    jimmy
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    49
                </p>
            </td>
        </tr>
        <tr>
            <td width="32" valign="top">
                <p align="center">
                    5
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    vicky jackson
                </p>
            </td>
            <td width="47" valign="top">
                <p>
                    26
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="47">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="248">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="47" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="248" valign="top">
                <p>
                    bob – 15 years old
                </p>
            </td>
        </tr>
        <tr>
            <td width="47" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="248" valign="top">
                <p>
                    kevin – 14 years old
                </p>
            </td>
        </tr>
        <tr>
            <td width="47" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="248" valign="top">
                <p>
                    vicky jackson – 27 years old
                </p>
            </td>
        </tr>
    </tbody>
</table>