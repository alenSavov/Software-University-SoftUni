<h1 align="center">
    OOP Basics Exam – Minedraft
</h1>
<p>
    You ever heard about the Rick and Morty’s Foundation for mining Plumbus
    Ore. Naaa, probably not. Well let’s just say there is this company that
    mines things, and they hired you to write them a supervising software. A
    draft which will be used to analyze the data of the mining – a … Minedraft.
</p>
<h3>
    Overview
</h3>
<p>
    The main system consists of Harvesters and Providers. The Harvesters are
    the ones that make real money – they mine Plumbus Ore. But they need a
    large amount of energy to do that. That’s where the Providers come. The
    Providers are the ones that provide the energy for the harvesters.
</p>
<h2>
    Task 1: Structure
</h2>
<p>
    The Structure consists of Harvesters and Providers.
</p>
<h3>
    Harvesters
</h3>
<p>
    A basic Harvester has the following properties:
</p>
<ul>
    <li>
        id – a <strong>string</strong>.
    </li>
    <li>
        oreOutput – a <strong>floating-point number</strong>.
    </li>
    <li>
        energyRequirement – a <strong>floating-point number</strong>.
    </li>
</ul>
<p>
For all harvesters you <strong>need to validate</strong>, that    <strong>ore output</strong> and <strong>energy requirement</strong> for
each harvester <strong>is NOT negative</strong>. Also you need to    <strong>validate</strong> that <strong>energy requirement</strong> for each
harveter <strong>is NOT over 20000</strong>. There are generally    <strong>2 </strong>types of Harversters:
</p>
<h4>
    SonicHarvester
</h4>
<p>
    Really fast… Has an extra property:
</p>
<ul>
    <li>
        sonicFactor – an <strong>integer</strong>.
    </li>
</ul>
<p>
    <strong>UPON INITIALIZATION</strong>
    ,<strong> divides</strong> its given energyRequirement by its sonicFactor.
</p>
<h4>
    HammerHarvester
</h4>
<p>
    Heavy... and big.
</p>
<p>
    <strong>UPON INITIALIZATION</strong>
,<strong> increases</strong> its oreOutput by <strong>200 %,</strong> and    <strong>increases</strong> its energyRequirement by <strong>100 %</strong>.
</p>
<h3>
    Providers
</h3>
<p>
    A basic Provider has the following properties:
</p>
<ul>
    <li>
        id – a <strong>string</strong>.
    </li>
    <li>
        energyOutput – a <strong>floating-point number</strong>.
    </li>
</ul>
<p>
Every provider energy output <strong>need to be positive numbers,</strong>    <strong>less than 10000</strong>. There are generally <strong>2 </strong>
    types of Providers:
</p>
<h4>
    SolarProvider
</h4>
<p>
    Extracts energy from the Sun. Nothing special here.
</p>
<h4>
    PressureProvider
</h4>
<p>
    Extracts energy from deep beneath the earth. Temperatures and Pressure
    affect it.
</p>
<p>
    <strong>UPON INITIALIZATION</strong>
    ,<strong> </strong>increases its energyOutput by <strong>50 %</strong>.
</p>
<h2>
    Task 2: Business Logic
</h2>
<h3>
    The Controller Class
</h3>
<p>
    The business logic of the program should be concentrated around several
commands. Implement a class called DraftManager, which will hold the<strong>main functionality</strong>, represented by these    <strong>public</strong> <strong>methods</strong>:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="390" valign="top">
                <p align="center">
                    DraftManager.cs
                </p>
            </td>
        </tr>
        <tr>
            <td width="390" valign="top">
                <p>
                    string RegisterHarvester(List&lt;string&gt; arguments)
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
                <p>
                    string RegisterProvider(List&lt;string&gt; arguments)
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
                <p>
                    string Day()
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
                <p>
                    string Mode(List&lt;string&gt; arguments)
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
                <p>
                    string Check(List&lt;string&gt; arguments)
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
                <p>
string <a name="OLE_LINK5"></a>                    <a name="OLE_LINK4">ShutDown</a>()
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO: Add some logic here …
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>NOTE: DraftManager class </strong>
methods are called from the outside so these methods <strong>must</strong>    <strong>NOT</strong> receive the command parameter as part of the
    arguments!
</p>
<h3>
    Functionality
</h3>
<p>
The whole system works on <strong>3 modes</strong> – “<strong>Full Mode</strong>”, “<strong>Half Mode</strong>”, “    <strong>Energy Mode</strong>”. Depending on the mode, the Harvesters and
    Providers work differently. By <strong>DEFAULT</strong> the mode is “Full
    Mode”.
</p>
<p>
The Providers and Harvesters have <strong>ids</strong>, which will    <strong>always</strong> be <strong>unique</strong>.
</p>
<p>
    When a <strong>day passes</strong>, the Providers produce energy and the
Harvesters consume energy and mine Plumbus Ore. In your program a<strong>day passes</strong> when you have been given the    <strong>corresponding command</strong>.
</p>
<p>
    The Providers produce energy which is being stored on the system. When
there is <strong>ENOUGH</strong> <strong>energy</strong> to<strong>power up</strong> <strong>ALL</strong> Harvesters, the Harvesters    <strong>consume</strong> it and return the ore.
</p>
<p>
    The system keeps the totalStoredEnergy and the totalMinedOre.
</p>
<h3>
    Modes
</h3>
<p>
    The different modes make the Harvesters work differently. You can save more
    power by changing the modes and stalling them a little. The Providers
    remain <strong>unaffected</strong> by the modes.
</p>
<h5>
    Full Mode
</h5>
<p>
    All Harvesters consume their <strong>FULL energy requirements</strong>, and
    produce their <strong>FULL ore output</strong>.
</p>
<h5>
    Half Mode
</h5>
<p>
All Harvesters consume <strong>60 %</strong> of their    <strong>energy requirements</strong>, and produce <strong>50 %</strong> of
    their <strong>ore output</strong>.
</p>
<h5>
    Energy Mode
</h5>
<p>
The Harvesters consume <strong>nothing</strong>, and produce    <strong>nothing</strong>. They practically do <strong>NOT</strong> work.
</p>
<h3>
    Commands
</h3>
<p>
    There are several commands that control the business logic of the
    application you are supposed to build.
    <br/>
    They are stated below.
</p>
<h4>
    RegisterHarvester Command
</h4>
<p>
    Creates a Harvester, and registers it into the system, so they can start
    mining when new day come.
</p>
<h5>
    Parameters
</h5>
<ul>
    <li>
        type – a <strong>string</strong>, equal to either Sonic or Hammer.
    </li>
    <li>
        id – a <strong>string</strong>.
    </li>
    <li>
        oreOutput – a positive <strong>floating-point number</strong>.
    </li>
    <li>
        energyRequirement – a positive <strong>floating-point number</strong>.
    </li>
</ul>
<p>
    If the type is Sonic, you will receive <strong>1 extra parameter</strong>:
</p>
<ul>
    <li>
        sonicFactor – a positive <strong>integer</strong>.
    </li>
</ul>
<h4>
    RegisterProvider Command
</h4>
<p>
    Creates a Provider, and registers it into the system. They start to provide
    energy from next day.
</p>
<h5>
    Parameters
</h5>
<ul>
    <li>
        type – a <strong>string</strong>, equal to either Solar or Pressure.
    </li>
    <li>
        id – a <strong>string</strong>.
    </li>
    <li>
        energyOutput – a positive <strong>floating-point number</strong>.
    </li>
</ul>
<h4>
    Day Command
</h4>
<p>
    When you receive this command a day passes. This is the moment where real
work starts. You need to <strong>calculate</strong> all the provided    <strong>energy</strong> and <strong>STORE</strong> it in the system. Then
you need to <strong>check</strong> if there is <strong>enough</strong>    <strong>energy</strong> for harvesters to start mining. If the sum of
energy requirement of <strong>ALL</strong> harvesters is more than the<strong>energy</strong> <strong>stored </strong>then<strong>NOTHING</strong> happens. If there is<strong>enough energy</strong>, <strong>ALL</strong> harvesters<strong>start mining</strong> and they <strong>consume</strong> from the    <strong>stored</strong> <strong>energy</strong> <strong>EQUAL</strong> to
    their energy requirement.
</p>
<p>
    <strong>NOTE</strong>
: The summed up energyRequirement might be <strong>less</strong> or<strong>more</strong> depending on the current <strong>working</strong>    <strong>Mode</strong>.
</p>
<h4>
    Mode Command
</h4>
<p>
Changes the <strong>mode</strong> of the system, to the    <strong>given one</strong>.
</p>
<h5>
    Parameters
</h5>
<ul>
    <li>
        mode - a <strong>string</strong>, equal to either Full, Half or Energy.
    </li>
</ul>
<h4>
    Check Command
</h4>
<p>
    <strong>Checks</strong>
    the Provider or the Harvester with the <strong>given id</strong>, returning
    a <strong>string representation</strong> of it. The system should check if
    there is an <strong>element</strong> with the <strong>given id</strong>
among the Providers or the Harvesters. The<strong> ids</strong> are    <strong>unique</strong> so there should be only <strong>one</strong> with
    that <strong>id</strong>.
</p>
<h5>
    Parameters
</h5>
<ul>
    <li>
        id – a <strong>string</strong>.
    </li>
</ul>
<h4>
    Shutdown Command
</h4>
<p>
    <strong>Ends</strong>
    the program and <strong>print total energy stored and ore mined</strong>
</p>
<h2>
    Task 3: Input / Output
</h2>
<h3>
    Input
</h3>
<p>
Below, you can see the <strong>format</strong> in which    <strong>each command</strong> will be given in the input:
</p>
<ul>
    <li>
        RegisterHarvester {type} {id} {oreOutput} {energyRequirement}
    </li>
</ul>
<p>
    · RegisterHarvester Sonic {id} {oreOutput} {energyRequirement}
    {sonicFactor}
</p>
<ul>
    <li>
        RegisterProvider {type} {id} {energyOutput}
    </li>
    <li>
        Day
    </li>
    <li>
        Mode {mode}
    </li>
    <li>
        Check {id}
    </li>
    <li>
        Shutdown
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    Below you can see what output should be provided from the commands.
</p>
<h4>
    RegisterHarvester Command
</h4>
<p>
    Successful command should print “Successfully registered {type} Harvester –
    {id}”.
</p>
<p>
    Unsuccessfull comand: "Harvester is not registered, because of it's
    {propertyName}"
</p>
<h4>
    RegisterProvider Command
</h4>
<p>
    Should output a message “Successfully registered {type} Provider – {id}”.
</p>
<p>
    Unsuccessfull comand: "Provider is not registered, because of it's
    {propertyName}"
</p>
<h4>
    Day Command
</h4>
<p>
    Should output a message
</p>
<p>
    “A day has passed.
</p>
<p>
    “Energy Provided: {summedEnergyOutput}”.
</p>
<p>
    “Plumbus Ore Mined: {summedOreOutput}”.
</p>
<p>
    The summedEnergyOutput and summedOreOutput are the ones that have been
    mined for the day.
</p>
<h4>
    Mode Command
</h4>
<p>
Should output a message “<a name="OLE_LINK2"></a>    <a name="OLE_LINK1">Successfully changed working mode to {mode} Mode</a>”.
</p>
<h4>
    Check Command
</h4>
<p>
    Should return a <strong>string representation</strong> of the element with
    the <strong>given id</strong>. If there is no such element, the command
    should output a message “No element found with id – {id}”.
</p>
<p>
Because the element can either be a Provider or a Harvester, both    <strong>output formats</strong> have been provided below:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="285" valign="top">
                <p align="center">
                    Harvester
                </p>
            </td>
            <td width="280" valign="top">
                <p align="center">
                    Provider
                </p>
            </td>
        </tr>
        <tr>
            <td width="285" valign="top">
                <p>
                    “{type} Harvester – {id}
                </p>
                <p>
                    Ore Output: {oreOutput}
                </p>
                <p>
                    Energy Requirement: {energyRequired}”
                </p>
            </td>
            <td width="280" valign="top">
                <p>
                    “{type} Provider – {id}
                </p>
                <p>
                    Energy Output: {energyOutput}”
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h4>
    Shutdown Command
</h4>
<p>
    Should output a message
</p>
<p>
    “<a name="OLE_LINK8"></a><a name="OLE_LINK3">System Shutdown</a>
</p>
<p>
    <a name="OLE_LINK10"></a>
    <a name="OLE_LINK9">Total Energy Stored: {totalEnergyStored}</a>
</p>
<p>
    <a name="OLE_LINK12"></a>
    <a name="OLE_LINK11">Total Mined Plumbus Ore: {totalMinedOre}</a>
    ”.<strong></strong>
</p>
<p>
    The totalEnergyStored and totalMinedOre are the total values that have been
    gathered throughout the program’s execution.
</p>
<h3>
    Constraints
</h3>
<p>
· The id will be a string which may contain any ASCII character, except    <strong>space</strong> (‘ ’).
</p>
<p>
    · The ids will always be <strong>unique</strong>.
</p>
<ul>
    <li>
All <strong>floating-point numbers</strong> will be in        <strong>range [-1.000.000, 1.000.000]</strong>.
    </li>
    <li>
        The sonicFactor will be in <strong>range [1, 10]</strong>.
    </li>
    <li>
        There will be <strong>NO invalid</strong> input data.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="371" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="361" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="371" valign="top">
                <p>
                    RegisterHarvester Sonic AS-51 100 100 10
                </p>
                <p>
                    RegisterHarvester Hammer CDD 100 50
                </p>
                <p>
RegisterProvider <a name="OLE_LINK7"></a>                    <a name="OLE_LINK6">Solar Falcon </a>100
                </p>
                <p>
                    Day
                </p>
                <p>
                    Check AS-51
                </p>
                <p>
                    Check CDD
                </p>
                <p>
                    Check Falcon
                </p>
                <p>
                    Day
                </p>
                <p>
                    Shutdown
                </p>
            </td>
            <td width="361" valign="top">
                <p>
                    Successfully registered Sonic Harvester - AS-51
                </p>
                <p>
                    Successfully registered Hammer Harvester - CDD
                </p>
                <p>
                    Successfully registered Solar Provider - Falcon
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 100
                </p>
                <p>
                    Plumbus Ore Mined: 0
                </p>
                <p>
                    Sonic Harvester - AS-51
                </p>
                <p>
                    Ore Output: 100
                </p>
                <p>
                    Energy Requirement: 10
                </p>
                <p>
                    Hammer Harvester - CDD
                </p>
                <p>
                    Ore Output: 300
                </p>
                <p>
                    Energy Requirement: 100
                </p>
                <p>
                    Solar Provider - Falcon
                </p>
                <p>
                    Energy Output: 100
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 100
                </p>
                <p>
                    Plumbus Ore Mined: 400
                </p>
                <p>
                    System Shutdown
                </p>
                <p>
                    Total Energy Stored: 90
                </p>
                <p>
                    Total Mined Plumbus Ore: 400
                </p>
            </td>
        </tr>
        <tr>
            <td width="371" valign="top">
                <p>
                    RegisterHarvester Sonic AS-51 100 1000000 10
                </p>
                <p>
                    RegisterHarvester Hammer CDD 100 50
                </p>
                <p>
                    RegisterProvider Solar Falcon 100
                </p>
                <p>
                    RegisterProvider Solar Pesho 100000
                </p>
                <p>
                    Day
                </p>
                <p>
                    Check CDD
                </p>
                <p>
                    Check Falcon
                </p>
                <p>
                    Day
                </p>
                <p>
                    Shutdown
                </p>
            </td>
            <td width="361" valign="top">
                <p>
                    Harvester is not registered, because of it's
                    EnergyRequirement
                </p>
                <p>
                    Successfully registered Hammer Harvester - CDD
                </p>
                <p>
                    Successfully registered Solar Provider - Falcon
                </p>
                <p>
                    Provider is not registered, because of it's EnergyOutput
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 100
                </p>
                <p>
                    Plumbus Ore Mined: 300
                </p>
                <p>
                    Hammer Harvester - CDD
                </p>
                <p>
                    Ore Output: 300
                </p>
                <p>
                    Energy Requirement: 100
                </p>
                <p>
                    Solar Provider - Falcon
                </p>
                <p>
                    Energy Output: 100
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 100
                </p>
                <p>
                    Plumbus Ore Mined: 300
                </p>
                <p>
                    System Shutdown
                </p>
                <p>
                    Total Energy Stored: 0
                </p>
                <p>
                    Total Mined Plumbus Ore: 600
                </p>
            </td>
        </tr>
        <tr>
            <td width="371" valign="top">
                <p>
                    RegisterProvider Pressure Deep-1 1000
                </p>
                <p>
                    RegisterProvider Pressure Deep-3 2000
                </p>
                <p>
                    Day
                </p>
                <p>
                    Mode Energy
                </p>
                <p>
                    RegisterHarvester Hammer S-1 10000 11250
                </p>
                <p>
                    Day
                </p>
                <p>
                    Check Something
                </p>
                <p>
                    Check S-1
                </p>
                <p>
                    Mode Half
                </p>
                <p>
                    Day
                </p>
                <p>
                    Shutdown
                </p>
            </td>
            <td width="361" valign="top">
                <p>
                    Successfully registered Pressure Provider - Deep-1
                </p>
                <p>
                    Successfully registered Pressure Provider - Deep-3
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 4500
                </p>
                <p>
                    Plumbus Ore Mined: 0
                </p>
                <p>
                    Successfully changed working mode to Energy Mode
                </p>
                <p>
                    Harvester is not registered, because of it's
                    EnergyRequirement
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 4500
                </p>
                <p>
                    Plumbus Ore Mined: 0
                </p>
                <p>
                    No element found with id - Something
                </p>
                <p>
                    No element found with id - S-1
                </p>
                <p>
                    Successfully changed working mode to Half Mode
                </p>
                <p>
                    A day has passed.
                </p>
                <p>
                    Energy Provided: 4500
                </p>
                <p>
                    Plumbus Ore Mined: 0
                </p>
                <p>
                    System Shutdown
                </p>
                <p>
                    Total Energy Stored: 13500
                </p>
                <p>
                    Total Mined Plumbus Ore: 0
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Task 4: Bonus
</h2>
<h3>
    Abstraction
</h3>
<p>
Probably, you have already noticed, that there is a way to    <strong>improve</strong> the <strong>abstraction</strong> of your code. If
NOT, now is the time to think about this. For this task, you need    <strong>one more level of abstraction for Harvester and Providers</strong>.
</p>
<h3>
    Factories
</h3>
<p>
    You know, that the keyword <strong>new</strong> is a bottleneck and we are
    trying to use it as less as possible. We even try to separate it in new
classes. These classes are called Factories and the convention for them is<strong>{TypeOfObject}Factory</strong><strong>. </strong>You need to have<strong>two</strong> <strong>different</strong> <strong>factories</strong>,    <strong>one for Harvesters and one for Providers</strong>. This is actually
a design pattern and you can read more about it.    <a href="https://www.dotnetperls.com/factory">Factory Pattern</a>
</p>
<h2>
    Points
</h2>
<p>
    For all tasks you can submit same project. Every different task give you
    points:
</p>
<p>
    Task 1. 100 points
</p>
<p>
    Task 2. 200 points
</p>
<p>
    Task 3. 100 points
</p>
<p>
    Task 4. 50 points
</p>