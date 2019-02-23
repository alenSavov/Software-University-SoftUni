<p>
    More Exercise: Arrays and Matrices
</p>
<p>
    Problems for exercise and homework for the
    <a href="https://softuni.bg/trainings/2247/js-fundamentals-january-2019">
        "JavaScript Fundamentals Course@SoftUni".
    </a>
    Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/1471">
        https://judge.softuni.bg/Contests/1471
    </a>
    .
</p>
<h2>
    1. Car Category
</h2>
<p>
    Write a function that takes as parameter an array of strings, which
    represent car numbers. The possible categories of car numbers are:<em></em>
</p>
<ul>
    <li>
        <strong>BulgarianArmy</strong>
        - <strong>"BA 123 456"</strong> -&gt; starts with "BA" and is followed
        by two 3-digit numbers.
    </li>
    <li>
        <strong>CivilProtection</strong>
        - <strong>"CP 12 345"</strong> -&gt; starts with "СР" and is followed
        by two number groups, the first one with 2-digits and the second one
        with 3-digits.<em></em>
    </li>
    <li>
        <strong>Diplomatic</strong>
        - <strong>"C 1234", "CT 1234"</strong> -&gt; starts with "С" or "СТ"
        and is followed by a 4-digit
        <br/>
        number.<em></em>
    </li>
    <li>
        <strong>Foreigners</strong>
        - <strong>"XX 1234"</strong> -&gt; starts with "ХХ" and is followed by
        a 4-digit number.<em></em>
    </li>
    <li>
        <strong>Transient</strong>
        - <strong>"123 В 123"</strong> -&gt; starts with 3 digits than a single
        letter and another 3
        <br/>
        digits.<em></em>
    </li>
    <li>
        <strong>Sofia </strong>
        - <strong>"CA 1234 CA", "СВ 1234 СВ", "С 1234 С", "С 1234 СА"</strong>
        -&gt; starts with "С", "СА" or "СВ" and is followed by 4-digits, and
        ends with one or two letters. <em></em>
    </li>
    <li>
        <strong>Province</strong>
        – <strong>"K 2412 DX"</strong>-&gt; starts with one or two letters,
        then 4 digits and one or two letters again.<em></em>
    </li>
    <li>
        <strong>Other</strong>
        – all that do not meet the conditions above.<em></em>
    </li>
</ul>
<p>
Display the cars <strong>sorted</strong> by count of numbers in<strong>descending</strong> then by category name.    <strong><u>Each row is a paragraph text.</u></strong><em></em>
</p>
<p>
    <strong>Examples</strong>
    <strong></strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="333" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="240" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="333" valign="top">
                <p>
                    ["C 1234", "CT 1234", "C 1234 C", "CP 12 345", "CA 1234
                    CA", "BA 123 456", "XX 1234", "123 B 123",
                    <br/>
                    "B 1234 BB", "11111111", "C1111111"]
                </p>
            </td>
            <td width="240" valign="top">
                <p>
                    BulgarianArmy -&gt; 1
                </p>
                <p>
                    CivilProtection -&gt; 1
                </p>
                <p>
                    Diplomatic -&gt; 2
                </p>
                <p>
                    Foreigners -&gt; 1
                </p>
                <p>
                    Other -&gt; 2
                </p>
                <p>
                    Province -&gt; 1
                </p>
                <p>
                    Sofia -&gt; 2
                </p>
                <p>
                    Transient -&gt; 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p align="center">
    <img
        border="0"
        width="422"
        height="408"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image002.jpg"
    />
</p>
<h2>
    2. Book Shelfs
</h2>
<p>
    Write a function that stores information about <strong>shelves</strong> and
the <strong>books in the shelves</strong>. Each shelf has an    <strong>Id</strong> and a <strong>genre</strong> of books that can be in
it. Each book has a <strong>title</strong>, an <strong>author</strong> and<strong>genre</strong>. The input comes as an    <strong>array of strings</strong>. They will be in the format:
</p>
<ul>
    <li>
        <strong>"{shelf id} -&gt; {shelf genre}"</strong>
        – create a shelf <strong>if the id is not taken</strong>
    </li>
    <li>
        <strong>"{book title}: {book author}, {book genre}"</strong>
        – if a shelf with that <strong>genre exists</strong>, add the book to
        the shelf<strong></strong>
    </li>
</ul>
<p>
After finished reading input, sort the shelves by    <strong>count of books</strong> in it in <strong>descending</strong>. For
    each shelf sort the <strong>books by title</strong> in ascending. Then
display them in the following format each in a separate    <strong>&lt;p&gt;</strong>.
</p>
<ul>
    <li>
        <strong>
            "{shelveOne id} {shelf genre}: {books count}
            <br/>
            --&gt; {bookOne title}: {bookOne author}
            <br/>
            --&gt; {bookTwo title}: {bookTwo author}
            <br/>
            …
            <br/>
            {shelveTwo id} {shelf genre}: {books count}
            <br/>
            …"
        </strong>
    </li>
</ul>
<h3>
</h3>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="307" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="307" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="307" valign="top">
                <p>
                    ["1 -&gt; history", "1 -&gt; action", "Death in Time: Criss
                    Bell, mystery", "2 -&gt; mystery", "3 -&gt; sci-fi", "Child
                    of Silver: Bruce Rich, mystery", "Hurting Secrets: Dustin
                    Bolt, action", "Future of Dawn: Aiden Rose, sci-fi", "Lions
                    and Rats: Gabe Roads, history", "2 -&gt; romance", "Effect
                    of the Void: Shay B, romance", "Losing Dreams: Gail Starr,
                    sci-fi", "Name of Earth: Jo Bell, sci-fi", "Pilots of
                    Stone: Brook Jay, history"]
                </p>
            </td>
            <td width="307" valign="top">
                <p>
                    3 sci-fi: 3
                </p>
                <p>
                    --&gt; Future of Dawn: Aiden Rose
                </p>
                <p>
                    --&gt; Losing Dreams: Gail Starr
                </p>
                <p>
                    --&gt; Name of Earth: Jo Bell
                </p>
                <p>
                    1 history: 2
                </p>
                <p>
                    --&gt; Lions and Rats: Gabe Roads
                </p>
                <p>
                    --&gt; Pilots of Stone: Brook Jay
                </p>
                <p>
                    2 mystery: 1
                </p>
                <p>
                    --&gt; Child of Silver: Bruce Rich
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p align="center">
    <img
        border="0"
        width="410"
        height="407"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image004.jpg"
    />
</p>
<h2>
    3. Card Wars
</h2>
<p>
The game is played by the rules of the game    <a href="https://en.wikipedia.org/wiki/War_(card_game)">"War"</a>.
</p>
<p>
    There are <strong>two players</strong>, each with <strong>13</strong>
    cards. <em>(The cards are valid, as the standard 52-card deck.)</em>
</p>
<p>
    The input is an <strong>array of 2 arrays</strong>. First starts the first
    player in order of input with the card at 0 index. Then it’s second one‘s
    turn. The process is repeated until the end of the game.
</p>
<p>
    The player with the <strong>higher</strong> card takes both of the cards,
    by adding them at the <strong>end</strong> of his array (first the card of
    the first player, then the card of the second).
</p>
<p>
    The winner is either the one who collects all cards, or the one who has
    collected more cards than the other on 20<sup>th</sup> turn.
</p>
<p>
    2, 3, 4, 5, 6, 7, 8, 9, 10, J (11), Q (12), K (13), A (14)
</p>
<p>
    Then it’s time to play.
</p>
<p>
    There will be <strong>no case</strong>, where the two players will have the
    same cards.
</p>
<h3>
    Input
</h3>
<p>
    Array of arrays
</p>
<h3>
    Output
</h3>
<p>
    The output consists of the cards of both players, as shown below:
</p>
<p>
    <strong>
        &lt;p&gt;First -&gt; 8, 7, 7, 7, 3, 3, K, 10, Q, J, 9, A, 4, Q, K, Q,
        4, 2&lt;/p&gt;
    </strong>
</p>
<p>
    <strong>&lt;p&gt;Second -&gt; 10, 6, J, 2, 3, 9, A, 5&lt;/p&gt;</strong>
</p>
<h3>
    Examples
</h3>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0" width="0">
        <tbody>
            <tr>
                <td width="305" valign="top">
                    <p align="center">
                        <strong>Input</strong>
                    </p>
                </td>
                <td width="252" valign="top">
                    <p align="center">
                        <strong>Output</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="305" valign="top">
                    <p>
                        [[4, 5, "J", 5],[3, 6, "K", 3]]
                    </p>
                </td>
                <td width="252" valign="top">
                    <p>
                        First -&gt;
                    </p>
                    <p>
                        Second -&gt; 4, 5, 3, 6, 5, J, 3, K
                    </p>
                </td>
            </tr>
            <tr>
                <td width="305" valign="top">
                    <p>
                        [[10, "K", "Q", 2, 4], ["A", 3, "J", 2, 8]]
                    </p>
                </td>
                <td width="252" valign="top">
                    <p>
                        First -&gt; 3, J, 2, K, 2, 10, 4, Q, 8
                    </p>
                    <p>
                        Second -&gt; A
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<p align="center">
    <img
        border="0"
        width="580"
        height="230"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image006.jpg"
    />
</p>
<h2>
    4. Radio Crystals
</h2>
<p>
    It’s time to put your skills to work for the war effort – creating
    management software for a radio transmitter factory. Radios require a
    finely tuned quartz crystal in order to operate at the correct frequency.
    The resource used to produce them is quartz ore that comes in big chunks
    and needs to undergo several processes, before it reaches the desired
    properties.
</p>
<p>
    You need to write a JS program that monitors the current thickness of the
    crystal and recommends the next procedure that will bring it closer to the
    desired frequency. To reduce waste and the time it takes to make each
    crystal your program needs to complete the process with the least number of
    operations. Each operation takes the same amount of time, but since they
    are done at different parts of the factory, the crystals have to be
    transported and thoroughly washed every time an operation different from
    the previous must be performed, so this must also be taken into account.
    When determining the order, always attempt to start from the operation that
    removes the largest amount of material.
</p>
<p>
    The different operations you can perform are the following:
</p>
<ul>
    <li>
        <strong>Cut</strong>
        – cuts the crystal in 4
    </li>
    <li>
        <strong>Lap</strong>
        – removes 20% of the crystal’s thickness
    </li>
    <li>
        <strong>Grind</strong>
        – removes 20 microns of thickness
    </li>
    <li>
        <strong>Etch</strong>
        – removes 2 microns of thickness
    </li>
    <li>
        <strong>X-ray</strong>
        – increases the thickness of the crystal by 1 micron; this operation
        can only be done once!
    </li>
    <li>
        <strong>Transporting and washing </strong>
        – removes any imperfections smaller than 1 micron (round down the
        number); do this after every batch of operations that remove material
    </li>
</ul>
<p>
At the beginning of your program, you will receive a<strong>number</strong> representing the<strong>desired final thickness</strong> and a<strong>series of numbers</strong>, representing    <strong>the thickness of crystal ore</strong> in <strong>microns</strong>.
    Process each chunk and print the order of operations and number of times
    they need to be repeated to bring them to the desired thickness.
</p>
<p>
    The <strong>input</strong> comes as a numeric array with a variable number
    of elements. The first number is the target thickness and all following
    numbers are the thickness of different chunks of quartz ore.
</p>
<p>
    The <strong>output</strong> is the order of operation and how many times
    they are repeated, every operation in a
    <br/>
    <strong>separate paragraph</strong>
    . See the examples for more information.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="227" valign="top">
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
            <td width="227" valign="top">
                <p>
                    [1375, 50000]
                </p>
            </td>
            <td width="302" valign="top">
                <p>
                    Processing chunk 50000 microns
                </p>
                <p>
                    Cut x2
                </p>
                <p>
                    Transporting and washing
                </p>
                <p>
                    Lap x3
                </p>
                <p>
                    Transporting and washing
                </p>
                <p>
                    Grind x11
                </p>
                <p>
                    Transporting and washing
                </p>
                <p>
                    Etch x3
                </p>
                <p>
                    Transporting and washing
                </p>
                <p>
                    X-ray x1
                </p>
                <p>
                    Finished crystal 1375 microns
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Explanation
</h3>
<p>
    The operation that will remove the most material is always cutting – it
    removes three quarters of the chunk. Starting from 50000, if we perform it
    twice, we bring the chunk down to 3125. If we cut again, the chunk will be
    781.25, which is less than the desired thickness, so we move to the next
    operation, but we first round down the number (transporting &amp; washing).
    Next, we lap the chunk – after three operations, the crystal reaches 1600
    microns. One more lapping would take it to 1280, so we move on to the next
    operation instead. We do the same check with grinding, and finally by
    etching 2 times, the crystal has reached 1376 microns, which is one more
    than desired. We don’t have an operation which only takes away 1 micron, so
    instead we etch once more to get to 1374, wash and then x-ray to add 1
    micron, which brings us to the desired thickness.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0" width="0">
        <tbody>
            <tr>
                <td width="227" valign="top">
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
                <td width="227" valign="top">
                    <p>
                        [1000, 4000, 8100]
                    </p>
                </td>
                <td width="302" valign="top">
                    <p>
                        Processing chunk 4000 microns
                    </p>
                    <p>
                        Cut x1
                    </p>
                    <p>
                        Transporting and washing
                    </p>
                    <p>
                        Finished crystal 1000 microns
                    </p>
                    <p>
                        Processing chunk 8100 microns
                    </p>
                    <p>
                        Cut x1
                    </p>
                    <p>
                        Transporting and washing
                    </p>
                    <p>
                        Lap x3
                    </p>
                    <p>
                        Transporting and washing
                    </p>
                    <p>
                        Grind x1
                    </p>
                    <p>
                        Transporting and washing
                    </p>
                    <p>
                        Etch x8
                    </p>
                    <p>
                        Transporting and washing
                    </p>
                    <p>
                        Finished crystal 1000 microns
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<p align="center">
    <img
        border="0"
        width="515"
        height="362"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image008.jpg"
    />
</p>
<h2>
    5. *DNA Helix
</h2>
<p>
    Write a JS program that prints a DNA helix with length, specified by the
    user. The helix has a repeating structure, but the symbol in the chain
    follows the sequence <em>ATCGTTAGGG</em>. See the examples for more
    information.
</p>
<p>
    The <strong>input</strong> comes as a single number. It represents the
    length of the required helix.
</p>
<p>
    The <strong>output</strong> is the completed structure, displayed in the
    DOM, each line in separate <strong>paragraph</strong>.
</p>
<h3>
    Examples
</h3>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0" width="0">
        <tbody>
            <tr>
                <td width="76" valign="top">
                    <p align="center">
                        <strong>Input</strong>
                    </p>
                </td>
                <td width="113" valign="top">
                    <p align="center">
                        <strong>Output</strong>
                    </p>
                </td>
                <td width="24" rowspan="2" valign="top">
                </td>
                <td width="76" valign="top">
                    <p align="center">
                        <strong>Input</strong>
                    </p>
                </td>
                <td width="113" valign="top">
                    <p align="center">
                        <strong>Output</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="76" valign="top">
                    <p>
                        4
                    </p>
                </td>
                <td width="113" valign="top">
                    <p>
                        **AT**
                        <br/>
                        *C--G*
                        <br/>
                        T----T
                        <br/>
                        *A--G*
                    </p>
                </td>
                <td width="76" valign="top">
                    <p>
                        10
                    </p>
                </td>
                <td width="113" valign="top">
                    <p>
                        **AT**
                        <br/>
                        *C--G*
                        <br/>
                        T----T
                        <br/>
                        *A--G*
                        <br/>
                        **GG**
                        <br/>
                        *A--T*
                        <br/>
                        C----G
                        <br/>
                        *T--T*
                        <br/>
                        **AG**
                        <br/>
                        *G--G*
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<p align="center">
    <img
        border="0"
        width="400"
        height="299"
        src="file:///C:/Users/ALENSA~1/AppData/Local/Temp/msohtmlclip1/01/clip_image010.jpg"
    />
</p>