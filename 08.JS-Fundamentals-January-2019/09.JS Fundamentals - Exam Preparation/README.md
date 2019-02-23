<h1>
    JS Fundamentals: Test Exam
</h1>
<p>
    <em>This is a test exam for course </em>
    <a href="https://softuni.bg/courses/javascript-fundamentals">
        <em>JavaScript Fundamentals</em>
    </a>
    <em> at SoftUni.</em>
</p>
<h2>
    1. Problem Stadium
</h2>
<p>
    <em>
        It is time for the match between Levski and Litex. Your task is to
        distribute all the fans to the sectors of the team there are for.
    </em>
</p>
<p>
    <img
        border="0"
        width="629"
        height="279"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image002.jpg"
    />
    <em></em>
</p>
<p>
There are <strong>3 types of sectors</strong>: <strong>"A"</strong>,<strong>"B"</strong> and <strong>"C"</strong>, and<strong>3 types of zones</strong>: <strong>"LITEX"</strong>,    <strong>"LEVSKI"</strong> and <strong>"VIP"</strong>. Your job is to finish
    this program to works as expected:<strong></strong>
</p>
<p>
    When someone want to buy a ticket (<strong>click on specific seat</strong>
    ), you get a particular amount of <strong>money</strong> depending on the
sector and whether the zone is <strong>LEVSKI/LITEX </strong>or    <strong>VIP</strong>. Follow the table below:
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="92" valign="top">
                </td>
                <td width="156" valign="top">
                    <p align="center">
                        <strong>LEVSKI/LITEX</strong>
                    </p>
                </td>
                <td width="162" valign="top">
                    <p align="center">
                        <strong>VIP</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="92" valign="top">
                    <p align="center">
                        <strong>A</strong>
                    </p>
                </td>
                <td width="156" valign="top">
                    <p align="center">
                        10
                    </p>
                </td>
                <td width="162" valign="top">
                    <p align="center">
                        25
                    </p>
                </td>
            </tr>
            <tr>
                <td width="92" valign="top">
                    <p align="center">
                        <strong>B</strong>
                    </p>
                </td>
                <td width="156" valign="top">
                    <p align="center">
                        7
                    </p>
                </td>
                <td width="162" valign="top">
                    <p align="center">
                        15
                    </p>
                </td>
            </tr>
            <tr>
                <td width="92" valign="top">
                    <p align="center">
                        <strong>C</strong>
                    </p>
                </td>
                <td width="156" valign="top">
                    <p align="center">
                        5
                    </p>
                </td>
                <td width="162" valign="top">
                    <p align="center">
                        10
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<p>
When that’s happen, you need to <strong>mark </strong>that seat as<strong>already taken</strong>. And print the expected message in the    <strong>textarea</strong>.
    <br/>
    If the current seat is <strong>available</strong> -
    <strong>
        Seat {seatNumber} in zone {team/VIP} sector {sector} is was taken.
    </strong>
    <br/>
    If the current seat is <strong>unavailable - </strong>
    <strong>
        Seat {seatNumber} in zone {team/VIP} sector {sector} is unavailable.
    </strong>
</p>
<p>
    <strong>
        To mark that seat as taken you need to make the button a rgb(255,0,0)
        color.
        <br/>
    </strong>
For example, if we click over the seat <strong>3</strong> in zone    <strong>VIP</strong> sector <strong>C</strong>, the expected result should
    be:<strong></strong>
</p>
<p>
    <img
        border="0"
        width="629"
        height="289"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image004.jpg"
    />
</p>
<p>
    And if we click <strong>again</strong> at the <strong>same seat</strong>,
    the <strong>expected</strong> <strong>result</strong> should be:
</p>
<p>
    <img
        border="0"
        width="628"
        height="288"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image006.jpg"
    />
</p>
<p>
    <strong>
        Note: You must keep track of the profit of all tickets sold and the
        number of all fans.
    </strong>
</p>
<p>
    <strong>
        If the ‘Summary’ button is clicked. You should print the profit of all
        tickets and the number of all fans, as shown below.
    </strong>
    <strong><u></u></strong>
</p>
<h3>
    Examples
</h3>
<p>
    <strong>
        Sequence of clicks - LITEX 5 A -&gt; LITEX 5 B -&gt; LITEX 5 A -&gt;
        VIP 1 A
    </strong>
</p>
<p>
    <img
        border="0"
        width="628"
        height="289"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image008.jpg"
    />
</p>
<p>
    <strong>
        Sequence of clicks - LITEX 5 A -&gt; LEVSKI 2 A -&gt; LEVSKI 3 B -&gt;
        VIP 4 C -&gt; LITEX 3 B -&gt; LEVSKI 2 A -&gt;
        <br/>
        LITEX 5 B -&gt; LITEX 5 A -&gt; VIP 1 A
    </strong>
</p>
<p>
    <img
        border="0"
        width="629"
        height="280"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image010.jpg"
    />
</p>

<h1>
    JS Fundamentals: Test Exam
</h1>
<p>
    <em>This is a test exam for course </em>
    <a href="https://softuni.bg/courses/javascript-fundamentals">
        <em>JavaScript Fundamentals</em>
    </a>
    <em> at SoftUni.</em>
</p>
<h2>
    Problem 2. Crossword
</h2>
<p>
You will receive a <strong>string</strong> into    <strong>Input field. </strong>After that one of the main commands
    properties will be filled with certain information.
</p>
<p>
    Here are all the possible commands and secondary commands:
</p>
<ul>
    <li>
        <strong>filter</strong>
    </li>
</ul>
<p>
    o <strong>UPPERCASE </strong>– filter all the uppercase letters then take
    the character at the given position
</p>
<p>
    o <strong>LOWERCASE </strong>– filter all the lowercase letters then take
    the character at the given position
</p>
<p>
    o <strong>NUMS</strong> – filter all the digits and take the digit at the
    given position
</p>
<ul>
    <li>
        <strong>sort</strong>
    </li>
</ul>
<p>
    o <strong>A </strong>– sort all the characters alphabetically and then take
    the character at the given position
</p>
<p>
    o <strong>Z</strong> – sort all the characters alphabetically in descending
    order and take the character at the given position
</p>
<ul>
    <li>
        <strong>rotate</strong>
    </li>
</ul>
<p>
    o The secondary command will be a number representing how many times to
    rotate the string (rotation means that the last element becomes first) –
    when it’s done, take the character at the given position
</p>
<ul>
    <li>
        <strong>get</strong>
    </li>
</ul>
<p>
    o Just get the character at the given position (in this case there is no
    secondary command)
</p>
<p>
    <strong>
        <u>NOTE: consider the position as a position, not an index</u>
    </strong>
    <strong><u></u></strong>
</p>
<p>
When a <strong>button</strong> from a main command    <strong>fieldeset</strong> is <strong>clicked</strong>, the result from
    that command must be <strong>appended</strong> to the paragraph into div
    element with <strong>id</strong> "<strong>output</strong>".
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="324" valign="top">
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
            <td width="324" valign="top">
                <p>
                    Input string: <strong>AkIoRpSwOzFdT</strong>
                    <br/>
Main command: <strong>Filter</strong> -&gt;                    <strong>UPPERCASE</strong> <strong>4</strong>
                </p>
                <p>
                    --
                </p>
                <p>
                    Input string: <strong>AOB</strong>
                </p>
                <p>
Main command: <strong>Sort</strong> -&gt;                    <strong>A</strong> <strong>3</strong>
                </p>
                <p>
                    --
                </p>
                <p>
                    Input string: <strong>FAILCL</strong>
                </p>
                <p>
                    <strong>Main command: Sort </strong>
                    -&gt; <strong>A 3</strong>
                </p>
                <p>
                    --
                </p>
                <p>
                    Input string: <strong>OUTAGN</strong>
                </p>
                <p>
Main command: <strong>Sort</strong> -&gt;                    <strong>Z 2</strong>
                </p>
                <p>
                    <strong>--</strong>
                </p>
                <p>
                    Input string: <strong>01S345U7N</strong>
                </p>
                <p>
Main command: <strong>Filter</strong> -&gt;                    <strong>UPPERCASE 2</strong>
                </p>
                <p>
                    <strong>--</strong>
                </p>
                <p>
                    Input string: <strong>DAN</strong>
                </p>
                <p>
Main command: <strong>Rotate</strong> -&gt;                    <strong>2 2</strong>
                </p>
                <p>
                    <strong>--</strong>
                </p>
                <p>
                    Input string: <strong>PING</strong>
                </p>
                <p>
                    Main command: <strong>Get</strong> -&gt; <strong>2</strong>
                </p>
                <p>
                    <strong>--</strong>
                </p>
                <p>
                    Input string: <strong>?- 654</strong>
                </p>
                <p>
                    Main command: <strong>Get</strong> -&gt; <strong>3</strong>
                </p>
            </td>
            <td width="318" valign="top">
                <p>
                    <strong>"SOFTUNI "</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>


<h1>
    JS Fundamentals: Test Exam
</h1>
<p>
    <em>This is a test exam for course </em>
    <a href="https://softuni.bg/courses/javascript-fundamentals">
        <em>JavaScript Fundamentals</em>
    </a>
    <em> at SoftUni</em>
</p>
<h2>
    Problem 3. Extractor
</h2>
<p>
    <img
        border="0"
        width="629"
        height="262"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image002.jpg"
    />
</p>
<p>
You will receive a single string. It will<strong>start with a number</strong> and that number represents the<strong>count of characters</strong> you need to    <strong>take from the string</strong> (<strong><u>excluding</u></strong>
    the <strong>characters of the number</strong>).
</p>
<p>
Then after you took all the characters you have to see what<strong>character is in the end</strong>. That is the character you need to    <strong>split the string by</strong>.
</p>
<p>
    After you have done that, you will get <strong>2 parts</strong>.
</p>
<ul>
    <li>
The first part is a <strong>sequence of characters</strong> you need to        <strong>remove</strong> from the <strong>second part</strong> and it is
        a <strong>regex pattern</strong>. More detailed information below.
    </li>
</ul>
<p>
    · In the second part, after you have removed all the characters from the
first part, you need to <strong>replace</strong> all the    <strong>"#" </strong>with <strong>" "</strong>
</p>
<p>
    Finally, <strong>print what is left from the second string.</strong>
</p>
<h3>
    Example:
</h3>
<p>
Input:<strong> </strong><strong>47</strong><strong>*0-9%&amp;</strong><strong>+</strong><strong>I</strong><strong>2'</strong><strong>m</strong><strong>0</strong><strong>#a#stu</strong><strong>59%</strong><strong>d</strong><strong>%</strong><strong>e</strong><strong>&amp;</strong><strong>nt#a</strong><strong>9</strong><strong>t#So</strong><strong>00</strong><strong>ft</strong><strong>%</strong><strong>Uni</strong><strong>*</strong><strong>!</strong>    <strong>+</strong><strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    First we <strong>take 47 characters</strong> (all of them), then we look at
the last character and split by it, so we get these<strong>two strings</strong> <strong>"*0-9%&amp;"</strong> and    <strong>"I2'm0#a#stu59%d%e&amp;nt#a9t#So00ft%Uni*!"</strong>.
</p>
<p>
    <br/>
We create a regex from the first one and we get    <strong>"[*0-9%&amp;]"</strong>, we use it on the second string, after that
    we replace the <strong>"#"</strong> with <strong>" "</strong> and at the
    end we get: <strong>"I'm a student at SoftUni!"</strong><strong></strong>
</p>
<h3>
    Input/Constrains
</h3>
<p>
    · You will receive a single string you need to manipulate
</p>
<ul>
    <li>
        The input will always be valid
    </li>
</ul>
<h3>
    Output
</h3>
<ul>
    <li>
When the "<strong>EXTRACT</strong>" button is <strong>clicked</strong>,<strong>print</strong> the <strong>result</strong> into        <strong>output</strong> <strong>textarea element.</strong>
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="403" valign="top">
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
            <td width="403" valign="top">
                <p>
                    47*0-9%&amp;+I0'm0#a#stu99%d%e&amp;nt#a9t#So00ft%Uni*!+
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    I'm a student at SoftUni!
                </p>
            </td>
        </tr>
        <tr>
            <td width="403" valign="top">
                <p>
                    67%!3-7=@+Ja45v=aS67cri!pt#Co%@@re#-#Fun4%!d=am6e@5n7t%!als#-#2018+
                </p>
            </td>
            <td width="228" valign="top">
                <p>
                    JavaScript Core - Fundamentals - 2018
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <img
        border="0"
        width="629"
        height="261"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image004.jpg"
    />
</p>

<h1>
    JS Fundamentals: Test Exam
</h1>
<p>
    <em>This is a test exam for course </em>
    <a href="https://softuni.bg/courses/javascript-fundamentals">
        <em>JavaScript Fundamentals</em>
    </a>
    <em> at SoftUni</em>
</p>
<h2>
    Problem 4. Trucks
</h2>
<p>
    <img
        border="0"
        width="629"
        height="252"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image002.jpg"
    />
</p>
<p>
You have to keep track of all of your <strong>trucks</strong> and their<strong>tire's conditions</strong>. Each truck has a    <strong>plate number</strong>, a total of <strong>8 tires</strong>, each
    one is a number representing <strong>how good its condition is</strong> and
it also needs to keep track of    <strong>each trucks travelled distance</strong>.
</p>
<p>
    You will receive a <strong>sequence</strong> of <strong>inputs</strong>
    for, each <strong>input</strong> will <strong>some information</strong>
    about <strong>one</strong> of the following <strong>commands</strong>:
</p>
<ul>
    <li>
        <strong>"NEWTRUCK"</strong>
–        <strong>Plate number: C111AA, Tires Condition: 5 5 5 5 5 5 5 5</strong>
        <br/>
        that means you have to <strong>add a new truck</strong> if you don’t
have it already with the given <strong>plate number</strong> and the        <strong>tires</strong>.
    </li>
    <li>
        <strong>"NEWTIRES"</strong>
        – <strong>Tires Condition:</strong><strong> 7 7 7 7 7 7 7 7</strong> –
        add the given tires in a collection of <strong>backup tires</strong>.
        You might need to use them later
    </li>
    <li>
        <strong>"WORK"</strong>
        –<strong> Plate number: C111AA, Distance: 7000</strong> – that means
        that <strong>if you have that truck</strong> (with the given plate
        number), it <strong>has to travel a given amount of kilometers</strong>
. Every <strong>1000</strong> kilometers the quality of each tire        <strong>reduces by 1</strong>. You have to calculate if the
        <strong>
            quality of all the tires of the truck is enough to travel that
            distance
        </strong>
        .
    </li>
</ul>
<p>
o If it is, <strong>reduce the quality</strong> of<strong>each tire</strong> with the <strong>needed amount</strong> and<strong>add the kilometers</strong> to the truck's    <strong>total distance</strong>
</p>
<p>
    o If it is not, <strong>try to change the tires</strong> (if you have any
    backups) <strong><u>once</u></strong> and do that calculations again. If
    after the <strong>change the tires the truck can travel</strong>, do it,
    otherwise the <strong>truck does not travel</strong> and you have to
    proceed.
</p>
<p>
    <strong>
        At the end of the shift (when "<u>End of the shift</u>" button is
        clicked)
    </strong>
    , print into <strong>textarea element</strong> for each truck information
in the following format:    <strong>"Truck {plateNumber} has traveled {trucksDistance}."</strong>. And
finally print how many sets of tires you have as backup in the format:    <strong>"You have {setsCount} sets of tires left."</strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>Note: </strong>
"<strong>Backup" tires sets</strong>" element into the skeleton<strong>contains all tire sets registered like NEWTIRES</strong>.<strong>Every tire</strong> <strong>set</strong> into "    <strong>Backup tire sets</strong>" must be in a <strong>div elemen</strong>
t with <strong>class</strong> "<strong>tireSet</strong>".<strong>If</strong> <strong>some tire set</strong> from the "<strong>Backup tires sets</strong>" is <strong>used</strong> you<strong>must remove</strong> the <strong>div element</strong> that    <strong>contains this set of tires</strong>.
</p>
<p>
And "<strong>Trucks</strong>" element into skeleton<strong>contains all trucks registered like NEWTRUCK</strong>.<strong>Every truck</strong> into "<strong>Trucks</strong>" must be in a<strong>div element</strong> with <strong>class</strong> "    <strong>truck</strong>".
</p>
<h3>
    Input/Constrains
</h3>
<ul>
    <li>
        The input will always be in a valid format
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    · Look at the examples for more clarity
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="426" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="266" valign="top">
                <p align="center">
                    <strong>Report output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="426" valign="top">
                <p>
                    NEWTRUCK
                    <br/>
                    - Plate number: C1111AA
                </p>
                <p>
                    - Tires Condition: 7 7 7 7 7 7 7 7
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTRUCK
                </p>
                <p>
                    - Plate number: C2222AA
                </p>
                <p>
                    - Tires Condition: 5 5 5 5 5 5 5 5
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 8 8 8 8 8 8 8 8
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 4 4 4 4 4 4 4 4
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 5 5 5 5 5 5 5 5
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: C1111AA
                </p>
                <p>
                    - Distance: 7700
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: C2222AA
                </p>
                <p>
                    - Distance: 6000
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: C1111AA
                </p>
                <p>
                    - Distance: 3000
                </p>
            </td>
            <td width="266" valign="top">
                <p>
                    Truck C1111AA has traveled 10700.
                </p>
                <p>
                    Truck C2222AA has traveled 0.
                </p>
                <p>
                    You have 0 sets of tires left.
                </p>
            </td>
        </tr>
        <tr>
            <td width="426" valign="top">
                <p>
                    NEWTRUCK
                </p>
                <p>
                    - Plate number: B1002SA
                </p>
                <p>
                    - Tires Condition: 17 17 17 17 17 17 17 17
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 8 8 4 8 8 8 9 8
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 4 4 5 4 4 7 4 4
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    NEWTIRES
                </p>
                <p>
                    - Tires Condition: 5 1 5 5 5 7 5 1
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: B1002SA
                </p>
                <p>
                    - Distance: 7700
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: B1002SA
                </p>
                <p>
                    - Distance: 6000
                </p>
                <p>
                    ------------------------------------------------
                </p>
                <p>
                    WORK
                </p>
                <p>
                    - Plate number: B1002SA
                </p>
                <p>
                    - Distance: 3000
                </p>
            </td>
            <td width="266" valign="top">
                <p>
                    Truck B1002SA has traveled 16700.
                </p>
                <p>
                    You have 3 sets of tires left.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <img
        border="0"
        width="629"
        height="258"
        src="file:///C:/Users/alenSavov/AppData/Local/Packages/oice_16_974fa576_32c1d314_2089/AC/Temp/msohtmlclip1/01/clip_image004.jpg"
    />
</p>