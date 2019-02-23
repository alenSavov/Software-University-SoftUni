<h1 align="center">
    Exercise: Web Server – Databases
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-web-development-basics">
        “C# Web Basics” course @ SoftUni
    </a>
    . Yoy can submit your solution in the course web page.
</p>
<p>
    Back to our By The Cake web site. We will connect our web site with a
    database so we can keep track of our data easily.
</p>
<h2>
    1. Create a Database Connection
</h2>
<p>
    Creating the database connection is pretty straight forward. We should add
    a project to keep our <strong>context class</strong> and a project to keep
our <strong>models</strong>. If you iplement the<strong>Repository pattern</strong> and/or the<strong>Unit of Work pattern</strong> (    <strong>and this is highly recommended</strong>), make sure they are in
    their own projects.
</p>
<p>
Start with creating the models. We will have <strong>users</strong>,    <strong>orders</strong> and <strong>products</strong>.
</p>
<p>
The <strong>user</strong> has <strong>name</strong>,<strong>username</strong>, <strong>password</strong>,<strong>date of registration</strong> and a<strong>collection of orders</strong>. The <strong>order</strong> has<strong>date of creation</strong> and a<strong>collection of products</strong>. The <strong>product</strong> has<strong>name</strong>, <strong>price</strong> and<strong>image URL</strong>. <strong>Each product</strong> can be part of    <strong>many orders</strong>.
</p>
<h2>
    2. Register Users
</h2>
<p>
    Create a Register page with a simple form. The form should ask for a
    username and a password. When a user is registered successfully, he/she
    should be taken to the home page.
</p>
<h2>
    3. Login Users
</h2>
<p>
    When the user try to log in you should check if the user exists in you
    database. If there is no such user, you should navigate to the Register
    page and ask the user to register.
</p>
<p>
    Add a link to the Register page and style it as a button.
</p>
<h2>
    4. User Profile Page
</h2>
<p>
    Add link <strong>My Profile</strong> to the <strong>Home</strong> page
    menu.
</p>
<p>
    The link should navigate to the page <strong>Profile</strong> where you can
see details about the user. The page should display the<strong>name</strong>, the <strong>username</strong>, the    <strong>date registered</strong> and the <strong>count of orders</strong>
    of the logged in user.
</p>
<h2>
    5. Add Cakes to the Database
</h2>
<p>
    On the <strong>Add Cake</strong> page the user can add cakes. You should
    store those cakes in the database. Extend the form and add a field for the
    URL of the picture of the cake.
</p>
<p>
    Fill some cakes so we can use them to test the application later.
</p>
<h2>
    6. The search Page
</h2>
<p>
    Now we are going to search all the cakes from our database. When the
    browser loads the page, there should be listed all cakes in the database.
    If there is no such cake, show a "Cake Not Found" message. The names of the
    cakes should be links that navigate to a page with details about the cake
    with a URL "<strong>localhost:{port}/cakeDetails/{cake id}</strong>".
</p>
<h2>
    7. Show Cake Details
</h2>
<p>
    Create the page <strong>CakeDetails</strong> and display the name, the
    price and the picture of the cake.
</p>
<h2>
    8. Make an Order
</h2>
<p>
    Users can order cakes, collect products in their cart and finish the order
    from the page Cart. Now when a user submits an order, you should keep that
    order in the database.
</p>
<h2>
    9. List Orders
</h2>
<p>
    Add link My Orders to the home page menu.
</p>
<p>
The link should navigate to the <strong>Orders</strong> page ("<strong>localhost:{port}/orders</strong>"). That page should show a    <strong>table</strong> with <strong>all orders</strong> made by the user.
    The orders should be ordered by date created in descending order.
</p>
<p>
    The <strong>id</strong> of the order should be a <strong>link</strong> that
    navigates to a page with details for the given order. The path to that page
    is "<strong>localhost:{port}/orderDetails/{order id}</strong>".
</p>
<h2>
    10. Show Order Details
</h2>
<p>
    The <strong>OrderDetails</strong> page should visualize details about the
    order (what a surprise!) with the given <strong>id</strong>. The user
should see when the order is created, a list with    <strong>all products</strong> and the <strong>total sum</strong> of the
    order.
</p>
<p>
    The name of the product is a link that navigates to a page with details
aboult the given cake – "    <strong>localhost:{port}/cakeDetails/{cake id}</strong>".
</p>