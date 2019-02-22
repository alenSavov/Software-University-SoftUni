<h1>
    Lab: Advanced Collections
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
    <a href="https://judge.softuni.bg/Contests/429">
        https://judge.softuni.bg/Contests/429
    </a>
    .
</p>
<h1>
    I. Multi-Dictionaries, Nested Dictionaries
</h1>
<h2>
    1. Average Student Grades
</h2>
<p>
    Write a program, which reads the <strong>name</strong> of a student and
their <strong>grades</strong> and <strong>adds</strong> them to the<strong>student record</strong>, then <strong>prints</strong><strong>grades</strong> along with their <strong>average grade</strong>.    <strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="128" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="322" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="128" valign="top">
                <p>
                    7
                </p>
                <p>
                    Ivancho 5.20
                </p>
                <p>
                    Mariika 5.50
                </p>
                <p>
                    Ivancho 3.20
                </p>
                <p>
                    Mariika 2.50
                </p>
                <p>
                    Stamat 2.00
                </p>
                <p>
                    Mariika 3.46
                </p>
                <p>
                    Stamat 3.00
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Ivancho -&gt; 5.20 3.20 (avg: 4.20)
                </p>
                <p>
                    Mariika -&gt; 5.50 2.50 3.46 (avg: 3.82)
                </p>
                <p>
                    Stamat -&gt; 2.00 3.00 (avg: 2.50)
                </p>
            </td>
        </tr>
        <tr>
            <td width="128" valign="top">
                <p>
                    4
                </p>
                <p>
                    Vladimir 4.50
                </p>
                <p>
                    Petko 3.00
                </p>
                <p>
                    Vladimir 5.00
                </p>
                <p>
                    Petko 3.66
                </p>
                <p>
                    Ivan 4.33
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Vladimir -&gt; 4.50 5.00 (avg: 4.75)
                </p>
                <p>
                    Petko -&gt; 3.00 3.66 (avg: 3.33)
                </p>
            </td>
        </tr>
        <tr>
            <td width="128" valign="top">
                <p>
                    5
                </p>
                <p>
                    Gosho 6.00
                </p>
                <p>
                    Gosho 5.50
                </p>
                <p>
                    Gosho 6.00
                </p>
                <p>
                    Ivan 4.40
                </p>
                <p>
                    Petko 3.30
                </p>
                <p>
                    Petko 4.50
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Gosho -&gt; 6.00 5.50 6.00 (avg: 5.83)
                </p>
                <p>
                    Ivan -&gt; 4.40 (avg: 4.40)
                </p>
                <p>
                    Petko -&gt; 3.30 (avg: 3.30)
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
        Use a <strong>dictionary</strong> (string à List&lt;double&gt;)
    </li>
</ul>
<p>
    · Check if the name exists before adding the grade. If it doesn’t, add it
    to the dictionary.
</p>
<ul>
    <li>
        Pass through all <strong>key-value pairs</strong> in the dictionary and
        print the results. You can use the .Average() method to quickly
        calculate the average value from a list.
    </li>
</ul>
<h2>
    2. Cities by Continent and Country
</h2>
<p>
Write a program to read <strong>continents</strong>,<strong>countries</strong> and their <strong>cities</strong>, put them in a<strong>nested dictionary</strong> and <strong>print</strong> them.    <strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="209" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="322" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="209" valign="top">
                <p>
                    9
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Asia China Beijing
                </p>
                <p>
                    Asia Japan Tokyo
                </p>
                <p>
                    Europe Poland Warsaw
                </p>
                <p>
                    Europe Germany Berlin
                </p>
                <p>
                    Europe Poland Poznan
                </p>
                <p>
                    Europe Bulgaria Plovdiv
                </p>
                <p>
                    Africa Nigeria Abuja
                </p>
                <p>
                    Asia China Shanghai
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Europe:
                </p>
                <p>
                    Bulgaria -&gt; Sofia, Plovdiv
                </p>
                <p>
                    Poland -&gt; Warsaw, Poznan
                </p>
                <p>
                    Germany -&gt; Berlin
                </p>
                <p>
                    Asia:
                </p>
                <p>
                    China -&gt; Beijing, Shanghai
                </p>
                <p>
                    Japan -&gt; Tokyo
                </p>
                <p>
                    Africa:
                </p>
                <p>
                    Nigeria -&gt; Abuja
                </p>
            </td>
        </tr>
        <tr>
            <td width="209" valign="top">
                <p>
                    3
                </p>
                <p>
                    Europe Germany Berlin
                </p>
                <p>
                    Europe Bulgaria Varna
                </p>
                <p>
                    Africa Egypt Cairo
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Europe:
                </p>
                <p>
                    Germany -&gt; Berlin
                </p>
                <p>
                    Bulgaria -&gt; Varna
                </p>
                <p>
                    Africa:
                </p>
                <p>
                    Egypt -&gt; Cairo
                </p>
            </td>
        </tr>
        <tr>
            <td width="209" valign="top">
                <p>
                    8
                </p>
                <p>
                    Africa Somalia Mogadishu
                </p>
                <p>
                    Asia India Mumbai
                </p>
                <p>
                    Asia India Delhi
                </p>
                <p>
                    Europe France Paris
                </p>
                <p>
                    Asia India Nagpur
                </p>
                <p>
                    Europe Germany Hamburg
                </p>
                <p>
                    Europe Poland Gdansk
                </p>
                <p>
                    Europe Germany Danzig
                </p>
            </td>
            <td width="322" valign="top">
                <p>
                    Africa:
                </p>
                <p>
                    Somalia -&gt; Mogadishu
                </p>
                <p>
                    Asia:
                </p>
                <p>
                    India -&gt; Mumbai, Delhi, Nagpur
                </p>
                <p>
                    Europe:
                </p>
                <p>
                    France -&gt; Paris
                </p>
                <p>
                    Germany -&gt; Hamburg, Danzig
                </p>
                <p>
                    Poland -&gt; Gdansk
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
        Use a <strong>nested</strong> <strong>dictionary</strong> (string à
        (Dictionary à List&lt;string&gt;))
    </li>
</ul>
<p>
    · Check if the continent exists before adding the country. If it doesn’t,
    add it to the dictionary.
</p>
<p>
    · Check if the country exists, before adding the city. If it doesn’t, add
    it to the dictionary.
</p>
<ul>
    <li>
        Pass through all <strong>key-value pairs</strong> in the dictionary and
        the values’ key-value pairs and print the results.
    </li>
</ul>
<h1>
    II. Sets
</h1>
<h2>
    3. Record Unique Names
</h2>
<p>
Write a program, which will take a list of <strong>names</strong> and print    <strong>only</strong> the <strong>unique </strong>names in the list.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="17" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="17" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="59" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="66" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="72" valign="top">
                <p>
                    8
                </p>
                <p>
                    Ivan
                </p>
                <p>
                    Pesho
                </p>
                <p>
                    Ivan
                </p>
                <p>
                    Stamat
                </p>
                <p>
                    Pesho
                </p>
                <p>
                    Alice
                </p>
                <p>
                    Peter
                </p>
                <p>
                    Pesho
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    Ivan
                </p>
                <p>
                    Pesho
                </p>
                <p>
                    Stamat
                </p>
                <p>
                    Alice
                </p>
                <p>
                    Peter
                </p>
            </td>
            <td width="17" valign="top">
            </td>
            <td width="72" valign="top">
                <p>
                    7
                </p>
                <p>
                    Lyle
                </p>
                <p>
                    Bruce
                </p>
                <p>
                    Alice
                </p>
                <p>
                    Easton
                </p>
                <p>
                    Shawn
                </p>
                <p>
                    Alice
                </p>
                <p>
                    Shawn
                </p>
                <p>
                    Peter
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    Lyle
                </p>
                <p>
                    Bruce
                </p>
                <p>
                    Alice
                </p>
                <p>
                    Easton
                </p>
                <p>
                    Shawn
                </p>
            </td>
            <td width="17" valign="top">
            </td>
            <td width="59" valign="top">
                <p>
                    6
                </p>
                <p>
                    Roki
                </p>
                <p>
                    Roki
                </p>
                <p>
                    Roki
                    <br/>
                    Roki
                </p>
                <p>
                    Roki
                </p>
                <p>
                    Roki
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    Roki
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    You can store the names in a HashSet&lt;string&gt; to extract only the
    unique ones.
</p>
<h2>
    4. Group Continents, Countries and Cities
</h2>
<p>
Write a program, which receives <strong>continents</strong>,<strong>countries</strong> and <strong>city names</strong> and    <strong>prints them</strong>, grouped by continent, country and city, all
    in <strong>alphabetical order</strong>. No duplicates are allowed.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="209" valign="top">
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
            <td width="209" valign="top">
                <p>
                    9
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Asia China Beijing
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Europe Poland Warsaw
                </p>
                <p>
                    Europe Germany Berlin
                </p>
                <p>
                    Europe Poland Poznan
                </p>
                <p>
                    Europe Poland Warsaw
                </p>
                <p>
                    Asia China Beijing
                </p>
                <p>
                    Asia China Shanghai
                </p>
            </td>
            <td width="249" valign="top">
                <p>
                    Asia:
                </p>
                <p>
                    China -&gt; Beijing, Shanghai
                </p>
                <p>
                    Europe:
                </p>
                <p>
                    Bulgaria -&gt; Sofia
                </p>
                <p>
                    Germany -&gt; Berlin
                </p>
                <p>
                    Poland -&gt; Poznan, Warsaw
                </p>
            </td>
        </tr>
        <tr>
            <td width="209" valign="top">
                <p>
                    7
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Europe Bulgaria Plovdiv
                </p>
                <p>
                    Europe Bulgaria Sofia
                </p>
                <p>
                    Asia China Beijing
                </p>
                <p>
                    Asia India Mumbai
                </p>
                <p>
                    Europe Turkey Istanbul
                </p>
            </td>
            <td width="249" valign="top">
                <p>
                    Asia:
                </p>
                <p>
                    China -&gt; Beijing
                </p>
                <p>
                    India -&gt; Mumbai
                </p>
                <p>
                    Europe:
                </p>
                <p>
                    Bulgaria -&gt; Plovdiv, Sofia
                </p>
                <p>
                    Turkey -&gt; Istanbul
                </p>
            </td>
        </tr>
        <tr>
            <td width="209" valign="top">
                <p>
                    10
                </p>
                <p>
                    Europe Turkey Ankara
                </p>
                <p>
                    Asia China Shenyang
                </p>
                <p>
                    Asia India Delhi
                </p>
                <p>
                    Asia India Pune
                </p>
                <p>
                    Asia Japan Yokohama
                </p>
                <p>
                    Asia China Suzhou
                </p>
                <p>
                    Europe Russia Moscow
                </p>
                <p>
                    Europe Turkey Ankara
                </p>
                <p>
                    Asia Japan Tokyo
                </p>
                <p>
                    Asia India Pune
                </p>
            </td>
            <td width="249" valign="top">
                <p>
                    Asia:
                </p>
                <p>
                    China -&gt; Shenyang, Suzhou
                </p>
                <p>
                    India -&gt; Delhi, Pune
                </p>
                <p>
                    Japan -&gt; Tokyo, Yokohama
                </p>
                <p>
                    Europe:
                </p>
                <p>
                    Russia -&gt; Moscow
                </p>
                <p>
                    Turkey -&gt; Ankara
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Since everything needs to be sorted and unique, you can use a
    SortedDictionary&lt;string, SortedDictionary&lt;string,
SortedSet&lt;string&gt;&gt;&gt;. That way, since we’re using<strong>dictionaries</strong>, we <strong>won’t have</strong> any<strong>duplicated</strong> <strong>continents</strong> or    <strong>countries</strong>.<strong></strong>
</p>
<p>
· By using a SortedSet to store the city names, we ensure we    <strong>won’t have</strong> any <strong>repeating</strong> cities. Since
everything is sorted, the alphabetical order is taken care of.    <strong></strong>
</p>