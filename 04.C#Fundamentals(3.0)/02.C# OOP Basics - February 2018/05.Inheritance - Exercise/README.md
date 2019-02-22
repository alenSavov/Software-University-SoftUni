<h1 align="center">
    Exercises: Inheritance
</h1>
<p>
    This document defines the exercises for
    <a href="https://softuni.bg/courses/csharp-oop-basics">
        "C# OOP Basics" course @ Software University
    </a>
    . Please submit your solutions (source code) of all below described
    problems in
    <a href="https://judge.softuni.bg/Contests/239/Inheritance-Exercise">
        Judge
    </a>
    .
</p>
<h2>
    Problem 1. Person
</h2>
<p>
    You are asked to model an application for storing data about people. You
    should be able to have a person and a child. The child is derived of the
    person. Your task is to model the application. The only constraints are:
</p>
<p>
- People should <strong>not</strong> be able to have    <strong>negative age</strong>
</p>
<p>
- Children should <strong>not</strong> be able to have age    <strong>more than 15</strong>.<strong></strong>
</p>
<p>
    <strong></strong>
</p>
<ul>
    <li>
        <strong>Person</strong>
        <strong> </strong>
        – represents the base class by which all others are implemented
    </li>
    <li>
        <strong>Child</strong>
        - represents a class which is derived by the <strong>Person.</strong>
    </li>
</ul>
<h3>
    Note
</h3>
<p>
    Your class’s names <strong>MUST</strong> be the same as the names shown
    above!!!
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="520">
                <p align="center">
                    <strong>Sample Main()</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="520" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">static</a>
                    void Main()
                </p>
                <p>
                    {
                </p>
                <p>
                    string name = Console.ReadLine();
                </p>
                <p>
                    int age = int.Parse(Console.ReadLine());
                </p>
                <p>
                    try
                </p>
                <p>
                    {
                </p>
                <p>
                    Child child = new Child(name, age);
                </p>
                <p>
                    Console.WriteLine(child);
                </p>
                <p>
                    }
                </p>
                <p>
                    catch (ArgumentException ae)
                </p>
                <p>
                    {
                </p>
                <p>
                    Console.WriteLine(ae.Message);
                </p>
                <p>
                    }
                </p>
                <pre>}</pre>
            </td>
        </tr>
    </tbody>
</table>
<p>
    Create a new empty class and name it <strong>Person</strong>. Set its
    access modifier to <strong>public </strong>so it can be instantiated from
    any project. Every person has a name, and age.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="522">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="522" valign="top">
                <p>
                    public class Person
                </p>
                <p>
                    {
                </p>
                <p>
                    // 1. Add Fields
                </p>
                <p>
                    // 2. Add Constructor
                </p>
                <p>
                    // 3. Add Properties
                </p>
                <p>
                    // 4. Add Methods
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 2 – Define the fields
</h3>
<p>
    Define a <strong>field</strong> for each property the class should have
    (e.g. <strong>Name</strong>, <strong>Age</strong>)
</p>
<h3>
    Step 3 - Define the Properties of a Person
</h3>
<p>
    Define the <strong>Name</strong> and <strong>Age</strong> properties of a
Person. Ensure that they can only be    <strong>changed by the class itself or its descendants</strong> (pick the
    most appropriate access modifier).
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="331">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="331" valign="top">
                <p>
                    public virtual string Name
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
                <p>
                    public virtual int Age
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO
                </p>
                <pre>    }</pre>
                <pre>}</pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 4 - Define a Constructor
</h3>
<p>
    Define a constructor that accepts <strong>name and age</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="341">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="341" valign="top">
                <p>
                    public Person(string name, int age)
                </p>
                <p>
                    {
                </p>
                <p>
                    this.Name = name;
                </p>
                <p>
                    this.Age = age;
                </p>
                <pre>}</pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 5 - Perform Validations
</h3>
<p>
After you have created a <strong>field</strong> for each property (e.g.<strong>Name</strong> and <strong>Age</strong>). Next step is to<strong>perform validations</strong> for each one. The    <strong>getter should return the corresponding field’s value</strong> and
    the <strong>setter should validate</strong> the input data before setting
    it. Do this for each property.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="567">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="567" valign="top">
                <p>
                    public virtual int Age
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return this.age;
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    if (value &lt; 0)
                </p>
                <p>
                    {
                </p>
                <p>
                    throw new ArgumentException("Age must be positive!");
                </p>
                <p>
                    }
                </p>
                <p>
                    //TODO set field age with value
                </p>
                <p>
                    }
                </p>
                <pre>}</pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Constraints
</h3>
<p>
    · If the age of a person is negative – exception’s message is: "Age must be
    positive!"
</p>
<p>
· If the age of a child is bigger than 15 – exception’s message is: "<a name="OLE_LINK6"></a>    <a name="OLE_LINK5">Child's age must be less than 15!</a>"
</p>
<p>
    · If the name of a child or a person is no longer than 3 symbols –
exception’s message is: "<a name="OLE_LINK4"></a>    <a name="OLE_LINK3">Name's length should not be less than 3 symbols!</a>"
</p>
<h3>
    Step 6 - Override ToString()
</h3>
<p>
As you probably already know, all classes in C# inherit the<strong>Object</strong> class and therefore have all its<strong>public</strong> members (<strong>T</strong><strong>oString()</strong>, <strong>E</strong><strong>quals()</strong> and<strong>G</strong><strong>etHashCode()</strong> methods).    <strong>T</strong><strong>oString()</strong> serves to return information
    about an instance as string. Let's <strong>override</strong> (change) its
    behavior for our <strong>Person</strong> class.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="501">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="501" valign="top">
                <p>
                    public override string ToString()
                </p>
                <p>
                    {
                </p>
                <p>
                    <a name="OLE_LINK8"></a>
                    <a name="OLE_LINK7">StringBuilder</a>
                    stringBuilder = new StringBuilder();
                </p>
                <p>
                    stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                </p>
                <p>
                    this.Name,
                </p>
                <p>
                    this.Age));
                </p>
                <p>
                    return stringBuilder.ToString();
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
And voila! If everything is correct, we can now create    <strong>Person objects</strong> and display information about them.
</p>
<h3>
    Step 7 – Create a Child
</h3>
<p>
    Create a <strong>Child </strong>class that inherits <strong>Person</strong>
    and has the same constructor definition. However, do not copy the code from
    the Person class - <strong>reuse the Person class’s constructor</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="330">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="330" valign="top">
                <p>
                    public Child(string name, int age)
                </p>
                <p>
                    : base(name, age)
                </p>
                <p>
                    {
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    There is <strong>no need</strong> to rewrite the Name and Age properties
    since <strong>Child</strong> inherits <strong>Person </strong>and by
    default has them.
</p>
<h3>
    Step 8 – Validate the Child’s setter
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="567">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="567" valign="top">
                <p>
                    public override int Age
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return base.Age;
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO validate childs age
                </p>
                <p>
                    base.Age = value;
                </p>
                <p>
                    }
                </p>
                <pre>}</pre>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Book Shop
</h2>
<p>
    You are working in a library. And you are pissed of writing descriptions
    for books by hand, so you wish to use the computer to speed up the process.
    The task is simple - your program should have two classes – one for the
ordinary books – <strong>Book</strong>, and another for the special ones –    <strong>GoldenEditionBook</strong>. So let’s get started! We need two
    classes:
</p>
<ul>
    <li>
        <strong>Book</strong>
- represents a book that holds <strong>title</strong>,<strong>author </strong>and <strong>price</strong>. A book should offer        <strong>information</strong> about itself in the format shown in the
        output below.
    </li>
    <li>
        <strong>GoldenEditionBook</strong>
- represents a special book holds the same properties as any<strong>Book</strong>, but its <strong>price</strong> is always        <strong>30% higher</strong>.
    </li>
</ul>
<h3>
    Constraints
</h3>
<p>
    · If the author’s second name is starting with a digit– exception’s message
    is: "<a name="OLE_LINK14"></a><a name="OLE_LINK13">Author not valid!</a>"
</p>
<p>
· If the title’s length is less than 3 symbols – exception’s message is: "    <a name="OLE_LINK16"></a><a name="OLE_LINK15">Title not valid!"</a>
</p>
<p>
· If the price is zero or it is negative – exception’s message is: "    <a name="OLE_LINK18"></a><a name="OLE_LINK17">Price not valid!</a>"
</p>
<ul>
    <li>
        Price must be formatted to <strong>two</strong> symbols after the
        decimal separator
    </li>
</ul>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="677">
                <p align="center">
                    <strong>Sample Main()</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="677" valign="top">
                <p>
                    static void Main()
                </p>
                <p>
                    {
                </p>
                <p>
                    <a name="OLE_LINK10"></a>
                    <a name="OLE_LINK9">try</a>
                </p>
                <p>
                    {
                </p>
                <p>
                    string author = Console.ReadLine();
                </p>
                <p>
                    string title = Console.ReadLine();
                </p>
                <p>
                    decimal price = decimal.Parse(Console.ReadLine());
                </p>
                <p>
                    Book book = new Book(author, title, price);
                </p>
                <p>
                    GoldenEditionBook goldenEditionBook = new
                    GoldenEditionBook(author, title, price);
                </p>
                <p>
                    Console.WriteLine(book + Environment.NewLine);
                </p>
                <p>
                    Console.WriteLine(goldenEditionBook);
                </p>
                <p>
                    }
                </p>
                <p>
                    catch (ArgumentException ae)
                </p>
                <p>
                    {
                </p>
                <p>
                    Console.WriteLine(ae.Message);
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="175">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="159" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="175" valign="top">
                <p>
                    Ivo 4ndonov
                </p>
                <p>
                    Under Cover
                </p>
                <p>
                    9999999999999999999
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Author not valid!
                </p>
            </td>
        </tr>
        <tr>
            <td width="175" valign="top">
                <p>
                    Petur Ivanov
                </p>
                <p>
                    Life of Pesho
                </p>
                <p>
                    20
                </p>
            </td>
            <td width="159" valign="top">
                <p>
                    Type: Book
                </p>
                <p>
                    Title: Life of Pesho
                </p>
                <p>
                    Author: Petur Ivanov
                </p>
                <p>
                    Price: 20.00
                </p>
                <p>
                    Type: GoldenEditionBook
                </p>
                <p>
                    Title: Life of Pesho
                </p>
                <p>
                    Author: Petur Ivanov
                </p>
                <p>
                    Price: 26.00
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 1 - Create a Book Class
</h3>
<p>
    Create a new empty class and name it <strong>Book</strong>. Set its access
    modifier to <strong>public </strong>so it can be instantiated from any
    project.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="256">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="256" valign="top">
                <p>
                    public class Book
                </p>
                <p>
                    {
                </p>
                <p>
                    //1. Add Fields
                </p>
                <p>
                    //2. Add Constructors
                </p>
                <p>
                    //3. Add Properties
                </p>
                <p>
                    //4. Add Methods
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 2 - Define the Properties of a Book
</h3>
<p>
Define the <strong>Title</strong>, <strong>Author</strong> and<strong>Price</strong> properties of a Book. Ensure that they can only be    <strong>changed by the class itself or its descendants</strong> (pick the
    most appropriate access modifier).
</p>
<h3>
    Step 3 - Define a Constructor
</h3>
<p>
Define a constructor that accepts <strong>author, title</strong> and    <strong>price</strong> arguments.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="669">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="669" valign="top">
                <p>
                    public Book(string author, string title, decimal price)
                </p>
                <p>
                    {
                </p>
                <p>
                    this.Author = author;
                </p>
                <p>
                    this.Title = title;
                </p>
                <p>
                    this.Price = price;
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 4 - Perform Validations
</h3>
<p>
Create a <strong>field</strong> for each property (<strong>Price</strong>,<strong>Title</strong> and <strong>Author</strong>) and<strong>perform validations</strong> for each one. The<strong>getter should return the corresponding field</strong> and the    <strong>setter should validate</strong> the input data before setting it.
    Do this for every property.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="661">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="661" valign="top">
                <p>
                    public string Author
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return this.author;
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO validate value
                </p>
                <p>
                    this.author = value;
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
                <p>
                    public string Title
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return this.title;
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO validate value
                </p>
                <p>
                    this.title = value;
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
                <p>
                    public virtual decimal Price
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return this.price;
                </p>
                <p>
                    }
                </p>
                <p>
                    set
                </p>
                <p>
                    {
                </p>
                <p>
                    //TODO validate value
                </p>
                <p>
                    this.price = value;
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
                <pre></pre>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Step 5 - Override ToString()
</h3>
<p>
We already mentioned that all classes in C# inherit the<strong>System.Object</strong> class and therefore have all its    <strong>public</strong> members. Let's <strong>override</strong> (change)
the <strong>ToString()</strong> method’s behavior again acordingly our    <strong>Book</strong> class’s data.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="666">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="666" valign="top">
                <p>
                    public override string ToString()
                </p>
                <p>
                    {
                </p>
                <p>
                    var resultBuilder = new StringBuilder();
                </p>
                <p>
                    resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                </p>
                <p>
                    .AppendLine($"Title: {this.Title}")
                </p>
                <p>
                    .AppendLine($"Author: {this.Author}")
                </p>
                <p>
                    .AppendLine($"Price: {this.Price:f2}");
                </p>
                <p>
                    string result = resultBuilder.ToString().TrimEnd();
                </p>
                <p>
                    return result;
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
And voila! If everything is correct, we can now create    <strong>Book objects</strong> and display information about them.
</p>
<h3>
    Step 6 – Create a GoldenEditionBook
</h3>
<p>
Create a <strong>GoldenEditionBook </strong>class that inherits    <strong>Book</strong> and has the same constructor definition. However, do
not copy the code from the Book class -    <strong>reuse the Book class constructor</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="675">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="675" valign="top">
                <p>
                    public GoldenEditionBook(string author, string title,
                    decimal price)
                </p>
                <p>
                    : base(author, title, price)
                </p>
                <p>
                    {
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    There is <strong>no need</strong> to rewrite the Price, Title and Author
properties since <strong>GoldenEditionBook</strong> inherits    <strong>Book </strong>and by default has them.
</p>
<h3>
    Step 7 - Override the Price Property
</h3>
<p>
Golden edition books should return a <strong>30%</strong> higher    <strong>price</strong> than the original price. In order for the getter to
    return a different value, we need to override the Price property.
</p>
<p>
    Back to the <strong>GoldenEditionBook</strong> class, let's override the
    Price property and change the getter body
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="675">
                <p align="center">
                    <strong>Sample Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="675" valign="top">
                <p>
                    public override decimal Price
                </p>
                <p>
                    {
                </p>
                <p>
                    get
                </p>
                <p>
                    {
                </p>
                <p>
                    return base.Price * 1.3;
                </p>
                <p>
                    }
                </p>
                <p>
                    }
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Mankind
</h2>
<p>
    Your task is to model an application. It is very simple. The mandatory
models of our application are 3: <strong>Human</strong>,    <strong>Worker</strong> and <strong>Student</strong>.
</p>
<p>
The parent class – Human should have <strong>first name</strong> and<strong>last name</strong>. Every student has a<strong>faculty number</strong>. Every worker has a    <strong>week salary</strong> and <strong>work hours per day</strong>. It
    should be able to calculate the money he earns by hour. You can see the
    constraints below.
</p>
<h3>
    Input
</h3>
<p>
    On the first input line you will be given info about a single student - a
    name and faculty number.
</p>
<p>
    On the second input line you will be given info about a single worker -
    first name, last name, salary and working hours.
</p>
<h3>
    Output
</h3>
<p>
    You should first print the info about the student following a single blank
    line and the info about the worker in the given formats:
</p>
<ul>
    <li>
        Print the student info in the following format:
    </li>
</ul>
<p>
    <strong>First Name: {student's first name}</strong>
</p>
<p>
    <strong> Last Name: {student's last name}</strong>
</p>
<p>
    <strong> Faculty number: {student's faculty number}</strong>
</p>
<p>
    <strong></strong>
</p>
<ul>
    <li>
        Print the worker info in the following format:
    </li>
</ul>
<p>
    <strong> First Name: {worker's first name}</strong>
</p>
<p>
    <strong>Last Name: {worker's second name}</strong>
</p>
<p>
    <strong>Week Salary: {worker's salary}</strong>
</p>
<p>
    <strong>Hours per day: {worker's working hours}</strong>
</p>
<p>
    <strong>Salary per hour: {worker's salary per hour}</strong>
</p>
<p>
    Print exactly two digits after every double value's decimal separator (e.g.
    10.00). Consider the workweek from Monday to Friday. A faculty number
    should be consisted only of digits and letters.
</p>
<h3>
    Constraints
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="120">
                <p align="center">
                    <strong>Parameter</strong>
                </p>
            </td>
            <td width="201">
                <p align="center">
                    <strong>Constraint</strong>
                </p>
            </td>
            <td width="397">
                <p align="center">
                    <strong>Exception Message</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Human first name
                </p>
            </td>
            <td width="201">
                <p>
                    Should start with a capital letter
                </p>
            </td>
            <td width="397">
                <p>
                    "<a name="OLE_LINK20"></a>
                    <a name="OLE_LINK19">
                        Expected upper case letter! Argument: firstName
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Human first name
                </p>
            </td>
            <td width="201">
                <p>
                    Should be more than 3 symbols
                </p>
            </td>
            <td width="397">
                <p>
                    "<a name="OLE_LINK22"></a>
                    <a name="OLE_LINK21">
                        Expected length at least 4 symbols! Argument: firstName
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Human last name
                </p>
            </td>
            <td width="201">
                <p>
                    Should start with a capital letter
                </p>
            </td>
            <td width="397">
                <p>
                    "Expected upper case letter! Argument: lastName"
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Human last name
                </p>
            </td>
            <td width="201">
                <p>
                    Should be more than 2 symbols
                </p>
            </td>
            <td width="397">
                <p>
                    "<a name="OLE_LINK24"></a>
                    <a name="OLE_LINK23">
                        Expected length at least 3 symbols! Argument: lastName
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Faculty number
                </p>
            </td>
            <td width="201">
                <p>
                    Should be in range [5..10] symbols
                </p>
            </td>
            <td width="397">
                <p>
"<a name="OLE_LINK26"></a>                    <a name="OLE_LINK25">Invalid faculty number!</a>"
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Week salary
                </p>
            </td>
            <td width="201">
                <p>
                    Should be more than 10
                </p>
            </td>
            <td width="397">
                <p>
                    "<a name="OLE_LINK28"></a>
                    <a name="OLE_LINK27">
                        Expected value mismatch! Argument: weekSalary
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="120">
                <p>
                    Working hours
                </p>
            </td>
            <td width="201">
                <p>
                    Should be in the range [1..12]
                </p>
            </td>
            <td width="397">
                <p>
                    "<a name="OLE_LINK30"></a>
                    <a name="OLE_LINK29">
                        Expected value mismatch! Argument: workHoursPerDay
                    </a>
                    "
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="191">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="433" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Ivan Ivanov 08
                </p>
                <p>
                    Pesho Kirov 1590 10
                </p>
            </td>
            <td width="433" valign="top">
                <p>
                    Invalid faculty number!
                </p>
            </td>
        </tr>
        <tr>
            <td width="191" valign="top">
                <p>
                    Stefo Mk321 0812111
                </p>
                <p>
                    Ivcho Ivancov 1590 10
                </p>
            </td>
            <td width="433" valign="top">
                <p>
                    First Name: Stefo
                </p>
                <p>
                    Last Name: Mk321
                </p>
                <p>
                    Faculty number: 0812111
                </p>
                <p>
                    First Name: Ivcho
                </p>
                <p>
                    Last Name: Ivancov
                </p>
                <p>
                    Week Salary: 1590.00
                </p>
                <p>
                    Hours per day: 10.00
                </p>
                <p>
                    Salary per hour: 31.80
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    <a name="__DdeLink__2168_1635918253"></a>
    Problem 4. Online Radio Database
</h2>
<p>
    Create an online radio station database. It should keep information about
    all added songs. On the first line you are going to get the number of songs
    you are going to try to add. On the next lines you will get the songs to be
    added in the format
    <strong>
        &lt;artist name&gt;;&lt;song name&gt;;&lt;minutes:seconds&gt;
    </strong>
    . To be valid, every song should have an artist name, a song name and
    length.
</p>
<p>
    Design a custom exception hierarchy for invalid songs:
</p>
<ul>
    <li>
        InvalidSongException
    </li>
</ul>
<p>
    o InvalidArtistNameException
</p>
<p>
    o InvalidSongNameException
</p>
<p>
    o InvalidSongLengthException
</p>
<p>
    § InvalidSongMinutesException
</p>
<p>
    § InvalidSongSecondsException
</p>
<h3>
    Validation
</h3>
<ul>
    <li>
        Artist name should be between 3 and 20 symbols.
    </li>
    <li>
        Song name should be between 3 and 30 symbols.
    </li>
</ul>
<p>
    · Song length should be between 0 second and 14 minutes and 59 seconds.
</p>
<ul>
    <li>
        Song minutes should be between 0 and 14.
    </li>
    <li>
        Song seconds should be between 0 and 59.
    </li>
</ul>
<h3>
    Exception Messages
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="239" valign="top">
                <p align="center">
                    <strong>Exception</strong>
                </p>
            </td>
            <td width="412" valign="top">
                <p align="center">
                    <strong>Message</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidSongException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "Invalid song."
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidArtistNameException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "<a name="OLE_LINK32"></a>
                    <a name="OLE_LINK31">
                        Artist name should be between 3 and 20 symbols.
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidSongNameException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "<a name="OLE_LINK34"></a>
                    <a name="OLE_LINK33">
                        Song name should be between 3 and 30 symbols.
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidSongLengthException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "Invalid song length."
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidSongMinutesException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "<a name="OLE_LINK39"></a><a name="OLE_LINK36"></a>
                    <a name="OLE_LINK35">
                        Song minutes should be between 0 and 14.
                    </a>
                    "
                </p>
            </td>
        </tr>
        <tr>
            <td width="239" valign="top">
                <p>
                    InvalidSongSecondsException
                </p>
            </td>
            <td width="412" valign="top">
                <p>
                    "<a name="OLE_LINK40"></a><a name="OLE_LINK38"></a>
                    <a name="OLE_LINK37">
                        Song seconds should be between 0 and 59.
                    </a>
                    "
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    <strong>Note</strong>
: Check validity in the order <strong>artist name</strong> -&gt;    <strong>song name</strong> -&gt; <strong>song length</strong>
</p>
<h3>
    Output
</h3>
<p>
If the song is added, print "<strong>Song added.</strong>". If you<strong>can’t add a song</strong>, print an    <strong>appropriate exception message</strong>. On the last two lines print
the <strong>number of songs added</strong> and the<strong>total length of the playlist</strong> in format    <strong>{Playlist length: 0h 7m 47s}.</strong>
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="314" valign="top">
                <p align="center">
                    <strong>Exception</strong>
                </p>
            </td>
            <td width="336" valign="top">
                <p align="center">
                    <strong>Message</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="314" valign="top">
                <p>
                    3
                </p>
                <p>
                    ABBA;Mamma Mia;3:35
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;4:123
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;4:12
                </p>
            </td>
            <td width="336" valign="top">
                <p>
                    Song added.
                </p>
                <p>
                    Song seconds should be between 0 and 59.
                </p>
                <p>
                    Song added.
                </p>
                <p>
                    Songs added: 2
                </p>
                <p>
                    Playlist length: 0h 7m 47s
                </p>
            </td>
        </tr>
        <tr>
            <td width="314" valign="top">
                <p>
                    5
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;14:59
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;14:59
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;14:59
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;14:59
                </p>
                <p>
                    Nasko Mentata;Shopskata salata;0:5
                </p>
            </td>
            <td width="336" valign="top">
                <p>
                    Song added.
                </p>
                <p>
                    Song added.
                </p>
                <p>
                    Song added.
                </p>
                <p>
                    Song added.
                </p>
                <p>
                    Song added.
                </p>
                <p>
                    Songs added: 5
                </p>
                <p>
                    Playlist length: 1h 0m 1s
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 5. *Mordor’s Cruel Plan
</h2>
<p>
    Gandalf the Gray is a great wizard but he also loves to eat and the food
    makes him loose his capability of fighting the dark. The Mordor’s orcs have
    asked you to design them a program which is calculating the Gandalf’s mood.
    So they could predict the battles between them and try to beat The Gray
    Wizard. When Gandalf is hungry he gets angry and he could not fight well.
    Because the orcs have a spy, he has told them the foods that Gandalf is
    eating and the result on his mood after he has eaten some food. So here is
    the list:
</p>
<ul>
    <li>
        <strong>Cram</strong>
        : 2 points of happiness;<strong></strong>
    </li>
    <li>
        <strong>Lembas</strong>
        : 3 points of happiness;<strong></strong>
    </li>
    <li>
        <strong>Apple</strong>
        : 1 point of happiness;<strong></strong>
    </li>
    <li>
        <strong>Melon</strong>
        : 1 point of happiness;<strong></strong>
    </li>
    <li>
        <strong>HoneyCake</strong>
        : 5 points of happiness;<strong></strong>
    </li>
    <li>
        <strong>Mushrooms</strong>
        : -10 points of happiness;<strong></strong>
    </li>
    <li>
        <strong>Everything else</strong>
        : -1 point of happiness;<strong></strong>
    </li>
</ul>
<p>
    Gandalf moods are:<strong></strong>
</p>
<ul>
    <li>
        <strong>Angry </strong>
        - below -5 points of happiness;<strong></strong>
    </li>
    <li>
        <strong>Sad</strong>
        - from -5 to 0 points of happiness;
    </li>
    <li>
        <strong>Happy </strong>
        - from 1 to 15 points of happiness;
    </li>
    <li>
        <strong>JavaScript</strong>
        - when happiness points are more than 15;
    </li>
</ul>
<p>
    The task is simple. Model an application which is calculating the happiness
    points, Gandalf has after eating all the food passed in the input. After
    you are done, print on the first line – total happiness points Gandalf had
collected. On the second line – print    <a name="__DdeLink__2217_1635918253">the <strong>Mood’s</strong></a> name
    which is corresponding to the points.
</p>
<h3>
    Input
</h3>
<p>
    The input comes from the console. It will hold a single line: all the
    Gandalf`s foods he has eaten separated by a whitespace.
</p>
<h3>
    Output
</h3>
<p>
Print on the console Gandalf`s happiness points and the    <strong>Mood’s</strong> name which is corresponding to the points.
</p>
<h3>
    Constraints
</h3>
<ul type="disc">
    <li>
The characters in the input string will be no more than:        <strong>1000.</strong>
    </li>
    <li>
        The food count would be in the range <strong>[1…100]</strong>.
    </li>
</ul>
<p>
    · Time limit: 0.3 sec. Memory limit: 16 MB.
</p>
<h3>
    Note
</h3>
<p>
Try to implement a factory pattern. You should have two factory classes –    <strong>FoodFactory</strong> and <strong>MoodFactory</strong>. And their
task is to produce objects (e.g. <strong>FoodFactory</strong>, produces –<strong>Food</strong> and the <strong>MoodFactory</strong> -    <strong>Mood</strong>). Try to implement abstract classes (e.g. classes
    which can’t be instantiated directly)
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="601" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="98" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="601" valign="top">
                <p>
                    <a name="__DdeLink__2117_1635918253"></a>
                    Cram melon honeyCake Cake
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    7
                </p>
                <p>
                    Happy
                </p>
            </td>
        </tr>
        <tr>
            <td width="601" valign="top">
                <p>
                    <a name="__DdeLink__2165_1635918253"></a>
                    gosho, pesho, meze, Melon, HoneyCake@;
                </p>
            </td>
            <td width="98" valign="top">
                <p>
                    -5
                </p>
                <p>
                    Sad
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 6. Animals
</h2>
<p>
    Create a hierarchy of <strong>Animals</strong>. Your program should have 3
different animals – <strong>Dog</strong>, <strong>Frog</strong> and    <strong>Cat</strong>. Deeper in the hierarchy you should have two
additional classes – <strong>Kitten</strong> and <strong>Tomcat</strong>.    <strong> </strong><strong>Kittens are female and Tomcats are male!</strong>
</p>
<p>
All types of animals should be able to produce some kind of sound (    <strong>ProduceSound()</strong>). For example, the dog should be able to
    bark.
</p>
<p>
    Your task is to model the hierarchy and test its functionality. Create an
    animal of each kind and make them all produce sound.
</p>
<p>
    You will be given some lines of input. Each two lines will represent an
    animal. On the first line will be the type of animal and on the second –
    the name, the age and the gender. When the command "<strong>Beast!</strong>
    " is given, stop the input and print all the animals in the format shown
    below.
</p>
<h3>
    Output
</h3>
<p>
    · Print the information for each animal on three lines. On the first line,
    print: "&lt;<strong>AnimalType</strong>&gt;"
</p>
<p>
· On the second line print: "&lt;<strong>Name</strong>&gt; &lt;    <strong>Age</strong>&gt; &lt;<strong>Gender</strong>&gt;"
</p>
<ul>
    <li>
On the third line print the sounds it produces: "&lt;        <strong>ProduceSound()</strong>&gt;"
    </li>
</ul>
<h3>
    Constraints
</h3>
<ul type="disc">
    <li>
Each <strong>Animal</strong> should have a <strong>name</strong>, an        <strong>age</strong> and a <strong>gender</strong>
    </li>
    <li>
        <strong>All</strong>
        input values should <strong>not be blank</strong> (e.g. name, age and
        so on…)
    </li>
    <li>
If you receive an input for the <strong>gender</strong> of a<strong>Tomcat</strong> or a <strong>Kitten</strong>, ignore it but        <strong>create</strong> the animal
    </li>
    <li>
        If the input is invalid for one of the properties, throw an exception
        with message: "I<strong>nvalid input!</strong>"
    </li>
    <li>
Each animal should have the functionality to        <strong>ProduceSound()</strong>
    </li>
    <li>
        Here is the type of sound each animal should produce:
    </li>
    <ul type="circle">
        <li>
            <strong>Dog: "Woof!"</strong>
        </li>
        <li>
            <strong>Cat: "Meow meow"</strong>
        </li>
        <li>
            <strong>Frog: "Ribbit"</strong>
        </li>
        <li>
            <strong>Kittens: "Meow"</strong>
        </li>
        <li>
            <strong>Tomcat: "MEOW"</strong>
        </li>
    </ul>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="139" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="171" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Cat
                </p>
                <p>
                    Tom 12 Male
                </p>
                <p>
                    Dog
                </p>
                <p>
                    Sharo 132 Male
                </p>
                <p>
                    Beast!
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Cat
                </p>
                <p>
                    Tom 12 Male
                </p>
                <p>
                    Meow meow
                </p>
                <p>
                    Dog
                </p>
                <p>
                    Sharo 132 Male
                </p>
                <p>
                    Woof!
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Frog
                </p>
                <p>
                    Kermit 12 Male
                </p>
                <p>
                    Beast!
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Frog
                </p>
                <p>
                    Kermit 12 Male
                </p>
                <p>
                    Ribbit
                </p>
            </td>
        </tr>
        <tr>
            <td width="139" valign="top">
                <p>
                    Frog
                </p>
                <p>
                    Sashko -2 Male
                </p>
                <p>
                    Frog
                </p>
                <p>
                    Sashko 2 Male
                </p>
                <p>
                    Beast!
                </p>
            </td>
            <td width="171" valign="top">
                <p>
                    Invalid input!
                </p>
                <p>
                    Frog
                </p>
                <p>
                    Sashko 2 Male
                </p>
                <p>
                    Ribbit
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Bonus
</h3>
<p>
    Create an interface <strong>ISoundProducable</strong> and implement it in
    the <strong>Animal</strong> class.
</p>