<h1 align="center">
    Exercise: Java Basics
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/software-technologies">
        “Software Technologies” course @ SoftUni
    </a>
    .
</p>
<p>
    You can submit your solutions here:
    <a href="https://judge.softuni.bg/Contests/712/Java-Basics-Exercises">
        https://judge.softuni.bg/Contests/712/Java-Basics-Exercises
    </a>
    .
</p>
<h1>
    Part I: Data Types and Methods
</h1>
<h2>
    1. Variable in Hexadecimal Format
</h2>
<p>
    Write a program that reads a number in <strong>hexadecimal format</strong>
    convert it to <strong>decimal format</strong> and prints it.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="55" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="67" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    FE
                </p>
            </td>
            <td width="67" valign="top">
                <p>
                    254
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    37
                </p>
            </td>
            <td width="67" valign="top">
                <p>
                    55
                </p>
            </td>
        </tr>
        <tr>
            <td width="55" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="67" valign="top">
                <p>
                    16
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
        Use
        <a href="http://www.tutorialspoint.com/java/number_parseint.htm">
            <strong>Integer.parseInt(string, base)</strong>
        </a>
        .
    </li>
</ul>
<h2>
    2. Boolean Variable
</h2>
<p>
Write a program that reads a <strong>string</strong>, converts it to<strong>Boolean</strong> variable and <strong>prints </strong>“<strong>Yes</strong>”<strong> </strong>if the variable is true and “    <strong>No</strong>” if the variable is false.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="64" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="67" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    True
                </p>
            </td>
            <td width="67" valign="top">
                <p>
                    Yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    False
                </p>
            </td>
            <td width="67" valign="top">
                <p>
                    No
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
        Java has a function, which takes a string and converts it to a Boolean.
    </li>
</ul>
<h2>
    3. Reverse Characters
</h2>
<p>
    Write a program to ask the user for <strong>3 letters</strong> and print
    them in <strong>reversed order</strong>.<strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="54" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="35" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="31" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
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
            <td width="54" valign="top">
                <p>
                    A
                </p>
                <p>
                    B
                </p>
                <p>
                    C
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    CBA
                </p>
            </td>
            <td width="35" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    x
                </p>
                <p>
                    Y
                </p>
                <p>
                    z
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    zYx
                </p>
            </td>
            <td width="31" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    G
                </p>
                <p>
                    g
                </p>
                <p>
                    n
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    ngG
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Vowel or Digit
</h2>
<p>
Create a program to check if given symbol is <strong>digit</strong>,<strong>vowel</strong> or any <strong>other symbol</strong>.    <strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="34" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="31" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
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
            <td width="51" valign="top">
                <p>
                    a
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    vowel
                </p>
            </td>
            <td width="34" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    9
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    digit
                </p>
            </td>
            <td width="31" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    g
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    other
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Integer to Hex and Binary
</h2>
<p>
Write a program to convert a <strong>decimal number</strong> to    <strong>hexadecimal</strong> and <strong>binary</strong> number and print
    it.<strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="35" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="92" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="31" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="92" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    A
                </p>
                <p>
                    1010
                </p>
            </td>
            <td width="35" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    420
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    1A4
                </p>
                <p>
                    110100100
                </p>
            </td>
            <td width="31" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    256
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    100
                </p>
                <p>
                    100000000
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · There are built-in methods, that convert Integer to Hex and Binary.
</p>
<h1>
    Part II: Arrays
</h1>
<h2>
    6. Compare Char Arrays
</h2>
<p>
Write a program, which <strong>compares</strong> two char arrays    <strong>lexicographically</strong> (letter by letter).
</p>
<p>
    Print the them in <strong>alphabetical order</strong>, each on separate
    line.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="92" valign="top">
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
            <td width="92">
                <p>
                    a b c
                </p>
                <p>
                    d e f
                </p>
            </td>
            <td width="62">
                <p>
                    abc
                </p>
                <p>
                    def
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    p e t e r
                </p>
                <p>
                    a n n i e
                </p>
            </td>
            <td width="62">
                <p>
                    annie
                </p>
                <p>
                    peter
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    a n n i e
                </p>
                <p>
                    a n
                </p>
            </td>
            <td width="62">
                <p>
                    an
                </p>
                <p>
                    annie
                </p>
            </td>
        </tr>
        <tr>
            <td width="92">
                <p>
                    a b
                </p>
                <p>
                    a b
                </p>
            </td>
            <td width="62">
                <p>
                    ab
                </p>
                <p>
                    ab
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Compare the first letter of arr1[] and arr2[], if equal, compare the next
    letter, etc.
</p>
<p>
· If all letters are equal, the smaller array is the    <strong>shorter</strong>.
</p>
<p>
    · If all letters are equal and the array lengths are the same, the arrays
    are <strong>equal</strong>.
</p>
<h2>
    7. Max Sequence of Equal Elements
</h2>
<p>
Write a program that finds the    <strong>longest sequence of equal elements</strong> in an array of
    integers. If several longest sequences exist, print the leftmost one.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="173" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="173">
                <p>
                    2 1 1 2 3 3 <strong>2 2 2</strong> 1
                </p>
            </td>
            <td width="76">
                <p>
                    2 2 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="173">
                <p>
                    <strong>1 1 1</strong>
                    2 3 1 3 3
                </p>
            </td>
            <td width="76">
                <p>
                    1 1 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="173">
                <p>
                    <strong>4 4 4 4</strong>
                </p>
            </td>
            <td width="76">
                <p>
                    4 4 4 4
                </p>
            </td>
        </tr>
        <tr>
            <td width="173">
                <p>
                    0 <strong>1 1</strong> 5 2 2 6 3 3
                </p>
            </td>
            <td width="76">
                <p>
                    1 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Start with the sequence that consists of the first element: start=0,
    len=1.
</p>
<ul>
    <li>
        Scan the elements <strong>from left to right</strong>, starting at the
        second element: pos=1…n-1.
    </li>
</ul>
<p>
    o At each step compare the current element with the element on the left:
</p>
<p>
    § Same value à you have found a sequence longer by one à len++.
</p>
<p>
§ Different value à <strong>start a new sequence</strong> from the    <strong>current element</strong>: start=pos, len=1.
</p>
<p>
    o After each step remember the sequence it is found to be longest at the
    moment: bestStart=start, bestLen=len.
</p>
<ul>
    <li>
        Finally, print the longest sequence by using bestStart and bestLen.
    </li>
</ul>
<h2>
    8. Max Sequence of Increasing Elements
</h2>
<p>
Write a program that finds the    <strong>longest increasing subsequence</strong> in an array of integers.
The longest increasing subsequence is a<strong>portion of the array</strong> (subsequence) that is strongly<strong>increasing</strong> and has the    <strong>longest possible length</strong>. If several such subsequences
    exist, find the left most of them.
</p>
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
            <td width="94" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="130">
                <p>
                    3 <strong>2 3 4</strong> 2 2 4
                </p>
            </td>
            <td width="94">
                <p>
                    2 3 4
                </p>
            </td>
        </tr>
        <tr>
            <td width="130">
                <p>
                    4 5 <strong>1 2 3 4 5</strong>
                </p>
            </td>
            <td width="94">
                <p>
                    1 2 3 4 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="130">
                <p>
                    <strong>3 4 5 6</strong>
                </p>
            </td>
            <td width="94">
                <p>
                    3 4 5 6
                </p>
            </td>
        </tr>
        <tr>
            <td width="130">
                <p>
                    <strong>0 1 </strong>
                    1 2 2 3 3
                </p>
            </td>
            <td width="94">
                <p>
                    0 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Use the same algorithm like in the previous problem (Max Sequence of
    Equal Elements).
</p>
<h2>
    9. Most Frequent Number
</h2>
<p>
    Write a program that finds the <strong>most frequent number</strong> in a
    given sequence of numbers.
</p>
<ul>
    <li>
Numbers will be in the range <strong>[0…</strong>        <strong>65535]</strong>.
    </li>
</ul>
<p>
· In case of multiple numbers with the same maximum frequency, print the    <strong>left-most</strong> of them.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="216" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="421" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="216">
                <p>
                    <strong>4</strong>
1 1 <strong>4</strong> 2 3 <strong>4 4</strong> 1 2                    <strong>4</strong> 9 3
                </p>
            </td>
            <td width="62">
                <p>
                    4
                </p>
            </td>
            <td width="421">
                <p>
                    The number <strong>4</strong> is the most frequent (occurs
                    5 times)
                </p>
            </td>
        </tr>
        <tr>
            <td width="216">
                <p>
                    <strong>2 2 2 2</strong>
                    1 <strong>2 2 2</strong>
                </p>
            </td>
            <td width="62">
                <p>
                    2
                </p>
            </td>
            <td width="421">
                <p>
                    The number <strong>2</strong> is the most frequent (occurs
                    7 times)
                </p>
            </td>
        </tr>
        <tr>
            <td width="216">
                <p>
                    <strong>7 7 7</strong>
                    0 2 2 2 0 10 10 10
                </p>
            </td>
            <td width="62">
                <p>
                    7
                </p>
            </td>
            <td width="421">
                <p>
The numbers <strong>2</strong>, <strong>7</strong> and                    <strong>10</strong> have the same maximal frequence (each
                    occurs 3 times). The leftmost of them is <strong>7</strong>
                    .
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Index of Letters
</h2>
<p>
    Write a program that creates an array containing all letters from the
    alphabet (<strong>a</strong>-<strong>z</strong>). Read a lowercase word
from the console and print the    <strong>index of each of its letters in the letters array</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    abcz
                </p>
            </td>
            <td width="76">
                <p>
                    a -&gt; 0
                </p>
                <p>
                    b -&gt; 1
                </p>
                <p>
                    c -&gt; 2
                </p>
                <p>
                    z -&gt; 25
                </p>
            </td>
        </tr>
        <tr>
            <td width="76" valign="top">
                <p>
                    softuni
                </p>
            </td>
            <td width="76">
                <p>
                    s -&gt; 18
                </p>
                <p>
                    o -&gt; 14
                </p>
                <p>
                    f -&gt; 5
                </p>
                <p>
                    t -&gt; 19
                </p>
                <p>
                    u -&gt; 20
                </p>
                <p>
                    n -&gt; 13
                </p>
                <p>
                    i -&gt; 8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Equal Sums
</h2>
<p>
Write a program that determines if there<strong>exists an element in the array</strong> such that the    <strong>sum of the elements on its left</strong> is <strong>equal</strong>
to the <strong>sum of the elements on its right</strong>. If there are<strong>no elements to the left / right</strong>, their<strong>sum is considered to be 0</strong>. Print the<strong>index</strong> that satisfies the required condition or    <strong>“no”</strong> if there is no such index.
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
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="345" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    1 2 3 3
                </p>
            </td>
            <td width="62">
                <p>
                    2
                </p>
            </td>
            <td width="345">
                <p>
                    At a[2] -&gt; left sum = 3, right sum = 3
                </p>
                <p>
                    a[0] + a[1] = a[3]
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    1 2
                </p>
            </td>
            <td width="62">
                <p>
                    no
                </p>
            </td>
            <td width="345">
                <p>
                    At a[0] -&gt; left sum = 0, right sum = 2
                </p>
                <p>
                    At a[1] -&gt; left sum = 1, right sum = 0
                </p>
                <p>
                    No such index exists
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    1
                </p>
            </td>
            <td width="62">
                <p>
                    0
                </p>
            </td>
            <td width="345">
                <p>
                    At a[0] -&gt; left sum = 0, right sum = 0
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    1 2 3
                </p>
            </td>
            <td width="62">
                <p>
                    no
                </p>
            </td>
            <td width="345">
                <p>
                    No such index exists
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    10 5 5 99 3 4 2 5 1 1 4
                </p>
            </td>
            <td width="62">
                <p>
                    3
                </p>
            </td>
            <td width="345">
                <p>
                    At a[3] -&gt; left sum = 20, right sum = 20
                </p>
                <p>
                    a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] +
                    a[9] + a[10]
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Bomb Numbers
</h2>
<p>
Write a program that <strong>reads sequence of numbers</strong> and    <strong>special bomb number </strong>with a certain<strong> power</strong>.
Your task is to    <strong>detonate every occurrence of the special bomb number</strong> and
    according to its power <strong>his neighbors from left and right</strong>.
    Detonations are performed from left to right and all detonated numbers
    disappear. Finally print the<strong> sum of the remaining elements</strong>
    in the sequence.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="173" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="453" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    1 2 2 4 2 2 2 9
                </p>
                <p>
                    4 2<strong></strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    12
                </p>
            </td>
            <td width="453" valign="top">
                <p>
                    Special number is <strong>4</strong> with power 2. After
                    detontaion we left with the sequence [1, 2, 9] with sum 12.
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    1 4 4 2 8 9 1
                </p>
                <p>
                    9 3
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="453" valign="top">
                <p>
                    Special number is <strong>9</strong> with power 3. After
                    detontaion we left with the sequence [1, 4] with sum 5.
                    Since the 9 has only 1 neighbour from the right we remove
                    just it (one number instead of 3).
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    1 7 7 1 2 3
                </p>
                <p>
                    7 1
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="453" valign="top">
                <p>
                    Detonations are performed from left to right. We could not
                    detonate the second occurance of 7 because its already
                    destroyed by the first occurance. The numbers [1, 2, 3]
                    survive. Their sum is 6.
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    1 1 2 1 1 1 2 1 1 1
                </p>
                <p>
                    2 1
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="453" valign="top">
                <p>
                    The red and yellow numbers disappear in two sequential
                    detonations. The result is the sequence [1, 1, 1, 1]. Sum =
                    4.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    Part IV: Strings, Maps and Stream API
</h1>
<h2>
    13. Reverse String
</h2>
<p>
Write a program that reads a string from the console,<strong>reverses</strong> <strong>its letters</strong> and    <strong>prints</strong> the result back at the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="92" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="92" valign="top">
                <p align="center">
                    <strong>Output </strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    sample
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    elpmas
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    24tvcoi92
                </p>
            </td>
            <td width="92" valign="top">
                <p>
                    29iocvt42
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
        <strong>Variant I</strong>
: convert the string to <strong>char array</strong>,        <strong>reverse</strong> it, then convert it to <strong>string</strong>
        again.
    </li>
    <li>
        <strong>Variant II</strong>
        : print the letters of the string right-to-left in a for-loop.
    </li>
</ul>
<h2>
    14. Fit String in 20 Chars
</h2>
<p>
Write a program that <strong>reads</strong> from the console a string and    <strong>fits the string in 20 characters</strong> as follows:
</p>
<ul>
    <li>
        If the string has <strong>less than 20 characters</strong>, append
asterisks ‘*’ to it until it’s        <strong>exactly 20 characters long</strong>.
    </li>
    <li>
        If the string length is <strong>more than 20 characters</strong>,
        discard all characters after the first 20.
    </li>
</ul>
<p>
    <strong>Print</strong>
    the result string at the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="462" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="190" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="462" valign="top">
                <p>
                    Welcome to SoftUni!
                </p>
            </td>
            <td width="190" valign="top">
                <p>
                    Welcome to SoftUni!*
                </p>
            </td>
        </tr>
        <tr>
            <td width="462" valign="top">
                <p>
                    A "regular expression" (abbreviated regex or regexp) is a
                    sequence of characters that forms a search pattern.
                </p>
            </td>
            <td width="190" valign="top">
                <p>
                    A "regular expressio
                </p>
            </td>
        </tr>
        <tr>
            <td width="462" valign="top">
                <p>
                    C#
                </p>
            </td>
            <td width="190" valign="top">
                <p>
                    C#******************
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · If string has a length &lt; 20, write a padRight(20, '*') method.
</p>
<p>
    · If string has a length &gt; 20, use substring(0, 20).
</p>
<h2>
    15. Censor Email Address
</h2>
<p>
    You have some text that contains your email address. You are sick of
spammers, so you want to <strong>hide</strong> it. You decide to<strong>censor</strong> your email: to<strong>replace all characters</strong> in it with asterisks (    <strong>'*'</strong>) <strong>except the domain</strong>.
</p>
<p>
Assume your email address will always be in format    <strong>[username]@[domain]</strong>. You need to replace the username with
    asterisks of equal number of letters and keep the domain unchanged.
</p>
<h3>
    Input
</h3>
<ul>
    <li>
        The first line holds your <strong>email</strong> address.
    </li>
    <li>
        The second line holds a <strong>text</strong> where the email should be
        censored.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="695">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    pesho.peshev@email.bg
                </p>
                <p>
                    My name is Pesho Peshev. I am from Sofia, my email is:
                    pesho.peshev@email.bg (not pesho.peshev@email.com). Test:
                    pesho.meshev@email.bg, pesho.peshev@email.bg
                </p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    My name is Pesho Peshev. I am from Sofia, my email is:
                    ************@email.bg (not pesho.peshev@email.com). Test:
                    pesho.meshev@email.bg, ************@email.bg
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    In order to accomplish the task, you may find these steps useful:
</p>
<ul>
    <li>
        <strong>Split</strong>
the email into two parts – <strong>username</strong> and        <strong>domain</strong>.
    </li>
    <li>
        Create the <strong>replacement</strong> string by duplicating the '*'
character {username.length} times and appending '@' and the        <strong>domain</strong>.
    </li>
    <li>
        <strong>Replace</strong>
all occurrences of your <strong>email</strong> with the        <strong>replacement string</strong>.
    </li>
</ul>
<h2>
    16. URL Parser
</h2>
<p>
    Write a program that <strong>parses an URL</strong> given in the following
    format:
</p>
<p>
    [protocol]://[server]/[resource]
</p>
<p>
The parsing extracts its parts: <strong>protocol</strong>,    <strong>server</strong> and <strong>resource</strong>.
</p>
<ul>
    <li>
        The <strong>[server]</strong> part is mandatory.
    </li>
    <li>
        The <strong>[protocol]</strong> and <strong>[resource]</strong> parts
        are <strong>optional</strong>.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="358" valign="top">
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
            <td width="358" valign="top">
                <p>
                    http://www.abc.com/video
                </p>
            </td>
            <td width="294">
                <p>
                    [protocol] = "http"
                </p>
                <p>
                    [server] = "www.abc.com"
                </p>
                <p>
                    [resource] = "video"
                </p>
            </td>
        </tr>
        <tr>
            <td width="358" valign="top">
                <p>
                    https://www.softuni.bg/Resources/Materials
                </p>
            </td>
            <td width="294">
                <p>
                    [protocol] = "https"
                </p>
                <p>
                    [server] = "www.softuni.bg"
                </p>
                <p>
                    [resource] = "Resources/Materials"
                </p>
            </td>
        </tr>
        <tr>
            <td width="358" valign="top">
                <p>
                    ftp://www.su.us/TestResource
                </p>
            </td>
            <td width="294">
                <p>
                    [protocol] = "ftp"
                </p>
                <p>
                    [server] = "www.su.us"
                </p>
                <p>
                    [resource] = "TestResource"
                </p>
            </td>
        </tr>
        <tr>
            <td width="358" valign="top">
                <p>
                    https://softuni.bg
                </p>
            </td>
            <td width="294">
                <p>
                    [protocol] = "https"
                </p>
                <p>
                    [server] = "softuni.bg"
                </p>
                <p>
                    [resource] = ""
                </p>
            </td>
        </tr>
        <tr>
            <td width="358" valign="top">
                <p>
                    www.nakov.com
                </p>
            </td>
            <td width="294">
                <p>
                    [protocol] = ""
                </p>
                <p>
                    [server] = "www.nakov.com"
                </p>
                <p>
                    [resource] = ""
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
        Find the leftmost occurrence of “://” in the input URL.
    </li>
</ul>
<p>
o If <strong>found</strong>, the left side holds the<strong>protocol</strong>, the right side holds the    <strong>server + resource</strong>.
</p>
<p>
    o If <strong>not found</strong>, the protocol is missing, the input string
    holds <strong>server + resource</strong> only.
</p>
<ul>
    <li>
        After the “<strong>protocol</strong>” part is removed from the input
        URL, find the <strong>leftmost occurrence</strong> of “/”.
    </li>
</ul>
<p>
o If <strong>found</strong>, the left side holds the    <strong>server</strong>, the right side holds the <strong>resource</strong>
    .
</p>
<p>
    o If <strong>not found</strong>, the resource is missing, the whole string
    holds the <strong>server</strong>.
</p>
<h2>
    17. Change to Uppercase
</h2>
<p>
Write a program that receives a <strong>string </strong>and<strong>modifies the casing of letters to uppercase</strong> at all places<strong>in the text surrounded</strong> <strong>by</strong> &lt;upcase&gt;<strong>and</strong> &lt;/upcase&gt; <strong>tags</strong>. Tags    <strong>will not</strong> be nested.<strong></strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="690" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="690">
                <p>
                    Welcome to the
                    <strong>
                        &lt;upcase&gt;Software University&lt;/upcase&gt;
                    </strong>
                    . Learn
                    <strong>
                        &lt;upcase&gt;computer programming&lt;/upcase&gt;
                    </strong>
and start a <strong>&lt;upcase&gt;</strong>                    <strong>job</strong><strong>&lt;/upcase&gt;</strong> in a
                    software company.
                </p>
            </td>
        </tr>
        <tr>
            <td width="690" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="690">
                <p>
Welcome to the <strong>SOFTWARE UNIVERSITY</strong>. Learn<strong>COMPUTER PROGRAMMING</strong> and start a                    <strong>JOB</strong> in a software company.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · You may find the position of the first &lt;upcase&gt; and the first
    &lt;/upcase&gt;, delete the text between and insert the uppercase version
    of the text without the tags at the position of &lt;upcase&gt;.
</p>
<p>
    · Repeat the above until no more &lt;upcase&gt; and &lt;/upcase&gt; tags
    are found in the text.
</p>
<h2>
    18. Phonebook
</h2>
<p>
Write a program that receives some info from the console about<strong>people</strong> and their <strong>phone numbers</strong>. Each<strong>entry</strong> should have just <strong>one name</strong> and    <strong>one number</strong> (both <strong>strings</strong>).
</p>
<p>
    On each line, you will receive some of the following commands:
</p>
<ul>
    <li>
        <strong>A {name} {phone}</strong>
– adds entry to the phonebook. In case of trying to add a name that is<strong>already</strong> in the phonebook, you should<strong>change</strong> the existing phone number to the        <strong>new one</strong>.
    </li>
    <li>
        <strong>S {name}</strong>
– searches for a contact by given name and prints it in format "        <strong>{name} -&gt; {number}</strong>".
        <br/>
In case the contact isn't found, print "        <strong>Contact {name} does not exist.</strong>".
    </li>
    <li>
        <strong>END</strong>
        – stop receiving more commands.
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
                    A Nakov 0888080808
                </p>
                <p>
                    S Mariika
                </p>
                <p>
                    S Nakov
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Contact Mariika does not exist.
                </p>
                <p>
                    Nakov -&gt; 0888080808
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    A Nakov +359888001122
                </p>
                <p>
                    A RoYaL(Ivan) 666
                </p>
                <p>
                    A Gero 5559393
                </p>
                <p>
                    A Simo 02/987665544
                </p>
                <p>
                    S Simo
                </p>
                <p>
                    S simo
                </p>
                <p>
                    S RoYaL
                </p>
                <p>
                    S RoYaL(Ivan)
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Simo -&gt; 02/987665544
                </p>
                <p>
                    Contact simo does not exist.
                </p>
                <p>
                    Contact RoYaL does not exist.
                </p>
                <p>
                    RoYaL(Ivan) -&gt; 666
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    A Misho +359883123
                </p>
                <p>
                    A Misho 02/3123
                </p>
                <p>
                    S Misho
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Misho -&gt; 02/3123
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
        by splitting by space. Execute the commands until “<strong>END</strong>
        ” is reached.
    </li>
    <li>
        Store the <strong>phonebook entries</strong> in
        LinkedHashMap&lt;String, String&gt; with key <strong>{name}</strong>
        and value <strong>{phone number}</strong>.
    </li>
</ul>
<h2>
    19. Phonebook Upgrade
</h2>
<p>
    <strong>Add functionality to the phonebook</strong>
from the previous task to    <strong>print all contacts ordered lexicographically</strong> when receive
    the command “ListAll”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="189" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    A Nakov +359888001122
                </p>
                <p>
                    A RoYaL(Ivan) 666
                </p>
                <p>
                    A Gero 5559393
                </p>
                <p>
                    A Simo 02/987665544
                </p>
                <p>
                    ListAll
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    Gero -&gt; 5559393
                </p>
                <p>
                    Nakov -&gt; +359888001122
                </p>
                <p>
                    RoYaL(Ivan) -&gt; 666
                </p>
                <p>
                    Simo -&gt; 02/987665544
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
        <strong>Variant I (slower):</strong>
        Sort all entries in the dictionary by key and print them.
    </li>
    <li>
        <strong>Variant II (faster):</strong>
        Keep the entries in more appropriate data structure that will keep them
        in sorted order for better performance.
    </li>
</ul>
<h1>
    Part V: Classes and Objects
</h1>
<h2>
    20. Count Working Days
</h2>
<p>
Write a program that <strong>reads two dates </strong>in the format<strong> </strong>dd-MM-yyyy and prints the<strong>number of working days</strong> between these two dates    <strong>inclusive</strong>. Non-working days are:
</p>
<ul>
    <li>
        All days that are <strong>Saturday</strong> or <strong>Sunday</strong>.
    </li>
    <li>
        All days that are <strong>official holidays</strong> in Bulgaria:
    </li>
</ul>
<p>
    o New Year Eve (<strong>1 Jan</strong>)
</p>
<p>
    o Liberation Day (<strong>3 March</strong>)
</p>
<p>
    o Worker’s day (<strong>1 May</strong>)
</p>
<p>
    o Saint George’s Day (<strong>6 May</strong>)
</p>
<p>
    o Saints Cyril and Methodius Day (<strong>24 May</strong>)
</p>
<p>
    o Unification Day (<strong>6 Sept</strong>)
</p>
<p>
    o Independence Day (<strong>22 Sept</strong>)
</p>
<p>
    o National Awakening Day (<strong>1 Nov</strong>)
</p>
<p>
o Christmas (<strong>24</strong>, <strong>25</strong> and    <strong>26 Dec</strong>)
</p>
<p>
    All days not mentioned above are <strong>working </strong>and should count.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="99" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="212" valign="top">
                <p align="center">
                    <strong>Calendar</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="99" valign="top">
                <p>
                    11-04-2016
                </p>
                <p>
                    14-04-2016
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="212" valign="top">
            </td>
        </tr>
        <tr>
            <td width="99" valign="top">
                <p>
                    11-04-2016
                </p>
                <p>
                    22-04-2016
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="212" valign="top">
            </td>
        </tr>
        <tr>
            <td width="99" valign="top">
                <p>
                    20-12-2015
                </p>
                <p>
                    31-12-2015
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="212" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<ul>
    <li>
        Read <strong>start date</strong> and <strong>end date</strong> from
        Console.
    </li>
    <li>
        <strong>Create</strong>
        two objects of type Date – startDate and endDate.<strong></strong>
    </li>
    <li>
Create an <strong>array of type </strong>Date and add        <strong>all official holidays</strong> in it.
    </li>
</ul>
<p>
    · Loop from startDate to endDate. Add <strong>1 day</strong> at each
    iteration.
</p>
<ul>
    <li>
Get the <strong>current da</strong>y in the loop and check whether is<strong>Saturday</strong>, <strong>Sunday</strong> or it is        <strong>contained</strong> <strong>in the holidays array</strong>. If
        it is not, increment the workingDaysCounter.
    </li>
</ul>
<h2>
    21. Advertisement Message
</h2>
<p>
Write a program that    <strong>generates a random fake advertisement message</strong> to extol
some product. The messages must consist of 4 parts: laudatory    <strong>phrase</strong> + <strong>event</strong> + <strong>author</strong>
    + <strong>city</strong>. Use the following predefined parts:
</p>
<ul>
    <li>
        <strong>Phrases</strong>
        – {"Excellent product.", "Such a great product.", "I always use that
        product.", "Best product of its category.", "Exceptional product.", "I
        can't live without this product."}
    </li>
    <li>
        <strong>Events</strong>
        – {"Now I feel good.", "I have succeeded with this product.", "Makes
        miracles. I am happy of the results!", "I cannot believe but now I feel
        awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
    </li>
    <li>
        <strong>Author</strong>
        – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
    </li>
    <li>
        <strong>Cities</strong>
        – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
    </li>
</ul>
<p>
The format of the output message is:    <strong>{phrase} {event} {author} – {city}</strong>.
</p>
<p>
    As input, you take the <strong>number of messages</strong> to be generated.
    Print each random message at a separate line.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="608" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="608" valign="top">
                <p>
                    Such a great product. Now I feel good. Elena – Ruse
                </p>
                <p>
                    Excelent product. Makes miracles. I am happy of the
                    results! Katya – Varna
                </p>
                <p>
                    Best product of its category. That makes miracles. Eva -
                    Sofia
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
        Hold the phrases, events, authors and towns in 4 arrays of strings.
    </li>
</ul>
<p>
· Create Random object and <strong>generate</strong>    <strong>4 random numbers</strong> each in its range:
</p>
<p>
    o phraseIndex à ­[0, phrases.Length]
</p>
<p>
    o eventIndex à [0, events.Length]
</p>
<p>
    o authorIndex à [0, authors.Length]
</p>
<p>
    o townIndex à [0, towns.Length]
</p>
<ul>
    <li>
        Get one<strong> random element </strong>from each of the four arrays
        and <strong>compose a message</strong> in the required format.
    </li>
</ul>
<h2>
    22. Intersection of Circles
</h2>
<p>
Create a Circle class with Center and Radius properties. The center is a    <strong>point</strong> with coordinates X and Y (make a class Point). Write
a method bool Intersect(Circle c1, Circle c2) that tells whether the    <strong>two</strong> given circles <strong>intersect or not</strong>. Write
    a program that tells if <strong>two circles</strong> intersect.
</p>
<h3>
    Input
</h3>
<p>
    The input lines will be in format: <strong>{X} {Y} {Radius}</strong>. Print
    as output “Yes” or “No”.<strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
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
            <td width="286" valign="top">
                <p align="center">
                    <strong>Visualization</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="60" valign="top">
                <p>
                    4 4 2
                </p>
                <p>
                    8 8 1
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    No
                </p>
            </td>
            <td width="286">
            </td>
        </tr>
        <tr>
            <td width="60" valign="top">
                <p>
                    3 3 2
                </p>
                <p>
                    4 3 6
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    Yes
                </p>
            </td>
            <td width="286">
            </td>
        </tr>
        <tr>
            <td width="60" valign="top">
                <p>
                    1 1 4
                </p>
                <p>
                    4 2 5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    Yes
                </p>
            </td>
            <td width="286">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<ul>
    <li>
Calculate d =<strong> distance between the circle centers</strong>.        <strong></strong>
    </li>
</ul>
<p>
· If the d ≤ r1 + r2 (the sum of radiuses<strong>) </strong>    <strong>à </strong>the circles<strong> intersect</strong> (or one of the
    circles is inside the other or the circles have one common point when d =
    r1 + r2).<strong></strong>
</p>
<p>
· If the d &gt; r1 + r2 <strong>à </strong>the circles do<strong>not intersect</strong> (they have not common shared point).    <strong></strong>
</p>
<h2>
    23. Average Grades
</h2>
<p>
    Define a class Student, which holds the following information about
students: <strong>name</strong>, <strong>list of grades</strong> and    <strong>average grade</strong> (calculated property, read-only). A single
    grade will be in range [2…6], e.g. 3.25 or 5.50.
</p>
<p>
Read a <strong>list of students</strong> and print the students that have    <strong>average grade ≥ 5.00</strong> ordered <strong>by name</strong>
    (ascending), then by <strong>average</strong> <strong>grade </strong>
    (descending). Print the student name and the calculated average grade.
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
            <td width="165" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    3
                </p>
                <p>
                    Ivan 3
                </p>
                <p>
                    Todor 5 5 6
                </p>
                <p>
                    Diana 6 5.50
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Diana -&gt; 5.75
                </p>
                <p>
                    Todor -&gt; 5.33
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    6
                </p>
                <p>
                    Petar 3 5 4 3 2 5 6 2 6
                </p>
                <p>
                    Mitko 6 6 5 6 5 6
                </p>
                <p>
                    Gosho 6 6 6 6 6 6
                </p>
                <p>
                    Ani 6 5 6 5 6 5 6 5
                </p>
                <p>
                    Iva 4 5 4 3 4 5 2 2 4
                </p>
                <p>
                    Ani 5.50 5.25 6.00
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Ani -&gt; 5.58
                </p>
                <p>
                    Ani -&gt; 5.50
                </p>
                <p>
                    Gosho -&gt; 6.00
                </p>
                <p>
                    Mitko -&gt; 5.67
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Create class Student with properties Name (string), Grades (double[]),
    and property AverageGrade (calculated by LINQ as Grades.Average(),
    read-only).
</p>
<ul>
    <li>
        Make a <strong>list of students</strong> and filter<strong> </strong>
all students that has average grade &gt;= 5.00 using Java’s        <strong>stream API</strong>.
    </li>
    <li>
        Print the filtered students <strong>ordered by name</strong> in
        ascending order, then by <strong>average grade</strong> in descending
        order.
    </li>
</ul>
<h2>
    24. Book Library
</h2>
<p>
To model a <strong>book library</strong>, define classes to hold a    <strong>book</strong> and a <strong>library</strong>. The library must have
    a <strong>name</strong> and a <strong>list of books</strong>. The books
must contain the <strong>title</strong>, <strong>author</strong>,<strong> publisher</strong>,<strong> release date</strong>,    <strong> ISBN-number </strong>and<strong> price. </strong>
</p>
<p>
    Read a <strong>list of books</strong>, add them to the library and print
    the <strong>total sum of prices by author</strong>,<strong> </strong>
ordered <strong>descending by price</strong> and    <strong>then by author’s name lexicographically</strong>.
</p>
<p>
Books in the input will be in format    <strong>{title} {author} {publisher} {release date} {ISBN} {price}</strong>
    .
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="439">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="165">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="439" valign="top">
                <p>
                    5
                </p>
                <p>
                    LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00
                </p>
                <p>
                    Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25
                </p>
                <p>
                    HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50
                </p>
                <p>
                    HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00
                </p>
                <p>
AC OBowden PenguinBooks 20.11.2009 0395082555 14.00                    <strong></strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Tolkien -&gt; 40.25
                </p>
                <p>
                    JKRowling -&gt; 35.50
                </p>
                <p>
                    OBowden -&gt; 14.00
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Create classes Book and Library with all the mentioned above properties:
</p>
<ul>
    <li>
        <strong>Create</strong>
        an object of type Library.
    </li>
    <li>
        <strong>Read the input</strong>
and create a Book<strong> </strong>object for each book in the input.        <strong></strong>
    </li>
    <li>
Create a <strong>STREAM</strong> query that will<strong>sum the prices by author</strong>,        <strong>order the results</strong> as requested.
    </li>
    <li>
        <strong>Print</strong>
        the results.
    </li>
</ul>
<h2>
    25. Book Library Modification
</h2>
<p>
Use the classes from the previous problem and make a program that<strong>read a list of books</strong> and <strong>print all titles</strong>    <strong>released after given date</strong> ordered <strong>by date</strong>
    and then <strong>by</strong> <strong>title lexicographically</strong>. The
    date is given if format “<strong>day-month-year</strong>” at the last line
    in the input.<strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="447">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="165">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="447" valign="top">
                <p>
                    5
                </p>
                <p>
                    LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00
                </p>
                <p>
                    Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25
                </p>
                <p>
                    HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50
                </p>
                <p>
                    HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00
                </p>
                <p>
                    AC OBowden PenguinBooks 20.11.2009 0395082555 14.00
                </p>
                <p>
                    30.07.1954<strong></strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    HP1 -&gt; 26.06.1997
                </p>
                <p>
                    HP7 -&gt; 21.07.2007
                </p>
                <p>
                    AC -&gt; 20.11.2009
                </p>
            </td>
        </tr>
    </tbody>
</table>