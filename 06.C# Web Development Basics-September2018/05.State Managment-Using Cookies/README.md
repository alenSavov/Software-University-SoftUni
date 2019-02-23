<h1 align="center">
    SIS – SoftUni Information Services
</h1>
<p>
    SIS is a combination of a Web Server and a MVC Framework. Ultimately it is
    designed to mimic Microsoft’s IIS and ASP.NET Core. Following several Lab
    documents you will build all components of the SIS.
</p>
<h1 align="center">
    SIS: Handmade HTTP Server
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-web-development-basics">
        “C# Web Development Basics” course @ SoftUni
    </a>
    .
</p>
<p>
    Following to the end this document will help you to create your own very
    simple HTTP Server. Later in the course we will extend it by adding
    sessions, cookies etc. We will eventually build a MVC Framework, with which
    we can build MVC Web Application which will be hosted on the Handmade HTTP
    Server.
</p>
<h1>
    State management
</h1>
<p>
    In this lab you will configure the Server to be stateful. This means that
    we will add a few classes for Cookies and Sessions, in order to maintain
    states about our clients.
</p>
<p>
Start by <strong>adding</strong> the following    <strong>2 namespaces</strong> to the SIS.HTTP project.
</p>
<p>
    And now let’s get to the main thing...
</p>
<h2>
    1. Cookies
</h2>
<h3>
    HttpCookie Class
</h3>
<p>
The first thing we need to do is add the functionality for the<strong>Cookies</strong>, they will be the most    <strong>primitive element</strong> to our <strong>State Management</strong>
    .
</p>
<p>
    Create a class, called HttpCookie, <a name="_Hlk526081189">in the </a>
    Cookies namespace. The class should have the following properties:
</p>
<ul>
    <li>
        Key – a <strong>string</strong>, representing the <strong>key</strong>
        (or the <strong>name</strong>) of the <strong>Cookie</strong>.
    </li>
    <li>
Value – a <strong>string</strong>, representing the<strong>value</strong> (or the <strong>content</strong>) of the        <strong>Cookie</strong>.
    </li>
    <li>
Expires – a <strong>DateTime</strong>, representing the        <strong>expiration time</strong> of the <strong>Cookie</strong>.
    </li>
</ul>
<p>
o This <strong>property</strong> will be initialized with an    <strong>integer</strong>, which will represent <strong>DAYS</strong>, from
    the <strong>current moment</strong>.
</p>
<ul>
    <li>
IsNew – a <strong>boolean</strong>, which will be used to<strong>define</strong> if the <strong>Cookie</strong> is<strong>freshly created</strong>. This way we will know if the<strong>Server</strong> has <strong>created</strong> the<strong>Cookie</strong> (for example when the        <strong>Client logs in</strong>) or the <strong>Cookie</strong> comes
        from the <strong>Client</strong>.
    </li>
</ul>
<p>
The ToString() method formats the <strong>Cookie</strong>    <strong>parameters</strong> in <strong>Web-ready format</strong>.
</p>
<p>
    There are <strong>2 constructors</strong> which control the way the IsNew
    property is <strong>initialized</strong>, due to its behaviour:
</p>
<p>
    And with this we have completed our HttpCookie class. Now it’s time to
    create a <strong>Repository-like</strong> class for it.
</p>
<h3>
    HttpCookieCollection Class
</h3>
<p>
    Create an interface, called IHttpCookieCollection in the Cookies namespace.
    It should look like this.
</p>
<p>
    The classes that implement the interface and its methods should have the
    following functionality:
</p>
<ul>
    <li>
Add() – <strong>adds</strong> the given Cookie to a        <strong>collection</strong> of HttpCookies.
    </li>
</ul>
<p>
    · ContainsCookie() – returns a <strong>boolean</strong> result, on whether
    the <strong>given key</strong> is <strong>contained</strong> in the
    HttpCookie collection.
</p>
<ul>
    <li>
        GetCookie() – <strong>extracts</strong>, form the HttpCookie
collection, the Cookie with the <strong>given key</strong>, and        <strong>returns it</strong>.
    </li>
</ul>
<p>
· HasCookies() – returns a <strong>boolean</strong> result, on<strong>whether</strong> there are <strong>ANY</strong>    <strong>cookies</strong> in the HttpCookie collection.
</p>
<p>
    The class is yours to implement. : )
</p>
<p>
    The HttpCookieCollection class should also have a ToString() override
    method, that should format the Cookies in Web-Ready format:
</p>
<p>
    Now let’s add the Cookies to our main communication classes – The
    HttpRequest &amp; HttpResponse.
</p>
<h3>
    HttpRequest
</h3>
<p>
    Add an IHttpCookieCollection property to the HttpRequest class. Intiialize
    it from the constructor. Write a method ParseCookies(), which checks the
    HttpHeadersCollection for a Header with name “Cookie” and if there is,
extracts its <strong>string value</strong>, <strong>formats</strong> it,    <strong>parses</strong> it and <strong>adds</strong> it to the
    HttpCookieCollection.
</p>
<h3>
    HttpResponse
</h3>
<p>
    Add an IHttpCookieCollection property to the HttpResponse class. Intiialize
it from the constructor. Write a public method AddCookie(), which    <strong>adds</strong> the <strong>given</strong> Cookie to the
    HttpCookieCollection.
</p>
<p>
    Reformat the ToString() method so that it includes the Cookies, if there
are any, with a “Set-Cookie” <strong>name</strong>, and<strong>values</strong> – separated by a <strong>semi colon</strong> and a    <strong>space</strong>.
</p>
<p>
    And with this we are done with the Cookies’ implementation in our HTTP
    Server. This will be enough for now. As the time passes by, we will
    obviously refactor them, extend them, optimize them and manipulate them in
    many ways, but let’s be patient.
</p>
<p>
    <strong>NOTE</strong>
: Each of the <strong>public methods</strong> and<strong>properties</strong> you’ve <strong>added</strong> should<strong>be</strong> <strong>also added</strong> to the    <strong>interfaces</strong> of the <strong>corresponding classes</strong>.
</p>
<h2>
    2. Sessions
</h2>
<p>
The next big thing we need to implement is the Sessions. They are    <strong>Server-side State Management</strong> mechanism, and are the most
    important element of the Stateful functionality.
</p>
<h3>
    IHttpSession
</h3>
<p>
    Let’s start with the interface. Create an interface, called IHttpSession,
in the Sessions namespace. The HttpSession should have a    <strong>collection</strong> of <strong>parameters</strong> and a Id which
    is a <strong>string</strong>. The interface should look like this:
</p>
<p>
As you can see there are <strong>several methods </strong>for<strong>accessing</strong> the <strong>collection</strong> of    <strong>parameters</strong>, as it will be <strong>private</strong>. This
    is everything we need as public behaviour.
</p>
<p>
The classes that implement the <strong>interface</strong> and its    <strong>methods</strong> should have the following functionality:
</p>
<ul>
    <li>
        Id – just a property with a getter.
    </li>
</ul>
<p>
· GetParameter() – <strong>extracts</strong>, form the    <strong>parameter collection</strong>, the <strong>parameter</strong> with
    the <strong>given name</strong>, and <strong>returns it</strong>.
</p>
<p>
    · ContainsParameter() – returns a <strong>boolean</strong> result, on
whether a <strong>parameter</strong> with <strong>given name</strong> is    <strong>contained</strong> in the collection.
</p>
<ul>
    <li>
AddParameter() – <strong>adds</strong> the given parameter with the<strong>given name</strong> to a <strong>key-value-pair</strong>        <strong>collection</strong> of <strong>parameters</strong>.
    </li>
    <li>
ClearParameters() – <strong>clears</strong> the        <strong>collection</strong>, emptying it.
    </li>
</ul>
<p>
    The class is yours to implement. : )
</p>
<p>
    <strong>Note</strong>
: The <strong>constructor</strong> of the <strong>class</strong> should    <strong>initialize</strong> the <strong>collection</strong> and the Id.
    Here’s a hint on how it should look:
</p>
<p>
The HttpSessions are implemented, but there is something missing. The    <strong>Server</strong> needs to store the Sessions somewhere.
</p>
<h3>
    HttpSessionStorage
</h3>
<p>
    Create a class named HttpSessionStorage, in the Sessions namespace. We will
use this <strong>class</strong> to <strong>store</strong> our    <strong>sessions</strong>, in a <strong>Dictionary-like</strong>
collection. But our <strong>Server</strong> will work with    <strong>many Clients parallelly</strong>, which means that the collection
    must be <strong>async-friendly</strong>, or <strong>thread-safe</strong>.
</p>
<p>
    Well, there is a collection that just does the trick.
</p>
<p>
    We would also need a <strong>Session Key</strong>, something with which our
    Session will be sent as a Cookie to the Client.
    <br/>
Let’s call it “SIS_ID”. This will be the <strong>SIS</strong>’s    <strong>Session Key</strong>.
</p>
<p>
The GetSession() method <strong>retrieves</strong> a Session from the    <strong>Session Storage collection</strong> if it <strong>exists</strong>,
or <strong>adds</strong> it and <strong>then retrieves</strong> it, if it    <strong>does NOT exist</strong>.
</p>
<p>
    And with this we are ready with our HttpSessionStorage. Now it’s time to
include all we’ve created so far in the main business logic of our    <strong>Server</strong>.
</p>
<h2>
    3. Server
</h2>
<p>
    We have to add the Sessions functionality to our ConnectionHandler, in
    order for it to be linked with the <strong>Client</strong>.
</p>
<p>
    The following things must be included in our logic:
</p>
<ul>
    <li>
        <strong>Initialize</strong>
        the Request Session – <strong>Check</strong> if the Request contains a
        Cookie with the <strong>SIS Session Key</strong>.
    </li>
</ul>
<p>
    o If <strong>there is</strong>:
</p>
<p>
    § <strong>Extract</strong> the <strong>value</strong> of the Cookie (which
    will be the <strong>id</strong> of the Session).
</p>
<p>
    § <strong>Use</strong> the <strong>id</strong> to <strong>extract</strong>
    the Session from the Session storage.
</p>
<p>
    § <strong>Set</strong> it to the Request’s Session property.
</p>
<p>
    o If <strong>there isn’t</strong>:
</p>
<p>
§ <strong>Generate</strong> a <strong>new GuID</strong>, create a    <strong>new Session</strong> with it.
</p>
<p>
    § <strong>Add</strong> the new Session to the Session storage.
</p>
<p>
    § <strong>Set</strong> it to the Request’s Session property.
</p>
<p>
o This should be achieved by <strong>adding</strong> the    <strong>following method</strong> to the ConnectionHandler class:
</p>
<ul>
    <li>
        <strong>Initialize</strong>
the Response Session – <strong>Add</strong> a Cookie with the        <strong>SIS Session Key </strong>as<strong> Cookie key</strong>, and
        the Request’s session id, as <strong>Cookie value</strong>
    </li>
</ul>
<p>
o This should be achieved by <strong>adding</strong> the    <strong>following method</strong> to the ConnectionHandler class:
</p>
<p>
The <strong>invocation</strong> of these methods should be    <strong>performed</strong> while <strong>processing</strong> the Request.
    Modify the ProcessRequest() method like this:
</p>
<p>
    And this should do for now. We have <strong>implemented</strong> a very
simple <strong>State Management</strong> mechanism in our    <strong>SIS</strong>’s <strong>HTTP Server</strong>.
</p>
<p>
    As the Server is implement, currently, it generates a Session for every
    connected client. That Session however is <strong>manipulatable</strong>,
and we can <strong>add parameters</strong> to it.    <strong>Parameters</strong> such as username for example. Such parameters
may be used to <strong>indicate</strong> if the <strong>Client</strong> is    <strong>logged in</strong>, or what are his <strong>permissions</strong> ot
    our application.
</p>
<h2>
    4. Test it out
</h2>