<h1>
    Lab: Dictionaries
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
    <a
        href="https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab"
    >
        https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab
    </a>
    .
</p>
<h2>
    1. Odd Occurrences
</h2>
<p>
    Write a program that extracts from a given sequence of words all elements
that present in it <strong>odd number of times</strong> (case-insensitive).    <strong></strong>
</p>
<p>
    · Words are given in a single line, space separated.<strong></strong>
</p>
<p>
· Print the result elements in lowercase, in their order of appearance.    <strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="265" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="128" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="265" valign="top">
                <p>
                    Java C# PHP PHP JAVA C java
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    java, c#, c
                </p>
            </td>
        </tr>
        <tr>
            <td width="265" valign="top">
                <p>
                    3 5 5 hi pi HO Hi 5 ho 3 hi pi
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    5, hi
                </p>
            </td>
        </tr>
        <tr>
            <td width="265" valign="top">
                <p>
                    a a A SQL xx a xx a A a XX c
                </p>
            </td>
            <td width="128" valign="top">
                <p>
                    a, SQL, xx, c
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
        Use a <strong>dictionary</strong> (string à int) to count the
        occurrences of each word (just like in the previous problem).
    </li>
    <li>
        Pass through all <strong>key-value pairs</strong> in the dictionary and
append to the results list all <strong>keys</strong> that have        <strong>odd value</strong>.
    </li>
    <li>
        Print the results list.
    </li>
</ul>
<h2>
    2. Count Real Numbers
</h2>
<p>
Read a <strong>list of real numbers</strong> and<strong>print them in ascending order</strong> along with their    <strong>number of occurrences</strong>.<strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="87" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="126" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="25" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="101" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="122" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="70" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="129" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="87" valign="top">
                <p>
                    8 2.5 2.5 8 2.5
                </p>
            </td>
            <td width="126" valign="top">
                <p>
                    2.5 -&gt; 3 times
                </p>
                <p>
                    8 -&gt; 2 times
                </p>
            </td>
            <td width="101" valign="top">
                <p>
                    1.5 5 1.5 3
                </p>
            </td>
            <td width="122" valign="top">
                <p>
                    1.5 -&gt; 2 times
                </p>
                <p>
                    3 -&gt; 1 times
                </p>
                <p>
                    5 -&gt; 1 times
                </p>
            </td>
            <td width="70" valign="top">
                <p>
                    -2 0.33 0.33 2
                </p>
            </td>
            <td width="129" valign="top">
                <p>
                    -2 -&gt; 1 times
                </p>
                <p>
                    0.33 -&gt; 2 times
                </p>
                <p>
                    2 -&gt; 1 times
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Use SortedDictionary&lt;double, int&gt; named counts.
</p>
<p>
    · Pass through each input number num and increase counts[num] (when num
    exists in the dictionary) or assign counts[num] = 1 (when num does not
    exist in the dictionary).
</p>
<p>
    · Pass through all numbers num in the dictionary (counts.Keys) and print
    the number num and its count of occurrences counts[num].
</p>