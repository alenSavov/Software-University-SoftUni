<h1>
    Exercise: JavaScript Syntax and Operators
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/trainings/2247/js-fundamentals-january-2019">
        "JavaScript Fundamentals" course @ SoftUni
    </a>
    <br/>
    Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/Practice/Index/1422">
        https://judge.softuni.bg/Contests/Practice/Index/1422
    </a>
</p>
<h2>
    1. I like JavaScript!
</h2>
<p>
    Write a JS function that <strong>can receive a name</strong> as input and
    print a greeting to the console.
</p>
<p>
    The <strong>input</strong> comes as a single string that is the name of the
    person.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="148" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="390" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="148" valign="top">
                <p>
                    'George'
                </p>
            </td>
            <td width="390">
                <p>
                    Hello George, do you like JavaScript?
                </p>
            </td>
        </tr>
        <tr>
            <td width="148" valign="top">
                <p>
                    'Maria'
                </p>
            </td>
            <td width="390">
                <p>
                    Hello Maria, do you like JavaScript?
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Even Numbers 1 to N
</h2>
<p>
Write a JS function that reads an integer <strong>n</strong> and prints all    <strong>even numbers</strong> from <strong>1</strong> to <strong>n</strong>
    .
</p>
<p>
    The <strong>input</strong> comes as a <strong>single number n</strong>. The
    number <strong>n</strong> will be an integer in the range
    <br/>
    [1 … 100 000].
</p>
<p>
    The <strong>output</strong> should hold the expected even numbers, each at
    a separate line.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="51" valign="top">
                <p>
                    7
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
                <p>
                    4
                </p>
                <p>
                    6
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Fruit
</h2>
<p>
    Write a JS function that calculates how much money you need to buy a fruit.
    You will receive a <strong>string</strong> for the type of fruit you want
to buy, <strong>a number</strong> for weight in grams and another    <strong>number</strong> for a price per kilogram.
</p>
<p>
Print the following text on the console:    <strong>'I need {money} leva to buy {weight} kilograms {fruit}.'</strong> .
    Print the weight and the money <strong>rounded</strong> to two decimal
    places.
</p>
<p>
    The <strong>input</strong> comes as <strong>three arguments</strong> passed
    to your function.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="206" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="463" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="206" valign="top">
                <p>
                    'orange', 2500, 1.80
                </p>
            </td>
            <td width="463">
                <p>
                    I need 4.50 leva to buy 2.50 kilograms orange.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="206" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="463" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="206" valign="top">
                <p>
                    'apple', 1563, 2.35
                </p>
            </td>
            <td width="463">
                <p>
                    I need 3.67 leva to buy 1.56 kilograms apple.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Fitness Rates
</h2>
<p>
    Write a JS function that calculates how much money you need to visit your
    favorite gym. You will receive <strong>two strings</strong> for a day of
    week and a service which you want to use and a <strong>number</strong> for
    the time in which you can go to the gym.
</p>
<p>
    In the table below you can find information about the prices and services
    offered at the gym.
</p>
<table border="0" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Service </strong>
                </p>
            </td>
            <td width="180" nowrap="" colspan="2" valign="bottom">
                <p align="center">
                    <strong>Fitness</strong>
                </p>
            </td>
            <td width="198" nowrap="" colspan="2" valign="bottom">
                <p align="center">
                    <strong>Sauna</strong>
                </p>
            </td>
            <td width="180" nowrap="" colspan="2" valign="bottom">
                <p align="center">
                    <strong>Instructor</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Hours</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    8.00-15.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    15.00-22.00
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    8.00-15.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    15.00-22.00
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    8.00-15.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    15.00-22.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Monday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    5.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    7.50
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    4.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    6.50
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    10.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    12.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Tuesday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    5.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    7.50
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    4.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    6.50
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    10.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    12.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Wednesday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    5.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    7.50
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    4.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    6.50
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    10.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    12.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Thursday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    5.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    7.50
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    4.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    6.50
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    10.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    12.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Friday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    5.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    7.50
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    4.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    6.50
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    10.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    12.50
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Saturday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    8.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    8.00
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    7.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    7.00
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    15.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    15.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="94" nowrap="" valign="bottom">
                <p align="center">
                    <strong>Sunday</strong>
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    8.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    8.00
                </p>
            </td>
            <td width="104" nowrap="" valign="bottom">
                <p align="right">
                    7.00
                </p>
            </td>
            <td width="95" nowrap="" valign="bottom">
                <p align="right">
                    7.00
                </p>
            </td>
            <td width="85" nowrap="" valign="bottom">
                <p align="right">
                    15.00
                </p>
            </td>
            <td width="94" nowrap="" valign="bottom">
                <p align="right">
                    15.00
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Example: If you want to go to the gym on Monday at 15 o`clock and use the
    sauna you have to pay 6.50 leva.
</p>
<p>
    The <strong>input</strong> comes as <strong>three arguments</strong> passed
    to your function.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="255" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    'Monday', 'Sauna', 15.30
                </p>
            </td>
            <td width="104">
                <p>
                    6.5
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="255" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="104" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="255" valign="top">
                <p>
                    'Sunday', 'Fitness', 22.00
                </p>
            </td>
            <td width="104">
                <p>
                    8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Greatest Common Divisor – GCD
</h2>
<pre>Write a JS function that takes <strong>two</strong> <strong>positive</strong> <strong>numbers</strong> as input and compute the greatest common divisor.    </pre>
<pre>Print on the console the result. </pre>
<p>
The <strong>input</strong> comes    <strong>as two positive integer numbers</strong>.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="159" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="144" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="163" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="123" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="159" valign="top">
                <p>
                    15, 5
                </p>
            </td>
            <td width="144">
                <p>
                    5
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="163" valign="top">
                <p>
                    2154, 458
                </p>
            </td>
            <td width="123" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Same Numbers
</h2>
<pre>Write a JS function that takes <strong>an integer</strong> <strong>number</strong> as input and check if all the digits in a given number are the same or not.</pre>
<pre>Print on the console <strong>true</strong> if all numbers are same or <strong>false</strong> if not. On the next line print the <strong>sum of all the digits.</strong></pre>
<p>
    The <strong>input</strong> comes as an integer number.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="149" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="153" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="173" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="130" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    2222222
                </p>
            </td>
            <td width="153">
                <p>
                    true
                </p>
                <p>
                    14
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="173" valign="top">
                <p>
                    1234
                </p>
            </td>
            <td width="130" valign="top">
                <p>
                    false
                </p>
                <p>
                    10
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Time to Walk
</h2>
<p>
    Write a JS function that <strong>calculates</strong> how long it takes a
    student to get to the university.
    <br/>
    The function takes <strong>three numbers</strong>:
</p>
<ul>
    <li>
        The <strong>first</strong> is the number of <strong>steps</strong> the
        student makes from his home to the university
    </li>
    <li>
        Тhe <strong>second</strong> number is the length of the student's
        footprint in <strong>meters</strong>
    </li>
    <li>
Тhe <strong>third</strong> number is the student speed in        <strong>km/h</strong>
    </li>
</ul>
<p>
Sometimes the student needs a rest. Every 500 meters, the person makes a    <strong>1 minute break</strong>.
</p>
<p>
    Calculate how long the student goes from home to university and print on
    the console the result as follows: <strong>'hours:minutes:seconds'</strong>
    .
</p>
<p>
    The <strong>input</strong> comes as <strong>three numbers</strong>.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="149" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="153" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="173" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="130" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="149" valign="top">
                <p>
                    4000, 0.60, 5
                </p>
            </td>
            <td width="153">
                <p>
                    00:32:48
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="173" valign="top">
                <p>
                    2564, 0.70, 5.5
                </p>
            </td>
            <td width="130" valign="top">
                <p>
                    00:22:35
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Flight Timetable
</h2>
<p>
    Write a JS function that displays flight information.
</p>
<p>
The <strong>input</strong> comes as an    <strong>array of string elements</strong>.
</p>
<p>
· The first string can be <strong>'Arrivals' </strong>or    <strong>'Departures'</strong>
</p>
<p>
    · The second string is the <strong>name</strong> of the town
</p>
<ul>
    <li>
        The third is the <strong>time</strong> when the plain departures or
        arrives
    </li>
    <li>
        The fourth is the <strong>flight number</strong>
    </li>
</ul>
<p>
    · The last one is the <strong>gate number</strong>
</p>
<p>
    The <strong>output</strong> should be printed to the console in the
    following format:
</p>
<p>
    “Departures/Arrivals: Destination - {town}, Flight - {flight number}, Time
    - {departure/arrival time}, Gate - {gate number}”
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="301" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="359" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="301" valign="top">
                <p>
                    ['Departures', 'London', '22:45', 'BR117', '42']
                </p>
            </td>
            <td width="359">
                <p>
                    Departures: Destination – London, Flight – BR117, Time –
                    22:45, Gate - 42
                </p>
            </td>
        </tr>
        <tr>
            <td width="301" valign="top">
                <p>
                    ['Arrivals', 'Paris', '02:22', 'VD17', '3']
                </p>
            </td>
            <td width="359">
                <p>
                    Arrivals: Destination – Paris,
                </p>
                <p>
                    Flight – VD17, Time – 02:22, Gate - 3
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Calorie Object
</h2>
<p>
    Write a JS function that composes an object by given properties. Every even
    index of the array is the string and the name of the food. Every odd index
    is a number that is equal to the calories in 100 grams of product. Assign
    each value to its respective property of an object and print it on the
    console.
</p>
<p>
The <strong>input</strong> comes as an <strong>array of string</strong>    <strong>elements</strong>.
</p>
<p>
    The <strong>output</strong> should be printed to the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="319" valign="top">
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
            <td width="319" valign="top">
                <p>
                    ['Yoghurt', 48, 'Rise', 138, 'Apple', 52]
                </p>
            </td>
            <td width="340">
                <p>
                    { Yoghurt: 48, Rise: 138, Apple: 52 }
                </p>
            </td>
        </tr>
        <tr>
            <td width="319" valign="top">
                <p>
                    ['Potato', 93, 'Skyr', 63, 'Cucumber', 18, 'Milk', 42]
                </p>
            </td>
            <td width="340">
                <p>
                    { Potato: 93, Skyr: 63, Cucumber: 18, Milk: 42 }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. *Coffee Machine
</h2>
<p>
    Write a program for a coffee machine. Calculate whether the money inserted
    in the machine is enough to make the order and print the corresponding
    output.
    <br/>
    <br/>
</p>
<h3>
    Input
</h3>
<p>
    The input is an <strong>array of strings</strong>. Each string represents
one order with different parts, separated by a single space    <strong>' '</strong>.
</p>
<ul>
    <li>
        The <strong>first part</strong> is the <strong>coins inserted</strong>.
    </li>
    <li>
The <strong>second</strong> is the <strong>type of drink </strong>(        <strong>coffee or tea</strong>).
    </li>
    <li>
Next, if the drink type is <strong>coffee</strong>, you will receive        <strong>'caffeine'</strong> or <strong>'decaf'</strong>.
    </li>
    <li>
        Next, you may receive <strong>'milk', </strong>if the ordered drink is
with milk. <strong>It costs</strong>        <strong>10% of the drink price, rounded to first decimal point</strong>
    </li>
    <li>
And <strong>last</strong> you receive the        <strong>quantity of sugar, between 0 and 5</strong>.
        <strong>
            No matter the quantity (except from 0) it costs 0.10. Add the sugar
            at the end!
        </strong>
    </li>
</ul>
<p>
    The <strong>prices of drinks</strong> are:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="162" valign="top">
                <p align="center">
                    <strong>Type</strong>
                </p>
            </td>
            <td width="138" valign="top">
                <p align="center">
                    <strong>Price</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="162" valign="top">
                <p align="center">
                    coffee caffeine
                </p>
            </td>
            <td width="138" valign="top">
                <p align="center">
                    0.80
                </p>
            </td>
        </tr>
        <tr>
            <td width="162" valign="top">
                <p align="center">
                    coffee decaf
                </p>
            </td>
            <td width="138" valign="top">
                <p align="center">
                    0.90
                </p>
            </td>
        </tr>
        <tr>
            <td width="162" valign="top">
                <p align="center">
                    tea
                </p>
            </td>
            <td width="138" valign="top">
                <p align="center">
                    0.80
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Constrains
</h3>
<p>
    · The input will always be <strong>valid.</strong>
</p>
<h3>
    Output
</h3>
<p>
    For each order there are <strong>two possible</strong> outputs:
</p>
<ul>
    <li>
        If the money inserted is enough, calculate the change of the order:
    </li>
</ul>
<p>
    <strong>'You ordered {drink}. Price: {price}$ Change: {change}$'</strong>
</p>
<ul>
    <li>
        If the money is not enough:
    </li>
</ul>
<p>
    <strong>
        'Not enough money for {drink}. Need {moneyNeeded}$ more'
        <br/>
        <br/>
    </strong>
</p>
<p>
    After proceeding all orders, print the <strong>total money earned</strong>
from the <strong>successful</strong> orders in the format:    <strong>'Income Report: {totalMoney}$'</strong>
</p>
<p>
All of the numbers should be    <strong>formatted to the second decimal point</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="296" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="432" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="296" valign="top">
                <p>
                    ['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2',
                </p>
                <p>
                    '1.00, coffee, decaf, 0']
                </p>
            </td>
            <td width="432" valign="top">
                <p>
                    You ordered coffee. Price: 1.00$ Change: 0.00$
                </p>
                <p>
                    Not enough money for tea. Need 0.60$ more.
                </p>
                <p>
                    You ordered coffee. Price: 0.90$ Change: 0.10$
                </p>
                <p>
                    Income Report: 1.90$
                </p>
            </td>
        </tr>
        <tr>
            <td width="728" colspan="2" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="728" colspan="2" valign="top">
                <p>
                    The first order is coffee with caffeine, milk and sugar.
                    The price of the drink is 0.80$, we calculate the milk, 10%
                    of the price, rounded to the first decimal point - 0.1$,
                    and we add the sugar =&gt; 0.80 + 0.10 + 0.10 = 1.00.
                </p>
                <p>
                    The second order is tea with milk and sugar (0.80 + 0.10 +
                    0.10 = 1.00), but the money inserted is not enough.
                </p>
                <p>
                    Next, we receive order for coffee decaf with no milk and 0
                    sugar =&gt; 0.90$. The change is 0.10$.
                </p>
                <p>
                    Total income = 1.90
                </p>
            </td>
        </tr>
        <tr>
            <td width="296" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="432" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="296" valign="top">
                <p>
                    ['8.00, coffee, decaf, 4',
                </p>
                <p>
                    '1.00, tea, 2']
                </p>
            </td>
            <td width="432" valign="top">
                <p>
                    You ordered coffee. Price: 1.00$ Change: 7.00$
                </p>
                <p>
                    You ordered tea. Price: 0.90$ Change: 0.10$
                </p>
                <p>
                    Income Report: 1.90$
                </p>
            </td>
        </tr>
    </tbody>
</table>