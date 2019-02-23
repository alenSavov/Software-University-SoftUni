<h1 align="center">
    Exercises: Introduction to ASP.NET Core
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
<h1 align="center">
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
    Your current task is to extend the functionality of the application, by
    adding Orders, and personal Events.
</p>
<h2>
    1. Data Storage
</h2>
<p>
    Create the following data model:
</p>
<h3>
    Order
</h3>
<p>
    Has the following properties:
</p>
<ul>
    <li>
        Ordered On – a DateTime object.
    </li>
    <li>
        Event – an Event object.
    </li>
    <li>
        Customer – a User object.
    </li>
    <li>
        Tickets Count – an integer.
    </li>
</ul>
<p>
    Each of the <strong>data models</strong>, also has an <strong>Id</strong>,
    which should be a <strong>GUID</strong>. Make the relationship between data
    models.
</p>
<h2>
    2. Front-End
</h2>
<h3>
    Home (logged-in users)
</h3>
<p>
    <strong>Note</strong>
    : Notice how we have [My Events] next to [All Events].
</p>
<h3>
    All Events (logged-in)
</h3>
<p>
    <strong>Note</strong>
    : There is a simple <strong>Form</strong> for <strong>Tickets</strong> in
    the Actions tab.
</p>
<h3>
    My Events (logged-in)
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
<h3>
    All Orders
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
<h3>
    Functionality
</h3>
<p>
The application should provide its Guest users (    <strong>not logged-in</strong>) the functionality to register and login.
</p>
<p>
The application should provide its Regular users (<strong>logged-in</strong> Users with Role – User) the functionality to<strong>view all </strong>Events, <strong>order</strong><strong>tickets</strong> for them, and <strong>view</strong> all Events,<strong>they’ve </strong>ordered<strong> tickets</strong> for (    <strong>My Events</strong>).
</p>
<p>
    The application should provide its Admin users (<strong>logged-in</strong>
Users with Role – Admin) the functionality to <strong>create</strong><strong>new</strong> Events, <strong>view all </strong>Events,<strong>order</strong> <strong>tickets</strong> for them,<strong>view</strong> all Events, <strong>they’ve </strong>ordered<strong> tickets</strong> for (<strong>My Events</strong>), and    <strong>view</strong> all Orders made.
</p>
<p>
    Upon <strong>clicking </strong>the<strong> </strong>[Order] button, you
    should add new Order to the database.
</p>
<p>
    · Each event has its own Tickets Order Form.
</p>
<p>
    · Each submitted Tickets Order (Clicket [Order] button) should create an
    Order with the given Tickets, and the corresponding Event.
</p>