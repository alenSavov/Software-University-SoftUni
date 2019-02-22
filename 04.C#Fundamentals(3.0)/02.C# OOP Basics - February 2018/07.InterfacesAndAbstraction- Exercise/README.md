<h1 align="center">
    Exercises: Interfaces
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/csharp-oop-basics">
        "CSharp OOP Basics" course @ Software University
    </a>
    . Please submit your solutions (source code) of all below described
    problems in
    <a
        href="https://judge.softuni.bg/Contests/245/Interfaces-and-Abstraction-Exercise"
    >
        Judge
    </a>
    .
</p>
<h2>
    Problem 1. Define an Interface IPerson
</h2>
<p>
Define an interface<strong> IPerson</strong> with properties for<strong>Name</strong> and <strong>Age</strong>. Define a class    <strong>Citizen </strong>which implements <strong>IPerson</strong> and has
a constructor which takes a <strong>string</strong> name and an    <strong>int</strong> age.
</p>
<p>
    Try to create a new Person like this:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="297" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">string</a>
                    name = Console.ReadLine();
                </p>
                <p>
                    int age = int.Parse(Console.ReadLine());
                </p>
                <p>
                    IPerson person = new Citizen(name, age);
                </p>
                <p>
                    Console.WriteLine(person.Name);
                </p>
                <p>
                    Console.WriteLine(person.Age);
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="196">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="210">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="196" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    25
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    25
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Multiple Implementation
</h2>
<p>
Using the code from the previous task, define an interface<strong>IIdentifiable </strong>with a <strong>string</strong> property<strong>Id</strong> and an interface <strong>IBirthable</strong> with a<strong>string</strong> property <a name="OLE_LINK6"></a>    <a name="OLE_LINK5"><strong>Birthdate</strong> </a>and implement them in
    the <strong>Citizen</strong> class. Rewrite the Citizen constructor to
    accept the new parameters.
</p>
<p>
    Test your class like this:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="478" valign="top">
                <p>
                    <a name="OLE_LINK4"></a>
                    <a name="OLE_LINK3">string</a>
                    name = Console.ReadLine();
                </p>
                <p>
                    int age = int.Parse(Console.ReadLine());
                </p>
                <p>
                    string id = Console.ReadLine();
                </p>
                <p>
                    string birthdate = Console.ReadLine();
                </p>
                <p>
                    IIdentifiable identifiable = new Citizen(name, age,id,
                    birthdate);
                </p>
                <p>
                    IBirthable birthable = new Citizen(name, age, id,
                    birthdate);
                </p>
                <p>
                    Console.WriteLine(identifiable.Id);
                </p>
                <p>
                    Console.WriteLine(birthable.Birthdate);
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="196">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="210">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="196" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    25
                </p>
                <p>
                    9105152287
                </p>
                <p>
                    15/05/1991
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    9105152287
                </p>
                <p>
                    15/05/1991
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Ferrari
</h2>
<p>
Model an application which contains a <strong>class Ferrari</strong> and an<strong>interface</strong>. Your task is simple, you have a<strong>car - Ferrari</strong>, its model is    <strong>"<a name="__DdeLink__1766_1236768407">488-Spider</a>"</strong> and
it has a <strong>driver</strong>. Your Ferrari should have functionality to    <strong>use brakes</strong> and <strong>push the gas pedal</strong>. When
    the <strong>brakes</strong> are pushed down
    <strong>
print "<a name="OLE_LINK9"></a>        <a name="__DdeLink__1762_1236768407">Brakes!</a>"
    </strong>
    , and when the <strong>gas pedal</strong> is pushed down -
    <strong>
"<a name="OLE_LINK10"></a>        <a name="__DdeLink__1764_1236768407">Zadu6avam sA!</a>"
    </strong>
    . As you may have guessed this functionality is typical for all cars, so
    you should <strong>implement an interface</strong> to describe it.
</p>
<p>
Your task is to <strong>create a Ferrari</strong> and    <strong>set the driver's name</strong> to the passed one in the input.
    After that, print the info. Take a look at the Examples to understand the
    task better.
</p>
<h3>
    <a name="__DdeLink__1787_1236768407"></a>
    Input
</h3>
<p>
On the <strong>single input line</strong>, you will be given the    <strong>driver's name</strong>.
</p>
<h3>
    Output
</h3>
<p>
    On the <strong>single output line</strong>, print the model, the messages
    from the brakes and gas pedal methods and the driver's name. In the
    following format:
</p>
<p>
&lt;<strong>model</strong>&gt;/&lt;<strong>brakes</strong>&gt;/&lt;<strong>gas</strong> <strong>pedal</strong>&gt;/&lt;    <strong>driver's</strong> <strong>name</strong>&gt;
</p>
<h3>
    Constraints
</h3>
<p>
    The input will always be valid, no need to check it explicitly! The
    Driver's name may contain any ASCII characters.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="191">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="433" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Bat Giorgi
                </p>
            </td>
            <td width="433" valign="top">
                <p>
                    <a name="OLE_LINK12"></a>
                    <a name="OLE_LINK11">488-Spider</a>
                    /Brakes!/Zadu6avam sA!/Bat Giorgi
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Dinko
                </p>
            </td>
            <td width="433" valign="top">
                <p>
                    488-Spider/Brakes!/Zadu6avam sA!/Dinko
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. Telephony
</h2>
<p>
    You have a business - <strong>manufacturing cell phones</strong>. But you
    have no software developers, so you call some friends of yours and ask them
    to help you create a cell phone software. They have already agreed and you
started working on the project. The project consists of one main    <strong>model – a Smartphone</strong>. Each of your smartphones should have
functionalities of <strong>calling other phones</strong> and    <strong>browsing in the world wide web.</strong>
</p>
<p>
    These friends of yours though are very busy, so you decide to write the
    code on your own. Here is the mandatory assignment:
</p>
<p>
    You should have a <strong>model</strong> - <strong>Smartphone</strong> and
two separate functionalities which your smartphone has - to<strong>call other phones</strong> and to<strong>browse in the world wide web</strong>. You should end up with    <strong>one class</strong> and <strong>two interfaces</strong>.
</p>
<h3>
    Input
</h3>
<p>
    The input comes from the console. It will hold two lines:
</p>
<ul>
    <li>
        <strong>First line</strong>
        : <strong>phone numbers</strong> to call (string), separated by spaces.
    </li>
    <li>
        <strong>Second line: sites</strong>
        to visit (string), separated by spaces.
    </li>
</ul>
<h3>
    Output
</h3>
<ul type="disc">
    <li>
First <strong>call all numbers</strong> in the order of input then        <strong>browse all sites</strong> in order of input
    </li>
    <li>
        The functionality of calling phones is printing on the console the
        number which are being called in the format:
    </li>
</ul>
<p>
    <a name="OLE_LINK14"></a>
    <a name="OLE_LINK13"></a>
    <a name="__DdeLink__585_916938617"></a>
    <a name="__DdeLink__581_916938617"></a>
    <strong>Calling... </strong>
    <strong>&lt;number&gt;</strong>
</p>
<ul type="disc">
    <li>
        The functionality of the browser should print on the console the site
        in format:
    </li>
</ul>
<p>
    <a name="__DdeLink__583_916938617"></a>
    <a name="OLE_LINK16"></a>
    <a name="OLE_LINK15"><strong>Browsing: </strong></a>
    <strong>
        &lt;site&gt;<a name="OLE_LINK18"></a><a name="OLE_LINK17">!</a>
    </strong>
    <strong></strong>
</p>
<ul type="disc">
    <li>
        If there is a number in the input of the URLs, print:
        <strong>
            "<a name="__DdeLink__606_916938617">Invalid URL!</a>"
        </strong>
        and continue printing the rest of the URLs.<strong></strong>
    </li>
    <li>
If there is a character different from a digit in a number, print:<strong>"Invalid number!"</strong> and continue to the next number.        <strong></strong>
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul type="disc">
    <li>
Each site's URL should consist only of letters and symbols (        <strong>No digits are allowed </strong>in the URL address)
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="484" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="249" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="484" valign="top">
                <p>
                    0882134215 0882134333 08992134215 0558123 3333 1
                </p>
                <p>
                    http://softuni.bg http://youtube.com http://www.g00gle.com
                </p>
            </td>
            <td width="249" valign="top">
                <p>
                    Calling... 0882134215
                </p>
                <p>
                    Calling... 0882134333
                </p>
                <p>
                    Calling... 08992134215
                </p>
                <p>
                    Calling... 0558123
                </p>
                <p>
                    Calling... 3333
                </p>
                <p>
                    Calling... 1
                </p>
                <p>
                    Browsing: http://softuni.bg!
                </p>
                <p>
                    Browsing: http://youtube.com!
                </p>
                <p>
                    Invalid URL!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. Border Control
</h2>
<p>
    It’s the future, you’re the ruler of a totalitarian dystopian society
    inhabited by <strong>citizens</strong> and <strong>robots</strong>, since
    you’re afraid of rebellions you decide to implement strict control of who
    enters your city. Your soldiers check the <strong>Id</strong>s of everyone
    who enters and leaves.
</p>
<p>
    You will receive an unknown amount of lines from the console until the
    command “<strong>End</strong>” is received, on each line there will be a
    piece of information for either a citizen or a robot who tries to enter
your city in the format<strong>“&lt;name&gt; &lt;age&gt; &lt;id&gt;</strong>” for    <strong>citizens</strong> and “<strong>&lt;model&gt; &lt;id&gt;</strong>”
    for <strong>robots</strong>. After the end command on the next line you
will receive a single number representing<strong>the last digits of fake ids</strong>, all citizens or robots whose    <strong>Id</strong> ends with the specified digits must be detained.
</p>
<p>
The output of your program should consist of all detained    <strong>Id</strong>s each on a separate line in the <strong>order</strong>
    of <strong>input</strong>.
</p>
<h3>
    Input
</h3>
<p>
    The input comes from the console. Every commands’ parameters before the
command “<strong>End</strong>” will be separated by a    <strong>single space</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="196">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="210">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="196">
                <p>
                    Pesho 22 9010101122
                </p>
                <p>
                    MK-13 558833251
                </p>
                <p>
                    MK-12 33283122
                </p>
                <p>
                    End
                </p>
                <p>
                    122
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    9010101122
                </p>
                <p>
                    33283122
                </p>
            </td>
        </tr>
        <tr>
            <td width="196">
                <p>
                    Toncho 31 7801211340
                </p>
                <p>
                    Penka 29 8007181534
                </p>
                <p>
                    IV-228 999999
                </p>
                <p>
                    Stamat 54 3401018380
                </p>
                <p>
                    KKK-666 80808080
                </p>
                <p>
                    End
                </p>
                <p>
                    340
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    7801211340
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 6. Birthday Celebrations
</h2>
<p>
    It is a well known fact that people celebrate birthdays, it is also known
    that some people also celebrate their pets’ birthdays. Extend the program
    from your last task to add <strong>birthdates</strong> to citizens and
    include a class <strong>Pet</strong>, pets have a <strong>name</strong> and
    a <strong>birthdate</strong>. Encompass repeated functionality into
    interfaces and implement them in your classes.
</p>
<p>
    You will receive from the console an unknown amount of lines. Until the
    command “<strong>End</strong>” is received, each line will contain
    information in one of the following formats
    <strong>
        “Citizen &lt;name&gt; &lt;age&gt; &lt;id&gt; &lt;birthdate&gt;
    </strong>
” for citizens, “<strong>Robot</strong><strong>&lt;model&gt; &lt;id&gt;</strong>” for robots or “<strong>Pet &lt;name&gt; &lt;birthdate&gt;</strong>” for pets. After the “    <strong>End</strong>” command on the next line you will receive a single
    number representing <strong>a specific year</strong>, your task is to print
    all birthdates (of both citizens and pets) in that year<strong> </strong>in
the format <strong>day/month/year</strong> in the <strong>order</strong> of    <strong>input</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="426">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="294">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="426">
                <p>
                    Citizen Pesho 22 9010101122 10/10/1990
                </p>
                <p>
                    Pet Sharo 13/11/2005
                </p>
                <p>
                    Robot MK-13 558833251
                </p>
                <p>
                    End
                </p>
                <p>
                    1990
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    10/10/1990
                </p>
            </td>
        </tr>
        <tr>
            <td width="426">
                <p>
                    Citizen Stamat 16 0041018380 01/01/2000
                </p>
                <p>
                    Robot MK-10 12345678
                </p>
                <p>
                    Robot PP-09 00000001
                </p>
                <p>
                    Pet Topcho 24/12/2000
                </p>
                <p>
                    Pet Kosmat 12/06/2002
                </p>
                <p>
                    End
                </p>
                <p>
                    2000
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    01/01/2000
                </p>
                <p>
                    24/12/2000
                </p>
            </td>
        </tr>
        <tr>
            <td width="426">
                <p>
                    Robot VV-XYZ 11213141
                </p>
                <p>
                    Citizen Penka 35 7903210713 21/03/1979
                </p>
                <p>
                    Citizen Kane 40 7409073566 07/09/1974
                </p>
                <p>
                    End
                </p>
                <p>
                    1975
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    &lt;empty output&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Food Shortage
</h2>
<p>
    Your totalitarian dystopian society suffers a shortage of food, so many
    rebels appear. Extend the code from your previous task with new
    functionality to solve this task.
</p>
<p>
Define a class <strong>Rebel</strong> which has a <strong>name</strong>,    <strong>age </strong>and<strong> group </strong>(string)<strong>, </strong>
    names are<strong> unique - </strong>there will never be 2 Rebels/Citizens
    or a Rebel and Citizen with the same name<strong>.</strong> Define an
interface <strong>IBuyer</strong> which defines a method    <strong>BuyFood() </strong>and an integer property<strong> Food</strong>.
Implement the <strong>IBuyer</strong> interface in the    <strong>Citizen</strong> and <strong>Rebel</strong> class, both Rebels and
Citizens <strong>start with 0 food</strong>, when a Rebel buys food his    <strong>Food</strong> increases by <strong>5</strong>, when a Citizen buys
    food his <strong>Food</strong> increases by <strong>10</strong>.
</p>
<p>
On the first line of the input you will receive an integer<strong>N</strong> - the number of people, on each of the next    <strong>N</strong> lines you will receive information in one of the
following formats “    <strong>&lt;name&gt; &lt;age&gt; &lt;id&gt; &lt;birthdate&gt;</strong>” for
    a Citizen or “<strong>&lt;name&gt; &lt;age&gt;&lt;group&gt;</strong>” for a
Rebel. After the <strong>N</strong> lines until the command “    <strong>End</strong>” is received, you will receive names of people who
    bought food, each on a new line. Note that not all names may be valid, in
    case of an incorrect name - nothing should happen.
</p>
<h3>
    Output
</h3>
<p>
    The <strong>output</strong> consists of only <strong>one line</strong> on
    which you should print the <strong>total</strong> amount of food purchased.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="426">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="294">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="426" valign="top">
                <p>
                    2
                </p>
                <p>
                    Pesho 25 8904041303 04/04/1989
                </p>
                <p>
                    Stancho 27 WildMonkeys
                </p>
                <p>
                    Pesho
                </p>
                <p>
                    Gosho
                </p>
                <p>
                    Pesho
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    20
                </p>
            </td>
        </tr>
        <tr>
            <td width="426" valign="top">
                <p>
                    4
                </p>
                <p>
                    Stamat 23 TheSwarm
                </p>
                <p>
                    Toncho 44 7308185527 18/08/1973
                </p>
                <p>
                    Joro 31 Terrorists
                </p>
                <p>
                    Penka 27 881222212 22/12/1988
                </p>
                <p>
                    Jiraf
                </p>
                <p>
                    Jo ro
                </p>
                <p>
                    Jiraf
                </p>
                <p>
                    Joro
                </p>
                <p>
                    Stamat
                </p>
                <p>
                    Penka
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    20
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Military Elite
</h2>
<p>
    Create the following class hierarchy:
</p>
<ul>
    <li>
        <strong>Soldier</strong>
– general class for soldiers, holding <strong>id</strong>,        <strong>first name</strong> and <strong>last name.</strong>
    </li>
</ul>
<p>
o <strong>Private</strong> – lowest base soldier type, holding the field    <strong>salary</strong>(double).
</p>
<p>
§ <strong>LeutenantGeneral</strong> – holds a set of    <strong>Privates</strong> under his command.
</p>
<p>
    § <strong>SpecialisedSoldier – </strong>general class for all specialised
    soldiers – holds the <strong>corps</strong> of the soldier. The corps can
only be one of the following: <a name="OLE_LINK20"></a><a name="OLE_LINK19"><strong>Airforces </strong></a>or    <a name="OLE_LINK22"></a><a name="OLE_LINK21"><strong>Marines</strong></a>.
</p>
<p>
- <strong>Engineer</strong> – holds a set of <strong>repairs</strong>. A<strong>repair </strong>holds a <strong>part name</strong> and    <strong>hours worked</strong>(int).
</p>
<p>
    - <strong>Commando</strong> – holds a set of <strong>missions</strong>. A
mission holds <strong>code name</strong> and a <strong>state</strong> (<a name="OLE_LINK24"></a><a name="OLE_LINK23"><strong><em>inProgress</em></strong> </a>or<a name="OLE_LINK26"></a>    <a name="OLE_LINK25"><strong><em>Finished</em></strong></a>). A mission can
    be finished through the method <strong>CompleteMission()</strong>.
</p>
<p>
    o <strong>Spy</strong> – holds the <strong>code number </strong>of the spy
    (int).
</p>
<p>
Extract <strong>interfaces</strong> for each class. (e.g.<strong>ISoldier</strong>, <strong>IPrivate</strong>,    <strong>ILeutenantGeneral</strong>, etc.) The interfaces should hold their
public properties and methods (e.g. <strong>Isoldier</strong> should hold<strong>id</strong>, <strong>first name</strong> and    <strong>last name</strong>). Each class should implement its respective
    interface. Validate the input where necessary (corps, mission state) -
    input should match <strong>exactly</strong> one of the required values,
otherwise it should be treated as <strong>invalid</strong>. In case of    <strong>invalid</strong> <strong>corps</strong> the entire line should be
skipped, in case of an <strong>invalid</strong> <strong>mission</strong>    <strong>state</strong> only the mission should be skipped.
</p>
<p>
    You will receive from the console an unknown amount of lines containing
    information about soldiers until the command “<strong>End</strong>” is
    received. The information will be in one of the following formats:
</p>
<ul>
    <li>
        Private: “
        <strong>
            Private &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt;
            &lt;salary&gt;
        </strong>
        ”
    </li>
</ul>
<p>
    · LeutenantGeneral: “
    <strong>
        LeutenantGeneral &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt;
        &lt;salary&gt; &lt;private1Id&gt; &lt;private2Id&gt; …
        &lt;privateNId&gt;
    </strong>
    ” where privateXId will <strong>always</strong> be an <strong>Id</strong>
    of a private already received through the input.
</p>
<ul>
    <li>
        Engineer: “
        <strong>
            Engineer &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt;
            &lt;salary&gt; &lt;corps&gt; &lt;repair1Part&gt;
            &lt;repair1Hours&gt; … &lt;repairNPart&gt; &lt;repairNHours&gt;
        </strong>
        ” where repairXPart is the name of a repaired part and repairXHours the
        hours it took to repair it (the two parameters will always come
        paired).
    </li>
    <li>
        Commando: “
        <strong>
            Commando &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt;
            &lt;salary&gt; &lt;corps&gt; &lt;mission1CodeName&gt;
            &lt;mission1state&gt; … &lt;missionNCodeName&gt;
            &lt;missionNstate&gt;
        </strong>
        ” a missions cde name, description and state will always come together.
    </li>
    <li>
        Spy: “
        <strong>
            Spy &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt;
            &lt;codeNumber&gt;
        </strong>
        ”
    </li>
</ul>
<p>
    Define proper constructors. Avoid code duplication through abstraction.
    Override <strong>ToString()</strong> in all classes to print detailed
    information about the object.
</p>
<ul>
    <li>
        <strong>Privates:</strong>
        <br/>
        Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary:
        &lt;salary&gt;
    </li>
    <li>
        <strong>Spy:</strong>
        <br/>
        Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt;
        <br/>
        Code Number: &lt;codeNumber&gt;
    </li>
    <li>
        <strong>LeutenantGeneral:</strong>
        <br/>
        Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary:
        &lt;salary&gt;
        <br/>
        Privates:
        <br/>
        &lt;private1 ToString()&gt;
        <br/>
        &lt;private2 ToString()&gt;
        <br/>
        …
        <br/>
        &lt;privateN ToString()&gt;
    </li>
    <li>
        <strong>Engineer:</strong>
        <br/>
        Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary:
        &lt;salary&gt;
        <br/>
        Corps: &lt;corps&gt;
        <br/>
        Repairs:
        <br/>
        &lt;repair1 ToString()&gt;
        <br/>
        &lt;repair2 ToString()&gt;
        <br/>
        …
        <br/>
        &lt;repairN ToString()&gt;
    </li>
    <li>
        <strong>Commando:</strong>
        <br/>
        Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary:
        &lt;salary&gt;
        <br/>
        Corps: &lt;corps&gt;
        <br/>
        Missions:
        <br/>
        &lt;mission1 ToString()&gt;
        <br/>
        &lt;mission2 ToString()&gt;
        <br/>
        …
        <br/>
        &lt;missionN ToString()&gt;
    </li>
    <li>
        <strong>
            Repair:
            <br/>
        </strong>
        Part Name: &lt;partName&gt; Hours Worked: &lt;hoursWorked&gt;
    </li>
    <li>
        <strong>Mission:</strong>
        <br/>
        Code Name: &lt;codeName&gt; State: &lt;state&gt;
    </li>
</ul>
<p>
    <strong>NOTE: </strong>
    Salary should be printed rounded to <strong>two decimal places</strong>
    after the separator.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="384">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="381">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="384" valign="top">
                <p>
                    Private 1 Pesho Peshev 22.22
                    <br/>
                    Commando 13 Stamat Stamov 13.1 Airforces
                </p>
                <p>
                    Private 222 Toncho Tonchev 80.08
                </p>
                <p>
                    LeutenantGeneral 3 Joro Jorev 100 222 1
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="381" valign="top">
                <p>
                    Name: Pesho Peshev Id: 1 Salary: 22.22
                </p>
                <p>
                    Name: Stamat Stamov Id: 13 Salary: 13.10
                </p>
                <p>
                    Corps: Airforces
                </p>
                <p>
                    Missions:
                </p>
                <p>
                    Name: Toncho Tonchev Id: 222 Salary: 80.08
                </p>
                <p>
                    Name: Joro Jorev Id: 3 Salary: 100.00
                </p>
                <p>
                    Privates:
                </p>
                <p>
                    Name: Toncho Tonchev Id: 222 Salary: 80.08
                    <br/>
                    Name: Pesho Peshev Id: 1 Salary: 22.22
                </p>
            </td>
        </tr>
        <tr>
            <td width="384" valign="top">
                <p>
                    Engineer 7 Pencho Penchev 12.23 Marines Boat 2 Crane 17
                </p>
                <p>
                    Commando 19 Penka Ivanova 150.15 Airforces HairyFoot
                    finished Freedom inProgress
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="381" valign="top">
                <p>
                    Name: Pencho Penchev Id: 7 Salary: 12.23
                </p>
                <p>
                    Corps: Marines
                </p>
                <p>
                    Repairs:
                </p>
                <p>
                    Part Name: Boat Hours Worked: 2
                </p>
                <p>
                    Part Name: Crane Hours Worked: 17
                </p>
                <p>
                    Name: Penka Ivanova Id: 19 Salary: 150.15
                </p>
                <p>
                    Corps: Airforces
                    <br/>
                    Missions:
                </p>
                <p>
                    Code Name: Freedom State: inProgress
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. *Collection Hierarchy
</h2>
<p>
Create 3 different string collections –<strong> AddCollection</strong>,    <strong>AddRemoveCollection</strong> and <strong>MyList</strong>.
</p>
<p>
    The <strong>AddCollection</strong> should have:
</p>
<p>
· Only a single method <strong>Add</strong> which adds an item to the    <strong>end</strong> of the collection.
</p>
<p>
    The <strong>AddRemoveCollection</strong> should have:
</p>
<ul>
    <li>
        An <strong>Add </strong>method<strong> </strong>– which adds an item to
        the <strong>start</strong> of the collection.
    </li>
    <li>
A <strong>Remove</strong> method which removes the        <strong>last</strong> item in the collection.
    </li>
</ul>
<p>
    The <strong>MyList</strong> collection should have:
</p>
<ul>
    <li>
An <strong>Add</strong> method which adds an item to the        <strong>start</strong> of the collection.
    </li>
    <li>
A <strong>Remove</strong> method which removes the        <strong>first</strong> element in the collection.
    </li>
    <li>
        A <strong>Used</strong> property which displays the number of elements
        currently in the collection.
    </li>
</ul>
<p>
    Create interfaces which define the collections functionality, think how to
    model the relations between interfaces to reuse code. Add an extra bit of
functionality to the methods in the custom collections,    <strong>add</strong> methods should return the index in which the item was
    added, <strong>remove</strong> methods should return the item that was
    removed.
</p>
<p>
    Your task is to create a single copy of your collections, after which on
    the first input line you will receive a random amount of strings in a
    single line separated by spaces - the elements you must add to each of your
    collections. For each of your collections write a single line in the output
    that holds the results of all <strong>Add operations</strong> separated by
    spaces (check the examples to better understand the format). On the second
input line, you will receive a single number - the amount of    <strong>Remove operations</strong> you have to call on each collection. In
    the same manner, as with the Add operations for each collection (except the
    AddCollection), print a line with the results of each Remove operation
    separated by spaces.
</p>
<h3>
    Input
</h3>
<p>
    The input comes from the console. It will hold two lines:
</p>
<p>
    · The first line will contain a random amount of strings separated by
    spaces - the elements you have to <strong>Add</strong> to each of your
    collections.
</p>
<p>
· The second line will contain a single number - the amount of    <strong>Remove </strong>operations.
</p>
<h3>
    Output
</h3>
<p>
    The output will consist of 5 lines:
</p>
<p>
    · The first line contains the results of all <strong>Add</strong>
    operations on the <strong>AddCollection</strong> separated by spaces.
</p>
<ul>
    <li>
        The second line contains the results of all <strong>Add</strong>
        operations on the <strong>AddRemoveCollection</strong> separated by
        spaces.
    </li>
    <li>
        The third line contains the result of all <strong>Add</strong>
        operations on the <strong>MyList</strong> collection separated by
        spaces.
    </li>
    <li>
        The fourth line contains the result of all <strong>Remove</strong>
        operations on the <strong>AddRemoveCollection</strong> separated by
        spaces.
    </li>
    <li>
        The fifth line contains the result of all <strong>Remove</strong>
        operations on the <strong>MyList</strong> collection separated by
        spaces.
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
        All collections should have a <strong>length of 100.</strong>
    </li>
    <li>
        There will never be <strong>more than 100</strong> add operations.
    </li>
</ul>
<p>
    · The number of remove operations will never be more than the amount of add
    operations.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="334">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="372">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="334" valign="top">
                <p>
                    banichka boza tutmanik
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    0 1 2
                </p>
                <p>
                    0 0 0
                </p>
                <p>
                    0 0 0
                </p>
                <p>
                    banichka boza tutmanik
                </p>
                <p>
                    tutmanik boza banichka
                </p>
            </td>
        </tr>
        <tr>
            <td width="334" valign="top">
                <p>
                    one two three four five six seven
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    0 1 2 3 4 5 6
                </p>
                <p>
                    0 0 0 0 0 0 0
                </p>
                <p>
                    0 0 0 0 0 0 0
                </p>
                <p>
                    one two three four
                </p>
                <p>
                    seven six five four
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hint
</h3>
<p>
    Create an interface hierarchy representing the collections. You can use a
    List as the underlying collection and implement the methods using the
    List’s Add, Remove and Insert methods.
</p>
<h2>
    Problem 10. *Explicit Interfaces
</h2>
<p>
    Create 2 interfaces<strong> IResident</strong> and <strong>IPerson</strong>
. <strong>IResident</strong> should have a <strong>name</strong>,<strong>country </strong>and a method<strong> GetName()</strong>.<strong>IPerson</strong> should have a <strong>name</strong>, an    <strong>age </strong>and a method<strong> GetName()</strong>. Create a
class Citizen which implements both <strong>IResident </strong>and<strong>IPerson</strong>, explicitly declare that IResident’s    <strong>GetName()</strong> method should return “Mr/Ms/Mrs ” before the
    name while IPerson’s <strong>GetName()</strong> method should return just
    the name. You will receive lines of citizen information from the console
    until the command “<strong>End</strong>” is received. Each will be in the
    format <strong>“&lt;name&gt; &lt;country&gt; &lt;age&gt;</strong>” for each
line create the corresponding citizen and print his<strong>IPerson’s GetName()</strong> and his    <strong>IResitent’s GetName().</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="285" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="273" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    PeshoPeshev Bulgaria 20
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="273" valign="top">
                <p>
                    PeshoPeshev
                </p>
                <p>
                    <a name="OLE_LINK28"></a>
                    <a name="OLE_LINK27">Mr/Ms/Mrs </a>
                    PeshoPeshev
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    JoroJorev Bulgaria 33
                </p>
                <p>
                    EricAnderson GreatBritain 28
                </p>
                <p>
                    PeterArmstrong USA 19
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="273" valign="top">
                <p>
                    JoroJorev
                </p>
                <p>
                    Mr/Ms/Mrs JoroJorev
                </p>
                <p>
                    EricAnderson
                </p>
                <p>
                    Mr/Ms/Mrs EricAnderson
                </p>
                <p>
                    PeterArmstrong
                </p>
                <p>
                    Mr/Ms/Mrs PeterArmstrong
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hint
</h3>
<p>
    Check online about Explicit Interface Implementation.
</p>