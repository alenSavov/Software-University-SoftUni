<h1 align="center">
    Problem 1 – Hornet Wings
</h1>
<p>
    The hornets are having a cardio contest. Your task is to calculate a
    contestant’s distance travelled, based upon the wing flaps he made. However
    some hornet contestants are faster and less durable, while others are
    slower but have more endurance.
</p>
<p>
    You will be given <strong>N</strong> – an <strong>integer</strong>
    indicating the <strong>wing flaps</strong>, a contestant has chosen to do.
</p>
<p>
After that, you will receive <strong>M</strong> – a<strong>floating-point number</strong> indicating the    <strong>distance</strong>, in <strong>meters</strong>, the hornet travels
    for <strong>1000 wing flaps</strong>.
</p>
<p>
    Then you will receive <strong>P</strong> – an <strong>integer</strong>
indicating the <strong>endurance</strong> of the contestant, or<strong>how many wing flaps</strong> he can make, before<strong>he stops to take a break</strong> and rest. A hornet    <strong>rests</strong> for <strong>5</strong> <strong>seconds</strong>.
</p>
<p>
You can assume that a hornet makes <strong>100 </strong>wing flaps    <strong>per</strong> <strong>second</strong>.
</p>
<p>
Your task is to <strong>calculate</strong> how much<strong>distance</strong> will the hornet <strong>travel</strong>, after it    <strong>flaps</strong> its <strong>wings</strong> <strong>N times</strong>,
    and how much <strong>time</strong> it <strong>took him</strong>, to travel
    it. The <strong>distance</strong> is measured in <strong>meters</strong>
    and the time – in <strong>seconds</strong>.
</p>
<h3>
    Input
</h3>
<p>
    · On the first input line you will receive N – the wing flaps, the hornet
    has chosen to do.
</p>
<p>
    · On the second input line you will receive M – the distance the hornet
    travels for 1000 wing flaps.
</p>
<p>
    · On the third input line you will receive P – the endurance of the hornet.
</p>
<h3>
    Output
</h3>
<p>
    · As output you must print the total distance the hornet contestant has
    travelled, and the amount of time it took him.
</p>
<ul>
    <li>
        The output must be in the format of two lines:
    </li>
</ul>
<p>
- On the first output line you must print the distance: “<strong>{</strong>    <strong>metersTraveled} m.</strong>”
</p>
<p>
- On the second output line you must print the time: “    <strong>{secondsPassed} s.</strong>
</p>
<ul>
    <li>
The <strong>distance</strong> must be <strong>printed</strong> to the        <strong>second digit</strong> after the <strong>decimal point</strong>.
    </li>
</ul>
<h3>
    Constrains
</h3>
<ul>
    <li>
The integer <strong>N</strong> – the wing flaps, will be in        <strong>range [0</strong><strong>; 1,000,000,000]</strong>.
    </li>
    <li>
        The floating-point number <strong>M</strong> – the distance for 1000
wing flaps, will be in <strong>range [0</strong>        <strong>; 1,000,000]</strong>.
    </li>
    <li>
The integer <strong>P</strong> – the endurance, will be in range        <strong>[1</strong><strong>; N]</strong>.
    </li>
</ul>
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
            <td width="120" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="455" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="97" valign="top">
                <p>
                    2000
                </p>
                <p>
                    5
                </p>
                <p>
                    200
                </p>
            </td>
            <td width="120" valign="top">
                <p>
                    10.00 m.
                </p>
                <p>
                    70 s.
                </p>
            </td>
            <td width="455" valign="top">
                <p>
The contestant has chosen to do                    <strong>2000 wing flaps</strong>.
                    <br/>
He moves <strong>5 meters</strong> per                    <strong>1000</strong> wing flaps.
                </p>
                <p>
He rests every <strong>200</strong><strong>wing flaps</strong> for <strong>5</strong>                    <strong>seconds</strong>.
                </p>
                <p>
The distance is                    <strong>(2000 / 1000) * 5 = 2 * 5 = 10.00</strong> meters.
                </p>
                <p>
The hornet flaps <strong>100 times</strong> for a<strong>second</strong>, so <strong>2000 / 100 =</strong>                    <strong>20 </strong>seconds.
                    <br/>
But it also rests for <strong>5</strong> seconds every                    <strong>200</strong> flaps.
                </p>
                <p>
                    <strong>(2000 / 200) * 5 = 10 * 5</strong>
= <strong>50</strong>; <strong>20</strong> +                    <strong>50</strong> = <strong>70</strong> seconds.
                </p>
            </td>
        </tr>
        <tr>
            <td width="97" valign="top">
                <p>
                    1000000
                </p>
                <p>
                    10
                </p>
                <p>
                    1500
                </p>
            </td>
            <td width="120" valign="top">
                <p>
                    10000.00 m.
                </p>
                <p>
                    13330 s.
                </p>
            </td>
            <td width="455">
            </td>
        </tr>
    </tbody>
</table>


<h1 align="center">
    Problem 2 – Hornet Comm
</h1>
<p>
    The Hornet Ex-King – Horny, has established an innovative technology
    providing communication for his fellow hornets, called Hornet Comm. Inc.
    Hornet Comm. provides functionality from private messages to wide
    broadcasts.
</p>
<p>
    You will be given data of several tracked comm. channels, which you must
    decrypt. The input data will come in the following format:
</p>
<p>
    {firstQuery} &lt;-&gt; {secondQuery}
</p>
<p>
If the <strong>first query</strong> consists    <strong>only of digits</strong> and the <strong>second one</strong>
consists of <strong>digits and / or letters</strong>, it is a    <strong>private message</strong>.
</p>
<p>
If the <strong>first query</strong> consists of    <strong>anything but digits</strong>, and the <strong>second one</strong>
consists of <strong>letters and / or digits,</strong> it is a    <strong>broadcast</strong>.
</p>
<p>
Any input that <strong>does</strong> <strong>NOT</strong><strong>follow</strong> the format, specified above, should be    <strong>IGNORED</strong>.
</p>
<p>
    If the <strong>given data</strong> is a <strong>private message</strong>,
    the first query is the <strong>recipient’s code</strong>, and the second
    query is the <strong>message</strong>. You must <strong>reverse</strong>
    the <strong>recipient’s code</strong> and <strong>store</strong> it along
    with the message.
</p>
<p>
    If the <strong>given data</strong> is a <strong>broadcast</strong>, the
first query is the message, and the second query is the    <strong>frequency</strong>. You must take the <strong>frequency</strong>
and make <strong>all capital letters</strong> – <strong>small</strong> and    <strong>all small letters</strong> – <strong>capital</strong>. Then you
    must <strong>store</strong> it, along with the <strong>message</strong>.
</p>
<p>
You must <strong>keep</strong> all input broadcasts and messages after you    <strong>decrypt</strong> them.
</p>
<p>
    When you receive the command “<strong>Hornet is Green</strong>”, the input
    sequences <strong>ends</strong>, and you must print the stored broadcasts
    and messages.
</p>
<h3>
    Input
</h3>
<p>
    · The input comes in the form of several input lines in the format
    specified above.
</p>
<ul>
    <li>
The input ends when you receive the command “        <strong>Hornet is Green</strong>”.
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    · As output you must print all broadcasts and messages, printing first the
    broadcasts, in the following format:
</p>
<p>
    o Broadcasts:
</p>
<p>
    o {frequency} -&gt; {message}
</p>
<p>
    o . . .
</p>
<p>
    o Messages:
</p>
<p>
    o {recipient} -&gt; {message}
</p>
<p>
    o . . .
</p>
<ul>
    <li>
If there are <strong>no messages</strong>, or        <strong>no broadcasts</strong>, print “<strong>None</strong>” in their
        place.
    </li>
</ul>
<h3>
    Constrains
</h3>
<ul>
    <li>
        The input lines may consist of <strong>any ASCII</strong> character.
    </li>
    <li>
        There will be <strong>NO</strong> more than 1000 lines of input.
    </li>
    <li>
        <strong>All data</strong>
        must be printed in <strong>order of input</strong>.
    </li>
</ul>
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
            <td width="189" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    213094 &lt;-&gt; BeeQueenDown
                </p>
                <p>
                    213094 &lt;-&gt; Repeat
                </p>
                <p>
                    Foxtrot &lt;-&gt; 123321
                </p>
                <p>
                    213094 &lt;-&gt; BeeQueenDown
                </p>
                <p>
                    Unicorn &lt;-&gt; 871203
                </p>
                <p>
                    Charlie &lt;-&gt; 56210
                </p>
                <p>
                    Kilo &lt;-&gt; 423211
                </p>
                <p>
                    Hornet is Green
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    Broadcasts:
                </p>
                <p>
                    123321 -&gt; Foxtrot
                </p>
                <p>
                    871203 -&gt; Unicorn
                </p>
                <p>
                    56210 -&gt; Charlie
                </p>
                <p>
                    423211 -&gt; Kilo
                </p>
                <p>
                    Messages:
                </p>
                <p>
                    490312 -&gt;BeeQueenDown
                </p>
                <p>
                    490312 -&gt;Repeat
                </p>
                <p>
                    490312 -&gt;BeeQueenDown
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    &lt;+&gt;.&lt;+&gt; &lt;-&gt; az13b6
                </p>
                <p>
                    &lt;-&gt;.&lt;-&gt; &lt;-&gt; P2Z4x789
                </p>
                <p>
                    12345 &lt;-&gt; Pr1v@teM3ssage
                </p>
                <p>
                    Hornet is Green
                </p>
            </td>
            <td width="189" valign="top">
                <p>
                    Broadcasts:
                </p>
                <p>
                    AZ13B6 -&gt; &lt;+&gt;.&lt;+&gt;
                </p>
                <p>
                    p2z4X789 -&gt; &lt;-&gt;.&lt;-&gt;
                </p>
                <p>
                    Messages:
                </p>
                <p>
                    None
                </p>
            </td>
        </tr>
    </tbody>
</table>