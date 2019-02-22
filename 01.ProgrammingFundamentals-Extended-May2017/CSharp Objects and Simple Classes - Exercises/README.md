<h1>
    More Exercises: Objects and Simple Classes
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        “Programming Fundamentals Extended” course @ SoftUni
    </a>
    .
</p>
<p>
    Check your solutions here:
    <a href="https://judge.softuni.bg/Contests/439">
        https://judge.softuni.bg/Contests/439
    </a>
    .
</p>
<h2>
    1. Exercises
</h2>
<p>
    Exercises are fun … Especially when they represent a problem from your
    exercises.
</p>
<p>
Implement a <strong>class Exercise</strong>, which has a<strong> Topic </strong>(<strong>string</strong>), a<strong>CourseName </strong>(<strong>string</strong>), a<strong>JudgeContestLink </strong>(<strong>string</strong>), and a<strong>Problems </strong>(<strong>collection</strong> of    <strong>strings</strong>).
</p>
<p>
    You will receive several input lines containing information about a single
    exercise in the following format:
</p>
<p>
    {topic} -&gt; {courseName} -&gt; {judgeContestLink} -&gt; {problem1},
    {problem2}. . .
</p>
<p>
You need to store every exercise in a <strong>Collection</strong> of    <strong>Exercises</strong>. When you receive the command “go go go”, you
    end the input sequence.
</p>
<p>
    You must print every exercise, in the following format:
</p>
<p>
    “Exercises: {topic}
</p>
<p>
    Problems for exercises <a name="OLE_LINK9"></a>
    <a name="OLE_LINK8">
        and homework for the “{courseName}” course @ SoftUni.
    </a>
</p>
<p>
    Check your solutions here: {judgeContestLink}.
</p>
<p>
    1. {problem1}
</p>
<p>
    2. {problem2}
</p>
<p>
    . . .”
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="310" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="392" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="310" valign="top">
                <p>
                    ObjectsAndSimpleClasses -&gt;
                    ProgrammingFundamentalsExtended -&gt;
                    https://judge.softuni.bg/Contests/439 -&gt; Exercises,
                    OptimizedBankingSystem, Animals, Websites, Boxes,
                    BoxIntersection, Messages
                </p>
                <p>
                    go go go
                </p>
            </td>
            <td width="392" valign="top">
                <p>
                    Exercises: ObjectsAndSimpleClasses
                </p>
                <p>
                    Problems for exercises and homework for the
                    "ProgrammingFundamentalsExtended" course @ SoftUni.
                </p>
                <p>
                    Check your solutions here:
                    https://judge.softuni.bg/Contests/439
                </p>
                <p>
                    1. Exercises
                </p>
                <p>
                    2. OptimizedBankingSystem
                </p>
                <p>
                    3. Animals
                </p>
                <p>
                    4. Websites
                </p>
                <p>
                    5. Boxes
                </p>
                <p>
                    6. BoxIntersection
                </p>
                <p>
                    7. Messages
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Optimized Banking System
</h2>
<p>
    Remember the Ordered Banking System problem? Well, now you have to optimize
    it with classes.
</p>
<p>
Create a <strong>class</strong> <strong>BankAccount</strong> which has a<strong>Name</strong> (<strong>string</strong>), <strong>Bank</strong> (<strong>string</strong>) and <strong>Balance</strong> (    <strong>decimal</strong>).
</p>
<p>
    You will receive several input lines, containing information in the
    following way:
</p>
<p>
    {bank} | {accountName} | {accountBalance}
</p>
<p>
You need to store every given Account. When you receive the command “    <strong>end</strong>” you must <strong>stop</strong> the input sequence.
</p>
<p>
    Then you must print all <strong>Accounts</strong>, <strong>ordered</strong>
    by their <strong>balance</strong>, in <strong>descending order</strong>,
and then by <strong>length</strong> of the <strong>bank name</strong>, in    <strong>ascending order</strong>.
</p>
<p>
    The accounts must be printed in the following way “{accountName} -&gt;
    {balance} ({bank})”.
</p>
<p>
    <strong>Note</strong>
    : <strong>Numbers</strong> must be printed, <strong>exactly</strong> as
they are <strong>entered</strong>. No <strong>formatting</strong> is    <strong>required</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="286" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="290" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="286" valign="top">
                <p>
                    DSK | Ivan | 504.403
                </p>
                <p>
                    DSK | Pesho | 2000.4031
                </p>
                <p>
                    DSK | Aleksander | 20000.0001
                </p>
                <p>
                    Piraeus | Ivan | 504.403
                </p>
                <p>
                    Piraeus | Aleksander | 20000.0001
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="290" valign="top">
                <p>
                    Aleksander -&gt; 20000.0001 (DSK)
                </p>
                <p>
                    Aleksander -&gt; 20000.0001 (Piraeus)
                </p>
                <p>
                    Pesho -&gt; 2000.4031 (DSK)
                </p>
                <p>
                    Ivan -&gt; 504.403 (DSK)
                </p>
                <p>
                    Ivan -&gt; 504.403 (Piraeus)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Animals *
</h2>
<p>
    You have been given the task to create classes for several sophisticated
    animals.
</p>
<p>
Create a <strong>class Dog</strong> which has a <strong>Name </strong>(<strong>string</strong>), <strong>Age </strong>(<strong>int</strong>) and    <strong>NumberOfLegs </strong>(<strong>int</strong>).
</p>
<p>
Create a <strong>class Cat</strong> which has a <strong>Name</strong> (<strong>string</strong>), <strong>Age</strong> (<strong>int</strong>) and    <strong>IntelligenceQuotient</strong> (<strong>int</strong>).
</p>
<p>
Create a <strong>class Snake</strong> which has a <strong>Name</strong> (<strong>string</strong>), <strong>Age</strong>(<strong>int</strong>) and    <strong>CrueltyCoefficient</strong> (<strong>int</strong>).
</p>
<p>
    Create a <strong>method</strong> in <strong>each class</strong> which is
    called public void ProduceSound(). The method should print on the console a
    string depending on the class:
</p>
<ul>
    <li>
If it’s a <strong>Dog</strong>, you should print “<a name="OLE_LINK10"></a><a name="OLE_LINK5"></a>        <a name="OLE_LINK6"></a>
        <a name="OLE_LINK7">
            <strong>
                I’m a Distinguishedog, and I will now produce a distinguished
                sound! Bau Bau.
            </strong>
        </a>
        ”
    </li>
    <li>
It it’s a <strong>Cat</strong>, you should print “        <a name="OLE_LINK11"></a><a name="OLE_LINK3"></a>
        <a name="OLE_LINK4">
            <strong>
                I’m an Aristocat, and I will now produce an aristocratic sound!
                Myau Myau.
            </strong>
        </a>
        ”
    </li>
    <li>
If it’s a <strong>Snake</strong>, you should print “        <a name="OLE_LINK12"></a><a name="OLE_LINK1"></a>
        <a name="OLE_LINK2">
            <strong>
                I’m a Sophistisnake, and I will now produce a sophisticated
                sound! Honey, I’m home.
            </strong>
        </a>
        ”
    </li>
</ul>
<p>
    Now for the real deal. You will receive several input commands, which will
    register animals or make them produce sounds, until you receive the command
    “<strong>I’m your Huckleberry</strong>”.
</p>
<p>
    The commands will be in the following format:
</p>
<p>
    {class} {name} {age} {parameter}
</p>
<p>
The <strong>class</strong> will be either “<strong>Dog</strong>”, “<strong>Cat</strong>” or “<strong>Snake</strong>”. The    <strong>name</strong> will be a simple <strong>string</strong>, which can
    contain <strong>any</strong> ASCII character BUT <strong>space</strong>.
The <strong>age</strong> will be an <strong>integer</strong>. The<strong>parameter</strong>, will be an <strong>integer</strong>.<strong>Depending</strong> on the <strong>class</strong> it would either be<strong>number of legs</strong>, <strong>IQ</strong>, or    <strong>cruelty coefficient</strong>.
</p>
<p>
    Register each animal, and keep them in <strong>collections</strong>, by
your <strong>choice</strong>, so that you can    <strong>ACCESS THEM BY NAME</strong>. You will most likely need 3
    collections, to store the different animals inside them.
</p>
<p>
    Between the register commands you might receive a command in the following
    format:
</p>
<p>
    talk {name}
</p>
<p>
You must then make the <strong>animal</strong> with the    <strong>given name</strong>, <strong>produce a sound</strong>.
</p>
<p>
    When you receive the ending command, you should print every animal in the
    following format:
</p>
<ul>
    <li>
        If it’s a <strong>Dog</strong>, you should print “
        <strong>
            Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}
        </strong>
        ”
    </li>
    <li>
It it’s a <strong>Cat</strong>, you should print “        <strong>Cat: {name}, Age: {age}, IQ: {intelligenceQontient}</strong>”
    </li>
    <li>
        If it’s a <strong>Snake</strong>, you should print “
        <strong>
Snake: {name}, Age: {age}, <a name="OLE_LINK14"></a>            <a name="OLE_LINK13">Cruelty</a>: {crueltyCoefficient}
        </strong>
        ”
    </li>
</ul>
<p>
    Print first the <strong>Dogs</strong>, then the <strong>Cats</strong>, and
    lastly – <strong>The Snakes</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
You can assume that there will be <strong>no duplicate</strong> names (        <strong>even</strong> in <strong>different animals</strong>).
    </li>
    <li>
All input data will be <strong>valid</strong>. There will be        <strong>no invalid</strong> input lines.
    </li>
    <li>
The <strong>name</strong> in the talk command, will        <strong>always</strong> be <strong>existent</strong>.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="181" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="521" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="181" valign="top">
                <p>
                    Dog Sharo 3 4
                </p>
                <p>
                    Cat Garfield 5 200
                </p>
                <p>
                    Snake Alex 25 1000
                </p>
                <p>
                    talk Sharo
                </p>
                <p>
                    talk Garfield
                </p>
                <p>
                    talk Alex
                </p>
                <p>
                    I’m your Huckleberry
                </p>
            </td>
            <td width="521" valign="top">
                <p>
                    I'm a Distinguishedog, and I will now produce a
                    distinguished sound! Bau Bau.
                </p>
                <p>
                    I'm an Aristocat, and I will now produce an aristocratic
                    sound! Myau Myau.
                </p>
                <p>
                    I'm a Sophistisnake, and I will now produce a sophisticated
                    sound! Honey, I'm home.
                </p>
                <p>
                    Dog: Sharo, Age: 3, Number Of Legs: 4
                </p>
                <p>
                    Cat: Garfield, Age: 5, IQ: 200
                </p>
                <p>
                    Snake: Alex, Age: 25, Cruelty: 1000
                </p>
            </td>
        </tr>
        <tr>
            <td width="181" valign="top">
                <p>
                    Dog Bau 5 10
                </p>
                <p>
                    Cat Myau 5 100
                </p>
                <p>
                    Dog Georgi 20 1000
                </p>
                <p>
                    Cat Bojo 4 20
                </p>
                <p>
                    talk Bojo
                </p>
                <p>
                    I’m your Huckleberry
                </p>
            </td>
            <td width="521" valign="top">
                <p>
                    I'm an Aristocat, and I will now produce an aristocratic
                    sound! Myau Myau.
                </p>
                <p>
                    Dog: Bau, Age: 5, Number Of Legs: 10
                </p>
                <p>
                    Dog: Georgi, Age: 20, Number Of Legs: 1000
                </p>
                <p>
                    Cat: Myau, Age: 5, IQ: 100
                </p>
                <p>
                    Cat: Bojo, Age: 4, IQ: 20
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Websites
</h2>
<p>
    You have been tasked to create an ordered database of websites. For the
task you will need to create a <strong>class</strong><strong>Website</strong>, which will have a <strong>Host</strong>, a    <strong>Domain</strong> and <strong>Queries</strong>.
</p>
<p>
The <strong>Host</strong> and the <strong>Domain</strong> are simple    <strong> strings</strong>.
    <br/>
The <strong>Queries</strong>, is <strong>Collections</strong> of    <strong>strings</strong>.
</p>
<p>
    You will be given several input lines in the following format:
</p>
<p>
    {host} | {domain} | {query1,query2. . .}
</p>
<p>
Note: There will <strong>always</strong> be a <strong>host</strong> and a<strong>domain</strong>, but there <strong>might</strong>    <strong>NOT</strong> be <strong>ANY</strong> <strong>queries</strong>.
</p>
<p>
    The input sequence ends, when you receive the command “<strong>end</strong>
    ”. Then you must print <strong>all websites</strong> in the following
    format:
</p>
<p>
    https://www.{host}.{domain}/query?=[{query1]&amp;[{query2}]&amp;[query3]. .
    .
</p>
<p>
    In case there are <strong>NO</strong> <strong>queries</strong>, just print:
</p>
<p>
    https://www.{host}.{domain}
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="272" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="479" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="272" valign="top">
                <p>
                    softuni | bg | user,course,homework
                </p>
                <p>
                    judge.softuni | bg | contest,bg
                </p>
                <p>
                    google | bg | search,query
                </p>
                <p>
                    zamunda | net
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="479" valign="top">
                <p>
                    https://www.softuni.bg/query?=[user]&amp;[course]&amp;[homework]
                </p>
                <p>
                    https://www.judge.softuni.bg/query?=[contest]&amp;[bg]
                </p>
                <p>
                    https://www.google.bg/query?=[search]&amp;[query]
                </p>
                <p>
                    https://www.zamunda.net
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Boxes
</h2>
<p>
Create a <strong>class Box</strong>, which will represent a<strong>rectangular</strong> <strong>box</strong>. The Box should have<strong>UpperLeft</strong> (<strong>Point</strong>),<strong>UpperRight</strong> (<strong>Point</strong>),<strong>BottomLeft</strong> (<strong>Point</strong>),    <strong>BottomRight</strong> (<strong>Point</strong>).
</p>
<p>
Create, or use from the Lab, the <strong>class Point</strong> which has<strong>X</strong> (<strong>int</strong>) and <strong>Y</strong> (    <strong>int</strong>) – coordinates in <strong>2D space</strong>. Move the
    CalculateDistance() method in the <strong>Point class</strong>, exactly as
it is. Then use “Point.CalculateDistance(point1, point2)” signature, to    <strong>use</strong> the <strong>method</strong>.
</p>
<p>
    Create <strong>2 methods</strong> in the <strong>Box class</strong>:
    <br/>
    public static int CalculatePerimeter(int width, int height)
    <br/>
    public static int CalculateArea(int width, int height).
</p>
<p>
    Make them <strong>return</strong> an <strong>integer</strong>, representing
the <strong>perimeter</strong> and <strong>area</strong> of the    <strong>box</strong>.
</p>
<p>
    The formulas are respectively – (2 * Width + 2 * Height) and (Width *
    Height).
</p>
<p>
The <strong>Width</strong> is the <strong>distance</strong><strong>between</strong> the <strong>UpperLeft</strong> and the<strong>UpperRight</strong> Points, and <strong>ALSO</strong> – the    <strong>Bottomleft</strong> and the <strong>BottomRight</strong> Points.
</p>
<p>
The <strong>Height</strong> is the <strong>distance</strong><strong>between</strong> the <strong>UpperLeft</strong> and the<strong>BottomLeft</strong> Points, and <strong>ALSO</strong> – the    <strong>UpperRight</strong> and the <strong>BottomRight</strong> Points.
</p>
<p>
    You will receive several input lines in the following format:
</p>
<p>
    {X1}:{Y1} | {X2}:{Y2} | {X3}:{Y3} | {X4}:{Y4}
</p>
<p>
Those will be the coordinates to <strong>UpperLeft</strong>,<strong>UpperRight</strong>, <strong>BottomLeft</strong> and    <strong>BottomRight</strong> (<strong>IN THE SAME ORDER</strong>).
</p>
<p>
When you receive the command “<strong>end</strong>”. You must print    <strong>all Boxes</strong> in the following format:
</p>
<p>
    “Box: {width}, {height}
</p>
<p>
    Perimeter: {perimeter}
</p>
<p>
    Area: {area}”
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="290" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    0:2 | 2:2 | 0:0 | 2:0
                </p>
                <p>
                    -3:0 | 0:0 | -3:-3 | 0:-3
                </p>
                <p>
                    -2:2 | 2:2 | -2:-2 | 2:-2
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="290" valign="top">
                <p>
                    Box: 2, 2
                </p>
                <p>
                    Perimeter: 8
                </p>
                <p>
                    Area: 4
                </p>
                <p>
                    Box: 3, 3
                </p>
                <p>
                    Perimeter: 12
                </p>
                <p>
                    Area: 9
                </p>
                <p>
                    Box: 4, 4
                </p>
                <p>
                    Perimeter: 16
                </p>
                <p>
                    Area: 16
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Messages *
</h2>
<p>
Create a <strong>class</strong> <strong>User</strong>, which has a<strong>Username</strong> (<strong>string</strong>), and<strong>ReceivedMessages</strong> (<strong>Collection</strong> of    <strong>Messages)</strong>.
    <br/>
Create a <strong>class</strong> <strong>Message</strong>, which has a<strong>Content</strong> (<strong>string</strong>) and a    <strong>Sender</strong> (<strong>User</strong>).
</p>
<p>
    You will have to store a messaging history for every user. The input
    consists of 2 commands:
</p>
<p>
    “register {username}”
</p>
<p>
    “{senderUsername} send {recipientUsername} {content}”
</p>
<p>
    The <strong>register command</strong>, registers a <strong>user</strong>
    with the <strong>given username</strong>.
</p>
<p>
    The <strong>send command</strong>, sends a <strong>message</strong>, from
    the <strong>given sender</strong>, to the <strong>given recipient</strong>,
with the <strong>given content</strong>. That means that you must<strong>add</strong> the <strong>message</strong> to the    <strong>recipient’s ReceivedMessages</strong>.
    <br/>
If <strong>even one</strong> of the <strong>given names</strong> does    <strong>NOT</strong> exist, <strong>ignore</strong> the command.
</p>
<p>
    When you receive the command “<strong>exit</strong>” you must end the input
sequence. After that you will receive <strong>2 usernames</strong>,    <strong>separated</strong> by a <strong>space</strong>.
</p>
<p>
You must <strong>print all messages</strong>, sent,<strong>between the two users</strong>, corresponding to    <strong>the given usernames</strong>. The messages should be printed in a
specified way. You should print <strong>first</strong> a<strong>message</strong> <strong>SENT</strong> from the<strong>first user</strong>, <strong>then</strong> a<strong>message</strong> <strong>SENT</strong> from the<strong>second user</strong>, then a <strong>message</strong> from<strong>the first user</strong>, and <strong>so</strong><strong>on</strong>. If one of the <strong>collections</strong> of<strong>messages</strong> has <strong>more</strong><strong>elements</strong> than the <strong>other</strong>, just print the    <strong>remaining elements</strong> from it.
</p>
<p>
    The first user’s messages must be printed in the following way:
    <br/>
    “{firstUser}: {content}”
</p>
<p>
    The second user’s message must be printed in the following way:
</p>
<p>
    “{content} :{secondUser}”
</p>
<p>
    When you print the whole output, it should look like this:
</p>
<p>
    {firstUser}: {content1}
</p>
<p>
    {content1} :{secondUser}
</p>
<p>
    {firstUser}: {content2}
</p>
<p>
    {content2} :{secondUser}
</p>
<p>
    . . .
</p>
<p>
    In case there are <strong>NO</strong> messages <strong>between</strong> the
    two users, print “<strong>No messages</strong>”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="318" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="290" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="318" valign="top">
                <p>
                    register Ivan
                </p>
                <p>
                    register Pesho
                </p>
                <p>
                    Ivan send Pesho pesho
                </p>
                <p>
                    Ivan send Pesho pesho_tam_li_si?
                </p>
                <p>
                    Pesho send Ivan kaji_vanka
                </p>
                <p>
                    Pesho send Ivan tuk_sum
                </p>
                <p>
                    Pesho send Ivan chakai_che_bachkam
                </p>
                <p>
                    Ivan send Pesho kvo_stava
                </p>
                <p>
                    Ivan send Pesho kak_si
                </p>
                <p>
                    Ivan send Pesho deka_izbega_be?
                </p>
                <p>
                    Ivan send Pesho pecaaa!!!
                </p>
                <p>
                    exit
                </p>
                <p>
                    Ivan Pesho
                </p>
            </td>
            <td width="290" valign="top">
                <p>
                    Ivan: pesho
                </p>
                <p>
                    kaji_vanka :Pesho
                </p>
                <p>
                    Ivan: pesho_tam_li_si?
                </p>
                <p>
                    tuk_sum :Pesho
                </p>
                <p>
                    Ivan: kvo_stava
                </p>
                <p>
                    chakai_che_bachkam :Pesho
                </p>
                <p>
                    Ivan: kak_si
                </p>
                <p>
                    Ivan: deka_izbega_be?
                </p>
                <p>
                    Ivan: pecaaa!!!
                </p>
            </td>
        </tr>
        <tr>
            <td width="318" valign="top">
                <p>
                    register John
                </p>
                <p>
                    John send Harry harry_you_there?
                </p>
                <p>
                    register Harry
                </p>
                <p>
                    John send Harry harry?
                </p>
                <p>
                    register Donald
                </p>
                <p>
                    Harry send John yeah_sorry_was_out...
                </p>
                <p>
                    Harry send John wassup?
                </p>
                <p>
                    Donald send John Yo_John?
                </p>
                <p>
                    Donald send Jonh You_there?
                </p>
                <p>
                    John send Harry thank_god!!
                </p>
                <p>
                    John send Harry I_need_you!
                </p>
                <p>
                    exit
                </p>
                <p>
                    John Harry
                </p>
            </td>
            <td width="290" valign="top">
                <p>
                    John: harry?
                </p>
                <p>
                    yeah_sorry_was_out... :Harry
                </p>
                <p>
                    John: thank_god!!
                </p>
                <p>
                    wassup? :Harry
                </p>
                <p>
                    John: I_need_you!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>