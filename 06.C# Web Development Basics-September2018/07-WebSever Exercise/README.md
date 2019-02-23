<h1 align="center">
    Exercise: Databases – EF Core
</h1>
<h1 align="center">
    IRunes
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-web-development-basics">
        “C# Web Basics” course @ SoftUni
    </a>
    . Yoy can submit your solution in the course web page.
</p>
<p>
    You have been tasked to implement a simple application, using the Web
Server. The application imitates a <strong>store</strong> for    <strong>Music Albums</strong> and <strong>Music Tracks</strong>. You will
    see the functionality – described below.
</p>
<h2>
    1. Database Requirements
</h2>
<p>
    The first thing you need to do is implement the Database entities. Use
    Entity Framework Core, and implement the following entities:
</p>
<h3>
    User
</h3>
<ul>
    <li>
        Id – a <strong>string</strong> (<strong>GuID</strong>).
    </li>
    <li>
        Username – a <strong>string</strong>.
    </li>
    <li>
        Password – a <strong>string</strong> (<strong>encoded</strong> in the
        database).
    </li>
    <li>
        Email – a <strong>string</strong>.
    </li>
</ul>
<h3>
    Album
</h3>
<ul>
    <li>
        Id – a <strong>string</strong> (<strong>GuID</strong>).
    </li>
    <li>
        Name – a <strong>string</strong>.
    </li>
    <li>
Cover – a <strong>string</strong> (a <strong>link</strong> to an        <strong>image</strong>).
    </li>
    <li>
Price – a <strong>decimal</strong> (<strong>sum</strong> of all Tracks’<strong>prices</strong>, <strong>reduced</strong> by        <strong>13%</strong>).
    </li>
    <li>
        Tracks – a <strong>collection</strong> of Tracks.
    </li>
</ul>
<h3>
    Track
</h3>
<ul>
    <li>
        Id – a <strong>string</strong> (<strong>GuID</strong>).
    </li>
    <li>
        Name – a <strong>string</strong>.
    </li>
    <li>
Link – a <strong>string</strong> (a <strong>link</strong> to a        <strong>video</strong>).
    </li>
    <li>
        Price – a <strong>decimal</strong>.
    </li>
</ul>
<h2>
    2. Template Requirements
</h2>
<p>
    Here you will find your template requirements. This is a simple
    application, but it will work with HTML pages, so get ready to write a lot
    of HTML. 😉 Each HTML Page comes with a Route on which you should return it.
</p>
<h3>
    Index (guest, logged-out) (route=”/Home/Index”, route=”/”)
</h3>
<p>
    [<strong>Login</strong>]<strong> </strong>links <strong>relocate</strong>
    you to “/Users/Login”.
</p>
<p>
[<strong>Register</strong>]<strong> </strong>links    <strong>relocate</strong> you to “/Users/Register”.
</p>
<h3>
    Login (guest, logged-out) (route=”/Users/Login”)
</h3>
<p>
The [<strong>Login</strong>] button <strong>submits</strong> the<strong>form </strong>with<strong> </strong>a <strong>POST</strong>    <strong>request</strong> to “/Users/Login”.
</p>
<h3>
    Register (guest, logged-out) (route=”/Users/Register”)
</h3>
<p>
The [<strong>Register</strong>] button <strong>submits</strong> the<strong>form </strong>with<strong> </strong>a <strong>POST</strong>    <strong>request</strong> to “/Users/Register”.
</p>
<h3>
    Index (user, logged-in) (route=”/Home/Index”, route=”/”)
</h3>
<h3>
    All Albums (user, logged-in) (route=”/Albums/All”)
</h3>
<p>
[<strong>Create</strong> <strong>Album</strong>] links    <strong>relocate</strong> you to “/Albums/Create”.
</p>
<h3>
    Album Create (user, logged-in) (route=”/Albums/Create”)
</h3>
<p>
The [<strong>Create</strong>] button <strong>submits</strong> the<strong>form </strong>with<strong> </strong>a <strong>POST</strong>    <strong>request</strong> to “/Albums/Create”.
</p>
<p>
    [<strong>Back To All</strong>] links <strong>relocate</strong> you to
    “/Albums/All”.
</p>
<h3>
    Album Details (user, logged-in) (route=”/Albums/Details?id={albumId}”)
</h3>
<p>
[<strong>Create</strong> <strong>Track</strong>] links    <strong>relocate</strong> you to “/Tracks/Create?albumId={albumId}”.
</p>
<p>
    [<strong>Back To All</strong>] links <strong>relocate</strong> you to
    “/Albums/All”.
</p>
<h3>
    Track Create (user, logged-in) (route=”/Tracks/Create?albumId={albumId}”)
</h3>
<p>
The [<strong>Create</strong>] button <strong>submits</strong> the<strong>form </strong>with<strong> </strong>a <strong>POST</strong>    <strong>request</strong> to “/Tracks/Create?albumId={albumId}”.
</p>
<p>
    [<strong>Back To Album</strong>] links <strong>relocate</strong> you to
    “/Album/Details?id={albumId}”. (the Album from which this page was
    accessed).
</p>
<h3>
    Track Details (user, logged-in)
    (route=”/Tracks/Details?albumId={albumId}&amp;trackId={trackId}”)
</h3>
<p>
    [<strong>Back To Album</strong>] links <strong>relocate</strong> you to
    “/Album/Details?id={albumId}”. (the Album from which this page was
    accessed).
</p>
<h2>
    3. Functional Requirements
</h2>
<p>
    The functional requirements are quite simple.
</p>
<h3>
    Users
</h3>
<p>
The application should provide guests (logged-out) with the    <strong>functionality</strong> to access:
</p>
<ul>
    <li>
        The Guest Index Page
    </li>
    <li>
        The Login Page and Functionality
    </li>
</ul>
<p>
    · The Register Page and Functionality
</p>
<p>
The application should provide users (logged-in) with the    <strong>functionality</strong> to access:
</p>
<ul>
    <li>
        The User Index Page
    </li>
</ul>
<p>
    · The All Albums Page and Functionality
</p>
<p>
    · The Album Create Page and Functionality
</p>
<p>
    · The Album Details Page and Functionality
</p>
<p>
    · The Track Create Page and Functionality
</p>
<p>
    · The Track Details Page and Functionality
</p>
<h3>
    Albums
</h3>
<p>
    The Albums are <strong>created</strong> and <strong>presented</strong> on
    the All Albums Page, in a <strong>listed format</strong> with only their
    names as elements. Each <strong>album</strong> <strong>name</strong> should
    be a <strong>link</strong> which <strong>leads</strong> to the
    corresponding Album’s Details Page.
</p>
<p>
    If there <strong>are no Albums currently</strong> in the Database, a
    message “There are currently no albums.” should be printed.
</p>
<p>
    On the Album’s Details Page, its tracks should be <strong>listed</strong>,
in an <strong>indexed list</strong>, <strong>starting</strong> from<strong>1</strong>. The <strong>order</strong> of <strong>data</strong> is    <strong>not mandatory</strong>.
</p>
<p>
    Each <strong>track name</strong> should be a link which leads to the
    corresponding Track’s Details Page.
</p>
<h3>
    Tracks
</h3>
<p>
    The Tracks are <strong>created</strong> and <strong>presented</strong> on
    their Album’s Details Page. Tracks are created using the Album’s id which
    is passed through the <strong>query parameters</strong>.
</p>
<p>
When you <strong>create</strong> a Track, you can pass it the    <strong>iframe-ready url</strong>, in order to make your work easier.
</p>
<h2>
    4. Notes
</h2>
<p>
    <strong>Note</strong>
: <strong>No data validation</strong> is <strong>required</strong>. If an    <strong>invalid</strong> <strong>form</strong> is <strong>sent</strong>,
    just <strong>redirect back</strong> to the form.
</p>
<p>
    <strong>Note</strong>
    : If the <strong>2 passwords</strong> of the <strong>Registration</strong>
of <strong>Users</strong> do <strong>NOT match</strong>, just    <strong>redirect back</strong> to the form.
</p>