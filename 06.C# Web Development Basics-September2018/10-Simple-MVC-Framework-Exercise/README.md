<h1 align="center">
    SIS – SoftUni Information Services
</h1>
<p>
    SIS is a combination of a Web Server and a MVC Framework. Ultimately it is
    designed to mimic Microsoft’s IIS and ASP.NET Core. Following several Lab
    documents you will build all components of the SIS.
</p>
<h1 align="center">
    SIS: Simple MVC Framework
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
    simple MVC Framework, which depends on the HTTP Server we already have. We
    will eventually extend the Framework, so that we can build dynamic and
    functional MVC Web Applications which will be hosted on the Handmade HTTP
    Server.
</p>
<h2>
    1. Project Setup
</h2>
<p>
    Create a project, named SIS.Framework, and link the SIS.WebServer project
    to it.
</p>
<p>
    Then create the following <strong>folder structure </strong>in the
    SIS.Framework<strong> </strong>project<strong>:</strong>
</p>
<p>
    From now on it will be easier to place the new classes and interfaces in
    the right folders.
</p>
<h2>
    2. Attributes
</h2>
<p>
Our framework needs several Attributes that would be placed on the    <strong>Methods</strong> of our <strong>Controllers</strong> to annotate
    whether the <strong>method</strong> can be invoked by GET, POST, PUT or
DELETE requests. These attributes will validate whether the    <strong>Method</strong> of the <strong>Controller</strong> can be executed.
    For example, if a method in the controller is marked as [HttpPost] it can
    be only invoked by a POST request.
</p>
<p>
In the <strong>Attributes folder</strong>, create a<strong>Methods sub-folder</strong>. In that, create an    <strong>abstract</strong> attribute HttpMethodAttribute that inherits
    Attribute and has <strong>one abstract boolean</strong> method
    IsValid(string requestMethod).
</p>
<p>
    Create a class, named HttpGetAttribute that inherits HttpMethodAttribute
    and overrides the IsValid() method. The overridden method should return
    true if the provided request method equals GET, otherwise returns false.
</p>
<p>
    Create a class, named HttpPostAttribute, like the HttpGetAttribute but this
    time the IsValid() method should validate whether the request method is
    POST.
</p>
<p>
    Create a class, named HttpPutAttribute, like the HttpGetAttribute but this
    time the IsValid() method should validate whether the request method is
    PUT.
</p>
<p>
    Create a class, named HttpDeleteAttribute, like the HttpGetAttribute but
    this time the IsValid() method should validate whether the request method
    is DELETE.
</p>
<h2>
    3. MVC Context
</h2>
<p>
    When the application is running we need to store and access information
about the <strong>context</strong> where our <strong>MVC Apps </strong>are<strong>executed</strong>, such as the <strong>Name </strong>of the<strong> Assembly, </strong>the<strong> Path </strong>to the<strong> Controllers Folder, </strong>the <strong>Paths </strong>to the    <strong>Views and Models folders</strong>, the <strong>Suffix </strong>of
    our<strong> Controllers</strong>, etc.
    <br/>
    When we start our application, we need to instantiate that Context only
    once. We can use the <strong>Singleton pattern</strong>.
    <br/>
    In C#, that is easily done.
</p>
<p>
    Create a class, named MvcContext in the SIS.Framework project.
</p>
<h2>
    4. Extending the Server
</h2>
<h3>
    IHttpHandler
</h3>
<p>
    The classes implementing this <strong>Interface</strong> would be
    responsible to <strong>Handle </strong>a<strong> HTTP request </strong>and
build a<strong> HTTP response</strong>. It should implement    <strong>1</strong> method Handle(IHttpRequest request) that returns a
IHttpResponse. (our <strong>router</strong> will implement that    <strong>Interface</strong>).
</p>
<p>
    <strong>IMPORTANT</strong>
    : Create this <strong>interface</strong> on the WebServer project, in a
    folder called Api.
</p>
<h3>
    Instatiation
</h3>
<p>
    Configure the WebServer to be able to use an IHttpHandler for its routing.
    Do <strong>NOT</strong> <strong>delete</strong> the ServerRoutingTable,
    just think of a way to <strong>combine</strong> them.
</p>
<p>
    <strong>For examle</strong>
    : <strong>create 2 constructors</strong>, one with an IHttpHandler and
another with the ServerRoutingTable. <strong>Depending</strong> on<strong>which one</strong> of them was <strong>given</strong>,<strong>configure</strong> the ConnectionHandler to work with a    <strong>different routing mechanism</strong>.
</p>
<p>
    <strong>Note</strong>
    : The example above is <strong>not mandatory</strong>. If you can think of
    a <strong>better way</strong> to implement it, feel free to do so.
</p>
<h2>
    5. Action Results Interfaces
</h2>
<p>
    The Framework should provide applications with a generic Controller Action
    Result functionality. Let’s implement some <strong>interfaces</strong> for
    those classes.
</p>
<p>
    Create a namespace, called ActionResults. We will use that namespace for
    the <strong>following 2 tasks</strong>.
</p>
<p>
    Implement the following interfaces in the ActionResults namespace.
</p>
<h4>
    IRenderable
</h4>
<p>
This <strong>interface</strong> has only 1 method Render() that returns    <strong>string</strong>. The class implementing that method should be
responsible for providing and <strong>structuring</strong> the    <strong>content</strong> of a <strong>Response</strong> to the server.
</p>
<p align="center">
    <strong> </strong>
</p>
<h4>
    IActionResult
</h4>
<p>
    <strong>This interface will be used to define the results of our </strong>
Controllers<strong>’ </strong>Actions<strong>. We will have different </strong>ActionResults<strong>, based on the </strong>Controller<strong>’s </strong>Action    <strong> invocation.</strong>
</p>
<h4>
    IViewable
</h4>
<p>
This interface will extend the IActionResult. It will be used for our    <strong>View results</strong>, which return <strong>HTML pages</strong>.
</p>
<h4>
    IRedirectable
</h4>
<p>
This interface will extend the IActionResult. It will be used for our<strong>Redirect results</strong>, which <strong>redirect</strong> the    <strong>Client</strong>, to another <strong>location</strong>.
</p>
<h2>
    6. Action Results Implementations
</h2>
<p>
    Now we need to create the classes which would implement the ActionResult
    interfaces, so that we could actually make <strong>Result Objects</strong>.
</p>
<h3>
    ViewResult
</h3>
<p>
    Create a class, named ViewResult, which implements the IViewable interface.
    We will use this class for our <strong>View Results</strong> – the HTML
    Pages. The class should be implemented like this:
</p>
<h3>
    RedirectResult
</h3>
<p>
    Create a class, named RedirectResult, which implements the IRedirectable
    interface. We will use this class for our <strong>Redirect Results</strong>
    – the <strong>Client redirection</strong>. The class should be implemented
    like this:
</p>
<h2>
    7. View
</h2>
<p>
    But to represent data to the clients, we need to have a class for the
Views. Thus, you should create a class, named View, in the Views    <strong>namespace</strong> in the Framework project. It should implement
    the IRenderable interface.
</p>
<p>
    The class should hold the following members:
</p>
<p>
    The constructor should only initialize the fullyQualifiedTemplateName,
which is the name of the Template with the <strong>Assembly</strong>,<strong>Views folder</strong>, <strong>Controller Name</strong> and    <strong>View name</strong>.
</p>
<p>
    The ReadFile() method should extract all the text from the .html file with
    the <strong>given name</strong> if the <strong>file exists</strong>.
</p>
<ul>
    <li>
In case it <strong>does</strong> <strong>NOT</strong>        <strong>exist</strong>, throw a FileNotFoundException.
    </li>
</ul>
<p>
    The Render() method is <strong>overridden</strong> from the IRenderable
    interface, and should look like this:
</p>
<p>
    Now that we are ready with the View we can implement our Controller class.
</p>
<h2>
    8. Controller
</h2>
<p>
Every MVC Framework provides its consumers with a<strong>base controller functionality</strong> to    <strong>implement</strong>. Create a <strong>main</strong> Controller class
in the Controllers namespace, that would have<strong>several methods </strong>to help us<strong> Handle Requests</strong>. Every Controller class in our    <strong>application</strong> (for example HomeController, UsersController
    etc.) will inherit from the <strong>main </strong>Controller class. For
    now, there would be <strong>2 methods</strong> in the base controller
    class:
</p>
<p>
    · View() – would just generate the view for the method that called the
    View() method. We would use the
    <a
        href="https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute(v=vs.110).aspx"
    >
        CallerMemberNameAttribute
    </a>
    . For example, if method Index() in HomeController class call that View()
    method it would return &lt;assembly&gt;.Views.Home.Index.html.
</p>
<p>
    · RedirectToAction(redirectUrl) – would return a RedirectResult with the
    given <strong>URL</strong>.
</p>
<p>
    Here is how the class’s inner implementation should look:
</p>
<p>
    The View() method should be implemented like this:
</p>
<p>
    Hmm, but we see something foreign here – the ControllerUtilities class.
    Well, let’s implement it right away!
</p>
<h3>
    ControllerUtilities
</h3>
<p>
    Create a class called ControllerUtilities, in the Utilities namespace. This
    class will hold helpful methods for our Controller class’s inner
    functionality.
</p>
<p>
    And with this we are ready with the main components of our MVC Framework.
    Now it’s time to connect everything.
</p>
<h2>
    9. Controller Router
</h2>
<p>
    Create a class, named ControllerRouter in the Routers namespace. The class
    should <strong>implement</strong> the IHandleable interface from the
    WebServer project.
</p>
<p>
The main purpose of this class will be to transform the direct the<strong>incoming </strong>Request to its    <strong>corresponding handling</strong> Controller Action. That would be
    possible by following this algorithm:
</p>
<p>
    The <strong>class itself</strong> should look like this:
</p>
<h3>
    Request &amp; Mapping Examples
</h3>
<p>
    Here are some examples of how Actions should be mapped using the methods
    shown above.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="243" valign="top">
                <p align="center">
                    <strong>Request URL</strong>
                </p>
            </td>
            <td width="111" valign="top">
                <p align="center">
                    <strong>Controller</strong>
                </p>
            </td>
            <td width="117" valign="top">
                <p align="center">
                    <strong>Action</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    test.com/home/index
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    HomeController
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    Index
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    test.com/users/profile?id=2
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    UsersController
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    Profile
                </p>
            </td>
        </tr>
        <tr>
            <td width="243" valign="top">
                <p>
                    test.com/users<em></em>
                </p>
            </td>
            <td width="111" valign="top">
                <p>
                    <em>Invalid URL</em>
                </p>
            </td>
            <td width="117" valign="top">
                <p>
                    <em>Invalid URL</em>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Notice how we <strong>capitalize the first letter</strong> of the    <strong>controller name </strong>and the <strong>action</strong>. Also, we
    append Controller suffix to the <strong>controller name</strong>.
</p>
<h3>
    Retrieve Method
</h3>
<p>
To obtain the Controller Action we should create a method that<strong>extracts</strong> the<strong> </strong>Controller’s method,    <strong>corresponding</strong> to the Request, based on the Controller and
    or <strong>NULL</strong> if no such method is found.
</p>
<p>
    Because of the <strong>overloading</strong> of methods in one Controller
class, there might be <strong>several methods </strong>with the    <strong>same</strong> <strong>name,</strong> so we need to obtain all of
them. Then we need to <strong>iterate</strong> over<strong>every one</strong> of them and <strong>check</strong> if they are<strong>annotated</strong> with some HttpMethodAttribute. If the    <strong>method</strong> is <strong>not annotated</strong> with any
    HttpMethodAttribute and the request method is <strong>GET</strong> we
should <strong>return it</strong>. Otherwise we check if the<strong>attribute</strong> on the <strong>method</strong> is the    <strong>same</strong> as the Request’s <strong>method</strong>. If the
attribute of the method and the requested method are the same =&gt;    <strong>that’s our method</strong> and we should return it.
</p>
<p>
    The GetSuitableMethods() method <strong>extracts all methods</strong> from
    the <strong>requested </strong>Controller.
</p>
<p>
    The GetController() method dynamically creates an <strong>instance</strong>
of the <strong>requested </strong>Controller using the    <strong>full path</strong> to the Controller in the project.
</p>
<p>
    Notice how every method has a check and returns a <strong>NULL</strong> if
    the check <strong>fails</strong>. At the end in the Handle() method, we
will return a NotFound HttpResponse if even one of those<strong>checks fails</strong>. This is to <strong>ensure</strong> that the<strong>Client</strong> uses the correct routes. Later, we will    <strong>implement</strong> better <strong>error handling</strong>.<em></em>
</p>
<p>
    Data for <strong>POST</strong>/<strong>PUT</strong>/<strong>DELETE</strong>
    requests should be <strong>extracted directly</strong> through the
Request’s FormData / QueryData. Later, we will implement    <strong>data binding</strong> and <strong>models</strong>.
</p>
<h3>
    Requests and Actions Examples
</h3>
<p>
    Here are some examples of Requests, and their corresponding Actions.
</p>
<h4>
    Example #1
</h4>
<p>
    We have a page that should show the profile of a user by given id.
    <br/>
    <strong>Data</strong>
    should be <strong>extracted</strong> through the Request’s QueryData.
</p>
<ul>
    <li>
        <strong>Request</strong>
    </li>
</ul>
<p>
    o <strong>Method:</strong> GET
</p>
<p>
    o <strong>URL:</strong> test.com/users/profile?id=1
</p>
<p>
    o <strong>Content:</strong> (no content)
</p>
<ul>
    <li>
        <strong>Action Method signature</strong>
    </li>
</ul>
<p>
    o [HttpGet] public IActionResult Profile()
</p>
<h4>
    Example #2
</h4>
<p>
    We have a page that should register a new user to our application.
    <br/>
    <strong>Data</strong>
    should be <strong>extracted</strong> through the Request’s FormData.
</p>
<ul>
    <li>
        <strong>Request</strong>
    </li>
</ul>
<p>
    o <strong>Method:</strong> POST
</p>
<p>
    o <strong>URL:</strong> test.com/users/register
</p>
<p>
    o <strong>Content:</strong> User=John&amp;Password=123
</p>
<ul>
    <li>
        <strong>Action Method Signature</strong>
    </li>
</ul>
<p>
    [HttpPost] public IActionResult Register()
</p>
<h4>
    Example #3
</h4>
<p>
    Users in our application has capabilities to create notes and add them to
    their profile. A note is just a simple text.
    <br/>
    <strong>Data</strong>
    should be <strong>extracted</strong> through the Request’s FormData &amp;
    QueryData.
</p>
<ul>
    <li>
        <strong>Request</strong>
    </li>
</ul>
<p>
    o <strong>Method:</strong> POST
</p>
<p>
    o <strong>URL:</strong> test.com/users/AddNote?id=1
</p>
<p>
    o <strong>Content:</strong> Text=simple new note
</p>
<ul>
    <li>
        <strong>Action Method Signature</strong>
    </li>
</ul>
<p>
    [HttpPost] public IActionResult AddNote()
</p>
<h4>
    Invoke Action Method
</h4>
<p>
When we have extracted the <strong>method</strong>,    <strong>controller</strong>, <strong>action</strong> <strong>etc.</strong>,
    we should <strong>prepare</strong> the <strong>response</strong> and return
    it:
</p>
<p>
    Then what is left is to implement the PrepareResponse() method.
</p>
<h2>
    10. MVC Engine
</h2>
<p>
The Framework needs an Engine – a heart, a core, which would    <strong>run</strong> the <strong>main processes</strong>.
</p>
<p>
    Create a class, named MvcEngine, that would setup our MvcContext and run
    our WebServer.
</p>
<p>
    The register methods would setup the current executing assembly and the
file structure of our project (set the names of the<strong>Controllers</strong>, <strong>Views</strong> and    <strong>Models</strong> folders).
</p>
<p>
    Also, we need to set the current <strong>Assembly</strong>, so that we can
    access the folders in it. Careful which assembly you are assigning.
</p>
<h2>
    11. Application Start
</h2>
<p>
    It’s time to test our framework in an application. Create a Project
    SIS.Demo and rename the Program.cs class to Launcher.cs.
</p>
<p>
    In the Launcher class in the Main() method instantiate new server listening
    on some port with our ControllerRouter.
    <br/>
    Then run our MvcEngine class.
</p>
<h2>
    12. Test Our MVC Framework
</h2>
<p>
    Time to test our framework. To create a page using our MVC framework there
    are several things you need to do. For example, lets imagine we need to do
    simple home page with greeting message that would be located in Home
    controller and the name of the page will be Index.
</p>
<p>
    To create that page, we need to follow these steps and strictly following
    the name and folder order conventions for our classes
</p>
<p>
    1. In the SIS.App project, in the Controllers folder, create a class called
    HomeController that inherits base Controller class
</p>
<p>
    2. Inside of it create public method Index()
</p>
<p>
    3. In the Views folder create <strong>subfolder</strong> called Home and
    inside of it create class Index.html
</p>
<p>
    4. The Index.html should hold “&lt;h1&gt;Hello MVC!&lt;/h1&gt;”
</p>
<p>
    5. Run the application and in the browser, try to open your page at
    localhost:8000/Home/Index
</p>