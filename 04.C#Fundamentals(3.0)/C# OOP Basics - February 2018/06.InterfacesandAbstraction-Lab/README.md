<h1 align="center">
    Lab: Interfaces and Abstraction
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-oop-basics">
        "CSharp OOP Basics" course @ Software University
    </a>
</p>
<p>
    You can check your solutions here:
    <a
        href="https://judge.softuni.bg/Contests/705/Interfaces-and-Abstraction-Lab"
    >
        Judge
    </a>
</p>
<h2>
    1. Shapes
</h2>
<p>
    Build hierarchy of interfaces and classes:
</p>
<p>
    You should be able to use the class like this:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    StartUp.cs
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">var</a>
                    radius = int.Parse(Console.ReadLine());
                </p>
                <p>
                    IDrawable circle = new Circle(radius);
                </p>
                <p>
                    var width = int.Parse(Console.ReadLine());
                </p>
                <p>
                    var height = int.Parse(Console.ReadLine());
                </p>
                <p>
                    IDrawable rect = new Rectangle(width, height);
                </p>
                <p>
                    circle.Draw();
                </p>
                <pre>rect.Draw();</pre>
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
            <td width="157" valign="top">
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
                    4
                </p>
                <p>
                    5
                </p>
            </td>
            <td width="157" valign="top">
                <p>
                    *******
                </p>
                <p>
                    ** **
                </p>
                <p>
                    ** **
                </p>
                <p>
                    * *
                </p>
                <p>
                    ** **
                </p>
                <p>
                    ** **
                </p>
                <p>
                    *******
                </p>
                <p>
                    ****
                </p>
                <p>
                    * *
                </p>
                <p>
                    * *
                </p>
                <p>
                    * *
                </p>
                <p>
                    ****
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Solution
</h3>
<p>
    For circle drawing you can use this algorithm:
</p>
<p>
    For rectangle drawing algorithm will be:
</p>
<h2>
    2. Cars
</h2>
<p>
    Build a hierarchy of interfaces and classes:
</p>
<p>
    Your hierarchy must be used with this code:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="695" valign="top">
                <p align="center">
                    StartUp.cs
                </p>
            </td>
        </tr>
        <tr>
            <td width="695" valign="top">
                <p>
                    <a name="OLE_LINK9"></a>
                    <a name="OLE_LINK8">ICar</a>
                    seat = new Seat("Leon", "Grey");
                </p>
                <p>
                    ICar tesla = new Tesla("Model 3", "Red", 2);
                </p>
                <p>
                    Console.WriteLine(seat.ToString());
                </p>
                <p>
                    Console.WriteLine(tesla.ToString());
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
            <td width="287" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="287" valign="top">
                <p>
                    Grey Seat Leon
                </p>
                <p>
                    <a name="OLE_LINK6"></a>
                    <a name="OLE_LINK5">Engine start</a>
                </p>
                <p>
                    Breaaak!
                </p>
                <p>
                    Red Tesla Model 3 with 2 Batteries
                    <br/>
                    Engine start
                </p>
                <p>
                    <a name="OLE_LINK7"></a>
                    <a name="OLE_LINK17"></a>
                    <a name="OLE_LINK16">Breaaak!</a>
                </p>
            </td>
        </tr>
    </tbody>
</table>