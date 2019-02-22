<h1>
    Lab: Array and List Algorithms
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
    <a href="https://judge.softuni.bg/Contests/426">
        https://judge.softuni.bg/Contests/426
    </a>
    .
</p>
<p>
    <strong>
        <em>
            Note: for this exercise, you are not allowed to use LINQ for the
            actual algorithms (parsing the input with LINQ is okay). The
            exercise is intended to help you flex your algorithmic thinking
            skills, and as such, please try to solve the problems
            algorithmically.
        </em>
    </strong>
</p>
<h2>
    1. Array Contains Element
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console
    and an integer <strong>N</strong> from the second line of the console and
    print whether the element is <strong>contained </strong>in the array. If it
    is, print “yes”, otherwise print “no”.
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
            <td width="92" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="92">
                <p>
                    yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    8 7 7 9 6 2 2
                </p>
                <p>
                    11
                </p>
            </td>
            <td width="92">
                <p>
                    no
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    99 7 8 6 2314 2
                </p>
                <p>
                    2314
                </p>
            </td>
            <td width="92">
                <p>
                    yes
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Read a text line from the console, split it by space, parse the obtained
    items as integers and convert them to array of integers.
</p>
<p>
    · Scan through the whole array, element by element, until you either find
    the element, or reach the end of the array.
</p>
<p>
    · Keep the result of the operation in a Boolean variable such as “isFound”.
</p>
<p>
    · Finally, if the element is found (checking by the variable), print “yes”
    or “no”.
</p>
<h2>
    2. Smallest Element in Array
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
After that, <strong>find </strong>the smallest element in the array and    <strong>print </strong>it on the console.
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
            <td width="92" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    1 2 3 4 5
                </p>
            </td>
            <td width="92">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    9 8 7 82 78 13
                </p>
            </td>
            <td width="92">
                <p>
                    7
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    78 77 1268 43 9
                </p>
            </td>
            <td width="92">
                <p>
                    9
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Read a text line from the console, split it by space, parse the obtained
    items as integers and convert them to array of integers.
</p>
<p>
· Traverse the whole array, element by element, putting the    <strong>smallest integer</strong> up to that point into an integer variable
    called “smallestInt”. Finally, print smallestInt.
</p>
<h2>
    3. Reverse Array In-place
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
    After that, <strong>reverse </strong>the array in-place (as in, don’t
    create a new collection to hold the result, reverse it using only the
    original array). After you are done, <strong>print</strong> the reversed
    array on the console.
</p>
<p>
    Note: You are <strong>not</strong> allowed to iterate over the list
    backwards and just print it,
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
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    1 2 3 4 5
                </p>
            </td>
            <td width="140">
                <p>
                    5 4 3 2 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    1 4 2 7 6 1 1
                </p>
            </td>
            <td width="140">
                <p>
                    1 1 6 7 2 4 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 52 43 12 1 6
                </p>
            </td>
            <td width="140">
                <p>
                    6 1 12 43 52 11
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
        Iterate over <strong>half</strong> of the array (0…length / 2) and swap
        each element with its opposite index like so:
    </li>
</ul>
<p>
    o Index 0 gets swapped with length - 1
</p>
<p>
    o Index 1 gets swapped with length - 2,
</p>
<p>
    o Index 2 gets swapped with length - 3,
</p>
<p>
    o and so on…
</p>
<ul>
    <li>
        When you reach the <strong>middle</strong> of the array, it means you
        are done swapping elements and are ready to print them.
    </li>
</ul>
<h2>
    4. Sort Array Using Bubble Sort
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
After that, <strong>sort </strong>the array, using the    <a href="https://visualgo.net/sorting"><strong>Bubble Sort</strong></a>
    algorithm.
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
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    5 3 4 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 3 4 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 872 673 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 11 673 872
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 52 43 12 1 6
                </p>
            </td>
            <td width="140">
                <p>
                    1 6 11 12 43 52
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Sort Array Using Insertion Sort
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
After that, <strong>sort </strong>the array, using the    <a href="https://visualgo.net/sorting"><strong>Insertion Sort</strong></a>
    algorithm.
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
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    5 3 4 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 3 4 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 872 673 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 11 673 872
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 52 43 12 1 6
                </p>
            </td>
            <td width="140">
                <p>
                    1 6 11 12 43 52
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Insertion Sort Using List
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
After that, <strong>sort </strong>the array, using the    <a href="https://visualgo.net/sorting"><strong>Insertion Sort</strong></a>
algorithm, but instead of doing it in-place, add the result    <strong>one by one</strong> to a <strong>list</strong>.
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
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    5 3 4 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 3 4 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 872 673 1 2
                </p>
            </td>
            <td width="140">
                <p>
                    1 2 11 673 872
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 52 43 12 1 6
                </p>
            </td>
            <td width="140">
                <p>
                    1 6 11 12 43 52
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Largest N Elements
</h2>
<p>
    Read a <strong>list of integers</strong> on the first line of the console.
    On the next line, you will receive an <strong>integer N</strong>. After
that, find and <strong>print</strong> the <strong>largest N</strong><strong>elements </strong>the array, sorted in    <strong>descending order</strong>.
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
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    5 3 4 1 2
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="140">
                <p>
                    5 4 3
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 872 673 1 2
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="140">
                <p>
                    872 673
                </p>
            </td>
        </tr>
        <tr>
            <td width="148">
                <p>
                    11 52 43 12 1 6
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="140">
                <p>
                    52 43 12 11
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
        A possible solution to this problem is:
    </li>
</ul>
<p>
    o Sort the array in <strong>descending order</strong>, using a sorting
    algorithm such as <strong>Insertion Sort</strong>,
</p>
<p>
    o Extract the first <strong>N elements</strong> from it
</p>