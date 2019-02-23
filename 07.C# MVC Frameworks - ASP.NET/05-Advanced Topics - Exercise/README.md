<p align="center">
    <strong>Exercise: Advanced Topics</strong>
</p>
<p align="center">
    Problems for exercises and homework for the
    <a
        href="https://softuni.bg/trainings/2197/csharp-mvc-frameworks-asp-net-core-november-2018"
    >
        “C# MVC Frameworks - ASP.NET Core” course @ SoftUni
    </a>
    .
</p>
<h3 align="center">
    Eventures
</h3>
<p>
    <strong>Eventures</strong>
    <strong>Inc</strong>
. is a fast-rising newly made Start-Up Company, which specializes in    <strong>Event Tickets Sales</strong>. It is said to be the killer of
    systems like Eventim, Eventbride, etc.
</p>
<p>
You have been appointed as the developer of the    <strong>main web application</strong>. This is a great responsibility, so
    do your best and do not dissapoint your employers. The application
functionality is not that complex, and it will be    <strong>separated</strong> into <strong>several parts</strong>, each part
    consisting of <strong>several tasks</strong>.
</p>
<p>
Your current task is to extend the <strong>business logic</strong> of the<strong>application</strong>, by adding <strong>social login</strong>,    <strong> auto mapping</strong> etc.
</p>
<h2>
    1. Social Accounts
</h2>
<p>
    Add functionality to <strong>login with Facebook</strong>.
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>NOTE:</strong>
    Go to the Facebook Login product Settings and make sure to add the
following redirect URIs in Client OAuth Settings. By default    <strong>ASP.NET Core</strong> is using the /signin-facebook redirect URI.
Be sure to add for <strong>HTTPS</strong> as well, because    <strong>the ASP.NET Core 2.1 application is running in HTTPS</strong>.
</p>
<p>
    <strong>HINT:</strong>
    Check the code in the default Login.cshtml and customize it.
</p>
<h2>
    2. AutoMapper
</h2>
<p>
    Replace all your manual object mappings to use AutoMapper. Everywhere in
    your project.
</p>
<h2>
    3. Available Events
</h2>
<p>
    As you know, the Events have a <strong>total ticket count</strong>. Last
    time we implemented Orders. But these Orders weren’t fully functional.
    Here’s a little change to that functionality.
</p>
<p>
Each time a certain amount of <strong>tickets</strong> is    <strong>ordered</strong>, the <strong>ticket count</strong> of the
corresponding Event, should be <strong>reduced</strong> by the Order’s    <strong>ticket amount</strong>. When an Event’s <strong>tickets</strong>
are <strong>reduced</strong> to<strong> 0</strong>, it should    <strong>not</strong> be <strong>visualized</strong> on the All Events page
    (it is no longer available).
</p>
<p>
    <strong>Note</strong>
: If an Event has <strong>5 tickets</strong>, and an Order with<strong>10 tickets</strong> is attempted, it should throw an    <strong>error</strong>. The <strong>error</strong> is up to you.
</p>