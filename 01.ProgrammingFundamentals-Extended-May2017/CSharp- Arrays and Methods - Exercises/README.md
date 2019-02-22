<h1>
    Exercises: Arrays and Methods
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
    <a href="https://judge.softuni.bg/Contests/Practice/Index/418">
        https://judge.softuni.bg/Contests/Practice/Index/418
    </a>
    .
</p>
<h2>
    1. Hello, Name!
</h2>
<p>
Write a <strong>method</strong> that receives a name as    <strong>parameter</strong> and prints on the console. “Hello,
    &lt;name&gt;!”
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
            <td width="124" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="52" valign="top">
                <p>
                    Peter
                </p>
            </td>
            <td width="124">
                <p>
                    Hello, Peter!
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Min Method
</h2>
<p>
Create a GetMin(int a, int b) method, that returns the    <strong>smaller</strong> of two numbers. Write a program that reads three
    numbers from the console and prints the <strong>smallest</strong> of them.
    Use the GetMin(…) method you just created.
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
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="24" valign="top">
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
                    1
                </p>
                <p>
                    2
                </p>
                <p>
                    3
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    1
                </p>
            </td>
            <td width="24" valign="top">
            </td>
            <td width="51" valign="top">
                <p>
                    -100
                </p>
                <p>
                    -101
                </p>
                <p>
                    -102
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    -102
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. String Repeater
</h2>
<p>
    Write a <strong>RepeatString(str, count)</strong><strong> </strong>method
that receives a <strong>string</strong> and an <strong>integer</strong><strong>N</strong> as <strong>parameters</strong> and returns the string,    <strong>repeated</strong> <strong>N</strong> times. After that, print the
    result on the console.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="564" valign="top">
                <p>
                    static string RepeatString(string str, int count)
                </p>
                <p>
                    {
                </p>
                <p>
                    string repeatedString = string.Empty;
                </p>
                <p>
                    for (int i = 0; i &lt; count; i++)
                </p>
                <p>
                    {
                </p>
                <p>
                    // TODO
                </p>
                <p>
                    }
                </p>
                <p>
                    return repeatedString;
                </p>
                <p>
                    }
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
            <td width="49" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="140" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="52" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="213" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="49" valign="top">
                <p>
                    str
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="140" valign="top">
                <p>
                    strstr
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    roki
                </p>
                <p>
                    6
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    rokirokirokirokirokiroki
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Nth Digit
</h2>
<p>
Write a <strong>method</strong> FindNthDigit(number, index) that receives a<strong>number</strong> and an <strong>index N</strong> as    <strong>parameters</strong> and returns the <strong>Nth digit</strong> of
the number (counted from <strong>right to left</strong>, starting from    <strong>1</strong>). After that, <strong>print</strong> the result on the
    console.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="564" valign="top">
                <p>
                    static int FindNthDigit(long number, int index)
                </p>
                <p>
                    {
                </p>
                <p>
                    …
                </p>
                <p>
                    }
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
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="61" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="52" valign="top">
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
            <td width="60" valign="top">
                <p>
                    83746
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    4
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    93847837
                </p>
                <p>
                    6
                </p>
            </td>
            <td width="61" valign="top">
                <p>
                    8
                </p>
            </td>
            <td width="52" valign="top">
                <p>
                    2435
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
· Use a while loop to perform the algorithm until the given number becomes    <strong>0</strong>.
</p>
<p>
· On every iteration of the while loop, check if the<strong>current index</strong> of the number equals the    <strong>index</strong> you are looking for. If it is, return the number at
that index (number % 10). If it’s not the correct index,    <strong>remove</strong> the last digit from the number (number / 10).
</p>
<ul>
    <li>
Keep track of which <strong>digit</strong> you are checking by<strong>index</strong> (<strong>right to left</strong>, starting from<strong>1</strong>). When you <strong>find</strong> the digit,        <strong>return </strong>that <strong>index</strong>.
    </li>
</ul>
<h2>
    5. Integer to Base
</h2>
<p>
Write a <strong>method</strong><strong>IntegerToBase(number, toBase)</strong> that receives a<strong>number</strong> and a <strong>base</strong> as<strong>parameters</strong> and returns the number,    <strong>converted </strong>to that<strong> number base.</strong> After
    that, <strong>print</strong> the result on the console.
</p>
<p>
The <strong>number</strong> will <strong>always</strong> be in<strong>base 10</strong> and the <strong>base</strong> parameter will    <strong>always</strong> be <strong>between 2 and 10</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    static string IntegerToBase(long number, int toBase)
                </p>
                <p>
                    {
                </p>
                <p>
                    …
                </p>
                <p>
                    }
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
            <td width="66" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="84" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="62" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="84" valign="top">
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
            <td width="66" valign="top">
                <p>
                    3
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    11
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    4
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    10
                </p>
            </td>
            <td width="84" valign="top">
                <p>
                    9
                </p>
                <p>
                    7
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    12
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
        Declare a variable where the <strong>result</strong> will be stored.
    </li>
</ul>
<p>
    · Perform the calculations, needed to convert the number:
</p>
<p>
    o Take the <strong>remainder</strong> of the <strong>number</strong>,
    divided by the <strong>base.</strong>
</p>
<p>
    o Add the <strong>remainder</strong> to the <strong>front</strong> of the
    result string.
</p>
<p>
    o Divide the <strong>number</strong> by the <strong>base</strong>
</p>
<p>
o The above algorithm should run <strong>until</strong> the number is    <strong>0</strong>
</p>
<h2>
    6. Notifications
</h2>
<p>
    Write 2 methods:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    static string ShowSuccess(string operation, string message)
                </p>
                <p>
                    {
                </p>
                <p>
                    …
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    which prints a message in the following format:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    Successfully executed {operation}.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Message: {message}.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    and
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    static string ShowError(string operation, int code)
                </p>
                <p>
                    {
                </p>
                <p>
                    …
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    which prints a message in the following format:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    Error: Failed to execute {operation}.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Error Code: {code}.
                </p>
                <p>
                    Reason: {reason}.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    The <strong>reason</strong> is determined by the <strong>code</strong>:
</p>
<ul>
    <li>
        If the code is <strong>positive</strong>, the reason is "Invalid Client
        Data"
    </li>
    <li>
        If the code is <strong>negative</strong>, the reason is "Internal
        System Failure"
    </li>
</ul>
<p>
    Then, create a program which accepts an integer <strong>N</strong>.
</p>
<p>
On the next <strong>N</strong> lines, the user receives a    <strong>result</strong> – "success" or "error". If the current operation is
success, it should prompt the user for an <strong>operation</strong> and a    <strong>message</strong>. If the operation is error, it should prompt the
    user for an operation and a code.
</p>
<p>
    If neither "success", nor "error" is given, <strong>nothing</strong> should
    be printed and the program should <strong>continue</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
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
            <td width="245" valign="top">
                <p>
                    2
                </p>
                <p>
                    success
                </p>
                <p>
                    User registration
                </p>
                <p>
                    User registered successfully
                </p>
                <p>
                    error
                </p>
                <p>
                    connecting to server
                </p>
                <p>
                    -403
                </p>
            </td>
            <td width="390" valign="top">
                <p>
                    Successfully executed User registration.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Message: User registered successfully.
                </p>
                <p>
                    Error: Failed to execute connecting to server.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Error Code: -403.
                </p>
                <p>
                    Reason: Internal System Failure.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="245" valign="top">
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
            <td width="245" valign="top">
                <p>
                    3
                </p>
                <p>
                    success
                </p>
                <p>
                    Database query
                </p>
                <p>
                    Updated 2 rows
                </p>
                <p>
                    warning
                </p>
                <p>
                    error
                </p>
                <p>
                    credit card purchase
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="390" valign="top">
                <p>
                    Successfully executed Database query.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Message: Updated 2 rows.
                </p>
                <p>
                    Error: Failed to execute credit card purchase.
                </p>
                <p>
                    ==============================
                </p>
                <p>
                    Error Code: 2.
                </p>
                <p>
                    Reason: Invalid Client Data.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. * Numbers to Words
</h2>
<p>
Write a method Letterize(number) which accepts a number and prints it as    <strong>words</strong>, according to these conditions:
</p>
<p>
    · If the number is more than 999 you should print – "too large"
</p>
<p>
    · If the number is less than -999 you should print – "too small"
</p>
<p>
    · If the number is negative, you should print "minus" before it.
</p>
<ul>
    <li>
If the number does <strong>not</strong> have 3 digits,        <strong>do not</strong> print it
    </li>
</ul>
<p>
The program should accept an integer <strong>N. </strong>On the next    <strong>N lines,</strong> you should accept <strong>numbers</strong> and
    print them as <strong>words</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="253" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="237" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="60" valign="top">
                <p>
                    3
                </p>
                <p>
                    999
                </p>
                <p>
                    -420
                </p>
                <p>
                    1020
                </p>
            </td>
            <td width="253" valign="top">
                <p>
                    nine-hundred and ninety nine
                </p>
                <p>
                    minus four-hundred and twenty
                </p>
                <p>
                    too large
                </p>
            </td>
            <td width="51" valign="top">
                <p>
                    2
                </p>
                <p>
                    15
                </p>
                <p>
                    350
                </p>
            </td>
            <td width="237" valign="top">
                <p>
                    three-hundred and fifty
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="60" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="253" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="13" rowspan="2" valign="top">
                <p align="center">
                    <strong></strong>
                </p>
            </td>
            <td width="51" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="245" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="60" valign="top">
                <p>
                    4
                </p>
                <p>
                    311
                </p>
                <p>
                    418
                </p>
                <p>
                    519
                </p>
                <p>
                    -9945
                </p>
            </td>
            <td width="253" valign="top">
                <p>
                    three-hundred and eleven
                </p>
                <p>
                    four-hundred and eighteen
                </p>
                <p>
                    five-hundred and nineteen
                </p>
                <p>
                    too small
                </p>
            </td>
            <td width="51" valign="top">
                <p>
                    2
                </p>
                <p>
                    500
                </p>
                <p>
                    123
                </p>
            </td>
            <td width="245" valign="top">
                <p>
                    five-hundred
                </p>
                <p>
                    one-hundred and twenty three
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
· The first set of special cases comes when a number’s right on the    <strong>hundreds</strong> (i.e. 100, 200, 300, etc.). Print them like this:
    “one-hundred”, “two-hundred”, “three-hundred”.
</p>
<p>
· The second set of special cases comes when a number’s last 2 digits are    <strong>less than 10</strong> (i.e. 101, 305, 609, etc.). Print them like
    this: “one-hundred and one”, “three-hundred and five”, “six-hundred and
    nine”
</p>
<p>
· The third set of special cases comes when a number is in the    <strong>teens</strong> (i.e. <strong>111, 814, 919</strong>). Print them
    like this: “one-hundred and eleven”, “eight-hundred and fourteen”,
    “nine-hundred and nineteen”
</p>
<h2>
    8. * String Encryption
</h2>
<p>
    Write a method Encrypt(char letter) which encrypts the letter in the
    following way:
</p>
<ul>
    <li>
        Take the first and the last digit of its <strong>ASCII</strong> code
        and append them together in a string.
    </li>
    <li>
Append at the <strong>start</strong> of the resulting string the        <strong>character corresponding to</strong>:
    </li>
</ul>
<p>
o the <strong>ASCII code</strong> of the letter <strong>+</strong> the    <strong>last digit</strong> of the <strong>ASCII code</strong> of the
    letter
</p>
<ul>
    <li>
Then append at the <strong>end</strong> of the resulting string the        <strong>character corresponding to</strong>:
    </li>
</ul>
<p>
o the <strong>ASCII code</strong> of the letter <strong>-</strong> the    <strong>first digit</strong> of the <strong>ASCII code</strong> of the
    letter
</p>
<ul>
    <li>
        The method should return the encrypted string.
    </li>
</ul>
<p>
    Example
</p>
<ul>
    <li>
        j -&gt; p16i
    </li>
</ul>
<p>
o j’s ASCII code is <strong>106 </strong><strong>è </strong>First digit –    <strong>1</strong>, last digit – <strong>6</strong>
</p>
<p>
    o Append the first and last digit è <strong>16</strong>
</p>
<p>
o Append the character, resulting from the ASCII code + last digit to the    <strong>start</strong> è 106 + 6 è 112 è p
</p>
<p>
o Append the character, resulting from the ASCII code - first digit to the    <strong>end</strong> è 106 - 1 è 105 è i
</p>
<p>
    o End result è p16i
</p>
<p>
    Assume that the input for this method will <strong>always</strong> be
    valid.
</p>
<p>
The main program should read an input from the user - an integer    <strong>N</strong>.
</p>
<p>
On the next <strong>N lines,</strong> you will receive<strong>characters</strong>. <strong>Encrypt</strong> them and    <strong>append </strong>them to an <strong>encrypted string</strong>.
</p>
<p>
In the end, what you should have is a long    <strong>encrypted string</strong> of characters like this:
</p>
<p>
    · S, o, f, t, U, n, i è V83Kp11nh12ez16sZ85Mn10mn15h
</p>
<p>
Your task is to <strong>print</strong> the    <strong>encrypted string.</strong>
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
            <td width="308" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    7
                </p>
                <p>
                    S
                </p>
                <p>
                    o
                </p>
                <p>
                    f
                </p>
                <p>
                    t
                </p>
                <p>
                    U
                </p>
                <p>
                    n
                </p>
                <p>
                    i
                </p>
            </td>
            <td width="308" valign="top">
                <p>
                    V83Kp11nh12ez16sZ85Mn10mn15h
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="82" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="278" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="82" valign="top">
                <p>
                    7
                </p>
                <p>
                    B
                </p>
                <p>
                    i
                </p>
                <p>
                    r
                </p>
                <p>
                    a
                </p>
                <p>
                    H
                </p>
                <p>
                    a
                </p>
                <p>
                    x
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    H66&lt;n15hv14qh97XJ72Ah97Xx10w
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
        Start with an empty <strong>result</strong> string – use string.Empty.
    </li>
    <li>
Loop <strong>n</strong> times and each time <strong>append</strong> the        <strong>encrypted character</strong> to the result string.
    </li>
    <li>
        To get the <strong>first</strong> and <strong>last</strong> digits of
        the <strong>ASCII</strong> code, use the same algorithm as the one
        you’d use to solve the <strong>Integer to Base</strong> problem.
    </li>
</ul>
<h2>
    9. Largest Element in Array
</h2>
<p>
    Read an integer <strong>N</strong> and on the next <strong>N</strong> lines
read an <strong>array</strong> of <strong>integers.</strong> Then, find its    <strong>largest</strong> element.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="243" valign="top">
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
            <td width="243" valign="top">
                <p>
                    4
                </p>
                <p>
                    5
                </p>
                <p>
                    6
                </p>
                <p>
                    8
                </p>
                <p>
                    7
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    8
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    3
                </p>
                <p>
                    -2
                </p>
                <p>
                    -18
                </p>
                <p>
                    -5348
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    -2
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    6
                </p>
                <p>
                    2
                </p>
                <p>
                    2
                </p>
                <p>
                    2
                </p>
                <p>
                    2
                </p>
                <p>
                    2
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Count of Negative Elements in Array
</h2>
<p>
    Read an integer <strong>N</strong> and on the next <strong>N</strong> lines
read an <strong>array</strong> of <strong>integers.</strong> Then, find the    <strong>count</strong> of <strong>negative</strong> elements in the array.
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
                <p>
                    1
                </p>
                <p>
                    -2
                </p>
                <p>
                    3
                </p>
                <p>
                    -4
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    3
                </p>
                <p>
                    1
                </p>
                <p>
                    3
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    0
                </p>
            </td>
        </tr>
        <tr>
            <td width="51" valign="top">
                <p>
                    6
                </p>
                <p>
                    -1
                </p>
                <p>
                    -2
                </p>
                <p>
                    -3
                </p>
                <p>
                    -4
                </p>
                <p>
                    -4
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="62" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Count of Given Element in Array
</h2>
<p>
    Read an array of integers and print how many times a given element exists
    in it.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="132" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    5 2 3 1 5
                </p>
                <p>
                    2
                </p>
            </td>
            <td width="132">
                <p>
                    1
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    1 4 4 4 1
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="132">
                <p>
                    3
                </p>
            </td>
        </tr>
        <tr>
            <td width="221">
                <p>
                    8 4 9 0 0
                </p>
                <p>
                    0
                </p>
            </td>
            <td width="132">
                <p>
                    2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Use the .Split() function to read the array on a single line.
</p>
<h2>
    12. Count Occurrences of Larger Numbers in Array
</h2>
<p>
    Read an <strong>array</strong> of <strong>real numbers</strong> and a
number <strong>p</strong>. Find how many elements are<strong>bigger</strong> than <strong>p</strong> in the array and    <strong>print</strong> the count.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    3 2 3.5 3 2 4 3 4 -2 -7 3
                </p>
                <p>
                    2.9
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    7
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    5 6 105 3 2 849
                </p>
                <p>
                    100
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    1.5 4.1 9.3 10.5 0.85
                </p>
                <p>
                    4.9
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Increasing Sequence of Elements
</h2>
<p>
Read an <strong>array of integers</strong> and find out if it is an    <strong>increasing sequence</strong>. Print Yes if it does and No if it
    doesn’t.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="84" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="84">
                <p>
                    1 5 10 12
                </p>
            </td>
            <td width="197">
                <p>
                    Yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="84">
                <p>
                    1 5 2 12
                </p>
            </td>
            <td width="197">
                <p>
                    No
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Equal Sequence of Elements in Array
</h2>
<p>
    Read an <strong>array of integers</strong> and find out if all the elements
    in the array are <strong>the same</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="55" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="55">
                <p>
                    5 5 5
                </p>
            </td>
            <td width="197">
                <p>
                    Yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="55">
                <p>
                    3 4 4
                </p>
            </td>
            <td width="197">
                <p>
                    No
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    15. Count of Capital Letters in Array
</h2>
<p>
Read an <strong>array of strings</strong> and find out how many of them are    <strong>capital English letters</strong> (such as A, B, C etc.). Print the
    count on the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="280" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="345" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="280">
                <p>
                    Hello SoftUni I am A student
                </p>
            </td>
            <td width="345">
                <p>
                    2
                </p>
            </td>
        </tr>
        <tr>
            <td width="280">
                <p>
                    I Think A B and C are the first three letters of the
                    alphabet
                </p>
            </td>
            <td width="345">
                <p>
                    4
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    16. Array Symmetry
</h2>
<p>
Read an <strong>array of strings</strong> and find out if it’s    <strong>symmetric</strong>. If it is, print “Yes”, otherwise print “No”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="280" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="345" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="280">
                <p>
                    hi you hi
                </p>
            </td>
            <td width="345">
                <p>
                    Yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="280">
                <p>
                    ho hi hi ho
                </p>
            </td>
            <td width="345">
                <p>
                    Yes
                </p>
            </td>
        </tr>
        <tr>
            <td width="280">
                <p>
                    hi ho ho ho
                </p>
            </td>
            <td width="345">
                <p>
                    No
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
        Iterate over the array as follows:
    </li>
</ul>
<p>
    o Check whether the <strong>first</strong> and <strong>last</strong>
    elements are equal
</p>
<p>
o Then check whether the <strong>second</strong> and the    <strong>next to last</strong> elements are equal
</p>
<p>
o Continue this pattern until you either    <strong>find an inequality</strong> or <strong>reach the middle</strong> of
    the array.
</p>
<ul>
    <li>
        Alternate solution: <strong>reverse</strong> the array and check if it
        is the <strong>same </strong>as the <strong>original</strong> array.
    </li>
</ul>
<h2>
    17. * Altitude
</h2>
<p>
    You are an airplane pilot, trying to maneuver your airplane to safety from
    an unknown danger.
</p>
<p>
An array holds a sequence of up / down commands and    <strong>numbers</strong>. Its first element <strong>always</strong> holds
the <strong>initial altitude</strong>. The<strong> </strong>command up    <strong>increases</strong> the altitude by the next number, while the
command <strong>down decreases</strong> the altitude by the    <strong>next number</strong>.
</p>
<p>
If at any point the altitude becomes either <strong>zero</strong> or<strong>negative</strong>, print “crashed” and <strong>end</strong><strong>the program</strong>. If by the end, the altitude is    <strong>positive</strong>, however, print “got through safely. current
    altitude: {altitude}m”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="285" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="358" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    300 up 3 down 7 up 5
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    got through safely. current altitude: 301m
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    50 up 2 down 20 up 3 down 36 up 1 down 2 up 2
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    crashed
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    11 up 12 down 20 down 3 down 36 down 1 down 2 down 2
                </p>
            </td>
            <td width="358" valign="top">
                <p>
                    crashed
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    18. * Ballistics Training
</h2>
<p>
    You are the anti-aircraft operator, trying to shoot down the airplane from
    the previous problem. You’ll be given instructions to get to the current
    coordinates of the plane. Shoot it down.
</p>
<p>
You will be given an array which holds 2 numbers – the<strong>target</strong> <strong>X</strong> and <strong>Y</strong>    <strong>coordinates</strong> of the plane.
</p>
<p>
Afterwards, you will be given a second array, which holds a sequence of<strong>left</strong> / <strong>right</strong> / <strong>up</strong> /    <strong>down</strong> commands and <strong>numbers</strong>. We start at
    position <strong>{x=0, y=0}</strong>. Manipulate the firing position in the
    following way:
</p>
<ul>
    <li>
        Up <strong>increases</strong> <strong>y</strong> by the next number.
    </li>
    <li>
        Down <strong>decreases</strong> <strong>y</strong> by the next number.
    </li>
    <li>
        Left <strong>decreases x</strong> by the next number.
    </li>
    <li>
        Right <strong>increases x</strong> by the next number.
    </li>
</ul>
<p>
    After you process all the commands, print “firing at [{x}, {y}]”. After
that, check if the <strong>firing position</strong><strong>coordinates</strong> line up with the    <strong>target coordinates</strong>. If they do, print “got 'em!”. If not –
    print “better luck next time...”
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
            <td width="213" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    25 -3
                </p>
                <p>
                    right 18 down 6 left -7 up 3
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    firing at [25, -3]
                </p>
                <p>
                    got 'em!<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    150 33
                </p>
                <p>
                    right 108 down 4 left -11 up 3 right 30 up 33 right 2
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    firing at [151, 32]
                </p>
                <p>
                    better luck next time...
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>19. </strong>
    <strong>Debugging Exercise: Tricky Strings</strong>
</p>
<p>
The goal of this exercise is to practice    <strong>debugging techniques </strong>in scenarios where a piece of code
does not work correctly. Your task is to    <strong>pinpoint the 4 bugs</strong> and <strong>fix them</strong> (without
    rewriting the entire code).
</p>
<p>
    You can download the broken solution from
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip"
    >
        here
    </a>
    .<strong></strong>
</p>
<p>
    <strong>Problem Description</strong>
</p>
<p>
    You are given a <strong>delimiter</strong>. On the next line, you will
    receive a number <strong>N.</strong> On the next <strong>N lines</strong>,
you will receive <strong>strings </strong>on each line. Your task is to<strong>print</strong> the strings, <strong>separated</strong> by the    <strong>delimiter</strong>.
</p>
<p>
    Note: the delimiter and strings could be <strong><em>anything</em></strong>
: whitespace and empty strings<strong> </strong>are    <strong> acceptable input</strong>!
</p>
<p>
    <strong>Examples</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="66" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="550" valign="top">
                <p>
                    <strong>Program Output (Wrong)</strong>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    <strong>Expected Output (Correct)</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    -
                </p>
                <p>
                    5
                </p>
                <p>
                    I
                </p>
                <p>
                    Am
                </p>
                <p>
                    Five
                </p>
                <p>
                    Strings
                </p>
                <p>
                    Long
                </p>
            </td>
            <td width="550" valign="top">
                <p>
I-IAm-IAmFive-IAmFiveStrings-IAmFiveStringsLong-IAmFiveStringsLong-                    <em></em>
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    I-Am-Five-Strings-Long
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    _
                </p>
                <p>
                    5
                </p>
                <p>
                    you
                </p>
                <p>
                    cannot
                </p>
                <p>
                    trick
                </p>
                <p>
                    me
                </p>
            </td>
            <td width="550" valign="top">
                <p>
                    you_youcannot_youcannot_youcannottrick_youcannottrickme_youcannottrickme_
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    you_cannot__trick_me
                </p>
            </td>
        </tr>
        <tr>
            <td width="66" valign="top">
                <p>
                    '
                </p>
                <p>
                    7
                </p>
                <p>
                    S
                </p>
                <p>
                    o
                </p>
                <p>
                    f
                </p>
                <p>
                    t
                </p>
                <p>
                    U
                </p>
                <p>
                    n
                </p>
                <p>
                    i
                </p>
            </td>
            <td width="550" valign="top">
                <p>
                    S'So'Sof'Soft'SoftU'SoftUn'SoftUni'SoftUni'
                </p>
            </td>
            <td width="161" valign="top">
                <p>
                    S'o'f't'U'n'i
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Hints</strong>
</p>
<p>
    · Download the source code and get familiar with it
</p>
<p>
    · Deal with poor code formatting - Remove unnecessary blank lines, indent
    the code properly
</p>
<ul>
    <li>
        Fix method parameters naming
    </li>
    <li>
        Give methods a proper name
    </li>
</ul>
<p>
    <strong>20. </strong>
    <strong>Debugging Exercise: Triangle Formations</strong>
</p>
<p>
The goal of this exercise is to practice    <strong>debugging techniques </strong>in scenarios where a piece of code
    does not work correctly. Your task is to <strong>pinpoint the bugs</strong>
    and <strong>fix them</strong> (without rewriting the entire code).
</p>
<p>
    You can download the broken solution from
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip"
    >
        here
    </a>
    .
</p>
<p>
    <strong>Problem Description</strong>
</p>
<p>
You are given <strong>3 integer numbers: a</strong>,<strong>b and c</strong>, which will represent the    <strong>3 sides of a triangle</strong>. Your task is to check whether the
    triangle is <strong>valid</strong>.
    <br/>
    <br/>
    If it is, print "<strong>Triangle is valid.</strong>".
    <br/>
Otherwise print "<strong>Invalid Triangle.</strong>" and    <strong>end the program</strong>.
</p>
<p>
If it is valid, you have to check if it is a<strong>right triangle </strong>(a<sup>2</sup> + b<sup>2</sup> == c    <sup>2</sup>).
    <br/>
If it is a right triangle, print "    <strong>Triangle has a right angle between sides a and b</strong>",
depending on which side forms a <strong>right angle</strong>. If the sides<strong>b </strong>and <strong>c</strong> form a right angle, print "    <strong>Triangle has a right angle between sides b and c</strong>", and so
    on.
</p>
<p>
    <strong>Examples</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="73" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    <strong>Program Output (Wrong)</strong>
                </p>
            </td>
            <td width="240" valign="top">
                <p>
                    <strong>Expected Output (Correct)</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    3
                </p>
                <p>
                    4
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Invalid Triangle.
                </p>
                <p>
                    Triangle has a right angle between sides a and b<em></em>
                </p>
            </td>
            <td width="240" valign="top">
                <p>
                    Triangle is valid.
                </p>
                <p>
                    Triangle has a right angle between sides a and b
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    5
                </p>
                <p>
                    5
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Invalid Triangle.
                </p>
                <p>
                    Triangle has no right angles.
                </p>
            </td>
            <td width="240" valign="top">
                <p>
                    Triangle is valid.
                </p>
                <p>
                    Triangle has no right angles
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    3
                </p>
                <p>
                    1
                </p>
                <p>
                    1
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Invalid Triangle.
                </p>
                <p>
                    Triangle has no right angles.
                </p>
            </td>
            <td width="240" valign="top">
                <p>
                    Invalid Triangle.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Hints</strong>
</p>
<p>
    · Download the source code and get familiar with it
</p>
<p>
    · Deal with poor code formatting - Remove unnecessary blank lines, indent
    the code properly
</p>
<ul>
    <li>
        Fix method parameters naming
    </li>
    <li>
        Give methods a proper name
    </li>
</ul>
<p>
    <strong>21. </strong>
    <strong>Debugging Exercise: Tetris</strong>
</p>
<p>
The goal of this exercise is to practice    <strong>debugging techniques </strong>in scenarios where a piece of code
    does not work correctly. Your task is to <strong>pinpoint the bugs</strong>
    and <strong>fix them</strong> (without rewriting the entire code).
</p>
<p>
    You can download the broken solution from
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip"
    >
        here
    </a>
    .
</p>
<p>
    <strong>Problem Description</strong>
</p>
<p>
    You will receive an integer <strong>N</strong>. On the next several lines,
you will receive commands in the form of <strong>directions</strong> –<strong>left</strong>, <strong>right</strong>, <strong>up</strong> and    <strong>down</strong>
</p>
<p>
Your task is to print the famous <strong>Tetris</strong> block – the    <strong>T-shape</strong>, facing the given <strong>direction</strong>, with
    a <strong>size</strong> of<strong> N</strong>.
</p>
<p>
    When you receive the command “<strong>exit</strong>”, you should stop the
    program execution.
</p>
<p>
    <strong>Examples</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="73" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <strong>Program Output (Wrong)</strong>
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>Expected Output (Correct)</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    1
                </p>
                <p>
                    left
                </p>
                <p>
                    right
                </p>
                <p>
                    exit
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <em>(no output)</em>
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>.*</strong>
                </p>
                <p>
                    <strong>**</strong>
                </p>
                <p>
                    <strong>.*</strong>
                </p>
                <p>
                    <strong>*.</strong>
                </p>
                <p>
                    <strong>**</strong>
                </p>
                <p>
                    <strong>*.</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    2
                </p>
                <p>
                    up
                </p>
                <p>
                    down
                </p>
                <p>
                    exit
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    **
                </p>
                <p>
                    <em>(infinite loop)</em>
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>..**..</strong>
                </p>
                <p>
                    <strong>..**..</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>..**..</strong>
                </p>
                <p>
                    <strong>..**..</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    3
                </p>
                <p>
                    right
                </p>
                <p>
                    left
                </p>
                <p>
                    exit
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    ******
                </p>
                <p>
                    ******
                </p>
                <p>
                    .*.
                </p>
                <p>
                    ......
                </p>
                <p>
                    ......
                </p>
                <p>
                    ******
                </p>
                <p>
                    ******
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>***...</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>******</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
                <p>
                    <strong>...***</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Hints</strong>
</p>
<p>
    · Download the source code and get familiar with it
</p>
<p>
    · Deal with poor code formatting - Remove unnecessary blank lines, indent
    the code properly
</p>
<ul>
    <li>
        Fix method parameters naming
    </li>
    <li>
        Give methods a proper name
    </li>
</ul>
<p>
    <strong>22. </strong>
    <strong>Debugging Exercise: Mining Coins</strong>
</p>
<p>
The goal of this exercise is to practice    <strong>debugging techniques </strong>in scenarios where a piece of code
    does not work correctly. Your task is to <strong>pinpoint the bugs</strong>
    and <strong>fix them</strong> (without rewriting the entire code).
</p>
<p>
    You can download the broken solution from
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code/05.%20Programming-Fundamentals-Debugging-and-Troubleshooting-Code-Exercises-Broken-Solutions.zip"
    >
        here
    </a>
    .
</p>
<p>
    <strong>Problem Description</strong>
</p>
<p>
In this problem you have to decrypt <strong>encrypted data</strong> and<strong>calculate</strong> its <strong>value</strong>. You will receive an    <strong>integer</strong> N. On the next <strong>N</strong> lines, you will
    receive 3-digit integers.
</p>
<p>
The input integers will be <strong>indexed</strong> - starting from    <strong>1 to N</strong>. The integers represent <strong>characters</strong>
    of an <strong>encrypted message</strong>.
</p>
<p>
    You must take the <strong>first</strong> and the <strong>last</strong>
    digit and form a <strong>2-digit number</strong> from them, depending on
    the <strong>current index</strong> of the input number:
</p>
<ul type="disc">
    <li>
if the index is an <strong>odd</strong> number –<strong>subtract</strong> the <strong>middle digit</strong> from the        <strong>2-digit number</strong>.
    </li>
    <li>
If the index is <strong>even</strong> number – <strong>add</strong> the        <strong>middle digit</strong> to the <strong>2-digit</strong> number.
    </li>
</ul>
<p>
If the resulting number is an <strong>English</strong><strong>alphabet</strong> <strong>letter</strong> (Lower or Uppercase)<strong>append</strong> it to a string. If it is not,    <strong>ignore</strong> it.
</p>
<p>
After that, calculate the <strong>sum</strong> of the<strong>3 digits</strong> and <strong>divide</strong> it by    <strong>N</strong>.
</p>
<p>
The result from this operation should be a<strong>floating-point number</strong>, <strong>rounded</strong> to the    <strong>7-th digit</strong> after the decimal point.
</p>
<p>
Do the same for <strong>all input integers</strong> and    <strong>sum</strong> the results. The sum is the <strong>value</strong> of
    the <strong>decrypted data</strong>.
</p>
<p>
    The final result should be the <strong>decrypted string </strong>(the
    letters, appended together), and the <strong>value</strong>.
</p>
<p>
    <strong>Examples</strong>
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="73" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    <strong>Program Output (Wrong)</strong>
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>Expected Output (Correct)</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    8
                </p>
                <p>
                    836
                </p>
                <p>
                    736
                </p>
                <p>
                    733
                </p>
                <p>
                    795
                </p>
                <p>
                    650
                </p>
                <p>
                    778
                </p>
                <p>
                    886
                </p>
                <p>
                    694
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Message:
                </p>
                <p>
                    Value: 15.25000000<em></em>
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>Message: SOFTUNI</strong>
                </p>
                <p>
                    <strong>Value: 17.6250000</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="73" valign="top">
                <p>
                    7
                </p>
                <p>
                    618
                </p>
                <p>
                    811
                </p>
                <p>
                    918
                </p>
                <p>
                    918
                </p>
                <p>
                    716
                </p>
                <p>
                    716
                </p>
                <p>
                    710
                </p>
            </td>
            <td width="299" valign="top">
                <p>
                    Message: aa
                </p>
                <p>
                    Value: 12.71429000
                </p>
            </td>
            <td width="319" valign="top">
                <p>
                    <strong>
Message: <a name="OLE_LINK2"></a>                        <a name="OLE_LINK1">CRacKME</a>
                    </strong>
                </p>
                <p>
                    <strong>Value: 13.8571400</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Hints</strong>
</p>
<p>
    · Download the source code and get familiar with it
</p>
<p>
    · Deal with poor code formatting - Remove unnecessary blank lines, indent
    the code properly
</p>
<ul>
    <li>
        Fix method parameters naming
    </li>
    <li>
        Give methods a proper name
    </li>
</ul>