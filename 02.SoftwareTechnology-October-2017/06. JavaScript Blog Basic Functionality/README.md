<h1>
    Blog: JavaScript and MongoDB
</h1>
<p>
This document defines a complete walkthrough of creating a<strong>Blog</strong> application with the    <a href="http://expressjs.com/">Express.js</a> Framework, from setting up
    the framework through <a href="http://passportjs.org/">authentication</a>
module, ending up with creating a <strong>CRUD</strong> around<a href="https://www.mongodb.com/">MongoDB</a> entities using    <a href="http://mongoosejs.com/">Mongoose</a> object-document model module.
</p>
<p>
    Make sure you have already gone through the
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/08.%20Software-Technologies-JavaScript-Blog-Basic-Functionality/08.%20Software-Technologies-JS-Blog-Getting-Started-Lab.docx"
    >
        Getting Started: JavaScript
    </a>
guide. In this guide we will be using:<a href="https://www.jetbrains.com/webstorm/">WebStorm</a> and    <a href="https://robomongo.org/">RoboMongo</a> GUI. The rest of the needed
    non-optional software is described in the guide above.
</p>
<p>
    <strong>
        Chapters from I to III are for advanced users, but is recommended to be
        read. There’s a
    </strong>
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/08.%20Software-Technologies-JavaScript-Blog-Basic-Functionality/08.%20Software-Technologies-JavaScript-Blog-Basic-Functionality-Skeleton.zip"
    >
        <strong>skeleton</strong>
    </a>
    <strong> which you can use and start from chapter IV. </strong>
</p>
<h1>
    I. Set Up Node.js Express Project
</h1>
<p>
    <strong>WebStorm</strong>
    comes directly with project structure plus we don’t need to download any
    plugins in order to develop our Node.js/Express.js application
</p>
<h2>
    1. Create the Project from your IDE
</h2>
<p>
    Once you have installed the plugins and started the <strong>IDE</strong>,
    you will have in the <strong>Create Project</strong> context menu either a
“Node.js and NPM<strong>”</strong> -&gt; “Node.js Express app” (    <strong>IntelliJ</strong> with <strong>Node.js plugin</strong>) or directly
    a “<strong>Node.js Express app”</strong> one (<strong>WebStorm</strong>)
</p>
<p>
Make sure that you have    <a href="https://nodejs.org/en/">Node interpreter</a> installed and the
    chosen directory is the right one.
</p>
<ul>
    <li>
Also, choose the <a href="http://handlebarsjs.com/">Handlebars</a>        <strong>Template</strong>.
    </li>
    <li>
The recommended Express <strong>versions</strong> are any above        <strong>4.0.0</strong>
    </li>
</ul>
<h2>
    <a name="_Create_a_Database"></a>
    2. Create a Database
</h2>
<p>
    It’s time to create the database, which your app will use. We have two
    possible approaches here. Choose whichever one you prefer:
</p>
<h3>
    Using the GUI
</h3>
<p>
    Open <strong>RoboMongo</strong>, connect to the default instance (with
    port: <strong>27017</strong>) and create a database named “blog”.
</p>
<h3>
    Using the Command Line
</h3>
<p>
    Or if you want to do it using the <strong>command line</strong> use the
    following commands:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="372" valign="top">
                <p>
                    mongo
                </p>
                <p>
                    use blog
                </p>
                <p>
                    db.users.insert({"email": "test@gmail.com"})
                </p>
                <p>
                    db.users.find({})
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong> </strong>
</p>
<p>
    <strong>Note</strong>
that in order to use command line you should have all    <strong>environment variables</strong> set or if not, you should run the
command line from the place where <strong>mongod.exe</strong> is (“    <a href="file:///C:/Program">C:\Program</a> Files\MongoDB\Server\3.0\bin” -
    the version after server <strong>might</strong> be different – instead of
3.0 to 3.2, but the path is relatively the same). Also you should your<strong>MongoDB</strong> connection <strong>open</strong> (“    <strong>mongod –dbpath D:\example\path</strong>” command).
</p>
<p>
    Once you set up your database, it’s time to get to work on the layout.
</p>
<h2>
    3. Setup Layout
</h2>
<p>
We will need a base layout for all of our templates. As we are using    <strong>Bootstrap</strong>, we will need its css included in all pages, and
the related scripts too. We can download the sample    <strong>blog design skeleton</strong> from
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Software-Technologies-Oct-2016/03.%20PHP-Blog-Basic-Functionality/blog%20design.zip"
    >
        here
    </a>
    , where part of our <strong>JavaScript</strong> and <strong>CSS</strong> is
    included. In addition, we will need
</p>
<ul>
    <li>
        <a href="http://www.malot.fr/bootstrap-datetimepicker/">
            Bootstrap Date Time picker
        </a>
        for choosing dates in our forms
    </li>
    <li>
        <a href="http://momentjs.com/">Moment JS</a>
        for validating dates
    </li>
</ul>
<p>
    All of our styles and scripts we need to include to our project. We should
    add stylesheets into the <strong>public/stylesheets </strong>and our public
    scripts in <strong>public/JavaScript</strong>. We will add the above two
    libraries when we need them:
</p>
<p>
    Then we need to use this styles and script setting up a base layout in
    views/layout.hbs.
</p>
<p>
    Setup a base layout as you wish or use the following one:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566">
                <p>
                    &lt;!DOCTYPE <strong>html</strong>&gt;
                </p>
                <p>
                    &lt;<strong>html</strong>&gt;
                </p>
                <p>
                    &lt;<strong>head</strong>&gt;
                </p>
                <p>
&lt;<strong>title</strong>&gt;SoftUni Blog&lt;/                    <strong>title</strong>&gt;
                </p>
                <p>
&lt;<strong>link </strong><strong>rel=</strong><strong>'stylesheet' </strong><strong>href=</strong>                    <strong>'/stylesheets/style.css' </strong>/&gt;
                </p>
                <p>
&lt;<strong>script </strong><strong>src=</strong><strong>"/JavaScripts/jquery-1.10.2.js"</strong>&gt;&lt;/                    <strong>script</strong>&gt;
                </p>
                <p>
&lt;<strong>script </strong><strong>src=</strong><strong>"/JavaScripts/bootstrap.js"</strong>&gt;&lt;/                    <strong>script</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>head</strong>&gt;
                </p>
                <p>
                    &lt;<strong>body</strong>&gt;
                </p>
                <p>
                    &lt;<strong>header</strong>&gt;
                </p>
                <p>
                    &lt;<strong>div </strong><strong>class=</strong>
                    <strong>
                        "navbar navbar-default navbar-fixed-top text-uppercase"
                    </strong>
                    &gt;
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container"</strong>&gt;
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"navbar-header"</strong>&gt;
                </p>
                <p>
&lt;<strong>a </strong><strong>href=</strong><strong>"/" </strong><strong>class=</strong><strong>"navbar-brand"</strong>&gt;SoftUni Blog&lt;/                    <strong>a</strong>&gt;
                </p>
                <p>
&lt;<strong>button </strong><strong>type=</strong><strong>"button" </strong><strong>class=</strong><strong>"navbar-toggle" </strong><strong>data-toggle=</strong><strong>"collapse" </strong><strong>data-target=</strong>                    <strong>".navbar-collapse"</strong>&gt;
                </p>
                <p>
&lt;<strong>span </strong><strong>class=</strong>                    <strong>"icon-bar"</strong>&gt;&lt;/<strong>span</strong>
                    &gt;
                </p>
                <p>
&lt;<strong>span </strong><strong>class=</strong>                    <strong>"icon-bar"</strong>&gt;&lt;/<strong>span</strong>
                    &gt;
                </p>
                <p>
&lt;<strong>span </strong><strong>class=</strong>                    <strong>"icon-bar"</strong>&gt;&lt;/<strong>span</strong>
                    &gt;
                </p>
                <p>
                    &lt;/<strong>button</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    {{#<strong>if user</strong>}}
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"navbar-collapse collapse"</strong>&gt;
                </p>
                <p>
&lt;<strong>ul </strong><strong>class=</strong>                    <strong>"nav navbar-nav navbar-right"</strong>&gt;
                </p>
                <p>
&lt;<strong>li</strong>&gt;&lt;<strong>a </strong>                    <strong>href=</strong><strong>"/user/details"</strong>
                    &gt;Welcome({{<strong>user</strong>.<strong>email</strong>
                    }})&lt;/<strong>a</strong>&gt;&lt;/<strong>li</strong>&gt;
                </p>
                <p>
&lt;<strong>li</strong>&gt;&lt;<strong>a </strong>                    <strong>href=</strong><strong>"/article/create"</strong>
&gt;New Article&lt;/<strong>a</strong>&gt;&lt;/                    <strong>li</strong>&gt;
                </p>
                <pre>             <strong>&lt;</strong><strong>li</strong><strong>&gt;</strong>&lt;<strong>a </strong><strong>href=</strong><strong>"/</strong><strong>user</strong><strong>/</strong><strong>logout</strong><strong>"</strong>&gt;Logout&lt;/<strong>a</strong>&gt;&lt;/<strong>li</strong>&gt;<strong></strong></pre>
                <p>
                    &lt;/<strong>ul</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    {{/<strong>if</strong>}}
                </p>
                <p>
                    {{#<strong>unless user</strong>}}
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"navbar-collapse collapse"</strong>&gt;
                </p>
                <p>
&lt;<strong>ul </strong><strong>class=</strong>                    <strong>"nav navbar-nav navbar-right"</strong>&gt;
                </p>
                <p>
&lt;<strong>li</strong>&gt;&lt;<strong>a </strong>                    <strong>href=</strong><strong>"/user/register"</strong>
&gt;Register&lt;/<strong>a</strong>&gt;&lt;/                    <strong>li</strong>&gt;
                </p>
                <p>
&lt;<strong>li</strong>&gt;&lt;<strong>a </strong>                    <strong>href=</strong><strong>"/user/login"</strong>
&gt;Login&lt;/<strong>a</strong>&gt;&lt;/                    <strong>li</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>ul</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    {{/<strong>unless</strong>}}
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>header</strong>&gt;
                </p>
                <p>
                    {{{<strong>body</strong>}}}
                </p>
                <p>
                    &lt;/<strong>body</strong>&gt;
                </p>
                <p>
                    &lt;<strong>footer</strong>&gt;
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container modal-footer"</strong>&gt;
                </p>
                <p>
                    &lt;<strong>p</strong>&gt;<strong>&amp;copy;</strong> 2016
                    - Software University Foundation&lt;/<strong>p</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>footer</strong>&gt;
                </p>
                <p>
                    &lt;/<strong>html</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h1>
    II. Node.js Express App Base Project Overview
</h1>
<p>
Node.js is a <strong>platform</strong> written in    <strong>JavaScript</strong> and provides <strong>back-end</strong>
    functionality. Express is a <strong>module </strong>(for now we can
    associate module as a <strong>class</strong> which provides some
    functionality) which wraps Node.js in way that makes coding faster and
    easier and it is suitable for <strong>MVC</strong> architecture.
</p>
<p>
    Initially the project comes with the following structure:
</p>
<p>
    We can see several folders here. Let look at them one by one and see what
    are they for:
</p>
<ul>
    <li>
        <strong>bin – </strong>
        contains single file named <strong>www</strong>, which is the starting
        point of our program. The file itself contains some configuration logic
needed in order to run the server <strong>locally</strong>.        <strong></strong>
    </li>
    <li>
        <strong>node_modules</strong>
        (library root) – as far as the name tells in this folder we put every
library (<strong>module</strong>) that our project depends on.        <strong></strong>
    </li>
    <li>
        <strong>public</strong>
        – here comes the interesting part. Everything that is in our public
        folder (files, images etc.) will be accessible by every user. We cover
        on that later.<strong></strong>
    </li>
    <li>
        <strong>routes – </strong>
        folder in which we will put our routes configurations. To make things
        clear: routes are responsible for distributing the work in our project
        (e.g. when user tries to get on "
        <a href="http://www.oursite.com/user/login">
            www.oursite.com/user/login
        </a>
        " to call the specific controller or module that is responsible for
        displaying login information)
    </li>
    <li>
        <strong>views – </strong>
like in the previous blog (PHP) we again have folder named        <strong>views</strong>. There we will store the views for our model.
Again, we will use templates with the help of the        <strong>Handlebars</strong> view engine.
    </li>
    <li>
        <strong>app.js</strong>
        – the script containing our server logic.
    </li>
    <li>
        <strong>package.json</strong>
– file containing project information (like project's        <strong>name</strong>, <strong>license</strong> etc.). The most
        important thing is that there is a "<strong>dependencies</strong>" part
        in which are all names and versions of every module that our projects
        uses.
    </li>
</ul>
<h1>
    III. User Authentication
</h1>
<p>
    We have to implement the user’s authentication by ourselves. Hopefully we
    will use some security modules to help us with that. But first let's start
    with our User entity.
</p>
<h2>
    4. Create the User Entity
</h2>
<p>
    Our users should be stored in the database (<strong>MongoDB</strong>). This
means we need <strong>U</strong>sers collection.<strong>Collections</strong> are represented as an array    <a href="http://www.w3schools.com/js/js_json_intro.asp">JSON</a> objects.
In Mongo, these objects are called <strong>Documents</strong>.    <strong></strong>
</p>
<p>
    Let’s define rules for a user:
</p>
<p>
    · Should have a unique login name, let’s say email
</p>
<p>
    · Should have a passwordHash (which we will won't save in it's pure view)
</p>
<p>
    · Should have a full name, let’s say fullName
</p>
<p>
    We won’t be using pure MongoDB. We will use Mongoose. Mongoose is a module
    that will make creating and manipulating collections easier. As a starter,
    create folder named "models". There create "User.js" file. In this file we
    will put our logic for the User collection (entity).
</p>
<p>
First we are going to require the "mongoose" module. Then we will create a    <a href="http://mongoosejs.com/docs/guide.html">schema</a> (look on the
    schema as a class in which we say what our objects will have). The schema
    will contain information about what the user will have (properties,
    functions and so on...).
</p>
<p>
    JavaScript is a dynamically typed language. The type of our variables is
    defined when the project is run. It’s called JIT (or Just In Time
    compilation). This is why this language is slow compared to C++ and even
    C#/Java. We have several keywords to declare and initialize a variable
    (var, let and const – and do not use var – just don’t). Use const when you
    create a constant value and let for any other uses.
</p>
<p>
    The above command “require” will look into our libraries and will try to
    find a module with name: “mongoose” (it’s like calling using System in C#
    but instead of typing it on top of the file, we just assign it as a
    variable, in order to use the functionality in the module). Whenever we add
    a new module, it is a must to add it as a <strong>dependency</strong> in
    our <strong>package.json </strong>file. The <strong>IDE</strong> is smart
    and can do it automatically. “<strong>Alt + Enter</strong>“ – it’s like
    calling “<strong>Ctrl + .</strong>” in Visual Studio.
</p>
<p>
    Let’s create our user schema:
</p>
<p>
    Unfortunately, when we use “let” it gets highlighted in red. This is
    because we have to switch our JavaScript version to ECMAScript 6. Press
    [Alt + Enter] to popup the helper, then click [Enter] and everything should
    be fine.
</p>
<p>
    Here is what our Schema should look like. We create schema by using that
    mongoose module we already imported. The Schema function accepts a
    JavaScript
    <a
        href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Data_structures"
    >
        object
    </a>
    . In plain words the above means: we will create a schema where every
    entity will have:
</p>
<ul>
    <li>
        email
    </li>
    <li>
        passwordHash
    </li>
    <li>
        fullName
    </li>
</ul>
<p>
    · salt (will explain it later)
</p>
<p>
    They all have the String type and they are all required. For more info on
types in JavaScript read this    <a href="http://www.w3schools.com/js/js_datatypes.asp">article</a>.
</p>
<p>
    To finalize creating the <strong>User</strong> collection, there are two
things left to do: create and export a model. A model is just a<strong>wrapper</strong> of our <strong>schema</strong>. It lets us make<strong>queries</strong> to the <strong>database</strong> directly and even<strong>create</strong>, <strong>update</strong> and    <strong>delete</strong> <strong>documents</strong> from our collection. It
    should look like this:
</p>
<p>
Creating the model is easy: just call “mongoose.model” and pass the<strong>model’s name</strong> as the <strong>first</strong>    <strong>argument</strong>, and then the <strong>schema</strong> that the
    model will be using. In order to export that model as a module, simply
    write that “module.exports” assignment. This means that every time someone
    requires our “User.js” file he will get the User model.
</p>
<h2>
    5. Create Connection with MongoDB
</h2>
<p>
    Before we start setting up our connection with database let’s create a
    config.js file in our config folder (configception). There, we will store
information about our <strong>project root folder</strong> and a<strong>connection string</strong>, which is needed to connect with our    <strong>database</strong> (MongoDB).
</p>
<p>
The idea behind creating a <strong>config file</strong> is to get our    <strong>configuration variables</strong> from a separate place where they
    can <strong>easily be changed</strong>. Let's say that we’ll have two
different configuration environments: <strong>production</strong> and    <strong>development</strong>.
</p>
<p>
    The two things that we will need for now are the rootFolder and the
connectionString. The rootFolder can be used when we need to<strong>declare the path</strong> to some of the project's<strong>dependencies</strong>. As for the    <strong>connection string</strong>, the mongoose module will require it so
    it can save the changes we made to our documents.
</p>
<p>
Let’s move onto creating the connection itself. We need to create a “    <strong>database.js</strong>” file in our <strong>config</strong> folder.
    It should look something like this:
</p>
<p>
Now go back in the <strong>app.js</strong> file and require that<strong>config</strong> module. Also, make sure that the code in    <strong>database.js</strong> is also called:
</p>
<p>
    The project structure should something like this:
</p>
<h2>
    <a name="__DdeLink__3351_1053218692"></a>
    <a name="__DdeLink__3352_1053218692"></a>
    6. Set Up the Security Configuration
</h2>
<p>
We have our model ready. Now we need to create some    <strong>security configuration</strong>.
</p>
<p>
    First, create a folder named “<strong>utilities</strong>”. Inside of it,
    create a file named: “encryption.js“. There will be our logic for
    generating
    <a
        href="https://www.addedbytes.com/blog/why-you-should-always-salt-your-hashes/"
    >
        salt
    </a>
    and <strong>hashing</strong> our <strong>password</strong>. So, we’ll
    create two <strong>functions</strong> and make them <strong>public</strong>
    so they can be useful.
</p>
<p>
    First, we will need some helper module (“crypto”). In order to make the
functionality visible to the <strong>outer world</strong>, we will<strong>export</strong> an <strong>object</strong> which will have    <strong>two properties</strong> which are
    <a href="https://cdn.meme.am/cache/instances/folder522/500x/63119522.jpg">
        JavaScript
    </a>
    <strong>functions</strong>
    .
</p>
<p>
    Next, let’s define the two functions (generateSalt and hashPassword) inside
    the module.exports statement:
</p>
<p>
    Next, let’s fill in the relevant functionality for each function:
</p>
<p>
The<strong> salt</strong> will be generated by creating an    <strong>array</strong> of <strong>128 random bytes</strong>, which are
later going to be converted to their    <a href="https://en.wikipedia.org/wiki/Base64">base64</a> presentation. For
our hashing logic, we use the    <a href="http://www.xorbin.com/tools/sha256-hash-calculator">SHA256</a>
    hashing algorithm.
</p>
<p>
Create an “<strong>express.js</strong>” file in the “<strong>config</strong>” folder. We will put some<strong>setup logic</strong> inside it. Simply copy the “    <strong>app.js</strong>” file and <strong>remove</strong> some of the code
    there and add the authentication modules – it should look like this:
</p>
<p>
    Let’s talk about the modules we are using:
</p>
<p>
    · express – wraps functionality that the <strong>Node.js</strong> platform
    provides while making coding easier and faster. Look at the example with
    “express.static”. What it does is to take the provided file path (which is
    resulted by using the module below) <strong>static</strong>. This means
that absolutely every file in that path is visible to    <strong>anybody </strong>on our server (no-restrictions).
</p>
<p>
    · path – supply utility functions for joining file paths (relative or
    absolute – doesn’t matter) or any tools needed around when using file
    paths.
</p>
<p>
· cookie-parser – cookies contain <strong>encrypted data</strong> about the<strong>current user</strong> and they are<strong>sent on every request</strong>. With this module, we enable    <strong>working with cookies</strong>.
</p>
<p>
    · body-parser – parses data from the request’s body and making it
    accessible by simply mapping that data as a object with different
properties. See the    <a href="https://github.com/expressjs/body-parser">documentation</a>.
</p>
<p>
· express-session – server-side <strong>storage</strong>. With that “    <strong>secret</strong>” string, we can differentiate cookies from one
    another (by setting an ID to every cookie). It also keeps information about
the <strong>current user’s</strong> <strong>connection</strong>.    <strong>Only for development uses</strong>.
</p>
<ul>
    <li>
passport – <strong>security module</strong> that uses the<strong>session</strong> to        <strong>save information about the user</strong>. It requires a saving
strategy (“<strong>Facebook</strong>”, “<strong>Google</strong>”, “        <strong>Local</strong>”, etc.) and tells us which data from the user
we’re going to put in the <strong>cookie</strong>. It binds        <strong>two functions</strong>: logIn and logOut.
    </li>
</ul>
<p>
Now let’s create a “<strong>passport.js</strong>” file in the “    <strong>config</strong>” folder in and choose an authentication strategy
    for our login:
</p>
<p>
As you see, we have declared a function to authenticate a user by their    <strong>username</strong> and <strong>password</strong>. This means that
    first, the <strong>username</strong> should exist in the database and
second - the given <strong>password</strong> should be<strong>equal</strong> to the one in the <strong>database</strong> (    <strong>hashed</strong> of course).
</p>
<p>
    Additionally, our function receives a <strong>third argument</strong>
called “<strong>done</strong>” – another function which will be invoked    <strong>inside</strong> the current function.
</p>
<p>
    The logic behind that is to pass any <strong>errors</strong> (if any have
occurred) as the <strong>first argument</strong> and    <strong>the user</strong> as the <strong>second argument</strong>. If we
    can’t authenticate the user, we return the errors in the first argument,
and if we can, we just pass <strong>null</strong>. Otherwise, we return the    <strong>user</strong>. This logic is needed to implement the Passport Login
    strategy. In this project, we will use “<strong>Local Passport</strong>”
    strategy. This means that the current user will be authorized only in the
    borders of our application (you can have a Facebook passport strategy where
    you will use Facebook credentials to log in).
</p>
<p>
    Here we use authentication method from the <strong>User’s</strong> model.
    It’s job will be to see if the currently given password is matching the
    original one. Here is the logic in the User’s <strong>schema</strong>:
</p>
<p>
    The passport module will provide us with two functions (as said above)
which means that it <strong>automatically</strong> takes care of    <strong>login/logout</strong>. However, the input data may be called
    differently than “<strong>email</strong>” and “<strong>password</strong>”
    (aka in our <strong>html</strong> form the <strong>input fields</strong>
can be <strong>named differently</strong>), therefore we can pass some    <strong>configuration object</strong>, in which we can set these names
    (usernameField: username). And to make that strategy complete, we should
    pass it to the passport module using the keyword: “use”.
</p>
<p>
Next, we will need to implement two functions for our    <strong>passport</strong> module. They are called: serializeUser and
deserializeUser. <strong>Passport</strong> is responsible for    <strong>distinguishing users</strong> (as the passport in real life), so to
    do that, we should tell it how to <strong>differentiate users</strong>.
</p>
<p>
    The code for this looks like this:
</p>
<p>
    Let’s break down what it does:
</p>
<p>
    · serializeUser – we give it the <strong>user object</strong> (user
    variable), and a done<strong> </strong>function. If we don’t have a user,
we call done with <strong>null</strong>, and if we do, we return the user’s    <strong>id</strong>.
</p>
<p>
    · deserializeUser – we give it the <strong>user id</strong> (user
    variable), and a done<strong> </strong>function. If we don’t have a user,
we call done with <strong>null</strong>, and if we do, we return the    <strong>user</strong> as an <strong>object</strong>.
</p>
<p>
    Since we moved a lot of our logic in the “<strong>express.js</strong>”
module we can safely <strong>remove</strong> <strong>it</strong> from “    <strong>app.js</strong>”. Here is how the “<strong>app.js</strong>” should
    look in the end:
</p>
<p>
Here is how the project structure should look like <strong>after</strong>    <strong>the addition</strong> of these three modules:
</p>
<h2>
    7. Register User
</h2>
<p>
Now that we have our <strong>authentication</strong> strategy and entity<strong>model</strong>, let’s start creating some <strong>views</strong> to    <strong>register</strong> our first user!
</p>
<p>
    Create a “<strong>user</strong>” folder in the “<strong>views</strong>”
    folder. Put a “<strong>register.hbs</strong>” file in it and copy the
    following <strong>html</strong>:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="695" valign="top">
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container body-content span=8 offset=2"</strong>
                    &gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"well"</strong>&gt;
                    <br/>
&lt;<strong>form </strong><strong>class=</strong><strong>"form-horizontal" </strong><strong>method=</strong><strong>"post" </strong><strong>action=</strong>                    <strong>"/user/register"</strong>&gt;
                    <br/>
                    &lt;<strong>fieldset</strong>&gt;
                    <br/>
&lt;<strong>legend</strong>&gt;Register&lt;/                    <strong>legend</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label" </strong>                    <strong>for=</strong><strong>"inputEmail"</strong>
                    &gt;Email&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputEmail" </strong><strong>placeholder=</strong><strong>"Email" </strong><strong>name=</strong><strong>"email" </strong><strong>required value=</strong>{{                    <strong>email</strong>}} &gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label" </strong>                    <strong>for=</strong><strong>"inputFullName"</strong>
                    &gt;Full Name&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputFullName" </strong><strong>placeholder=</strong><strong>"Full Name" </strong><strong>required name=</strong><strong>"fullName" </strong>                    <strong>value=</strong>{{<strong>fullName</strong>}}&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label" </strong>                    <strong>for=</strong><strong>"inputPassword"</strong>
                    &gt;Password&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4"</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"password" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputPassword" </strong><strong>placeholder=</strong><strong>"Password" </strong>                    <strong>required name=</strong><strong>"password"</strong>
                    &gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong>                    <strong>"col-sm-4 control-label"</strong>&gt;Confirm
                    Password&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4"</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"password" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputPassword" </strong><strong>placeholder=</strong><strong>"Confirm Password" </strong><strong>required name=</strong>                    <strong>"repeatedPassword"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 col-sm-offset-4"</strong>&gt;
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"reset" </strong><strong>class=</strong><strong>"btn btn-default"</strong>&gt;Cancel&lt;/                    <strong>button</strong>&gt;
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"submit" </strong><strong>class=</strong><strong>"btn btn-primary"</strong>&gt;Submit&lt;/                    <strong>button</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>fieldset</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Now, after we have our user registration view, let’s create a    <strong>controller</strong> to render it.
</p>
<p>
    Let’s create a folder named “<strong>controllers</strong>”. Inside it,
    create a file called “<strong>user.js</strong>”. We will put everything all
the logic, which will manipulate our User model there.<strong>Add a function</strong>, which will render the    <strong>html</strong> passed above:
</p>
<p>
    Our function in the controller will receive the request and response as
    parameters.
</p>
<p>
    What we need now is to define routes (routes will say which controller when
    to be called). The logic of routes is simple and lay on
    <a
        href="http://www.andrewhavens.com/posts/20/beginners-guide-to-creating-a-rest-api/"
    >
        REST
    </a>
    API definition. Let’s <strong>delete the routes folder</strong> we have and
    create a “<strong>routes.js</strong>” file in the “<strong>config</strong>”
    folder where we can handle all requests:
</p>
<p>
    Now, require it in our <strong>app.js</strong> file:
</p>
<p>
    If everything is ok and we <strong>run the server</strong>, when we go on
    localhost:3000/user/register, the following should be displayed:
</p>
<p>
    <strong></strong>
</p>
<p>
    Our form got displayed (using a <strong>GET</strong> request)!
</p>
<p>
    Let’s dive deeper in “<strong>user/register.hbs</strong>”. If we look at
the &lt;form&gt; tag, we can see that the form has<strong>two attributes</strong><strong>: (key</strong><strong> </strong>    <strong>è</strong><strong> value) </strong>pairs:
</p>
<ul>
    <li>
        <strong>method </strong>
        <strong>è post</strong>
        <strong></strong>
    </li>
    <li>
        <strong>action </strong>
        <strong>è /user/register</strong>
        <strong></strong>
    </li>
</ul>
<p>
    This simply means that whenever this form is submitted (aka the button of
    type “submit” is clicked). It will create a POST request towards the URL
    described above:
</p>
<p>
This means that we need to <strong>create a new route</strong> with<strong>same URL</strong>, but <strong>different HTTP method</strong>    <strong> (</strong>POST<strong>)</strong>:
</p>
<p>
    First, add the route to the in “<strong>routes.js</strong>” file:
    <br/>
</p>
<p>
    Second create a new action in the User’s controller. That action should do
    the following:
</p>
<p>
We need to parse the input data. We can find it in the    <strong>request’s</strong> <strong>body</strong>. You can access concrete
    arguments from it by passing the name of the input field (taken from the
    html). If we look at “<strong>user/register.hbs</strong>”, we can see that
    every input field has a name attribute (name="email" and so on):
</p>
<p>
    So, if we want to take the “<strong>email</strong>” value, we can do it
    with: “registerArgs.email”. For more clarity look at the pictures below.
</p>
<p>
    Second, we need to write our <strong>validation logic</strong>, which needs
    to answer <strong>two questions</strong>:
</p>
<ul>
    <li>
        Is the given email <strong>already registered</strong>?
    </li>
    <li>
        Do <strong>both passwords match</strong>?
    </li>
</ul>
<p>
    If the answer to both of those questions is “<strong>yes</strong>”, only
    then can we register the user.
</p>
<p>
    Before we can answer the questions, we need to figure out how we can search
    the models for data. Luckily, <strong>Mongoose</strong> gives us this
    functionality. All we need to do is require() the <strong>User</strong>
    model and then just use Mongoose’s built-in methods:
</p>
<p>
    At this point, our user.js controller should look like this:
</p>
<p>
    Now, back to validation. Let’s answer the validation questions. To do that,
we need to <strong>connect to our database</strong> and<strong>check</strong> if there is    <strong>already a user with that email</strong>. This can be done by using
the Mongoose findOne() function. This command accepts an    <strong>object</strong>, which we can use as a <strong>filter</strong>:
</p>
<p>
However here is something very important: this function is<strong>asynchronous</strong> (like most query functions) and it will<strong>not </strong>directly return the user. This means that we    <strong><u>cannot</u></strong> do something like this:
</p>
<p>
    Instead we need to use <strong>promises</strong>, which are essentially
    just <strong>chained functions</strong>. You can use a promise with the
    keyword then().
</p>
<p>
    For example, if we wanted to <strong>print</strong> a <strong>user</strong>
    with a specific <strong>email</strong> like in the code above, we would
    write the following:
</p>
<p>
Now, after we’ve found the user, let’s <strong>validate</strong> if the    <strong>user exists</strong> and if the <strong>passwords match</strong>:
</p>
<p>
    For every error case, we will create a <strong>string</strong> variable in
    which we’ll save the error message. Note that <strong>JavaScript</strong>
is <strong><u>weird</u></strong> when speaking about<strong>truthy</strong> and <strong>falsy</strong> values. Read this    <a href="http://james.padolsey.com/javascript/truthy-falsey/">article</a>
    for further clarity.
</p>
<p>
    Now, let’s analyze what the logic in the above screenshot does:
</p>
<p>
    If the user variable returns anything, that’s <strong>bad</strong>, because
it means there’s <strong>already a user with that email</strong> in the<strong>database</strong>. If there weren’t, it would have returned    <strong>null</strong>.
</p>
<p>
    We can convert the <strong>user </strong>variable to true/false by just
    putting it in an if<strong> </strong>statement. An undefined value would be
    converted into false and an existing user, (which isn’t undefined) into
    true.
</p>
<p>
After we have our validations, we should check for any    <strong>errors</strong>:
</p>
<p>
If any errors occurred, we will simply <strong>reload</strong><strong>the page</strong>. The key thing here is that we will reload it    <strong>with the previous values</strong> (so that the user doesn’t have
    their form cleared), and with the <strong>error message</strong>. The error
message will be <strong>displayed</strong> in the layout (“    <strong>layout.hbs</strong>”).
</p>
<p>
On the other hand, if we <strong>didn’t have any errors</strong>,    <strong> </strong>we should insert a <strong>new entity</strong> in the
    database and <strong>log</strong> the user <strong>in</strong>:
</p>
<p>
    <em>
        Do not forget to require the “User” model and the “encryption” utility
        module!
    </em>
    <em></em>
</p>
<p>
    One last thing before we move on to the <strong>Login</strong> form – go to
    the “<strong>express.js</strong>” file and add the following:
</p>
<p>
    We have just declared a
    <a href="http://expressjs.com/en/guide/using-middleware.html">
        middleware
    </a>
    , which will simply make our current user visible for both the views and
    the controllers.
</p>
<h2>
    8. Login Form
</h2>
<p>
    We will create our login functionallity in the same fashion we created the
register one. In the previous step we did the following: register form<strong>view</strong> -&gt; <strong>controller</strong> -&gt;    <strong>route</strong> -&gt; <strong>controller</strong>.
</p>
<p>
    Create “login.hbs” in “views/user” folders:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="702" valign="top">
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container body-content span=8 offset=2"</strong>
                    &gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"well"</strong>&gt;
                    <br/>
&lt;<strong>form </strong><strong>class=</strong><strong>"form-horizontal" </strong><strong>method=</strong><strong>"post" </strong><strong>action=</strong>                    <strong>"/user/login"</strong>&gt;
                    <br/>
                    &lt;<strong>fieldset</strong>&gt;
                    <br/>
&lt;<strong>legend</strong>&gt;Login&lt;/                    <strong>legend</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label"</strong>&gt;Email&lt;/                    <strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputEmail" </strong><strong>placeholder=</strong><strong>"Email" </strong><strong>name=</strong>                    <strong>"email"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label"</strong>&gt;Password&lt;/                    <strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4"</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"password" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"inputPassword" </strong><strong>placeholder=</strong><strong>"Password" </strong>                    <strong>name=</strong><strong>"password"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 col-sm-offset-4"</strong>&gt;
                    <br/>
&lt;<strong>a </strong><strong>class=</strong><strong>"btn btn-default" </strong><strong>href=</strong>                    <strong>"/"</strong>&gt;Cancel&lt;/<strong>a</strong>&gt;
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"submit" </strong><strong>class=</strong><strong>"btn btn-primary"</strong>&gt;Login&lt;/                    <strong>button</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>fieldset</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Then add the <strong>action</strong> in the    <strong>user controller</strong>:
</p>
<p>
After that, extend the “<strong>routes.js</strong>” file with our    <strong>login</strong> <strong>get </strong>action:
</p>
<p>
It’s time to go back to the <strong>user</strong>    <strong>controller</strong> and create the <strong>login logic</strong>.
Just like with registration, we need to answer a couple    <strong>validation questions </strong>before we let the user log in:
</p>
<ul>
    <li>
        Does the user exist?
    </li>
    <li>
        If so, does the <strong>password</strong> (when hashed) they gave us
        match the <strong>hashed</strong> <strong>password </strong>given in
        the input?
    </li>
</ul>
<p>
The easiest way to do that is to give every <strong>User</strong> a    <strong>validation function</strong>. This is the easiest way because the
users have all the needed information (<strong>salt</strong> and<strong>passwordHash</strong>). Go to the <strong>User.js</strong> in “    <strong>models</strong>” folder and add this block of code:
</p>
<p>
    Make sure that this <strong>method</strong> appears <strong>before</strong>
the one, which creates the User’s <strong>model </strong>(“mongoose.model”)    <strong>.</strong><strong></strong>
</p>
<p>
    Again on the <strong>controller</strong>. Write a search query (aka
    User.findOne) and <strong>validate</strong> user’s input:
</p>
<p>
    So, we have some <strong>validation</strong> on the input, what left is to
actually <strong>log</strong> the <strong>user in</strong>. You may use the<strong>same</strong> logic <strong>as</strong> we used in the    <strong>registration</strong> section.
</p>
<h2>
    9. Logout
</h2>
<p>
Logging out is very simple. Let’s add it in the    <strong>user controller</strong>:
</p>
<p>
Add the <strong>logout route</strong>. Here is how “    <strong>routes.js</strong>” should look at this point:
</p>
<h1>
    IV. Creating Articles
</h1>
<h2>
    1. Start MongoDB (Only if you are here from the start)
</h2>
<p>
Before going ham on MongoDB, let’s clarify some things. MongoDB is a<strong>NoSQL</strong> database. But what is database? A    <strong>Database</strong> is just some <strong>storage</strong> for
information. For now, we can assume that a database is just a bunch of    <strong>tables</strong> in which we <strong>save information</strong>
    (SQL). Here is how our <strong>User table</strong> looks like from previous
    steps:
</p>
<p>
We have a couple of <strong>tables</strong>, each of them have some<strong>columns</strong> which give us the opportunity to    <strong>store</strong> <strong>data in them</strong>. This is what a
    typical SQL database looks like:
</p>
<p>
    <strong>MongoDB</strong>
uses a slightly different approach. Instead of saving the data into a<strong>table-columns</strong> format, it parses<strong>every object</strong> to a <strong>JSON</strong><strong>string</strong> and saves it. That’s all! Here is an example of a<strong>user</strong> <strong>object</strong> saved in    <strong>MongoDB</strong>:
</p>
<p>
    <strong> </strong>
</p>
<p>
One more thing: concrete <strong>objects</strong> are named<strong>documents</strong>, and a list of <strong>grouped</strong>    <strong>documents</strong> is called a <strong>collection</strong>
(contrary to SQL, where one object consists of a <strong>row</strong> of    <strong>several columns</strong>, which is inside a <strong>table</strong>
    ).<strong></strong>
</p>
<p>
    Enough talk, let’s do some action:
</p>
<p>
1. <strong>Open</strong> a <strong>MongoDB</strong><strong>connection</strong> – open <strong>Command Prompt </strong>in the    <strong>directory</strong>, where mongo is installed (Example: “C:\Program
    Files\MongoDB\Server\3.2\bin”) and type <strong>“</strong>mongod --dbpath
    "D:\test\example"”. What this will do is: <strong>create a server</strong>
    (locally) on the default <strong>port </strong>(<strong>27017</strong>) and
    will wait for any command.
</p>
<p>
    2. <strong>Connect</strong> to the newly-created server: depends on whether
    you are using <strong>console</strong> or <strong>GUI client</strong>
</p>
<ul>
    <li>
For a <strong>console</strong> <strong>client</strong> simply run the “        <strong>mongo</strong>” command. But in <strong>different</strong>
        window.
    </li>
    <li>
For <strong>RoboMongo</strong>, just        <strong>start the application</strong> and <strong>connect</strong> to
        the <strong>Mongo server</strong>.
    </li>
</ul>
<p>
Now you can communicate with the database and execute    <a href="https://docs.mongodb.com/v3.2/reference/command/">commands</a>.
</p>
<p>
    You can create a database named “<strong>blog</strong>”. Check out the “
    <a
        href="file:///C:/Users/alenSavov/Desktop/SoftUni-Hub/Software-University-SoftUni/02.SoftwareTechnology-October-2017/06.%20JavaScript%20Blog%20Basic%20Functionality/08.%20Software-Technologies-JavaScript-Blog-Basic-Functionality-Lab.docx#_Create_a_Database"
    >
        Create database
    </a>
    ” step for steps on how to do that.
</p>
<p>
    Summary: We now know the simple definition of a database. We saw different
    ideas for implementing a database. Also, we learned how to start a MongoDB
    server from which we can create and manipulate different databases.
</p>
<p>
    Here is how your connection <strong>might</strong> look like:
</p>
<h2>
    2. Open/Create project
</h2>
<p>
    We have our database ready. Let’s go ahead and load the skeleton. Click
    open and find the downloaded and unzipped skeleton project:
</p>
<p>
    Note that the skeleton project has also <strong>one more</strong>
controller named “<strong>home</strong>” and one more folder in “    <strong>views</strong>”, also named “<strong>home</strong>”. Don’t worry if
    you don’t have them at the moment, we will talk about them later. Here is
    how the project structure should look like:
</p>
<p>
    This is our <strong>Node.js</strong> project. In the previous steps, we saw
    how we got here. Now let’s talk a little bit about <strong>Node</strong>:
</p>
<p>
    <strong>Node.JS</strong>
    is a <strong>platform</strong> written in <strong>JavaScript</strong>,
    which provides <strong>back-end</strong> functionality. This gives us a lot
of flexibility because our <strong>front-end</strong> (HTML, using<a href="https://jquery.com/">jQuery</a>,<a href="http://www.w3schools.com/xml/ajax_intro.asp">Ajax</a> etc.)<strong>also</strong> uses <strong>JavaScript</strong>. This makes mutual    <strong>communication</strong> easier. It is fast because it uses C++
behind the scenes and also, because it’s capable of making    <strong>asynchronous calls</strong>. It uses the event loop
    <a href="https://www.tutorialspoint.com/nodejs/nodejs_event_loop.htm">
        system
    </a>
    .
</p>
<p>
    Summary: we have downloaded the project and we are ready for further
    action!
</p>
<h2>
    3. Create the Article Model
</h2>
<p>
    It is time to design our main entity – the <strong>Article</strong>. It
    will have the following properties:
</p>
<ul>
    <li>
        title
    </li>
    <li>
        content
    </li>
    <li>
        author
    </li>
    <li>
        date
    </li>
</ul>
<p>
    The interesting property here is the <strong>author</strong> property,
    because it is <strong>already</strong> a <strong>model</strong> in our
    database. Imagine that if every time we created an <strong>article</strong>
    , we <strong>bound</strong> that author’s <strong>information </strong>to
the article. What happens when one <strong>author</strong> creates<strong>50</strong> <strong>articles</strong>? Would we store the same<strong>author name</strong> and <strong>other</strong>    <strong>properties</strong> for every single one? Wouldn’t that be a huge
    waste of <strong>memory</strong>? Yes, so how can we resolve that problem?
</p>
<p>
The answer is what’s called a <strong>reference</strong> key (something<strong>unique</strong> for the author – like an <strong>ID</strong> or a    <strong>name</strong>). When our author has an <strong>ID</strong>, instead
of binding all the information to the article, we just    <strong>save</strong> that author <strong>ID</strong> in the article.
</p>
<p>
But how do we retrieve information about a specific<strong>article’s author</strong>, you ask. Well, we can always just<strong>look them up </strong>in the database, using the    <strong>ID</strong>, which we saved inside the article. This is called
    (database) <strong>relations</strong>. One author has zero or many
    articles. We will cover on that more in the next chapter.
</p>
<p>
Let’s create our model in the <strong>Mongoose</strong> way.<strong>In</strong> our “<strong>models</strong>” <strong>folder</strong><strong>create</strong> a <strong>file</strong> named “    <strong>Article</strong>.<strong>js</strong>”:
</p>
<p>
    1. <strong>Define</strong> article <strong>schema</strong>:
    <br/>
    <strong> </strong>
</p>
<p>
    2. <strong>Declare</strong> <strong>properties</strong> with their types
and any other <strong>constraints</strong> (such as<strong>default</strong> values, is current property    <strong>unique</strong>, is it <strong>required</strong> and so on…):
    <br/>
</p>
<p>
    Look at how we created the <strong>user schema</strong> as well (if you
    skipped the first 3 chapters).
</p>
<p>
    <strong>Two</strong>
    key <strong>things</strong> to notice:
</p>
<ul>
    <li>
The <strong>author</strong> has the “mongoose.Schema.Types.ObjectId”<strong>type</strong>. That ObjectId is the type of the        <strong>unique</strong> <strong>identifier</strong> that our database
        puts on every document in order to differentiate between two documents.
This is done <strong>when</strong> you <strong>initially</strong><strong>save</strong> a document (aka <strong>when</strong> you<strong>create</strong> an article – the database will generate an “        <strong>id</strong>” <strong>property</strong> – it may simply be just
        a string with <strong>unique</strong> content).
    </li>
    <li>
The “<strong>ref</strong>” property, which is telling<strong>Mongoose</strong> that this “<strong>id</strong>” will        <strong>reference</strong> the “<strong>User</strong>” collection.
    </li>
</ul>
<p>
    After we have defined our schema with all of it’s relations and constraints
    we will <strong>wrap</strong> it in a model. <strong>Model</strong> gives
    us the functionallity to perform <strong>CRUD</strong> operations. This
    means that if I <strong>create</strong> an <strong>article</strong> which
has the same structure like the article’s schema (aka object    <strong>with</strong> <strong>title</strong>, <strong>content</strong>
etc.) by using the Model wrapper we can <strong>save</strong> it<strong>to</strong> the <strong>database</strong>. See this    <a href="http://mongoosejs.com/docs/guide.html">guide</a> for more
    explanation.
</p>
<p>
    Almost done: let’s <strong>export</strong> our model, so it can be visible
    for the outer world:
</p>
<p>
One last thing: we need to add a reference to the    <strong>Article model </strong>in our <strong>database.js</strong> file, so
    our database can know articles exist and can use them:
</p>
<p>
    <strong>Summary</strong>
    : we now know how to create a user schema, wrap it in a model and define a
    relation with another model.
</p>
<h2>
    4. Create Author – Article Relationship
</h2>
<p>
Our <strong>program</strong> is like our real world – it is    <strong>based</strong> on <strong>connections</strong> and interactions
between it’s elements. We have a <strong>user</strong> which has    <strong>zero</strong> or <strong>more</strong> <strong>articles</strong>.
    This relation is called <strong>one</strong> to <strong>many</strong>. We
    might want the <strong>articles</strong> to have <strong>tags</strong>.
Many articles with many tags. Again relation – this one is called    <strong>many</strong> to <strong>many</strong>. Our articles may have
categories. <strong>One</strong> <strong>article</strong> –    <strong>one</strong> <strong>category</strong>, from this side it looks
    like a <strong>one</strong> to <strong>one</strong> relation. Well, this is
true <strong>but</strong> keep in mind that <strong>one</strong><strong>category</strong> may have <strong>many</strong><strong>articles</strong>. Here is the conclusion: relations can be:<strong>One to One</strong>, <strong>One to Many</strong>,<strong>Many to Many</strong>. There is one more called    <strong>One to Few</strong>.
</p>
<p>
    Let’s go back to the <strong>author</strong> - <strong>article</strong>
    relation. One article will have one author. We defined it with property in
    the article model. In order to complete the relation we have to change
current user’s schema. In database world this is called<strong>Migration</strong>. Let’s do the migration in the    <strong>user’s</strong><strong> schema</strong>:
</p>
<p>
    Just <strong>add</strong> the <strong>property</strong> articles, which
    will have the type <strong>ObjectId</strong> <strong>array </strong>type,
and a <strong>default</strong> value, which is an empty array. This is our    <strong>migration</strong>.
</p>
<p>
Summary: a database <strong>relation</strong> defines<strong>connection</strong> between two entities. The<strong>relation</strong> type depends on the point of    <strong>view</strong>. In MongoDB <strong>migrations</strong> are as free
    as <strong>changing</strong> the <strong>model</strong>.
</p>
<h2>
    5. Apply Database Migrations
</h2>
<p>
    In the <strong>MongoDB</strong> world, where we don’t have tables and
    columns, relations between models are <strong>more loose</strong>. The
    whole
    <a
        href="https://media.tenor.co/images/4c3b395bb7e3b40b780ac97f287b6ab3/raw"
    >
        responsibility
    </a>
of handling a migration is given to the programmer<strong> (for better or for worse)</strong>. There are some    <a href="https://github.com/emirotin/mongodb-migrations">frameworks</a>
    that might help us with that, but for the scope of our project it would be
    too overkill to use one.
</p>
<p>
    Let’s continue with our logic. In order to keep our data up to date we have
    to find all users who do not have an ”<strong>articles</strong>” property
    and set the default value of it, so we don’t get any errors down the road
    when we actually start creating articles. This simply means that every
    change that we made to the schema will affect every next document inserted
    and will not make any update on existing documents.
</p>
<p>
    This migration problem has two solutions: either delete all the old data
    and start over or run an update query on the not-updated entities. This can
    be done with the following command.
</p>
<p>
    · If we want to use the console, just execute this statement:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="642" valign="top">
                <p align="center">
                    <strong>
                        db.getCollection('users').update({articles: {$exists:
                        false}}, { $set: {articles: []}}, {multi: true})
                    </strong>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
· If we want to use RoboMongo, we need to right click the    <strong>blog</strong> database and <strong>click Open Shell</strong>, after
which we can <strong>paste </strong>the command from above and click    <strong>F5</strong> to execute it:
    <br/>
</p>
<p>
    Let’s look closer on this query:
</p>
<ul>
    <li>
        db.getCollection('users') – find all users.
    </li>
    <li>
        update() – update the first match found (by default)
    </li>
</ul>
<p>
    · {articles: {$exists: false}} – for every user where “articles” is not
    existing property.
</p>
<ul>
    <li>
        {$set: {articles: []}} – sets “articles” value to empty array.
    </li>
    <li>
        {multi: true} – update all matches, not just the first one.
    </li>
</ul>
<p>
    <a href="http://mongoosejs.com/docs/api.html#model_Model.update">Source</a>
    .
</p>
<p>
    <strong>Summary</strong>
: When having a <strong>migration</strong> we are the ones to    <strong>update</strong>/delete the already <strong>existing</strong> data.
Updating can be done with the “<strong>update</strong>” command and we can<strong>pass</strong> some <strong>filter</strong>    <strong>arguments</strong> to it.
</p>
<h2>
    6. Create the Article Controller
</h2>
<p>
    The next part will be creating the <strong>article controller</strong>
where we will put all the logic connected directly with the    <strong>Article</strong> model. Create an “<strong>article.js</strong>”
    file in the “<strong>controllers</strong>” folder. As a starter, we want to
    create a method which will render the form for creating an article. The
    controller might look like this:
</p>
<p>
    Note that we can require a mongoose <strong>model</strong> through the
    mongoose module just by passing the model’s <strong>name</strong>.
    Important thing about this way is that the code, initializing the Article
    model must be compiled before we try to access the model.
</p>
<p>
    With the above code are in need to create a view which will render the form
    for creating article.
</p>
<h2>
    7. Templating Article Form
</h2>
<p>
In the beginning of the project creation we said that we will use the    <strong>Handlebars</strong> view engine. So, this time, instead of copying
the html and directly moving forward let’s see how<strong>templating</strong> is done. As an example, we’ll take on    <strong>layout.hbs:</strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    We can see that there is a lot of html but also there are multiple blocks
    of code which are not. These parts are for the <strong>view engine</strong>
    . Let’s explain what it does to the code.
</p>
<p>
    With double curly brackets “<strong>{{</strong>”, we say that the next part
will not be html but a <strong>command</strong> for our<strong>view engine</strong>. This scope for the command ends with next    <strong>closing curly brackets</strong> – “<strong>}}</strong>”. In the
    current example, we can see that we have an <strong>if </strong>statement
(#if). If the <strong>variable</strong> passed to the “if” is    <strong>truthy</strong>, all the html until the <strong>{{/if}}</strong>
    will be displayed.
</p>
<p>
    Okay, but what if the variable is <strong>falsy</strong> and we want to
    display something different? We will use “<strong>unless</strong>” in the
    same way that we used “if”.
</p>
<p>
    In the end, the result will be: if there is any user logged in, display the
    first blog html (with “Welcome”, “Logout” etc.), else display the other
    blog html (“<strong>Register</strong>”, “<strong>Login</strong>” etc.)
</p>
<p>
But how does the view know about the current user? Look at “    <strong>express.js</strong>” – there is a middleware that binds user in way
    that allows to be visible to the view (if you don’t have that middleware –
    write it somewhere after <strong>passport.session()</strong>):
</p>
<p>
Another <strong>thing</strong> to mention: look at the first<strong>&lt;a&gt; tag</strong> – there is a block “{{    <strong>user.email</strong>}}”. This simply means that we can not only use
“<strong>user</strong>” as a boolean but to actually <strong>take</strong>    <strong>data</strong> from it! There are more commands to use (like
    “each”), but we’ll cover that later. For now, let’s go back to the article.
We need a view which will display an <strong>html</strong>    <strong>form</strong>. In this form, <strong>data</strong> (title, content
etc.) will be <strong>inserted</strong> and we’ll have to take that data    <strong>into</strong> our logic (for example, a <strong>controller</strong>
    ). Create a “<strong>views/article/create.hbs</strong>” file:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container body-content span=8 offset=2"</strong>
                    &gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"well"</strong>&gt;
                    <br/>
&lt;<strong>form </strong><strong>class=</strong><strong>"form-horizontal" </strong><strong>method=</strong><strong>"POST" </strong><strong>action=</strong>                    <strong>"/article/create"</strong>&gt;
                    <br/>
                    &lt;<strong>fieldset</strong>&gt;
                    <br/>
&lt;<strong>legend</strong>&gt;New Article&lt;/                    <strong>legend</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label" </strong>                    <strong>for=</strong><strong>"articleTitle"</strong>
                    &gt;Article Title&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"articleTitle" </strong><strong>placeholder=</strong><strong>"Article Title" </strong><strong>name=</strong>                    <strong>"title" </strong><strong>required </strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>label </strong><strong>class=</strong><strong>"col-sm-4 control-label" </strong>                    <strong>for=</strong><strong>"articleContent"</strong>
                    &gt;Content&lt;/<strong>label</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-6"</strong>&gt;
                    <br/>
&lt;<strong>textarea </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"articleContent" </strong><strong>rows=</strong><strong>"5" </strong><strong>name=</strong>                    <strong>"content" </strong><strong>required</strong>
                    &gt;&lt;/<strong>textarea</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 col-sm-offset-4"</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"reset" </strong><strong>class=</strong><strong>"btn btn-default"</strong>&gt;Cancel&lt;/                    <strong>button</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"submit" </strong><strong>class=</strong><strong>"btn btn-primary"</strong>&gt;Submit&lt;/                    <strong>button</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>fieldset</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Our <strong>form</strong> html tag contains two important attributes:<strong>method</strong> – which defines what the HTTP    <a href="https://www.tutorialspoint.com/http/http_methods.htm">method</a>
    of the request will be, and <strong>action</strong> – the actual link where
    we want the data to go. So, wherever this form is submitted the request
    will go where the <strong>action</strong> attribute points.
</p>
<p>
    <strong>Summary</strong>
: The <strong>view engine</strong> helps us <strong>put</strong><strong>logic</strong> in our views and also helps us    <strong>display</strong> even <strong>more</strong> information. The best
thing here is that that logic can be put <strong>directly</strong>    <strong>into</strong> our <strong>html</strong> code. J
</p>
<h2>
    8. Finalize Article Creation
</h2>
<p>
    After we have our form displayed, it’s time to parse its data and complete
    our article creation. Go back to “<strong>controllers/article.js</strong>”
    and create another function to handle that logic:
</p>
<p>
    This is how the article controller should look for now. We have our article
    data parsed so start making some <strong>validations</strong>:
</p>
<p>
    req.isAuthenticated() comes from the passport module and it checks if there
    is currently a logged in user. This validation is optional for now. Other
checks validate if the <strong>title/content</strong> is    <strong>empty/undefined/null</strong>. If they are, an error message is
    created.
</p>
<p>
After all validations, there are two things we can do: either<strong>inform the user </strong>if an error occurred, or    <strong>create an article article</strong> and <strong>store</strong> it in
    the <strong>database</strong>:
</p>
<p>
    Here’s how the control flow goes:
</p>
<ul>
    <li>
        If there are <strong>any</strong> <strong>errors</strong>, we will:
    </li>
</ul>
<p>
    o <strong>Re-render</strong> the same page, but this time, we’ll pass an
    object <strong>with</strong> an “<strong>error</strong>” property, whose
    textwill be displayed in the “<strong>layout.hbs</strong>”.
</p>
<ul>
    <li>
        If there<strong> isn’t any error</strong>, we will:
    </li>
</ul>
<p>
    o <strong>Assign</strong> the <strong>author’s</strong> <strong>id</strong>
    to the <strong>article</strong> object
</p>
<p>
    o <strong>Save</strong> the article to the database
</p>
<p>
    o Attach an “<strong>id</strong>” to the <strong>article</strong>, which we
will <strong>add</strong> to the <strong>author’s</strong>    <strong>articles</strong> later.
</p>
<p>
    Here is our <strong>redirect</strong>. We just say <strong>where</strong>
    to redirect (in our case will be just the home page – ‘’<strong>/</strong>
    ”) and pass any additional info (object) to the view engine (if needed).
</p>
<p>
Now we need to <strong>add</strong> the routes to our “    <strong>routes.js</strong>” file. First require the articleController:
</p>
<p>
    And <strong>attach</strong> <strong>functions</strong> to the POST and GET
    methods on the <strong>“/article/create</strong>” URL:
</p>
<p>
    <strong>
        <em>If you are using the skeleton skip the following step</em>
    </strong>
    <em>:</em>
</p>
<p>
    <strong>Create</strong>
    a <strong>folder</strong> named “<strong>home</strong>” <strong>in</strong>
the “<strong>views</strong>” folder. Then create an empty “    <strong>index.hbs</strong>” file. Go to “controllers” folder and add new
    controller named – “<strong>home.js</strong>”. Inside of it just simply
    type:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="228" valign="top">
                <p>
                    module.exports = {
                    <br/>
                    index: (req, res) =&gt; {
                    <br/>
                    res.render(<strong>'home/index'</strong>);
                    <br/>
                    }
                    <br/>
                    };
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
And don’t forget to <strong>require</strong> the    <strong>Article.js</strong> in the <strong>database.js</strong> :
</p>
<p>
Then, add the <strong>home controller</strong> into the “    <strong>routes.js</strong>” and the “<strong>home</strong>” routing:
</p>
<p>
    If you had problems with this setup (or any other) feel free to look from
    the skeleton. J
</p>
<p>
    Summary: We have completed our logic for creating articles. We have
performed <strong>validations</strong> and based on them we can<strong>inform</strong> our <strong>user</strong> for any errors. After<strong>saving</strong> the <strong>article</strong> in the database we    <strong>update</strong> our user’s <strong>articles</strong>.
</p>
<h1>
    V. Read Articles
</h1>
<p>
    In this part, we will focus on manipulating the article entity.
</p>
<h2>
    1. List Articles
</h2>
<p>
What we will try to do now is to display <strong>6</strong> articles with    <strong>information</strong> about every one of them. We want to do it on
    our home, so let’s go the “home/index.hbs” view and type the following:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container body-content"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"row"</strong>&gt;
                    <br/>
                    {{#<strong>each articles</strong>}}
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-md-6"</strong>&gt;
                    <br/>
                    &lt;<strong>article</strong>&gt;
                    <br/>
                    &lt;<strong>header</strong>&gt;
                    <br/>
&lt;<strong>h2</strong>&gt;{{<strong>this</strong>.                    <strong>title</strong>}}&lt;/<strong>h2</strong>&gt;
                    <br/>
                    &lt;/<strong>header</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>p</strong>&gt;{{<strong>this</strong>.                    <strong>content</strong>}}
                    <br/>
                    &lt;/<strong>p</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>small </strong><strong>class=</strong>                    <strong>"author"</strong>&gt;
                    <br/>
{{<strong>this</strong>.<strong>author</strong>.                    <strong>fullName</strong>}}
                    <br/>
                    &lt;/<strong>small</strong>&gt;
                    <br/>
                    <br/>
                    &lt;<strong>footer</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"pull-right"</strong>&gt;
                    <br/>
&lt;<strong>a </strong><strong>class=</strong><strong>"btn btn-default btn-xs" </strong><strong>href=</strong><strong>"/article/details/</strong>{{<strong>this</strong>.<strong>id</strong>}}<strong>"</strong>&gt;Read more                    <strong>&amp;raquo;</strong>&lt;/<strong>a</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>footer</strong>&gt;
                    <br/>
                    &lt;/<strong>article</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    {{/<strong>each</strong>}}
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Here, we use Handlebars’ full strength. We are using an “    <strong>each</strong>” construction (which works the same way as foreach in
    some languages).
</p>
<p>
    We go through <strong>every article</strong> which was passed to us. For
    every single one we will display:
</p>
<ul>
    <li>
        its <strong>title</strong> (using <strong>this</strong> means that we
are iterating over the <strong>current</strong>        <strong>article</strong>)
    </li>
    <li>
        its <strong>content</strong>
    </li>
    <li>
        its <strong>author</strong>
    </li>
</ul>
<p>
The interesting part here is that we pass this statement: “    <strong>this.author.fullName</strong>”. Remember when we created the
Article <strong>model</strong>? The “<strong>author</strong>” property    <strong>was</strong> of type “<strong>ObjectId</strong>”, right? Here comes
    the cruicial point in getting the whole information (from our relation).
    Let’s see how we will get that information from the “<strong>home</strong>”
    controller:
</p>
<p>
    What this will do is:
</p>
<ul>
    <li>
        Retrieve all the articles
    </li>
    <li>
        Get <strong>only the first</strong> <strong>6</strong> of them
    </li>
    <li>
        <strong>Populate</strong>
their “<strong>author</strong>” property (put <strong>all</strong>        <strong>of</strong> the author’s information there instead of just
        their <strong>ID</strong>)
    </li>
</ul>
<p>
    · Send them to the “home/index” view.
</p>
<p>
Populate example: If we have an <strong>article</strong> with an “<strong>author</strong>” <strong>property</strong> = “    <strong>a3fvce4GtT</strong>” (which is the author’s ID) and we say that we
want to populate that property, <strong>MongoDB</strong> will search in the    <strong>User</strong> model for a user with the <strong>same ID</strong>
    and simply attach <strong>all the information</strong> it has for that
    user.
</p>
<p>
    Also, notice the <strong>link</strong> for the “<strong>Read more</strong>
    ”: it is “<strong>article/details/<em>this.id</em></strong>”. This means
that every article we want to display will have a unique    <strong>route</strong> (URL), based on the <strong>article’s id</strong>.
    This is how our <strong>controller</strong> can get information about the
    article we want to see. We will go deeper in the next chapter.
</p>
<p>
    Here is how the article should appear in our homepage:
</p>
<p>
Summary: We now know how we can <strong>iterate</strong> over an    <strong>object</strong> in our <strong>view</strong> engine. Also, we saw
    the basics of “<strong>populating</strong>” a <strong>relation</strong>
    property.
</p>
<h2>
    2. Details Articles
</h2>
<p>
    Have you noticed the “<strong>Read more</strong>” button? Let’s implement
    it. We want to display <strong>more detailed information</strong> about the
    specific article when we click on it.
</p>
<p>
    Again, our first step is to <strong>generate the view</strong>. This means
that we have to create a file named “<strong>details.hbs</strong>” in our “    <strong>views/article</strong>” folder:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"container body-content"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"row"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-md-12"</strong>&gt;
                    <br/>
                    &lt;<strong>article</strong>&gt;
                    <br/>
                    &lt;<strong>header</strong>&gt;
                    <br/>
&lt;<strong>h2</strong>&gt;{{<strong>title</strong>}}&lt;/                    <strong>h2</strong>&gt;
                    <br/>
                    &lt;/<strong>header</strong>&gt;
                    <br/>
                    <br/>
                    &lt;<strong>p</strong>&gt;
                    <br/>
                    {{<strong>content</strong>}}
                    <br/>
                    &lt;/<strong>p</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>small </strong><strong>class=</strong>                    <strong>"author"</strong>&gt;
                    <br/>
                    {{<strong>author</strong>.<strong>fullName</strong>}}
                    <br/>
                    &lt;/<strong>small</strong>&gt;
                    <br/>
                    <br/>
                    &lt;<strong>footer</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"pull-right"</strong>&gt;
                    <br/>
&lt;<strong>a </strong><strong>class=</strong><strong>"btn btn-default btn-xs" </strong><strong>href=</strong><strong>"/"</strong>&gt;Back                    <strong>&amp;raquo;</strong>&lt;/<strong>a</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>footer</strong>&gt;
                    <br/>
                    &lt;/<strong>article</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    We have the view, now let’s use it in our controller:
</p>
<p>
    Whenever we want to so see the <strong>details</strong> of an article, it’s
    only logical to <strong>tell the server</strong> which article we want to
    see. This information will be sent through the <strong>URL</strong>. In the
    URL, we will pass the <strong>article’s “id”</strong> (we already did in
    the “<strong>index.hbs</strong>”). Once we get that “<strong>id</strong>”
on the server side, we can <strong>find</strong> the specific<strong>article</strong> by its <strong>id</strong> and then    <strong>pass it</strong> on to the <strong>view engine</strong>.
</p>
<p>
    How do we get the information from the link? We will use req.params. But
first let’s look how our routing will look in “<strong>routes.js</strong>”    <strong>:</strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    Just add the “<strong>/article/details/:id</strong>” part. This means that
    in the end of our link, we are expecting a <strong>parameter</strong> named
“<strong>id</strong>”. Later on when using req.params, we can    <strong>access</strong> that parameter by just <strong>getting</strong> its
    name as a property of the req.params object.
</p>
<p>
    So, if we want to get a parameter with the name “<strong>id</strong>”, we
    will write req.params.id. This is how we get <strong>parameters</strong>
from our <strong>URL</strong> (<em>note: </em><em>req.params</em>    <em> is different from </em><em>req.body</em>).
</p>
<p>
Let’s implement the details page in <strong>article</strong>    <strong>controller </strong>(<strong>article.js</strong>):
</p>
<p>
    Now everything should be implemented and we should be able to get an
    article’s details when we press the <strong>read more</strong> button next
    to an article!
</p>
<p>
    <strong>Summary</strong>
: We saw how to <strong>display</strong> more <strong>detailed</strong><strong>information</strong> about an <strong>article</strong>. We<strong>passed</strong> the needed <strong>parameters</strong> in our<strong>URL</strong>, which we can easily work with from the<strong>server’s side</strong>. This way we can get    <strong>information</strong> about an <strong>article</strong> by just
    giving the server its <strong>id</strong>.
</p>
<p>
    Congratulations, you’ve just implemented a basic blog system, using Note.JS
as a <strong>server</strong>, ExpressJS as a router, Mongoose as an    <strong>ORM</strong>, MongoDB as a <strong>database</strong> and Handlebars
    as a <strong>view engine</strong>! Feel free to implement any additional
    functionality using your newfound knowledge (try to implement profile view
    for every user). Happy coding! J
</p>