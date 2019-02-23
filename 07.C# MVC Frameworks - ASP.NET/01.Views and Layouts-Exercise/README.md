<h1 align="center">
    Exercises: Razor Views &amp; Layouts
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
    CHUSHKA
</h1>
<p>
    <strong>CHUSHKA</strong>
(<strong>C</strong>entral <strong>H</strong>ierarchically-<strong>U</strong>niversal <strong>S</strong>ales <strong>H</strong>ost    <strong>K</strong>ickstarter <strong>A</strong>pplication) is a universal
    web application for selling products, like a web shop. You have been tasked
    to implement this application by the <strong>Codex Input / Output</strong>
    organization. There are several requirements you must follow in the
    implementation.
</p>
<h2>
    Technological Requirements
</h2>
<h2>
    The application should be an ASP.NET Core Web app.
</h2>
<h2>
    Database Requirements
</h2>
<p>
    The <strong>Database</strong> of the <strong>CHUSHKA</strong> application
    needs to support <strong>3 entities</strong>:
</p>
<h3>
    User
</h3>
<ul>
    <li>
        Has an Username
    </li>
    <li>
        Has a Password
    </li>
    <li>
        Has a Full Name
    </li>
    <li>
        Has an Email<strong></strong>
    </li>
    <li>
        Has an Role – can be one of the following values (“User”, “Admin”)
    </li>
</ul>
<h3>
    Product
</h3>
<ul>
    <li>
        Has an Id – a <strong>GUID</strong> string or <strong>integer</strong>.
    </li>
    <li>
        Has a Name
    </li>
</ul>
<p>
    · Has a Price – think of the right data type here
</p>
<ul>
    <li>
        Has a Description
    </li>
    <li>
        Has a Type – can be one of the following values (“Food”, “Domestic”,
        “Health”, “Cosmetic”, “Other”)
    </li>
</ul>
<h3>
    Order
</h3>
<ul>
    <li>
        Has an Id – a <strong>GUID</strong> string or <strong>integer</strong>.
    </li>
    <li>
        Has a Product – a Product
    </li>
    <li>
        Has a Client – an User
    </li>
    <li>
        Has an Ordered On – a DateTime
    </li>
</ul>
<p>
    Implement the entities with the <strong>correct datatypes</strong>. Think
    of the relationships between data models.
</p>
<h2>
    Template Requirements
</h2>
<h3>
    Guest Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Guests (    <strong>logged out</strong> users).
</p>
<h4>
    Index Template
</h4>
<h4>
    Login Template
</h4>
<h4>
    Register Template
</h4>
<h3>
    User Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Users (    <strong>logged in</strong> users with Role - User).
</p>
<h4>
    Index Template (logged-in users)
</h4>
<p>
    <strong>NOTE</strong>
    : Products on this page have their description substringed to the 50th
    symbol, and then accompanied by 3 dots “…”
</p>
<h4>
    Product Details Template (logged-in users)
</h4>
<h3>
    Admin Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Admins (    <strong>logged in</strong> users with Role - Admin).
</p>
<h4>
    Index Template (logged-in admin)
</h4>
<p>
    <strong>NOTE</strong>
    : Products on this page have their description substringed to the 50th
    symbol, and then accompanied by 3 dots “…”
</p>
<h4>
    Product Details Admin Template (logged-in admin)
</h4>
<h4>
    Product Create Template (logged-in admin)
</h4>
<h4>
    Product Edit Template (logged-in admin)
</h4>
<h4>
    Product Delete Template (logged-in admin)
</h4>
<h4>
    All Orders Template (logged-in admin)
</h4>
<p>
    Some of the templates have been given to you in the application skeleton,
    but the others will be for you to implement, so make sure you implement
    them correctly. You can use the given ones as helpers.
</p>
<p>
    <strong>NOTE</strong>
    : The templates should look <strong>EXACTLY</strong> as shown above.
</p>
<p>
    <strong>NOTE</strong>
: The templates do <strong>NOT</strong> <strong>require</strong><strong>additional</strong> <strong>CSS</strong>. Only    <strong>bootstrap</strong> and the <strong>given css</strong> are enough.
</p>
<h2>
    Functional Requirements
</h2>
<p>
The Functionality Requirements describe the functionality that the    <strong>Application</strong> must support.
</p>
<p>
    The <strong>application</strong> should provide Guest (not logged-in) users
    with the functionality to login, register and <strong>view</strong> the
    Index page.
</p>
<p>
    The <strong>application</strong> should provide Users (logged-in) with the
    functionality to logout, and view all products, and <strong>order</strong>
    a Product (clicking on the [Order] button on the Product Details page).
</p>
<p>
    The <strong>application</strong> should provide Admins (logged-in) with the
    functionality to logout, and view all products, <strong>order</strong> a
    Product, <strong>create</strong> a Product, <strong>edit </strong>a
    Product,<strong> delete</strong> a Product, and <strong>view</strong> all
    Orders.
</p>
<h4>
    Users
</h4>
<p>
When you register a new User, it should be assigned with a    <strong>role</strong> – User.
</p>
<p>
    Make the <strong>first registered</strong> user – an <strong>Admin</strong>
    .
</p>
<h4>
    Products
</h4>
<p>
    Upon clicking on the <strong>rectangular object</strong> holding the data
    about a certain product, you should be redirected to its Details page.
</p>
<p>
    <strong>NOTE</strong>
    : Admins can Edit and Delete products on that page.
</p>
<p>
Upon <strong>ordering</strong> a Product, an Order should be    <strong>created</strong> and <strong>persisted</strong>.
</p>
<p>
The <strong>application</strong> should <strong>store</strong> its    <strong>data</strong> using Entity Framework Core.
</p>
<h2>
    Security Requirements
</h2>
<p>
    The Security Requirements are mainly access requirements. Configurations
    about which users can access specific functionalities and pages.
</p>
<ul>
    <li>
        Guest (not logged in) users can access Index page and functionality.
    </li>
    <li>
        Guest (not logged in) users can access Login page and functionality.
    </li>
    <li>
        Guest (not logged in) users can access Register page and functionality.
    </li>
    <li>
        Users (logged in) can access User LoggedIn Index page and
        functionality.
    </li>
    <li>
        Users (logged in) can access User Product Details page and
        functionality.
    </li>
    <li>
        Users (logged in) can access the Order Product functionality.
    </li>
    <li>
        Users (logged in) can access Logout functionality.
    </li>
    <li>
Admins (logged in) can access <strong>every functionality</strong> a        <strong>normal</strong> logged in User can.
    </li>
    <li>
        Admins (logged in) can access Admin LoggedIn Index page and
        functionality.
    </li>
    <li>
        Admins (logged in) can access the Admin Product Details page and
        functionality.
    </li>
    <li>
        Admins (logged in) can access the Product Create page and
        functionality.
    </li>
    <li>
        Admins (logged in) can access the Product Edit page and functionality.
    </li>
    <li>
        Admins (logged in) can access the Product Delete page and
        functionality.
    </li>
    <li>
        Admins (logged in) can access the All Orders page and functionality.
    </li>
</ul>
<p>
    <strong>TIP:</strong>
    Add this code in Startup.cs to disable confirming email address of user:
</p>
<p>
    services.Configure&lt;IdentityOptions&gt;(options =&gt;
</p>
<p>
    {
</p>
<p>
    options.SignIn.RequireConfirmedEmail = false;
</p>
<p>
    });
</p>
<p>
    <strong>TIP:</strong>
    Add this code (remove the old one) in Startup.cs to enabling using Roles:
</p>
<p>
    services.AddIdentity&lt;IdentityUser, IdentityRole&gt;()
</p>
<p>
    .AddDefaultUI()
</p>
<p>
    .AddDefaultTokenProviders()
</p>
<p>
    .AddEntityFrameworkStores&lt;EventuresDbContext&gt;();
</p>
<p>
    <strong>TIP:</strong>
    Change the code in <strong>Register.cshtml.cs</strong> to match the
    requirements and <strong>add Role to newly created User</strong>.
</p>