<h1 align="center">
    Exercises: Unit Testing
</h1>
<p>
    This document defines the exercises for
    <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">
        "C# OOP Advanced" course @ Software University
    </a>
    .
</p>
<h2>
    Problem 1. Database
</h2>
<p>
Create a simple class - <strong>Database</strong>. It should<strong>store integers</strong>. You should<strong>set the initial integers by constructor</strong>. Store them<strong>in array</strong>. Your Database should have a functionality to<strong>add</strong>, <strong>remove</strong> and<strong>fetch all stored items</strong>. Your task is to<strong>test the class</strong>. In other words, create the class and    <strong>write tests</strong>, so you are sure its methods are working as
    intended.
</p>
<h3>
    Constraints
</h3>
<p>
· Storing array's <strong>capacity</strong> must be    <strong>exactly 16 integers</strong>
</p>
<p>
o If the size of the array is not 16 integers long, throw    <strong>InvalidOperationException</strong>
</p>
<ul>
    <li>
        <strong>Add</strong>
        operation, should <strong>add an element at the next free cell</strong>
        (just like a stack)
    </li>
</ul>
<p>
    o If there are 16 elements in the Database and try to add 17<sup>th</sup>,
    throw an <strong>InvalidOperationException</strong>
</p>
<ul>
    <li>
        <strong>Remove </strong>
operation, should support only removing an element        <strong>at the last index</strong> (just like a stack)
    </li>
</ul>
<p>
o If you try to remove element from empty Database throw    <strong>InvalidOperationException</strong>
</p>
<ul>
    <li>
        <strong>Constructors </strong>
        should take integers only, and store them in <strong>array</strong>
    </li>
    <li>
        <strong>Fetch method </strong>
        should return the elements as <strong>array</strong>
    </li>
</ul>
<h3>
    Hint
</h3>
<p>
    Do not forget to <strong>test the constructor(s)</strong>. They are methods
    too!
</p>
<h2>
    Problem 2. Extended Database
</h2>
<p>
    You already have a class - <strong>Database</strong>. Now your task is to
modify and extend it. It should support,    <strong>adding, removing and finding People</strong>. In other words, it
    should <strong>store People</strong>. There should be two types of finding
    methods - first: <strong>FindById </strong><strong>(long id)</strong> and
    the second one: <strong>FindByUsername (string username)</strong>. As you
may guess, each person should have its own <strong>unique id</strong>, and    <strong>unique username</strong>. Your task is to implement these functions
    and test them.
</p>
<h3>
    Constraints
</h3>
<p>
    Database should have methods:
</p>
<ul>
    <li>
        Add
    </li>
</ul>
<p>
o If there are already users with this username, throw    <strong>InvalidOperationException</strong>
</p>
<p>
o If there are already users with this id, throw    <strong>InvalidOperationException</strong>
</p>
<ul>
    <li>
        Remove
    </li>
    <li>
        FindByUsername
    </li>
</ul>
<p>
o If no user is present by this username, throw    <strong>InvalidOperationException</strong>
</p>
<p>
o If username parameter is null, throw    <strong>ArgumentNullException</strong>
</p>
<p>
    o Arguments are all <strong>CaseSensitive</strong>
</p>
<ul>
    <li>
        FindById
    </li>
</ul>
<p>
o If no user is present by this id, throw    <strong>InvalidOperationException</strong>
</p>
<p>
o If negative ids are found, throw    <strong>ArgumentOutOfRangeException</strong>
</p>
<h3>
    Hint
</h3>
<p>
    Do not forget to test the constructor(s). They are methods too!
</p>
<h2>
    Problem 3. Iterator Test
</h2>
<p>
    Create a class ListIterator, it should receive the collection (strings)
    which it will iterate, through its constructor. You should store the
    elements in a List and get them initially through its constructor. If there
    is null passed to the constructor, throw new ArgumentNullException(). The
    class should have three main functions:
</p>
<ul>
    <li>
        <strong>Move</strong>
        - should move an internal index position to the next index in the list,
        the method should return true if it successfully moved and false if
        there is no next index.
    </li>
    <li>
        <strong>HasNext</strong>
        - should return true if there is a next index and false if the index is
        already at the last element of the list.
    </li>
    <li>
        <strong>Print</strong>
        - should print the element at the current internal index, calling Print
        on a collection without elements should throw an appropriate exception
        with the message "<strong>Invalid Operation!</strong>".
    </li>
</ul>
<p>
By default, the internal index should be pointing to the    <strong>0<sup>th</sup> index</strong> of the List. Your program should
    support the following commands:
</p>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="165" valign="top">
                <p align="center">
                    <strong>Command</strong>
                </p>
            </td>
            <td width="217" valign="top">
                <p align="center">
                    <strong>Return Type</strong>
                </p>
            </td>
            <td width="308" valign="top">
                <p align="center">
                    <strong>Description</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    Move
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    boolean
                </p>
            </td>
            <td width="308" valign="top">
                <p>
                    This command should move the internal index to the next
                    index.
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    Print
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    void
                </p>
            </td>
            <td width="308" valign="top">
                <p>
                    This command should return the element at the current
                    internal index.
                </p>
            </td>
        </tr>
        <tr>
            <td width="165" valign="top">
                <p>
                    HasNext
                </p>
            </td>
            <td width="217" valign="top">
                <p>
                    boolean
                </p>
            </td>
            <td width="308" valign="top">
                <p>
                    Returns whether the collection has a next element.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Test
</h3>
<p>
    Create tests, so you are sure all methods in the class ListIterator are
    working as intended.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        There will always be only <strong>1</strong> <strong>Create</strong>
        command and it will always be the first command passed.
    </li>
    <li>
        The last command will always be the only <strong>END</strong> command.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="260" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="435" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="260" valign="top">
                <p>
                    Create
                </p>
                <p>
                    Print
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="435" valign="top">
                <p>
                    Invalid Operation!
                </p>
            </td>
        </tr>
        <tr>
            <td width="260" valign="top">
                <p>
                    Create Stefcho Goshky
                </p>
                <p>
                    HasNext
                </p>
                <p>
                    Print
                </p>
                <p>
                    Move
                </p>
                <p>
                    Print
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="435" valign="top">
                <p>
                    True
                </p>
                <p>
                    Stefcho
                </p>
                <p>
                    True
                </p>
                <p>
                    Goshky
                </p>
            </td>
        </tr>
        <tr>
            <td width="260" valign="top">
                <p>
                    Create 1 2 3
                </p>
                <p>
                    HasNext
                </p>
                <p>
                    Move
                </p>
                <p>
                    HasNext
                </p>
                <p>
                    HasNext
                </p>
                <p>
                    Move
                </p>
                <p>
                    HasNext
                </p>
                <p>
                    END
                </p>
            </td>
            <td width="435" valign="top">
                <p>
                    True
                </p>
                <p>
                    True
                </p>
                <p>
                    True
                </p>
                <p>
                    True
                </p>
                <p>
                    True
                </p>
                <p>
                    False
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. **Bubble Sort Test
</h2>
<p>
    There is a sorting algorithm - Bubble Sort. You could read this article, to
    get better the idea:
    <a href="https://en.wikipedia.org/wiki/Bubble_sort#Analysis">
        Bubble Sort
    </a>
    .
</p>
<p>
    <strong>Bubble sort</strong>
    , sometimes referred to as <strong>sinking sort</strong>, is a simple
    <a
        href="https://en.wikipedia.org/wiki/Sorting_algorithm"
        title="Sorting algorithm"
    >
        sorting algorithm
    </a>
    that repeatedly steps through the list to be sorted, compares each pair of
    adjacent items and
    <a
        href="https://en.wikipedia.org/wiki/Swap_(computer_science)"
        title="Swap (computer science)"
    >
        swaps
    </a>
    them if they are in the wrong order. The pass through the list is repeated
    until no swaps are needed, which indicates that the list is sorted. The
    algorithm, which is a
    <a
        href="https://en.wikipedia.org/wiki/Comparison_sort"
        title="Comparison sort"
    >
        comparison sort
    </a>
    , is named for the way smaller elements "bubble" to the top of the list.
    Although the algorithm is simple, it is too slow and impractical for most
    problems even when compared to
    <a
        href="https://en.wikipedia.org/wiki/Insertion_sort"
        title="Insertion sort"
    >
        insertion sort
    </a>
    . It can be practical if the input is usually in sorted order but may
    occasionally have some out-of-order elements nearly in position.
</p>
<p>
    Create a class "Bubble", and try to implement the sorting method yourslef.
    Create a Test class and test, is it working as intended. Think about the
    border cases.
</p>
<h2>
    Problem 5. **Integration Tests
</h2>
<p>
    When you create tests for a program, you should decouple a method which you
    test, so you could test a single problem. If a method is coupled to another
    one or it is doing more job that it is supposed to do, you could not
    clearly tell, which part is buggy. So when you create test, to determine
    which exactly is the problem, you separate each operation of the method and
    test each of them, to be sure, everything is working correctly. But there
    is another instance of the Unit Testing - Integration testing. When you do
    integration testing, you are testing the relationships of the models and
    the functions.
</p>
<p>
    You are a web developer and your boss assigns you a task to implement the
    backend logic of the following problem.
</p>
<p>
    You have a site with the following two models:
</p>
<p>
    <strong>Category has a:</strong>
    <strong></strong>
</p>
<ul>
    <li>
        Name.
    </li>
</ul>
<p>
    · Set of Users.
</p>
<p>
    · (optional) Set of Categories (children)
</p>
<p>
    <strong>User has a:</strong>
</p>
<ul>
    <li>
        Name.
    </li>
</ul>
<p>
    · Set of Categories
</p>
<p>
    <strong>Functions to implement:</strong>
</p>
<p>
    · Add Categories
</p>
<p>
    · Remove Category / Categories
</p>
<p>
    · Assign a child Category to a single Category.
</p>
<p>
    · Assign a User to specific Category.
</p>
<h3>
    Task
</h3>
<p>
    Create tests for all the classes. Test, do they work correctly together.
    Keep in mind, you should test the border cases which are very interesting
    in this domain.
</p>
<h3>
    Hint
</h3>
<p>
    In case you have a child Category and you remove its parent Category, if it
    has any Users, they must be reassigned to the child Category. If you try to
    move a child Category from its parent to another, don’t forget to remove
    the relationship from the first one. (e.g. When you move a Category from
    one parent to another, don’t copy the child to the both parents. Instead,
    create new child with all characteristics of the previous one and assign it
    to the new parent).
</p>
<h2>
    Problem 6. Twitter
</h2>
<p>
    You are working for twitter and your boss wants you to make a twitter
    client for microwave ovens. The main models in your domain should be - a
    Tweet (e.g. Message) and a Client (e.g. MicrowaveOven). Implement an
    Interface - Tweet. This interface should have the only functionality - to
    retrieve a message of a tweet. Create its implementation. The next
    interface we should create is Client (e.g. MicrowaveOven). When the Client
    receives the Tweet, it should write it to the console first and send it to
    the server as next step. Your task is to model the domain and create unit
    test.
</p>
<h3>
    Hint
</h3>
<p>
    Don’t forget to check the number of invocations of the methods to ensure
    they are invoked properly.
</p>
<h2>
    Problem 7. Hack
</h2>
<p>
    It is not considered as good practice to mock foreign objects. For the sake
    of learning, your task is to ensure the given methods are working as
    expected:
</p>
<p>
    <strong>Methods to Test:</strong>
    <strong></strong>
</p>
<ul>
    <li>
        <strong>Math.Аbs</strong>
        <strong>()</strong>
    </li>
    <li>
        <strong>Math.Floor</strong>
        <strong>()</strong>
    </li>
</ul>
<p>
    Try to mock the classes containing these methods and create tests which are
    proving they are working correctly.
</p>
<h2>
    Problem 8. Custom Linked List
</h2>
<p>
    Use the VS <strong>solution</strong> "<strong>CustomLinkedList</strong>".
</p>
<p>
· Create new <strong>Unit</strong> <strong>Test</strong><strong>Project</strong> and <strong>add</strong>    <strong>reference</strong> to the “<strong>CustomLinkedList</strong>”.
</p>
<ul>
    <li>
        Create Test Methods for <strong>all public members</strong> that need
        testing.
    </li>
</ul>
<p>
· Create tests that ensure all methods, getters and setters    <strong>work correctly</strong> (do not test auto-properties).
</p>
<ul>
    <li>
        Make sure that the methods throw the correct exceptions in case wrong
        input is entered.
    </li>
    <li>
Give <strong>meaningful</strong> <strong>assert</strong>        <strong>messages</strong> for failed tests.
    </li>
</ul>
<h2>
    Problem 9. DateTime.Now.AddDays();
</h2>
<p>
    Test the method <strong>DateTime.Now.AddDays()</strong>. Use mocking to
    provide the <strong>DateTime</strong> objects you need.
</p>
<p>
It is important that you test <strong>DateTime.Now</strong>, so don't use    <strong>new DateTime()</strong> for the tests.
</p>
<p>
    Some cases to consider:
</p>
<p>
    · Adding a day to the middle of the month, for example 16<sup>th</sup> June
    -&gt; 17<sup>th</sup> June
</p>
<ul>
    <li>
        Adding a day which will be in the next month (31<sup>st</sup> July
        -&gt; 1<sup>st</sup> August)
    </li>
</ul>
<p>
    · Adding a negative value (-5 days), also check negative values which go on
    to the previous month
</p>
<ul>
    <li>
Adding a day to a leap year (28<sup>th</sup> February 2008 -&gt; 29        <sup>th</sup> February 2008)
    </li>
    <li>
        Check the previous test with non-leap years (28<sup>th</sup> February
        1900 -&gt; 1<sup>st</sup> Match 1900)
    </li>
</ul>
<p>
    · Add a day to DateTime.MinValue and DateTime.MaxValue
</p>
<p>
    · Subtract a day from DateTime.MinValue and DateTime.MaxValue
</p>
<p>
    You can also make other tests if you wish.
</p>
<h2>
    Problem 10. Tire Pressure Monitoring System
</h2>
<p>
    You are given a small project for a system which monitors the pressure in
    car tires. Your task is to write unit tests for the system. You will need
    to use mocking in order to pass dependencies. Think about the corner cases
    of the project.
</p>