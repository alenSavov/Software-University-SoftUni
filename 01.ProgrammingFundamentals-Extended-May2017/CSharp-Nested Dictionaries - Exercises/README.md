<h1>
    Exercises: Advanced Collections
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        “Programming Fundamentals” course @ SoftUni
    </a>
    .
</p>
<p>
    Check your solutions here:
    <a href="https://judge.softuni.bg/Contests/433">
        https://judge.softuni.bg/Contests/433/Advanced-Collections-Exercises
    </a>
    .
</p>
<h2>
    1. Wardrobe
</h2>
<p>
    You just bought a new wardrobe. The weird thing about it is that it came
    prepackaged with a big box of clothes (just like those refrigerators, which
    ship with free beer inside them)! So, you’ll need to find something to
    wear.
</p>
<h3>
    Input
</h3>
<p>
On the first line of the input, you will receive n – the    <strong>number of lines</strong> of clothes, which came prepackaged for the
    wardrobe.
</p>
<p>
    On the next n lines, you will receive the clothes for each color in the
    format:
</p>
<p>
    · “{color} -&gt; {item1},{item2},{item3}…”
</p>
<p>
If a color is added a <strong>second</strong> time, <strong>add</strong><strong>all items</strong> from it and <strong>count</strong> the    <strong>duplicates</strong>.
</p>
<p>
    <strong>Finally</strong>
    , you will receive the<strong> color </strong>and <strong>item</strong> of
    the clothing, that you need to look for.
</p>
<h3>
    Output
</h3>
<p>
    Go through all the <strong>colors</strong> of the clothes and print them in
    the following format:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="176" valign="top">
                <p>
                    <strong>{color}</strong>
                    clothes:
                </p>
                <p>
                    * <strong>{item1}</strong> - <strong>{count}</strong>
                </p>
                <p>
                    * <strong>{item2}</strong> - <strong>{count}</strong>
                </p>
                <p>
                    * <strong>{item3}</strong> - <strong>{count}</strong>
                </p>
                <p>
                    …
                </p>
                <p>
                    * <strong>{itemN}</strong> - <strong>{count}</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
If the <strong>color</strong> lines up with the    <strong>clothing item</strong>, print “(found!)” alongside the item. See
    the examples to better understand the output.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="196" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="245" valign="top">
                <p>
                    4
                </p>
                <p>
                    Blue -&gt; dress,jeans,hat
                </p>
                <p>
                    Gold -&gt; dress,t-shirt,boxers
                </p>
                <p>
                    White -&gt; briefs,tanktop
                </p>
                <p>
                    Blue -&gt; gloves
                </p>
                <p>
                    Blue dress
                </p>
            </td>
            <td width="196" valign="top">
                <p>
                    Blue clothes:
                </p>
                <p>
                    * dress - 1 (found!)
                </p>
                <p>
                    * jeans - 1
                </p>
                <p>
                    * hat - 1
                </p>
                <p>
                    * gloves - 1
                </p>
                <p>
                    Gold clothes:
                </p>
                <p>
                    * dress - 1
                </p>
                <p>
                    * t-shirt - 1
                </p>
                <p>
                    * boxers - 1
                </p>
                <p>
                    White clothes:
                </p>
                <p>
                    * briefs - 1
                </p>
                <p>
                    * tanktop - 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="245" valign="top">
                <p>
                    4
                </p>
                <p>
                    Red -&gt; hat
                </p>
                <p>
                    Red -&gt; dress,t-shirt,boxers
                </p>
                <p>
                    White -&gt; briefs,tanktop
                </p>
                <p>
                    Blue -&gt; gloves
                </p>
                <p>
                    White tanktop
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Red clothes:
                </p>
                <p>
                    * hat - 1
                </p>
                <p>
                    * dress - 1
                </p>
                <p>
                    * t-shirt - 1
                </p>
                <p>
                    * boxers - 1
                </p>
                <p>
                    White clothes:
                </p>
                <p>
                    * briefs - 1
                </p>
                <p>
                    * tanktop - 1 (found!)
                </p>
                <p>
                    Blue clothes:
                </p>
                <p>
                    * gloves - 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="245" valign="top">
                <p>
                    5
                </p>
                <p>
                    Blue -&gt; shoes
                </p>
                <p>
                    Blue -&gt; shoes,shoes,shoes
                </p>
                <p>
                    Blue -&gt; shoes,shoes
                </p>
                <p>
                    Blue -&gt; shoes
                </p>
                <p>
                    Blue -&gt; shoes,shoes
                </p>
                <p>
                    Red tanktop
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Blue clothes:
                </p>
                <p>
                    * shoes - 9
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Key-Key Value-Value
</h2>
<p>
Write a program, which searches for a <strong>key</strong> and    <strong>value</strong> inside of several <strong>key-value</strong> pairs.
</p>
<h3>
    Input
</h3>
<ul>
    <li>
On the <strong>first</strong> line, you will receive a        <strong>key</strong>.
    </li>
    <li>
On the <strong>second</strong> line, you will receive a        <strong>value</strong>.
    </li>
    <li>
        On the <strong>third</strong> line, you will receive <strong>N</strong>
        .
    </li>
    <li>
        On the next <strong>N</strong> lines, you will receive strings in the
        following format:
    </li>
</ul>
<p>
    “key =&gt; {value 1};{value 2};…{value X}”
</p>
<p>
    After you receive <strong>N</strong> <strong>key -&gt; values</strong>
pairs, your task is to go through them and print <strong>only </strong>the<strong>keys</strong>, which contain the <strong>key </strong>and the    <strong>values</strong>, which contain the <strong>value</strong>. Print
    them in the following format:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="89" valign="top">
                <p>
                    <strong>{key}</strong>
                    :
                </p>
                <p>
                    -<strong>{value1}</strong>
                </p>
                <p>
                    -<strong>{value2}</strong>
                </p>
                <p>
                    …
                </p>
                <p>
                    -<strong>{valueN}</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="145" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="245" valign="top">
                <p>
                    bug
                </p>
                <p>
                    X
                </p>
                <p>
                    3
                </p>
                <p>
                    invalidkey =&gt; testval;x;y
                </p>
                <p>
                    debug =&gt; XUL;ccx;XC
                </p>
                <p>
                    buggy =&gt; testX;testY;XtestZ
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    debug:
                </p>
                <p>
                    -XUL
                </p>
                <p>
                    -XC
                </p>
                <p>
                    buggy:
                </p>
                <p>
                    -testX
                </p>
                <p>
                    -XtestZ
                </p>
            </td>
        </tr>
        <tr>
            <td width="245" valign="top">
                <p>
                    key
                </p>
                <p>
                    valu
                </p>
                <p>
                    2
                </p>
                <p>
                    xkeyc =&gt; value;value;valio
                </p>
                <p>
                    keyhole =&gt; valuable;x;values
                </p>
            </td>
            <td width="145" valign="top">
                <p>
                    xkeyc:
                </p>
                <p>
                    -value
                </p>
                <p>
                    -value
                </p>
                <p>
                    keyhole:
                </p>
                <p>
                    -valuable
                </p>
                <p>
                    -values
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Travel Company
</h2>
<p>
    Write a program, which categorizes information about a travel company.
</p>
<p>
    Companies have various vehicles planned for different cities. Every city
    has prepared several <strong>types of vehicles</strong>. Each vehicle type
    has a different <strong>capacity</strong>.
</p>
<p>
Until you receive the command “ready”, you will receive all the    <strong>cities</strong> the company offers holiday packages for, and their
    respective <strong>vehicle types </strong>+ <strong>capacities</strong> in
    the format:
</p>
<ul>
    <li>
        “{city}:{type}-{capacity},{type}-{capacity}…”
    </li>
</ul>
<p>
    An example city with its transportation options would look like this:
</p>
<ul>
    <li>
        “Athens:bus-40,airplane-300,train-150”
    </li>
</ul>
<p>
    If a city is entered a <strong>second time</strong>, add all transport
which <strong>hasn’t already been added</strong> and    <strong>replace</strong> <strong>existing</strong> transports’ capacities
    with the <strong>new</strong> ones.<strong></strong>
</p>
<p>
    After the “ready” command, you will start receiving <strong>groups</strong>
    for various cities in the format: “{city} {peopleCount}” until you receive
    “travel time!”.
</p>
<p>
After that, calculate whether the <strong>group</strong> will have    <strong>enough seats</strong> to accommodate the passengers and print the
    status per these conditions:
</p>
<p>
If the group’s size is <strong>smaller than or equal to</strong> the    <strong>combines seats </strong>in all the vehicles, print:
</p>
<ul>
    <li>
        “{city} -&gt; all {peopleCount} accommodated”
    </li>
</ul>
<p>
If the group’s size is <strong>larger than</strong> the    <strong>combines seats </strong>in all the vehicles, print:
</p>
<p>
    · “{city} -&gt; all except {peopleCount - transportCapacities}
    accommodated”
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        There will be <strong>no redundant whitespaces</strong> anywhere in the
        input.
    </li>
    <li>
The input will <strong>always</strong> be in the        <strong>format specified</strong>.
    </li>
    <li>
The <strong>group cities</strong> will <strong>always</strong> be        <strong>existing </strong>cities.
    </li>
    <li>
The <strong>group sizes </strong>will <strong>always</strong> be        <strong>positive</strong>.
    </li>
</ul>
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
            <td width="326" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="310" valign="top">
                <p>
                    Athens:bus-40,airplane-300,train-150
                </p>
                <p>
                    Athens:minibus-8,airplane-350
                </p>
                <p>
                    Warsaw:bus-30,train-150,airplane-120
                </p>
                <p>
                    ready
                </p>
                <p>
                    Athens 400
                </p>
                <p>
                    Warsaw 500
                </p>
                <p>
                    travel time!
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    Athens -&gt; all 400 accommodated
                </p>
                <p>
                    Warsaw -&gt; all except 200 accommodated
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="310" valign="top">
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
            <td width="310" valign="top">
                <p>
                    Sofia:bus-30,airplane-150,train-25
                </p>
                <p>
                    Istanbul:minibus-6,train-80
                </p>
                <p>
                    Sofia:bus-45
                </p>
                <p>
                    Sofia:bus-50
                </p>
                <p>
                    Berlin:airplane-120
                </p>
                <p>
                    ready
                </p>
                <p>
                    Berlin 115
                </p>
                <p>
                    Istanbul 200
                </p>
                <p>
                    Sofia 200
                </p>
                <p>
                    travel time!
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    Berlin -&gt; all 115 accommodated
                </p>
                <p>
                    Istanbul -&gt; all except 114 accommodated
                </p>
                <p>
                    Sofia -&gt; all 200 accommodated
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Shellbound
</h2>
<p>
    Vladi is a crab. Crabs are scared of almost anything, which is why they
    usually hide in their shells. Vladi is a rich crab though. He has acquired
    many outer shells, in different regions, in which he can hide – each with a
    different size.
</p>
<p>
    However, it is really annoying to look after all your shells when they are
so spread out. That is why Vladi decided to <strong>merge</strong><strong>all</strong> shells in <strong>each</strong> region, so that he has<strong>one</strong> <strong>big</strong> <strong>shell</strong> for    <strong>every</strong> <strong>region</strong>. He needs your help to do
    that.
</p>
<p>
    You will be given several input lines containing a <strong>string</strong>
and an <strong>integer</strong>, <strong>separated</strong> by a<strong>space</strong>. The <strong>string</strong> will represent the    <strong>region’s name</strong>, and the <strong>integer</strong> – the
    shell in the <strong>given region</strong>, <strong>size</strong>.
</p>
<p>
    You must store all shells in their corresponding regions.
    <br/>
If the region <strong>already exists</strong>, <strong>add</strong> the    <strong>new shell</strong> to it. Make sure you have <strong>NO</strong>
    duplicate shells (shells with <strong>same size</strong>). Vladi doesn’t
    like shells to have the same size.
</p>
<p>
    When you receive the command “Aggregate”, you must stop reading input
lines, and you must print <strong>every region</strong>,<strong>all of the shells</strong> in that region, and the    <strong>size</strong> of the <strong>giant shell</strong> after you’ve
    merged them in the following format:
</p>
<p>
    {regionName} -&gt; {shell 1, shell 2…, shell n…} ({giantShell})
</p>
<p>
The giant shell size is calculated when you <strong>subtract</strong> the    <strong>average</strong> of the shells from the <strong>sum</strong> of the
    shells.
    <br/>
    Or in other words: (sum of shells) – ((sum of shells) / (count of shells)).
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        All numeric data will be represented with <strong>integer</strong>
        variables in <strong>range </strong>[0…1.000.000.000].
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="189" valign="top">
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
            <td width="189" valign="top">
                <p>
                    Sofia 50
                </p>
                <p>
                    Sofia 20
                </p>
                <p>
                    Sofia 30
                </p>
                <p>
                    Varna 10
                </p>
                <p>
                    Varna 20
                </p>
                <p>
                    Aggregate
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Sofia -&gt; 50, 20, 30 (67)
                </p>
                <p>
                    Varna -&gt; 10, 20 (15)
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Sofia 2
                </p>
                <p>
                    Sofia 1
                </p>
                <p>
                    Plovdiv 100
                </p>
                <p>
                    Plovdiv 50
                </p>
                <p>
                    Aggregate
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Sofia -&gt; 2, 1 (2)
                </p>
                <p>
                    Plovdiv -&gt; 100, 50 (75)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Dict-Ref-Advanced
</h2>
<p>
    Remember the Dict-Ref Problem from the previous exercise? Well this one is
    an Advanced Version.
</p>
<p>
    You will begin receiving input lines containing information in one of the
    following formats:
</p>
<p>
    · {key} -&gt; {value 1, value 2, …, value n}
</p>
<p>
    · {key} -&gt; {otherKey}
</p>
<p>
The <strong>keys</strong> will always be <strong>strings</strong>, and the<strong>values</strong> will always be <strong>integers</strong>,<strong>separated</strong> by a <strong>comma</strong> and a    <strong>space</strong>.
</p>
<p>
    If you are <strong>given a key</strong> and <strong>values</strong>, you
must <strong>store</strong> the <strong>values</strong> to the<strong>given key</strong>. If the <strong>key</strong> already<strong>exists</strong>, you must <strong>add</strong> the    <strong>given values</strong> to the old ones.
</p>
<p>
    If you are <strong>given a key</strong> and <strong>another key</strong>,
you must <strong>copy</strong> the <strong>values</strong> of the<strong>other key</strong> to the <strong>first one</strong>. If the    <strong>other key</strong> <strong>does not exist</strong>, this input line
    must be <strong>IGNORED</strong>.
</p>
<p>
    When you receive the command “<strong>end</strong>”, you must stop reading
    input lines, and you must print all keys with their values, in the
    following format:
</p>
<p>
    · {key} === {value1, value2, value3. . .}
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="189" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Isacc -&gt; 5, 4, 3
                </p>
                <p>
                    Peter -&gt; 6, 3, 3
                </p>
                <p>
                    Derek -&gt; 2, 2, 2
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Isacc === 5, 4, 3
                </p>
                <p>
                    Peter === 6, 3, 3
                </p>
                <p>
                    Derek === 2, 2, 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Donald -&gt; 2, 2, 2
                </p>
                <p>
                    Isacc -&gt; 1
                </p>
                <p>
                    George -&gt; John
                </p>
                <p>
                    John -&gt; Isacc
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Donald === 2, 2, 2
                </p>
                <p>
                    Isacc === 1
                </p>
                <p>
                    John === 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Forum Topics
</h2>
<p>
    You have been tasked to store a few forum topics, and filter them by
    several given tags.
    <br/>
    You will be given several input lines, containing data about topics in the
    following format:
</p>
<p>
    {topic} -&gt; {tag1, tag2, tag3...}
</p>
<p>
    <strong>
        The topic and tags will be strings. They will NOT contain spaces or ‘
    </strong>
    -<strong>’, ‘</strong>&gt;<strong>’ symbols.</strong><strong></strong>
</p>
<p>
    <strong>
        If you receive an existing topic, you must add the new tags to it.
        There should be NO duplicate tags.
    </strong>
    <strong></strong>
</p>
<p>
    <strong>When you receive the command “</strong>
    filter
    <strong>
        ”, you must end the input sequence. On the next line (after “
    </strong>
    filter
    <strong>
        ”), you will receive a sequence of tags, separated by a comma and a
        space. You must print ONLY those topics, which contain all tags in the
        given sequence.
    </strong>
    <strong></strong>
</p>
<p>
    <strong>
        The topics must be printed in the following format:
        <br/>
    </strong>
    {topic} | {#tag1, #tag2, …, #tagN}
</p>
<p>
    <strong>NOTE: The tags have a number sign (‘</strong>
    #<strong>’) as a prefix.</strong><strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="353" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="342" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="353" valign="top">
                <p>
                    HelloWorld -&gt; hello, forum, topic
                </p>
                <p>
                    HelpWithHomework -&gt; homework, forum, topic
                </p>
                <p>
                    filter
                </p>
                <p>
                    forum, topic
                </p>
            </td>
            <td width="342" valign="top">
                <p>
                    HelloWorld | #hello, #forum, #topic
                </p>
                <p>
                    HelpWithHomework | #homework, #forum, #topic
                </p>
            </td>
        </tr>
        <tr>
            <td width="353" valign="top">
                <p>
                    First -&gt; this
                </p>
                <p>
                    First -&gt; that
                </p>
                <p>
                    First -&gt; who
                </p>
                <p>
                    Second -&gt; this, what, why
                </p>
                <p>
                    First -&gt; this
                </p>
                <p>
                    Third -&gt; this, third
                </p>
                <p>
                    Third -&gt; that
                </p>
                <p>
                    filter
                </p>
                <p>
                    that, this
                </p>
            </td>
            <td width="342" valign="top">
                <p>
                    First | #this, #that, #who
                </p>
                <p>
                    Third | #this, #third, #that
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    <strong>7. </strong>
    <strong>Social Media Posts</strong>
    <strong></strong>
</h2>
<p>
    You have been tasked to create a Console Social Media Database.
</p>
<p>
    You will receive several input lines in one of the following formats:
</p>
<p>
    · post {postName}
</p>
<p>
    · like {postName}
</p>
<p>
    · dislike {postName}
</p>
<p>
    · comment {postName} {commenterName} {content}
</p>
<p>
If you receive the <strong>post</strong> command, you must<strong>create</strong> a <strong>post</strong> with the    <strong>given name</strong>.
</p>
<p>
If you receive the <strong>like</strong> command you must<strong>add</strong> a <strong>like</strong> to the    <strong>given post</strong>.
</p>
<p>
If you receive the <strong>dislike</strong> command you must add a    <strong>dislike</strong> to the <strong>given post</strong>.
</p>
<p>
If you receive the <strong>comment</strong> command, you must<strong>add</strong> a <strong>comment</strong> to the<strong>given post</strong>. The <strong>comment’s</strong>    <strong>writer</strong> must be the <strong>given commentator name</strong>
    , and the <strong>content</strong> of the <strong>comment</strong> must be
    the <strong>given content</strong>.
</p>
<p>
By default, the posts have <strong>0 likes</strong>,    <strong>0 dislikes</strong> and <strong>0 comments</strong> when created.
</p>
<p>
    When you receive the command “drop the media”, you must end the input
sequence, and you must print <strong>every post</strong> with its<strong>likes</strong>, <strong>dislikes</strong> and    <strong>comments</strong> in the following format:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="470" valign="top">
                <p>
                    Post: {postName} | Likes: {likes} | Dislikes {dislikes}
                    <br/>
                    Comments:
                    <br/>
                    * {commentator1}: {comment1}
                    <br/>
                    * {commentator2}: {comment2}
                    <br/>
                    . . .
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
If a certain <strong>post</strong> does <strong>not</strong> have    <strong>any</strong> comments, you should just print “<strong>None</strong>
    ”.
</p>
<p>
The comments have a <strong>prefix</strong> of a <strong>single</strong><strong>asterisk</strong> (‘<strong>*</strong>’) and    <strong>2 spaces</strong>.
</p>
<p>
There is <strong>NO space</strong> between the    <strong>commentator’s name</strong> and the <strong>colon</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
The <strong>post name</strong> will be a <strong>string</strong> of        <strong>letters</strong> and <strong>digits</strong>.
    </li>
    <li>
The <strong>commentator’s name</strong> will be a        <strong>string</strong> of <strong>letters</strong>.
    </li>
    <li>
The comment’s <strong>CONTENT</strong>, may contain        <strong>ANY ASCII</strong> character.
    </li>
    <li>
        There will be <strong>NO invalid</strong> input data.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="277" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="350" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="277" valign="top">
                <p>
                    post FirstPost
                </p>
                <p>
                    like FirstPost
                </p>
                <p>
                    like FirstPost
                </p>
                <p>
                    dislike FirstPost
                </p>
                <p>
                    post SecondPost
                </p>
                <p>
                    comment FirstPost Isacc Cool
                </p>
                <p>
                    comment SecondPost Isacc Lol
                </p>
                <p>
                    like SecondPost
                </p>
                <p>
                    drop the media
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    Post: FirstPost | Likes: 2 | Dislikes: 1
                </p>
                <p>
                    Comments:
                </p>
                <p>
                    * Isacc: Cool
                </p>
                <p>
                    Post: SecondPost | Likes: 1 | Dislikes: 0
                </p>
                <p>
                    Comments:
                </p>
                <p>
                    * Isacc: Lol
                </p>
            </td>
        </tr>
        <tr>
            <td width="277" valign="top">
                <p>
                    post SomePost
                </p>
                <p>
                    like SomePost
                </p>
                <p>
                    like SomePost
                </p>
                <p>
                    dislike SomePost
                </p>
                <p>
                    post OtherPost
                </p>
                <p>
                    comment OtherPost Isacc Naaais
                </p>
                <p>
                    comment OtherPost Peter GoodPost
                </p>
                <p>
                    comment OtherPost John Meh...
                </p>
                <p>
                    drop the media
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    Post: SomePost | Likes: 2 | Dislikes: 1
                </p>
                <p>
                    Comments:
                </p>
                <p>
                    None
                </p>
                <p>
                    Post: OtherPost | Likes: 0 | Dislikes: 0
                </p>
                <p>
                    Comments:
                </p>
                <p>
                    * Isacc: Naaais
                </p>
                <p>
                    * Peter: GoodPost
                </p>
                <p>
                    * John: Meh...
                </p>
            </td>
        </tr>
    </tbody>
</table>