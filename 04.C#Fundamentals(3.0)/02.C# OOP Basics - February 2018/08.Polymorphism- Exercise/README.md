<h1 align="center">
    Exercises: Polymorphism
</h1>
<p>
    This document defines the exercises for
    <a href="https://softuni.bg/courses/csharp-oop-basics">
        "C# OOP Basics" course @ Software University
    </a>
    .
    <br/>
    Please submit your solutions (source code) of all below described problems
    in
    <a href="https://judge.softuni.bg/Contests/241/Polymorphism-Exercise">
        Judge
    </a>
    .
</p>
<h2>
    Problem 1. Vehicles
</h2>
<p>
Write a program that models 2 vehicles (<strong>Car</strong> and<strong>Truck</strong>) and simulates <strong>driving</strong> and<strong>refueling </strong>them. <strong>Car</strong> and<strong>truck</strong> both have <strong>fuel quantity</strong>,<strong>fuel consumption</strong> <strong>in liters</strong>    <strong>per km</strong> and can be <strong>driven a given distance</strong>
    and <strong>refueled with a given amount of fuel.</strong> It’s summer, so
both vehicles use air conditioners and their<strong>fuel consumption</strong> per km is <strong>increased</strong> by<strong>0.9</strong> liters for the <strong>car</strong> and with<strong>1.6</strong> liters for the <strong>truck</strong>. Also, the<strong>truck</strong> has a tiny hole in its tank and when its<strong>refueled</strong> it keeps only <strong>95%</strong> of the given<strong>fuel</strong>. The <strong>car</strong> has no problems and adds    <strong>all the given fuel to its tank. </strong>If a vehicle cannot travel
    the given distance, its fuel does not change.
</p>
<h3>
    Input
</h3>
<p>
    · On the first line – information about the car in the format: "Car {fuel
    quantity} {liters per km}"
</p>
<p>
    · On the second line – info about the truck in the format: "Truck {fuel
    quantity} {liters per km}"
</p>
<ul>
    <li>
        On the third line – the number of commands N that will be given on the
        next N lines
    </li>
    <li>
        On the next N lines – commands in the format:
    </li>
</ul>
<p>
    § "Drive Car {distance}"
</p>
<p>
    § "Drive Truck {distance}"
</p>
<p>
    § "Refuel Car {liters}"
</p>
<p>
    § "Refuel Truck {liters}"
</p>
<h3>
    Output
</h3>
<p>
    · After each Drive command, if there was enough fuel, print on the console
    a message in the format:
</p>
<p>
    § "Car/Truck travelled {distance} km"
</p>
<p>
    · If there was not enough fuel, print: "Car/Truck needs refueling"
</p>
<p>
    · After the End command, print the remaining fuel for both the car and the
    truck, rounded to 2 digits after the floating point in the format:
</p>
<p>
    § <strong>"Car: {liters}"</strong>
</p>
<p>
    § <strong>"Truck: {liters}"</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="175">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="191">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="175" valign="top">
                <p>
                    Car 15 0.3
                </p>
                <p>
                    Truck 100 0.9
                </p>
                <p>
                    4
                </p>
                <p>
                    Drive Car 9
                </p>
                <p>
                    Drive Car 30
                </p>
                <p>
                    Refuel Car 50
                </p>
                <p>
                    Drive Truck 10
                </p>
            </td>
            <td width="191" valign="top">
                <p>
                    Car travelled 9 km
                </p>
                <p>
                    Car needs refueling
                </p>
                <p>
                    Truck travelled 10 km
                </p>
                <p>
                    Car: 54.20
                </p>
                <p>
                    Truck: 75.00
                </p>
            </td>
        </tr>
        <tr>
            <td width="175" valign="top">
                <p>
                    Car 30.4 0.4
                </p>
                <p>
                    Truck 99.34 0.9
                </p>
                <p>
                    5
                </p>
                <p>
                    Drive Car 500
                </p>
                <p>
                    Drive Car 13.5
                </p>
                <p>
                    Refuel Truck 10.300
                </p>
                <p>
                    Drive Truck 56.2
                </p>
                <p>
                    Refuel Car 100.2
                </p>
            </td>
            <td width="191" valign="top">
                <p>
                    Car needs refueling
                </p>
                <p>
                    Car travelled 13.5 km
                </p>
                <p>
                    Truck needs refueling
                </p>
                <p>
                    Car: 113.05
                </p>
                <p>
                    Truck: 109.13
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Vehicles Extension
</h2>
<p>
    Use your solution of the <strong>previous</strong> task for the starting
    point and add more functionality. Add a new vehicle – <strong>Bus</strong>.
Add to every <strong>vehicle </strong>a new property –<strong>tank</strong> <strong>capacity</strong>. A vehicle cannot<strong>start</strong> <strong>with</strong> or <strong>refuel</strong>    <strong>above</strong> its <strong>tank</strong> <strong>capacity</strong>.
</p>
<p>
If you <strong>try to put more fuel</strong> in the tank than the<strong>available space,</strong> print on the console<strong>"Cannot fit {fuel amount} fuel in the tank</strong>    <strong>"</strong> and <strong>do not add any fuel</strong> in the
vehicle’s tank. If you try to <strong>create</strong> a vehicle with<strong>more</strong> <strong>fuel</strong> than its <strong>tank</strong><strong>capacity</strong>, <strong>create</strong> it but start with an    <strong>empty</strong> <strong>tank</strong>.
</p>
<p>
Add a <strong>new command</strong> for the bus. You can<strong>drive</strong> the <strong>bus</strong><strong>with or without people</strong>. <strong>With people</strong>, the<strong>air-conditioner</strong> <strong>is turned on</strong> and its<strong>fuel consumption</strong> per kilometer is<strong>increased by 1.4 liters</strong>. If there are<strong>no people in the bus</strong>, the air-conditioner is    <strong>turned off</strong> and <strong>does not increase</strong> the fuel
    consumption.
</p>
<p>
Finally, add <strong>validation</strong> for the <strong>amount</strong> of<strong>fuel</strong> given to the <strong>Refuel</strong><strong>command</strong> – if it is 0 or negative, print    <strong>"Fuel must be a positive number</strong><strong>"</strong>.
</p>
<h3>
    Input
</h3>
<ul>
    <li>
On the <strong>first</strong> <strong>three</strong>        <strong>lines</strong> you will receive information about the vehicles
        in the format:
    </li>
</ul>
<p>
    § <strong>"</strong>Vehicle {initial fuel quantity} {liters per km} {tank
    capacity}<strong>"</strong>
</p>
<p>
    · On the fourth line – the number of commands N that will be given on the
    next N lines
</p>
<ul>
    <li>
        On the next N lines – commands in format:
    </li>
</ul>
<p>
    § <strong>"</strong>Drive Car {distance}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>Drive Truck {distance}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>Drive Bus {distance}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>DriveEmpty Bus {distance}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>Refuel Car {liters}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>Refuel Truck {liters}<strong>"</strong>
</p>
<p>
    § <strong>"</strong>Refuel Bus {liters}<strong>"</strong>
</p>
<h3>
    Output
</h3>
<p>
    · After each Drive command, if there was enough fuel, print on the console
    a message in the format:
</p>
<p>
    § "Car/Truck travelled {distance} km"
</p>
<ul>
    <li>
        If there was not enough fuel, print:
    </li>
</ul>
<p>
    § "Car/Truck needs refueling"
</p>
<ul>
    <li>
If you try to refuel with an amount <strong>≤ 0 </strong>print:        <strong></strong>
    </li>
</ul>
<p>
    § "Fuel must be a positive number"<strong></strong>
</p>
<p>
    · If the given fuel cannot fit in the tank, print:
</p>
<p>
    § "Cannot fit {fuel amount} fuel in the tank"
</p>
<p>
    · After the End command, print the remaining fuel for all vehicles, rounded
    to 2 digits after the floating point in the format:
</p>
<p>
    § <strong>"Car: {liters}"</strong>
</p>
<p>
    § <strong>"Truck: {liters}"</strong>
</p>
<p>
    § <strong>"Bus: {liters}"</strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="175">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="280">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="175" valign="top">
                <p>
                    Car 30 0.04 70
                </p>
                <p>
                    Truck 100 0.5 300
                </p>
                <p>
                    Bus 40 0.3 150
                </p>
                <p>
                    8
                </p>
                <p>
                    Refuel Car -10
                </p>
                <p>
                    Refuel Truck 0
                </p>
                <p>
                    Refuel Car 10
                </p>
                <p>
                    Refuel Car 300
                </p>
                <p>
                    Drive Bus 10
                </p>
                <p>
                    Refuel Bus 1000
                </p>
                <p>
                    DriveEmpty Bus 100
                </p>
                <p>
                    Refuel Truck 1000
                </p>
            </td>
            <td width="280" valign="top">
                <p>
                    Fuel must be a positive number
                </p>
                <p>
                    Fuel must be a positive number
                </p>
                <p>
                    Cannot fit 300 fuel in the tank
                </p>
                <p>
                    Bus travelled 10 km
                </p>
                <p>
                    Cannot fit 1000 fuel in the tank
                </p>
                <p>
                    Bus needs refueling
                </p>
                <p>
                    Cannot fit 1000 fuel in the tank
                </p>
                <p>
                    Car: 40.00
                </p>
                <p>
                    Truck: 100.00
                </p>
                <p>
                    Bus: 23.00
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Wild Farm
</h2>
<p>
    Your task is to create a <strong>class</strong> <strong>hierarchy</strong>
like <strong>described</strong> <strong>below</strong>. The<strong>Animal</strong>, <strong>Bird</strong>, <strong>Mammal</strong>,<strong>Feline</strong> and <strong>Food</strong> classes should be    <strong>abstract</strong>. Override the method <strong>ToString()</strong>.
</p>
<ul>
    <li>
        <strong>Food – int Quantity;</strong>
    </li>
</ul>
<p>
    § <strong>Vegetable;</strong>
</p>
<p>
    § <strong>Fruit;</strong>
</p>
<p>
    § <strong>Meat;</strong>
</p>
<p>
    § <strong>Seeds;</strong>
</p>
<ul>
    <li>
        <strong>Animal – string Name, double Weight, int FoodEaten;</strong>
    </li>
</ul>
<p>
    § <strong>Bird – double WingSize;</strong>
</p>
<p>
    v <strong>Owl;</strong>
</p>
<p>
    v <strong>Hen;</strong>
</p>
<p>
    § <strong>Mammal – string LivingRegion;</strong>
</p>
<p>
    v <strong>Mouse;</strong>
</p>
<p>
    v <strong>Dog;</strong>
</p>
<p>
    v <strong>Feline;</strong>
</p>
<ul>
    <li>
        <strong>Cat – string Breed;</strong>
    </li>
    <li>
        <strong>Tiger – string Breed;</strong>
    </li>
</ul>
<p>
    All <strong>animals</strong> should also have the <strong>ability</strong>
    to ask for food by <strong>producing</strong> a <strong>sound</strong>.
</p>
<ul>
    <li>
        <strong>Owl – "Hoot Hoot";</strong>
    </li>
    <li>
        <strong>Hen </strong>
        <strong>– "Cluck";</strong>
    </li>
    <li>
        <strong>Mouse – "Squeak";</strong>
    </li>
    <li>
        <strong>Dog – "Woof!";</strong>
    </li>
    <li>
        <strong>Cat – "Meow";</strong>
    </li>
    <li>
        <strong>Tiger – "ROAR!!!";</strong>
    </li>
</ul>
<p>
Now use the <strong>classes</strong> you’ve created to<strong>instantiate</strong> some <strong>animals</strong> and    <strong>feed</strong> <strong>them</strong>.
    <br/>
    Input should be read from the console. Every <strong>even</strong> line
(starting from 0) will <strong>contain</strong>    <strong>information</strong> about an <strong>animal</strong> in the
    following format:
</p>
<ul>
    <li>
        <strong>
            Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}
        </strong>
        <strong>";</strong>
    </li>
    <li>
        <strong>Birds - "{Type} {Name} {Weight} {WingSize}</strong>
        <strong>";</strong>
    </li>
    <li>
        <strong>Mice and Dogs = "{Type} {Name} {Weight} {LivingRegion}</strong>
        <strong>";</strong>
    </li>
</ul>
<p>
On the <strong>odd</strong> lines you will receive    <strong>information</strong> about a piece of <strong>food</strong> that
    you should <strong>give</strong> to that <strong>animal</strong>. The line
    will consist of a <strong>FoodType</strong> and <strong>quantity</strong>,
    separated by a whitespace.
</p>
<p>
    Animals will only eat a certain type of food, as follows:
</p>
<ul>
    <li>
        <strong>Hens</strong>
        eat <strong>everything</strong>;
    </li>
    <li>
        <strong>Mice</strong>
        eat <strong>vegetables</strong> and <strong>fruits</strong>;
    </li>
    <li>
        <strong>Cats</strong>
        east <strong>vegetables</strong> and <strong>meat</strong>;
    </li>
    <li>
        <strong>Tigers</strong>
, <strong>Dogs </strong>and <strong>Owls</strong> eat        <strong>only</strong> <strong>meat</strong>;
    </li>
</ul>
<p>
    If you try to give an animal a different type of food, it will not eat it
    and you should print:
</p>
<ul>
    <li>
        <strong>"</strong>
        <strong>{AnimalType} does not eat {FoodType}!</strong>
        <strong>"</strong>
    </li>
</ul>
<p>
The <strong>weight</strong> of an <strong>animal</strong> will<strong>increase</strong> with <strong>every</strong>    <strong>piece</strong> of <strong>food</strong> it <strong>eats</strong>,
    as follows:
</p>
<ul>
    <li>
        <strong>Hen – 0.35;</strong>
    </li>
    <li>
        <strong>Owl – 0.25;</strong>
    </li>
    <li>
        <strong>Mouse – 0.10;</strong>
    </li>
    <li>
        <strong>Cat – 0.30;</strong>
    </li>
    <li>
        <strong>Dog – 0.40;</strong>
    </li>
    <li>
        <strong>Tiger – 1.00;</strong>
    </li>
</ul>
<p>
    Override the <strong>ToString()</strong> method to print the information
    about an animal in the formats:
</p>
<ul>
    <li>
        <strong>Birds </strong>
        <strong>–</strong>
        <strong>
            "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight},
            {FoodEaten}]
        </strong>
        <strong>"</strong>
    </li>
    <li>
        <strong>Felines – </strong>
        <strong>
            "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight},
            {AnimalLivingRegion}, {FoodEaten}]
        </strong>
        <strong>"</strong>
    </li>
    <li>
        <strong>Mice and Dogs –</strong>
        <strong>
            "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion},
            {FoodEaten}]
        </strong>
        <strong>"</strong>
    </li>
</ul>
<p>
After you read <strong>information</strong> about an<strong>animal</strong> and some <strong>food</strong>, the<strong>animal</strong> will <strong>produce a</strong><strong>sound</strong> (<strong>print</strong> it on the<strong>console</strong>). Next, you should <strong>try</strong> to    <strong>feed</strong> it. After receiving the “<strong>End</strong>”
command, <strong>print</strong> information about <strong>every</strong>    <strong>animal</strong> in <strong>order</strong> of <strong>input</strong>
    .
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="261" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="326" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    Cat Pesho 1.1 Home Persian
                </p>
                <p>
                    Vegetable 4
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    Meow
                </p>
                <p>
                    Cat [Pesho, Persian, 2.3, Home, 4]
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    Tiger Typcho 167.7 Asia Bengal
                </p>
                <p>
                    Vegetable 1
                </p>
                <p>
                    Dog Doncho 500 Street
                </p>
                <p>
                    Vegetable 150
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    ROAR!!!
                </p>
                <p>
                    Tiger does not eat Vegetable!
                </p>
                <p>
                    Woof!
                </p>
                <p>
                    Dog does not eat Vegetable!
                </p>
                <p>
                    Tiger [Typcho, Bengal, 167.7, Asia, 0]
                </p>
                <p>
                    Dog [Doncho, 500, Street, 0]
                </p>
            </td>
        </tr>
        <tr>
            <td width="261" valign="top">
                <p>
                    Mouse Jerry 0.5 Anywhere
                </p>
                <p>
                    Fruit 1000
                </p>
                <p>
                    Owl Toncho 2.5 30
                </p>
                <p>
                    Meat 5
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="326" valign="top">
                <p>
                    Squeak
                </p>
                <p>
                    Hoot Hoot
                </p>
                <p>
                    Mouse [Jerry, 100.5, Anywhere, 1000]
                </p>
                <p>
                    Owl [Toncho, 30, 3.75, 5]
                </p>
            </td>
        </tr>
    </tbody>
</table>