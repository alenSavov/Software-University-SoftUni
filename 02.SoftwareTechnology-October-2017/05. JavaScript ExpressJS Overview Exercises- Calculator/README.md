<p>
    Lab: Calculator using Javascript and ExpressJS
</p>
<p>
This document defines a complete walkthrough of creating a<strong>Calculator</strong> application with the    <a href="http://expressjs.com/">Express.js</a> Framework, from setting up
    the framework, to implementing the models, views and controllers necessary
    for our application to function.
</p>
<p>
    Make sure you have already gone through the
    <a
        href="https://softuni.bg/downloads/svn/soft-tech/Sep-2016/Software-Technologies-Oct-2016/06.%20JS-Blog-Basic-Functionality/06.%20Software-Technologies-JS-Blog-Getting-Started.docx"
    >
        Getting Started: JavaScript
    </a>
guide. In this guide we will be using:    <a href="https://www.jetbrains.com/webstorm/">WebStorm</a>. You can
    download the <strong>calculator’s skeleton</strong> from
    <a
        href="http://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/07.%20Software-Technologies-JavaScript-ExpressJS-Overview/07.%20Software-Technologies-JavaScript-ExpressJS-Overview-Lab-Calculator-Skeleton.zip"
    >
        here
    </a>
    . The rest of the needed non-optional software is described in the guide
    above.
</p>
<h1>
    I. Base Project Overview
</h1>
<p>
Node.js is a <strong>platform</strong> written in    <strong>JavaScript</strong> and provides <strong>back-end</strong>
    functionality. Express is a <strong>module </strong>(for now we can
    associate module as a <strong>class</strong> which provides some
    functionality), which wraps Node.js in way that makes coding faster and
    easier and it is suitable for the <strong>MVC</strong> architecture.
</p>
<p>
    Initially the project comes with the following structure:
</p>
<p>
    We can see several folders here. Let look at them one by one and see what
    are they for:
</p>
<p>
    1. bin <strong>– </strong>Contains a single file named <strong>www</strong>
    , which is the <strong>starting point</strong> of our program. The file
    itself contains some <strong>configuration</strong> logic needed to run the
    server <strong>locally</strong>.<strong></strong>
</p>
<p>
    2. node_modules (library root) – As far as the name tells us, in this
    folder we put every library (<strong>module</strong>) that our project
    depends on.<strong></strong>
</p>
<p>
3. public – Everything in our <strong>public</strong> folder (<strong>files</strong>, <strong>images</strong>, etc.) will be    <strong>accessible</strong> by <strong>every user</strong>. We’ll cover on
    that later.<strong></strong>
</p>
<p>
    4. routes<strong> </strong>–<strong> </strong>A<strong> </strong>folder in
    which we will put our <strong>route</strong> configurations. We’ll find out
    what a <strong>route</strong> is in a bit.
</p>
<p>
    5. views<strong> – </strong>Like in the previous calculator (in PHP), we
    again have a folder named <strong>views</strong>. There, we will store the
views for our model. Again, we will use templates with the help of the<strong>Handlebars</strong> view engine (last time we used    <strong>Twig</strong>).
</p>
<p>
6. app.js – The script containing the logic needed to    <strong>start the server</strong>.
</p>
<p>
7. package.json – a file containing project information (like the project's    <strong>name</strong>, <strong>license</strong> etc.). The most important
    thing is that there is a "<strong>dependencies</strong>" part, where all
    the names and versions of every module that our projects uses will reside.
</p>
<p>
    Let’s see what we have in the skeleton before we start working on it:
</p>
<h2>
    1. Open the Project
</h2>
<p>
    Let’s go ahead and load the skeleton. Click “<strong>Open</strong>“, and
    find the downloaded and unzipped skeleton project:
</p>
<p>
    This is our Node.js project. In the previous steps, we described on how we
    got here. Now let’s talk about <strong>Node.JS</strong>:
</p>
<p>
As we know, it’s a <strong>platform</strong> written in    <strong>Javascript</strong>, providing <strong>back-end</strong>
functionality. This gives us a lot of flexibility, because our    <strong>front-end</strong> usually uses <strong>JavaScript </strong>as
    well. This makes mutual <strong>communication</strong> easier.
</p>
<p>
    Furthermore, Node.JS is fast because it uses C++ behind the scenes and also
    because it’s capable of making asynchronous calls. It uses the
    <a href="https://www.tutorialspoint.com/nodejs/nodejs_event_loop.htm">
        event loop system
    </a>
    .
</p>
<p>
    Summary: we have downloaded the project and we are ready to start writing
    code!
</p>
<h2>
    2. Run the Project
</h2>
<p>
    Now that we’ve opened the project, let’s try running it, so we can see what
    we’re working with. Go to the top right of WebStorm, where you’ll find a
    Run button, which looks like a green play button:
</p>
<p>
    That’s how we’ll start our Express app. Go ahead and click the button. If
    everything goes according to plan, we should see this message on the
    console:
</p>
<p>
    Now we can open the page and see what we have:
</p>
<p>
    <br clear="all"/>
    It doesn’t look like much, but at least we have the basic layout down!
    Let’s get to work on implementing some functionality!
</p>
<h1>
    II. Implementing Functionality
</h1>
<h2>
    1. Create Calculator View
</h2>
<p>
    Before we can have any functionality, it would be nice to have an idea of
what we’re working against, so let’s go ahead and <strong>create</strong> a<strong>form</strong>, which the <strong>user</strong> will use for    <strong>calculations</strong>:
</p>
<p>
    Go into the <strong>views/home</strong> folder and open the index.hbs file:
</p>
<p>
    It’s empty?! How does the header and footer seen above get displayed then?
The answer is, we use a <strong>global</strong> <strong>layout</strong>    <strong>file</strong>, so we don’t have to copy-paste our page layout into
every single view in our project (which could have <strong>tens</strong> or<strong>hundreds</strong> of views). All the    <strong>actual design HTML</strong> is inside layout.hbs. We won’t be
    touching that, so let’s go to the index.hbs file and add our form:
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
&lt;<strong>form </strong><strong>class=</strong><strong>"form-inline" </strong><strong>action=</strong><strong>"/" </strong><strong>method=</strong>                    <strong>"POST"</strong>&gt;
                    <br/>
                    &lt;<strong>fieldset</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-1 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"leftOperand" </strong>                    <strong>placeholder=</strong>
                    <strong>
                        "Left Operand"
                        <br/>
                    </strong>
                    <strong>name=</strong>
                    <strong>"calculator[leftOperand]" </strong>
                    <strong>value=</strong>
                    <strong>"</strong>
                    {{<strong>calculator</strong>.<strong>leftOperand</strong>
                    }}<strong>"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong><strong>"</strong><strong>col-sm-4</strong>                    <strong> "</strong>&gt;
                    <br/>
&lt;<strong>select </strong><strong>class=</strong><strong>"form-control" </strong><strong>name=</strong>                    <strong>"calculator[operator]"</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"+"</strong>{{<strong>selectif calculator</strong>.<strong>operator </strong><strong>'+'</strong>}}&gt;+&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"-"</strong>{{<strong>selectif calculator</strong>.<strong>operator </strong><strong>'-'</strong>}}&gt;-&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"*"</strong>{{<strong>selectif calculator</strong>.<strong>operator </strong><strong>'*'</strong>}}&gt;*&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"/"</strong>{{<strong>selectif calculator</strong>.<strong>operator </strong><strong>'/'</strong>}}&gt;/&lt;/                    <strong>option</strong>&gt;
                    <br/>
                    &lt;/<strong>select</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong><strong>"</strong><strong>col-sm-4</strong>                    <strong> "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"rightOperand" </strong>                    <strong>placeholder=</strong>
                    <strong>
                        "Right Operand"
                        <br/>
                    </strong>
                    <strong>name=</strong>
                    <strong>"calculator[rightOperand]" </strong>
                    <strong>value=</strong>
                    <strong>"</strong>
                    {{<strong>calculator</strong>.<strong>rightOperand</strong>
                    }}<strong>"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-2 "</strong>&gt;
                    <br/>
                    &lt;<strong>p</strong>&gt;=&lt;/<strong>p</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong><strong>"</strong><strong>col-sm-4</strong>                    <strong> "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong>                    <strong>"result" </strong><strong>placeholder=</strong>
                    <strong>
                        "Result"
                        <br/>
                    </strong>
                    <strong>name=</strong>
                    <strong>"result" </strong>
                    <strong>value=</strong>
                    <strong>"</strong>
                    {{<strong>result</strong>}}<strong>"</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong><strong>"</strong><strong>col-sm-4</strong>                    <strong> col-sm-offset-4"</strong>&gt;
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"submit" </strong><strong>class=</strong><strong>"btn btn-primary"</strong>&gt;Calculate&lt;/                    <strong>button</strong>&gt;
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
    Just like with the PHP blog, we will <strong>save the state</strong> of the
operands and operator for ease of use, so the    <strong>handlebars syntax </strong>you see here does just that. The
    {{selectif}} helper is a bit more special: it selects the operator from the
    dropdown list, <strong>based on</strong> the last used operator. We’ll see
    how that’s implemented a bit later. For now, let’s navigate to our web app
    at <a href="http://localhost:3000/">http://localhost:3000</a> and see how
    we’re doing:
</p>
<p>
    Looking good! Except it doesn’t do anything. First, let’s get down to
    making the thing, which will hold our data: the <strong>model</strong>.
</p>
<h2>
    2. Create Calculator Model
</h2>
<p>
    It’s time to design our main model – the <strong>Calculator</strong>. It
    will contain the following properties:
</p>
<ul>
    <li>
        leftOperand
    </li>
    <li>
        operator
    </li>
    <li>
        rightOperand
    </li>
</ul>
<p>
Let’s create our model in the <strong>JavaScript</strong> way. Since we’re    <strong>not</strong> using a database in this exercise, we’re just going to
    define the calculator as a <strong>simple JavaScript class</strong>.
</p>
<p>
Create a folder, called “<strong>models</strong>” and inside it, create a    <strong>JavaScript</strong> file, named “<strong>Calculator.js</strong>”:
</p>
<p>
Now, let’s write the code, which will define our    <strong>Calculator</strong> model:
</p>
<p>
    1. Create a function, which will be called upon creating a new calculator
    instance:
    <br/>
</p>
<p>
2. Inside it,<strong> define</strong> the calculator    <strong>properties</strong>:
</p>
<p>
    3. Create a <strong>function</strong> for <strong>calculating</strong> the
    result from the <strong>properties</strong>:
    <br/>
    <br/>
    Inside this function, we’ll write the logic, which is needed for
    calculating the result from the operands and operator. Let’s create the
    logic, needed for that:
</p>
<p>
    4. Write the calculation logic:
    <br/>
</p>
<p>
5. Almost done: <strong>export</strong> our model so it can be    <strong>visible</strong> for the <strong>outer world</strong> (outside of
    the <strong>Calculator.js</strong> file):
</p>
<p>
    6.
</p>
<p>
    Summary: We now know how to create a simple model and make it visible to
    the outside world.
</p>
<h2>
    3. Add a Route, which Calls the Controller Action
</h2>
<p>
    As for the routing – with <strong>ExpressJS</strong>, all our routing logic
    is usually located within a file, called <strong>routes.js</strong>. Here’s
    what that currently looks like:
</p>
<p>
    Let’s break this code down into understandable chunks:
</p>
<p>
    · const homeController = require('./../controllers/home')
</p>
<p>
    This bit of code <strong>imports</strong> our controller’s logic. Before we
can <strong>call</strong> any methods, we need to know those methods    <strong>exist</strong>, right?
</p>
<ul>
    <li>
        module.exports
    </li>
</ul>
<p>
This is the piece of code which takes the code inside it and    <strong>exposes</strong> it to the outside world. We’re putting our code
    here, because Node.JS needs to have <strong>access</strong> to it, so it
can <strong>execute the action</strong> when our user    <strong>calls</strong> the specified <strong>route</strong> (examples:
    /calculate, /edit/2, /login).
</p>
<p>
    · app.get('/', homeController.indexGet)
</p>
<p>
This piece of code tells Node.JS to <strong>listen</strong> for any    <strong>GET requests</strong> on the “<strong>/</strong>” route, and when
    it finds one – to execute the homeController.indexGet method (this is why
    we needed to <strong>import</strong> the <strong>home controller</strong>
    up there using require().
</p>
<p>
Now that we’ve understood how the <strong>routing system</strong> in<strong>Express.JS</strong> works, it’s time to <strong>add</strong> our<strong>own route</strong>, which calls our own <strong>controller</strong>    <strong>action</strong>, which gets the data from the user and uses it to
    calculate the result.
</p>
<p>
    Since we’re going to be sending out <strong>form data</strong> to the
server, we’re going to be using a <strong>HTTP</strong>    <strong>POST</strong> <strong>request</strong> to do it. Hence, we need to
    tell <strong>routes.js</strong> to expect <strong>POST requests</strong>
    and <strong>execute </strong>the appropriate controller action:
</p>
<p>
    We just made a <strong>route</strong>, which listens on “<strong>/</strong>
”, and upon matched, executes the indexPost action inside the<strong>home controller</strong>. That’s alright, but the problem is we    <strong>don’t have</strong> an action with that name yet. So, guess what
    happens if we try to send a form to the server:
</p>
<p>
    Not so great. For our final trick, we’ll create our own controller action,
which will <strong>process</strong> what the user sent us and<strong>return</strong> a <strong>view</strong> with the    <strong>result</strong> from the calculation.
</p>
<h2>
    4. Implement the Controller Action
</h2>
<p>
Now that we’ve created the <strong>view</strong>, which will<strong>hold our data</strong> and allow the <strong>user</strong> to    <strong>interact</strong> with our web application, it’s time to create the
    driving force behind the whole app – <strong>the controller</strong>.
</p>
<p>
    As it turns out, we already have a <strong>home controller</strong> set up,
    and an action, set up on the “<strong>/</strong>” route, otherwise we
wouldn’t even be able to see our calculator. You can find the    <strong>home controller</strong> in the “<strong>controllers</strong>”
    folder. Let’s see what it looks like:
</p>
<p>
    Not much going on here… Let’s break it down:
</p>
<p>
· module.exports è the piece of code, which takes the code inside it and    <strong>exposes</strong> it to the outside world. We’re putting our code
here, because the <strong>router</strong> needs to have<strong>access</strong> to it, so it can    <strong>execute the action</strong> when our user <strong>calls</strong>
    the specified <strong>route</strong> (right now, that’s “<strong>/</strong>
    ”).
</p>
<p>
· indexGet: (req, res) è This is the actual<strong>controller action</strong>. It’s a function, which<strong>holds the</strong> <strong>logic</strong>, which will be<strong>executed</strong>, when it’s <strong>called</strong>. It’s    <strong>no different</strong> than a <strong>regular method</strong>.
    <br/>
It has 2 parameters: req and res. They hold data about the<strong>HTTP</strong> <strong>request</strong> and <strong>HTTP</strong><strong>response</strong> respectively. They’ll be used for<strong>getting data</strong> from the user and also doing things such as    <strong>rendering views</strong> in the <strong>response</strong>. Remember
    – all we’re doing here is returning different <strong>HTML code</strong>,
    based on the logic we’ve implemented in our app.
</p>
<p>
· res.render('home/index') è This function <strong>renders</strong> a    <strong>view</strong> in the <strong>response</strong> (in essence, takes
whatever’s inside of “home/index.hbs”, runs it through the    <strong>Handlebars</strong> templating engine, and returns it back to the
    user.
</p>
<p>
So, using this newfound knowledge, let’s try to create our own    <strong>action</strong>.
</p>
<p>
    First, we’ll start off by declaring the action:
</p>
<p>
    As we know from above, we have req and res parameters. We’ll use the req
    parameter to get the data from the <strong>request</strong>. That’s the
    data the user <strong>sent us</strong> through the <strong>form</strong>.
    We can get a hold of that data by accessing req.body:
</p>
<p>
    Before we continue, let’s see what that property would hold if we looked at
    it during a <strong>debug session</strong>:
</p>
<p>
    The data comes through the request as a <strong>calculator</strong>
    variable. Why does that happen? Well, let’s look at what data we’re sending
the server with a tool like <strong>Chrome Developer Tools</strong>    <strong>(F12)</strong>:
</p>
<p>
The form has a <strong>calculator variable</strong> with    <strong>3 values</strong>, sent as <strong>strings</strong>. And as such,
    that comprises the <strong>request body</strong> – something we can access
    by using the req.body property. Let’s go back into our controller action
    and <strong>process</strong> the data.
</p>
<p>
We can access the properties of the calculator by accessing the<strong>request</strong> <strong>body</strong> and getting the    <strong>calculator</strong> as a key:
</p>
<p>
    Accessing calculatoryBody’s values by the “<strong>calculator</strong>” key
    is the same as just writing “req.body['calculator']”, but we’re extracting
    every step into variables for clarity.
</p>
<p>
    Before we can use our <strong>calculator model</strong>, we need to tell
    the controller that it exists. We’ll do that by <strong>importing</strong>
    it, using require() at the <strong>top</strong> of the file:
</p>
<p>
    Next, we need to create an <strong>instance</strong> of our calculator
    model, which we’ll use for storing the data inside:
</p>
<p>
We use the Number() function to convert the operands from    <strong>strings</strong> to <strong>numbers</strong>. Now that we’ve gotten
    the data, it’s time to calculate the result from what we currently have.
    Remember that calculateResult() function we wrote a while ago? Now’s the
    time to use it:
</p>
<p>
After that, all we have left is to <strong>render</strong>    <strong>the view</strong>. We can do that by using the render function
    inside the res (response) method parameter:
</p>
<p>
    Let’s break down what res.render() does:
</p>
<ul>
    <li>
        'home/index'
        <br/>
        This parameter specifies which view to return.
    </li>
</ul>
<p>
    · {'calculator': calculator, 'result': result}
    <br/>
    This parameter is a <strong>JavaScript Object</strong>, which specifies
    what we’re going to <strong>send</strong> to <strong>the view </strong>(in
    our well-known key -&gt; value pairs).
    <br/>
So, when we send over the <strong>calculator object</strong> and the<strong>result value</strong> to the view, we can <strong>fill</strong> the    <strong>form fields</strong> with our data. This happens here:
    <br/>
</p>
<p>
We use the data from the controller in the home/index.hbs view to set the    <strong>values </strong>of the form inputs to whatever we want. In this
case, we set the <strong>operands</strong>, and select the last used    <strong>operator</strong>.
</p>
<h1>
    III. Test the Application
</h1>
<p>
    All our hard work should finally pay off now, right? If you’ve followed all
the steps properly, and    <strong><em>read all the explanatory text</em></strong>, hopefully we
    should have a functioning calculator!
</p>
<h1>
    IV. * Implement Extra Functionality
</h1>
<p>
Just like last time, you’re free to implement extra functionality like    <strong>extra operators</strong>, <strong>input validation</strong>, and
    whatever else you can think of. Happy coding. J
</p>
<p>
    Next time we’ll be using the same logic as the one in this lab to implement
a <strong>fully functioning blog system</strong>, with a<strong>database</strong> behind it for storing everything and even    <strong>user authentication</strong> and <strong>security</strong>. Have
    fun with JS! J
</p>