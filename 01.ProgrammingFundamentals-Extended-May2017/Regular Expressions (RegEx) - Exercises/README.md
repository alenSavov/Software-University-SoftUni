<h1>
    Exercises: Regular Expressions (RegEx)
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        "Programming Fundamentals Extended" course @ Software University
    </a>
    . Please submit your solutions (source code) of all below described
    problems in <a href="https://judge.softuni.bg/Contests/444">Judge</a>.
</p>
<h2>
    1. Cards
</h2>
<p>
    You will be given sequences of playing cards. Your task is to print the
valid ones of them, separated by a <strong>comma</strong> and a    <strong>space</strong>.
</p>
<p>
    The <strong>VALID playing cards</strong> have:
</p>
<ul>
    <li>
        <strong>power</strong>
– <strong>2</strong>, <strong>3</strong>, <strong>4</strong>…<strong>10</strong>, <strong>J</strong>, <strong>Q</strong>,        <strong>K</strong>, <strong>A</strong>.
    </li>
    <li>
        <strong>suit</strong>
– <strong>S</strong>, <strong>H</strong>, <strong>D</strong>,        <strong>C</strong>
    </li>
</ul>
<p>
    A card is formed by its power and its suit in the following format:
{power}{suit}. . ., but <strong>ONLY </strong>those with<strong>valid</strong> <strong>power</strong> and<strong>valid suit</strong>, should be <strong>considered</strong>    <strong>VALID</strong>.
</p>
<p>
So a valid car would look like this: <strong>KS</strong>,    <strong>10S</strong>, <strong>2D</strong>, <strong>3D</strong>.
</p>
<h3>
    Input
</h3>
<p>
    The input will consist of a <strong>single line</strong>, containing a
    sequence of cards.
</p>
<h3>
    Output
</h3>
<p>
    The output should be a single line, containing the valid cards, separated
    by a <strong>comma</strong> and a <strong>space</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="370" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="261" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="370" valign="top">
                <pre>2S3S4S5S6S</pre>
            </td>
            <td width="261" valign="top">
                <pre>2S, 3S, 4S, 5S, 6S</pre>
            </td>
        </tr>
        <tr>
            <td width="370" valign="top">
                <pre>2SASKS6SJSQSOS</pre>
            </td>
            <td width="261" valign="top">
                <pre>2S, AS, KS, 6S, JS, QS</pre>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Fish Statistics
</h2>
<p>
    You are a marine biologist tasked with researching various types of fish.
    You will receive a <strong>single line</strong> on the console as input.
From this line, you must extract <strong>all the fish</strong> you find and<strong>print statistics</strong> about <strong>each</strong>    <strong>one</strong>.
    <br/>
Fish are categorized by three criteria: <strong>tail length</strong>,    <strong>body length</strong> and <strong>status</strong>. A standard fish
    looks like this:
</p>
<table border="1" cellspacing="0" cellpadding="0" align="left">
    <tbody>
        <tr>
            <td width="132" valign="top">
                <p>
                    &gt;&lt;(((('&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <br clear="all"/>
This fish has a <strong>tail length </strong>of <strong>1</strong>, a<strong>body length </strong>of <strong>4</strong> and has the<strong>status</strong> “<strong>Awake</strong>”, since its    <strong>eye is open</strong>. <strong>One ASCII character</strong>
    represents 2 <strong>centimeters</strong> in real life. By those standards,
this fish has a <strong>tail length</strong> of <strong>2 cm</strong> and a<strong>body length</strong> of <strong>8 cm</strong>. There are various    <strong>types</strong> of <strong>tails</strong>, <strong>bodies </strong>
    and <strong>statuses</strong>, which are described below:
</p>
<ul>
    <li>
        Tail types:
    </li>
</ul>
<p>
    o Tail <strong>longer</strong> than <strong>5</strong> “&lt;” characters à
    Long
</p>
<p>
    o Tail <strong>longer</strong> than <strong>1</strong> “&lt;” characters à
    Medium
</p>
<p>
o Tail, which is <strong>1</strong> “&lt;” character long à    <strong>Short</strong>
</p>
<p>
    o Nonexistent tail à <strong>None</strong>
</p>
<ul>
    <li>
        Body types:
    </li>
</ul>
<p>
    o Body <strong>longer</strong> than <strong>10</strong> “(” characters à
    Long
</p>
<p>
    o Body <strong>longer</strong> than <strong>5</strong> “(” characters à
    Medium
</p>
<p>
    o Any other length à <strong>Short</strong>
</p>
<ul>
    <li>
        Statuses:
    </li>
</ul>
<p>
    o <strong>'</strong> à Awake
</p>
<p>
    o <strong>-</strong> à Asleep
</p>
<p>
    o <strong>x</strong> à Dead
</p>
<p>
    The input will contain a <strong>variable amount of fish</strong>,
separated by any sequence of <strong>ASCII characters</strong>. There’s a<strong>possibility</strong> you might receive input, which has    <strong>no fish</strong> – in this case, just print “No fish found.”, and
    end the program.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="447" valign="top">
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
            <td width="447" valign="top">
                <pre>&gt;&lt;(((('&gt; &gt;&gt;&gt;&gt;&lt;((((((((('&gt;~~~~~&lt;((-&gt;~~~  o o &gt;&gt;&gt;&gt;&lt;((x&gt;</pre>
            </td>
            <td width="237" valign="top">
                <pre>Fish 1: &gt;&lt;(((('&gt;</pre>
                <pre>  Tail type: Short (2 cm)</pre>
                <pre>  Body type: Short (8 cm)</pre>
                <pre>  Status: Awake</pre>
                <pre>Fish 2: &gt;&gt;&gt;&gt;&lt;((((((((('&gt;</pre>
                <pre>  Tail type: Medium (8 cm)</pre>
                <pre>  Body type: Medium (18 cm)</pre>
                <pre>  Status: Awake</pre>
                <pre>Fish 3: &lt;((-&gt;</pre>
                <pre>  Tail type: None</pre>
                <pre>  Body type: Short (4 cm)</pre>
                <pre>  Status: Asleep</pre>
                <pre>Fish 4: &gt;&gt;&gt;&gt;&lt;((x&gt;</pre>
                <pre>  Tail type: Medium (8 cm)</pre>
                <pre>  Body type: Short (4 cm)</pre>
                <pre>  Status: Dead</pre>
            </td>
        </tr>
        <tr>
            <td width="447" valign="top">
                <pre>            o oo     &gt;&gt;&gt;&gt;&lt;((-&gt;           * ()()()():</pre>
            </td>
            <td width="237" valign="top">
                <pre>Fish 1: &gt;&gt;&gt;&gt;&lt;((-&gt;</pre>
                <pre>  Tail type: Medium (8 cm)</pre>
                <pre>  Body type: Short (4 cm)</pre>
                <pre>  Status: Asleep</pre>
            </td>
        </tr>
        <tr>
            <td width="447" valign="top">
                <pre>o  o     &gt;&lt;(-&gt; &gt;&gt;&lt;(('&gt; &lt;(((((((((x&gt;  *  #%#$@     *</pre>
            </td>
            <td width="237" valign="top">
                <pre>Fish 1: &gt;&lt;(-&gt;</pre>
                <pre>  Tail type: Short (2 cm)</pre>
                <pre>  Body type: Short (2 cm)</pre>
                <pre>  Status: Asleep</pre>
                <pre>Fish 2: &gt;&gt;&lt;(('&gt;</pre>
                <pre>  Tail type: Medium (4 cm)</pre>
                <pre>  Body type: Short (4 cm)</pre>
                <pre>  Status: Awake</pre>
                <pre>Fish 3: &lt;(((((((((x&gt;</pre>
                <pre>  Tail type: None</pre>
                <pre>  Body type: Medium (18 cm)</pre>
                <pre>  Status: Dead</pre>
            </td>
        </tr>
        <tr>
            <td width="447" valign="top">
                <pre>o xx xxxx  ~ ~ ~ xxxx</pre>
            </td>
            <td width="237" valign="top">
                <pre>No fish found.</pre>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Word encounter
</h2>
<p>
You will be given a <strong>filter</strong>, in the form of a<strong>string</strong> of <strong>two characters </strong>– the<strong>first</strong> being an <strong>ASCII character</strong>, and the    <strong>second</strong> – a <strong>digit</strong>.
</p>
<p>
    You will then receive a <strong>sequence of sentences</strong>. You must
extract <strong>all words</strong> from those sentences, and print<strong>only</strong> the <strong>words</strong> that<strong>contain</strong> the <strong>given filter character</strong>,    <strong>at least</strong> <strong>N times</strong> – <strong>N</strong>
    being the <strong>filter digit</strong>.
</p>
<p>
    There are <strong>2 types</strong> of sentences – <strong>Valid</strong>
and <strong>Invalid</strong>. The <strong>valid ones</strong>, always<strong>start</strong> with a <strong>capital</strong>    <strong>letter</strong>, and <strong>always</strong> <strong>end</strong>
with one of the following characters: “<strong>.</strong>”, “    <strong>!</strong>”, “<strong>?</strong>”. Invalid sentences, should be
    ignored.
</p>
<p>
    <strong>Note</strong>
: You <strong>WILL NOT</strong> be given more than    <strong>1 sentence</strong> on a <strong>single input line</strong>.
</p>
<p>
    The input sequence ends, when you receive the command “<strong>end</strong>
    ”. After that you must print all the filtered words, you’ve gathered.
</p>
<p>
The <strong>valid words</strong> must be printed, on a<strong>single line</strong>, <strong>separated</strong> by a    <strong>comma</strong> and a <strong>space</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="370" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="261" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="370" valign="top">
                <pre>l2</pre>
                <pre>This will, likely be a funny feeling, Laslo.</pre>
                <pre>Will you come to my playlife ;)?</pre>
                <pre>end</pre>
            </td>
            <td width="261" valign="top">
                <pre>will, likely, Will, playlife</pre>
            </td>
        </tr>
        <tr>
            <td width="370" valign="top">
                <pre>o1</pre>
                <pre>How about... No...</pre>
                <pre>Maaan, this is amazing! Yeah; I know bro!</pre>
                <pre>end</pre>
            </td>
            <td width="261" valign="top">
                <pre>How, about, No, know, bro</pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hint
</h3>
<p>
    Check if there is a way to find where a word, in a sentence, starts, and
    ends. There surely must be a way to do that with Regular Expressions.
</p>
<h2>
    4. Happiness Index
</h2>
<p>
You will be given a <strong>string</strong>, consisting of one or several    <strong> emoticons</strong> and random <strong>garbage characters</strong>
in-between them. Your task is to count the <strong>happy</strong> and<strong>sad</strong> emoticons and calculate the    <strong>happiness index</strong> of the string. The index is calculated by
    this formula: {happyEmoticonsCount} / {sadEmoticonsCount}. The happiness
    index is then <strong>rounded </strong>to the <strong>second</strong>
decimal place. <strong>Two</strong> emoticons will    <strong>never touch</strong>.
</p>
<p>
    The emoticons of all the emotion types are as follows:
</p>
<p>
    · Happy: :), :D, ;), :*, :], ;], :}, ;}, (:, *:, c:, [:, [;
</p>
<p>
    · Sad: :(, D:, ;(, :[, ;[, :{, ;{, ):, :c, ]:, ];
</p>
<p>
    After you calculate the happiness index, <strong>print</strong> the final
    emoticon score, following this format:
</p>
<p>
· Happiness index <strong>greater than or equal </strong>to    <strong> 2 </strong>à :D
</p>
<p>
    · Happiness index <strong>greater than 1 </strong>à :)
</p>
<p>
    · Happiness index <strong>equal </strong>to<strong> 1 </strong>à :|
</p>
<p>
    · Happiness index <strong>smaller than 1 </strong>à :(
</p>
<ul>
    <li>
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="455" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="177" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="455" valign="top">
                <pre>:)^%&amp;:)**&amp;:]v;)ff:(</pre>
            </td>
            <td width="177" valign="top">
                <pre>Happiness index: 4.00 :D<br/>
[Happy count: 4, Sad count: 1]</pre>
            </td>
        </tr>
        <tr>
            <td width="455" valign="top">
                <pre>&amp;&amp;:(&amp;:)z:)zz%%!%%!%%!%:(</pre>
            </td>
            <td width="177" valign="top">
                <pre>Happiness index: 1.00 :|</pre>
                <pre>[Happy count: 2, Sad count: 2]</pre>
            </td>
        </tr>
        <tr>
            <td width="455" valign="top">
                <pre>&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;]:bb:[&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;:}&lt;&lt;&lt;&lt;&lt;&lt;:(&lt;&lt;&lt;&lt;&lt;&lt;:)z:)z:)&amp;@^@%@</pre>
                <pre></pre>
            </td>
            <td width="177" valign="top">
                <pre>Happiness index: 1.33 :)<br/>
[Happy count: 4, Sad count: 3]</pre>
            </td>
        </tr>
        <tr>
            <td width="455" valign="top">
                <pre>;(&amp;m%td[:^i+@#:{eqk#n</pre>
            </td>
            <td width="177" valign="top">
                <pre>Happiness index: 0.50 :(</pre>
                <pre>[Happy count: 1, Sad count: 2]</pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<ul>
    <li>
        Regex
        <a href="http://www.regular-expressions.info/named.html">
            named capturing groups
        </a>
        might come in handy for this problem.
    </li>
</ul>
<h2>
    5. * Commits
</h2>
<p>
    Believe it or not, GitHub doesn’t process its commits using software. They
    achieve their versatile version control by employing the services of a
    small man, named Master Branch. Mr. Branch is sick of parsing the huge
    amounts of data every single day and needs your help.
</p>
<p>
Write a program, which receives <strong>lines</strong> of    <strong>URLs</strong>. Until you receive the command “git push”, your task
    is to <strong>parse</strong> the URLs, which come in the following format:
</p>
<p>
    <strong>
        https://github.com/{user}/{repo}/commit/{hash},{message},{additions},{deletions}
    </strong>
</p>
<p>
    Valid input will follow this format. If any input doesn’t follow this
    format, <strong>ignore it</strong>. The validation rules are as follows:
</p>
<ul>
    <li>
The <strong>username</strong> may contain<strong>alphanumeric characters </strong>(Latin letters and digits) and        <strong>hyphens</strong> (-).
    </li>
    <li>
The <strong>repository name</strong> may contain<strong>letters</strong>, <strong>hyphens</strong> and        <strong>underscores</strong>.
    </li>
    <li>
        The <strong>commit hash</strong> will be a <strong>SHA-1</strong> hash,
and as such, it may contain <strong>only</strong>        <strong>hexadecimal</strong> <strong>characters</strong> (digits and
        letters A through F). Since SHA-1 hashes are always 20 bytes long, the
commit hash will also <strong>always</strong> be        <strong>40 characters</strong> long.
    </li>
    <li>
The message may contain <strong>any</strong> character,        <strong>except</strong> the <strong>new</strong> <strong>line</strong>
        character.
    </li>
    <li>
        The <strong>additions</strong> and <strong>deletions</strong> are
        numbers and may <strong>only</strong> contain <strong>digits</strong>.
    </li>
</ul>
<p>
    While parsing the input, you also need to <strong>categorize </strong>it
for Mr. Branch. Every <strong>user</strong> has his own<strong>repos </strong>(a user cannot have two repos with the<strong>same name</strong>) and every <strong>repo</strong> has a list of<strong>commits</strong>. The users are<strong>sorted alphabetically by name</strong>. The repos are also<strong>sorted alphabetically by name</strong>. The    <strong>commits</strong> are sorted by <strong>order of insertion</strong>.
</p>
<p>
    After you receive the command “git push”, your task is to print information
    about the commits in the following format:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    {user}:
                </p>
                <p>
                    {repo}:
                </p>
                <p>
                    commit {hash}: {message} ({additionsCount} additions,
                    {deletionsCount} deletions)
                </p>
                <p>
                    commit {hash}: {message} ({additionsCount} additions,
                    {deletionsCount} deletions)
                </p>
                <p>
                    …
                </p>
                <p>
                    Total: {totalAdditionsCount} additions,
                    {totalDeletionsCount} deletions
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
            <td width="699" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <pre>https://github.com/gosho/http-parser/commit/f17c563aed112dabbdbe977fcdb88772be7d85eb,general fixes,14,3<br/>
https://github.com/pesho-1232/db-checker/commit/5ca49ccc157c98af2c71391223e4b254ee327134,fix SELECT statement,9,19<br/>
https://github.com/gosho/http-parser/commit/1f0abbdf5006b4a88aed1b72f9a937b35a5126dc,One does not simply merge into master,1,15<br/>
https://github.com/stamat4o/hackertools/commit/ddb473ab0304e5e843983da8b26925dbb3495afa,another big bag of changes,8,18<br/>
  <strong>git push</strong></pre>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="699" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <p>
                    gosho:
                </p>
                <p>
                    http-parser:
                </p>
                <p>
                    commit f17c563aed112dabbdbe977fcdb88772be7d85eb: general
                    fixes (14 additions, 3 deletions)
                </p>
                <p>
                    commit 1f0abbdf5006b4a88aed1b72f9a937b35a5126dc: One does
                    not simply merge into master (1 additions, 15 deletions)
                </p>
                <p>
                    Total: 15 additions, 18 deletions
                </p>
                <p>
                    pesho-1232:
                </p>
                <p>
                    db-checker:
                </p>
                <p>
                    commit 5ca49ccc157c98af2c71391223e4b254ee327134: fix SELECT
                    statement (9 additions, 19 deletions)
                </p>
                <p>
                    Total: 9 additions, 19 deletions
                </p>
                <p>
                    stamat4o:
                </p>
                <p>
                    hackertools:
                </p>
                <p>
                    commit ddb473ab0304e5e843983da8b26925dbb3495afa: another
                    big bag of changes (8 additions, 18 deletions)
                </p>
                <p>
                    Total: 8 additions, 18 deletions
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="699" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <p>
                    https://github.com/A4B5TR/ceca-music-player/commit/5ca49ccc157c98af2c71391223e4b254ee327134,implement
                    mile kitic,16,16
                </p>
                <p>
                    https://github.com/Huosey/3ds-hax/commit/c4994a26e7370d9e482e9317c9a0489648c83fc6,for
                    free,8,20
                </p>
                <p>
                    https://github.com/A4B5TR/ceca-music-player/commit/136aa8bd1ac90d58230767027db5d2d0f3a6b9a5,lots
                    and lots of changes,12,3
                </p>
                <p>
                    https://github.com/A4B5TR/ceca-music-player/commit/d5cdb78e9a10af7f929dfa070577ef548bdadbb9,stuff,17,3
                </p>
                <p>
                    https://github.com/dirtyhaxxor/csbotrepo/commit/8d99397247811cdc0210a92c9beb21bb20689dbc,add
                    rush b functionality,1,6
                </p>
                <p>
                    <strong>git push</strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="699" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <p>
                    A4B5TR:
                </p>
                <p>
                    ceca-music-player:
                </p>
                <p>
                    commit 5ca49ccc157c98af2c71391223e4b254ee327134: implement
                    mile kitic (16 additions, 16 deletions)
                </p>
                <p>
                    commit 136aa8bd1ac90d58230767027db5d2d0f3a6b9a5: lots and
                    lots of changes (12 additions, 3 deletions)
                </p>
                <p>
                    commit d5cdb78e9a10af7f929dfa070577ef548bdadbb9: stuff (17
                    additions, 3 deletions)
                </p>
                <p>
                    Total: 45 additions, 22 deletions
                </p>
                <p>
                    dirtyhaxxor:
                </p>
                <p>
                    csbotrepo:
                </p>
                <p>
                    commit 8d99397247811cdc0210a92c9beb21bb20689dbc: add rush b
                    functionality (1 additions, 6 deletions)
                </p>
                <p>
                    Total: 1 additions, 6 deletions
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="699" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <p>
                    https://github.com/prakash/thymeleef/commit/e97c8637a13bf911e55030681884c8301a67e1dd,[MAJOR
                    FEAT] minor fix,8,7
                </p>
                <p>
                    https://github.com/ivanov33/superstartup/commit/56e566a92b48e430b4a81fd05fe777fbd612e085,it's
                    5am. It works. I quit.,9,2
                </p>
                <p>
                    https://github.com/ivanov34/superstartup/commit/460afc15d7f7ab14be7966bc13019c17de96b3b2,sorry
                    I'm new. merged every branch to master,1990048,2913460
                </p>
                <p>
                    https://github.com/prakash/thymeleef/commit/f17c563aed112dabbdbe977fcdb88772be7d85eb,[MINOR
                    FEAT] fixed spelling error,19,14
                </p>
                <p>
                    https://github.com/ivanov35/superstartup/commit/ecd3e802dec29c41e7f4d653e1019749f4ca6eec,ivanov34
                    got fired.. rebased to 3rd commit..,6,20
                </p>
                <p>
                    https://github.com/ivanov34/superstartup/commit/71c2c02ccf8da0765d21a79bf9bcfe1dd87f1544,im
                    back,18,2
                </p>
                <p>
                    https://github.com/adamash/thyme$leef/commit/58033134ca5bfb1c2cd606513f02b854ba7529c9,hehe,1,2
                </p>
                <p>
                    https://github.com/prakash/thymeleef/commit/44b801d6aa6e37d5960d14734d10e87cfc6ec0a8,I'm
                    done,16,0
                </p>
                <p>
                    git push
                </p>
            </td>
        </tr>
    </tbody>
</table>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="699" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="699" valign="top">
                <p>
                    ivanov33:
                </p>
                <p>
                    superstartup:
                </p>
                <p>
                    commit 56e566a92b48e430b4a81fd05fe777fbd612e085: it's 5am.
                    It works. I quit. (9 additions, 2 deletions)
                </p>
                <p>
                    Total: 9 additions, 2 deletions
                </p>
                <p>
                    ivanov34:
                </p>
                <p>
                    superstartup:
                </p>
                <p>
                    commit 460afc15d7f7ab14be7966bc13019c17de96b3b2: sorry I'm
                    new. merged every branch to master (1990048 additions,
                    2913460 deletions)
                </p>
                <p>
                    commit 71c2c02ccf8da0765d21a79bf9bcfe1dd87f1544: im back
                    (18 additions, 2 deletions)
                </p>
                <p>
                    Total: 1990066 additions, 2913462 deletions
                </p>
                <p>
                    ivanov35:
                </p>
                <p>
                    superstartup:
                </p>
                <p>
                    commit ecd3e802dec29c41e7f4d653e1019749f4ca6eec: ivanov34
                    got fired.. rebased to 3rd commit.. (6 additions, 20
                    deletions)
                </p>
                <p>
                    Total: 6 additions, 20 deletions
                </p>
                <p>
                    prakash:
                </p>
                <p>
                    thymeleef:
                </p>
                <p>
                    commit e97c8637a13bf911e55030681884c8301a67e1dd: [MAJOR
                    FEAT] minor fix (8 additions, 7 deletions)
                </p>
                <p>
                    commit f17c563aed112dabbdbe977fcdb88772be7d85eb: [MINOR
                    FEAT] fixed spelling error (19 additions, 14 deletions)
                </p>
                <p>
                    commit 44b801d6aa6e37d5960d14734d10e87cfc6ec0a8: I'm done
                    (16 additions, 0 deletions)
                </p>
                <p>
                    Total: 43 additions, 21 deletions
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
· You can store information about the commits in a custom<strong>Commit</strong> class, which contains the<strong>commit hash</strong>, <strong>message</strong>,    <strong>additions</strong> and <strong>deletions</strong>. After that,
calculating the total additions and deletions per repo is only a    <strong>LINQ </strong>query away.
</p>