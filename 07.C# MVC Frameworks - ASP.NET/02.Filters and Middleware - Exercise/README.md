<h1 align="center">
    Exercises: Application Flow &amp; Middleware
</h1>
<p>
    Problems for exercises and homework for the
    <a
        href="https://softuni.bg/trainings/2197/csharp-mvc-frameworks-asp-net-core-november-2018"
    >
        “C# MVC Frameworks - ASP.NET Core” course @ SoftUni
    </a>
    .
</p>
<h1>
    Eventures
</h1>
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
Your current task is to create the <strong>architecture</strong> and    <strong>core logic</strong> of the <strong>application</strong>, so get
    started.
</p>
<h2>
    1. Data Storage
</h2>
<p>
    The core application logic requires <strong>2 data models</strong> to be
    implemented:
</p>
<h3>
    User
</h3>
<p>
    Has the following properties:
</p>
<ul>
    <li>
        Username – a string (from IdentityUser)<strong>.</strong>
    </li>
    <li>
        Password – a string (from IdentityUser)<strong>.</strong>
    </li>
    <li>
        Email – a string (from IdentityUser)<strong>.</strong>
    </li>
    <li>
        First Name – a string.
    </li>
    <li>
        Last Name – a string.
    </li>
    <li>
        Unique Citizen Number (UCN) – a string.
    </li>
    <li>
        Role – can be User / Admin
    </li>
</ul>
<h3>
    Event
</h3>
<p>
    Has the following properties:
</p>
<ul>
    <li>
        Id – a <strong>UUID</strong>.
    </li>
    <li>
        Name – a string.
    </li>
    <li>
        Place – a string.
    </li>
    <li>
        Start – a DateTime object.
    </li>
    <li>
        End – a DateTime object.
    </li>
    <li>
        Total Tickets – an integer.
    </li>
    <li>
        Price Per Ticket – a <strong>decimal</strong> value.
    </li>
</ul>
<h2>
    2. Front-End
</h2>
<p>
    The Front-End might be a little different in some small components than the
    things you’ve done so far. However, do not panic, it is not that hard to do
    it. You can do it! 😉
</p>
<p>
    There are a few templates you must implement, they are not that much, but
    they are tricky.
</p>
<h3>
    Index Template
</h3>
<h3>
    Login Template
</h3>
<p>
    The Forgot your password? Is a just a link with no functionality, for now.
</p>
<h3>
    Register Template
</h3>
<h3>
    Home (logged-in users)
</h3>
<h3>
    All Events (logged-in)
</h3>
<h3>
    Admin Home (logged-in Admin)
</h3>
<h4>
    Admin Navigation
</h4>
<h3>
    Create Events
</h3>
<p>
    <strong>Note</strong>
    : The color for the application is #AFEEEE.
</p>
<h2>
    3. Business Logic
</h2>
<h3>
    Technical Requirements
</h3>
<p>
    The application should be an <strong>ASP.NET Core Web</strong> app. As such
it should use <strong>the most</strong> of the    <strong>ASP.NET Core MVC Framework</strong>.
</p>
<p>
    Use <strong>ASP.NET Core Identity</strong> for authentication. Add the
    following <strong>roles</strong> to your User functionality – (‘USER’,
    ‘ADMIN’).
</p>
<h3>
    Functionality
</h3>
<p>
The application should provide its Guest users (    <strong>not logged-in</strong>) the functionality to register and login.
</p>
<p>
The application should provide its Regular users (<strong>logged-in</strong> Users with Role – User) the functionality to    <strong>view all </strong>Events.
</p>
<p>
    The application should provide its Admin users (<strong>logged-in</strong>
Users with Role – Admin) the functionality to <strong>create</strong>    <strong>new</strong> Events, <strong>view all </strong>Events.
</p>
<h2>
    4. Logging Provider
</h2>
<p>
    A logging provider <strong>displays or stores logs</strong>. For example,
    the Console provider displays logs on the console. The default project
    template calls the <strong>CreateDefaultBuilder</strong> extension method,
    which adds the logging providers Consolе, Debug, EventSource (starting in
    ASP.NET Core 2.2).
</p>
<p>
    If you use <strong>CreateDefaultBuilder</strong>, you can replace the
default providers with your own choices. Call    <strong>ClearProviders</strong>, and add the providers you want.
</p>
<h3>
    Create Logs
</h3>
<p>
Get an <strong>ILogger&lt;TCategoryName&gt;</strong> object from DI and    <strong>create information log for created Event</strong>.
</p>
<h2>
    5. Middleware
</h2>
<p>
Create a Middleware, which <strong>seeds</strong> the    <strong>database</strong> upon <strong>Application startup</strong>. It
    should <strong>seed</strong> the database with the Roles and it should seed
    a single Admin User.
</p>
<h2>
    6. Filters
</h2>
<p>
    Create an ActionFilter which <strong>Logs</strong> each Admin Create Event
    activity, after the action itself. The log should output a single message:
</p>
<p>
    [{currentDateAndTime}] Administrator {Username} create event {EventName}
    ({EventStart} / {EventEnd}).
</p>