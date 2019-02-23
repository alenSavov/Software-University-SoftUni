<h1>
    Exercise: Strings and Regular Expressions
</h1>
<p>
    Problems for in-class lab for the
    <a href="https://softuni.bg/trainings/2247/js-fundamentals-january-2019">
        "JavaScript Fundamentals" course @ SoftUni
    </a>
    . Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/1480/">
        https://judge.softuni.bg/Contests/1480/
    </a>
    .<strong><u></u></strong>
</p>
<h2>
    1. Binary Decoding
</h2>
<p>
    You will receive a string from zeros and ones. Write a function that
    converts it into text. To do that, you need to calculate the weight of the
    string (sum of all the ones). The result of that sum should be a single
    digit (e.g '10011101111100111111001101111' here the sum is 21, but since we
    need only one digit, we sum 2 and 1 and get 3). After that, you need to
    remove from the start and the end the calculated sum and split the
    remaining string into groups of 8 characters. Then convert each segment of
    binary code into decimals to get the ascii code of each element. Then print
    the result in the "result" span (only the letters and spaces).
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="949" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="72" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="97" valign="top">
                <p align="center">
                    <strong>Comment</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="949" valign="top">
                <p>
                    '0100011011010111100100100000011011100110000101101101011001010010000001101001011100110010'
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    my name is
                </p>
            </td>
            <td width="97" valign="top">
                <p>
                    The sum here is 40; 4 + 0 = 4; we take 4 characters from
                    the beginning and end, then we split it into segments of 8
                    characters and we get '01101101', '01111001', '00100000',
                    '01101110', '01100001', '01101101', '01100101', '00100000',
                    '01101001', '01110011'. When we convert each one of these
                    segments into ascii we get 109 121 32 110 97 109 101 32 150
                    115. When we convert that into text we get 'my name is'
                </p>
            </td>
        </tr>
        <tr>
            <td width="949" valign="top">
                <p>
                    '010011100110110111101100110011101000111010101101110011010010010000001110011011101000111010101100100011001010110111001110100010'
                </p>
            </td>
            <td width="72" valign="top">
                <p>
                    softuni student
                </p>
            </td>
            <td width="97" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Example
</h3>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>Hints</strong>
</p>
<h2>
    2. Expedition problems
</h2>
<p>
    <em>
        The expedition is over and everyone has returned successfully to the
        rest house. It turns out, however, that one from the group has fallen
        behind. He has sent a message to the leader but his device is broken
        and his message contains unwanted symbols, which prevent it from being
        read. Since the leader does not understand anything from programming,
        he has assigned the task of decrypting to you.
    </em>
</p>
<p>
You will receive a text (<strong>string</strong>), which can contain<strong>all of the ASCII symbols</strong>, <strong>including</strong>    <strong>new lines</strong> and <strong>tabs</strong>. The location of the
    lost person and his message must be retrieved from this string. The text
contains a <strong>keyword</strong> that indicates the<strong>beginning</strong> and the <strong>end</strong> of the<strong>message</strong>. The geographical coordinates come as<strong>a</strong> <strong>pair</strong> of longitude ("    <strong>east</strong>") and latitude ("<strong>north</strong>") and each
    coordinate should meet the following conditions:
</p>
<p>
1. It should start with "<strong>north</strong>"/"<strong>east</strong>",    <strong>case-insensitive</strong>;
</p>
<p>
2. Next come <strong>2 digits</strong>, which form the    <strong>whole part of the degrees</strong>;
</p>
<p>
3. The whole part of the degrees is separated from the decimal part by "<strong>,</strong>" and there may be any number of characters between them,    <strong>except</strong> ","
</p>
<p>
    4. The <strong>decimal part</strong> consists of <strong>6 digits</strong>
</p>
<p>
    In case there is <strong>more than one</strong> longitude or latitude in
    the text, take <strong>the latter</strong>. The message is surrounded by
the <strong>keyword</strong>, which will be the    <strong>first argument</strong> from the input. The second argument from
the input will be the <strong>text</strong>, containing    <strong>both the location</strong> and <strong>the message</strong> of the
    lost person. See the examples below to understand how it works.
</p>
<p>
    <strong>Input</strong>
</p>
<p>
    The first argument contains the keyword and the second argument contains
the text. There will always be    <strong>at least one pair of coordinates</strong>.
</p>
<p>
    <strong>Output</strong>
</p>
<p>
Print the latitude in a <strong>paragraph</strong> in the    <strong>"result"</strong> span in the following format:<strong></strong>
</p>
<p>
    <strong>&lt;<em>degrees</em>&gt;.&lt;<em>decimal part</em>&gt; N</strong>
</p>
<p>
Print the second in a <strong>paragraph</strong> in the    <strong>"result"</strong> span in the following format:<strong> </strong>
</p>
<p>
    <strong>&lt;<em>degrees</em>&gt;.&lt;<em>decimal part</em>&gt; E</strong>
</p>
<p>
    On the last line print the message:
</p>
<p>
    <strong>Message:<em> &lt;message&gt;</em></strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    &lt;&gt;
                </p>
                <p>
                    o u%&amp;lu43t&amp;^ftgv&gt;&lt;nortH4276hrv756dcc,
                    jytbu64574655k &lt;&gt;ThE sanDwich is iN the
                    refrIGErator&lt;&gt;yl i75evEAsTer23,lfwe 987324tlblu6b
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    42.645746 N
                </p>
                <p>
                    23.987324 E
                </p>
                <p>
                    Message: ThE sanDwich is iN the refrIGErator
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" align="left" width="0">
    <tbody>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    4ds
                </p>
                <p>
                    eaSt 19,432567noRt north east 53,123456north
                    43,3213454dsNot all those who wander are lost.4dsnorth
                    47,874532
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    47.874532 N
                </p>
                <p>
                    19.432567 E
                </p>
                <p>
                    Message: Not all those who wander are lost.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Note there are three instances of north coordinates – the first two are
    ignored and only the last one is counted.
</p>
<p>
    <strong>Hints</strong>
</p>
<p>
    <strong></strong>
</p>
<h2>
    3. James Bond
</h2>
<p>
    You are the spy master of a guild of spies, since you’re all carefully
watched, your spies communicate with you by leaving<strong>encoded messages</strong>. You will receive a    <strong>special key</strong> and <strong>lines of text</strong> which you
    must comb in order to find the <strong>encoded messages</strong>.
</p>
<p>
The special key will consist only of <strong>one or more</strong>    <strong>English letters</strong>.
</p>
<p>
    · The special key must be preceded by either a <strong>space</strong> or
    the <strong>start of the string</strong> in order to be considered valid in
    the string.
</p>
<p>
    · The special key may appear in <strong>any casing</strong> (its letters
could be a random mix of lower and uppercase) in the    <strong>lines of text</strong>.
</p>
<p>
    Valid encoded messages must meet these requirements:
</p>
<ul>
    <li>
An <strong>encoded message</strong> must immediately follow the<strong>special key</strong>, being separated from it only by        <strong>one or more spaces</strong>.
    </li>
</ul>
<p>
· An encoded message must be <strong>at least</strong><strong>8 symbols long</strong> and consist only of the symbols<strong> !</strong>,<strong> %</strong>, <strong>$</strong>,    <strong>#</strong> or <strong>Capital English letters</strong>.
</p>
<p>
· The encoded message must be followed by a <strong>space</strong>, a<strong> dot (.)</strong>, a<strong> comma (,)</strong> or the    <strong>end of the string</strong>.
</p>
<p>
After finding the correct <strong>encoded messages</strong>, you must<strong>decode</strong> and    <strong>replace them in the original text</strong>. The decoding should be
    as follows:
</p>
<ul>
    <li>
        The symbol <strong>!</strong> becomes the number <strong>1</strong>
    </li>
    <li>
        The symbol <strong>%</strong> becomes the number <strong>2</strong>
    </li>
    <li>
        The symbol <strong>#</strong> becomes the number <strong>3</strong>
    </li>
    <li>
The symbol <strong>$</strong> should become the number        <strong>4</strong>
    </li>
    <li>
        <strong>Capital English letters </strong>
        should become their<strong> lower case counterparts</strong>
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
A pair of a <strong>special key</strong> and        <strong>encoded message</strong> will never be split between multiple
        lines.
    </li>
</ul>
<p>
    · The preceding space before a <strong>special key</strong> will never
    overlap with a trailing space after an <strong>encoded message</strong>.
</p>
<p>
· There will never be an <strong>encoded message</strong> equal to the    <strong>special key</strong>.
</p>
<h3>
    Input
</h3>
<p>
    The <strong>input</strong> comes as an array of strings - the first element
is the <strong>special key</strong>, each element after it is a    <strong>line of text</strong>.
</p>
<h3>
    Output
</h3>
<p>
    The <strong>output</strong> should be displayed in the DOM - consisting of
the entire text with the <strong>correct</strong><strong>encoded messages</strong> replaced with their    <strong>decoded</strong> versions, each <strong>line of text</strong> in a
    new paragraph in the "result" span.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="706" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p>
                    specialKey
                </p>
                <p>
                    In this text the specialKey HELLOWORLD! is correct, but
                </p>
                <p>
                    the following specialKey $HelloWorl#d and spEcIaLKEy
                    HOLLOWORLD1 are not, while
                </p>
                <p>
                    SpeCIaLkeY SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p>
                    In this text the specialKey helloworld1 is correct, but
                </p>
                <p>
                    the following specialKey $HelloWorl#d and spEcIaLKEy
                    HOLLOWORLD1 are not, while
                </p>
                <p>
                    SpeCIaLkeY som22eth4in and SPECIALKEY 33443344 are!
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p align="center">
                    Input
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p>
                    enCode
                </p>
                <p>
                    Some messages are just not encoded what can you do?
                </p>
                <p>
                    RE - ENCODE THEMNOW! - he said.
                </p>
                <p>
                    Damn encode, ITSALLHETHINKSABOUT, eNcoDe BULL$#!%.
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="706" valign="top">
                <p>
                    Some messages are just not encoded what can you do?
                </p>
                <p>
                    RE - ENCODE themnow1 - he said.
                </p>
                <p>
                    Damn encode, ITSALLHETHINKSABOUT, eNcoDe bull4312.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<h2>
    4. Airport Check
</h2>
<p>
    <em>Your next task is to extract information about a flight. </em>
</p>
<p>
You will be given a string in two parts separated by a comma. The    <strong>first</strong> one is a <strong>string</strong> you need to extract
the information from. The <strong>second</strong> one will be the    <strong>information you need to print</strong>.
</p>
<p>
    The information to extract is as follows:
</p>
<p>
    <strong>Passenger name</strong>
    :
</p>
<ul>
    <li>
        Starts with a <strong>space</strong> (' ')
    </li>
    <li>
Consists of <strong>2 or 3 names</strong> (        <strong>upper and lower-case letters</strong>)
    </li>
</ul>
<p>
    · The names should be <strong>separated by a single dash ('-')</strong>
</p>
<ul>
    <li>
        Each name should <strong>start with an upper-case letter</strong>
    </li>
    <li>
If there are <strong>3 names</strong>,        <strong>the second one should end with a dot ('.')</strong>
    </li>
    <li>
If there are <strong>2 names</strong>,        <strong>the second should not contain any dots</strong>
    </li>
    <li>
        Ends with a <strong>space (' ')</strong>
    </li>
    <li>
        <strong>Valid</strong>
examples with <strong>2 names</strong>:        <strong>' Test-Testov ', ' V-N '</strong>
    </li>
    <li>
        <strong>Valid</strong>
examples with <strong>3 names</strong>:        <strong>' T-T.-Testov ', ' Valid-V.-Name '</strong>
    </li>
</ul>
<p>
    <strong>Airport:</strong>
</p>
<ul>
    <li>
        Starts with a <strong>space</strong> (' ')
    </li>
    <li>
Should consist of <strong>3 upper-case letters</strong>, the symbol '        <strong>/</strong>' and <strong>3 more upper-case letters</strong>
    </li>
    <li>
        Ends with a <strong>space (' ')</strong>
    </li>
    <li>
        <strong>Valid </strong>
        airports are: <strong>' SOF/VAR ', ' VIE/AIR '</strong>
    </li>
</ul>
<p>
    <strong>Flight number</strong>
    :
</p>
<ul>
    <li>
        Starts with a <strong>space (' ')</strong>
    </li>
    <li>
        Followed by <strong>1 to</strong> <strong>3 upper-case letters</strong>
    </li>
    <li>
        Followed by <strong>1 to 5 digits</strong>
    </li>
    <li>
        Ends with a <strong>space (' ')</strong>
    </li>
    <li>
        <strong>Valid</strong>
        flight numbers are: <strong>' DWF24 ', ' S43159 ', ' OE314 '</strong>
    </li>
</ul>
<p>
    <strong>Company</strong>
    :
</p>
<p>
    · Starts with dash and space <strong>'- '</strong>
</p>
<ul>
    <li>
Followed by <strong>one or more</strong> <strong>letters</strong> (        <strong>starting with an upper-case letter</strong>)
    </li>
    <li>
        Followed by <strong>'*'</strong>
    </li>
    <li>
        Followed by <strong>one or more</strong> <strong>letters </strong>again
        (<strong>starting with an upper-case letter</strong>)
    </li>
    <li>
        Ends with a space <strong>(' ')</strong>
    </li>
    <li>
        <strong>Valid</strong>
        companies: <strong>'- Wizz*Air ', '- X*Y '</strong>
    </li>
</ul>
<h3>
    Input
</h3>
<p>
    <strong>String in two parts separated by a comma</strong>
    : the string you have to extract the information from and the command for
    the output
</p>
<h3>
    Output
</h3>
<p>
    <strong>4 different types of outputs</strong>
    depending on the <strong>second</strong> parameter:
</p>
<p>
    <strong>'name'</strong>
    – print <strong>'Mr/Ms, {name}, have a nice flight!'</strong>
</p>
<p>
    '<strong>flight'</strong> – print
    <strong>
        'Your flight number {flightNumber} is from {fromAirport} to
        {toAirport}.'
    </strong>
</p>
<p>
    <strong>'company'</strong>
    <strong> </strong>
    – print <strong>'Have a nice flight with {companyName}.'</strong>
</p>
<p>
    <strong>'all'</strong>
    <strong> </strong>
    – print
    <strong>
        'Mr/Ms, {name}, your flight number {flightNumber} is from {fromAirport}
        to {toAirport}. Have a nice flight with {company}.'
    </strong>
</p>
<p>
    <strong><u></u></strong>
</p>
<p>
The name should be printed <strong>without the </strong>    <strong>'-'</strong> (if any) and <strong>with spaces instead</strong>:
    <br/>
    <strong>' STEF-T.-Stefanov ' -&gt; 'STEF T. Stefanov'</strong>
    .
</p>
<p>
The <strong>company </strong>should be printed<strong>without the </strong><strong>'- '</strong> and the    <strong>'*'</strong>:
</p>
<p>
    <strong>' - Wizz*Air ' -&gt; 'Wizz Air'.</strong>
</p>
<p>
The<strong> flight number </strong>should be printed    <strong> without the spaces in the front and back</strong>:
</p>
<p>
    <strong>' OS806 ' -&gt; 'OS806'</strong>
</p>
<p>
    <strong>Display the output in the "result" span</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="432" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="318" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="432" valign="top">
                <p>
                    ahah Second-Testov )*))&amp;&amp;ba SOF/VAR ela** FB973 -
                    Bulgaria*Air -opFB900 pa-SOF/VAr//_- T12G12 STD08:45
                    STA09:35 , all
                </p>
            </td>
            <td width="318" valign="top">
                <p>
                    Mr/Ms, Second Testov, your flight number FB973 is from SOF
                    to VAR. Have a nice flight with Bulgaria Air.
                </p>
            </td>
        </tr>
        <tr>
            <td width="432" valign="top">
                <p>
                    TEST-T.-TESTOV SOF/VIE OS806 - Austrian*Airlines T24G55
                    STD11:15 STA11:50 , flight
                </p>
            </td>
            <td width="318" valign="top">
                <p>
                    Your flight number OS806 is from SOF to VIE.
                </p>
            </td>
        </tr>
    </tbody>
</table>