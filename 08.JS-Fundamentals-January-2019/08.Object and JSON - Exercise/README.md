<h1>
    Exercise: Objects and JSON, DOM Events
</h1>
<p>
    Problems for in-class lab for the
    <a href="https://softuni.bg/trainings/2247/js-fundamentals-january-2019">
        "JavaScript Fundamentals" course @ SoftUni
    </a>
    . Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/1485">
        https://judge.softuni.bg/Contests/1485
    </a>
</p>
<h2>
    1. Shopping Cart
</h2>
<p>
    You will be given some products that you should be able to add to your
    cart. Each product will have a <strong>name, picture and a price</strong>.
    When the button <strong>"Add to cart"</strong> is clicked, add the current
product in the <strong>textarea</strong> in the following format:<strong>"Added {name} for {money} to the cart"</strong>. Each<strong>button can be clicked as much as you want</strong>. When the button<strong>"Buy"</strong> is pressed, you need to calculate the    <strong>total money</strong> that you need to pay for the products that are
    currently in your cart. Print the result in the <strong>textarea</strong>
in the following format:    <strong>"You bought {list} for {totalPrice}."</strong>. The list should
    contain only the <strong>unique elements</strong>. The list should be the
    products, separated by a <strong>", ". </strong>The total price should be
    rounded to the second decimal point.
</p>
<h3>
    Examples
</h3>
<p>
    <strong></strong>
</p>
<h2>
    2. Furniture
</h2>
<p>
    You will be given some furniture as an <strong>array of objects</strong>.
    Each object will have a <strong>name</strong>, a <strong>price</strong> and
a <strong>decoration factor</strong>. When clicking on<strong>"Generate"</strong>, add to the    <strong>div with id furniture-list</strong> a <strong>div</strong> element
with <strong>class furniture</strong> for each piece of furniture with    <strong>checkbox, name, price and decoration factor </strong>(code example
below). Then when the <strong>"Buy"</strong> button is clicked, get all<strong>checkboxes that are marked</strong> and show in the    <strong>result textbox</strong> the <strong>names</strong> of the piece of
furniture that <strong>were checked</strong>, separated by a space(<strong>" "</strong>) in the format:    <strong>"Bought furniture: {furniture1} {furniture2}…".</strong> On the
next line, print the total price in format:    <strong>"Total price: {totalPrice}"</strong> (formatted to the second
decimal). And finally, print the average decoration factor in the format:    <strong>"Average decoration factor: {decFactor}"</strong>
</p>
<h3>
    Examples
</h3>
<p>
    <strong></strong>
</p>
<p>
    <strong></strong>
</p>
<h2>
    3. Forum
</h2>
<p>
You will be given a registration form containing the following:<strong>username</strong>, <strong>password</strong>,<strong>email</strong>, <strong>checkboxes</strong><strong>for 4 different topics</strong>:<strong>science, cooking, art, sports</strong>. When<strong>the form is submitted</strong>, a user must be    <strong>registered and displayed in the table</strong> below. There will be
    a <strong>search box</strong> that should receive a string to search for in
    each row. When the button <strong>"Search"</strong> is clicked, display
only the rows that include that searched string. (set<strong>visibility:visible</strong> for the matched and    <strong>visibility:hidden</strong> for the others)
</p>
<h3>
    Hint
</h3>
<p>
    Use the <strong>preventDefault</strong> function to stop the page from
    reloading when you click the button
</p>
<h3>
    Examples
</h3>
<h2>
    4. Salesman
</h2>
<p>
    You will be given an <strong>array of objects in textarea,</strong> each
object containing a<strong>name of a product, quantity and a price</strong>. When the button    <strong>"Load"</strong> is clicked, <strong>add </strong>the product in
    some storage variable. If the <strong>product already exists</strong>, add
    the <strong>quantity and update the price</strong>. After a successful
    product addition display in the log the following message:
    <strong>
        "Successfully added {productQuantity} {productName}. Price:
        {currentPrice}"
    </strong>
    . Then, you will also be given another textarea that will contain an object
with <strong>name and quantity</strong>. When the button    <strong>"Buy"</strong> is clicked, <strong>check for that product</strong>
in the storage and if you <strong>have enough quantity</strong>; if you<strong>can complete</strong> the order,<strong>remove the quantity </strong>of that product from the storage and    <strong>add the money profited</strong> from that order to a profit
    variable. If the order <strong>cannot be completed</strong>, display a
    message <strong>"Cannot complete order." </strong>in the log, otherwise
display this message:    <strong>"{quantity} {productName} sold for {orderMoney}."</strong>. When
    the button <strong>"End Day"</strong> is clicked, display in the result
textbox the profit for the day in the format:<strong>"Profit: {profit}."</strong> (formatted to the<strong>second decimal</strong>).You should also    <strong>not be able to click any buttons</strong> anymore.
</p>
<p>
    <strong><em><u>Note:</u></em></strong>
    the messages in the log should be each on a separate line.
</p>
<h3>
    Examples
</h3>
<h4>
    Step 1
</h4>
<h4>
    Step 2
</h4>
<h4>
    Step 3
</h4>