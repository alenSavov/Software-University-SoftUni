<h1 align="center">
    C# Web Development Basics – Retake Exam
</h1>
<h1 align="center">
    Mish-Mash
</h1>
<p>
    <strong>Mish-Mash</strong>
    is a web application for media channels, like YouTube, with the difference
    that everything is mashed up like Mish-Mash. You have been tasked to
    implement this application by the Indiaver organization. There are several
    requirements you must follow in the implementation.
</p>
<p>
    The application has been developed to somewhere. The previous developer was
    not able to implement a lot of the main functionality, but he implemented
    the guest functionality – <strong>Login</strong>, <strong>Register</strong>
    , <strong>Logout</strong> etc. The other functionalities are up to you. He
    also broke some of the Framework’s main modules: Javache, Broccolina,
    Summer, for unknown reasons…
</p>
<p>
    Below, you will see, how the application should behave, if implemented
    correctly. You should also fix It, so that it is implemented correctly.
</p>
<h2>
    1. Technological Requirements
</h2>
<ul>
    <li>
        Use the Web Server
    </li>
    <li>
        Use the MVC Framework
    </li>
    <li>
        Use Entity Framework
    </li>
</ul>
<p>
The Technological Requirements are <strong>ABSOLUTE</strong>. If you    <strong>do not follow</strong> them, you will <strong>NOT</strong> be
    scored for other Requirements.
</p>
<p>
    Now that you know the Technological Requirements, let us see what are the
    Functional Requirements.
</p>
<h2>
    2. Database Requirements
</h2>
<p>
The <strong>Database</strong> of the Mish-Mash application needs to support    <strong>2 entities</strong>:
</p>
<h3>
    User
</h3>
<ul>
    <li>
        Has an Id – a UUID String or an <strong>Integer</strong>.
    </li>
    <li>
        Has an Username
    </li>
    <li>
        Has a Password
    </li>
    <li>
        Has an Email<strong></strong>
    </li>
</ul>
<p>
    · Has Followed Channels – a collection of Channels.<strong></strong>
</p>
<p>
    · Has an Role – can be one of the following values (“User”, “Admin”)
</p>
<h3>
    Channel
</h3>
<ul>
    <li>
        Has an Id – a UUID String or an <strong>Integer</strong>.
    </li>
    <li>
        Has a Name
    </li>
    <li>
        Has a Description
    </li>
</ul>
<p>
    · Has a Type – can be one of the following values (“Game”, “Motivation”,
    “Lessons”, “Radio”, “Other”).
</p>
<p>
    · Has Tags – a collection of <strong>Strings</strong>.
</p>
<p>
    · Has Followers – a collection of Users.
</p>
<p>
    Implement the entities with the <strong>correct datatypes</strong>.
</p>
<h2>
    3. Template Requirements
</h2>
<h3>
    Guest Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Guests (    <strong>logged out</strong> users).
</p>
<h4>
    Index Template (route = “/home/index”) (logged out user)
</h4>
<h4>
    Login Template (route = “/users/login”) (logged out user)
</h4>
<h4>
    Register Template (route = “/users/register”) (logged out user)
</h4>
<h3>
    User Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Users (    <strong>logged in</strong> users with Role - User).
</p>
<h4>
    LoggedIn Index Template (route=”/home/index”) (logged in user)
</h4>
<p>
    <strong>NOTE</strong>
    : As you can see the <strong>elements</strong> are <strong>aligned</strong>
    to the <strong>left</strong>, <strong>regardless of their count</strong>.
The <strong>maximum count</strong> is <strong>5 per</strong>    <strong>row</strong>, however they are <strong>always aligned</strong> to
    the <strong>left</strong>.
</p>
<h5>
    First
</h5>
<h5>
    Second
</h5>
<h5>
    Third
</h5>
<h4>
    Channel Details Template (route=”/channels/details/{id}”) (logged in user)
</h4>
<h4>
    My Channels Template (route=”/channels/followed”) (logged in user)
</h4>
<h3>
    Admin Templates
</h3>
<p>
These are the <strong>templates</strong> and<strong>functionalities</strong>, accessible by Admins (    <strong>logged in</strong> users with Role - Admin).
</p>
<h4>
    Admin Index Template (route=”/home/index”) (logged in admin)
</h4>
<p>
    <strong>NOTE</strong>
    : As you can see the <strong>elements</strong> are <strong>aligned</strong>
    to the <strong>left</strong>, <strong>regardless of their count</strong>.
The <strong>maximum count</strong> is <strong>5 per</strong>    <strong>row</strong>, however they are <strong>always aligned</strong> to
    the <strong>left</strong>.
</p>
<h5>
    First
</h5>
<h5>
    Second
</h5>
<h5>
    Third
</h5>
<h4>
    Channel Create Admin Template (route=”/channels/create”) (logged in admin)
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
: The templates do <strong>NOT</strong> <strong>require</strong><strong>additional</strong> <strong>CSS</strong>. Only    <strong>bootstrap</strong> is enough.
</p>
<h2>
    4. Functional Requirements
</h2>
<p>
The Functionality Requirements describe the functionality that the    <strong>Application</strong> must support.
</p>
<p>
    The <strong>application</strong> should provide Guest (not logged in) users
    with the functionality to login, register and <strong>view</strong> the
    Index page.
</p>
<p>
    The <strong>application</strong> should provide Users (logged in) with the
functionality to logout, and view all channels, and<strong>follow / unfollow</strong> a Channel, and    <strong>view details</strong> about a Channel.
</p>
<p>
    The <strong>application</strong> should provide Admins (logged in, with
role - Admin) with the functionality to logout, and view all channels, and<strong>follow / unfollow</strong> a Channel, and    <strong>view details</strong> about a Channel, <strong>create</strong> a
    Channel.
</p>
<p>
When you register a new User, it should be assigned with a    <strong>role</strong> – User.
</p>
<h3>
    Users
</h3>
<p>
    Users can <strong>follow</strong> or <strong>unfollow</strong> Channels. If
    a Channel is <strong>NOT followed</strong>, it should be represented on the
    Index page as a rectangular element, which holds <strong>2 buttons</strong>
    at its bottom – [Follow] and [Details].
</p>
<p>
    · Upon clicking the [Follow] button, the Channel should be added to the
    Followed Channels of the <strong>current user</strong>.
</p>
<p>
    · Upon clicking the [Details] button, the <strong>current user</strong>
    should be <strong>redirected</strong> to the Channel’s Details Page.
</p>
<p>
    If a Channel is <strong>followed</strong>, it should be represented on the
Index page as a rectangular element, which holds<strong>a simple text </strong>at its bottom – “Following”, with no    <strong>functionality</strong> behind it.
</p>
<h3>
    Channels
</h3>
<p>
    There are <strong>3 sections</strong> on the Index page:
</p>
<ul>
    <li>
        Your Channels
    </li>
    <li>
        Suggested
    </li>
    <li>
        See Other
    </li>
</ul>
<p>
    The Your Channels section holds all of the current user’s Followed
    Channels. If there are <strong>no such</strong> Channels, it should just be
    left empty.
</p>
<p>
The Suggested section holds any Channels, which have at least<strong>1 common tag</strong> with <strong>one</strong> of the    <strong>current user’s</strong> Followed Channels.
</p>
<p>
The See Other section holds all Channels, which are    <strong>NOT included</strong> in the Your Channels and Suggested sections.
</p>
<h2>
    5. Security Requirements
</h2>
<p>
    The Security Requirements are mainly access requirements. Configurations
    about which users can access specific functionalities and pages.
</p>
<p>
    · Guest (not logged in) users can access Index page and functionality.
</p>
<p>
    · Guest (not logged in) users can access Login page and functionality.
</p>
<p>
    · Guest (not logged in) users can access Register page and functionality.
</p>
<p>
    · Users (logged in) can access User LoggedIn Index page and functionality.
</p>
<p>
    · Users (logged in) can access User Channel Details page and functionality.
</p>
<p>
    · Users (logged in) can access the My Channels functionality.
</p>
<p>
    · Users (logged in) can access the Channel Follow functionality.
</p>
<p>
    · Users (logged in) can access the Channel Unfollow functionality.
</p>
<p>
    · Users (logged in) can access Logout functionality.
</p>
<p>
· Admins (logged in) can access <strong>every functionality</strong> a    <strong>normal</strong> logged in User can.
</p>
<p>
    · Admins (logged in) can access Admin LoggedIn Index page and
    functionality.
</p>
<p>
    · Admins (logged in) can access the Channel Create page and functionality.
</p>
<h2>
    6. Scoring
</h2>
<p>
    This section describes how the scoring of the Exam Preparation will be
    made.
</p>
<h3>
    Database Requirements – 10 points.
</h3>
<h3>
    Template Requirements – 35 points.
</h3>
<h3>
    Functional Requirements – 45 points.
</h3>
<h3>
    Security Requirements – 10 points.
</h3>