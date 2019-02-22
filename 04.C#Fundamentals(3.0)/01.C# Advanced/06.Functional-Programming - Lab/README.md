<h1 align="center">
    Lab: Functional Programming
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-advanced">
        "CSharp Advanced" course @ Software University.
    </a>
</p>
<p>
    Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/Practice/Index/597">
        https://judge.softuni.bg/Contests/Practice/Index/597
    </a>
    <a href="https://judge.softuni.bg/Contests/597/Functional-Programming-Lab">
        .
    </a>
</p>
<h2>
    1. Sort Even Numbers
</h2>
<p>
    Write a program that reads one line of <strong>integers</strong> separated
    by <strong>", "</strong>. Then print the <strong>even numbers </strong>of
    that sequence<strong> sorted </strong>in<strong> increasing</strong> order.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="111">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="118">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="70">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="55">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="15" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="105">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="71">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="111" valign="top">
                <p>
                    4, 2, 1, 3, 5, 7, 1, 4, 2, 12
                </p>
            </td>
            <td width="118" valign="top">
                <p>
                    2, 2, 4, 4, 12
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    1, 3, 5
                </p>
            </td>
            <td width="55" valign="top">
            </td>
            <td width="105" valign="top">
                <p>
                    2, 4, 6
                </p>
            </td>
            <td width="71" valign="top">
                <p>
                    2, 4, 6
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    It is up to you what type of data structures you will use to solve this
    problem
</p>
<p>
    Using functional programming filter and sort the collection of numbers.
</p>
<h2>
    2. Sum Numbers
</h2>
<p>
Write a program that reads a line of <strong>integers</strong> separated by    <strong>", "</strong>. Print on two lines the <strong>count</strong> of
    numbers and their <strong>sum.</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="277">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="281">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="277" valign="top">
                <p>
                    4, 2, 1, 3, 5, 7, 1, 4, 2, 12
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    10
                </p>
                <p>
                    41
                </p>
            </td>
        </tr>
        <tr>
            <td width="277" valign="top">
                <p>
                    2, 4, 6
                </p>
            </td>
            <td width="281" valign="top">
                <p>
                    3
                </p>
                <p>
                    12
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Count Uppercase Words
</h2>
<p>
    Write a program that reads a line of <strong>text</strong> from the
console. Print <strong>all</strong> words that start with an    <strong>uppercase letter</strong> in the <strong>same order</strong> you
    receive them in the text.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="243">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="316">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    The following example shows how to use Function
                </p>
            </td>
            <td width="316" valign="top">
                <p>
                    The
                </p>
                <p>
                    Function
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    Write a program that reads one line of text from console.
                    Print count of words that start with Uppercase, after that
                    print all those words in the same order like you find them
                    in text.
                </p>
            </td>
            <td width="316" valign="top">
                <p>
                    Write
                </p>
                <p>
                    Print
                </p>
                <p>
                    Uppercase,
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    Use <strong>Func&lt;string, bool&gt; </strong>like or in if condition
</p>
<p>
    Use <strong>" "</strong> for splitting words.
</p>
<h2>
    4. Add VAT
</h2>
<p>
    Write a program that reads one line of <strong>double </strong>prices
separated by <strong>", "</strong>. Print the <strong>prices</strong> with<strong>added</strong> <strong>VAT</strong> for all of them.    <strong>Format</strong> them to <strong>2</strong> <strong>signs</strong>
    after the decimal point. The <strong>order</strong> of the prices must be
    the <strong>same</strong>.
    <br/>
    VAT is equal to 20% of the price.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="140">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="148">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="15" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="140">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="148">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="140" valign="top">
                <p>
                    1.38, 2.56, 4.4
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    1.66
                </p>
                <p>
                    3.07
                </p>
                <p>
                    5.28
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    1, 3, 5, 7
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    1.20
                </p>
                <p>
                    3.60
                </p>
                <p>
                    6.00
                </p>
                <p>
                    8.40
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Filter by Age
</h2>
<p>
    Write a program that receives an integer <strong>N</strong> on first line.
On the next <strong>N</strong> lines, read pairs of    <strong>"[name], [age]". </strong>Then read three lines with:
</p>
<ul>
    <li>
        <strong>Condition</strong>
        - "younger" or "older"
    </li>
    <li>
        <strong>Age</strong>
        - Integer
    </li>
    <li>
        <strong>Format</strong>
        - "name", "age" or "name age"
    </li>
</ul>
<p>
Depending on the <strong>condition</strong>, print the correct    <strong>pairs</strong> in the correct <strong>format</strong>.
</p>
<p>
    <strong>
        Don’t use the built-in functionality from .NET. Create your own
        methods.
    </strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="96">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="14" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="96" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="96" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="96" valign="top">
                <p>
                    5
                </p>
                <p>
                    Pesho, 20
                    <br/>
                    Gosho, 18
                    <br/>
                    Mimi, 29
                    <br/>
                    Ico, 31
                    <br/>
                    Simo, 16
                </p>
                <p>
                    older
                </p>
                <p>
                    20
                </p>
                <p>
                    name age
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    Pesho - 20
                </p>
                <p>
                    Mimi - 29
                </p>
                <p>
                    Ico - 31
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    5
                </p>
                <p>
                    Pesho, 20
                    <br/>
                    Gosho, 18
                    <br/>
                    Mimi, 29
                    <br/>
                    Ico, 31
                    <br/>
                    Simo, 16
                </p>
                <p>
                    younger
                </p>
                <p>
                    20
                </p>
                <p>
                    name
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    Gosho
                </p>
                <p>
                    Simo
                </p>
            </td>
            <td width="13" valign="top">
            </td>
            <td width="96" valign="top">
                <p>
                    5
                </p>
                <p>
                    Pesho, 20
                    <br/>
                    Gosho, 18
                    <br/>
                    Mimi, 29
                    <br/>
                    Ico, 31
                    <br/>
                    Simo, 16
                </p>
                <p>
                    younger
                </p>
                <p>
                    50
                </p>
                <p>
                    age
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    20
                </p>
                <p>
                    18
                </p>
                <p>
                    29
                </p>
                <p>
                    31
                </p>
                <p>
                    16
                </p>
            </td>
        </tr>
    </tbody>
</table>