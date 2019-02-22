<h1>
    Lab: Arrays: Simple Array Processing
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        “Programming Fundamentals Extended” course @ SoftUni
    </a>
    .
</p>
<p>
    You can check your solutions here:
    <a
        href="https://judge.softuni.bg/Contests/384/Arrays-Simple-Array-Processing-Lab"
    >
        https://judge.softuni.bg/Contests/384/Arrays-Simple-Array-Processing-Lab
    </a>
    .
</p>
<h2>
    1. Sum Array Elements
</h2>
<p>
    Write a program which reads an <strong>array</strong> of integers,
    calculates its <strong>sum</strong> and <strong>prints </strong>it.
</p>
<p>
    The input consists of a <strong>number</strong> n (the number of elements)
    + n integers, each as a separate line.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="92">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    <strong>4</strong>
                </p>
                <p>
                    1
                </p>
                <p>
                    2
                </p>
                <p>
                    3
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="62">
                <p>
                    10
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    <strong>5</strong>
                </p>
                <p>
                    1
                </p>
                <p>
                    1
                </p>
                <p>
                    1
                </p>
                <p>
                    1
                </p>
                <p>
                    1
                </p>
            </td>
            <td width="62">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    <strong>4</strong>
                </p>
                <p>
                    2
                </p>
                <p>
                    -1
                </p>
                <p>
                    -2
                </p>
                <p>
                    8
                </p>
            </td>
            <td width="62">
                <p>
                    7
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
        First, read the number n.
    </li>
</ul>
<p>
    · Allocate an array of n integers.
</p>
<ul>
    <li>
        Read the integers in a for-loop.
    </li>
</ul>
<h2>
    2. Multiply an Array of Doubles
</h2>
<p>
    Write a program to read <strong>an array of doubles</strong>, a double p,
    multiply each element by p and print the resulting array.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="157">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="157">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="157">
                <p>
                    1.2 3.0 12.3 4.56
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="157">
                <p>
                    4.8 12 49.2 18.24
                </p>
            </td>
        </tr>
        <tr>
            <td width="157">
                <p>
                    6.0 8.8 1.2 -9.6
                </p>
                <p>
                    0.5
                </p>
            </td>
            <td width="157">
                <p>
                    3 4.4 0.6 -4.8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · First, use the Split() function to read the integers on the single line
</p>
<ul>
    <li>
Use a <strong>for loop</strong> to convert the resulting        <strong>string array </strong>into a <strong>double array</strong>
    </li>
    <li>
        <strong>Loop through </strong>
the array, <strong>multiplying each element </strong>by        <strong>p</strong>
    </li>
    <li>
Finally, <strong>print</strong> the resulting array, using a        <strong>for</strong> loop
    </li>
</ul>
<h2>
    3. Smallest Element in Array
</h2>
<p>
Write a program to read <strong>an array of integers</strong>, find the    <strong>smallest element </strong>and <strong>print</strong> it.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="116">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="116">
                <p>
                    <strong>1</strong>
                    2 3 4
                </p>
            </td>
            <td width="62">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="116">
                <p>
                    3 2 9 <strong>-9</strong> 6 1
                </p>
            </td>
            <td width="62">
                <p>
                    -9
                </p>
            </td>
        </tr>
        <tr>
            <td width="116">
                <p>
                    -6 0 <strong>-17</strong> -1
                </p>
            </td>
            <td width="62">
                <p>
                    -17
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · First, use the Split() function to read the integers on the single line
</p>
<ul>
    <li>
Use a <strong>for loop</strong> to convert the resulting        <strong>string array </strong>into an <strong>integer array</strong>
    </li>
    <li>
Finally, <strong>loop through </strong>the<strong>integer array </strong>until you find the        <strong>smallest element</strong>
    </li>
</ul>
<h2>
    4. Rotate Array of Strings
</h2>
<p>
Write a program to read <strong>an array of strings</strong>,    <strong>rotate</strong> it to the right and <strong>print</strong> its
    rotated elements.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="132">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="107">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="132">
                <p>
                    a b c d e
                </p>
            </td>
            <td width="107">
                <p>
                    e a b c d
                </p>
            </td>
        </tr>
        <tr>
            <td width="132">
                <p>
                    soft uni hi
                </p>
            </td>
            <td width="107">
                <p>
                    hi soft uni
                </p>
            </td>
        </tr>
        <tr>
            <td width="132">
                <p>
                    i r a b
                </p>
            </td>
            <td width="107">
                <p>
                    b i r a
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints:
</h3>
<ul>
    <li>
        You can store the rotated array in a <strong>second array</strong>
        alongside the first one
    </li>
</ul>
<h2>
    5. Count of Odd Numbers in Array
</h2>
<p>
Write a program to read <strong>an array of integers</strong> and find    <strong>how many odd elements it holds</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="116">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    <strong>1</strong>
                    -2 <strong>3</strong> 4
                </p>
            </td>
            <td width="116">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    <strong>3</strong>
                    <strong>9</strong>
                    <strong>-9</strong>
                    -6 <strong>1</strong> -2
                </p>
            </td>
            <td width="116">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    66 0 2 1
                </p>
            </td>
            <td width="116">
                <p>
                    1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints:
</h3>
<ul>
    <li>
You can check if a number is <strong>odd</strong> if you<strong>divide them by 2 </strong>and check whether you get        <strong>a remainder of 1</strong>.
    </li>
    <li>
Odd numbers which are negative have a <strong>remainder</strong> of        <strong>-1</strong>.
    </li>
</ul>
<h2>
    6. Odd Numbers at Odd Positions
</h2>
<p>
Write a program to read an array of integers and find how many    <strong>odd numbers</strong> at <strong>odd positions</strong> the array
holds. If there are no numbers which match this criteria,    <strong>do not print anything</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="157">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="124">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="358" valign="top">
                <p align="center">
                    <strong>Explanation</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="157">
                <p>
2 <strong>3</strong> 5 2 7 <strong>9</strong> -1                    <strong>-7</strong>
                </p>
            </td>
            <td width="124">
                <p>
                    Index 1 -&gt; 3
                </p>
                <p>
                    Index 5 -&gt; 9
                </p>
                <p>
                    Index 7 -&gt; -7
                </p>
            </td>
            <td width="358" valign="top">
                <p>
Indexes: 0 <strong>1</strong> 2 3 4 <strong>5</strong> 6                    <strong>7</strong>
                </p>
                <p>
Numbers: 2 <strong>3</strong> 5 2 7 <strong>9</strong>                    <strong>-1</strong> -7
                </p>
                <p>
                    Odd positions with odd numbers: 1, 5 and 7
                </p>
            </td>
        </tr>
        <tr>
            <td width="157">
                <p>
                    2 <strong>3</strong> 55 2 4 <strong>1</strong>
                </p>
            </td>
            <td width="124">
                <p>
                    Index 1 -&gt; 3
                </p>
                <p>
                    Index 5 -&gt; 1
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    Indexes: 0 <strong>1</strong> 2 3 4 <strong>5</strong>
                </p>
                <p>
                    Numbers: 2 <strong>3</strong> 55 2 4 <strong>1</strong>
                </p>
                <p>
                    Odd positions with odd numbers: 1 and 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="157">
                <p>
                    5 0 1 2
                </p>
            </td>
            <td width="124">
                <p>
                    <em>(no output)</em>
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    Indexes: 0 1 2 3
                </p>
                <p>
                    Numbers: 5 0 1 2
                </p>
                <p>
                    Odd positions with odd numbers: <strong>none</strong>
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
        Positions are counted <strong>from</strong> <strong>0</strong> from
left to right, so if for example the second element (<strong>index 1</strong>) is <strong>odd</strong>, then we        <strong>should</strong> count it, and so on…
    </li>
    <li>
Do <strong>NOT </strong>count odd numbers which are at        <strong>even </strong>positions (0, 2, 4, etc…)
    </li>
</ul>