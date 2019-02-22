<h1 align="center">
    Exercises: Reflection and Attributes
</h1>
<p>
    This document defines the exercises for
    <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">
        "C# OOP Advanced" course @ Software University
    </a>
    .
    <br/>
    Please submit your solutions (source code) of all below described problems
    in
    <a
        href="https://judge.softuni.bg/Contests/263/Reflection-and-Attributes-Exercise"
    >
        Judge
    </a>
    .
</p>
<h2>
    Problem 1. Harvesting Fields
</h2>
<p>
    <em>Provided skeleton.</em>
</p>
<p>
    You are given a <strong>RichSoilLand</strong> class with lots of fields
    (look at the provided skeleton). Like a good farmer as what you are, you
    must harvest them. Harvesting means that you must print each field in a
    certain format (see output).
</p>
<h3>
    Input
</h3>
<p>
    You will receive a maximum of 100 lines with one of the following commands:
</p>
<ul>
    <li>
        <strong>private -</strong>
        print all private fields
    </li>
    <li>
        <strong>protected</strong>
        - print all protected fields
    </li>
    <li>
        <strong>public</strong>
        - print all public fields
    </li>
    <li>
        <strong>all</strong>
        - print ALL declared fields
    </li>
</ul>
<p>
    <a name="OLE_LINK2"></a>
    <a name="OLE_LINK1">· <strong>HARVEST</strong></a>
    - end the input
</p>
<h3>
    Output
</h3>
<p>
    For each command, you must print the fields that have the given access
    modifier as described in the input section. The format in which the fields
    should be printed is:
</p>
<p>
    <strong>
        "&lt;access modifier&gt; &lt;field type&gt; &lt;field name&gt;"
    </strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    protected
                </p>
                <p>
                    HARVEST
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    protected String testString
                </p>
                <p>
                    protected Double aDouble
                </p>
                <p>
                    protected Byte testByte
                </p>
                <p>
                    protected StringBuilder aBuffer
                </p>
                <p>
                    protected BigInteger testBigNumber
                </p>
                <p>
                    protected Single testFloat
                </p>
                <p>
                    protected Object testPredicate
                </p>
                <p>
                    protected Object fatherMotherObject
                </p>
                <p>
                    protected String moarString
                </p>
                <p>
                    protected Exception inheritableException
                </p>
                <p>
                    protected Stream moarStreamz<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    private
                </p>
                <p>
                    public
                </p>
                <p>
                    private
                </p>
                <p>
                    HARVEST
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    private Int32 testInt
                </p>
                <p>
                    private Int64 testLong
                </p>
                <p>
                    private Calendar aCalendar
                </p>
                <p>
                    private Char testChar
                </p>
                <p>
                    private BigInteger testBigInt
                </p>
                <p>
                    private Thread aThread
                </p>
                <p>
                    private Object aPredicate
                </p>
                <p>
                    private Object hiddenObject
                </p>
                <p>
                    private String anotherString
                </p>
                <p>
                    private Exception internalException
                </p>
                <p>
                    private Stream secretStream
                </p>
                <p>
                    public Double testDouble
                </p>
                <p>
                    public String aString
                </p>
                <p>
                    public StringBuilder aBuilder
                </p>
                <p>
                    public Int16 testShort
                </p>
                <p>
                    public Byte aByte
                </p>
                <p>
                    public Single aFloat
                </p>
                <p>
                    public Thread testThread
                </p>
                <p>
                    public Object anObject
                </p>
                <p>
                    public Int32 anotherIntBitesTheDust
                </p>
                <p>
                    public Exception justException
                </p>
                <p>
                    public Stream aStream
                </p>
                <p>
                    private Int32 testInt
                </p>
                <p>
                    private Int64 testLong
                </p>
                <p>
                    private Calendar aCalendar
                </p>
                <p>
                    private Char testChar
                </p>
                <p>
                    private BigInteger testBigInt
                </p>
                <p>
                    private Thread aThread
                </p>
                <p>
                    private Object aPredicate
                </p>
                <p>
                    private Object hiddenObject
                </p>
                <p>
                    private String anotherString
                </p>
                <p>
                    private Exception internalException
                </p>
                <p>
                    private Stream secretStream
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    all
                </p>
                <p>
                    HARVEST
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    private Int32 testInt
                </p>
                <p>
                    public Double testDouble
                </p>
                <p>
                    protected String testString
                </p>
                <p>
                    private Int64 testLong
                </p>
                <p>
                    protected Double aDouble
                </p>
                <p>
                    public String aString
                </p>
                <p>
                    private Calendar aCalendar
                </p>
                <p>
                    public StringBuilder aBuilder
                </p>
                <p>
                    private Char testChar
                </p>
                <p>
                    public Int16 testShort
                </p>
                <p>
                    protected Byte testByte
                </p>
                <p>
                    public Byte aByte
                </p>
                <p>
                    protected StringBuilder aBuffer
                </p>
                <p>
                    private BigInteger testBigInt
                </p>
                <p>
                    protected BigInteger testBigNumber
                </p>
                <p>
                    protected Single testFloat
                </p>
                <p>
                    public Single aFloat
                </p>
                <p>
                    private Thread aThread
                </p>
                <p>
                    public Thread testThread
                </p>
                <p>
                    private Object aPredicate
                </p>
                <p>
                    protected Object testPredicate
                </p>
                <p>
                    public Object anObject
                </p>
                <p>
                    private Object hiddenObject
                </p>
                <p>
                    protected Object fatherMotherObject
                </p>
                <p>
                    private String anotherString
                </p>
                <p>
                    protected String moarString
                </p>
                <p>
                    public Int32 anotherIntBitesTheDust
                </p>
                <p>
                    private Exception internalException
                </p>
                <p>
                    protected Exception inheritableException
                </p>
                <p>
                    public Exception justException
                </p>
                <p>
                    public Stream aStream
                </p>
                <p>
                    protected Stream moarStreamz
                </p>
                <p>
                    private Stream secretStream
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Black Box Integer
</h2>
<p>
    <em>Provided skeleton.</em>
</p>
<p>
    You are helping a buddy of yours who is still in the OOP Basics course -
    his name is Peshoslav (not to be mistaken with real people or trainers). He
    is rather slow and made a class with all private members. Your tasks are to
    instantiate an object from his class (always with start value 0) and then
    invoke the different methods it has. Your restriction is to not change
    anything in the class itself (consider it a black box). You can look at his
class but don't touch anything! The class itself is called    <strong>BlackBoxInt</strong> it is a wrapper for the <strong>int</strong>
    primitive.
</p>
<p>
    The methods this class has are:
</p>
<ul>
    <li>
        Add(int)
    </li>
    <li>
        Subtract(int)
    </li>
    <li>
        Multiply(int)
    </li>
    <li>
        Divide(int)
    </li>
    <li>
        LeftShift(int)
    </li>
    <li>
        RightShift(int)
    </li>
</ul>
<h3>
    Input
</h3>
<p>
    The input will consist of lines in the form:
</p>
<p>
    <strong>&lt;method name&gt;_&lt;value&gt;</strong>
</p>
<p>
    For instance: <strong>Add_115</strong>
</p>
<p>
    Input will always be valid and in the format described, so there is no need
    to check it explicitly. You stop receiving input when you encounter the
    command "<strong>END</strong>".
</p>
<h3>
    Output
</h3>
<p>
    Each command (except the <strong>END</strong> one) should print the current
    value of <strong>innerValue</strong> of the BlackBoxInt object you
    instantiated. Don't cheat by overriding ToString() in the class - you must
    get the value from the <strong>private</strong> field.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Add_999999
                </p>
                <p>
                    Subtract_19
                </p>
                <p>
                    Divide_4
                </p>
                <p>
                    Multiply_2
                </p>
                <p>
                    RightShift_1
                </p>
                <p>
                    LeftShift_3
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    999999
                </p>
                <p>
                    999980
                </p>
                <p>
                    249995
                </p>
                <p>
                    499990
                </p>
                <p>
                    249995
                </p>
                <p>
                    1999960
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. BarracksWars - A New Factory
</h2>
<p>
    You are given a small console based project called Barracks (the code for
    it is included in the provided skeleton).
</p>
<p>
    The general functionalities of the project are adding new units to its
    repository and printing a report with statistics about the units currently
    in the repository. First let's go over the original task before the project
    was created:
</p>
<h3>
    Input
</h3>
<p>
    The input consists of commands each on a separate line. Commands that
    execute the functionality are:
</p>
<ul>
    <li>
        <strong>add </strong>
&lt;<strong>Archer</strong>/<strong>Swordsman</strong>/        <strong>Pikeman/{…}</strong>&gt; - adds a unit to the repository.
    </li>
    <li>
        <strong>report</strong>
        - prints a lexicological ordered statistic about the units in the
        repository.
    </li>
    <li>
        <strong>fight</strong>
        - ends the input.
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    Each command except <strong>fight</strong> should print output on the
    console.
</p>
<ul>
    <li>
        <strong>add </strong>
should print: "&lt;<strong>Archer</strong>/<strong>Swordsman</strong>/        <strong>Pikeman</strong>/<strong>{…}&gt; added!</strong>"
    </li>
    <li>
        <strong>report</strong>
should print all the info in the repository in the format: "&lt;<strong>UnitType</strong>&gt;<strong> -&gt; </strong>&lt;        <strong>UnitQuantity</strong>&gt;", sorted by UnitType
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul>
    <li>
        Input will consist of no more than <strong>1000</strong> lines
    </li>
    <li>
        <strong>report</strong>
        command will never be given before any valid add command was provided
    </li>
</ul>
<h3>
    Your task
</h3>
<p>
1) You have to    <strong>study the code of the project and figure out how it works</strong>.
    However, there are parts of it that are not implemented (left with TODOs).
    You must implement the functionality of the <strong>CreateUnit </strong>
    method in the <strong>UnitFactory </strong>class so that it creates a unit
    based on the unit type received as parameter. Implement it in such a way
    that whenever you add a new unit it will be creatable without the need to
change anything in the <strong>UnitFactory </strong>class (<em>psst</em><em> - use reflection</em>). You can use the approach called    <strong>Simple Factory</strong>.
</p>
<p>
2) Add two new unit classes (there will be tests that require them) -<strong>Horseman </strong>with 50 health and 10 attack and    <strong>Gunner </strong>with 20 health and 20 attack.
</p>
<p>
    If you complete everything correctly for this problem, you should add code
    only inside the <strong>Factories</strong> and <strong>Units</strong>
    folders.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    add Swordsman
                </p>
                <p>
                    add Archer
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    report
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    report
                </p>
                <p>
                    fight
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Swordsman added!
                </p>
                <p>
                    Archer added!
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Archer -&gt; 1
                </p>
                <p>
                    Pikeman -&gt; 1
                </p>
                <p>
                    Swordsman -&gt; 1
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Archer -&gt; 1
                </p>
                <p>
                    Pikeman -&gt; 3
                </p>
                <p>
                    Swordsman -&gt; 1
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    add Pikeman
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Horseman
                </p>
                <p>
                    add Archer
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Horseman
                </p>
                <p>
                    report
                </p>
                <p>
                    fight
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Pikeman added!
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Horseman added!
                </p>
                <p>
                    Archer added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Horseman added!
                </p>
                <p>
                    Archer -&gt; 1
                </p>
                <p>
                    Gunner -&gt; 3
                </p>
                <p>
                    Horseman -&gt; 2
                </p>
                <p>
                    Pikeman -&gt; 2
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. BarracksWars - The Commands Strike Back
</h2>
<p>
    <em>Provided skeleton.</em>
</p>
<p>
    As you might have noticed commands in the project from Problem 3 are
implemented via a switch case with method calls in the    <strong>Engine</strong> class. Although this approach works it is flawed
    when you add a new command because you have to add a new case for it. In
    some projects, you might not have access to the engine and this would not
    work. Imagine this project will be outsourced and the outsourcing firm will
    not have access to the engine. Make it so whenever they want to add a new
    command they won't have to change anything in the <strong>Engine.</strong>
</p>
<p>
    To do so employ the design pattern called
    <a href="https://en.wikipedia.org/wiki/Command_pattern">
        <strong>Command Pattern</strong>
    </a>
    . We've done this in the <strong>BashSoft</strong> <strong>Lab</strong> and
you can look there for tips too. Use the provided    <strong>Executable </strong>interface as a frame for the command classes.
    Put the new command classes in the provided <strong>commands</strong>
    package inside <strong>core</strong>. You can also make a Command
    Interpreter to decouple that functionality from the Engine. Here is how the
    base (abstract) command should look like:
</p>
<p>
    Notice how all commands that extend this one will have both a Repository
    and a <strong>UnitFactory</strong> although not all of them need these.
    Leave it like this for this problem, because for the reflection to work we
    need all constructors to accept the same parameters. We will see how to go
    around this issue in problem 5.
</p>
<p>
    Once you've implemented the pattern add a new command. It will have the
    following syntax:
</p>
<ul>
    <li>
        <strong>retire</strong>
        &lt;<strong>UnitType</strong>&gt; - All it has to do is remove a unit
        of the provided type from the repository.
    </li>
</ul>
<p>
o If there are no such units currently in the repository print:<a name="OLE_LINK4"></a>    <a name="OLE_LINK3">"<strong>No such units in repository.</strong>"</a>
</p>
<p>
o If there is such a unit currently in the repository, print: "    <strong>&lt;UnitType&gt; retired!</strong>"
</p>
<p>
    To implement this command, you will also have to implement a corresponding
    method in the <strong>UnitRepository</strong>.
</p>
<p>
    If you do everything correctly for this problem, you should write/refactor
    code only in the <strong>Core</strong> and <strong>Data</strong> packages.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    retire Archer
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    add Pikeman
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Horseman
                </p>
                <p>
                    add Archer
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Gunner
                </p>
                <p>
                    add Horseman
                </p>
                <p>
                    report
                </p>
                <p>
                    retire Gunner
                </p>
                <p>
                    retire Archer
                </p>
                <p>
                    report
                </p>
                <p>
                    retire Swordsman
                </p>
                <p>
                    retire Archer
                </p>
                <p>
                    fight
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    No such units in repository.
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Pikeman added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Horseman added!
                </p>
                <p>
                    Archer added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Gunner added!
                </p>
                <p>
                    Horseman added!
                </p>
                <p>
                    Archer -&gt; 1
                </p>
                <p>
                    Gunner -&gt; 3
                </p>
                <p>
                    Horseman -&gt; 2
                </p>
                <p>
                    Pikeman -&gt; 2
                </p>
                <p>
                    Gunner retired!
                </p>
                <p>
                    Archer retired!
                </p>
                <p>
                    Archer -&gt; 0
                </p>
                <p>
                    Gunner -&gt; 2
                </p>
                <p>
                    Horseman -&gt; 2
                </p>
                <p>
                    Pikeman -&gt; 2
                </p>
                <p>
                    No such units in repository.
                </p>
                <p>
                    No such units in repository.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. * BarracksWars - Return of the Dependencies
</h2>
<p>
    In the final part of this epic problem trilogy we will resolve the issue
    where all Commands received all utility classes as parameters in their
constructors. We can accomplish this by using an approach called    <strong>dependency injection container</strong>. This approach is used in
    many frameworks.
</p>
<p>
    We will do a little twist on that approach. Remove all fields from the
    abstract command except the <strong>data. </strong>Instead put whatever
fields each command needs in the concrete class. Create an attribute called    <strong>Inject</strong> and make it so it can be used only on fields. Put
    the attribute over the fields we need to set trough reflection. Once you've
prepared all of this, write the necessary reflection code in the    <strong>Command Interpreter </strong>(which you should have refactored out
    from the engine in problem 4).
</p>
<p>
    You can use the same example as in Problem 4 to check if you completed the
    task correctly.
</p>
<h2>
    Problem 6. Traffic Lights
</h2>
<p>
    Implement a simple state machine in the form of a traffic light. Every
    traffic light has three possible signals - red, green and yellow. Each
    traffic light can be updated, which changes the color of its signal (e.g.
    if it is currently red, it changes to green, if it is green it changes to
    yellow). The order of signals is red -&gt; green -&gt; yellow -&gt; red and
    so on.
</p>
<p>
    On the first line you will be given multiple traffic light signals in the
    format "Red Green Yellow". You need to make as many traffic lights as there
    are signals in the input.
</p>
<p>
    On the second line, you will receive the <strong>n</strong> number of times
    you need to change each traffic light's signal.
</p>
<p>
    Your output should consist of <strong>n</strong> number of lines, including
    each updated traffic light's signal. To better understand the problem, see
    the example below.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="378" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    Green Red Yellow
                </p>
                <p>
                    4
                </p>
            </td>
            <td width="378" valign="top">
                <p>
                    Yellow Green Red
                </p>
                <p>
                    Red Yellow Green
                </p>
                <p>
                    Green Red Yellow
                </p>
                <p>
                    Yellow Green Red
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Inferno Infinity
</h2>
<p>
    If you've been involved with the creation of Inferno III last year, you may
    be informed of the disastrous critic reception it has received.
    Nevertheless, your company is determined to satisfy its fan base, so a
    sequel is coming and yeah, you will develop the crafting module of the game
    using the latest OOP trends.
</p>
<p>
    You have three different weapons (Axe, Sword and Knife) which have base
    stats and a name. The base stats are min damage, max damage and number of
    sockets (sockets are basically holes, in which you can insert gems). Below
    are the base stats for the three weapon types:
</p>
<ul>
    <li>
        Axe (5-10 damage, 4 sockets)
    </li>
    <li>
        Sword (4-6 damage, 3 sockets)
    </li>
    <li>
        Knife (3-4 damage, 2 sockets)
    </li>
</ul>
<p>
    What’s more, every weapon comes with a different level of rarity (how rare
    it is to come across such an item). Depending on its rarity, a weapon’s
    maximum and minimum damage can be modified.
</p>
<ul>
    <li>
        Common (increases damage x1)
    </li>
    <li>
        Uncommon (increases damage x2)
    </li>
    <li>
        Rare (increases damage x3)
    </li>
    <li>
        Epic (increases damage x5)
    </li>
</ul>
<p>
    So a Common Axe would have its damage modified in the following way:
    minimum damage = 5 *1, maximum damage = 10 *1. Whereas an Epic Axe would
    look like this: minimum damage = 5 * 5, maximum damage = 10 * 5.
</p>
<p>
    Additionally, every weapon provides a bonus to three magical stats -
    strength, agility and vitality. At first the bonus of every magical stat is
    zero and can be increased with gems which are inserted into the weapon.
</p>
<p>
    Every gem provides a bonus to all three of the magical stats. There are
    three different kind of gems:
</p>
<ul>
    <li>
        Ruby (+7 strength, +2 agility, +5 vitality)
    </li>
    <li>
        Emerald (+1strength, +4 agility, +9 vitality)
    </li>
    <li>
        Amethyst (+2 strength, +8 agility, +4 vitality)
    </li>
</ul>
<p>
    Every point of strength adds +2 to min damage and +3 to max damage. Every
    point of agility adds +1 to min damage and +4 to max damage. Vitality does
    not add damage.
</p>
<p>
    Furthermore, every gem comes in different levels of clarity (basically
    level of quality). Depending on its level of clarity, a gem’s stats can be
    modified in the following manner:
</p>
<ul>
    <li>
        Chipped (increases each stat by 1)
    </li>
    <li>
        Regular (increases each stat by <strong>2</strong>)
    </li>
    <li>
        Perfect (increases each stat by 5)
    </li>
    <li>
        Flawless (increases each stat by 10)
    </li>
</ul>
<p>
    So a Chipped Amethyst will have its stats modified like this: strength = 2
    + 1, agility = 8 + 1, vitality = 4 + 1. Whilst a Perfect Emerald would look
    like this: strength = 1 + 5, agility = 4 + 5, vitality = 9 + 5.
</p>
<p>
    Your job is to implement the functionality to read some weapons from the
    console and optionally to insert or remove gems at different socket indexes
    until you receive the END command.
</p>
<p>
    Also, upon the <strong>Print</strong> command, in order to print correct
final stats for a given weapon, first calculate the weapon’s<strong>base stats </strong>taking into account    <strong>its type and rarity</strong>. Afterwards, calculate the stats of
    each of its gems based on their <strong>clarity </strong>and finally add
    everything together. For the specific format of printing refer to the
    Output section.
</p>
<h3>
    Note
</h3>
<p>
    If you add gem on top of another, just overwrite it. If you add a gem to an
    invalid index, nothing happens. If you try to remove a gem from an empty
    socket or from invalid index, nothing happens. Upon receiving the END
    command print the weapons in order of their appearance in the format
    provided below.
</p>
<h3>
    Input
</h3>
<p>
    Each line consists of three types of commands in which the tokens are
    separated by ";".
</p>
<p>
    Command types:
</p>
<p>
    · Create;{weapon type};{weapon name}
</p>
<p>
    · Add;{weapon name};{socket index};{gem type}
</p>
<p>
    · Remove;{weapon name};{socket index}
</p>
<p>
    · Print;{weapon name}
</p>
<h3>
    Output
</h3>
<p>
    Print weapons in the given format:
</p>
<p>
    "{weapon's name}: {min damage}-{max damage} Damage, +{points} Strength,
    +{points} Agility, +{points} Vitality"
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="321" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="387" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="321" valign="top">
                <p>
                    Create;Common Axe;Axe of Misfortune
                </p>
                <p>
                    Add;Axe of Misfortune;0;Chipped Ruby
                </p>
                <p>
                    Print;Axe of Misfortune
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="387" valign="top">
                <p>
                    Axe of Misfortune: 24-46 Damage, +8 Strength, +3 Agility,
                    +6 Vitality
                </p>
            </td>
        </tr>
        <tr>
            <td width="321" valign="top">
                <p>
                    Create;Common Axe;Axe of Misfortune
                </p>
                <p>
                    Add;Axe of Misfortune;0;Flawless Ruby
                </p>
                <p>
                    Remove;Axe of Misfortune;0
                </p>
                <p>
                    Print;Axe of Misfortune
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="387" valign="top">
                <p>
                    Axe of Misfortune: 5-10 Damage, +0 Strength, +0 Agility, +0
                    Vitality
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. Create Custom Class Attribute
</h2>
<p>
    Create a custom attribute that can be applied to classes and can be
    accessed at runtime. The attribute type elements it should contain are
    author, revision, description and reviewers. Apply the attribute to the
    Weapon class you have created for the Inferno Infinity problem. Provide
    these<strong> exact</strong> values:
</p>
<ul>
    <li>
        author = "Pesho"
    </li>
    <li>
        revision = 3
    </li>
</ul>
<p>
    · description = "Used for C# OOP Advanced Course - Enumerations and
    Attributes."
</p>
<p>
    · reviewers = "Pesho", "Svetlio"
</p>
<p>
    Implement additional commands for extracting different attribute values:
</p>
<ul>
    <li>
        Author - prints the author of the class
    </li>
    <li>
        Revision - prints the revision of the class
    </li>
    <li>
        Description - prints the class description
    </li>
    <li>
        Reviewers - prints the reviewers of the class
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="246" valign="top">
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
            <td width="246" valign="top">
                <p>
                    Author
                </p>
                <p>
                    Revision
                </p>
                <p>
                    Description
                </p>
                <p>
                    Reviewers
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="463" valign="top">
                <p>
                    Author: Pesho
                </p>
                <p>
                    Revision: 3
                </p>
                <p>
                    Class description: Used for C# OOP Advanced Course -
                    Enumerations and Attributes.
                </p>
                <p>
                    Reviewers: Pesho, Svetlio
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 9. *Refactoring - Bonus
</h2>
<p>
    Refactor your Inferno Infinity problem code according to all HQC standards.
</p>
<p>
    · Think about the proper naming of all your variables, methods, classes and
    interfaces.
</p>
<p>
    · Review all of your methods and make sure they are doing only one highly
    concrete thing.
</p>
<p>
    · Review your class hierarchy and make sure you have no duplicating code.
</p>
<p>
    · Consider making your classes less dependent of each other. If you have
    the <strong>new</strong> keyword anywhere inside the body of a non-factory
    or main class, think about how to remove it. Read about
    <a href="https://en.wikipedia.org/wiki/Dependency_injection">
        <strong>dependency injection</strong>
    </a>
    <strong>.</strong>
</p>
<p>
    · Consider adding independent classes for reading input and writing output.
</p>
<p>
    · Create repository class that stores all weapon data.
</p>
<p>
    · Create an engine, weapon creator and so on. Try using design patterns
    like command and factory.
</p>
<ul>
    <li>
        Make you classes
        <a href="https://en.wikipedia.org/wiki/Cohesion_(computer_science)">
            <strong>highly cohesive</strong>
        </a>
        and
        <a href="https://en.wikipedia.org/wiki/Coupling_(computer_programming)">
            <strong>loosely coupled</strong>
        </a>
        .
    </li>
</ul>