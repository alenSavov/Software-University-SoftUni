<h1 align="center">
    Exercises: Data Binding &amp; Data Validation
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
    Your current task is <strong>very simple</strong>. You just need to
implement the <strong>validation</strong> and proper<strong>error handling</strong> in-case of    <strong>model-binding failure</strong> for the User and Event entities.
</p>
<h2>
    1. Validation
</h2>
<p>
Implement <strong>data validation</strong> for the<strong>data models</strong> which are <strong>affected</strong> by    <strong>user input</strong> (User, Event).
</p>
<h3>
    User
</h3>
<p>
    The following data constraints should be present:
</p>
<p>
    Username
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be <strong>at least 3 symbols long</strong>.
    </li>
    <li>
        May only contain:
    </li>
</ul>
<p>
    o <strong>alphanumeric characters</strong>
</p>
<p>
    o <strong>dashes </strong>and <strong>underscores</strong>
</p>
<p>
o <strong>dots</strong>, <strong>asterisks</strong> and    <strong>tildes</strong>
</p>
<p>
    Password
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be <strong>at least 5 symbols long</strong>.
    </li>
    <li>
        May contain <strong>any</strong> character.
    </li>
</ul>
<p>
    Email
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be a valid <strong>email</strong>.
    </li>
</ul>
<p>
    Unique Citizen Number(UCN)
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should consist of <strong>exactly</strong> <strong>10 numbers</strong>.
    </li>
</ul>
<h3>
    Event
</h3>
<p>
    Name
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be <strong>at least 10 symbols long</strong>.
    </li>
    <li>
        May contain <strong>any</strong> character.
    </li>
</ul>
<p>
    Place
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should <strong>NOT</strong> be <strong>empty</strong>.
    </li>
    <li>
        May contain <strong>any</strong> character.
    </li>
</ul>
<p>
    Start
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be a<strong> valid date</strong>.
    </li>
</ul>
<p>
    End
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be a<strong> valid date</strong>.
    </li>
</ul>
<p>
    Total Tickets
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be a <strong>non-zero integer number</strong>.
    </li>
</ul>
<p>
    Price per Ticket
</p>
<ul>
    <li>
        Should <strong>NOT</strong> be <strong>NULL</strong>.
    </li>
    <li>
        Should be a<strong> decimal number</strong>.
    </li>
</ul>
<h2>
    2. Error Handling
</h2>
<p>
    Implement basic <strong>error handling</strong> in the Eventures
    application.
</p>
<p>
Instead of handling <strong>binding errors</strong> or any other<strong>request-connected errors</strong> in the Controllers, throw    <strong>exceptions</strong> and <strong>handle</strong> them with error
    handlers.
</p>
<p>
Implement <strong>custom view pages</strong> for the<strong>errors</strong>, so that you could provide the client with a    <strong>suitable response</strong>.
</p>