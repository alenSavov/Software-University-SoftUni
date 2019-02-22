<p>
    Calculator: Java and Spring
</p>
<p>
This document defines a complete walkthrough of creating a<strong>Calculator</strong> application with the    <a href="http://spring.io/">Spring</a> Framework, from setting up the
    framework to implementing the fully functional application.
</p>
<h1>
    I. Setting Up JDK and IntelliJ Idea Configuration
</h1>
<p>
    Before we start, you need to download the
    <a
        href="http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html"
    >
        Java Development Kit
    </a>
, also known as <strong>JDK</strong>. Download the "    <strong>Java SE Development Kit 8u141</strong>". After downloading it,
    install it <strong>without changing the installation directory</strong>.
The default configuration will install it in the "<strong>Program Files\Java</strong>" folder if you’re running    <strong>Windows</strong>.
</p>
<h2>
    1. Set Up JDK
</h2>
<p>
    If you are using the skeleton and see something like this:
</p>
<p>
    You should set-up the SDK. Click on "<strong>Setup SDK</strong>". You
    should see this screen:
</p>
<p>
    Click on "<strong>Configure</strong>" and see if you receive this screen:
</p>
<p>
    Click on the <strong>green plus sign</strong> in the top left corner of the
    window and choose <strong>JDK</strong>:
</p>
<p>
Then <strong>locate your JDK</strong>, it should be in the "<strong>Program Files</strong>" <strong>folder</strong> if you're using    <strong>windows</strong>:
</p>
<p>
    After you click "<strong>OK</strong>", you should see this screen:
</p>
<p>
    That’s everything, your <strong>JDK is now configured</strong>.
</p>
<h1>
    II. Base Project Overview
</h1>
<h2>
    2. Open the Project
</h2>
<p>
    When you open the
    <a
        href="http://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/09.%20Software-Technologies-Java-Syntax-and-Basic-Web/09.%20Software-Technologies-Java-Syntax-Basic-Web-Calculator-Skeleton.zip"
    >
        project
    </a>
    you might see the following window in the lower right corner of IntelliJ
    IDEA:
</p>
<p>
Click on "<strong>Enable Auto-Import</strong>". It is<strong>really important</strong> and if you miss this step, the<strong>project might not work</strong> as    <strong>you would expect</strong>.
</p>
<p>
    In our
    <a
        href="http://softuni.bg/downloads/svn/soft-tech/May-2017/Software-Technologies-July-2017/09.%20Software-Technologies-Java-Syntax-and-Basic-Web/09.%20Software-Technologies-Java-Syntax-Basic-Web-Calculator-Skeleton.zip"
    >
        project
    </a>
    , there is only one folder we're interested in. That would be the “src”
folder. That folder will <strong>contain all the files</strong> we are    <strong>going to create</strong>. Let's take a look:
</p>
<p>
    We can see several folders here. Let look at them one by one and see what
    they are for:
</p>
<p>
1. src<strong> </strong>–<strong> </strong>Contains all the<strong>source</strong> files of our applications, including<strong>templates</strong>, <strong>models</strong> (entities) and    <strong>controllers</strong>.<strong></strong>
</p>
<p>
2. src/main/resources/static – Everything that’s in our    <strong>static folder</strong> (files, images, stylesheets, JavaScript
scripts, etc.) will be <strong>accessible</strong> by    <strong>every user</strong>.<strong></strong>
</p>
<p>
3. src/main/java/{packageName}/…<strong> – </strong>we’ll store all our    <strong>back-end logic</strong> (controllers, entities, etc.) here (in
    separate folders, of course).
</p>
<p>
4. src/main/resources/templates – we’ll store our<strong>view templates </strong>here. We’ll be using the template engine    <strong>Thymeleaf</strong>.
</p>
<h2>
    3. Run the Project
</h2>
<p>
    Now that we’ve opened the project, let’s try running it, so we can see what
we’re working with. Go to the <strong>top right</strong> corner of    <strong>IntelliJ Idea</strong>, where you’ll find a <strong>Run</strong>
    button, which looks like a <strong>green play button</strong> (be patient –
    the first build may take a while due to resolving dependencies):
</p>
<p>
That’s how we’ll run our Spring app. Go ahead and click the    <strong>play</strong> <strong>button</strong>. If everything goes according
    to plan, we should see this message in the console:
</p>
<p>
    Now we can open the page (at <strong>localhost:8080</strong>) and see what
    we have:
</p>
<p>
    <br clear="all"/>
    It doesn’t look like much, but at least we have the basic layout down!
    Let’s get to work on implementing some functionality!
</p>
<h1>
    III. Implementing Functionality
</h1>
<h2>
    4. Create Calculator View
</h2>
<p>
    Before we start adding functionality, it would be nice to have an idea of
what we’re working against, so let’s go ahead and <strong>create</strong> a<strong>form</strong>, which the <strong>user</strong> will use for    <strong>calculations</strong>:
</p>
<p>
    Go into the src/main/resources/templates/views/ folder and open the
    calculatorForm.html file:
</p>
<p>
    It’s empty?! How does the header and footer seen above get displayed then?
    The answer is, we use a global <strong>layout</strong> file
    (base-layout.html), so we don’t have to copy-paste our page layout into
every single view in our project (which could have <strong>tens</strong> or<strong>hundreds</strong> of views). All the    <strong>actual base design HTML</strong> is inside base-layout.html. We
    won’t be touching that, so let’s go to the calculatorForm.html file and add
    our form:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
&lt;<strong>form </strong><strong>class=</strong><strong>"form-inline" </strong><strong>th</strong><strong>:action=</strong><strong>"@{/}" </strong>                    <strong>method=</strong><strong>"POST"</strong>&gt;
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
                    <strong>"leftOperand" </strong>
                    <strong>th</strong>
                    <strong>:value=</strong>
                    <strong>"${leftOperand}"</strong>
                    /&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>select </strong><strong>class=</strong><strong>"form-control" </strong><strong>name=</strong>                    <strong>"operator"</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"+" </strong><strong>th</strong><strong>:selected=</strong><strong>"${operator.equals('+')}"</strong>&gt;+&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"-" </strong><strong>th</strong><strong>:selected=</strong><strong>"${operator.equals('-')}"</strong>&gt;-&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"*" </strong><strong>th</strong><strong>:selected=</strong><strong>"${operator.equals('*')}"</strong>&gt;*&lt;/                    <strong>option</strong>&gt;
                    <br/>
&lt;<strong>option </strong><strong>value=</strong><strong>"/" </strong><strong>th</strong><strong>:selected=</strong><strong>"${operator.equals('/')}"</strong>&gt;/&lt;/                    <strong>option</strong>&gt;
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
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong><strong>"rightOperand" </strong>                    <strong>placeholder=</strong>
                    <strong>
                        "Right Operand"
                        <br/>
                    </strong>
                    <strong>name=</strong>
                    <strong>"rightOperand" </strong>
                    <strong>th</strong>
                    <strong>:value=</strong>
                    <strong>"${rightOperand}"</strong>
                    /&gt;
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
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"col-sm-4 "</strong>&gt;
                    <br/>
&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>class=</strong><strong>"form-control" </strong><strong>id=</strong>                    <strong>"result" </strong><strong>placeholder=</strong>
                    <strong>
                        "Result"
                        <br/>
                    </strong>
                    <strong>name=</strong>
                    <strong>"result" </strong>
                    <strong>th</strong>
                    <strong>:value=</strong>
                    <strong>"${result}"</strong>
                    /&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    <br/>
&lt;<strong>div </strong><strong>class=</strong>                    <strong>"form-group"</strong>&gt;
                    <br/>
&lt;<strong>button </strong><strong>type=</strong><strong>"submit" </strong><strong>class=</strong><strong>"btn btn-primary"</strong>&gt;Calculate&lt;/                    <strong>button</strong>&gt;
                    <br/>
                    &lt;/<strong>div</strong>&gt;
                    <br/>
                    &lt;/<strong>fieldset</strong>&gt;
                    <br/>
                    &lt;/<strong>form</strong>&gt;
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Just like with the JavaScript blog, we will <strong>save the state</strong>
of the operands and operator for ease of use, so the    <strong>Thymeleaf syntax </strong>you see here does just that. The
th:selected="" template is a bit more special: it    <strong>automatically</strong> <strong>selects</strong> the operator from
    the dropdown list, <strong>based on</strong> the last used operator. We’ll
    see how that’s implemented a bit later. For now, let’s navigate to our web
    app at <a href="http://localhost:8080/">http://localhost:8080</a> and see
    how we’re doing:
</p>
<p>
    Still nothing?! The reason our form doesn’t display is because we’re not
    sending the <strong>form view</strong> to the user. To add the form to our
    project, we need to do two things: The first thing is to add this line of
    code in base-layout.html:
</p>
<p>
    This line of code expects to be fed a <strong>template</strong> to display
    around the header and footer. So, we’re going to do just that. Go into the
    HomeController.java file and check out what the <strong>index </strong>
    action does:
</p>
<p>
    All this action does is listen on the “<strong>/</strong>” (site root)
    route, and display the <strong>base-layout</strong> view. But before it
displays it, it <strong>adds an attribute</strong> to the model. The<strong>model</strong> is the <strong>data</strong> that’s fed to the    <strong>view</strong>, so it can perform various functions (such as
    displaying the calculator’s operands, operator, etc.). We’re going to give
    the <strong>view</strong> one more <strong>attribute</strong>. Remember
that ${view} template the <strong>base-layout</strong> expects? Let’s    <strong>add</strong> it here <strong>before</strong> returning the base
    layout view:
</p>
<p>
    We’ve given it the view, so let’s get <strong>restart</strong> our Spring
    application and see how we’re doing:
</p>
<p>
    Looking good! Except it doesn’t do anything. First, let’s get down to
    making the thing, which will hold our data: the <strong>model</strong>.
</p>
<h2>
    5. Create Calculator Model
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
    Let’s create our mode. Since we’re <strong>not</strong> using a database in
this exercise, we’re just going to define the calculator as a    <strong>simple Java class</strong>.
</p>
<p>
Go into the entity folder and create a new Java class, called “    <strong>Calculator.java</strong>”:
</p>
<p>
    Now, let’s define what our class will have:
</p>
<p>
    1. Create <strong>fields</strong>, which will be used internally in the
    class:
    <br/>
</p>
<p>
    2. <strong>Define</strong> the calculator <strong>properties</strong>:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="278">
            </td>
            <td width="29">
                <p align="center">
                    à
                </p>
            </td>
            <td width="257">
            </td>
        </tr>
    </tbody>
</table>
<p>
    3. Create a <strong>constructor</strong> for <strong>instantiating</strong>
    the calculator:
    <br/>
</p>
<p>
4. Create <strong>getters </strong>and<strong> setters</strong> for the    <strong> </strong>Calculator’s<strong> fields</strong> (you can make them
    with <strong>[Alt + Insert]</strong>)
</p>
<p>
    5. Create a <strong>method</strong> for <strong>calculating</strong> the
    result from the <strong>properties</strong>:
    <br/>
    <br/>
    Inside this method, we’ll write the logic, which is needed for calculating
    the result from the operands and operator. Let’s create the logic, needed
    for that.
</p>
<p>
    6. Write the calculation logic:
    <br/>
</p>
<p>
    Our calculator logic is neatly nested inside the Calculator class. Now all
    that’s left is to connect it to the rest of our little web application.
</p>
<p>
For our final trick, we’ll create our own controller action, which will    <strong>process</strong> what the user sent us and <strong>return</strong>
    a <strong>view</strong> with the <strong>result</strong> from the
    calculation.
</p>
<h2>
    6. Implement the Controller Action
</h2>
<p>
Now that we’ve created the <strong>view</strong>, which will<strong>hold our data</strong> and allow the <strong>user</strong> to    <strong>interact</strong> with our web application, it’s time to implement
the driving force behind the whole app –    <strong>the controller action</strong>.
</p>
<p>
    As it turns out, we already have a <strong>home controller</strong> set up,
    and an action, set up on the “<strong>/</strong>” route, otherwise we
wouldn’t even be able to see our calculator. You can find the    <strong>home controller</strong> in the “<strong>controller</strong>”
    folder. Let’s see what it looks like:
</p>
<p>
    Not much going on here… Let’s break it down:
</p>
<p>
    · @GetMapping("/") è the piece of code, which binds a URL Route to a
method, so it can <strong>execute the action</strong> when our user    <strong>calls</strong> the specified <strong>route</strong> (right now,
    that’s “<strong>/</strong>”).
</p>
<p>
· public String index(Model model) è This is the actual<strong>controller action</strong>. It’s a method, which<strong>holds the</strong> <strong>logic</strong>, which will be    <strong>executed</strong>, when it’s <strong>called</strong>.
    <br/>
    It has one parameter: model – it holds the data, which will be passed to
    the <strong>view</strong> for processing. Remember – all we’re doing here
    is returning different <strong>HTML</strong>, based on the logic we’ve
    implemented in our app.
</p>
<p>
· model.addAttribute(String, String) è this piece of code takes<strong>2 parameters</strong> – the <strong>first</strong> states the<strong>name</strong> of the <strong>attribute</strong> we’re going to<strong>send</strong> to the <strong>view</strong>. The    <strong>second</strong> one – the <strong>actual data</strong>.
</p>
<p>
· return "base-layout" è This function <strong>renders</strong> a    <strong>layout</strong> in the <strong>response</strong> (in essence, takes
whatever’s inside of “templates/base-layout.html”, runs it through the    <strong>Thymeleaf</strong> templating engine, and returns it to the user.
</p>
<p>
So, using that newfound knowledge, let’s try to create our own    <strong>action</strong>.
</p>
<p>
First, we’ll start off by declaring what kind of    <strong>HTTP method</strong> this method will be handling (either GET or
    POST). In our case, since we’re processing <strong>form data</strong> sent
    to the “<strong>/</strong>” URL, we’ll set it to @PostMapping("/"):
</p>
<p>
    After that, let’s declare our method. We’ll use a couple of new types here
    – RequestParam. That’s just a fancy way of getting the form data:
</p>
<p>
    All this method should do at this point is just return the base-layout
    template with the <strong>form attribute</strong> inside of it:
</p>
<p>
    Let’s see what a debug session would show us if we were to debug this
    method:
</p>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="508" valign="top">
            </td>
        </tr>
        <tr>
            <td width="508" valign="top">
            </td>
        </tr>
        <tr>
            <td width="508" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
The leftOperand, operator, and rightOperand variables come in the form of<strong>strings</strong>. So, before we feed them to our    <strong>calculator</strong> class, we need to <strong>parse</strong> them
    as numeric variables, using <strong>try-catch</strong> blocks:
</p>
<p>
This will ensure, that if the user tries to send us    <strong>invalid data</strong>, it’ll be set to <strong>zero</strong>
    instead.
</p>
<p>
    Next, we need to create an <strong>instance</strong> of our calculator
    model, which we’ll use for storing the data inside:
</p>
<p>
    We can set its data, using its constructor, which we defined in step 4. Now
    that we’ve gotten the data, it’s time to calculate the result from what we
    currently have. Remember that calculateResult() function we wrote a while
    ago? Now is the time to use it:
</p>
<p>
After that, all we have left is to <strong>send the result to the</strong>    <strong>view</strong>. Apart from the result, we also need to send the
leftOperand, rightOperand and operator, so we can    <strong>save the state </strong>of our calculator through requests. We can
    do that, using the model.addAttribute function:
</p>
<p>
    <br/>
This way, we specify what we’re going to <strong>send</strong> to<strong>the view</strong>. So, when we send over the    <strong>result value</strong> and the previous state of the calculator to
    the view, we can <strong>fill</strong> the <strong>form fields</strong>
    with our data. This happens here:
    <br/>
    <br/>
    We use the data from the controller in the views/calculatorForm.html view
    to set the <strong>values </strong>of the form inputs to whatever we want.
    In this case, we set the <strong>operands</strong>, and select the last
    used <strong>operator</strong>.
</p>
<h1>
    IV. Test the Application
</h1>
<p>
    All our hard work should finally pay off now, right? If you’ve followed all
    the steps properly, and have read all the explanatory text, hopefully we
    should have a functioning calculator!
</p>