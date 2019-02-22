<h1 align="center">
    Exercises: Functional Programming
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-advanced">
        "CSharp Advanced" course @ Software University.
    </a>
</p>
<p>
    Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/199/">
        https://judge.softuni.bg/Contests/199/
    </a>
    .
</p>
<h2>
    Problem 1. Action Point
</h2>
<p>
    Write a program that reads a collection of <strong>strings</strong> from
the console and then <strong>prints</strong> them onto the<strong>console</strong>. Each name should be printed on a<strong>new</strong> <strong>line</strong>. Use    <strong>Action&lt;T&gt;</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    Pesho Gosho Adasha
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    Gosho
                </p>
                <p>
                    Adasha
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Knights of Honor
</h2>
<p>
Write a program that reads a collection of <strong>names</strong> as<strong>strings</strong> from the <strong>console</strong> then appends “    <strong>Sir</strong>” in front of every name and <strong>prints</strong> it
back onto the <strong>console</strong>. Use    <strong>Action&lt;T&gt;</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    Pesho Gosho Adasha StanleyRoyce
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Sir Pesho
                </p>
                <p>
                    Sir Gosho
                </p>
                <p>
                    Sir Adasha
                </p>
                <p>
                    Sir StanleyRoyce
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Custom Min Function
</h2>
<p>
    Write a simple program that reads from the <strong>console</strong> a set
of <strong>integers</strong> and <strong>prints</strong> back onto the<strong>console</strong> the <strong>smallest</strong><strong>number</strong> from the collection. Use    <strong>Func&lt;T, T&gt;</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    1 4 3 2 1 7 13
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. Find Evens or Odds
</h2>
<p>
    You are given a lower and an upper bound for a range of integer numbers.
    Then a command specifies if you need to list all even or odd numbers in the
    given range. Use <strong>Predicate&lt;T&gt;</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    1 10
                </p>
                <p>
                    odd
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    1 3 5 7 9
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    20 30
                </p>
                <p>
                    even
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    20 22 24 26 28 30
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. Applied Arithmetics
</h2>
<p>
    Write a program that executes some mathematical operations on a given
collection. On the <strong>first line</strong> you are given    <strong>a list of numbers</strong>. On the <strong>next lines</strong> you
are passed <strong>different commands</strong> that you need to    <strong>apply to all numbers</strong> in the list: "add" -&gt; add 1 to
    each number; "multiply" -&gt; multiply each number by 2; "subtract" -&gt;
    subtract 1 from each number; “print” -&gt; print the collection. The input
    will end with an "<strong>end</strong>" command. Use functions.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    add
                </p>
                <p>
                    add
                </p>
                <p>
                    print
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    3 4 5 6 7
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    5 10
                </p>
                <p>
                    multiply
                </p>
                <p>
                    subtract
                </p>
                <p>
                    print
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    9 19
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 6. Reverse and Exclude
</h2>
<p>
    Write a program that reverses a collection and removes elements that are
    divisible by a given integer <strong>n</strong>. Use predicates/functions.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    1 2 3 4 5 6
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    5 3 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    20 10 40 30 60 50
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    50 40 10 20
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Predicate for Names
</h2>
<p>
    Write a program that filters a list of names according to their length. On
    the first line you will be given integer <strong>n</strong> representing
    name length. On the second line you will be given some names as strings
    separated by space. Write a function that prints only the names whose
    length is <strong>less than or equal</strong> to <strong>n</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    4
                </p>
                <p>
                    Kurnelia Qnaki Geo Muk Ivan
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Geo
                </p>
                <p>
                    Muk
                </p>
                <p>
                    Ivan
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    4
                </p>
                <p>
                    Karaman Asen Kiril Yordan<strong></strong>
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Asen
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Custom Comparator
</h2>
<p>
    Write a custom comparator that sorts all even numbers before all odd ones
    in ascending order. Pass it to an Array.Sort() function and print the
    result. Use functions.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    1 2 3 4 5 6
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    2 4 6 1 3 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    -3 2
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    2 -3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. List of Predicates
</h2>
<p>
    Find all numbers in the range 1...N that are divisible by the numbers of a
given sequence. On the first line you will be given an integer    <strong>N</strong> – which is the end of the range. On the second line you
    will be given a sequence of integers which are the dividers. Use
    predicates/functions.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    10
                </p>
                <p>
                    1 1 1 2
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    2 4 6 8 10
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    100
                </p>
                <p>
                    2 5 10 20
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    20 40 60 80 100
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 10. Predicate Party!
</h2>
<p>
    Ivancho’s parents are on a vacation for the holidays and he is planning an
    epic party at home. Unfortunately, his organizational skills are next to
    non-existent so you are given the task to help him with the reservations.
</p>
<p>
On the <strong>first line</strong> you get a<strong>list with all the people</strong> that are coming. On the<strong>next lines</strong>, until you get the<strong>"Party!" command</strong>, you may be asked to<strong>double</strong> or <strong>remove</strong><strong>all the people</strong> that apply to given<strong> criteria</strong>. There are <strong>three different</strong><strong>criteria</strong>: 1. everyone that has his <strong>name</strong>    <strong>starting </strong>with a<strong> given string</strong>; 2. everyone
that has a <strong>name</strong> <strong>ending </strong>with a<strong> given string</strong>; 3. everyone that has a    <strong>name</strong> with a <strong>given length</strong>.
</p>
<p>
Finally <strong>print all the guests</strong> who are going to the party<strong>separated by</strong> “,<strong> </strong>” and then<strong>add the ending</strong> “are going to the party!”. If there are    <strong>no guests</strong> going to the party print “Nobody is going to the
    party!”. See the examples below:
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="257" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="343" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="257" valign="top">
                <p>
                    Pesho Misho Stefan
                </p>
                <p>
                    Remove StartsWith P
                </p>
                <p>
                    Double Length 5
                </p>
                <p>
                    Party!
                </p>
            </td>
            <td width="343" valign="top">
                <p>
                    Misho, Misho, Stefan are going to the party!
                </p>
            </td>
        </tr>
        <tr>
            <td width="257" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    Double StartsWith Pesh
                </p>
                <p>
                    Double EndsWith esho
                </p>
                <p>
                    Party!
                </p>
            </td>
            <td width="343" valign="top">
                <p>
                    Pesho, Pesho, Pesho, Pesho are going to the party!
                </p>
            </td>
        </tr>
        <tr>
            <td width="257" valign="top">
                <p>
                    Pesho
                </p>
                <p>
                    Remove StartsWith P
                </p>
                <p>
                    Party!
                </p>
            </td>
            <td width="343" valign="top">
                <p>
                    Nobody is going to the party!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 11. Party Reservation Filter Module
</h2>
<p>
    You need to implement a filtering module to a party reservation software.
First, to the Party Reservation Filter Module (PRFM for short) is<strong>passed a list</strong> with invitations. Next the PRFM receives a    <strong>sequence of commands</strong> that specify whether you need to add
    or remove a given filter.
</p>
<p>
Each PRFM command is in the given format    <strong>{command;filter type;filter parameter}</strong>
</p>
<p>
    You can receive the following PRFM commands: "<strong>Add filter</strong>",
    "<strong>Remove filter</strong>" or "<strong>Print</strong>". The possible
PRFM filter types are: "<strong>Starts with</strong>", "<strong>Ends with</strong>", "<strong>Length</strong>" and "    <strong>Contains</strong>". All PRFM filter parameters will be a string (or
    an integer only for the “<strong>Length”</strong> filter). Each command
    will be valid e.g. you won’t be asked to remove a non-existent filter.
</p>
<p>
    The input will <strong>end</strong> with a "<strong>Print</strong>" command
    after which you should print all the party-goers that are left after the
    filtration. See the examples below:
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="257" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="343" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="257" valign="top">
                <p>
                    Pesho Misho Slav
                </p>
                <p>
                    Add filter;Starts with;P
                </p>
                <p>
                    Add filter;Starts with;M
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="343" valign="top">
                <p>
                    Slav
                </p>
            </td>
        </tr>
        <tr>
            <td width="257" valign="top">
                <p>
                    Pesho Misho Jica
                </p>
                <p>
                    Add filter;Starts with;P
                </p>
                <p>
                    Add filter;Starts with;M
                </p>
                <p>
                    Remove filter;Starts with;M
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="343" valign="top">
                <p>
                    Misho Jica
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 12. Inferno III
</h2>
<p>
On the <strong>first line</strong> you are given<strong>a sequence of numbers</strong>. Each number is a gem and the    <strong>value</strong> represents its <strong>power</strong>. On the next
    lines, until you receive the "<strong>Forge</strong>" command, you will be
receiving commands in the following format:    <strong>{command;filter type;filter parameter}</strong>
</p>
<p>
    <strong>Commands</strong>
can be: "<strong>Exclude</strong>", "<strong>Reverse</strong>" or "<strong>Forge</strong>". The possible filter types are: "<strong>Sum Left</strong>", "<strong>Sum Right</strong>" and "<strong>Sum Left</strong> <strong>Right</strong>". All filter    <strong>parameters</strong> will be <strong>an integer</strong>.
</p>
<p>
    "<strong>Exclude</strong>" marks a gem for <strong>exclusion</strong> from
the set if it meets a <strong>given condition</strong>. "<strong>Reverse</strong>" <strong>deletes</strong> a previous    <strong>exclusion</strong>.
</p>
<p>
"<strong>Sum Left</strong>" tests if a gems <strong>power</strong><strong>added</strong> to the gem standing to <strong>its</strong><strong>left</strong> gives a <strong>certain value</strong>. "<strong>Sum Right</strong>" is the same but looks to a gems    <strong>right peer</strong>. "<strong>Sum Left Right</strong>" sums the
gems power with <strong>both</strong> its <strong>left</strong> and<strong>right</strong> neighbors. If a gem has    <strong>no neighbor </strong>to its right or to its left (first or last
    element), then simply <strong>add 0</strong> to the gem.
</p>
<p>
Note that <strong>changes</strong> to the sequence    <strong>are applied</strong> only <strong>after forging</strong>. This
means that the gems are fixed at their positions and    <strong>every function</strong> occurs on the <strong>original set</strong>
    , so every gems power is considered, no matter if it is marked to be
    excluded or not. To better understand the problem, see the examples below:
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="210" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="204" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="210" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="210" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    Exclude;Sum Left;1
                </p>
                <p>
                    Exclude;Sum Left Right;9
                </p>
                <p>
                    Forge
                </p>
            </td>
            <td width="204" valign="top">
                <p>
                    2 4
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    1. Marks for exclusion all gems for which the sum with
neighbors to their left equals 1, e.g. 0 +                    <strong>1</strong> = 1
                </p>
                <p>
                    2. Marks for exclusion all gems for which the sum with
                    neighbors to their left and their right equals 9, e.g.
                </p>
                <p>
                    2 + <strong>3</strong> + 4 = 9
                </p>
                <p>
                    4 + <strong>5</strong> + 0 = 9
                </p>
            </td>
        </tr>
        <tr>
            <td width="210" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    Exclude;Sum Left;1
                </p>
                <p>
                    Reverse;Sum Left;1
                </p>
                <p>
                    Forge
                </p>
            </td>
            <td width="204" valign="top">
                <p>
                    1 2 3 4 5
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    1. Marks for exclusion all gems for which the sum with
                    their gem peers to the left equals 1, e.g. 0 + 1 = 1
                </p>
                <p>
                    2. Reverses the previous exclusion.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 13. TriFunction
</h2>
<p>
Write a program that traverses a collection of names and returns the<strong>first name</strong> whose sum of characters is<strong>equal</strong> to or <strong>larger</strong> than a given number    <strong>N, </strong>which will be given on the first line. Use a function
    that <strong>accepts another function</strong> as one of its parameters.
    Start off by building a regular function to hold the basic logic of the
program. Something along the lines of    <strong>Func&lt;string, int, bool&gt;</strong>. Afterwards create your main
    function which should accept the first function as one of its parameters.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256" valign="top">
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
            <td width="256" valign="top">
                <p>
                    800
                </p>
                <p>
                    Qvor Qnaki Petromir Sadam
                </p>
            </td>
            <td width="270" valign="top">
                <p>
                    Petromir
                </p>
            </td>
        </tr>
    </tbody>
</table>