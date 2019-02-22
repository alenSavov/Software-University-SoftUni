<h1>
    Exercises: Lists
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
    <a href="https://judge.softuni.bg/Contests/424">
        https://judge.softuni.bg/Contests/424
    </a>
    .
</p>
<h2>
    1. Remove Elements at Odd Positions
</h2>
<p>
Write a program which reads a <strong>list</strong> of<strong>space-separated</strong> <strong>strings</strong> and    <strong>removes</strong> the elements at positions [1…3…5…7…etc.]. After
that, <strong>print</strong> the elements with<strong>no delimiter</strong>. Note that positions are    <strong>counted from 1</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="213" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="116" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="213">
                <p>
                    First Soft ccc Uni fifth
                </p>
            </td>
            <td width="116">
                <p>
                    SoftUni
                </p>
            </td>
        </tr>
        <tr>
            <td width="213">
                <p>
                    now you're_ fired hired
                </p>
            </td>
            <td width="116">
                <p>
                    you're_hired
                </p>
            </td>
        </tr>
        <tr>
            <td width="213">
                <p>
                    java I_ x &lt; php 3_ - C#
                </p>
            </td>
            <td width="116">
                <p>
                    I_&lt;3_C#
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
· Instead of removing elements from the initial list,<strong>create</strong> a new list and <strong>add</strong> the    <strong>even</strong> elements to it.
</p>
<h2>
    2. Track Downloader
</h2>
<p>
    You will receive a list of <strong>blacklisted words </strong>(on the same
    line, separated by <strong>one</strong> space). On the next lines, you will
start receiving a list of <strong>filenames</strong> (as    <strong>strings</strong>) until you receive the string “end”. Your task is
to <strong>add</strong> the filenames to a <strong>list</strong> and<strong>sort</strong> them. <strong>Ignore</strong> the tracks which    <strong>contain</strong> the text in the <strong>blacklist</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="334" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="334" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="334" valign="top">
                <p>
                    Metallica Linkin Park
                </p>
                <p>
                    01. Ceca - Maskarada.mp3
                </p>
                <p>
                    6.Metallica–Nothing Else Matters.mp3
                </p>
                <p>
                    Kilo_dole_kilo_gore_superfreedotbiz.mp3
                </p>
                <p>
                    Metallica_forWhomTheBellTolls.flac
                </p>
                <p>
                    04. ...Powdered Water Too (Part 1).mp3
                </p>
                <p>
                    Linkin Park - Numb.mp3
                </p>
                <p>
                    10. One Word Extinguisher.flac
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="334" valign="top">
                <p>
                    01. Ceca - Maskarada.mp3
                </p>
                <p>
                    04. ...Powdered Water Too (Part 1).mp3
                </p>
                <p>
                    10. One Word Extinguisher.flac
                </p>
                <p>
                    Kilo_dole_kilo_gore_superfreedotbiz.mp3
                </p>
            </td>
        </tr>
        <tr>
            <td width="334" valign="top">
                <p>
                    Britney
                </p>
                <p>
                    12 - The Messenger.mp3
                </p>
                <p>
                    01-Can't Knock The Hustle.mp3
                </p>
                <p>
                    09-99 Problems.mp3
                </p>
                <p>
                    Britney Spears - Toxic.mp3
                </p>
                <p>
                    03 - Axion.mp3
                </p>
                <p>
                    07 - Ultra Thizz.flac
                </p>
                <p>
                    Britney - Baby one more time.flac
                </p>
                <p>
                    03 - Surph.flac
                </p>
                <p>
                    02 - Breakbeat Malaria.mp3
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="334" valign="top">
                <p>
                    01-Can't Knock The Hustle.mp3
                </p>
                <p>
                    02 - Breakbeat Malaria.mp3
                </p>
                <p>
                    03 - Axion.mp3
                </p>
                <p>
                    03 - Surph.flac
                </p>
                <p>
                    07 - Ultra Thizz.flac
                </p>
                <p>
                    09-99 Problems.mp3
                </p>
                <p>
                    12 - The Messenger.mp3
                </p>
            </td>
        </tr>
        <tr>
            <td width="334" valign="top">
                <p>
                    -
                </p>
                <p>
                    02 - Guillotine.mp3
                </p>
                <p>
                    Death Grips - Takyon (Death Yon).mp3
                </p>
                <p>
                    03. Started From The Bottom.mp3
                </p>
                <p>
                    Tuscan_Leather_V0.mp3
                </p>
                <p>
                    10. Big Shots.mp3
                </p>
                <p>
                    11 - Void (Internal Theory).mp3
                </p>
                <p>
                    01. Jynweythek.flac
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="334" valign="top">
                <p>
                    01. Jynweythek.flac
                </p>
                <p>
                    03. Started From The Bottom.mp3
                </p>
                <p>
                    10. Big Shots.mp3
                </p>
                <p>
                    Tuscan_Leather_V0.mp3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · You can check if a string contains another string by using the
    string.Contains(str) method.
</p>
<h2>
    3. Equal Sum After Extraction
</h2>
<p>
You will be given <strong>two</strong> <strong>integer</strong>    <strong>lists</strong> on the first <strong>two lines</strong>
(space-separated). <strong>Remove</strong> the elements in the<strong>first list</strong> from the elements in the<strong>second list</strong>. If an element from the first list occurs<strong>more than once</strong> in the second list,    <strong>remove all occurrences</strong>.
</p>
<p>
    After you remove the elements, check the <strong>sum</strong> of both
    lists. If the sum of both of them is <strong>equal</strong>, print “Yes.
    Sum: {sum}”. If not print the <strong>absolute</strong> difference between
    the two lists in the format “No. Diff: {sum}”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="124" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="116" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="301" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="124" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    5 3 2 7 4 1 8
                </p>
            </td>
            <td width="116" valign="top">
                <p>
                    Yes. Sum: 15
                </p>
            </td>
            <td width="301" valign="top">
                <p>
                    first list: 1 2 3 4 5
                </p>
                <p>
                    second list: 5 3 2 7 4 1 8
                </p>
                <p>
                    elements to remove: 5 3 2 7 4 1 8
                </p>
                <p>
                    resulting list: 7 8
                </p>
                <p>
                    list1 sum: 1 + 2 + 3 + 4 + 5 = 15
                </p>
                <p>
                    list2 sum: 7 + 8 = 15
                </p>
                <p>
                    list1 sum == list2 sum è Equal sum
                </p>
            </td>
        </tr>
        <tr>
            <td width="124" valign="top">
                <p>
                    3 4 4 6 7
                </p>
                <p>
                    20 2 2
                </p>
            </td>
            <td width="116" valign="top">
                <p>
                    Yes. Sum: 24
                </p>
            </td>
            <td width="301" valign="top">
                <p>
                    no list1 elements present in list2 è no removal
                </p>
                <p>
                    list1 sum = 3 + 4 = 4 + 6 + 7 = 24
                </p>
                <p>
                    list2 sum = 20 + 2 + 2 = 24
                </p>
            </td>
        </tr>
        <tr>
            <td width="124" valign="top">
                <p>
                    8 7 9 8 7
                </p>
                <p>
                    1 2 3 8 4
                </p>
            </td>
            <td width="116" valign="top">
                <p>
                    No. Diff: 29
                </p>
            </td>
            <td width="301" valign="top">
                <p>
                    elements to remove: 1 2 3 8 4
                </p>
                <p>
                    list1 sum = 8 + 7 + 9 + 8 + 7 = 39
                </p>
                <p>
                    list2 sum = 1 + 2 + 3 + 4 = 10
                </p>
                <p>
                    list1 sum != list2 sum è Diff: 39 - 10 = 29
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Flip List Sides
</h2>
<p>
    You will receive an integer list on the first line of the input
    (space-separated). Leave the first, middle and last elements as they are.
For every other element, <strong>exchange</strong> it with its    <strong>opposite indexed element</strong> (list[1] è list[length-2] and so
    on…). After that, print the list on the console (space-separated).
</p>
<div align="center">
    <table border="0" cellspacing="0" cellpadding="0" width="0">
        <tbody>
            <tr>
                <td width="316">
                </td>
                <td width="30">
                    <p>
                        è
                    </p>
                </td>
                <td width="351">
                </td>
            </tr>
        </tbody>
    </table>
</div>
<p>
    <em>
        Note: If the list has an even number of elements, as there is no middle
        element, <strong>flip</strong> all the elements <strong>except</strong>
        for the <strong>first</strong> and <strong>last</strong> ones.
    </em>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="229" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="229" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="229" valign="top">
                <p>
                    1 2 3 4 5 6 7 8 9 10 11
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    1 10 9 8 7 6 5 4 3 2 11
                </p>
            </td>
        </tr>
        <tr>
            <td width="229" valign="top">
                <p>
                    2 3 4 1
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    2 4 3 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="229" valign="top">
                <p>
                    12 88 9 7 7623 84 2 1 8 97
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    12 8 1 2 84 7623 7 9 88 97
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. * Tear List in Half
</h2>
<p>
You will receive a list of <strong>integers</strong> on the    <strong>first</strong> input line (space-separated). Your task is to
    separate the list into <strong>two</strong> parts and perform the following
    operations:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="474" valign="top">
                <p>
                    Assume you have the following initial list:
                </p>
            </td>
        </tr>
        <tr>
            <td width="474" valign="top">
            </td>
        </tr>
        <tr>
            <td width="474" valign="top">
                <p>
                    Split the list into <strong>2 equal parts </strong>and
stack the <strong>right half</strong> on top of the                    <strong>left half</strong>:
                </p>
            </td>
        </tr>
        <tr>
            <td width="474" valign="top">
            </td>
        </tr>
        <tr>
            <td width="474" valign="top">
                <p>
                    Place <strong>each digit</strong> of the upper list
                    elements on <strong>either side</strong> of the lower list:
                </p>
            </td>
        </tr>
        <tr>
            <td width="474" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    After you perform the operations, print the resulting list on the console.
</p>
<h3>
    Constraints
</h3>
<p>
The count of the input list elements will <strong>always</strong> be<strong>even</strong> and the elements will always be    <strong>between 10 and 99</strong>.
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
            <td width="350" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    11 22 33 45 14 12
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    4 11 5 1 22 4 1 33 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    82 77 12 84 92 11
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    8 82 4 9 77 2 1 12 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    11 12 13 14 15 16 17 18
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    1 11 5 1 12 6 1 13 7 1 14 8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · There is a certain arithmetic progression which can help you solve this
    problem:<em></em>
</p>
<p>
    o Simulate the
    <em>
        splitting list -&gt; splitting numbers into digits -&gt; inserting to
        the left and right of the element
    </em>
    action several times and pay attention to the indices you are inserting the
    numbers into. <em></em>
</p>
<p>
o Do this several times and you will find the progression by yourself.    <em></em>
</p>
<p>
    o It is the key to seeing at which index you need to insert the elements
    each time and it works no matter how many elements the list has as long as
    you follow it.<em></em>
</p>
<h2>
    6. * Stuck Zipper
</h2>
<p>
    You will be given <strong>two</strong> lists of <strong>integers</strong>
    on the first and second line of the input respectively (space-separated).
We want to <strong>zip</strong> these two lists together like a    <strong>zipper</strong>, but <strong>one or several</strong> of the
elements in <strong>either</strong> of the lists are<strong>too large</strong> to allow that to happen. Being larger, they have    <strong>more digits</strong> than the element with the smallest amount of
    digits in the two lists.
</p>
<p>
    Your task is to find any elements which have <strong>more digits</strong>
than the element with the least amount of digits in the list (<strong>if such exist</strong>) and <strong>remove</strong> them, then    <strong>zip</strong> the lists together as shown in the example.
</p>
<p>
    After you stack the lists, <strong>print</strong> the resulting list on the
    console (one line, space-separated).
</p>
<p>
    Ideal example (no bad elements):
</p>
<p>
    The initial lists:
</p>
<p>
    Separate the elements to prepare for zipping:
</p>
<p>
    Zip the list:
</p>
<p>
    Stuck zipper example:
</p>
<p>
    The initial lists:
</p>
<p>
    Remove the elements with <strong>more digits</strong> than the element with
    the <strong>smallest amount</strong> <strong>of digits</strong> in both of
the lists. In this case, we have to remove anything with more than    <strong>1</strong> digit:
</p>
<p>
    Lists after removal:
</p>
<p>
    Separate the elements to prepare for zipping:
</p>
<p>
    Finally, we zip the list:
</p>
<h3>
    Constraints
</h3>
<p>
    The integers in both of the lists will always be in the range [1…1000000]
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="213" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="210" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="270" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="213" valign="top">
                <p>
                    2 4 4 3 9
                </p>
                <p>
                    4 1 3 2 7
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    4 2 1 4 3 4 2 3 7 9
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Nothing to remove – just zip the lists.
                </p>
                <p>
                    Insert list1[0] into list2 at index 1,
                </p>
                <p>
                    list1[1] into list2 at index 3,
                </p>
                <p>
                    list1[2] into list2 at index 5, etc...
                </p>
            </td>
        </tr>
        <tr>
            <td width="213" valign="top">
                <p>
                    2 12 4 3 9
                </p>
                <p>
                    22 1 3 88 7
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    1 2 3 4 7 3 9
                </p>
            </td>
            <td width="270" valign="top">
                <p>
We find any elements which have more than                    <strong>1 digits</strong> in both lists. We then zip the
                    two lists like so:
                </p>
                <p>
                    Insert list1[0] into list2 at index 1,
                </p>
                <p>
                    list1[1] into list2 at index 3,
                </p>
                <p>
                    list1[2] into list2 at index 5, etc...
                </p>
            </td>
        </tr>
        <tr>
            <td width="213" valign="top">
                <p>
                    -156 9128 7223 -938 -923
                </p>
                <p>
                    -918 22282 -848 98127
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    -918 -156 -848 -938 -923
                </p>
            </td>
            <td width="270" valign="top">
                <p>
We find any elements which have more than                    <strong>3 digits</strong> and<strong> remove </strong>them.
                    We then zip the two lists.
                </p>
            </td>
        </tr>
        <tr>
            <td width="213" valign="top">
                <p>
                    81728 73234 89 9912
                </p>
                <p>
                    2 5379 -5 92348
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    2 -5
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Find elements which have more than <strong>1 digit</strong>
                    and <strong>remove</strong> them.
                </p>
                <p>
                    Since we have nothing to zip (first list is empty), we just
                    print what’s left.
                </p>
            </td>
        </tr>
    </tbody>
</table>