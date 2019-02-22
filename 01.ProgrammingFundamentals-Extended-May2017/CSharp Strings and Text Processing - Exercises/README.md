<h1>
    Exercises: Strings and Text Processing
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
    <a href="https://judge.softuni.bg/Contests/441">
        https://judge.softuni.bg/Contests/441
    </a>
    .
</p>
<h2>
    1. Placeholders
</h2>
<p>
    Placeholders in C# are really comfortable for use, right? How about you
    implement them to see just how easy they are.
</p>
<p>
    You will be given input lines containing a string with placeholders, i.e.
    “This is {0}. And that is {1}.”.
</p>
<p>
    The input lines will be in the following format:
</p>
<p>
    {someString} -&gt; {someElement}, {someElement2}
</p>
<p>
    You have to <strong>replace</strong> the <strong>placeholders</strong> in
the <strong>string</strong>, with the <strong>elements</strong><strong>given after that</strong>, <strong>separated</strong> by a<strong>comma</strong> and a <strong>space</strong>. <strong>Each</strong>    <strong>element</strong> has an <strong>index</strong>, so you must give
them the <strong>right order</strong>. The    <strong>first given element </strong>goes where the <strong>0</strong> is,
    the <strong>second</strong> to the <strong>1</strong>, and so on…
</p>
<p>
Print <strong>each</strong> <strong>string</strong>, with its<strong>replaced</strong> <strong>placeholders</strong>,<strong>RIGHT after you’ve read it</strong>, and    <strong>BEFORE reading</strong> the <strong>next one</strong>.
</p>
<p>
    The input ends when you receive the command “<strong>end</strong>”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="361" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="361" valign="top">
                <p>
                    I have a {0} and a {1} -&gt; car, house
                </p>
                <p>
                    Cool, and I have a {0}. -&gt; yacht
                </p>
                <p>
                    Darn... You beat me {0} {1} -&gt; with, this
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    I have a car and a house
                </p>
                <p>
                    Cool, and I have a yacht.
                </p>
                <p>
                    Darn... You beat me with this
                </p>
            </td>
        </tr>
        <tr>
            <td width="361" valign="top">
                <p>
                    This is {2} {1} {0}. -&gt; ment, I, what
                </p>
                <p>
                    And this is what you ment. -&gt; nothing
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    This is what I ment.
                </p>
                <p>
                    And this is what you ment.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hint
</h3>
<p>
    · Due to the fact that the sentences hold spaces, you cannot split the
    sentence and the values, by space. There should be functionality in C#
    which removes the border spaces from a string, if you split it by
    <br/>
    “-&gt;”, though.
</p>
<ul>
    <li>
You might have to <strong>split first</strong> the<strong>sentence</strong> and the <strong>values</strong>, and<strong>then the values</strong>, because their<strong>delimiter</strong> <strong>contains</strong> a        <strong>space</strong>.
    </li>
</ul>
<h2>
    2. JSON stringify
</h2>
<p>
JSON is a syntax for storing and exchanging data. It comes from<strong>J</strong>ava<strong>S</strong>cript <strong>O</strong>bject    <strong>N</strong>otation. You have been tasked to create a database of
    students, and stored them in a JSON format.
</p>
<p>
First, create a <strong>class Student</strong>, which will represent our<strong>data</strong> <strong>model</strong> – it will hold our<strong>data</strong>. The <strong>Student</strong> should have<strong>Name</strong> (<strong>string</strong>), <strong>Age</strong> (<strong>integer</strong>), and <strong>Grades</strong> (    <strong>Collection</strong> of <strong>integer numbers</strong>).
</p>
<p>
    This will be enough to store our data. We’ll need a collection of Students,
    since we will store a lot of students.
</p>
<p>
    And now let’s see the input and output formats.
</p>
<p>
    The input will consist of several input lines in the following format:
</p>
<p>
    {name} : {age} -&gt; {grade1}, {grade2}, {grade3}. . .
</p>
<p>
    Store every student with its <strong>name</strong>, <strong>age</strong>
and <strong>given grades</strong>. The <strong>name</strong> will be a<strong>string</strong> which can contain <strong>any</strong>    <strong>ASCII</strong> characters except <strong>space </strong>(“ “), “:”,
“-”, “&gt;”, “,”. The <strong>age</strong> will be an<strong>integer</strong>. The <strong>grades</strong> will be    <strong>integer numbers</strong>.
</p>
<p>
    When you receive the command “<strong>stringify</strong>”, the input
    sequence ends.
</p>
<p>
    You should print the <strong>collection of students</strong> in the
    following format: [{student1},{student2}. . .]
</p>
<p>
    Each student must be printed in the following format:
</p>
<p>
    {name:”{name}”,age:{age},grades:[{grade1}, {grade2}. . .]}
</p>
<p>
    See the examples for more info.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="191" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="566" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Pesho : 25 -&gt; 6, 6, 5
                </p>
                <p>
                    Gosho : 10 -&gt; 3, 3, 4
                </p>
                <p>
                    Ivan : 28 -&gt; 2, 2, 3
                </p>
                <p>
                    stringify
                </p>
            </td>
            <td width="566" valign="top">
                <p>
                    [{name:"Pesho",age:25,grades:[6, 6,
                    5]},{name:"Gosho",age:10,grades:[3, 3,
                    4]},{name:"Ivan",age:28,grades:[2, 2, 3]}]
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Johnny : 11 -&gt; 6, 4, 3
                </p>
                <p>
                    Peter : 10 -&gt; 5, 5, 4
                </p>
                <p>
                    Jordan : 13 -&gt; 6, 6
                </p>
                <p>
                    Donald : 10 -&gt;
                </p>
                <p>
                    Isacc : 20 -&gt; 2, 2, 3
                </p>
                <p>
                    Alex : 11 -&gt; 6, 6, 3
                </p>
                <p>
                    stringify
                </p>
            </td>
            <td width="566" valign="top">
                <p>
                    [{name:"Johnny",age:11,grades:[6, 4,
                    3]},{name:"Peter",age:10,grades:[5, 5,
                    4]},{name:"Jordan",age:13,grades:[6,
                    6]},{name:"Donald",age:10,grades:[]},{name:"Isacc",age:20,grades:[2,
                    2, 3]},{name:"Alex",age:11,grades:[6, 6, 3]}]
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. JSON parse
</h2>
<p>
    Stringifying a JSON was easy? You want something harder?
</p>
<p>
    Well … JSON parse is your problem. You will receive a JSON collection of
    students. You need to parse it to Student objects.
</p>
<p>
    The input will consist of a single line containing the students’ info. The
    students will be given in the following way:
</p>
<p>
    [{student1},{student2}. . .]
</p>
<p>
    Each student will be given in the following format:
</p>
<p>
    {name:”{name}”,age:{age},grades:[{grade1}, {grade2}. . .]}
</p>
<p>
    Parse the input data, and print each student in the following way.
</p>
<p>
    {name} : {age} -&gt; {grade1}, {grade2}, {grade3}. . .
</p>
<p>
    In case there are <strong>NO grades</strong>, print “None”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="560" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="136" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="560" valign="top">
                <p>
                    [{name:"Pesho",age:25,grades:[6, 6,
                    5]},{name:"Gosho",age:10,grades:[3, 3,
                    4]},{name:"Ivan",age:28,grades:[2, 2, 3]}]
                </p>
            </td>
            <td width="136" valign="top">
                <p>
                    Pesho : 25 -&gt; 6, 6, 5
                </p>
                <p>
                    Gosho : 10 -&gt; 3, 3, 4
                </p>
                <p>
                    Ivan : 28 -&gt; 2, 2, 3
                </p>
            </td>
        </tr>
        <tr>
            <td width="560" valign="top">
                <p>
                    [{name:"Johnny",age:11,grades:[6, 4,
                    3]},{name:"Peter",age:10,grades:[5, 5,
                    4]},{name:"Jordan",age:13,grades:[6,
                    6]},{name:"Donald",age:10,grades:[]},{name:"Isacc",age:20,grades:[2,
2, 3]},{name:"Alex",age:11,grades:[6, 6, 3]}]                    <strong></strong>
                </p>
            </td>
            <td width="136" valign="top">
                <p>
                    Johnny : 11 -&gt; 6, 4, 3
                </p>
                <p>
                    Peter : 10 -&gt; 5, 5, 4
                </p>
                <p>
                    Jordan : 13 -&gt; 6, 6
                </p>
                <p>
                    Donald : 10 -&gt; None
                </p>
                <p>
                    Isacc : 20 -&gt; 2, 2, 3
                </p>
                <p>
                    Alex : 11 -&gt; 6, 6, 3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Sentence Split
</h2>
<p>
    Splitting the input by a given delimiter is easy, especially when you are
    told in the problem descriptions, that the elements will not contain the
    delimiter. What if, however, they do.
</p>
<p>
You will be <strong>given a sentence</strong>, which may contain    <strong>ANY ASCII CHARACTER</strong>.
    <br/>
    Then you will be <strong>given</strong> a <strong>delimiter</strong>, which
    may <strong>ALSO</strong> contain <strong>ANY ASCII CHARACTER</strong>.
</p>
<p>
Your task is to <strong>split the sentence</strong>, by the    <strong>given</strong> <strong>delimiter</strong>, and print each of the
    elements, in the following format:
</p>
<p>
    [{element1}, {element2}, {element3}. . .]
</p>
<p>
    See the examples for more info.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="324" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="324" valign="top">
                <p>
                    This will be hard, right. Nope!
                </p>
                <p>
                    . <strong>(dot and space)</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    [This will be hard, right, Nope!]
                </p>
            </td>
        </tr>
        <tr>
            <td width="324" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">Bau, Chika, Bow Wow</a>
                </p>
                <p>
                    , <strong>(comma and space)</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    [Bau, Chika, Bow Wow]
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Capitalize Words
</h2>
<p>
    Create a program, which receives sentences of words, and capitalizes the
    words in them.
</p>
<p>
    The sentences will follow a <strong>correct grammatical order</strong>. You
    must <strong>extract</strong> <strong>each</strong> <strong>word</strong>
    from the sentences, and you must <strong>capitalize</strong> it.
</p>
<p>
    The <strong>capitalization</strong> of a <strong>word</strong>, is the
process of making the <strong>first letter</strong> from it –<strong>Capital</strong>, and <strong>every other</strong> –    <strong>lowercase</strong>.
</p>
<p>
You should read input lines, until you receive the command “    <strong>end</strong>”.
</p>
<p>
You <strong>might</strong> receive <strong>SEVERAL sentences</strong> on    <strong>1 input line</strong>.
</p>
<p>
After you’ve read a sentence, you extract the words,<strong>capitalize them</strong>, and <strong>print them</strong>,<strong>separated</strong> by a <strong>space</strong> and a<strong>comma</strong>. <strong>ONLY </strong>then you should    <strong>read</strong> the <strong>next sentence</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="324" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="324" valign="top">
                <p>
                    This is funny.
                </p>
                <p>
                    This is not.
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    This, Is, Funny
                </p>
                <p>
                    This, Is, Not
                </p>
            </td>
        </tr>
        <tr>
            <td width="324" valign="top">
                <p>
                    Let’s... gEt... iT RoCKing In HeRE!!!
                </p>
                <p>
                    PartY rock ANTHEM! ! !
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    Let’s, Get, It, Rocking, In, Here
                </p>
                <p>
                    Party, Rock, Anthem
                </p>
            </td>
        </tr>
    </tbody>
</table>