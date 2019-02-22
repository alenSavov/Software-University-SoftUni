<h1 align="center">
    Exercises: Matrices
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/csharp-advanced">
        "CSharp Advanced" course @ Software University
    </a>
    . Please submit your solutions (source code) of all below described
    problems in <a href="https://judge.softuni.bg/Contests/573">Judge</a>.
</p>
<h2>
    Problem 1. Matrix of Palindromes
</h2>
<p>
Write a program to generate and print the following<strong>matrix of palindromes </strong>of <strong>3 </strong>letters with    <strong>r </strong>rows and <strong>c </strong>columns like at the examples
    below.
</p>
<ul>
    <li>
        <strong>Rows</strong>
        define the first and the last letter: row 0 à ‘a’, row 1 à ‘b’, row 2 à
        ‘c’, …
    </li>
    <li>
        <strong>Columns + rows</strong>
        define the middle letter:
    </li>
</ul>
<p>
    o column 0, row 0 à ‘a’, column 1, row 0 à ‘b’, column 2, row 0 à ‘c’, …
</p>
<p>
    o column 0, row 1 à ‘b’, column 1, row 1 à ‘c’, column 2, row 1 à ‘d’, …
</p>
<h3>
    Input
</h3>
<ul>
    <li>
On the <strong>first line</strong>, you are given the integers        <strong>r</strong> and <strong>c</strong>, separated by a space.
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
        On <strong>r</strong> *<strong>c</strong> number of lines, print the
        matrix of palindromes as shown in the example.
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
        Constraints: r and c are integers in the range [1…26]; r + c ≤ 27.
    </li>
</ul>
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
            <td width="205" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="26" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
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
            <td width="51">
                <p>
                    4 6
                </p>
            </td>
            <td width="205">
                <p>
                    aaa aba aca ada aea afa
                </p>
                <p>
                    bbb bcb bdb beb bfb bgb
                </p>
                <p>
                    ccc cdc cec cfc cgc chc
                </p>
                <p>
                    ddd ded dfd dgd dhd did
                </p>
            </td>
            <td width="51">
                <p>
                    3 2
                </p>
            </td>
            <td width="76">
                <p>
                    aaa aba
                </p>
                <p>
                    bbb bcb
                </p>
                <p>
                    ccc cdc
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
        char[] alphabet = "<strong>abcdefghijklmnopqrstuvwxyz</strong>
        ".ToCharArray();
    </li>
</ul>
<h2>
    Problem 2. Diagonal Difference
</h2>
<p>
Write a program that finds the    <strong>difference between the sums of the square matrix diagonals</strong>
    (absolute value).
</p>
<h3>
    Input
</h3>
<ul>
    <li>
On the <strong>first line</strong>, you are given the integer        <strong>N</strong> – the size of the square matrix
    </li>
    <li>
The next N<strong> lines</strong> holds the values for        <strong> every row</strong> – N numbers separated by a space
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
Print <strong>the absolute </strong>difference between        <strong>the sums</strong> of the primary and the secondary diagonal
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="83" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="272" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="83" valign="top">
                <p>
                    3
                </p>
                <p>
                    11 2 4
                </p>
                <p>
                    4 5 6
                </p>
                <p>
                    10 8 -12<strong></strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    15
                </p>
            </td>
            <td width="272" valign="top">
                <p>
                    <strong>Primary diagonal:</strong>
                    sum = 11 + 5 + (-12) = 4
                </p>
                <p>
                    <strong>Secondary diagonal:</strong>
                    sum = 4 + 5 + 10 = 19
                </p>
                <p>
                    <strong>Difference:</strong>
                    |4 - 19| = 15
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. 2x2 Squares in Matrix
</h2>
<p>
    Find the count of <strong>2 x 2 squares of equal chars</strong> in a
    matrix.
</p>
<h3>
    Input
</h3>
<ul>
    <li>
On the <strong>first line</strong>, you are given the integers        <strong>rows</strong> and <strong>cols – </strong>the matrix’s
        dimensions
    </li>
    <li>
        Matrix characters come at the next <strong>rows</strong> lines (space
        separated)
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    · Print the number of all the squares matrixes you have found
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
            <td width="60" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="233" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76">
                <p>
                    3 4
                </p>
                <p>
                    A B B D
                </p>
                <p>
                    E B B B
                </p>
                <p>
                    I J B B
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="233" valign="top">
                <p>
                    Two 2 x 2 squares of equal cells:
                </p>
                <p>
                    A <strong>B B</strong> D A B B D
                </p>
                <p>
                    E <strong>B B</strong> B E B <strong>B B</strong>
                </p>
                <p>
                    I J B B I J <strong>B B</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="76">
                <p>
                    2 2
                </p>
                <p>
                    a b
                </p>
                <p>
                    c d
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    0
                </p>
            </td>
            <td width="233" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">
                        No 2 x 2 squares of equal cells exist.
                    </a>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. Maximal Sum
</h2>
<p>
Write a program that reads a rectangular integer matrix of size    <strong>N x M</strong> and finds in it the square <strong>3 x 3</strong>
    that <strong>has maximal sum of its elements</strong>.
</p>
<h3>
    Input
</h3>
<p>
    · On the first line, you will receive the rows <strong>N</strong> and
    columns <strong>M</strong>. On the next <strong>N lines</strong> you will
    receive <strong>each row with its columns</strong>
</p>
<h3>
    Output
</h3>
<ul>
    <li>
        Print the <strong>elements</strong> of the 3 x 3 square as a matrix,
        along with their <strong>sum</strong>
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="138">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="222">
                <p align="center">
                    <strong>Matrix</strong>
                </p>
            </td>
            <td width="108">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="138" valign="top">
                <p>
                    4 5
                </p>
                <p>
                    1 5 5 2 4
                </p>
                <p>
                    2 1 4 14 3
                </p>
                <p>
                    3 7 11 2 8
                </p>
                <p>
                    4 8 12 16 4
                </p>
            </td>
            <td width="222" valign="top">
            </td>
            <td width="108" valign="top">
                <p>
                    Sum = 75
                </p>
                <p>
                    1 4 14
                </p>
                <p>
                    7 11 2
                </p>
                <p>
                    8 12 16
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. Rubik’s Matrix
</h2>
<p>
    Rubik’s cube – everyone’s favorite head-scratcher. Writing a program to
    solve it will be quite a difficult task for an exam, though. Instead, we
    have a Rubik’s matrix prepared for you. You will be given a pair of
    dimensions: <strong>R</strong> and <strong>C. </strong>To prepare the
    matrix, fill each row with increasing integers, starting from one. For
    example, <strong>2 x 4</strong> matrix must look like this:
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left">
    <tbody>
        <tr>
            <td width="28" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="28" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Next, you will receive series of commands, indicating which row or column
you must move, in which direction, and how many times. For example,    <strong>1 up 1</strong> means: column 1, direction: up, 1 move. After
    executing it, the matrix should look like:
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left">
    <tbody>
        <tr>
            <td width="28" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    6
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    3
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    4
                </p>
            </td>
        </tr>
        <tr>
            <td width="28" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="28" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Directions <strong>left</strong> and <strong>right</strong> means you must
move the corresponding <strong>row</strong>, while <strong>up</strong> and    <strong>down</strong> are related to the <strong>columns. </strong>After
    shuffling the Rubik’s matrix, you have to <strong>rearrange</strong> it
(meaning that the <strong>values in each cell</strong> should be in    <strong>increasing order</strong>, such as the ones in the original
    matrix). The rearranging process should start at <strong>top-left</strong>
and end at <strong>bottom-right</strong>. Find the<strong>position</strong> of the value you need, and print the    <strong>swap</strong> <strong>command</strong> on the console, in the
    format described below.
</p>
<h3>
    Input
</h3>
<p>
· On the first line, you are given the integers <strong>R</strong> and    <strong>C</strong>, separated by a space
</p>
<p>
    · On the second line, you are given an integer <strong>N</strong>,
    indicating the number of commands to follow
</p>
<p>
· On the next N lines, you are given commands in format    <strong>{row/col} {direction} {moves}</strong>
</p>
<h3>
    Output
</h3>
<ul>
    <li>
On <strong>R</strong> * <strong>C</strong> number of lines, print the        <strong>swap commands </strong>needed to rearrange the matrix, either:
    </li>
</ul>
<p>
o <strong>“Swap ({row}, {col}) with ({row}, {col})” </strong>or    <strong></strong>
</p>
<p>
    o <strong>“No swap required”</strong>
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        <strong>R, C, N</strong>
        are integers in range [1 … 100]
    </li>
    <li>
        {<strong>row</strong>} and {<strong>col</strong>} will always be inside
        the matrix
    </li>
    <li>
        {<strong>moves</strong>} is in range [0 … 2<sup>31</sup>-1]
    </li>
</ul>
<p>
    · Allowed time and memory: 0.25s / 16 MB
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="156" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="156" valign="top">
                <p>
                    3 3
                </p>
                <p>
                    2
                </p>
                <p>
                    1 down 1
                </p>
                <p>
                    1 left 1
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    No swap required
                </p>
                <p>
                    Swap (0, 1) with (1, 0)
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    Swap (1, 0) with (1, 2)
                </p>
                <p>
                    Swap (1, 1) with (2, 1)
                </p>
                <p>
                    Swap (1, 2) with (2, 1)
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    3 3
                </p>
                <p>
                    2
                </p>
                <p>
                    0 down 3
                </p>
                <p>
                    0 left 3
                </p>
            </td>
            <td width="156" valign="top">
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
                <p>
                    No swap required
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 6. Target Practice
</h2>
<p>
    Cotton-eye Gosho has a problem. <strong>Snakes</strong>! An infestation of
    snakes! Gosho is a red-neck which means he doesn’t really care about animal
    rights, so he bought some ammo, loaded his shotgun and started shooting at
    the poor creatures. He has a favorite spot – rectangular stairs which the
    snakes like to climb in order to reach Gosho’s stash of whiskey in the
    attic. You’re tasked with the horrible cleanup of the aftermath.
</p>
<p>
A <strong>snake</strong> is represented by <strong>a string</strong>. The<strong>stairs</strong> are a    <strong>rectangular matrix of size NxM</strong>. A snake starts climbing
    the stairs from the <strong>bottom-right corner</strong> and slithers its
    way up in a <strong>zigzag</strong> – first it moves left until it reaches
    the left wall, it climbs on the next row and starts moving right, then on
    the third row, moving left again and so on. The first cell (bottom-right
    corner) is filled with the first symbol of the snake, the second cell (to
    the left of the first) is filled with the second symbol, etc. The snake is
    as long as it takes in order to <strong>fill the stairs completely</strong>
    – if you reach the end of the string representing the snake, start again at
    the beginning. Gosho is patient and a sadist, he’ll wait until the stairs
    are completely covered with snakes and then will fire a shot.
</p>
<p>
The shot has three parameters –    <strong>impact row, impact column and radius</strong>. When the projectile
    lands on the specified coordinates in the matrix it
    <strong>
        destroys all symbols in the given radius (turns them into a space)
    </strong>
    . You can check whether a cell is inside the blast radius using the
    Pythagorean Theorem (very similar to the "point inside a circle" problem).
</p>
<p>
    The symbols above the impact area start
    <strong>
        falling down until they land on other symbols (meaning a symbol moves
        down a row as long as there is a space below)
    </strong>
. When the horror ends, print on the console the    <strong>resulting staircase, each row on a new line</strong>. You should
    really check out the examples at this point.
</p>
<h3>
    Input
</h3>
<p>
    · The input data should be read from the console. It consists of exactly
    three lines
</p>
<p>
    · On the first line, you’ll receive the <strong>dimensions</strong> of the
    stairs in format: <strong>"N M"</strong>, where <strong>N</strong> is the
number of <strong>rows</strong>, and <strong>M</strong> is the number of    <strong>columns</strong>. They’ll be separated by a single space
</p>
<p>
· On the second line you’ll receive the string representing the    <strong>snake</strong>
</p>
<p>
· On the third line, you’ll receive the    <strong>shot parameters (impact row, impact column and radius)</strong>,
    all separated by a <strong>single space</strong>
</p>
<p>
    · The input data will always be valid and in the format described. There is
    no need to check it explicitly
</p>
<h3>
    Output
</h3>
<p>
· The output should be printed on the console. It should consist of    <strong>N lines</strong>
</p>
<p>
    · Each line should contain a string representing the respective row of the
    final matrix
</p>
<h3>
    Constraints
</h3>
<ul type="disc">
    <li>
        The <strong>dimensions</strong> N and M of the matrix will be integers
        in the range [1 … 12]
    </li>
    <li>
        The <strong>snake</strong> will be a string with length in the range [1
        … 20] and <strong>will not contain any whitespace characters</strong>
    </li>
    <li>
The shot’s <strong>impact row and column</strong> will always be        <strong>valid coordinates</strong> in the matrix – they will be
        integers in the range [0 … N – 1] and [0 … M – 1] respectively
    </li>
    <li>
        The shot’s <strong>radius</strong> will be an integer in the range [0 …
        4]
    </li>
    <li>
        Allowed working time for your program: 0.1 seconds. Allowed memory: 16
        MB
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="71" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td width="537" valign="top">
                <p>
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="71" valign="top">
                <p>
                    5 6
                </p>
                <p>
                    SoftUni
                </p>
                <p>
                    2 3 2
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    O
                </p>
                <p>
                    US t
                </p>
                <p>
                    tn f
                </p>
                <p>
                    iSi UU
                </p>
                <p>
                    nUt oS
                </p>
            </td>
            <td width="537" valign="top">
                <p>
                    The matrix has 5 rows and 6 columns. Fill it in the
                    described pattern:
                </p>
                <table border="1" cellspacing="0" cellpadding="0">
                    <tbody>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <p>
                    The shot lands on cell (2,3). It has a radius of 2 cells.
                    The impact cell is shaded black and the other cells within
                    the shot radius are shaded grey.
                </p>
                <table border="1" cellspacing="0" cellpadding="0">
                    <tbody>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <p>
                    Replace all characters in the blast area with a space:
                </p>
                <table border="1" cellspacing="0" cellpadding="0">
                    <tbody>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <p>
                    All characters start falling down until they land on other
                    characters:
                </p>
                <table border="1" cellspacing="0" cellpadding="0">
                    <tbody>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    f
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="19">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="19">
                            </td>
                            <td width="19">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="19">
                                <p align="center">
                                    S
                                </p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <p>
                    The resulting matrix is:
                </p>
                <table border="1" cellspacing="0" cellpadding="0">
                    <tbody>
                        <tr>
                            <td width="20">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                        </tr>
                        <tr>
                            <td width="20">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                                <p align="center">
                                    t
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="20">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                                <p align="center">
                                    f
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="20">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    S
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    i
                                </p>
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    U
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td width="20">
                                <p align="center">
                                    n
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    U
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    t
                                </p>
                            </td>
                            <td width="20">
                            </td>
                            <td width="20">
                                <p align="center">
                                    o
                                </p>
                            </td>
                            <td width="20">
                                <p align="center">
                                    S
                                </p>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Lego Blocks
</h2>
<p>
You are given two <strong>jagged arrays</strong>. Each array represents a<strong>Lego block </strong>containing integers. Your task is first to<strong>reverse</strong> the second jagged array and then check if it would    <strong>fit perfectly</strong> in the first jagged array.
</p>
<p>
The picture above shows exactly what <strong>fitting</strong><strong>arrays</strong> means. If the arrays fit perfectly you should    <strong>print out</strong> the newly made rectangular matrix. If the arrays
    do not match (they do not form a rectangular matrix) you should print out
    the <strong>number of cells</strong> in the first array and in the second
    array combined. The examples below should help you understand the
    assignment better.
</p>
<h3>
    Input
</h3>
<p>
The first line of the input comes as an <strong>integer</strong>    <strong>number, n, </strong>saying how many rows are there in both arrays.
    Then you have <strong>2 * n</strong> lines of numbers separated by
    whitespace(s). The first <strong>n </strong>lines are the rows of the first
    jagged array; the next <strong>n </strong>lines are the rows of the second
    jagged array. There might be leading and/or trailing whitespace(s).
</p>
<h3>
    Output
</h3>
<p>
    You should print out the combined matrix in the format:
    <br/>
    <strong>
        [<em>elem, elem, …, elem</em>]
        <br/>
        [<em>elem, elem, …, elem</em>]
        <br/>
        [<em>elem, elem, …, elem</em>]
    </strong>
    <strong>
        <br/>
    </strong>
If the two arrays do not fit you should print out:    <strong>The total number of cells is: <em>count</em></strong>
</p>
<h3>
    Constraints
</h3>
<ul type="disc">
    <li>
        The number n will be in the range [2…10]
    </li>
</ul>
<p>
    · Time limit: 0.3 sec. Memory limit: 16 MB
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="501" valign="top">
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
            <td width="501" valign="top">
                <p>
                    2
                </p>
                <p>
                    1 1 1 1 1 1
                </p>
                <p>
                    2 1 1 3
                </p>
                <p>
                    1 1
                </p>
                <p>
                    2 2 2 3
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    [1, 1, 1, 1, 1, 1, 1, 1]
                </p>
                <p>
                    [2, 1, 1, 3, 3, 2, 2, 2]
                </p>
            </td>
        </tr>
        <tr>
            <td width="501" valign="top">
                <p>
                    2
                </p>
                <p>
                    1 1 1 1 1
                </p>
                <p>
                    1 1 1
                </p>
                <p>
                    1
                </p>
                <p>
                    1 1 1 1 1
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    The total number of cells is: 14
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Radioactive Mutant Vampire Bunnies
</h2>
<p>
    Browsing through GitHub, you come across an old JS Basics teamwork game. It
    is about very nasty bunnies that multiply extremely fast. There’s also a
    player that has to escape from their lair. You really like the game so you
    decide to port it to C# because that’s your language of choice. The last
    thing that is left is the algorithm that decides if the player will escape
    the lair or not.
</p>
<p>
First, you will receive a line holding integers <strong>N</strong> and    <strong>M</strong>, which represent the rows and columns in the lair. Then
    you receive <strong>N</strong> strings that can <strong>only</strong>
    consist of <strong>“.”</strong>, <strong>“B”</strong>, <strong>“P”</strong>
. The <strong>bunnies</strong> are marked with “<strong>B”,</strong> the<strong>player</strong> is marked with “<strong>P</strong>”, and<strong>everything</strong> else is free space, marked with a dot    <strong>“.”</strong>. They represent the initial state of the lair. There
    will be <strong>only </strong>one player. Then you will receive a string
    with <strong>commands</strong> such as <strong>LLRRUUDD</strong> – where
    each letter represents the next <strong>move</strong> of the player (Left,
    Right, Up, Down).
</p>
<p>
    <strong>After</strong>
    each step of the player, each of the bunnies spread to the up, down, left
    and right (neighboring cells marked as “.” <strong>changes</strong> their
    value to B). If the player <strong>moves</strong> to a bunny cell or a
    bunny <strong>reaches</strong> the player, the player has died. If the
    player goes <strong>out</strong> of the lair <strong>without</strong>
    encountering a bunny, the player has won.
</p>
<p>
    When the player <strong>dies</strong> or <strong>wins</strong>, the game
    ends. All the activities for <strong>this</strong> turn continue (e.g. all
the bunnies spread normally), but there are no more turns. There will be    <strong>no</strong> stalemates where the moves of the player end before he
    dies or escapes.
</p>
<p>
    Finally, print the final state of the lair with every row on a separate
    line. On the last line, print either <strong>“dead: {row} {col}”</strong>
    or <strong>“won: {row} {col}”</strong>. Row and col are the coordinates of
    the cell where the player has died or the last cell he has been in before
    escaping the lair.
</p>
<h3>
    Input
</h3>
<p>
· On the first line of input, the numbers <strong>N</strong> and<strong>M</strong> are received – the number of <strong>rows</strong> and    <strong>columns</strong> in the lair
</p>
<p>
    · On the next N lines, each row is received in the form of a string. The
    string will contain only “.”, “B”, “P”. All strings will be the same
    length. There will be only one “P” for all the input
</p>
<p>
    · On the last line, the directions are received in the form of a string,
    containing “R”, “L”, “U”, “D”
</p>
<h3>
    Output
</h3>
<p>
    · On the first N lines, print the final state of the bunny lair
</p>
<p>
    · On the last line, print the outcome – “won:” or “dead:” + {row} {col}
</p>
<h3>
    Constraints
</h3>
<p>
    · The dimensions of the lair are in range [3…20]
</p>
<p>
    · The directions string length is in range [1…20]
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="305" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="305" valign="top">
                <p>
                    5 8
                </p>
                <p>
                    .......B
                </p>
                <p>
                    ...B....
                </p>
                <p>
                    ....B..B
                </p>
                <p>
                    ........
                </p>
                <p>
                    ..P.....
                </p>
                <p>
                    ULLL
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    BBBBBBBB
                </p>
                <p>
                    BBBBBBBB
                </p>
                <p>
                    BBBBBBBB
                </p>
                <p>
                    .BBBBBBB
                </p>
                <p>
                    ..BBBBBB
                </p>
                <p>
                    won: 3 0
                </p>
            </td>
        </tr>
        <tr>
            <td width="305" valign="top">
                <p>
                    4 5
                </p>
                <p>
                    .....
                </p>
                <p>
                    .....
                </p>
                <p>
                    .B...
                </p>
                <p>
                    ...P.
                </p>
                <p>
                    LLLLLLLL
                </p>
            </td>
            <td width="372" valign="top">
                <p>
                    .B...
                </p>
                <p>
                    BBB..
                </p>
                <p>
                    BBBB.
                </p>
                <p>
                    BBB..
                </p>
                <p>
                    dead: 3 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. Crossfire
</h2>
<p>
    You will receive <strong>two</strong> <strong>integers</strong> which
    represent the <strong>dimensions</strong> of a <strong>matrix</strong>.
Then, you must <strong>fill</strong> <strong>the</strong><strong>matrix</strong> with <strong>increasing</strong>    <strong>integers</strong> starting from 1, and continuing on every row,
    like this:
    <br/>
    first row: 1, 2, 3, …, n
    <br/>
    second row: n + 1, n + 2, n + 3, …, n + n
    <br/>
    third row: 2 * n + 1, 2 * n + 2, …, 2 * n + n
</p>
<p>
You will also receive several commands in the form of    <strong>3 integers</strong> separated by a space. Those 3 integers will
    represent a <strong>row</strong> in the matrix, a <strong>column</strong>
    and a <strong>radius</strong>. You must then <strong>destroy</strong> the
    cells which correspond to those arguments <strong>cross-like.</strong>
</p>
<p>
    <strong>Destroying</strong>
    a cell means that, <strong>that</strong> <strong>cell </strong>becomes
    completely<strong> nonexistent</strong> in the matrix.<strong> </strong>
Destroying cells <strong>cross-like</strong> means that you form a    <strong>cross figure</strong> with center point - equal to the cell with
    coordinates – the <strong>given row</strong> and <strong>column</strong>,
and <strong>lines </strong>with length equal to the    <strong>given radius</strong>. See the examples for more info.
</p>
<p>
    The <strong>input ends</strong> when you receive the command “Nuke it from
    orbit”. When that happens, you must print what has remained from the
    initial matrix.
</p>
<h3>
    Input
</h3>
<p>
    · On the first line you will receive the dimensions of the matrix. You must
    then fill the matrix according to those dimensions
</p>
<p>
    · On the next several lines you will begin receiving 3 integers separated
    by a single <strong>space</strong>, which represent the row, col and
    radius. You must then destroy cells according to those coordinates
</p>
<ul>
    <li>
        When you receive the command “<strong>Nuke it from orbit</strong>” the
        input ends
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    · The output is simple. You must print what is left from the matrix
</p>
<p>
    · Every row must be printed on a new line and every column of a row -
    separated by a space
</p>
<h3>
    Constraints
</h3>
<p>
    · The dimensions of the matrix will be integers in the range [2, 100]
</p>
<p>
· The given rows and columns will be valid integers in the range [-2    <sup>31 </sup>+ 1, 2<sup>31</sup> - 1]
</p>
<p>
    · The radius will be in range [0, 2<sup>31</sup> - 1]
</p>
<ul>
    <li>
        Allowed time/memory: 250ms/16MB
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    <strong>Comment</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    5 5
                </p>
                <p>
                    3 3 2
                </p>
                <p>
                    4 3 2
                </p>
                <p>
                    Nuke it from orbit
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    6 7 8 10
                </p>
                <p>
                    11 12 13
                </p>
                <p>
                    16
                </p>
                <p>
                    21
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    Initial matrix:
                </p>
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    6 7 8 9 10
                </p>
                <p>
                    11 12 13 14 15
                </p>
                <p>
                    16 17 18 19 20
                </p>
                <p>
                    21 22 23 24 25
                </p>
                <p>
                    Result from first destruction:
                </p>
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    6 7 8 10
                </p>
                <p>
                    11 12 13 15
                </p>
                <p>
                    16
                </p>
                <p>
                    21 22 23 25
                </p>
                <p>
                    Result from second destruction:
                </p>
                <p>
                    1 2 3 4 5
                </p>
                <p>
                    6 7 8 10
                </p>
                <p>
                    11 12 13
                </p>
                <p>
                    16
                </p>
                <p>
                    21
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    5 5
                </p>
                <p>
                    4 4 4
                </p>
                <p>
                    Nuke it from orbit
                </p>
            </td>
            <td width="104" valign="top">
                <p>
                    1 2 3 4
                </p>
                <p>
                    6 7 8 9
                </p>
                <p>
                    11 12 13 14
                </p>
                <p>
                    16 17 18 19
                </p>
            </td>
            <td width="302" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 10. The Heigan Dance
</h2>
<p>
    At last, level 80. And what do level eighties do? Go raiding. This is where
    you are now – trying not to be wiped by the famous dance boss, Heigan the
    Unclean. The fight is pretty straightforward - dance around the Plague
    Clouds and Eruptions, and you’ll be just fine.
</p>
<p>
    Heigan’s chamber is a 15-by-15 two-dimensional array. The player always
    starts at the <strong>exact center. </strong>For each turn, Heigan uses a
spell that hits a certain cell and the neighboring    <strong>rows/columns</strong>. For example, if he hits (1,1), he also hits
    (0,0, 0,1, 0,2, 1,0 … 2,2). If the player’s current position is within the
area of damage, the player tries to move. First, he tries to move    <strong>up</strong>, if there’s <strong>damage/wall</strong>, he tries to
move <strong>right</strong>, then <strong>down</strong>, then    <strong>left</strong>. If he <strong>cannot move</strong> in any direction,
because<strong> the cell is damaged </strong>or there is    <strong> a wall</strong>, the player <strong>stays</strong> in place and
    takes the damage.
</p>
<p>
    <strong>Plague cloud</strong>
does 3500 damage <strong>when it hits</strong>, and 3500 damage    <strong>the next turn</strong>. Then it <strong>expires. Eruption</strong>
    does 6000 damage <strong>when it hits. </strong>If a spell hits a player
that also has an active Plague Cloud from the previous turn, the<strong>cloud</strong> damage is applied <strong>first</strong>.    <strong>Both</strong> Heigan and the player <strong>may</strong> die in the
same turn. If Heigan is <strong>dead</strong>, the spell he    <strong>would</strong> have casted is <strong>ignored</strong>.
</p>
<p>
    The player always starts at <strong>18500</strong> hit points; Heigan
    starts at <strong>3,000,000</strong> hit points. <strong>Each</strong>
    turn, the player does damage to Heigan. The fight is over either when the
    player is <strong>killed</strong>, or Heigan is <strong>defeated</strong>.
</p>
<h3>
    Input
</h3>
<p>
· On the first line you receive a floating-point number    <strong>D – </strong>the damage done to Heigan each turn
</p>
<p>
· On the next several lines – you receive input in format<strong>{spell} {row} {col}</strong> – <strong>{spell}</strong> is either<strong>Cloud</strong> or <a name="OLE_LINK6"></a>    <a name="OLE_LINK5"><strong>Eruption</strong></a>
</p>
<h3>
    Output
</h3>
<ul>
    <li>
        On the first line
    </li>
</ul>
<p>
o If Heigan is defeated: “<strong>Heigan:</strong>    <strong>Defeated!</strong>”
</p>
<p>
    o Else: “<strong>Heigan: {remaining</strong>}”, where remaining is rounded
    to two digits after the decimal separator
</p>
<ul>
    <li>
        On the second line:
    </li>
</ul>
<p>
    o If the player is killed: “<a name="OLE_LINK8"></a>
    <a name="OLE_LINK7">
        <strong>Player:</strong>
        <strong>Killed by {spell}</strong>
    </a>
    ”
</p>
<p>
o Else “<a name="OLE_LINK10"></a><a name="OLE_LINK9"><strong>Player: {remaining}</strong></a>    <strong>”</strong>
</p>
<ul>
    <li>
        On the third line: “<strong>Final position: {row, col}</strong>” -&gt;
        the last coordinates of the player
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
        <strong>D </strong>
        is a floating-point number in range [0 … 500000]<strong></strong>
    </li>
</ul>
<p>
    · A damaging spell will always affect at least one cell<strong></strong>
</p>
<ul>
    <li>
        Allowed memory: 16 MB<strong></strong>
    </li>
    <li>
        Allowed working time: 0.25s<strong></strong>
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="299" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="299" valign="top">
                <p>
                    10000
                </p>
                <p>
                    Cloud 7 7
                </p>
                <p>
                    Eruption 6 7
                </p>
                <p>
                    Eruption 8 7
                </p>
                <p>
                    Eruption 8 7
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Heigan: 2960000.00
                </p>
                <p>
                    Player: Killed by Eruption
                </p>
                <p>
                    Final position: 8, 7
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="299" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="299" valign="top">
                <p>
                    500000
                </p>
                <p>
                    Cloud 7 6
                </p>
                <p>
                    Eruption 7 8
                </p>
                <p>
                    Eruption 7 7
                </p>
                <p>
                    Cloud 7 8
                </p>
                <p>
                    Eruption 7 9
                </p>
                <p>
                    Eruption 6 14
                </p>
                <p>
                    Eruption 7 11
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Heigan: Defeated!
                </p>
                <p>
                    Player: 12500
                </p>
                <p>
                    Final position: 7, 11
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="299" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="299" valign="top">
                <p>
                    12500.66
                </p>
                <p>
                    Cloud 7 7
                </p>
                <p>
                    Cloud 7 7
                </p>
                <p>
                    Cloud 7 7
                </p>
                <p>
                    Cloud 7 7
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Heigan: 2949997.36
                </p>
                <p>
                    Player: Killed by Plague Cloud
                </p>
                <p>
                    Final position: 7, 7
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 11. Parking System
</h2>
<p>
    The parking lot in front of SoftUni is one of the busiest in the country,
    and it’s a common cause for conflicts between the doorkeeper Bai Tzetzo and
    the students. The SoftUni team wants to proactively resolve all conflicts,
    so an automated parking system should be implemented. They are organizing a
    competition – Parkoniada – and the author of the best parking system will
    win a romantic dinner with RoYaL. That’s <strong>exactly</strong> what
    you’ve been dreaming of, so you decide to join in.
</p>
<p>
The parking lot is a <strong>rectangular</strong> matrix where the    <strong>first</strong> column is <strong>always</strong> free and all other
    cells are parking spots. A car can enter from <strong>any cell</strong> of
    the <strong>first column</strong> and then decides to go to a specific
spot. If that spot is <strong>not </strong>free, the car searches for the<strong>closest </strong>free spot on the <strong>same </strong>row. If    <strong>all</strong> the cells on that specific row are used, the car
    cannot park and leaves. If <strong>two</strong> free cells are located at
    the <strong>same</strong> distance from the <strong>initial</strong>
    parking spot, the cell which is <strong>closer</strong> to the entrance is
    preferred. A car can <strong>pass </strong>through a used parking spot.
</p>
<p>
    Your task is to calculate the distance travelled by each car to its parking
    spot.
</p>
<p>
    Example: A car enters the parking at row 1. It wants to go to cell 2, 2 so
    it moves through <strong>exactly four</strong> cells to reach its parking
    spot.
</p>
<h3>
    Input
</h3>
<p>
    · On the first line of input, you are given the integers <strong>R</strong>
    and <strong>C</strong>, defining the dimensions of the parking lot
</p>
<p>
· On the next several lines, you are given the integers    <strong>Z, X,</strong> <strong>Y</strong> where <strong>Z</strong> is the
    entry row and <strong>X, Y</strong> are the coordinates of the desired
    parking spot
</p>
<ul>
    <li>
        The input stops with the command ‘<strong>stop</strong>’. All integers
        are separated by a <strong>single</strong> space
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    · For each car, print the distance travelled to the desired spot or the
    first free spot
</p>
<p>
· If a car cannot park on its desired row, print the message ‘    <strong>Row {row number} full</strong>’
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        2 ≤ R,C ≤ 10000
    </li>
</ul>
<p>
    · Z, X, Y are inside the dimensions of the matrix. Y is never on the first
    column
</p>
<ul>
    <li>
        There are no more than 1000 input lines
    </li>
    <li>
        Allowed time/space: 0.1s (C#) /16MB
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="305" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="305" valign="top">
                <p>
                    4 4
                </p>
                <p>
                    1 2 2
                </p>
                <p>
                    2 2 2
                </p>
                <p>
                    2 2 2
                </p>
                <p>
                    3 2 2
                </p>
                <p>
                    stop
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    4
                </p>
                <p>
                    2
                </p>
                <p>
                    4
                </p>
                <p>
                    Row 2 full
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 12. String Matrix Rotation
</h2>
<p>
    You are given a <strong>sequence of text lines</strong>. Assume these text
    lines form a <strong>matrix of characters</strong> (pad the missing
positions with spaces to build a rectangular matrix). Write a program to    <strong>rotate the matrix</strong> by 90, 180, 270, 360, … degrees. Print
    the result at the console as sequence of strings. Examples:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="220">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="124">
                <p align="center">
                    <strong>Rotate(90)</strong>
                </p>
            </td>
            <td width="225">
                <p align="center">
                    <strong>Rotate(180)</strong>
                </p>
            </td>
            <td width="129">
                <p align="center">
                    <strong>Rotate(270)</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="220">
                <p>
                    hello
                </p>
                <p>
                    softuni
                </p>
                <p>
                    exam
                </p>
            </td>
            <td width="124" rowspan="2">
            </td>
            <td width="225" rowspan="2">
            </td>
            <td width="129" rowspan="2">
            </td>
        </tr>
        <tr>
            <td width="220">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Input
</h3>
<p>
    · The first line holds a command in format "<strong>Rotate(X)</strong>"
    where <strong>X</strong> are the degrees of the requested rotation
</p>
<ul>
    <li>
        The next lines contain the <strong>lines of the matrix</strong> for
        rotation
    </li>
    <li>
        The input ends with the command <strong>"END"</strong>
    </li>
</ul>
<p>
    The input data will always be valid and in the format described. There is
    no need to check it explicitly
</p>
<h3>
    Output
</h3>
<ul>
    <li>
        Print at the console the <strong>rotated matrix</strong> as a sequence
        of text lines
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
        The rotation <strong>degrees</strong> are positive integer in the range
[0…90000], where <strong>degrees</strong> is        <strong>multiple of 90</strong>
    </li>
    <li>
        The number of matrix lines is in the range [1…<strong>1 000</strong>]
    </li>
    <li>
        The matrix lines are <strong>strings</strong> of length 1 … 1 000
    </li>
</ul>
<p>
    · Allowed working time: 0.2 seconds. Allowed memory: 16 MB
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="97" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="55" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="26" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="106" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="23" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="106" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="97" valign="top">
                <p>
                    Rotate(90)
                </p>
                <p>
                    hello
                </p>
                <p>
                    softuni
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="55" valign="top">
                <p>
                    esh
                </p>
                <p>
                    xoe
                </p>
                <p>
                    afl
                </p>
                <p>
                    mtl
                </p>
                <p>
                    uo
                </p>
                <p>
                    n
                </p>
                <p>
                    i
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Rotate(180)
                </p>
                <p>
                    hello
                </p>
                <p>
                    softuni
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    maxe
                </p>
                <p>
                    inutfos
                </p>
                <p>
                    olleh
                </p>
            </td>
            <td width="106" valign="top">
                <p>
                    Rotate(270)
                </p>
                <p>
                    hello
                </p>
                <p>
                    softuni
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    i
                </p>
                <p>
                    n
                </p>
                <p>
                    ou
                </p>
                <p>
                    ltm
                </p>
                <p>
                    lfa
                </p>
                <p>
                    eox
                </p>
                <p>
                    hse
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="20" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="105" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="73" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="23" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="105" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="100" valign="top">
                <p>
                    Rotate(720)
                </p>
                <p>
                    js
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    js
                </p>
                <p>
                    exam
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    Rotate(810)
                </p>
                <p>
                    js
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="73" valign="top">
                <p>
                    ej
                </p>
                <p>
                    xs
                </p>
                <p>
                    a
                </p>
                <p>
                    m
                </p>
            </td>
            <td width="105" valign="top">
                <p>
                    Rotate(0)
                </p>
                <p>
                    js
                </p>
                <p>
                    exam
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="60" valign="top">
                <p>
                    js
                </p>
                <p>
                    exam
                </p>
            </td>
        </tr>
    </tbody>
</table>