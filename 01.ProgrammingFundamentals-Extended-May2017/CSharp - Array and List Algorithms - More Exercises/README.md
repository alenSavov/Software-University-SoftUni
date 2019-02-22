<h1>
    More Exercises: Array and List Algorithms
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
    <a href="https://judge.softuni.bg/Contests/428">
        https://judge.softuni.bg/Contests/428
    </a>
</p>
<h2>
    1. Rabbit Hole
</h2>
<p>
    Rabbit hole is a term for a portal for time travel.
</p>
<p>
    You are trying to go back in the past to prevent Kennedy’s assassination.
    But first you should find the rabbit hole. Your energy is limited and if
    you exhaust it, you will be tired and can’t continue the mission.
</p>
<p>
    You will be given an array of strings representing different obstacles you
    should overcome.
</p>
<ul>
    <li>
        “<strong>Left|[integer value]</strong>”-you should jump to the left
        with <strong>[integer value]</strong> positions and decrease your
        energy with <strong>[integer value];</strong>
    </li>
    <li>
        “<strong>Right|[integer value]</strong>”-you should jump to the right
        with <strong>[integer value] </strong>positions and decrease your
        energy with <strong>[integer value]</strong>;
    </li>
    <li>
        “<strong>Bomb|[integer value]</strong>”-the bomb explodes and this
        element of the array should be removed, your energy should be decreased
        be the <strong>[integer value]</strong>, you should start from the
        beginning (<strong>index 0</strong>);
    </li>
    <li>
        “<strong>RabbitHole</strong>” – you have found the rabbit hole, the
        program should stop here, print on the console – “You have 5 years to
        save Kennedy!”
    </li>
</ul>
<p>
    <strong>
        Your mission begins at the first element of the array. The rabbit hole
        will be only one.
    </strong>
</p>
<p>
    The program ends when you find the rabbit hole or when your energy is gone.
    And if it is gone due to bomb explosion you should print “You are dead due
    to bomb explosion!” on the console or if it is due jumps print
</p>
<p>
    “You are tired. You can't continue the mission.”.
</p>
<p>
After every move someone puts a bomb at the end of the array with    <strong>[integer value] of your current energy </strong>(the last element
    is removed and the bomb is placed there, but when the last element is the
    “RabbitHole”, it can’t be removed and the bomb is placed after it).
</p>
<h3>
    Input / Constraints
</h3>
<p>
    · First line – space separated string values consists the obstacles you
    should overcome.
</p>
<p>
    · Second line – integer value representing your initial energy in range
    [0-100].
</p>
<h3>
    Output
</h3>
<ul>
    <li>
        If you find the Rabbit Hole you should print: “You have 5 years to save
        Kennedy!”;
    </li>
</ul>
<p>
    · If you die due to bomb explosion (your energy is gone, after a bomb
    explosion): “You are dead due to bomb explosion!”;
</p>
<p>
    · If you are tired (your energy is gone, after a jump): “You are tired. You
    can't continue the mission.” .
</p>
<h2>
    Examples
</h2>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="377" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="339" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="377" valign="top">
                <p>
                    RabbitHole Left|100 Right|10 Bomb|10 Left|11
                </p>
                <p>
                    100
                </p>
            </td>
            <td width="339" valign="top">
                <p>
                    You have 5 years to save Kennedy!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="376" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="340" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="376" valign="top">
                <p>
                    Right|100 Left|10 Bomb|11 RabbitHole Bomb|10 Left|2
                </p>
                <p>
                    80
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    You are tired. You can't continue the mission.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Binary Search
</h2>
<p>
    In most of our tasks we use <strong>linear search</strong>, when we are
    looking for an element. However, another simple to implement and widely
    used algorithm is the <strong>binary search</strong>. Its idea is to work
on <strong>sorted</strong> collections and to use the principle of    <strong>divide and conquer</strong>.
</p>
<p>
    Your task is to write two methods, which receive an array and an element,
which we will be looking for. Perform the linear search on the<strong>unmodified</strong> collection and start from the<strong>first</strong> element. For the binary search<strong>order</strong> the collection in <strong>ascending</strong><strong>order</strong>, so you receive a viable result. Print “    <strong>Yes</strong>” if the element <strong>can</strong> be found in the
    collection or “<strong>No</strong>” if it’s <strong>not</strong> present.
</p>
<p>
    After that print the <strong>count</strong> of <strong>iterations</strong>,
    which the <strong>linear</strong> search made in format:
</p>
<p>
    “Linear search made {countOfIterations} iterations”
</p>
<p>
And the <strong>count</strong> of <strong>iterations</strong>, which    <strong>binary</strong> search made:
</p>
<p>
    “Binary search made {countOfIterations} iterations”
</p>
<h3>
    Input / Constraints
</h3>
<ul>
    <li>
        <strong>First</strong>
        line – space separated <strong>unique</strong> integers.
    </li>
    <li>
        <strong>Second</strong>
        line – the <strong>element</strong>, which we are searching.
    </li>
    <li>
The numbers will be in the interval        <strong>[-2147483648…2147483647]</strong>
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="214" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="269" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="214" valign="top">
                <p>
                    7 3 3 5 1 2
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="269" valign="top">
                <p>
                    Yes
                </p>
                <p>
                    Linear search made 4 iterations
                </p>
                <p>
                    Binary search made 2 iterations
                </p>
            </td>
        </tr>
        <tr>
            <td width="214" valign="top">
                <p>
                    1 2 3 4 5 6 7 8
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="269" valign="top">
                <p>
                    Yes
                </p>
                <p>
                    Linear search made 2 iterations
                </p>
                <p>
                    Binary search made 2 iterations
                </p>
            </td>
        </tr>
        <tr>
            <td width="214" valign="top">
                <p>
                    20 10 30 50 90 60
                </p>
                <p>
                    23
                </p>
            </td>
            <td width="269" valign="top">
                <p>
                    No
                </p>
                <p>
                    Linear search made 6 iterations
                </p>
                <p>
                    Binary search made 3 iterations
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Hints
</h2>
<ul>
    <li>
        Read more about <strong>linear</strong> search
        <a
            href="https://www.tutorialspoint.com/data_structures_algorithms/linear_search_algorithm.htm"
        >
            here
        </a>
    </li>
    <li>
        Read more about <strong>binary</strong> search
        <a
            href="https://www.tutorialspoint.com/data_structures_algorithms/binary_search_algorithm.htm"
        >
            here
        </a>
    </li>
</ul>
<h2>
    3. Mirror Image
</h2>
<p>
    You will receive a collection of elements from the console. Until you
    receive the command “<strong>Print</strong>” you will receive on every line
    a single number - n, which will represent index from your collection. Your
    task is to reverse the elements from index <strong>0</strong> to index n-1
    and from n+1 to the <strong>last</strong> element of the collection. You
    should not change he position of the element at the given index.
</p>
<p>
    Example: We have the array <strong>10 20 30 40 50 60 70 80 90</strong>. We
receive from the console the index <strong>3</strong>, which is the number    <strong>40</strong>. After reversing the element left and right from the
    number the collection will look like this:
</p>
<p>
    <strong>30 20 10 40 90 80 70 60 50</strong>
</p>
<h3>
    Input / Constraints
</h3>
<ul>
    <li>
        <strong>First</strong>
        line – space separated integers.
    </li>
    <li>
        <strong>Next </strong>
lines – single <strong>number</strong>, which will represent the index,<strong>left</strong> and <strong>right</strong> from which we need to        <strong>reverse</strong> our <strong>array</strong>
    </li>
    <li>
The numbers will be in the interval        <strong>[-2147483648…2147483647]</strong>
    </li>
    <li>
The given <strong>indices</strong> will always be        <strong>inside</strong> the array
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
Print the <strong>elements</strong> of the array        <strong>separated</strong> with <strong>single</strong> white space
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
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
            <td width="226" valign="top">
                <p>
                    <strong>10 20 30 40 50 60 70 80 90</strong>
                </p>
                <p>
                    3
                </p>
                <p>
                    5
                </p>
                <p>
                    8
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    60 50 80 30 20 10 40 90 70
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
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
            <td width="226" valign="top">
                <p>
                    <strong>Every day I am shuffling</strong>
                </p>
                <p>
                    0
                </p>
                <p>
                    4
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    I am shuffling Every day
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="226" valign="top">
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
            <td width="226" valign="top">
                <p>
                    <strong>1 6 10 4 10 2</strong>
                </p>
                <p>
                    3
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    10 6 1 4 2 10
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Japanese Roulette
</h2>
<p>
    Russian roulette is a game of chance where a single player places a single
    bullet in a revolver, spins the cylinder, points the muzzle against their
    head and pulls the trigger. Japanese people however are not that brave
    (crazy) so they <strong>play</strong> with <strong>toy guns</strong>.
</p>
<p>
Every player can spin the cylinder with different strength. The    <strong>numeric</strong> representation of the <strong>strength</strong> is
with    <strong>how many places they can move the bullet while spinning</strong>.
    Note that the cylinder has only <strong>6 places</strong> but the strength
could be <strong>much more</strong> than <strong>6</strong> due to    <strong>several rotations</strong> of the cylinder.
</p>
<p>
    You are given an array of integers which represent the cylinder of the
revolver where<strong> 0 </strong>means <strong>empty</strong> and<strong>1 </strong>represents the<strong> bullet</strong>. There is    <strong>exactly</strong> <strong>one bullet</strong> in the cylinder.
</p>
<p>
You will receive <strong>another</strong> array, this time of<strong>strings</strong> where <strong>every index</strong> is a<strong>different player</strong> and every <strong>value</strong> is the    <strong>strength</strong> of the player and the <strong>direction</strong>
    to which the player <strong>rotates</strong> the cylinder.
</p>
<p>
The elements in the array will be separated by <strong>spaces</strong>. The    <strong>power</strong> and the <strong>direction</strong> will be separated
by a <strong>comma</strong> (”<strong>,</strong>”) e.g.: “    <strong>111,Left</strong>”.
</p>
<p>
    The <strong>muzzle</strong> <strong>IS at</strong> index <strong>2</strong>
of the cylinder. If the <strong>element</strong> at that<strong>position</strong> is <strong>1</strong>, the    <strong>current player</strong> <strong>loses the game</strong>.
</p>
<p>
    <strong>Note! </strong>
After a player <strong>pulls the trigger</strong> the cylinder<strong>spins</strong> with <strong>one position</strong> to the    <strong>right</strong>.<strong> </strong>The <strong>next player</strong>
starts spinning with the <strong>new state</strong> of the    <strong>cylinder</strong>.
</p>
<p>
    Assume that the order of the players is according to their places in the
    array. The player with index 0 shots first, index 1-second and so on…
</p>
<p>
    Your task is to <strong>go</strong> <strong>through all players</strong>,
    and see if anyone will shoot himself with the <strong>toy gun</strong>.
</p>
<h3>
    Input / Constraints
</h3>
<ul>
    <li>
        First line – <strong>6</strong> <strong>integers</strong>, separated by
        a <strong>space</strong> (only 0 or 1, where 1 once and 0 five times)
        which represent the cylinder.
    </li>
    <li>
Second line –<strong>strings</strong>, separated by a        <strong>space</strong>, representing the strength and the direction to
which <strong>every player</strong> rotates. The<strong>strength</strong> and <strong>direction</strong> for a<strong>single player</strong> are <strong>separated</strong> by a        <strong>comma</strong>.
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
        If someone <strong>loses the game</strong> you should print on the
console “Game over! Player {index} is dead.”, where        <strong>index </strong>is the index of the player in the array. The
        game <strong>ends</strong> and so does your program.
    </li>
    <li>
        If no one lost, you should just print: “Everybody got lucky!”
    </li>
</ul>
<h2>
    Examples
</h2>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="359" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="352" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="359" valign="top">
                <p>
                    0 0 0 0 1 0
                </p>
                <p>
                    10,Right 11,Left 140,Right 1,Left 30,Right
                </p>
            </td>
            <td width="352" valign="top">
                <p>
                    Game over! Player 0 is dead.
                </p>
            </td>
        </tr>
        <tr>
            <td width="359" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="352" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="359" valign="top">
                <p>
                    0 0 1 0 0 0
                </p>
                <p>
                    1,Right 2,Left 5,Left
                </p>
            </td>
            <td width="352" valign="top">
                <p>
                    Game over! Player 1 is dead.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Increasing Crisis
</h2>
<p>
    You will be given <strong>N</strong> – an <strong>integer</strong>. On the
    next <strong>N lines</strong>, you will receive <strong>sequences</strong>
of <strong>integers</strong>, <strong>separated</strong> by a    <strong>space</strong>.
</p>
<p>
    Your task is to add each sequence’s integers to a list, so that it forms an
    increasing sequence. If there are already elements <strong>inside</strong>
    the list, you must <strong>find</strong> the <strong>right-most </strong>
element, <strong>lower by value</strong>, than the<strong>first element</strong> from the <strong>given</strong><strong>sequence</strong>, and start<strong> INSERTING</strong>, the<strong>sequence’s</strong> <strong>elements</strong> at the<strong>position</strong>, <strong>AFTER</strong> the    <strong>found element</strong>.
</p>
<p>
If the <strong>increasing sequence</strong> is <strong>BROKEN</strong>,<strong>during</strong> the <strong>addition</strong> of<strong>new elements</strong>, you must <strong>IGNORE </strong>the<strong>element</strong> that <strong>breaks</strong> it and<strong>all others</strong> <strong>after it</strong>. You must also<strong>remove all elements</strong> from the <strong>list</strong>,    <strong>AFTER</strong> the <strong>LAST ADDED</strong> element.
</p>
<p>
When you process all input lines, you must print the<strong>list’s elements</strong>, separated by a    <strong>single space</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
The list, to which you add the elements, is <strong>initially</strong>        <strong>empty</strong>.
    </li>
    <li>
The increasing sequence <strong>CAN</strong> have        <strong>EQUAL</strong> elements.
    </li>
    <li>
        Do <strong>NOT</strong> sort the list in any order.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="123" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="465" valign="top">
                <p align="center">
                    <strong>Comment</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    5
                </p>
                <p>
                    1 2 12 15 16
                </p>
                <p>
                    4 5 6
                </p>
                <p>
                    5 5 5
                </p>
                <p>
                    3 2
                </p>
                <p>
                    3 4 5 6
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    1 2 3 3 4 5 6
                </p>
            </td>
            <td width="465" valign="top">
                <p>
The list is initially empty, so we <strong>add</strong>                    <strong>[1, 2, 12, 15, 16]</strong> to it.
                </p>
                <p>
After that we have <strong>[4, 5, 6]</strong>. We find the<strong>right-most</strong> element,<strong>lower by value</strong> than the                    <strong>first element</strong> (<strong>4</strong>), which
is <strong>2</strong>, and we start                    <strong>INSERTING</strong> <strong>AFTER</strong> it.
                </p>
                <p>
                    The list is now [1, 2, 4, 5, 6, 12, 15, 16].
                </p>
                <p>
                    <strong>
                        + 5 5 5 -&gt; [1, 2, 4, 5, 5, 5, 5, 6, 12, 15, 16]
                    </strong>
                    .<strong></strong>
                </p>
                <p>
Of the <strong>sequence [3, 2]</strong> we                    <strong>insert</strong> <strong>3</strong>.
                </p>
                <p>
The <strong>2<sup>nd</sup> element</strong> of the sequence<strong> </strong>(<strong>2</strong>)<strong> BREAKS</strong> the<strong>increasing sequence</strong>, and so we<strong>ignore</strong> it, and we <strong>remove</strong><strong>all</strong> elements <strong>after</strong> the                    <strong>last added</strong> (<strong>3</strong>), which
                    results in
                </p>
                <p>
                    <strong>[1, 2, 3]</strong>
                    .
                </p>
                <p>
Then we have                    <strong>[3, 4, 5, 6] -&gt; [1, 2, 3, 3, 4, 5, 6]</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="465">
            </td>
        </tr>
        <tr>
            <td width="123" valign="top">
                <p>
                    4
                </p>
                <p>
                    1 2
                </p>
                <p>
                    2 1
                </p>
                <p>
                    2 3
                </p>
                <p>
                    4 5 1 6 7
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    1 2 2 2 3 4 5
                </p>
            </td>
            <td width="465">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Extremums *
</h2>
<p>
You are given a sequence of non-negative integers and a command (    <strong>Min</strong> or <strong>Max</strong>).
</p>
<p>
Depending on the command, you must find the <strong>maximum</strong> or the<strong>minimum</strong> sum of <strong>numbers</strong> formed by the<strong>rotations</strong> of the <strong>digits</strong> of    <strong>every element</strong> in the <strong>sequence</strong>.
</p>
<p>
You are allowed to use only rotations to form the numbers (    <strong>you cannot swap digits, only rotations</strong>). These rotations
    are similar to the array rotations e.g.:
</p>
<p>
    When you are forming the sum you should use all the elements in the
    sequence.
</p>
<p>
    <strong>Note! </strong>
If you<strong> </strong>rotate<strong> 900 </strong><strong>→ 009, 009 </strong>is<strong> </strong>a    <strong> valid number </strong>which is equal to<strong> 9. </strong>
</p>
<h3>
    Input / Constraints
</h3>
<ul>
    <li>
On the first line you will receive <strong>integers</strong>,<strong>separated</strong> by a <strong>space</strong>, in        <strong>range</strong> [<strong>0…100000</strong>];
    </li>
    <li>
        On the second line, you will receive a <strong>string</strong>
        containing the <strong>one</strong> of the words “<strong>Min</strong>”
        or “<strong>Max</strong>”.
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
        The numbers which form the <strong>result</strong> <strong>min</strong>
/ <strong>max</strong> <strong>sum</strong> separated by        <strong>comma</strong> and <strong>space</strong> (‘, ’);
    </li>
    <li>
        A <strong>single integer</strong> <strong>number</strong> representing
the <strong>minimum</strong> or the <strong>maximum</strong>        <strong>sum</strong> of the <strong>numbers</strong>.
    </li>
</ul>
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
            <td width="205" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="173" valign="top">
                <p>
                    255 590 90018 12 10
                </p>
                <p>
                    Max
                </p>
            </td>
            <td width="205" valign="top">
                <p>
                    552, 905, 90018, 21, 10
                </p>
                <p>
                    91506
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="172" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="204" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="172" valign="top">
                <p>
                    100 90 811 98 67
                </p>
                <p>
                    Min
                </p>
            </td>
            <td width="204" valign="top">
                <p>
                    1, 9, 118, 89, 67
                </p>
                <p>
                    284
                </p>
            </td>
        </tr>
    </tbody>
</table>