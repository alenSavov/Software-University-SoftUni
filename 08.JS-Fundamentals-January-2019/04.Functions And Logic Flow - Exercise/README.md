<h1>
    Exercises: Functions and Logic Flow
</h1>
<p>
    Problems for exercise and homework for the
    <a href="https://softuni.bg/trainings/2247/js-fundamentals-january-2019">
        "JavaScript Fundamentals Course@SoftUni".
    </a>
    Submit your solutions in the SoftUni Judge System at
    <a href="https://judge.softuni.bg/Contests/1450">
        https://judge.softuni.bg/Contests/1450
    </a>
</p>
<h2>
    1. Leap Year
</h2>
<p>
    You are given a <strong>year</strong> as an <strong>input</strong>. Your
task is to find if the given year is <strong>leap</strong> or    <strong>not</strong>.
</p>
<p>
When the “<strong>Check</strong>” <strong>button</strong> is    <strong>clicked</strong> the <strong>h2 element</strong> inside the div
with <strong>id</strong> “<strong>yea</strong>r” should be filled with “<strong>Leap Year</strong>” or “<strong>Not Leap Year</strong>”<strong>depends</strong> on the result. And the<strong>div element</strong> inside the div with <strong>id</strong> ”<strong>year</strong>” should be filled with the    <strong>given year</strong>.
</p>
<p>
    <u>
After every click on the “Check” button the input field        <strong>must be cleared</strong>
    </u>
    !
</p>
<h3>
    Examples
</h3>
<p>
    Input: <strong>2016</strong>
</p>
<p>
    Input: <strong>1900</strong>
</p>
<h2>
    2. Simple Number Validator
</h2>
<p>
    Your task here is to create a <strong>Simple Number Validator</strong>.
This Validator calculates whether the given input of    <strong>digits</strong><strong> </strong>form a <strong>valid</strong>
    number. <u>The given number is considered to be valid</u>:
</p>
<p>
    · The input number will be <strong>10-digits</strong>
</p>
<ul>
    <li>
The <strong>last</strong> <strong>digit</strong> should        <strong>equal</strong> the <strong>remainder</strong> of sum of the
        product of its nine digits with their <strong>weights</strong> (the
        weights of each position is given below) divided by 11
    </li>
</ul>
<p>
    · If you have a reminder of 10, make it 0, since you cannot have last digit
    10
</p>
<p>
The weights are as follows:    <strong><u>[2, 4, 8, 5, 10, 9, 7, 3, 6];</u></strong>
</p>
<h3>
    Constrains
</h3>
<p>
    The row of numbers you receive will be a string and every digit will have a
    value between <strong>0</strong> and <strong>9</strong>.
</p>
<p>
    The output should be true (if the row is valid) or false (if the row is
    invalid).
</p>
<h3>
    Output
</h3>
<p>
    When you check if the given number is <strong>valid or not</strong>. Print
    one of the following messages depends on the result:
</p>
<p>
    <strong>“This number is Valid!”</strong>
</p>
<p>
    <strong>“This number is NOT Valid!”</strong>
</p>
<p>
This message must appear like <strong>text</strong> into the<strong>span element</strong> with <strong>id</strong>=“    <strong>response”</strong>.
</p>
<h3>
    Examples
</h3>
<p>
    Input: <strong>1234567890</strong>
</p>
<p>
    Input: <strong>7890123456</strong>
</p>
<h2>
    3. EGN Generator
</h2>
<p>
Your next task is to create an <strong>EGN generator</strong>.    <strong>EGN</strong> consists of 10 digits from 0 to 9, ordered in the
    following sequence:
</p>
<p>
    <strong>The first two digits</strong>
    are the <strong>last two</strong> from the <strong>year of birth</strong>.
</p>
<p>
    <strong>The next two digits</strong>
    are <strong>the month</strong>.
</p>
<p>
    <strong>The next two</strong>
    are <strong>the date</strong>.
</p>
<p>
    <strong>The next three digits</strong>
are for <strong>the region</strong> in which    <strong>the person was born</strong>, <strong>as the last one</strong> is
    for <strong>the gender</strong>.
    <br/>
    <u>Even numbers are used for males and, therefore, odd ones for females</u>
    .
</p>
<p>
    <strong>The last digit</strong>
    <strong>validates</strong>
    <strong>the EGN</strong>
    .
</p>
<p>
It is formed by summing the products of all 9 digits (<strong>weightSum</strong>) with their weight (    <strong>weightPosition</strong>) which is a constant for each digit and
    equals to the position it takes. <strong>CheckNum</strong> is the value of
    the remainder of the division between <strong>weightSum</strong> and the
    number 11.
    <br/>
    <strong>
        <u>
            Have in mind that if the remainder is 10, you have to keep 0 as a
            value.
        </u>
    </strong>
</p>
<p>
    <strong>weightPosition = [2, 4, 8, 5, 10, 9, 7, 3, 6];</strong>
</p>
<h3>
    Input
</h3>
<p>
    You will receive <strong>five parameters</strong>, as follows:
</p>
<p>
    <strong>Year</strong>
    (number), <strong>Month</strong> (string), <strong>Date</strong>(day)
(number), <strong>gender</strong> (string), <strong>regional</strong>    <strong>code</strong> (number);
</p>
<h3>
    Output
</h3>
<p>
When “<strong>GET MY EGN</strong>” button is clicked you have to    <strong>generate</strong> a <strong>new EGN</strong> with the given
information and put it into <strong>paragraph</strong>    <strong>element</strong> with <strong>id</strong> "<strong>egn</strong>".
</p>
<h3>
    Constrains
</h3>
<p>
    <strong>
        <u>
            After each click of the button, input fields must be reset in their
            original state
        </u>
    </strong>
    .
    <br/>
    <strong>Valid year </strong>
is between <strong>1900</strong> and <strong>2100</strong> (    <strong>including</strong>);
</p>
<p>
    <strong>Valid regional code</strong>
is between <strong>43</strong> and <strong>999</strong> (    <strong>including</strong>);
</p>
<p>
    <strong>List of area codes:</strong>
    <strong></strong>
</p>
<p>
    Blagoevgrad - 43
    <br/>
    Burgas 43 – 93
    <br/>
    Varna 93 -139
    <br/>
    Veliko Turnovo 139- 169
    <br/>
    Vidin 183
    <br/>
    Vratca 183- 217
    <br/>
    Gabrovo 217- 233
    <br/>
    Kurdjali- 233 -281
    <br/>
    Kiustendil 281- 301
    <br/>
    Lovech 301- 319
    <br/>
    Montana 319 -341
    <br/>
    Pazardjik 341- 377
    <br/>
    Pernik 377- 395
    <br/>
    Pleven 395- 435
    <br/>
    Plovdiv 435- 501
    <br/>
    Razgrad 501- 527
    <br/>
    Ruse 527- 555
    <br/>
    Silistra 555 -575
    <br/>
    Sliven 575 -601
    <br/>
    Smolqn 601- 623
    <br/>
    Sofia – city 623- 721
    <br/>
    Sofia – region 721- 751
    <br/>
    Stara Zagora 751- 789
    <br/>
    Dobrich (Tolbuhin) 789- 821
    <br/>
    Turgovishte- 821- 843
    <br/>
    Haskovo 843- 871
    <br/>
    Shumen 871- 903
    <br/>
    Qmbol 903 -925
    <br/>
    Other/Unknown 925 – 999
</p>
<h3>
    Examples
</h3>
<p>
    <strong>
        Year: 1900, Month: January, Date: 1, Gender: Male, Regional Code: 950
    </strong>
</p>
<p>
    <strong>
        Year: 2019, Month: December, Date: 31, Gender: Female, Regional Code:
        987
    </strong>
</p>
<h2>
    4. Cooking Numbers
</h2>
<p>
    Write a JS program that receives a number and a list of five operations.
    Perform the operations in sequence by starting with the input number and
    using the result of every operation as starting point for the next. Print
    the result of every operation in order. The operations can be one of the
    following:
</p>
<ul>
    <li>
        chop – divide the number by two
    </li>
    <li>
        dice – square root of number
    </li>
    <li>
        spice – add 1 to number
    </li>
    <li>
        bake – multiply number by 3
    </li>
    <li>
        fillet – subtract 20% from number
    </li>
</ul>
<h3>
    Input
</h3>
<p>
    The original (first) numbers comes from
    <strong>
        input field.
        <br/>
        If in the input field you do NOT receive any number, you should work
        with zero (0);
    </strong>
</p>
<h3>
    Output
</h3>
<p>
    <strong><u>After every click</u></strong>
    on the operation button you should perform the necessary action and print
    the result into the paragraph with id (output)
</p>
<h3>
    Example
</h3>
<p>
The actions in this example will be in this specific order:<strong>Chop</strong> -&gt; <strong>Dice</strong> -&gt;<strong>Spice</strong> -&gt; <strong>Bake</strong> and    <strong>Fillet.</strong>
</p>
<p>
    <strong>The initial number will be 10.</strong>
    <strong></strong>
</p>
<p>
    <strong>Chop</strong>
</p>
<p>
    <strong>Dice</strong>
</p>
<p>
    <strong>Spice</strong>
</p>
<p>
    <strong>Bake</strong>
</p>
<p>
    <strong>Fillet</strong>
</p>
<h2>
    5. Cards Generator
</h2>
<p>
    In this problem you should write a<strong> JS functions</strong> that
generates a hand of cards, depends on <strong>starting</strong> and    <strong>ending</strong> <strong>card</strong>.
</p>
<p>
    Every card should be <strong>div element with class ‘card’.</strong> Also
    needs to contain <strong>3 paragraphs</strong>. <strong>The first</strong>
and the <strong>last one</strong> have to contain the<strong>Unicode character</strong> of that<strong>suit. The middle </strong>one have to contain the    <strong>current card value</strong>. (<strong>2</strong>…<strong>A</strong>
    )
</p>
<p>
All cards must be appended to the <strong>section</strong> with    <strong>id</strong> “<strong>cards</strong>”.
</p>
<h3>
    Input
</h3>
<p>
    <strong>From</strong>
and <strong>To</strong> <strong>values</strong> will be in range:<strong>2</strong>, <strong>3</strong>, <strong>4</strong>,<strong>5</strong>, <strong>6</strong>, <strong>7</strong>,<strong>8</strong>, <strong>9</strong>, <strong>10</strong>,<strong>J</strong>, <strong>Q</strong>, <strong>K</strong> and    <strong>A</strong>.
</p>
<p>
    <strong>Suit</strong>
will be one of the following: <strong>Hearts</strong>,<strong>Diamonds</strong>, <strong>Spades</strong> or    <strong>Clubs;</strong>
</p>
<p>
    <strong><u>Note</u>: From card value</strong>
will be <strong>greater</strong> or <strong>equal</strong> to    <strong>To card value.</strong>
</p>
<p>
    <strong><u>Note</u>: </strong>
    If you already have some cards into the <strong>cards section </strong>you
    need to append the new cards to the old ones.
</p>
<p>
    From: <strong>9</strong>, To: <strong>Q</strong>, <strong>Spades</strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    From: <strong>6</strong>, To: <strong>9</strong>, <strong>Hearts</strong>
</p>
<p>
    <strong></strong>
</p>
<h2>
    6. Greatest Common Divisor
</h2>
<p>
    Write a function that finds the
    <a href="https://en.wikipedia.org/wiki/Greatest_common_divisor">
        greatest common divisor
    </a>
    of two numbers.
</p>
<h3>
    Input
</h3>
<p>
    The input comes as <strong>two number parameters</strong>.
</p>
<h3>
    Output
</h3>
<p>
Print the result in the following format:    <strong>"Greatest Common Divisor: {result}"</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="309" valign="bottom">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="309" valign="bottom">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="309" valign="bottom">
                <p>
                    2154, 458
                </p>
            </td>
            <td width="309" valign="bottom">
                <p>
                    Greatest Common Divisor: 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="309" valign="bottom">
                <p>
                    2000, 1000
                </p>
            </td>
            <td width="309" valign="bottom">
                <p>
                    Greatest Common Divisor: 1000
                </p>
            </td>
        </tr>
        <tr>
            <td width="309" valign="bottom">
                <p>
                    255, 486
                </p>
            </td>
            <td width="309" valign="bottom">
                <p>
                    Greatest Common Divisor: 3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<h2>
    7. Binary Search *
</h2>
<p>
    Write a function that does a
    <a href="https://en.wikipedia.org/wiki/Binary_search_algorithm">
        binary search
    </a>
    in an array and prints a result.
</p>
<h3>
    Input
</h3>
<p>
    You will be given <strong>two parameters</strong>:
</p>
<ul>
    <li>
        A <strong>sorted array with numbers</strong>
    </li>
    <li>
        A <strong>single number</strong> to search for
    </li>
</ul>
<h3>
    Output
</h3>
<p>
If the number <strong>is present</strong> in the array print:    <strong>"Found number {number} at index {index}"</strong>
</p>
<p>
If the number is not present in the array print:    <strong>"The number {number} is not in the array."</strong>
</p>
<p>
    <strong></strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="374" valign="bottom">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="245" valign="bottom">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="374" valign="bottom">
                <p>
                    [10, 11, 15, 23, 25, 32], 15
                </p>
            </td>
            <td width="245" valign="bottom">
                <p>
                    Found 15 at index 2
                </p>
            </td>
        </tr>
        <tr>
            <td width="374" valign="bottom">
                <p>
                    [13, 15, 17, 21, 26, 67, 87, 88, 90], 20
                </p>
            </td>
            <td width="245" valign="bottom">
                <p>
                    20 is not in the array
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<h2>
    8. Hailstone sequence
</h2>
<p>
    Write a function that generates the
    <a href="https://rosettacode.org/wiki/Hailstone_sequence">
        hailstone sequence
    </a>
    starting from a given number.
</p>
<h3>
    Input
</h3>
<p>
    The input comes as a <strong>single number</strong>
</p>
<h3>
    Output
</h3>
<p>
    Print the <strong>sequence on a single line separated by space</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="206" valign="bottom">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="413" valign="bottom">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="206" valign="bottom">
                <p>
                    13
                </p>
            </td>
            <td width="413" valign="bottom">
                <p>
                    13 40 20 10 5 16 8 4 2 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="206" valign="bottom">
                <p>
                    3
                </p>
            </td>
            <td width="413" valign="bottom">
                <p>
                    3 10 5 16 8 4 2 1 4 2 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<h2>
    9. Dot Product **
</h2>
<p>
    Write a function that generates the
    <a href="https://www.mathsisfun.com/algebra/matrix-multiplying.html">
        dot product
    </a>
    of two matrices.
</p>
<h3>
    Input
</h3>
<p>
    The input will come as <strong>two parameters: two matrices</strong>.
</p>
<h3>
    Output
</h3>
<p>
Print each row from the <strong>resulting matrix </strong>in individual    <strong>paragraph element</strong> inside a <strong>div</strong> element
    with <strong>id</strong> “<strong>result</strong>”.
    <br/>
    Look the example below.
</p>
<h3>
    Constrains
</h3>
<p>
You need to write a <strong>transpose </strong>function that transposes    <strong>the second matrix</strong> in order for the calculation of the dot
    product to be possible
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="242" valign="bottom">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="377" valign="bottom">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="242" valign="bottom">
                <p>
                    [[1, 2, 3], [4, 5, 6]] ,
                </p>
                <p>
                    [[7, 9, 11], [8, 10, 12]]
                </p>
            </td>
            <td width="377" valign="bottom">
                <p>
                    58 64
                </p>
                <p>
                    139 154
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>Hints </strong>
</p>
<h2>
    10. Factors
</h2>
<p>
    Write a function to compute all of the <strong>factors</strong> of a given
    number
</p>
<h3>
    Input
</h3>
<p>
    A <strong>single number</strong>
</p>
<h3>
    Output
</h3>
<p>
Print the sequence    <strong>starting from 1 in the format shown in the example</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="242" valign="bottom">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="377" valign="bottom">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="242" valign="bottom">
                <p>
                    15
                </p>
            </td>
            <td width="377" valign="bottom">
                <p>
                    1 3 5 15
                </p>
            </td>
        </tr>
        <tr>
            <td width="242" valign="bottom">
                <p>
                    21
                </p>
            </td>
            <td width="377" valign="bottom">
                <p>
                    1 3 7 21
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong></strong>
</p>
<p>
    <strong>Hints</strong>
</p>