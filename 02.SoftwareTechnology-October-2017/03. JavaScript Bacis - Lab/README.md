<h1>
    Lab: JavaScript Syntax and Basic Web
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
    <a href="https://judge.softuni.bg/Contests/223/">
        https://judge.softuni.bg/Contests/223/
    </a>
    .
</p>
<h2>
    1. Sum Numbers with HTML and JS
</h2>
<p>
    Create an HTML form holding two text fields and a result field and write a
    JavaScript function to <strong>sum </strong>them.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="61" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="20" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="20" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="19" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="61" valign="top">
                <p>
                    1 2
                </p>
            </td>
            <td width="62">
                <p>
                    3
                </p>
            </td>
            <td width="20" valign="top">
            </td>
            <td width="60" valign="top">
                <p>
                    5 5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    10 15
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    25
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    1 5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    6
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step by Step
</h3>
<h4>
    1. Create WebStorm Project
</h4>
<p>
    Open WebStorm and click Create New Project:
</p>
<p>
    Give the folder a meaningful name, such as “JS Syntax Lab”:
</p>
<h4>
    2. Create a New HTML File
</h4>
<p>
    <strong>Right click</strong>
    the folder in the <strong>Project view</strong>, which just appeared (if
you can’t see the project view, go to    <strong>View-&gt;Tool Windows -&gt; Project</strong> to open it), hover
    over the “<strong>New</strong>” menu, and click “<strong>HTML File</strong>
    ”:
</p>
<p>
    Give the HTML file a meaningful name:
</p>
<p>
    After you create the file, it should look something like this:
</p>
<h4>
    3. Create the Form
</h4>
<p>
    After you create the file, it’s time to make the form. Create a
    &lt;form&gt; tag with some &lt;input&gt; fields inside:
</p>
<p>
    The input fields are as follows:
</p>
<ul>
    <li>
        A <strong>text</strong> input field, called <strong>num1</strong>
    </li>
    <li>
        A <strong>text</strong> input field, called <strong>num2</strong>
    </li>
    <li>
        A <strong>button </strong>input, which calls the “sumNumbers()”
        function upon being clicked, and has the text “Calculate” inside it.
    </li>
</ul>
<p>
    Apart from the form, we’ve also created a <strong>div</strong>, which will
    hold the <strong>result</strong> of the calculation.
</p>
<p>
    When we’re done writing the code, our little html page should look
    something like this:
</p>
<h4>
    4. Write the JavaScript Code
</h4>
<p>
    Let’s create a &lt;script&gt; tag after the form, which will hold our
    logic:
</p>
<p>
In order to perform the calculation, we need to <strong>access</strong> the<strong>num1</strong> and <strong>num2</strong> fields’    <strong>values</strong> and then sum them. Let’s first create a function
    calculateResult(), which will be called on click:
</p>
<p>
After we create the script tag, we can get both the elements    <strong>by id</strong>, and sum them:
</p>
<p>
    We’ve written the code, but WebStorm is showing us some errors. The reason
it’s showing errors with the <strong>let</strong> expression is because it    <strong>didn’t exist yet</strong> in <strong>ECMAScript 5.1</strong>, which
    WebStorm uses by <strong>default</strong>. We need to <strong>fix</strong>
    that.
</p>
<p>
    Place the cursor over the <strong>let</strong> expression and press
[Alt+Enter] to open the <strong>quick fix</strong> menu and<strong>change</strong> the <strong>JavaScript version</strong> to    <strong>ECMAScript 6</strong>:
</p>
<p>
    Afterwards, the errors should disappear. Let’s continue writing the code.
    Next, we need to sum the numbers. We’ll do that by creating a variable
    called <strong>sum</strong>, which will hold the result of num1 and num2,
    converted to the <strong>number</strong> data type:
</p>
<p>
    Finally, we need to set the text of the #result element, which we’ll access
    by its <strong>id</strong>, and set its <strong>inner HTML</strong> value
    to the sum:
</p>
<h4>
    5. Open the HTML Page
</h4>
<p>
    After we’re done writing our logic, it’s time to open the page and check if
    it works. We can do that by going to the <strong>top right</strong> corner
    of WebStorm and clicking our <strong>browser of choice</strong> to open the
    page in it:
</p>
<p>
    Upon clicking the <strong>Calculate</strong> button, the sum should appear
    below:
</p>
<p>
    Looks like it works!
</p>
<p>
To submit this problem to the Judge system, you need to<strong><em>submit only the </em></strong><em>sumNumbers()</em>    <em> function</em>.
</p>
<h2>
    2. Calculate Expression
</h2>
<p>
    Write a JavaScript program to print the value of the following expression:
</p>
<p>
    · ((30 + 25) * 1/3 * (35 - 14 - 12))<sup>2</sup>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="100" valign="top">
                <p>
                    <em>(no input)</em>
                    <em></em>
                </p>
            </td>
            <td width="62">
                <p>
                    27225
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
This exercise has a <strong>Judge</strong> <strong>contest</strong><strong>entry</strong>, so you need to create a        <strong>JavaScript</strong> <strong>function</strong>, for the judge
system to <strong>accept</strong> it as <strong>valid</strong>, and<strong><em>submit</em></strong>        <em> <strong>only</strong> <strong>the function</strong></em>, like so:
        <br/>
    </li>
    <li>
        You can solve this problem by either using the Math.pow() method, using
        the <strong>exponentiation operator</strong> (**) or by multiplying the
        result by <strong>itself</strong>.
    </li>
</ul>
<h2>
    3. Sum Two Numbers
</h2>
<p>
    Write a JavaScript program to sum <strong>two numbers</strong>, which are
    received as a <strong>string array</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="112" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="17" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="108" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="112" valign="top">
                <p align="center">
                    ['10', '20']
                </p>
            </td>
            <td width="62">
                <p align="center">
                    30
                </p>
            </td>
            <td width="17" valign="top">
            </td>
            <td width="108" valign="top">
                <p align="center">
                    ['66', '4']
                </p>
            </td>
            <td width="62">
                <p align="center">
                    70
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · The first and second numbers will be elements in the first parameter of
    the function, like so:
    <br/>
    <br/>
    In this case, the two numbers would be nums[0] and nums[1].
</p>
<ul>
    <li>
        Since the input is received as a <strong>string array</strong>, you’re
        going to have to do some conversion, in order to be able to sum them.
    </li>
</ul>
<h2>
    4. Three Integers Sum
</h2>
<p>
    Write a JavaScript program, which receives <strong>three numbers</strong>,
    as a <strong>string array</strong>. Your task is to check whether there
    exists a number in the sequence, which is equal to the <strong>sum</strong>
    of the other two.
</p>
<p>
    · If they are, print the numbers and their sum in the following format:
    “`${num1} + ${num2} = ${sum}`”. Print the elements, in such way, that num1
    &lt;= num2
</p>
<ul>
    <li>
        If there’s no such element, print “No”.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="98" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="14" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="116" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="68" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    8 15 7
                </p>
            </td>
            <td width="98">
                <p align="center">
                    7 + 8 = 15
                </p>
            </td>
            <td width="14" valign="top">
            </td>
            <td width="84" valign="top">
                <p align="center">
                    -5 -3 -2
                </p>
            </td>
            <td width="116">
                <p align="center">
                    -3 + -2 = -5
                </p>
            </td>
            <td width="13" valign="top">
            </td>
            <td width="68" valign="top">
                <p align="center">
                    3 8 12
                </p>
            </td>
            <td width="62">
                <p align="center">
                    No
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Symmetric Numbers
</h2>
<p>
    Write a JavaScript program, which receives <strong>a number </strong>n, as
    a <strong>string array</strong> with a single element, and print all
    symmetrical numbers in the range [1…n].
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="382" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    100
                </p>
            </td>
            <td width="382">
                <p align="center">
                    1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="382" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p>
                    750
                </p>
            </td>
            <td width="382" valign="top">
                <p>
                    1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99 101 111 121
                    131 141 151 161 171 181 191 202 212 222 232 242 252 262 272
                    282 292 303 313 323 333 343 353 363 373 383 393 404 414 424
                    434 444 454 464 474 484 494 505 515 525 535 545 555 565 575
                    585 595 606 616 626 636 646 656 666 676 686 696 707 717 727
                    737 747
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Sums by Town
</h2>
<p>
    You are given a sequence of <strong>JSON</strong> <strong>strings</strong>
    holding <strong>town</strong> + <strong>income</strong>. Write a JS
function to <strong>sum</strong> and print the <strong>incomes</strong> for<strong>each town</strong>. Towns can appear    <strong>multiple times</strong>. In the output, <strong>order</strong> the
    towns by <strong>name</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="262" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="188" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="262" valign="top">
                <p>
                    {"town":"Sofia","income":200}
                </p>
                <p>
                    {"town":"Varna","income":120}
                </p>
                <p>
                    {"town":"Pleven","income":60}
                </p>
                <p>
                    {"town":"Varna","income":70}
                </p>
            </td>
            <td width="188" valign="top">
                <p>
                    Pleven -&gt; 60
                </p>
                <p>
                    Sofia -&gt; 200
                </p>
                <p>
                    Varna -&gt; 190
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Largest 3 Numbers
</h2>
<p>
Write a program to read an <strong>array</strong> of    <strong>numbers</strong> and find and print the <strong>largest 3</strong>
    of them, sorted in <strong>descending order</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="148" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" valign="top">
                <p>
                    <strong></strong>
                </p>
            </td>
            <td width="116" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148" valign="top">
                <p>
                    10 30 15 20 50 5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    50
                </p>
                <p>
                    30
                </p>
                <p>
                    20
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="60" valign="top">
                <p>
                    20 30
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    30
                </p>
                <p>
                    20
                </p>
            </td>
            <td width="13" valign="top">
            </td>
            <td width="116" valign="top">
                <p>
                    10 5 20 3 20
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    20
                </p>
                <p>
                    20
                </p>
                <p>
                    10
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Extract Capital-Case Words
</h2>
<p>
    Write a <strong>JavaScript</strong> function to <strong>extract</strong>
from array of strings all <strong>capital-case</strong> words. All<strong>non-letter chars</strong> are considered    <strong>separators</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="448" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="270" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="448" valign="top">
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
            <td width="270" valign="top">
                <p align="center">
                    HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC,
                    MVC
                </p>
            </td>
        </tr>
    </tbody>
</table>