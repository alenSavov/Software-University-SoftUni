<h1>
    Lab: Objects and Classes
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        “Programming Fundamentals” course @ SoftUni
    </a>
    .
</p>
<p>
    You can check your solutions here:
    <a href="https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab">
        https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
    </a>
    .
</p>
<h1>
    I. Using the Built-in .NET Classes
</h1>
<h2>
    1. Day of Week
</h2>
<p>
You are given a <strong>date</strong> in format<strong>day-month-year</strong>. Calculate and print the    <strong>day of week</strong> in <strong>English</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="100" valign="top">
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
            <td width="100">
                <p>
                    18-04-2016
                </p>
            </td>
            <td width="92">
                <p>
                    Monday
                </p>
            </td>
        </tr>
        <tr>
            <td width="100">
                <p>
                    27-11-1996
                </p>
            </td>
            <td width="92">
                <p>
                    Wednesday
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
        <strong>Read the date as string</strong>
        from the Console.
    </li>
    <li>
        Use the method
        <a
            href="https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx"
        >
            <strong>DateTime.ParseExact(string date, </strong>
            <strong>format, </strong>
            <strong>provider)</strong>
        </a>
        to convert the input string to object of type<strong> </strong>
        DateTime. Use format <strong>“</strong>d-M-yyyy<strong>”</strong> and
        CultureInfo.InvariantCulture.
    </li>
</ul>
<p>
    o Alternatively split the input by “-“ and you will get the day, month and
    year as numbers. Now you can create new DateTime(year, month, day).
</p>
<p>
    · The newly created DateTime object has property
    <a
        href="https://msdn.microsoft.com/en-us/library/system.datetime.dayofweek(v=vs.110).aspx"
    >
        <strong>DayOfWeek</strong>
    </a>
    .
</p>
<h2>
    2. Randomize Words
</h2>
<p>
You are given a <strong>list of words in one line</strong>.    <strong>Randomize their order</strong> and print each word at a separate
    line.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="282" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="113" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="293" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="282" valign="top">
                <p>
                    Welcome to SoftUni and have fun learning programming
                </p>
            </td>
            <td width="113" valign="top">
                <p>
                    learning
                </p>
                <p>
                    Welcome
                </p>
                <p>
                    SoftUni
                </p>
                <p>
                    and
                </p>
                <p>
                    fun
                </p>
                <p>
                    programming
                </p>
                <p>
                    have
                </p>
                <p>
                    to
                </p>
            </td>
            <td width="293" valign="top">
                <p>
                    The order of the words in the output will be different
                    after each program execution.
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
        <strong>Split</strong>
the input string by (space) and create an        <strong>array of words</strong>.
    </li>
    <li>
Create a random number generator – an object rnd of type        <strong>Random</strong>.
    </li>
    <li>
        In a<strong> for-loop exchange each number</strong> at positions 0, 1,
        … words.Length-1 by a number at <strong>random position</strong>. To
generate a random number in range<strong> </strong>use        <strong>rnd.</strong>
        <a
            href="https://msdn.microsoft.com/en-us/library/2dx6wyd4(v=vs.110).aspx"
        >
            <strong>Next(minValue, maxValue)</strong>
        </a>
        . Note that by definition minValue is <strong>inclusive</strong>, but
        maxValue is <strong>exclusive</strong>.
    </li>
    <li>
        Print each word in the array on new line.
    </li>
</ul>
<h2>
    3. Big Factorial
</h2>
<p>
    Calculate and print n! (n factorial) for very big integer n (e.g. 1000).
</p>
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
            <td width="536" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="51">
                <p>
                    5
                </p>
            </td>
            <td width="536">
                <p>
                    120
                </p>
            </td>
        </tr>
        <tr>
            <td width="51">
                <p>
                    50
                </p>
            </td>
            <td width="536">
                <p>
                    3041409320171337804361260816606476884437764156896051200000000000
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    Use the class BigInteger<strong> </strong>from the built-in .NET library
    System.Numerics.dll.
</p>
<p>
    1. Add reference to System.Numerics.dll.
</p>
<p>
    2. Import the namespace “System.Numerics”:
</p>
<p>
    3. Use the type BigInteger instead of long or decimal to keep the factorial
    value:
</p>
<h1>
    II. Defining Simple Classes
</h1>
<h2>
    4. Distance Between Points
</h2>
<p>
Write a method to calculate the distance between two points<strong>p<sub>1</sub></strong> {<strong>x<sub>1</sub></strong>,<strong>y<sub>1</sub></strong>} and <strong>p<sub>2</sub></strong> {    <strong>x<sub>2</sub></strong>, <strong>y<sub>2</sub></strong>}. Write a
    program to read <strong>two points</strong> (given as two integers) and
    print the <strong>Euclidean distance</strong> between them.
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
            <td width="68" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="52">
                <p>
                    3 4
                </p>
                <p>
                    6 8
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    5.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="52">
                <p>
                    3 4
                </p>
                <p>
                    5 4
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    2.000
                </p>
            </td>
        </tr>
        <tr>
            <td width="52">
                <p>
                    8 -2
                </p>
                <p>
                    -1 5
                </p>
            </td>
            <td width="68" valign="top">
                <p>
                    11.402
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
        Create a <strong>class </strong>Point holding properties X and Y.
    </li>
</ul>
<p>
    · Write a method CalcDistance(Point p1, Point p2) that returns the distance
    between the given points – a double number.
</p>
<ul>
    <li>
        Use
        <a href="http://www.cut-the-knot.org/pythagoras/DistanceFormula.shtml">
            this formula
        </a>
        to calculate the distance between two points. How it works?
    </li>
</ul>
<p>
o Let's have two points <strong>p<sub>1</sub></strong> {<strong>x<sub>1</sub></strong>, <strong>y<sub>1</sub></strong>} and<strong>p<sub>2</sub></strong> {<strong>x<sub>2</sub></strong>,    <strong>y<sub>2</sub></strong>}
</p>
<p>
    o Draw a right-angled triangle
</p>
<p>
    o Side<strong> a = |x<sub>1</sub> - x<sub>2</sub>|</strong>
</p>
<p>
    o Side<strong> b = |y<sub>1</sub> - y<sub>2</sub>|</strong>
</p>
<p>
    o Distance == side <strong>c</strong> (hypotenuse)
</p>
<p>
o <strong>c<sup>2</sup></strong> = <strong>a<sup>2</sup></strong> +    <strong>b<sup>2</sup></strong> (Pythagorean theorem)
</p>
<p>
    o Distance = <strong>c</strong> =
</p>
<ul>
    <li>
        You can use
        <a
            href="https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.90).aspx"
        >
            <strong>Math.Sqrt(number)</strong>
        </a>
        method for calculating a square root.
    </li>
</ul>
<h2>
    5. Closest Two Points
</h2>
<p>
Write a program to read <strong>n </strong>points and find the    <strong>closest two</strong> of them.
</p>
<h3>
    Input
</h3>
<p>
    The <strong>input</strong> holds the number of points n and n lines, each
    holding a point {X and Y coordinate}.
</p>
<h3>
    Output
</h3>
<ul>
    <li>
        The <strong>output</strong> holds the shortest distance and the closest
        two points.
    </li>
</ul>
<p>
· If several pairs of points are equally close, print    <strong>the first</strong> of them (from top to bottom).
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="68" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="76" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="251" valign="top">
                <p align="center">
                    <strong>Visualization</strong>
                </p>
            </td>
            <td width="293" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p>
                    4
                </p>
                <p>
                    3 4
                </p>
                <p>
                    6 8
                </p>
                <p>
                    2 5
                </p>
                <p>
                    -1 3
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    1.414
                </p>
                <p>
                    (3, 4)
                </p>
                <p>
                    (2, 5)
                </p>
            </td>
            <td width="251" valign="top">
            </td>
            <td width="293" valign="top">
                <p>
The closest two points are <strong>{3, 4}</strong> and<strong>{2, 5}</strong> at distance 1.4142135623731 ≈                    <strong>1.414</strong>.
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p>
                    3
                </p>
                <p>
                    12 -30
                </p>
                <p>
                    6 18
                </p>
                <p>
                    6 18
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    0.000
                </p>
                <p>
                    (6, 18)
                </p>
                <p>
                    (6, 18)
                </p>
            </td>
            <td width="251" valign="top">
            </td>
            <td width="293" valign="top">
                <p>
Two of the points have the same coordinates<strong>{6, 18}</strong>, so the distance between them is                    <strong>0</strong>.
                </p>
            </td>
        </tr>
        <tr>
            <td width="68" valign="top">
                <p>
                    3
                </p>
                <p>
                    1 1
                </p>
                <p>
                    2 2
                </p>
                <p>
                    3 3
                </p>
            </td>
            <td width="76" valign="top">
                <p>
                    1.414
                </p>
                <p>
                    (1, 1)
                </p>
                <p>
                    (2, 2)
                </p>
            </td>
            <td width="251" valign="top">
            </td>
            <td width="293" valign="top">
                <p>
                    The pairs of points {{1, 1}, {2, 2}} and {{2,2}, {3,3}}
stay at the same distance, but the first pair is {                    <strong>{1, 1}</strong>, <strong>{2, 2}</strong>}. The
distance between them is 1.4142135623731 ≈                    <strong>1.414</strong>.
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
        Use the <strong>class</strong> Point you created in the previous task.
    </li>
    <li>
        Create an array Point[]<strong> </strong>points that will keep all
        points.
    </li>
    <li>
        Create a method Point[]<strong> </strong>FindClosestPoints(Point[]
points) that will check distance        <strong>between every two pairs </strong>from the array of points and
        returns the two closest points in a new array.
    </li>
    <li>
Print the <strong>closest distance</strong> and the        <strong>coordinates</strong> of the two closest points.
    </li>
</ul>
<h2>
    6. Rectangle Position
</h2>
<p>
    Write a program to <strong>read two rectangles</strong> {left, top, width,
    height} and print whether the first is inside the second.
</p>
<p>
    The input is given as two lines, each holding a rectangle, described by 4
integers: <strong>left</strong>, <strong>top</strong>,    <strong>width</strong> and <strong>height</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="92" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="239" valign="top">
                <p align="center">
                    <strong>Visualization</strong>
                </p>
            </td>
            <td width="266" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    4 -3 6 4
                </p>
                <p>
                    2 -3 10 6
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    Inside
                </p>
            </td>
            <td width="239" valign="top">
            </td>
            <td width="266" valign="top">
                <p>
                    The first rectangle stays <strong>inside</strong> the
                    second.
                </p>
            </td>
        </tr>
        <tr>
            <td width="92" valign="top">
                <p>
                    2 -3 10 6
                </p>
                <p>
                    4 -5 6 10
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    Not inside
                </p>
            </td>
            <td width="239" valign="top">
            </td>
            <td width="266" valign="top">
                <p>
The rectangles intersect, no the first is                    <strong>not insid</strong>e the second.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Create a class Rectangle holding properties Top, Left, Width and Height.
</p>
<ul>
    <li>
        Define calculated properties Right and Bottom.
    </li>
</ul>
<p>
    · Define a method bool IsInside(Rectangle r). A rectangle r1 is inside
    another rectangle r2 when:
</p>
<p>
    o r1.Left ≥ r2.Left
</p>
<p>
    o r1.Right ≤ r2.Right
</p>
<p>
    o r1.Top ≤ r2.Top
</p>
<p>
    o r1.Bottom ≤ r2.Bottom
</p>
<ul>
    <li>
        Create a method to <strong>read</strong> a Rectangle.
    </li>
    <li>
        Combine all methods into a single program.
    </li>
</ul>
<h2>
    7. Sales Report
</h2>
<p>
Write a class Sale holding the following data: <strong>town</strong>,    <strong>product</strong>, <strong>price</strong>, <strong>quantity</strong>
. Read a <strong>list of sales</strong> and calculate and print the<strong>total sales by town</strong> as shown in the output. Order    <strong>alphabetically</strong> the towns in the output.
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
            <td width="148" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="335" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205">
                <p>
                    5
                </p>
                <p>
                    Sofia beer 1.20 160
                </p>
                <p>
                    Varna chocolate 2.35 86
                </p>
                <p>
                    Sofia coffee 0.40 853
                </p>
                <p>
                    Varna apple 0.86 75.44
                </p>
                <p>
                    Plovdiv beer 1.10 88
                </p>
            </td>
            <td width="148" valign="top">
                <p>
                    Plovdiv -&gt; 96.80
                </p>
                <p>
                    Sofia -&gt; 533.20
                </p>
                <p>
                    Varna -&gt; 266.98
                </p>
            </td>
            <td width="335" valign="top">
                <p>
                    Plovdiv -&gt; 1.10 * 88 = 96.80
                </p>
                <p>
                    Sofia -&gt; 1.20 * 160 + 0.40 * 853 = 533.20
                </p>
                <p>
                    Varna -&gt; 2.35 * 86 + 0.86 * 75.44 = 266.98
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Define the class Sale holding properties Town, Product, Price and
    Quantity.
</p>
<p>
    · Create a method ReadSale() that reads a sale data line from the console
    and returns Sale object. It could split the input line by space and parse
    the price and quantity.
</p>
<ul>
    <li>
        To read the input, first read an integer n, then n times read a sale.
    </li>
    <li>
        <strong>Approach I – LINQ</strong>
    </li>
</ul>
<p>
o Using <strong>LINQ</strong> select the    <strong>distinct town names</strong> from the array of sales and sort them.
</p>
<p>
    o For <strong>each town</strong> in a loop use a LINQ query to calculate
the <strong>total sales</strong> (aggregate the sum of    <strong>price</strong> * <strong>quantity</strong> for all sales by the
    current town).
</p>
<ul>
    <li>
        <strong>Approach II – Dictionary {town </strong>
        <strong>à sales}</strong>
    </li>
</ul>
<p>
    o Define a dictionary SortedDictionary&lt;string, decimal&gt; salesByTown
    to hold the total sales for each town.
</p>
<p>
    o Pass through all the sales from the input in a loop and for each sale,
    add its <strong>price</strong> * <strong>quantity</strong> to the
    salesByTown for the current town. If the town is missing in the dictionary,
    first create it.
</p>
<p>
    o Finally print the dictionary.
</p>
<p>
    · The second approach is faster, because it scans the array of sales only
    once.
</p>