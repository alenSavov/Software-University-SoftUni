<h1>
    Exercises: Dictionaries
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
    <a href="https://judge.softuni.bg/Contests/431">
        https://judge.softuni.bg/Contests/431
    </a>
    .
</p>
<h2>
    1. Letter Repetition
</h2>
<p>
You will be given a <strong>single string</strong>, containing<strong>random ASCII character</strong>. Your task is to    <strong>print every character</strong>, and how <strong>many times</strong>
    it has been used in the <strong>string</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="285" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    aaabbaaabbbccc
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    a -&gt; 6
                </p>
                <p>
                    b -&gt; 5
                </p>
                <p>
                    c -&gt; 3
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    The quick brown fox jumps over the lazy dog
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    T -&gt; 1
                </p>
                <p>
                    h -&gt; 2
                </p>
                <p>
                    e -&gt; 3
                </p>
                <p>
                    -&gt; 8
                </p>
                <p>
                    q -&gt; 1
                </p>
                <p>
                    u -&gt; 2
                </p>
                <p>
                    i -&gt; 1
                </p>
                <p>
                    c -&gt; 1
                </p>
                <p>
                    k -&gt; 1
                </p>
                <p>
                    b -&gt; 1
                </p>
                <p>
                    r -&gt; 2
                </p>
                <p>
                    o -&gt; 4
                </p>
                <p>
                    w -&gt; 1
                </p>
                <p>
                    n -&gt; 1
                </p>
                <p>
                    f -&gt; 1
                </p>
                <p>
                    x -&gt; 1
                </p>
                <p>
                    j -&gt; 1
                </p>
                <p>
                    m -&gt; 1
                </p>
                <p>
                    p -&gt; 1
                </p>
                <p>
                    s -&gt; 1
                </p>
                <p>
                    v -&gt; 1
                </p>
                <p>
                    t -&gt; 1
                </p>
                <p>
                    l -&gt; 1
                </p>
                <p>
                    a -&gt; 1
                </p>
                <p>
                    z -&gt; 1
                </p>
                <p>
                    y -&gt; 1
                </p>
                <p>
                    d -&gt; 1
                </p>
                <p>
                    g -&gt; 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Dict-Ref
</h2>
<p>
    You have been tasked to create a referenced dictionary, or in other words a
    dictionary, which knows how to reference itself.
</p>
<p>
    You will be given several input lines, in one of the following formats:
</p>
<ul>
    <li>
        {name} = {value}
    </li>
    <li>
        {name} = {secondName}
    </li>
</ul>
<p>
The <strong>names</strong> will always be <strong>strings</strong>, and the    <strong>values</strong> will always be <strong>integers</strong>.
</p>
<p>
    In case you are given a <strong>name</strong> and a <strong>value</strong>,
you must store the <strong>given name</strong> and its    <strong>value</strong>. If the name already <strong>EXISTS</strong>, you
must <strong>CHANGE</strong> its <strong>value</strong> with the    <strong> given one</strong>.
</p>
<p>
In case you are given a <strong>name</strong> and a<strong>second name</strong>, you must <strong>store</strong> the<strong>given name</strong> with the <strong>same value</strong> as the<strong>value</strong> of the <strong>second name</strong>. If the given<strong>second name</strong> <strong>DOES NOT</strong> exist, you must    <strong>IGNORE</strong> that input.
</p>
<p>
When you receive the command “<strong>end</strong>”, you must print<strong>all</strong> <strong>entries</strong> with their    <strong>value</strong>, by <strong>order</strong> of <strong>input</strong>
    , in the following format:
</p>
<p>
    {entry} === {value}
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="205" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    Cash = 500
                </p>
                <p>
                    Johny = 5
                </p>
                <p>
                    Cash = 200
                </p>
                <p>
                    Johnny = 200
                </p>
                <p>
                    Car = 150
                </p>
                <p>
                    Plane = 2000000
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Cash === 200
                </p>
                <p>
                    Johny === 5
                </p>
                <p>
                    Johnny === 200
                </p>
                <p>
                    Car === 150
                </p>
                <p>
                    Plane === 2000000
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    Entry1 = 10000
                </p>
                <p>
                    Entry2 = 12345
                </p>
                <p>
                    Entry3 = 10101
                </p>
                <p>
                    Entry4 = Entry1
                </p>
                <p>
                    Entry2 = Entry3
                </p>
                <p>
                    Entry3 = Entry4
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Entry1 === 10000
                </p>
                <p>
                    Entry2 === 10101
                </p>
                <p>
                    Entry3 === 10000
                </p>
                <p>
                    Entry4 === 10000
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Mixed Phones
</h2>
<p>
    You will be given several phone entries, in the form of strings in format:
</p>
<p>
    {firstElement} : {secondElement}
</p>
<p>
    The first element is usually the person’s name, and the second one – his
    phone number. The phone number consists ONLY of digits, while the person’s
    name can consist of any ASCII characters.
</p>
<p>
    Sometimes the phone operator gets distracted by the Minesweeper she plays
all day, and gives you first the phone, and then the name.    <strong>e.g. : 0888888888 : Pesho</strong>. You must store them correctly,
    even in those cases.
</p>
<p>
When you receive the command “<strong>Over</strong>”, you are to    <strong>print all names</strong> you’ve stored with their phones. The names
    must be printed in <strong>alphabetical order</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="205" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    14284124 : Alex
                </p>
                <p>
                    Gosho : 088423123
                </p>
                <p>
                    Ivan : 412048192
                </p>
                <p>
                    123123123 : Nanyo
                </p>
                <p>
                    Pesho : 150925812
                </p>
                <p>
                    Over
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Alex -&gt; 14284124
                </p>
                <p>
                    Gosho -&gt; 88423123
                </p>
                <p>
                    Ivan -&gt; 412048192
                </p>
                <p>
                    Nanyo -&gt; 123123123
                </p>
                <p>
                    Pesho -&gt; 150925812
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    Ivan : 13213456
                </p>
                <p>
                    GeorgeThe2nd : 131313
                </p>
                <p>
                    Johnny : 5556322312
                </p>
                <p>
                    Donald : 3212
                </p>
                <p>
                    Over
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Donald -&gt; 3212
                </p>
                <p>
                    GeorgeThe2nd -&gt; 131313
                </p>
                <p>
                    Ivan -&gt; 13213456
                </p>
                <p>
                    Johnny -&gt; 5556322312
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Exam Shopping
</h2>
<p>
A supermarket has <strong>products</strong> which have<strong>quantities</strong>. Your task is to stock the shop before    <strong>Exam Sunday</strong>. Until you receive the command “shopping
    time”, <strong>add</strong> the various <strong>products</strong> to the
shop’s <strong>inventory</strong>, keeping track of their    <strong>quantity</strong> (for inventory purposes). When you receive the
aforementioned command, the students start pouring in before the exam and    <strong>buy</strong> various <strong>products</strong>.
</p>
<p>
    The format for <strong>stocking</strong> a product is: “stock {product}
    {quantity}”.
</p>
<p>
    The format for <strong>buying</strong> a product is: “buy {product}
    {quantity}”.
</p>
<p>
If a student <strong>tries</strong> to buy a product, which    <strong>doesn’t exist</strong>, print “{product} doesn't exist”. If it does
    exist, but it’s <strong>out of stock</strong>, print “{product} out of
    stock”. If a student tries buying <strong>more</strong> than the quantity
of that product, sell them <strong>all</strong> <strong>the</strong><strong>quantity</strong> of the product (the product is left out of stock,    <strong>don’t</strong> print anything).
</p>
<p>
When you receive the command “exam time”, your task is to    <strong>print</strong> the <strong>remaining</strong> inventory in the
    following format: “{product} -&gt; {quantity}”. If a product is out of
    stock, <strong>do not</strong> print it.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="205" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    stock Boca_Cola 10
                </p>
                <p>
                    stock Boca_Cola 10
                </p>
                <p>
                    stock Kay's 3
                </p>
                <p>
                    stock Kay's 2
                </p>
                <p>
                    shopping time
                </p>
                <p>
                    buy Boca_Cola 5
                </p>
                <p>
                    buy Kay's 5
                </p>
                <p>
                    exam time
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Boca_Cola -&gt; 15
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    stock Lobster_Energy 20
                </p>
                <p>
                    stock Loreni 30
                </p>
                <p>
                    stock Loreni 30
                </p>
                <p>
                    stock Lobster_Energy 10
                </p>
                <p>
                    shopping time
                </p>
                <p>
                    exam time
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Lobster_Energy -&gt; 30
                </p>
                <p>
                    Loreni -&gt; 60
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    stock Boca_Cola 16
                </p>
                <p>
                    stock Kay's_Chips 33
                </p>
                <p>
                    stock Lobster_Energy 60
                </p>
                <p>
                    stock Boca_Cola 4
                </p>
                <p>
                    stock Loreni 15
                </p>
                <p>
                    stock Loreni 15
                </p>
                <p>
                    stock Loreni 15
                </p>
                <p>
                    stock Loreni 15
                </p>
                <p>
                    shopping time
                </p>
                <p>
                    buy Boca_Bola 2
                </p>
                <p>
                    buy Lobster_Energy 20
                </p>
                <p>
                    buy Boca_Cola 1
                </p>
                <p>
                    buy Boba_Bola 12
                </p>
                <p>
                    exam time
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Boca_Bola doesn't exist
                </p>
                <p>
                    Boba_Bola doesn't exist
                </p>
                <p>
                    Boca_Cola -&gt; 19
                </p>
                <p>
                    Kay's_Chips -&gt; 33
                </p>
                <p>
                    Lobster_Energy -&gt; 40
                </p>
                <p>
                    Loreni -&gt; 60
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. User Logins
</h2>
<p>
Write a program that receives a <strong>list</strong> of    <strong>username-password pairs</strong> in the format “{username} -&gt;
{password}”. If there’s already a user with that username,    <strong>replace their password</strong>. After you receive the command
“login”, <strong>login requests</strong> start coming in, using the    <strong>same format</strong>. Your task is to print the status of user
    login, using different messages as per the conditions below:
</p>
<p>
    · If the password matches with the user’s password, print “{username}:
    logged in successfully”.
</p>
<p>
    · If the user doesn’t exist, or the password doesn’t match the user, print
    “{username}: login failed”.
</p>
<p>
When you receive the command “end”, print the <strong>count</strong> of    <strong>unsuccessful</strong> login attempts, using the format
    “unsuccessful login attempts: {count}”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="261" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="326" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    ivan_ivanov -&gt; java123
                </p>
                <p>
                    pesh0 -&gt; qwerty
                </p>
                <p>
                    stamat4e -&gt; 111111
                </p>
                <p>
                    princess_penka -&gt; MyPrince
                </p>
                <p>
                    <strong>login</strong>
                </p>
                <p>
                    pesh0 -&gt; qwertt
                </p>
                <p>
                    ivan_ivanov -&gt; java123
                </p>
                <p>
                    stamat4e -&gt; 111112
                </p>
                <p>
                    princess_penka -&gt; MyPrince
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    pesh0: login failed
                </p>
                <p>
                    ivan_ivanov: logged in successfully
                </p>
                <p>
                    stamat4e: login failed
                </p>
                <p>
                    princess_penka: logged in successfully
                </p>
                <p>
                    unsuccessful login attempts: 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    johnny_bravo05 -&gt; woahMama
                </p>
                <p>
                    <strong>login</strong>
                </p>
                <p>
                    johnny_bravo06 -&gt; woahMama
                </p>
                <p>
                    johnny_bravo05 -&gt; woahmama
                </p>
                <p>
                    johnny_bravo05 -&gt; WoahMama
                </p>
                <p>
                    johnny_bravo05 -&gt; wohMama
                </p>
                <p>
                    johnny_bravo05 -&gt; woahMama
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    johnny_bravo06: login failed
                </p>
                <p>
                    johnny_bravo05: login failed
                </p>
                <p>
                    johnny_bravo05: login failed
                </p>
                <p>
                    johnny_bravo05: login failed
                </p>
                <p>
                    johnny_bravo05: logged in successfully
                </p>
                <p>
                    unsuccessful login attempts: 4
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    walter_white58 -&gt; iamthedanger
                </p>
                <p>
                    krazy_8 -&gt; ese
                </p>
                <p>
                    jesseABQ -&gt; bword
                </p>
                <p>
                    <strong>login</strong>
                </p>
                <p>
                    krazy_8 -&gt; ese
                </p>
                <p>
                    krazy_8 -&gt; ese
                </p>
                <p>
                    jesse -&gt; bword
                </p>
                <p>
                    jesseabq -&gt; bword
                </p>
                <p>
                    walter_white58 -&gt; IAmTheDanger
                </p>
                <p>
                    walter_white58 -&gt; iamthedanger
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    krazy_8: logged in successfully
                </p>
                <p>
                    krazy_8: logged in successfully
                </p>
                <p>
                    jesse: login failed
                </p>
                <p>
                    jesseabq: login failed
                </p>
                <p>
                    walter_white58: login failed
                </p>
                <p>
                    walter_white58: logged in successfully
                </p>
                <p>
                    unsuccessful login attempts: 3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<ul>
    <li>
        <strong>Parse the commands</strong>
        by splitting by space. The first element is the username, while the
        third element is the password.
    </li>
    <li>
Store the <strong>user entries</strong> in<strong>Dictionary&lt;string, string&gt;</strong> with key        <strong>{username}</strong> and value <strong>{password}</strong>.
    </li>
</ul>
<h2>
    6. Filter Base
</h2>
<p>
    You have been tasked to sort out a database full of information about
    employees. You will be given several input lines containing information in
    one of the following formats:
</p>
<ul>
    <li>
        {name} -&gt; {age}
    </li>
    <li>
        {name} -&gt; {salary}
    </li>
    <li>
        {name} -&gt; {position}
    </li>
</ul>
<p>
    As you see you have 2 parameters. There can be only 3 cases of input:
    <br/>
    If the second parameter is an <strong>integer</strong>, you must store it
    as <strong>name</strong> and <strong>age</strong>.
</p>
<p>
    If the second parameter is a <strong>floating-point number</strong>, you
    must store it as <strong>name</strong> and <strong>salary</strong>.
</p>
<p>
If the second parameter is a <strong>string</strong>, you must store it as    <strong>name</strong> and <strong>position</strong>.
</p>
<p>
You must read input lines, then parse and store the information from them,    <strong>until</strong> you receive the command
    <br/>
“<strong>filter base</strong>”. When you receive that command, the    <strong>input sequence</strong> of <strong>employee information</strong>
    should <strong>end</strong>.
</p>
<p>
On the last line of input you will receive a string, which can either be “<strong>Age</strong>”, “<strong>Salary</strong>” or “<strong>Position</strong>”. Depending on the case, you must    <strong>print all entries</strong> which <strong>have been stored</strong>
    as <strong>name</strong> and <strong>age</strong>, <strong>name</strong>
and <strong>salary</strong>, or <strong>name</strong> and    <strong>position</strong>.
</p>
<p>
    In case, the given last line is “<strong>Age</strong>”, you must print
    every employee, stored with its <strong>age</strong> in the following
    format:
</p>
<p>
    Name: {name1}
    <br/>
    Age: {age1}
    <br/>
    ====================
    <br/>
    Name: {name2}
    <br/>
    . . .
</p>
<p>
    In case, the given last line is “<strong>Salary</strong>”, you must print
    every employee, stored with its <strong>salary</strong> in the following
    format:
</p>
<p>
    Name: {name1}
    <br/>
    Salary: {salary1}
    <br/>
    ====================
    <br/>
    Name: {name2}
    <br/>
    . . .
</p>
<p>
    <strong>NOTE: </strong>
The <strong>Salary </strong>must be <strong>formatted</strong> to    <strong>2 digits</strong> after the decimal point.
</p>
<p>
    In case, the given last line is “<strong>Position</strong>”, you must print
    every employee, stored with its <strong>position</strong> in the following
    format:
</p>
<p>
    Name: {name1}
    <br/>
    Position: {position1}
    <br/>
    ====================
    <br/>
    Name: {name2}
    <br/>
    . . .
</p>
<p>
    <strong>NOTE:</strong>
    Every entry is <strong>separated</strong> with the <strong>other</strong>,
with a <strong>string</strong> of <strong>20 character</strong>    <strong>‘=</strong>’.
</p>
<p>
    There is <strong>NO</strong> particular order of printing – the data must
    be printed in <strong>order</strong> of <strong>input</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="205" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    Isacc -&gt; 34
                </p>
                <p>
                    Peter -&gt; CEO
                </p>
                <p>
                    Isacc -&gt; 4500.054321
                </p>
                <p>
                    George -&gt; Cleaner
                </p>
                <p>
                    John -&gt; Security
                </p>
                <p>
                    Nina -&gt; Secretary
                </p>
                <p>
                    filter base
                </p>
                <p>
                    Position
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Name: Peter
                </p>
                <p>
                    Position: CEO
                </p>
                <p>
                    ====================
                </p>
                <p>
                    Name: George
                </p>
                <p>
                    Position: Cleaner
                </p>
                <p>
                    ====================
                </p>
                <p>
                    Name: John
                </p>
                <p>
                    Position: Security
                </p>
                <p>
                    ====================
                </p>
                <p>
                    Name: Nina
                </p>
                <p>
                    Position: Secretary
                </p>
                <p>
                    ====================
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    Ivan -&gt; Chistach
                </p>
                <p>
                    Pesho -&gt; Ohrana
                </p>
                <p>
                    Pesho -&gt; 1323.0456
                </p>
                <p>
                    Ivan -&gt; 732.404
                </p>
                <p>
                    Georgi -&gt; 21
                </p>
                <p>
                    Georgi -&gt; 21.02
                </p>
                <p>
                    filter base
                </p>
                <p>
                    Salary
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Name: Pesho
                </p>
                <p>
                    Salary: 1323.05
                </p>
                <p>
                    ====================
                </p>
                <p>
                    Name: Ivan
                </p>
                <p>
                    Salary: 732.40
                </p>
                <p>
                    ====================
                </p>
                <p>
                    Name: Georgi
                </p>
                <p>
                    Salary: 21.02
                </p>
                <p>
                    ====================
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints:
</h3>
<p>
Use int.TryParse() and double.TryParse() to find out in<strong>which case</strong> are you and where to <strong>store</strong> the    <strong>data</strong>.
</p>