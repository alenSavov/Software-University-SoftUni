<h1>
    Exercises: Array and List Algorithms
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
    <a href="https://judge.softuni.bg/Contests/427/">
        https://judge.softuni.bg/Contests/427/
    </a>
</p>
<h2>
    1. Shoot List Elements
</h2>
<p>
Until you receive the command "stop", you will either receive an    <strong>integer</strong>, or the command bang on every line.
</p>
<p>
    If you receive an integer, place it at the <strong>front</strong> of the
    list. If, however, you receive the command bang, <strong>remove</strong>
the first element whose value is <strong>smaller</strong> than the<strong>average</strong> of the elements of the list,    <strong>print</strong> "shot {element}" and then <strong>decrement</strong>
    every element in the list by <strong>1</strong>.
</p>
<p>
    If you receive "bang" and there are no elements left in the list, print
    "nobody left to shoot! last one was {lastRemovedInt}" and end the program.
When you finally do receive the command "end", either    <strong>print</strong> "survivors: {elements, separated by space}" if there
    are any, or "you shot them all. last one standing was {lastRemovedInt}".
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="52" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="310" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="325" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="52" valign="top">
                <p>
                    3
                </p>
                <p>
                    4
                </p>
                <p>
                    5
                </p>
                <p>
                    6
                </p>
                <p>
                    2
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
            </td>
            <td width="310" valign="top">
                <p>
                    shot 2
                </p>
                <p>
                    shot 3
                </p>
                <p>
                    shot 1
                </p>
                <p>
                    shot 2
                </p>
                <p>
                    shot 2
                </p>
                <p>
                    nobody left to shoot! last one was 2
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Insert 3 at front è 3
                </p>
                <p>
                    Insert 4 at front è 4 3
                </p>
                <p>
                    Insert 5 at front è 5 4 3
                </p>
                <p>
                    Insert 6 at front è 6 5 4 3
                </p>
                <p>
                    Insert 2 at front è 2 6 5 4 3
                </p>
                <p>
                    bang è average: 4 è remove 2
                </p>
                <p>
                    after removal è 6 5 4 3
                </p>
                <p>
                    decrement everything è 5 4 3 2
                </p>
                <p>
                    bang è average: 3.5 è remove 3
                </p>
                <p>
                    after removal è 5 4 2
                </p>
                <p>
                    decrement everything è 4 3 1
                </p>
                <p>
                    bang è average: 2.66 è remove 1
                </p>
                <p>
                    after removal è 4 3
                </p>
                <p>
                    decrement everything è 3 2
                </p>
                <p>
                    bang è average: 2.5 è remove 2
                </p>
                <p>
                    after removal è 3
                </p>
                <p>
                    decrement everything è 2
                </p>
                <p>
                    bang è last element è remove 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="52" valign="top">
                <p>
                    56
                </p>
                <p>
                    12
                </p>
                <p>
                    33
                </p>
                <p>
                    915
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    stop
                </p>
            </td>
            <td width="310" valign="top">
                <p>
                    shot 33
                </p>
                <p>
                    shot 11
                </p>
                <p>
                    shot 54
                </p>
                <p>
                    shot 912
                </p>
                <p>
                    you shot them all. last one was 912
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Insert 56 at front è 56
                </p>
                <p>
                    Insert 12 at front è 12 56
                </p>
                <p>
                    Insert 33 at front è 33 12 56
                </p>
                <p>
                    Insert 915 at front è 915 33 12 56
                </p>
                <p>
                    bang è average: 254 è remove 33
                </p>
                <p>
                    after removal è 915 12 56
                </p>
                <p>
                    decrement everything è 914 11 55
                </p>
                <p>
                    bang è average: 326.66 è remove 11
                </p>
                <p>
                    after removal è 914 55
                </p>
                <p>
                    decrement everything è 913 54
                </p>
                <p>
                    bang è average: 483.5 è remove 54
                </p>
                <p>
                    after removal è 913
                </p>
                <p>
                    decrement everything è 912
                </p>
                <p>
                    bang è last element è remove 912
                </p>
                <p>
                    stop è nothing left in list
                </p>
            </td>
        </tr>
        <tr>
            <td width="52" valign="top">
                <p>
                    99
                </p>
                <p>
                    150
                </p>
                <p>
                    3450
                </p>
                <p>
                    819
                </p>
                <p>
                    bang
                </p>
                <p>
                    bang
                </p>
                <p>
                    stop
                </p>
            </td>
            <td width="310" valign="top">
                <p>
                    shot 819
                </p>
                <p>
                    shot 149
                </p>
                <p>
                    survivors: 3448 97
                </p>
            </td>
            <td width="325" valign="top">
                <p>
                    Insert 99 at front è 99
                </p>
                <p>
                    Insert 150 at front è 150 99
                </p>
                <p>
                    Insert 3450 at front è 3450 150 99
                </p>
                <p>
                    Insert 819 at front è 819 3450 150 99
                </p>
                <p>
                    bang è average: 1129.5 è remove 819
                </p>
                <p>
                    after removal è 3450 150 99
                </p>
                <p>
                    decrement everything è 3449 149 98
                </p>
                <p>
                    bang è average: 1232 è remove 149
                </p>
                <p>
                    after removal è 3449 98
                </p>
                <p>
                    decrement everything è 3448 97
                </p>
                <p>
                    stop è survivors: 3448 97
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Average Character Delimiter
</h2>
<p>
    You will receive an array of <strong>strings</strong> as input. Your task
    is to find the <strong>average character</strong> within every string in
the array. As in, take every character’s <strong>ASCII</strong> code,<strong>sum</strong> it and <strong>divide</strong> the result by the    <strong>sum</strong> of the <strong>count</strong> of all the letters in
    the array.
</p>
<p>
    <strong>Example</strong>
    :
</p>
<p>
    a b ab abc abc è a, b, a, b a, b, c, a, b, c è sum: 978 è Divide it by 10:
    97.8 è <strong>97</strong>
</p>
<p>
    After you find the average sum, convert it to its <strong>ASCII</strong>
character representation, <strong>convert</strong> it to<strong>uppercase</strong> and <strong>print</strong> the    <strong>original array</strong>, <strong>delimited</strong> by that
    character.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="168" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="220" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="168" valign="top">
                <p>
                    a b ab abc abc
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    aAbAabAabcAabc
                </p>
            </td>
            <td width="220" valign="top">
                <p>
                    Sum of a+b+a+b+a+b+c+a+b+c: 978
                </p>
                <p>
                    Divided by 10: 97.8 è97 èa
                </p>
                <p>
                    To uppercase: A
                </p>
                <p>
                    original array, delimited by a:
                </p>
                <p>
                    aAbAabAabcAabc
                </p>
            </td>
        </tr>
        <tr>
            <td width="168" valign="top">
                <p>
                    gosho pesho 1 2 3
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    gosho_pesho_1_2_3
                </p>
            </td>
            <td width="220" valign="top">
                <p>
                    Sum of letters: 1237
                </p>
                <p>
                    Divided by 13: 95 è _
                </p>
                <p>
                    Original array, delimited by _:
                </p>
                <p>
                    gosho_pesho_1_2_3
                </p>
            </td>
        </tr>
        <tr>
            <td width="168" valign="top">
                <p>
                    SOFTWARE University
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    SOFTWARE^University
                </p>
            </td>
            <td width="220" valign="top">
                <p>
                    Sum of letters: 1709
                </p>
                <p>
                    Divided by 18: 94 è ^
                </p>
                <p>
                    Original array, delimited by ^:
                </p>
                <p>
                    SOFTWARE^University
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Sort Array of Strings
</h2>
<p>
    You are given an array of strings (one line, space-delimited). Sort the
array using the <strong>Bubble sort</strong> or    <strong>Insertion sort</strong> algorithms. Instead of comparing if one
    string is smaller than the other (which you can’t do), you can use the
string.CompareTo(str) method. Once the array is sorted,    <strong>print</strong> it on the console, separating the elements by
    spaces.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="302" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="302" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="302" valign="top">
                <p>
                    abc abc test 123 123 test
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    123 123 abc abc test test
                </p>
            </td>
        </tr>
        <tr>
            <td width="302" valign="top">
                <p>
                    8 6 7 2 pesho 9
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    2 6 7 8 9 pesho
                </p>
            </td>
        </tr>
        <tr>
            <td width="302" valign="top">
                <p>
                    softuni SOFTUNI software university
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    SOFTUNI softuni software university
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Array Histogram
</h2>
<p>
    You will be given a <strong>string array</strong> on the console (single
    line, <strong>space-separated</strong>). Your task is to make statistics
    about the elements of the array. Find out <strong>how many times</strong>
each word <strong>occurs</strong> in the array. After which,    <strong>sort</strong> the result by the <strong>count</strong> of
    occurrences in <strong>descending</strong> order and print statistics about
    every word in the following format:
</p>
<p>
    {word} -&gt; {count} times ({percentage:F2}%)
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="495" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="228" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="495" valign="top">
                <p>
                    hello hello pesho hello four two gosho five pesho six gosho
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    hello -&gt; 3 times (27.27%)
                </p>
                <p>
                    pesho -&gt; 2 times (18.18%)
                </p>
                <p>
                    gosho -&gt; 2 times (18.18%)
                </p>
                <p>
                    four -&gt; 1 times (9.09%)
                </p>
                <p>
                    two -&gt; 1 times (9.09%)
                </p>
                <p>
                    five -&gt; 1 times (9.09%)
                </p>
                <p>
                    six -&gt; 1 times (9.09%)
                </p>
            </td>
        </tr>
        <tr>
            <td width="495" valign="top">
                <p>
                    get the get request from the get url of get dot com
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    get -&gt; 4 times (33.33%)
                </p>
                <p>
                    the -&gt; 2 times (16.67%)
                </p>
                <p>
                    request -&gt; 1 times (8.33%)
                </p>
                <p>
                    from -&gt; 1 times (8.33%)
                </p>
                <p>
                    url -&gt; 1 times (8.33%)
                </p>
                <p>
                    of -&gt; 1 times (8.33%)
                </p>
                <p>
                    dot -&gt; 1 times (8.33%)
                </p>
                <p>
                    com -&gt; 1 times (8.33%)
                </p>
            </td>
        </tr>
        <tr>
            <td width="495" valign="top">
                <p>
                    trep trep trep trep trepni trepni trepni
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    trep -&gt; 4 times (57.14%)
                </p>
                <p>
                    trepni -&gt; 3 times (42.86%)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    You can solve the problem in the following way:
</p>
<ul>
    <li>
Make two lists: one for the <strong>words</strong> and one for their        <strong>occurrences count</strong>.
    </li>
    <li>
        Iterate over every element in the initial array:
    </li>
</ul>
<p>
    o If it’s <strong>not</strong> contained in the <strong>words</strong>
list, <strong>add it</strong>, and <strong>add 1</strong> to the    <strong>occurrences count</strong> list.
</p>
<p>
    o If it <strong>is</strong> contained in the <strong>words</strong> list,
    increment the number at the <strong>occurrences count</strong> list (which
is placed on the same index as the word itself in the    <strong>words</strong> list)
</p>
<p>
· After you iterate over the entire initial array, you should have the<strong>unique words</strong> in the <strong>words list</strong> and their<strong>occurrence count</strong> in the    <strong>occurrences count </strong>list.
</p>
<ul>
    <li>
        <strong>Sort </strong>
the <strong>words list</strong> and<strong>occurrence count list</strong> at the<strong>same time</strong> by <strong>modifying</strong> a standard        <strong>sorting algorithm</strong>:<strong></strong>
    </li>
</ul>
<p>
    o First – reverse the swapping logic in the algorithm, so that the elements
    are sorted in <strong>descending order</strong>.
</p>
<p>
o Second – instead of swapping just the elements in the<strong>occurrences count list</strong>, swap the elements in the    <strong>words list </strong>at the <strong>same time</strong>, ensuring
    that when you move one element at one index in one list, the other element
in the other list will have the    <strong>same index after it’s swapped</strong>.
</p>
<ul>
    <li>
        After both lists are sorted at the same time, <strong>iterate</strong>
        over <strong>either</strong> of them and print the elements at each
        index in the aforementioned format. Since you’re sure a word in one
list will <strong>always </strong>have its occurrences at the        <strong>same index</strong> of the other list, you can iterate over
        either list.
    </li>
</ul>
<h2>
    5. Decode Radio Frequencies
</h2>
<p>
    You are given an array of <strong>doubles</strong> (one line,
    space-separated). Your task is to <strong>convert</strong> the double
    values to their <strong>character representations</strong> and insert them
    into a list like so:
</p>
<ul>
    <li>
        Example: 83.105
    </li>
</ul>
<p>
    · Extract the left part of the number and convert it to its ASCII code
    representation: 83 è S
</p>
<p>
    · Extract the right part of the number and convert I to its ASCII code
    representation: 105 è i
</p>
<p>
    · Insert the left character at the position equal to the index of the
    double number in the original array. è Index of double: 0 è insert S at
    index 0
</p>
<p>
    · Insert the right character at the position equal to the index of the
    double number in the original array, <strong>counted in reverse</strong>:
index of the double: 0 è insert “i” at index 0, counted    <strong>in reverse</strong> (so, the end of the list)
</p>
<p>
    Repeat the aforementioned algorithm for each element of the double array,
until you run out of elements. When you do, print the list with    <strong>no delimiter</strong>.
</p>
<p>
If any of the parts of the double number are 0 (such as 86.0 or 0.97),    <strong>ignore</strong> them and do not insert them anywhere.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="237" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="165" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="305" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    83.105 111.110 102.85 116.0
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    SoftUni
                </p>
            </td>
            <td width="305" valign="top">
                <p>
                    83.105:
                </p>
                <p>
                    Left part è 83 è S, right part è105 èi
                </p>
                <p>
                    Index of 83.105 è 0
                </p>
                <p>
                    Insert S at index 0 èS
                </p>
                <p>
                    Insert I at index 0, backwards èS i
                </p>
                <p>
                    111.110:
                </p>
                <p>
                    Left part è 111 è o, right part è110 èn
                </p>
                <p>
                    Index of 111.110 è 1
                </p>
                <p>
                    Insert o at index 1 è S o i
                </p>
                <p>
                    Insert I at index 1, backwards èS o n i
                </p>
                <p>
                    102.85:
                </p>
                <p>
                    Left part è 102 è f, right part è85 èU
                </p>
                <p>
                    Index of 102.85 è 2
                </p>
                <p>
                    Insert o at index 2 è S o f n i
                </p>
                <p>
                    Insert I at index 2, backwards èS o f t n i
                </p>
                <p>
                    116.0:
                </p>
                <p>
                    Left part è 116 è U, right part è0 èignore
                </p>
                <p>
                    Index of 116.0 è 3
                </p>
                <p>
                    Insert o at index 2 è S o f t U n i
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    66.33 105.97 114.0 0.0
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Bira!
                </p>
            </td>
            <td width="305" valign="top">
                <p>
                    66.33:
                </p>
                <p>
                    Left part è 66 è B, right part è 33 è!
                </p>
                <p>
                    Index of 66.33 è 0
                </p>
                <p>
                    Insert B at index 0 èB
                </p>
                <p>
                    Insert ! at index 0, backwards èB !
                </p>
                <p>
                    105.97:
                </p>
                <p>
                    Left part è 105è i, right part è 97 èa
                </p>
                <p>
                    Index of 105.97 è 1
                </p>
                <p>
                    Insert i at index 1 èB i !
                </p>
                <p>
                    Insert a at index 1, backwards èB i a !
                </p>
                <p>
                    114.0:
                </p>
                <p>
                    Left part è 114 è r, right part è0 èignore
                </p>
                <p>
                    Index of 114.0 è 2
                </p>
                <p>
                    Insert r at index 2 èB i r a !
                </p>
                <p>
                    0.0:
                </p>
                <p>
                    Left part è 0 è ignore, right part è 0 èignore
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    110.115 111.113 116.101 32.114 114.102 97.32 100.111 105.0
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    not radio freqs
                </p>
            </td>
            <td width="305" valign="top">
                <p>
                    The space character has an ascii code of 32
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    72.46 101.100 114.105 101.107 39.32 115.44 32.117 108.111
                    111.121 111.32 107.116 105.97 110.32 103.0
                </p>
            </td>
            <td width="165" valign="top">
                <p>
                    Here's looking at you, kid.
                </p>
            </td>
            <td width="305" valign="top">
                <p>
                    ' has an ascii character code of 39 and , has a character
                    code of 44. The period has an ascii code of 46.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Batteries
</h2>
<p>
    You are in a battery manufacturing plant. Your task is to stress test the
    latest batch of batteries for longevity.
</p>
<p>
    You will receive an array of <strong>doubles</strong> on the console (first
    line, space-separated), indicating the <strong>capacities</strong> of the
    different batteries in the batch (in mAh). On the next line, you will
receive the <strong>usage per hour</strong> for each battery as an array of    <strong>doubles </strong>(second line, space-separated).
</p>
<p>
    Next, you will receive the amount of hours you have to stress test each
    battery for (as an <strong>integer</strong>). Each of the batteries drains
    by its capacity until either the testing hours are over, or the battery
    dies (reaches 0 capacity).
</p>
<p>
    Print the status of all the batteries at the end of the testing session (in
percentage). If any batteries die, along with the percentage, print<strong>how many hours</strong> it took. The <strong>capacity</strong> and<strong>percentage</strong> are <strong>rounded</strong> to the 2    <sup>nd</sup> decimal point.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="237" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="277" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    3000 3600 800.56 6000
                </p>
                <p>
                    350 400 200 600
                </p>
                <p>
                    8
                </p>
            </td>
            <td width="277" valign="top">
                <p>
                    Battery 1: 200.00 mAh (6.67)%
                </p>
                <p>
                    Battery 2: 400.00 mAh (11.11)%
                </p>
                <p>
                    Battery 3: dead (lasted 5 hours)
                </p>
                <p>
                    Battery 4: 1200.00 mAh (20.00)%
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    1200 9128.22 110 3129.11
                </p>
                <p>
                    120 400 200 600
                </p>
                <p>
                    9
                </p>
            </td>
            <td width="277" valign="top">
                <p>
                    Battery 1: 120.00 mAh (10.00)%
                </p>
                <p>
                    Battery 2: 5528.22 mAh (60.56)%
                </p>
                <p>
                    Battery 3: dead (lasted 1 hours)
                </p>
                <p>
                    Battery 4: dead (lasted 6 hours)
                </p>
            </td>
        </tr>
        <tr>
            <td width="237" valign="top">
                <p>
                    81279 9128.22 110 99812
                </p>
                <p>
                    1500 400 200 1372.40
                </p>
                <p>
                    72
                </p>
            </td>
            <td width="277" valign="top">
                <p>
                    Battery 1: dead (lasted 55 hours)
                </p>
                <p>
                    Battery 2: dead (lasted 23 hours)
                </p>
                <p>
                    Battery 3: dead (lasted 1 hours)
                </p>
                <p>
                    Battery 4: 999.20 mAh (1.00)%
                </p>
            </td>
        </tr>
    </tbody>
</table>