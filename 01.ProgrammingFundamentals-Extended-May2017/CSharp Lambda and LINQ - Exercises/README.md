<h1>
    Exercises: Lambda and LINQ
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
    <a href="https://judge.softuni.bg/Contests/435">
        https://judge.softuni.bg/Contests/435
    </a>
    .
</p>
<h2>
    1. Registered Users
</h2>
<p>
    You will be given several usernames and dates of registry, in the following
    format:
</p>
<p>
    {username} -&gt; {date}
</p>
<p>
The <strong>username</strong> will be a <strong>string</strong> and the<strong>date</strong> will be a valid date in format “    <strong>dd/MM/yyyy</strong>”.
</p>
<p>
You must read input lines until you receive the command “    <strong>end</strong>”.
</p>
<p>
    You need to store every user, with his date of registry. Then you must
print the <strong>LAST 5</strong> registered names, or in other words the<strong>OLDEST</strong> registered users, in<strong>order of registry</strong> – from the<strong>latest registered,</strong> to the    <strong>oldest registered</strong>.
</p>
<p>
If there are <strong>LESS </strong>than<strong> 5 </strong>people, print<strong>them</strong> in the <strong>order</strong>,    <strong>specified above</strong>.
    <br/>
if any entries have the <strong>SAME date</strong>, print the    <strong>LAST</strong> entered one, <strong>FIRST</strong>, and then the
    other (in <strong>input</strong>).
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
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    John27 -&gt; 12/02/2004
                </p>
                <p>
                    7H3D347H -&gt; 15/09/2015
                </p>
                <p>
                    Bojo96 -&gt; 15/09/2015
                </p>
                <p>
                    Sanity -&gt; 04/05/2015
                </p>
                <p>
                    Innos -&gt; 04/05/2015
                </p>
                <p>
                    Nakov -&gt; 01/01/2013
                </p>
                <p>
                    Danny -&gt; 04/04/2016
                </p>
                <p>
                    Yori -&gt; 29/02/2016
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Bojo96
                </p>
                <p>
                    Innos
                </p>
                <p>
                    Sanity
                </p>
                <p>
                    Nakov
                </p>
                <p>
                    John27
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Danny -&gt; 04/04/2016
                </p>
                <p>
                    Innos -&gt; 04/05/2015
                </p>
                <p>
                    Sanity -&gt; 04/05/2015
                </p>
                <p>
                    Nakov -&gt; 01/01/2013
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Danny
                </p>
                <p>
                    Sanity
                </p>
                <p>
                    Innos
                </p>
                <p>
                    Nakov
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Use the DateTime.ParseExact() method. The method <strong>accepts</strong>
a <strong>string</strong> (the <strong>input data</strong>), a    <strong>date format</strong>, and CultureInfo.
</p>
<p>
    · For CultureInfo, use CultureInfo.InvariantCulture.
</p>
<h2>
    2. Default Values
</h2>
<p>
    You will be given several key-value pairs in the following format: “{key}
    -&gt; {value}”
</p>
<p>
    Your task is to store all these pairs until you receive the command “end”.
When you do receive the ending command, you must read<strong>one last line</strong>, containing the    <strong>default value</strong>. Then you must change all values, which are
    equal to “null” with the <strong>given default value</strong>.
</p>
<p>
At the <strong>end,</strong> you must print<strong>all key-value pairs</strong>, which have <strong>NOT</strong> been    <strong>replaced</strong> with the <strong>default value</strong>, ordered
in <strong>descending</strong> order, by their    <strong>value’s length</strong>.
</p>
<p>
    <strong>After</strong>
them, you must print <strong>all key-value</strong> pairs which    <strong>HAVE been replaced</strong> with the <strong>default value</strong>
    , in <strong>order of input</strong>.
</p>
<p>
    Each key-value pair, must be printed in the following format: “{key}
    &lt;-&gt; {value}”.
</p>
<p>
    All variables in the program logic are strings.
</p>
<p>
    Note: If you receive the same key twice or more times, you should update
    its value every time.
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
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    What -&gt; null
                </p>
                <p>
                    How -&gt; null
                </p>
                <p>
                    To -&gt; Do
                </p>
                <p>
                    This -&gt; null
                </p>
                <p>
                    Correctly -&gt; null
                </p>
                <p>
                    end
                </p>
                <p>
                    welp
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    To &lt;-&gt; Do
                </p>
                <p>
                    What &lt;-&gt; welp
                </p>
                <p>
                    How &lt;-&gt; welp
                </p>
                <p>
                    This &lt;-&gt; welp
                </p>
                <p>
                    Correctly &lt;-&gt; welp
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    This -&gt; Input
                </p>
                <p>
                    Will -&gt; Be
                </p>
                <p>
                    Sorted -&gt; null
                </p>
                <p>
                    By -&gt; Descending
                </p>
                <p>
                    Order -&gt; null
                </p>
                <p>
                    end
                </p>
                <p>
                    sortorder
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    By &lt;-&gt; Descending
                </p>
                <p>
                    This &lt;-&gt; Input
                </p>
                <p>
                    Will &lt;-&gt; Be
                </p>
                <p>
                    Sorted &lt;-&gt; sortorder
                </p>
                <p>
                    Order &lt;-&gt; sortorder
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Shopping Spree
</h2>
<p>
    Pesho has a problem with taking decisions and mostly with deciding on what
    to eat for dinner. He asked you to write a program which chooses dinner for
    him.
</p>
<p>
On the <strong>first</strong> line, you will receive Pesho’s    <strong>budget </strong>as<strong> decimal </strong>number.
</p>
<p>
On the <strong>next</strong> lines, until you receive the command “<strong>end</strong>”, you will receive strings with the<strong>name</strong> of the <strong>product</strong> and the<strong>price</strong> of the <strong>product</strong>. Save    <strong>all</strong> products and if you receive the <strong>same</strong>
product and its <strong>price</strong> is <strong>lower</strong> than the    <strong>already saved</strong> one – <strong>rewrite</strong> the old
    value.
</p>
<p>
At the <strong>end</strong>, <strong>sum</strong>    <strong>all values</strong> of the <strong>received</strong> products. If
the <strong>sum</strong> is <strong>bigger</strong> than Pesho’s    <strong>budget</strong> – print:
</p>
<p>
    <strong>“</strong>
    Need more money... Just buy banichka<strong>”</strong>
</p>
<p>
If Pesho <strong>has</strong> <strong>enough</strong> money – print<strong>all</strong> <strong>purchased</strong> products,<strong>ordered</strong> by <strong>price </strong>in<strong>descending </strong>order, <strong>then</strong> by the<strong>count</strong> of the <strong>characters</strong> in its<strong>name</strong> in <strong>ascending order</strong>. Use the    <strong>following</strong> format for <strong>each</strong> product:
</p>
<p>
    <strong>“</strong>
    {productName} costs {productPrice}<strong>”</strong>
</p>
<p>
Print all <strong>prices</strong> <strong>rounded</strong> to the    <strong> 2<sup>nd</sup></strong> decimal <strong>sign</strong>.
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
            <td width="294" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    20.50
                </p>
                <p>
                    Bread 2.41
                </p>
                <p>
                    Butter 3.12
                </p>
                <p>
                    Cheese 4.20
                </p>
                <p>
                    Bread 2.12
                </p>
                <p>
                    Milk 4.20
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Milk costs 4.20
                </p>
                <p>
                    Cheese costs 4.20
                </p>
                <p>
                    Butter costs 3.12
                </p>
                <p>
                    Bread costs 2.12
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    10.50
                </p>
                <p>
                    Bread 2.41
                </p>
                <p>
                    Butter 3.12
                </p>
                <p>
                    Cheese 4.20
                </p>
                <p>
                    Bread 2.12
                </p>
                <p>
                    Milk 4.20
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Need more money… Just buy banichka
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. SoftUni Beer Pong
</h2>
<p>
    In SoftUni it is time for the annual beer pong tournament. Last year the
    competition was a total disaster, because nobody was in “condition” to keep
    track of the scores. Now it is your job to write a program, which will keep
    track of the total results. The competition’s rules are simple:
</p>
<ul>
    <li>
        <strong>All</strong>
        contestants are <strong>divided</strong> into <strong>teams</strong>
    </li>
    <li>
Every <strong>team</strong> should have <strong>exactly 3</strong>        <strong>participants</strong>
    </li>
    <li>
After a team has a total of<strong> 3</strong> participants, any<strong>further</strong> attempt to <strong>add</strong> a        <strong>participant</strong> should be <strong>ignored</strong>.
    </li>
    <li>
If a team has <strong>less</strong> <strong>than</strong>        <strong>3</strong> participants – it gets <strong>disqualified</strong>
        and should <strong>not</strong> be <strong>printed</strong>.
    </li>
</ul>
<p>
Until you receive the command “stop the game” you will receive<strong>lines</strong> of <strong>input</strong> in the following    <strong>format</strong>:
</p>
<p>
    <strong>“</strong>
    team|player|pointsMade<strong>”</strong>
</p>
<p>
    The <strong>total</strong> score of the team is the <strong>sum</strong> of
the <strong>points</strong> made from <strong>every</strong>    <strong>player</strong>.
</p>
<p>
Print <strong>every</strong> team, which has <strong>enough</strong>    <strong>players</strong> in the following <strong>format</strong>:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="307" valign="top">
                <p>
                    <strong>{teamPosition}. {teamName}; Players:</strong>
                </p>
                <p>
                    <strong>###{firstPlayerName}: {points}</strong>
                </p>
                <p>
                    <strong>###{secondPlayerName}: {points}</strong>
                </p>
                <p>
                    <strong>###{thirdPlayerName}: {points}</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Order the teams by <strong>total points</strong> in<strong>descending</strong> <strong>order</strong> and<strong>order each team’s players</strong> by the amount of    <strong>points made</strong>, again in <strong>descending order</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
You will <strong>not</strong> receive a player’s name, which        <strong>already exists</strong> in the team it’s trying to be inserted
        into.
    </li>
    <li>
        Points will be in the interval [0…2147483647].
    </li>
    <li>
The <strong>total</strong> <strong>points</strong> of the teams and the        <strong>points</strong> of the <strong>players</strong> in the same
        team will <strong>not</strong> be <strong>equal</strong>.
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
            <td width="294" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Jubrata|Retro|57
                </p>
                <p>
                    Pesho|Destroyers|20
                </p>
                <p>
                    Gosho|Destroyers|35
                </p>
                <p>
                    Pesho|TechModule|32
                </p>
                <p>
                    Stefan|Destroyers|12
                </p>
                <p>
                    Kaloyan|TechModule|14
                </p>
                <p>
                    Meto|TechModule|24
                </p>
                <p>
                    Hrisi|Retro|59
                </p>
                <p>
                    Maria|TechModule|19
                </p>
                <p>
                    stop the game
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    1. TechModule; Players:
                </p>
                <p>
                    ###Pesho: 32
                </p>
                <p>
                    ###Meto: 24
                </p>
                <p>
                    ###Kaloyan: 14
                </p>
                <p>
                    2. Destroyers; Players:
                </p>
                <p>
                    ###Gosho: 35
                </p>
                <p>
                    ###Pesho: 20
                </p>
                <p>
                    ###Stefan: 12
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Ivan|Loosers|5
                </p>
                <p>
                    Ivo|RoYaL|100
                </p>
                <p>
                    Vladi|RoYaL|120
                </p>
                <p>
                    Pesho|Trainers|22
                </p>
                <p>
                    Stefan|NoobS|12
                </p>
                <p>
                    RoYaL|RoYaL|90
                </p>
                <p>
                    Geotgi|NoobS|24
                </p>
                <p>
                    Anna|NoobS|70
                </p>
                <p>
                    Maria|Loosers|19
                </p>
                <p>
                    Pesho|Loosers|30
                </p>
                <p>
                    stop the game
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    1. RoYaL; Players:
                </p>
                <p>
                    ###Vladi: 120
                </p>
                <p>
                    ###Ivo: 100
                </p>
                <p>
                    ###RoYaL: 90
                </p>
                <p>
                    2. NoobS; Players:
                </p>
                <p>
                    ###Anna: 70
                </p>
                <p>
                    ###Geotgi: 24
                </p>
                <p>
                    ###Stefan: 12
                </p>
                <p>
                    3. Loosers; Players:
                </p>
                <p>
                    ###Pesho: 30
                </p>
                <p>
                    ###Maria: 19
                </p>
                <p>
                    ###Ivan: 5
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Flatten Dictionary
</h2>
<p>
You will be given several input lines containing info about a<strong>key</strong>, an <strong>inner key</strong> and<strong>inner value</strong>, <strong>separated</strong> by    <strong>SPACES</strong>.
</p>
<p>
Your task is to store every <strong>inner key</strong> and    <strong>inner value</strong>, in <strong>every key’s value</strong>. Check
    the Examples for more info.
</p>
<p>
If you receive the command “flatten {key}”, you must<strong>flatten</strong> all the <strong>inner</strong>    <strong>keys</strong> and <strong>inner</strong> <strong>values</strong> at
the <strong>given key</strong>, or in other words,    <strong>CONCATENATE</strong> them.
</p>
<p>
When you receive the command “<strong>end</strong>”, the    <strong>input ends</strong>. You must print all <strong>keys</strong> and
their <strong>inner-keys</strong> and <strong>inner-values</strong>.<strong>Flattened</strong> <strong>inner keys</strong> and    <strong>inner values</strong>, must be printed <strong>AFTER</strong> all
    else.
</p>
<p>
The <strong>keys</strong> must be printed, ordered by length in    <strong>descending order</strong>.
</p>
<p>
All <strong>inner-keys</strong> must be printed ordered by length in    <strong>ascending order</strong>.
</p>
<p>
    Flattened Values must be printed in <strong>order of input</strong>.
</p>
<p>
    The format of printing regular keys is: Flattened values should be printed
    like this
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="236" valign="top">
                <p>
                    {key}
                </p>
                <p>
                    1. {innerKey} – {innerValue}
                </p>
                <p>
                    2. {innerKey} – {innerValue}
                </p>
                <p>
                    3. {innerKey} – {innerValue}
                </p>
                <p>
                    ...
                </p>
            </td>
            <td width="330" valign="top">
                <p>
                    {key}
                </p>
                <p>
                    1. {flattenedValue1}
                </p>
                <p>
                    2. {flattenedValue2}
                </p>
                <p>
                    3. {flattenedValue3}
                </p>
                <p>
                    ...
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
If you receive an <strong>inner</strong> <strong>key</strong> that    <strong>already</strong> <strong>exists</strong>, <strong>replace</strong>
    its value with the <strong>new given one</strong>.
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
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    Cars Opel Astra
                </p>
                <p>
                    Cars Opel Vectra
                </p>
                <p>
                    Laptops Lenovo T500
                </p>
                <p>
                    Cars BMW X6
                </p>
                <p>
                    Laptops Acer Aspire
                </p>
                <p>
                    Cars Audi Q7
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Laptops
                </p>
                <p>
                    1. Acer - Aspire
                </p>
                <p>
                    2. Lenovo - T500
                </p>
                <p>
                    Cars
                </p>
                <p>
                    1. BMW - X6
                </p>
                <p>
                    2. Opel - Vectra
                </p>
                <p>
                    3. Audi - Q7
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    TV Samsung Home
                </p>
                <p>
                    TV Sony Office
                </p>
                <p>
                    TV Samsung Office
                </p>
                <p>
                    Default Get Set
                </p>
                <p>
                    Default Set Get
                </p>
                <p>
                    flatten TV
                </p>
                <p>
                    TV Lenovo General
                </p>
                <p>
                    TV Samsung Home
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Default
                </p>
                <p>
                    1. Get - Set
                </p>
                <p>
                    2. Set - Get
                </p>
                <p>
                    TV
                </p>
                <p>
                    1. Lenovo - General
                </p>
                <p>
                    2. Samsung - Home
                </p>
                <p>
                    3. SamsungOffice
                </p>
                <p>
                    4. SonyOffice
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. CottageScraper *
</h2>
<p>
    You’re a carpenter at the local woodworking shop. Your client wants you to
    build a wooden skyscraper/cottage. A <strong>CottageScraper</strong>, he
calls it. But in order to accomplish this task, he needs the trees to be    <strong>taller</strong> than a <strong>certain height</strong>. The problem
    is that he <strong>doesn’t know</strong> what type of tree he’ll use yet,
and doesn’t know <strong>how tall</strong> he wants the    <strong>CottageScraper</strong> to be. You’ve obviously got nothing better
    to do, so you go to work chopping down logs until he calls you with the
    details.
</p>
<p>
Write a program which receives tree <strong>types</strong> and their    <strong>lengths</strong> in the format “{type} -&gt; {height}”. When you
    receive the command “chop chop”, it’s time to get paid.
</p>
<p>
On the next line, you will receive the <strong>type</strong><strong>of tree</strong> that needs to be used to build the    <strong>CottageScraper</strong>. On the final input line, you will receive
    the <strong>minimum length per tree</strong>, needed to accomplish the
    task. Filter the trees based on type and minimum length, making sure that
you’ll only use the trees of the specified <strong>type</strong> and    <strong>minimum length</strong>.
</p>
<p>
After which, calculate the <strong>total price</strong> of the    <strong>CottageScraper</strong>, which includes the price of all the trees
you collected up to that point. The price is calculated as being the<strong>average</strong> meters of <strong>all</strong><strong>logs</strong> you collected, per <strong>meter</strong> of log,    <strong>rounded to the second decimal place</strong>.
</p>
<p>
You’re going to charge the client <strong>100%</strong> of the<strong>price per log</strong> for logs you’ll use in the skyscraper, and<strong>25%</strong> of the price per log for logs you    <strong>won’t</strong> use for the <strong>CottageScraper</strong>. Both
    fees are <strong>rounded to the second decimal place</strong>.
</p>
<p>
    After you make the calculations, <strong>print</strong> them on the console
    in the following format:
</p>
<ul>
    <li>
        On the first line of the console, print “Price per meter:
        ${pricePerMeter:F2}”.
    </li>
</ul>
<p>
    · On the second, print “Used logs price: ${usedLogsPrice:F2}”.
</p>
<ul>
    <li>
        On the third line, print “Unused logs price: ${unusedLogsPrice:F2}”.
    </li>
    <li>
        On the final line of the output, print “CottageScraper subtotal:
        ${subTotal:F2}”.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="130" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="278" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="312" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="130" valign="top">
                <p>
                    Maple -&gt; 20
                </p>
                <p>
                    Oak -&gt; 12
                </p>
                <p>
                    Poplar -&gt; 25
                </p>
                <p>
                    Maple -&gt; 33
                </p>
                <p>
                    Poplar -&gt; 11
                </p>
                <p>
                    Poplar -&gt; 30
                </p>
                <p>
                    <strong>chop chop</strong>
                </p>
                <p>
                    Poplar
                </p>
                <p>
                    12
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    Price per meter: $21.83
                </p>
                <p>
                    Used logs price: $1200.65
                </p>
                <p>
                    Unused logs price: $414.77
                </p>
                <p>
                    CottageScraper subtotal: $1615.42
                </p>
            </td>
            <td width="312" valign="top">
                <p>
                    Needed type: Poplar
                </p>
                <p>
                    Needed height: at least 12m
                </p>
                <p>
                    Price per meter == (sum of all logs) / (count) == 21.83
                </p>
                <p>
                    Used logs (taller than 12m): Poplar -&gt; 25, 30
                </p>
                <p>
Used logs price: (25 + 30) * 21.83 =                    <strong>$1200.65</strong>
                </p>
                <p>
                    Unused logs: Maple -&gt; 20, 33; Oak -&gt; 12; Poplar -&gt;
                    11
                </p>
                <p>
Unused logs price: (20 + 33 + 12 + 11) * 21.83 * 0.25 =                    <strong>$414.77</strong>
                </p>
                <p>
Used + unused logs price: 1200.65 + 414.77 =                    <strong>$1615.42</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="130" valign="top">
                <p>
                    Cherry -&gt; 918
                </p>
                <p>
                    Oak -&gt; 112
                </p>
                <p>
                    Maple -&gt; 1423
                </p>
                <p>
                    Maple -&gt; 9118
                </p>
                <p>
                    Poplar -&gt; 122
                </p>
                <p>
                    Oak -&gt; 232
                </p>
                <p>
                    <strong>chop chop</strong>
                </p>
                <p>
                    Maple
                </p>
                <p>
                    250
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    Price per meter: $1987.50
                </p>
                <p>
                    Used logs price: $20950237.50
                </p>
                <p>
                    Unused logs price: $687675.00
                </p>
                <p>
                    CottageScraper subtotal: $21637912.50
                </p>
            </td>
            <td width="312" valign="top">
                <p>
                    Needed type: Maple
                </p>
                <p>
                    Needed height: at least 250m
                </p>
                <p>
Price per meter = 918 + 112 + 1423 + 9118 + 122 + 232 / 6 =                    <strong>$1987.50</strong>
                </p>
                <p>
                    Used logs (taller than 250m): Maple -&gt; 1423, 9118
                </p>
                <p>
Used logs price: (1423 + 9118) * 1987.50 =                    <strong>$20950237.50</strong>
                </p>
                <p>
                    Unused logs: Cherry -&gt; 918, Oak -&gt; 112, 232, Poplar
                    -&gt; 122
                </p>
                <p>
Unused logs price: (918+ 112+ 232+ 122) * $1987.50 * 0.25 =                    <strong>$687675.00</strong>
                </p>
                <p>
                    Used + unused logs price: <strong>$21637912.50</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="130" valign="top">
                <p>
                    Apple -&gt; 218
                </p>
                <p>
                    Pear -&gt; 112
                </p>
                <p>
                    Apple -&gt; 123
                </p>
                <p>
                    Apple -&gt; 118
                </p>
                <p>
                    Pear -&gt; 122
                </p>
                <p>
                    Cherry -&gt; 232
                </p>
                <p>
                    <strong>chop chop</strong>
                </p>
                <p>
                    Apple
                </p>
                <p>
                    120
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    Price per log: $154.00
                </p>
                <p>
                    Used logs price: $52514.00
                </p>
                <p>
                    Unused logs price: $22484.00
                </p>
                <p>
                    CottageScraper subtotal: $74998.00
                </p>
            </td>
            <td width="312" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · To flatten the dictionary’s values (so you can calculate the price per
    log), you can use the LINQ .SelectMany() method.
</p>
<p>
    · The unused logs include not only the logs from different types than
    needed, but also the logs whose height was <strong>lower</strong> than the
    minimum height.
</p>