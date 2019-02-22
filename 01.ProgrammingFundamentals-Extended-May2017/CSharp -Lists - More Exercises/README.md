<h1>
    More Exercises: Lists
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
    <a href="https://judge.softuni.bg/Contests/425">
        https://judge.softuni.bg/Contests/425
    </a>
    .
</p>
<h2>
    1. Distinct List
</h2>
<p>
You will be given a list of <strong>integers</strong> on the<strong>first line</strong> of the input (space-separated).    <strong>Remove</strong> all <strong>repeating elements</strong> from the
    list.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="165" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="124" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="340" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    1 2 3 4
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    1 2 3 4
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    No repeating elements
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    7 8 9 7 2 3 4 1 2
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    7 8 9 2 3 4 1
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    7 and 2 are already present in the list èremove them
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    20 8 12 13 4 4 8 5
                </p>
            </td>
            <td width="124" valign="top">
                <p>
                    20 8 12 13 4 5
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    4 and 8 are already present in the list èremove them
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Integer Insertion
</h2>
<p>
    You will receive a list of <strong>integers</strong> on the same line
    (separated by <strong>one </strong>space). On the next lines, you will
    start receiving a list of <strong>strings</strong>, until you receive the
string “end”. Your task is to insert each string (    <strong>converted</strong> to integer) at a specific index in the list. The
index is determined by the <strong>first digit</strong> of the    <strong>number</strong>.
</p>
<p>
Example: 514 è first digit – 5 è insert 514 at the    <strong>5<sup>th</sup></strong> index of the list.
</p>
<p>
    After you insert all the elements, print the list, separated by single
    spaces.
</p>
<p>
    <em>
        The input will <strong>always</strong> be valid and you don’t need to
        explicitly check if you’re inserting an element into a valid index.
    </em>
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
            <td width="350" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    1 2 3 4 5 6 7 8 9
                </p>
                <p>
                    25
                </p>
                <p>
                    716
                </p>
                <p>
                    2772
                </p>
                <p>
                    1982
                </p>
                <p>
                    8534
                </p>
                <p>
                    2
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    1 1982 2 2 2772 25 3 4 5 8534 6 716 7 8 9
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    3 12 66 243 8766
                </p>
                <p>
                    12
                </p>
                <p>
                    33
                </p>
                <p>
                    56
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    3 12 12 33 66 56 243 8766
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    9 9 9 9 9 9 9 9 9 9
                </p>
                <p>
                    9
                </p>
                <p>
                    9
                </p>
                <p>
                    9
                </p>
                <p>
                    9
                </p>
                <p>
                    9
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="350" valign="top">
                <p>
                    9 9 9 9 9 9 9 9 9 9 9 9 9 9 9
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Camel’s Back
</h2>
<p>
The city is breaking down on a camel back. You will receive a sequence of    <strong>N</strong> <strong>integers</strong>, (space-separated), which will
    represent the <strong>buildings</strong> in the city. You will then receive
an integer <strong>M</strong>, indicating the camel back's    <strong>size</strong>.
</p>
<p>
The camel back is a <strong>linear structure</strong> standing<strong>below</strong> the city, in such a way that it has an<strong>equal amount</strong> of buildings to its <strong>left</strong> and    <strong>right</strong>. The idea is, if every round – <strong>one</strong>
    building falls from the <strong>left</strong> <strong>side</strong> of the
    city, and <strong>one</strong> from the <strong>right side</strong>, how
    many <strong>rounds</strong> will it take for the city to stop breaking
    down?
</p>
<p>
    As output you must print how many rounds it took before the city stopped
    breaking down as “{rounds} rounds”. On the next line, print what’s left of
    the city (space-separated). Format: “remaining: {buildings
    (space-separated)}”
</p>
<p>
    If no buildings have fallen, print “already stable: {buildings
    (space-separated)}”
</p>
<p>
Example: city with <strong>9 elements</strong>; Camel back size:    <strong>5</strong>
</p>
<p>
    Round 1: first and last elements fall off:
</p>
<p>
    Round 2: first and last elements fall off:
</p>
<p>
    Remaining list:
</p>
<h3>
    Constraints
</h3>
<p>
    <strong>N</strong>
    and <strong>M</strong> will always be <strong>odd</strong> numbers.
[1-1000] and <strong>M</strong> will always be    <strong>smaller or equal</strong> to <strong>N</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="253" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="253" valign="top">
                <p>
                    12 45 61 34 21 345 62 11 94
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="221" valign="top">
                <p>
                    2 rounds
                </p>
                <p>
                    remaining: 61 34 21 345 62
                </p>
            </td>
        </tr>
        <tr>
            <td width="253" valign="top">
                <p>
                    9 8 7 8 2
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="221" valign="top">
                <p>
                    already stable: 9 8 7 8 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="253" valign="top">
                <p>
                    8 7 8 1 2 3 8 7 2 44 3 212 11
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="221" valign="top">
                <p>
                    4 rounds
                </p>
                <p>
                    remaining: 2 3 8 7 2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Ununion Lists
</h2>
<p>
You will be given a sequence of integers, separated by a space. This is the<strong>primal list</strong>. Then you will receive an    <strong>integer N</strong>. On the next <strong>N lines</strong>, you will
    receive sequences of integers. Your task is to add all elements that the
primal list <strong>does not</strong> contain from the    <strong>current sequence</strong> to the <strong>primal list</strong> and
then <strong>remove</strong> from the primal list, all elements which    <strong>are</strong> contained in the current sequence of integers. If
    there are several occurrences, remove <strong>all</strong> occurrences you
    find.
</p>
<p>
After you are done receiving lists and manipulating the primal list,    <strong>sort</strong> the primal list and <strong>print </strong>it.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="157" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="294" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    3
                </p>
                <p>
                    3 4 5 20 1
                </p>
                <p>
                    16 2 1
                </p>
                <p>
                    14
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    1 14 16 20
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Key:
                </p>
                <p>
                    è remove from primal list
                </p>
                <p>
                    è add to primal list
                </p>
                <p>
                    Primal: 1 2 3 4 5
                </p>
                <p>
                    List 1: 3 4 5 20 1
                </p>
                <p>
                    Primal after List 1: 2 20
                </p>
                <p>
                    List 2: 16 2 1
                </p>
                <p>
                    Primal after List 2: 20 16 1
                </p>
                <p>
                    List 3: 14
                </p>
                <p>
                    Primal after List 3: 20 16 1 14
                </p>
                <p>
                    Sorted primal list: 1 14 16 20
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    3 3 4 5 18 20
                </p>
                <p>
                    2
                </p>
                <p>
                    1 2 3
                </p>
                <p>
                    18 20
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    1 2 4 5
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Primal: 3 3 4 5 18 20
                </p>
                <p>
                    List 1: 1 2 3
                </p>
                <p>
                    Primal after List 1: 4 5 18 20 1 2
                </p>
                <p>
                    List 2: 18 20
                </p>
                <p>
                    Primal after List 2: 4 5 1 2
                </p>
                <p>
                    Sorted primal list: 1 2 4 5
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    99 88 77 99 66 55
                </p>
                <p>
                    5
                </p>
                <p>
                    99
                </p>
                <p>
                    88
                </p>
                <p>
                    77
                </p>
                <p>
                    66
                </p>
                <p>
                    14 11 12 13 55
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    11 12 13 14
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Primal: 99 88 77 99 66 55
                </p>
                <p>
                    List 1: 99
                </p>
                <p>
                    Primal after List 1: 88 77 66 55
                </p>
                <p>
                    List 2: 88
                </p>
                <p>
                    Primal after List 2: 77 66 55
                </p>
                <p>
                    List 3: 77
                </p>
                <p>
                    Primal after List 3: 66 55
                </p>
                <p>
                    List 4: 66
                </p>
                <p>
                    Primal after List 4: 55
                </p>
                <p>
                    List 5: 14 11 12 13 55
                </p>
                <p>
                    Primal after List 5: 14 11 12 13
                </p>
                <p>
                    Sorted primal list: 11 12 13 14
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. * Note Statistics
</h2>
<p>
    In music, certain frequencies correspond to certain musical notes (example:
    A -&gt; 440hz, C# -&gt; 554.37hz).
</p>
<p>
    You will be given frequencies as <strong>real numbers</strong> on the first
line of the input (space-separated). Your task is to<strong>convert</strong> the numbers to their<strong>musical note representation</strong>, then    <strong>separate</strong> them into <strong>naturals</strong> (C, B, F and
    etc.) and <strong>sharp</strong> notes (C#, F#, A#, etc.). After that,
    print both lists in the console in the format described in the examples.
After you print them, <strong>sum</strong> each list’s frequencies and    <strong>print</strong> it on the console, rounded to the second decimal
    place.
</p>
<h3>
    Constraints
</h3>
<p>
    The frequencies in the input will be constrained to this chart:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="41" valign="top">
                <p align="center">
                    <strong>Note</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Frequency</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    C
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    261.63hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    C#
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    277.18hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    D
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    293.66hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    D#
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    311.13hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    E
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    329.63hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    F
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    349.23hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    F#
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    369.99hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    G
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    392.00hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    G#
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    415.30hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    A
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    440.00hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    A#
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    466.16hz
                </p>
            </td>
        </tr>
        <tr>
            <td width="41" valign="top">
                <p>
                    B
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    493.88hz
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="423" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="423" valign="top">
                <p>
                    293.66 311.13 293.66 311.13 349.23 349.23
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Notes: D D# D D# F F
                </p>
                <p>
                    Naturals: D, D, F, F
                </p>
                <p>
                    Sharps: D#, D#
                </p>
                <p>
                    Naturals sum: 1285.78
                </p>
                <p>
                    Sharps sum: 622.26
                </p>
            </td>
        </tr>
        <tr>
            <td width="423" valign="top">
                <p>
                    329.63 329.63 329.63 261.63 329.63 392.0
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Notes: E E E C E G
                </p>
                <p>
                    Naturals: E, E, E, C, E, G
                </p>
                <p>
                    Sharps:
                </p>
                <p>
                    Naturals sum: 1972.15
                </p>
                <p>
                    Sharps sum: 0
                </p>
            </td>
        </tr>
        <tr>
            <td width="423" valign="top">
                <p>
                    392.0 440.0 349.23 392.0 466.16 440.0 349.23 392.0
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Notes: G A F G A# A F G
                </p>
                <p>
                    Naturals: G, A, F, G, A, F, G
                </p>
                <p>
                    Sharps: A#
                </p>
                <p>
                    Naturals sum: 2754.46
                </p>
                <p>
                    Sharps sum: 466.16
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <em>Bonus: you can feed the list of frequencies into </em>
    <em>Console.Beep(freq, duration)</em>
    <em> to hear the tests </em>
    J<em></em>
</p>
<h2>
    6. * Winecraft
</h2>
<p>
    You will be given a sequence of integers, which will represent grapes. On
the next line, you will be given <strong>N </strong>- an    <strong>integer</strong>, indicating the <strong>growth days</strong>. You
    must increment every integer in the list by 1 <strong>N times</strong>.
However, if one of the grapes’ <strong>value</strong> is<strong>greater</strong> than the grape to its <strong>left</strong> and is<strong>also</strong> <strong>greater</strong> than the one to his    <strong>right</strong>, it becomes <strong>Greater grape</strong>.
</p>
<p>
    <strong>The Greater grape </strong>
steals the values, which would have been incremented to its    <strong>neighbors</strong>, and adds them to itself, instead of being
    incremented by <strong>1</strong> like <strong>normal</strong>. On top of
    that the grapes, which are <strong>neighbors</strong> of the Greater grape
are decremented by <strong>1</strong> (note: if any of the<strong>greater grapes’</strong> neighboring grapes have a value of<strong>0</strong>, <strong>DON’T</strong> decrement it and<strong>DON’T</strong> add its <strong>value</strong> to the    <strong>greater grape</strong>).
</p>
<p>
    <strong>Example</strong>
    : If we the list <strong>1 12 4</strong>. The element at position 1 is
greater grape, because it is <strong>bigger</strong> than the<strong>elements</strong> on the <strong>left</strong> and on the    <strong>right</strong>:
</p>
<ul>
    <li>
        <strong>First</strong>
iteration: The <strong>Greater</strong> grape increases with<strong>1</strong> by default and takes <strong>2</strong> from its<strong>neighbors</strong>. The new list look like:        <strong>0 15 3</strong>
    </li>
    <li>
        <strong>Second</strong>
iteration: The <strong>Greater</strong> grape increases with<strong>1</strong> by <strong>default</strong> and takes<strong>only</strong> <strong>1</strong> from its<strong>neighbors</strong>. This is because the grape on<strong>left</strong> is <strong>0</strong> and the<strong>Greater</strong> <strong>grape</strong> takes only from the<strong>left</strong> one. The list now looks like this:        <strong>0 16 2</strong>
    </li>
</ul>
<p>
Lesser grapes <strong>don’t</strong> get <strong>incremented </strong>when<strong> </strong>they<strong> have </strong>as    <strong> neighbor Greater grape </strong>, but instead they have their
values <strong>decremented</strong> by <strong>1</strong> by their    <strong>neighboring</strong> <strong>Greater grapes</strong> (if there are
    such), therefore their <strong>values</strong> get <strong>added</strong>
    to the Greater grapes.
</p>
<p>
After you're done with the <strong>growing</strong> (processed the grapes<strong>N</strong> times), every grape which has a <strong>value</strong>,<strong>lower</strong> than <strong>N</strong> should be<strong>set to a value of 0 and </strong>you should    <strong> not increment </strong>them or<strong> steal values </strong>from
    them.
</p>
<p>
The process should then repeat, again incrementing everything    <strong>N</strong> times, where the <strong>Greater grapes </strong>steal
from the <strong>lesser grapes</strong>, until your list contains<strong>less</strong> than <strong>N</strong> grapes with    <strong>value</strong> <strong>more</strong> than <strong>N</strong>.
</p>
<p>
After that, print the <strong>remaining</strong> grapes on the console (<strong>one</strong> <strong>line</strong>,    <strong>space-separated</strong>).
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="157" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="390" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    4 4 15 4
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    7 24
                </p>
            </td>
            <td width="390" valign="top">
                <p>
                    Key:
                </p>
                <p>
                    è normal grapes
                </p>
                <p>
                    è lesser grapes
                </p>
                <p>
                    è greater grapes
                </p>
                <p>
                    Round 1: 5 3 18 3
                </p>
                <p>
                    Round 2: 6 2 21 2
                </p>
                <p>
                    Round 3: 7 1 24 1
                </p>
                <p>
                    Remove grapes less or equal to 3 è 1 and 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    10 11 12 13 19 13
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    20 35 44
                </p>
            </td>
            <td width="390" valign="top">
                <p>
                    Round 1: 11 12 13 12 22 12
                </p>
                <p>
                    Round 2: 12 11 16 10 25 11
                </p>
                <p>
                    Round 3: 13 10 19 8 28 10
                </p>
                <p>
                    Round 4: 14 9 22 6 31 9
                </p>
                <p>
                    Round 5: 15 8 25 4 34 8
                </p>
                <p>
                    Remove grapes less or equal to 5 è 4
                </p>
                <p>
                    Round 1: 16 7 27 0 36 7
                </p>
                <p>
                    Round 2: 17 6 29 0 38 6
                </p>
                <p>
                    Round 3: 18 5 31 0 40 5
                </p>
                <p>
                    Round 4: 19 3 33 0 42 4
                </p>
                <p>
                    Round 5: 20 3 35 0 44 3
                </p>
                <p>
                    Remove grapes less or equal to 5 è 3 and 3
                </p>
            </td>
        </tr>
        <tr>
            <td width="157" valign="top">
                <p>
                    6 7 6 2
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    16 5
                </p>
            </td>
            <td width="390" valign="top">
                <p>
                    Round 1: 5 10 5 3
                </p>
                <p>
                    Round 2: 4 13 4 4
                </p>
                <p>
                    Round 3: 3 16 3 5
                </p>
                <p>
                    Remove grapes less or equal to 3 è 3 and 3
                </p>
            </td>
        </tr>
    </tbody>
</table>