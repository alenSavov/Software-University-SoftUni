<h1>
    Lab: PHP Syntax, Basic Web
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/software-technologies">
        “Software Technologies” course @ SoftUni
    </a>
    .
</p>
<p>
    You can submit your solutions here
    <a href="https://judge.softuni.bg/Contests/697/PHP-Basic-Syntax-Lab">
        https://judge.softuni.bg/Contests/697/PHP-Basic-Syntax-Lab
    </a>
    .
</p>
<h2>
    1. Hello, PHP!
</h2>
<h3>
    Write PHP script to print "Hello, PHP!"
</h3>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="108" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="108">
                <p>
                    Hello, PHP!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    You solutin shoud have the following structure:
</p>
<h2>
    2. Numbers 1 to 20
</h2>
<p>
Wrete a PHP script, which prints the <strong>numbers</strong> from    <strong>1 to 20</strong> in a list. Every number on <strong>odd</strong>
line should be <strong>blue</strong> amd every number on    <strong>even</strong> line should be <strong>green</strong>. The list
    should have the following structure
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="383" valign="top">
                <p>
                    &lt;ul&gt;
                </p>
                <p>
                    &lt;li&gt;&lt;span
                    style='color:blue'&gt;1&lt;/span&gt;&lt;/li&gt;
                </p>
                <p>
                    &lt;li&gt;&lt;span
                    style='color:green'&gt;2&lt;/span&gt;&lt;/li&gt;
                </p>
                <p>
                    &lt;li&gt;&lt;span
                    style='color:blue'&gt;3&lt;/span&gt;&lt;/li&gt;
                </p>
                <p>
                    …
                </p>
                <p>
                    &lt;/ul&gt;
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
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="62">
                <p>
                    <em>...</em>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Color Palette
</h2>
<p>
Write a PHP script to print a <strong>color</strong>    <strong>palette</strong> like shown below:
</p>
<h3>
    Hints
</h3>
<p>
    · Every &lt;div&gt; should have the following structure:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="493" valign="top">
                <p>
                    &lt;div style='background:rgb(0, 0, 0)'&gt;rgb(0, 0,
                    0)&lt;/div&gt;
                </p>
                <p>
                    &lt;div style='background:rgb(0, 0, 51)'&gt;rgb(0, 0,
                    51)&lt;/div&gt;
                </p>
                <p>
                    …
                </p>
                <p>
                    &lt;div style='background:rgb(0, 0, 255)'&gt;rgb(0, 0,
                    255)&lt;/div&gt;
                </p>
                <p>
                    &lt;div style='background:rgb(0, 51, 0)'&gt;rgb(0, 51,
                    0)&lt;/div&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    · Add the following .css in the &lt;head&gt; section:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="211" valign="top">
                <p>
                    <strong>div {</strong>
                </p>
                <p>
                    <strong> display: inline-block;</strong>
                </p>
                <p>
                    <strong> width: 150px;</strong>
                </p>
                <p>
                    <strong> padding: 2px;</strong>
                </p>
                <p>
                    <strong> margin: 5px;</strong>
                </p>
                <p>
                    <strong>}</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Hello, Person!
</h2>
<p>
Write a program which receives a <strong>name </strong>from a<strong>form</strong> and prints in the html the <strong>following</strong><strong>greeting </strong>(after youy click on the<strong>[Submit]</strong> button). The <strong>form</strong> should    <strong>dissapear</strong> after clicking the input.:
</p>
<ul>
    <li>
        Hello, {name}!
    </li>
</ul>
<p>
    You shoud read the name from the following form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="347" valign="top">
                <p>
                    &lt;<strong>form</strong>&gt;
                    <br/>
Name: &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>name=</strong>                    <strong>"person" </strong>/&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong>                    <strong>"submit" </strong>/&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<br clear="ALL"/>
<h2>
    5. Dump an HTTP GET Request
</h2>
<p>
Write a PHP script to dump the <strong>content</strong> of the    <strong>HTTP GET</strong> request parameters using var_dump(…). Dump the
    content of the following form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="329" valign="top">
                <p>
                    &lt;<strong>form</strong>&gt;
                    <br/>
                    &lt;<strong>div</strong>&gt;Name:&lt;/<strong>div</strong>
                    &gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>name=</strong>                    <strong>"personName"</strong>/&gt;
                    <br/>
                    &lt;<strong>div</strong>&gt;Age:&lt;/<strong>div</strong>
                    &gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>name=</strong>                    <strong>"age"</strong>/&gt;
                    <br/>
                    &lt;<strong>div</strong>&gt;Town:&lt;/<strong>div</strong>
                    &gt;
                    <br/>
&lt;<strong>select </strong><strong>name=</strong>                    <strong>"townId"</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong>                    <strong>"10"</strong>&gt;Sofia&lt;/<strong>option</strong>
                    &gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong>                    <strong>"20"</strong>&gt;Varna&lt;/<strong>option</strong>
                    &gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"30"</strong>&gt;Plodvid&lt;/                    <strong>option</strong>&gt;
                    <br/>
                    &lt;/<strong>select</strong>&gt;
                    <br/>
&lt;<strong>div</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"submit"</strong>/&gt;&lt;/                    <strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<h2>
    6. Sum Two Numbers
</h2>
<p>
    Write a PHP script to sum two numbers. The script should display a HTML
    form to enter the numbers. If the numbers are passed as parameters, display
    their sum. You wii receive the input from the following form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="299" valign="top">
                <p>
                    &lt;<strong>form</strong>&gt;
                    <br/>
&lt;<strong>div</strong>&gt;First Number:&lt;/                    <strong>div</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>name=</strong>                    <strong>"num1" </strong>/&gt;
                    <br/>
&lt;<strong>div</strong>&gt;Second Number:&lt;/                    <strong>div</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"number" </strong><strong>name=</strong>                    <strong>"num2" </strong>/&gt;
                    <br/>
&lt;<strong>div</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"submit" </strong>/&gt;&lt;/                    <strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<h3>
</h3>
<h2>
    7. From Celsius to Fahrenheit and Vice Versa
</h2>
<p>
Write a PHP script to convert from Celsius to Fahrenheit (    <strong>0 °C = 32 °F</strong>).
</p>
<p>
    · If you convert from Celsius to Fahrenheit print:
</p>
<p>
    o “{degreesCelsius} °C = {degreesFahrenheit} °F”
</p>
<p>
    · If you convert from Fahrenheit to Celsius print:
</p>
<p>
    o “{degreesFahrenheit} °F = {degreesCelsius} °C”
</p>
<p>
    The form you should use is the following:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="365" valign="top">
                <p>
                    &lt;<strong>form</strong>&gt;
                    <br/>
Celsius: &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>name=</strong>                    <strong>"cel" </strong>/&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"submit" </strong><strong>value=</strong>                    <strong>"Convert"</strong>&gt;
                    <br/>
                    <strong>&lt;?= </strong>
                    $msgAfterCelsius <strong>?&gt;</strong>
                    <strong>
                        <br/>
                    </strong>
                    &lt;/<strong>form</strong>&gt;
                    <br/>
                    &lt;<strong>form</strong>&gt;
                    <br/>
Fahrenheit: &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong>                    <strong>name=</strong><strong>"fah" </strong>/&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"submit" </strong><strong>value=</strong>                    <strong>"Convert"</strong>&gt;
                    <strong>
                        <br/>
                    </strong>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<h3>
    Hints
</h3>
<ul>
    <li>
        Use &amp;deg; for the degrees sign - °
    </li>
</ul>
<h2>
    8. Sort Lines
</h2>
<p>
    Write a PHP script that <strong>sorts</strong> the <strong>text</strong>
    lines from a &lt;textarea&gt;. Take the input from the following form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="383" valign="top">
                <p>
                    &lt;<strong>form</strong>&gt;
                    <br/>
&lt;<strong>textarea </strong><strong>rows=</strong><strong>"10" </strong><strong>name=</strong>                    <strong>"lines"</strong>&gt;<strong>&lt;?= </strong>
                    $sortedLines
                    <br/>
                    <strong>?&gt;</strong>
                    &lt;/<strong>textarea</strong>&gt; &lt;<strong>br</strong>
                    &gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"submit" </strong><strong>value=</strong>                    <strong>"Sort"</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    <br clear="ALL"/>
    Examples
</h3>
<h2>
    9. Extract Capital-Case Words
</h2>
<p>
Write a <strong>PHP</strong> script to extract all<strong>capital-case</strong> words from an <strong>array</strong> of    <strong>strings</strong>. All <strong>non-letter</strong> chars are
    considered <strong>separators</strong>. Use the following form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="377" valign="top">
                <pre>&lt;<strong>form</strong>&gt;<br/>
    &lt;<strong>textarea </strong><strong>rows=</strong><strong>"10" </strong><strong>name=</strong><strong>"text"</strong>&gt;<strong>textarea</strong>&gt; &lt;<strong>br</strong>&gt;<br/>
    &lt;<strong>input </strong><strong>type=</strong><strong>"submit" </strong><strong>value=</strong><strong>"Extract"</strong>&gt;<br/>
  &lt;/<strong>form</strong>&gt;</pre>
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
            <td width="412" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="276" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="412" valign="top">
                <p>
                    We start by HTML, CSS, JavaScript, JSON and REST.
                </p>
                <p>
                    Later we touch some PHP, MySQL and SQL.
                </p>
                <p>
                    Later we play with C#, EF, SQL Server and ASP.NET MVC.
                </p>
                <p>
                    Finally, we touch some Java, Hibernate and Spring.MVC.
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC,
                    MVC
                </p>
            </td>
        </tr>
    </tbody>
</table>