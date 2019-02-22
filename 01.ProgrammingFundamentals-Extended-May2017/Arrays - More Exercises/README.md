<h1>
    More Exercises: Arrays
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
    <a href="https://judge.softuni.bg/Contests/422">
        https://judge.softuni.bg/Contests/422
    </a>
    .
</p>
<h2>
    1. Last 3 Consecutive Equal Strings
</h2>
<p>
Read an array of <strong>strings</strong> and find the    <strong>last three</strong> consecutive equal strings.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="439" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="181" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="439" valign="top">
                <p>
one one one one two hi hi my echo                    <strong>last last last</strong> pi
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    last last last
                </p>
            </td>
        </tr>
        <tr>
            <td width="439" valign="top">
                <p>
                    Gosho had a <strong>little little little</strong> lamb
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    little little little
                </p>
            </td>
        </tr>
        <tr>
            <td width="439" valign="top">
                <p>
                    no shirt shirt shirt no <strong>shoes shoes shoes</strong>
                    no service
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    shoes shoes shoes
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Array Elements Equal to Their Index
</h2>
<p>
    Read an array of <strong>integers</strong> and extract the elements which
    have the <strong>same value</strong> as their <strong>index</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="189" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="181" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
1 <strong>1</strong> 1 1 <strong>4</strong> 2 1 3                    <strong>8</strong> <strong>9</strong> 5
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    1 4 8 9
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
2 5 <strong>2</strong> 24 254 <strong>5</strong>                    <strong>6</strong>
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    2 5 6
                </p>
            </td>
        </tr>
        <tr>
            <td width="189" valign="top">
                <p>
                    <strong>0 1 2 3 4 5 6 7 8</strong>
                    8
                </p>
            </td>
            <td width="181" valign="top">
                <p>
                    0 1 2 3 4 5 6 7 8
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Phonebook
</h2>
<p>
    You will be given an array of <strong>phone numbers</strong> (strings) and
    an array of <strong>names </strong>(strings). After which, you will be
    given <strong>strings on new lines</strong>, <strong>until</strong> you
    receive the command “done”. Find the <strong>numbers</strong>, which
    correspond to the <strong>names</strong> and print them on the console in
    the following format:
</p>
<ul>
    <li>
        {name} -&gt; {number}
    </li>
</ul>
<p>
A number corresponds to a name when it’s located on the    <strong>same position</strong> as its corresponding <strong>name</strong>
    in both arrays.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="366" valign="top">
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
            <td width="366" valign="top">
                <p>
                    0888888888 0888123456 +359886001122
                </p>
                <p>
                    Nakov Ivan Maria
                </p>
                <p>
                    Ivan
                </p>
                <p>
                    Maria
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Ivan -&gt; 0888123456
                </p>
                <p>
                    Maria -&gt; +359886001122
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    (602)207-2544 +918671613200 1-661-335-8202
                </p>
                <p>
                    John Prakash Felix
                </p>
                <p>
                    Felix
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Felix -&gt; 1-661-335-8202
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    0882983983 0822223321 0898128398 0878223211
                </p>
                <p>
                    Vasil Hristo Georgi Luben
                </p>
                <p>
                    Vasil
                </p>
                <p>
                    Luben
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="197" valign="top">
                <p>
                    Vasil -&gt; 0882983983
                </p>
                <p>
                    Luben -&gt; 0878223211
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. * Phone
</h2>
<p>
This is an upgrade of the previous problem. Implement the    <strong>phonebook</strong> functionality from the previous problem with
    this additional functionality:
</p>
<p>
    · call {number/name} -&gt; print “calling {name/number}…”
</p>
<p>
    o If the <strong>sum of the digits</strong> (ignore other characters) of
    the number is <strong>odd</strong>, print “no answer”.
</p>
<p>
    o If the <strong>sum of the digits</strong> (ignore other characters) of
    the number is <strong>even</strong>, print “call ended. duration:
{duration}”. The duration is calculated from the    <strong>sum of the digits</strong> in the format “mm:ss”
</p>
<ul>
    <li>
        message {number/name} -&gt; print “sending sms to {name/number}...”
    </li>
</ul>
<p>
    o if the <strong>difference</strong> <strong>of the digits</strong> (ignore
    other characters) of the number is <strong>odd</strong>, print “busy”
</p>
<p>
    o if the <strong>difference of the digits</strong> (ignore other
    characters) of the number is <strong>even</strong>, print “meet me there”
</p>
<h3>
    Constraints
</h3>
<p>
    · The numbers will contain the digits 0-9 and might contain the plus sign
    +. They will <strong>always be valid</strong> and in this format.
</p>
<ul>
    <li>
        The numbers and names will be <strong>unique</strong> – there will be
no cases of <strong>repeated numbers</strong> or        <strong>repeated names</strong>.
    </li>
    <li>
        The names and numbers will <strong>always</strong> be separated by
        exactly <strong>one</strong> whitespace.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="366" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="286" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    0888888888 0888123456 +359886001122
                </p>
                <p>
                    Nakov Ivan Maria
                </p>
                <p>
                    call 0888888888
                </p>
                <p>
                    call Ivan
                </p>
                <p>
                    message Maria
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    calling Nakov...
                </p>
                <p>
                    call ended. duration: 01:12
                </p>
                <p>
                    calling 0889123456...
                </p>
                <p>
                    no answer
                </p>
                <p>
                    sending sms to +359886001122...
                </p>
                <p>
                    busy
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    (602)207-2544 +918671613200 1-661-335-8202
                </p>
                <p>
                    John Prakash Felix
                </p>
                <p>
                    call Prakash
                </p>
                <p>
                    call John
                </p>
                <p>
                    call Felix
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    calling +918671613200
                </p>
                <p>
                    call ended. duration: 00:44
                </p>
                <p>
                    calling (602)207-2544
                </p>
                <p>
                    call ended. duration: 00:32
                </p>
                <p>
                    calling 1-661-335-8202
                </p>
                <p>
                    no answer
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    0882983983 0822223321 0898128398 0878223211
                </p>
                <p>
                    Vasil Hristo Georgi Luben
                </p>
                <p>
                    message Vasil
                </p>
                <p>
                    message 0878223211
                </p>
                <p>
                    message Hristo
                </p>
                <p>
                    done
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    sending sms to 0882983983...
                </p>
                <p>
                    meet me there
                </p>
                <p>
                    sending sms to Luben
                </p>
                <p>
                    meet me there
                </p>
                <p>
                    sending sms to 0822223321...
                </p>
                <p>
                    busy
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Char Rotation
</h2>
<p>
    You are given <strong>two lines of input</strong>: a string and an int
    array. Modify the elements in the first array by the second array,
    following these conditions:
</p>
<ul>
    <li>
If the element at the position is <strong>even</strong>,        <strong>subtract</strong> its value to the ASCII code of the character
        on the same position.
    </li>
    <li>
If the element at the position is <strong>odd</strong>,        <strong>add </strong>its value to the ASCII code of the character on
        the same position.
    </li>
</ul>
<p>
    After that, <strong>print</strong> the resulting string.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="366" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="286" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    $wM+J_H
                </p>
                <p>
                    47 8 25 73 11 15 33
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    SoftUni
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    tszL
                </p>
                <p>
                    18 10 8 21
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    bira
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    luFqfd~}
                </p>
                <p>
                    6 2 41 14 3 1 10 4
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    fsociety
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · You can use the string.ToCharArray() or the string.Split('') methods to
    turn the initial input from a string into an array.
</p>
<h2>
    6. * Power Plants
</h2>
<p>
    Ever heard of <strong>Power Plants</strong>? Power Plants are a special
    type of plant which collectively withers and blooms in strange ways.
</p>
<p>
    You will receive an <strong>array</strong> of <strong>integers</strong>,
    holding the plants’ <strong>power</strong> <strong>level</strong>. If a
    plant’s power reaches <strong>0</strong>, it <strong>dies</strong>.
</p>
<p>
    The plants get more and more withered each <strong>day</strong>, and so –
    their power <strong>decreases</strong> by 1, except for one special plant,
    which <strong>blooms</strong> instead. The special plant which blooms is
the one whose <strong>index</strong> corresponds to the<strong>current day</strong>. Its power is increased by 1, but only if it    <strong>isn’t dead </strong>(but since it has withered the same day,
    realistically its power stays the same).
</p>
<p>
    When a season ends, all plants which are still alive <strong>bloom</strong>
. The season ends when the <strong>Nth</strong> day is reached,    <strong>N</strong> being the total number of plants.
</p>
<p>
    Your task is to calculate how many days and seasons it will take for all
    the plants to <strong>die</strong>. Print them on the console in the
    following format: “survived {days} days ({seasons} seasons)”
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="112" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="294" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
            <td width="278" valign="top">
                <p align="center">
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="112" valign="top">
                <p>
                    1 2 3 4
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    survived 6 days (1 season)
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    x -&gt; day index, y -&gt; withering
                </p>
                <p>
                    initial: 1 2 3 4
                </p>
                <p>
                    day 0: 1 1 2 3
                </p>
                <p>
                    day 1: 0 1 1 2
                </p>
                <p>
                    day 2: 0 0 1 1
                </p>
                <p>
                    day 3: 0 0 0 1
                </p>
                <p>
                    season over: 0 0 0 2 (alive ++)
                </p>
                <p>
                    day 4: 0 0 0 1
                </p>
                <p>
                    day 5: 0 0 0 0
                </p>
                <p>
                    days survived è 6, seasons è 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="112" valign="top">
                <p>
                    3 3 3 3
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    survived 4 days (0 seasons)
                </p>
            </td>
            <td width="278" valign="top">
                <p>
                    x -&gt; day index, y -&gt; withering
                </p>
                <p>
                    initial: 3 3 3 3
                </p>
                <p>
                    day 0: 3 2 2 2
                </p>
                <p>
                    day 1: 2 2 1 1
                </p>
                <p>
                    day 2: 1 1 1 0
                </p>
                <p>
                    day 3: 0 0 0 0
                </p>
                <p>
                    days survived è 4, seasons è 0
                </p>
            </td>
        </tr>
        <tr>
            <td width="112" valign="top">
                <p>
                    10409 32 2
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    survived 31224 days (10407 seasons)
                </p>
            </td>
            <td width="278" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. ** Resizable Array
</h2>
<p>
You will be given a series of commands on the console. Create an empty    <strong>, </strong>4 element<strong> integer array</strong>. Until you
    receive the command "end", process the following commands:
</p>
<ul>
    <li>
        <strong>push {number}</strong>
        – <strong>add</strong> the number to the <strong>end</strong> of the
        array.
    </li>
    <li>
        <strong>pop</strong>
        – <strong>remove</strong> the <strong>last</strong> number from the
        array<strong></strong>
    </li>
    <li>
        <strong>removeAt {index}</strong>
– <strong>remove</strong> the number at the given        <strong>index</strong> and <strong>shift</strong> all elements to its
        right to the <strong>left</strong> to fill its room.<strong></strong>
    </li>
</ul>
<p>
    o example: [1 2 3 4 5] -&gt; removeAt 2 -&gt; [1 2 4 5]
</p>
<ul>
    <li>
        <strong>clear</strong>
        – <strong>erase</strong> all the contents of the array<strong></strong>
    </li>
</ul>
<p>
    If at any point, the array becomes too small to hold the elements (such as
when adding too many elements), create a new array at    <strong>twice the size </strong>of the original one and fill it up with the
    elements of the original array. Then continue executing the commands. After
    you receive the “end” command, <strong>print</strong> the array in its
final state, <strong>separating</strong> the elements by a    <strong>single space</strong>. If there are no elements left in the array,
    print “empty array”
</p>
<p>
    <em>
Note: for this problem, you are not allowed to use the        <strong>List&lt;T&gt; </strong>data structure or any similar resizable
        array solutions.
    </em>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="366" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="286" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    push 1
                </p>
                <p>
                    push 2
                </p>
                <p>
                    push 3
                </p>
                <p>
                    push 4
                </p>
                <p>
                    push 5
                </p>
                <p>
                    removeAt 2
                </p>
                <p>
                    pop
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    1 2 4
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    push 2
                </p>
                <p>
                    push 4
                </p>
                <p>
                    push 3
                </p>
                <p>
                    push 8
                </p>
                <p>
                    push 2
                </p>
                <p>
                    clear
                </p>
                <p>
                    push 7
                </p>
                <p>
                    push 7
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    7 7
                </p>
            </td>
        </tr>
        <tr>
            <td width="366" valign="top">
                <p>
                    push 2
                </p>
                <p>
                    push 4
                </p>
                <p>
                    push 12
                </p>
                <p>
                    push 33
                </p>
                <p>
                    push 150
                </p>
                <p>
                    clear
                </p>
                <p>
                    push 11
                </p>
                <p>
                    push 12
                </p>
                <p>
                    removeAt 1
                </p>
                <p>
                    removeAt 0
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    empty array
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    · Think about how you would implement the removal of elements. For
    instance, if you <strong>set them to</strong> <strong>0</strong>, you could
potentially get them <strong>mixed up</strong> with other    <strong>legitimate elements</strong> that have a value of 0. Search the
    internet for a structure, which allows having an integer which can be set
    to <strong>null</strong>.
</p>