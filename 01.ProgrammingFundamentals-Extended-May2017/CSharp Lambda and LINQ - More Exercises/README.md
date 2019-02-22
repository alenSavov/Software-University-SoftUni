<h1>
    More Exercises: Lambda and LINQ
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/programming-fundamentals">
        “Programming Fundamentals Extended” course @ SoftUni
    </a>
    .
</p>
<p>
    Check your solutions here:
    <a href="https://judge.softuni.bg/Contests/436">
        https://judge.softuni.bg/Contests/436
    </a>
    .
</p>
<h2>
    1. Array Data
</h2>
<p>
    You will receive a list of <strong>integers</strong>, each separated with a
single space. On the <strong>next</strong> line, you will receive<strong>one</strong> of the following commands: “<strong>Min</strong>”, “    <strong>Max</strong>” or “<strong>All</strong>”.
</p>
<p>
Your task is to <strong>remove</strong> all numbers, which are<strong>smaller</strong> than the <strong>average</strong> of the    <strong>initial</strong> <strong>list</strong> and depending on the next
    command, to print an <strong>additional</strong> <strong>line</strong>:
</p>
<ul>
    <li>
If the command is “<strong>Min</strong>” – print the        <strong>smallest</strong> element from the <strong>remaining</strong>
        numbers.
    </li>
    <li>
If the command is “<strong>Max</strong>” – print the        <strong>largest</strong> element from the <strong>remaining</strong>
        numbers.
    </li>
    <li>
        If the command is “<strong>All</strong>” – print <strong>all</strong>
of the <strong>remaining</strong> numbers <strong>ordered</strong> in<strong>ascending</strong> <strong>order</strong> and<strong>separated</strong> by a <strong>single</strong>        <strong>whitespace</strong>.
    </li>
</ul>
<h3>
    Constraints
</h3>
<p>
    · The elements of the array will be in the interval
    [-2147483648…2147483647]
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    3 2 5 1 8 2 3
                </p>
                <p>
                    Min
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    5
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    9 10 8 1 2 6 7 3 4 5
                </p>
                <p>
                    All
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    6 7 8 9 10
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. String Decryption
</h2>
<p>
    Write a program, which can decipher an array of integers into a string
    message.
</p>
<h3>
    Input
</h3>
<p>
On the <strong>first</strong> line, you will receive an<strong>array</strong> of <strong>integers</strong> with exactly    <strong>two</strong> elements – <strong>m </strong>and <strong>n</strong>:
</p>
<ul>
    <li>
        <strong>m</strong>
will be the elements you have to <strong>skip</strong> from the        <strong>beginning</strong>.
    </li>
    <li>
        <strong>n </strong>
will be the element you have to <strong>take</strong>,        <strong>after</strong> the <strong>skipped</strong> elements.
    </li>
</ul>
<p>
On the <strong>second</strong> line, you will receive an    <strong>array</strong> of <strong>integers</strong>.
</p>
<h3>
    Output
</h3>
<p>
    Your task is to take <strong>only</strong> the <strong>numbers</strong>,
which are in the <strong>capital latin letter</strong> ASCII range (    <strong>65…90 inclusive</strong>). From the <strong>filtered</strong>
numbers, <strong>skip</strong> the next <strong>m </strong>elements (<strong>starting</strong> from <strong>0</strong>) and take the<strong>next</strong> <strong>n </strong>elements. After that,<strong>convert</strong> <strong>each</strong> <strong>number</strong> into    <strong>ASCII</strong> <strong>characters</strong>.
</p>
<p>
    <strong>Print</strong>
    the resulting string of <strong>ASCII characters </strong>on the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="398" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="100" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="398" valign="top">
                <p>
                    3 10
                </p>
                <p>
                    67 80 87 78 65 25 75 79 86 82 85 56 76 90 27 90
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    NAKOVRULZZ
                </p>
            </td>
        </tr>
        <tr>
            <td width="398" valign="top">
                <p>
                    4 5
                </p>
                <p>
                    23 70 71 72 14 73 80 25 73 12 90 18 90 65
                </p>
            </td>
            <td width="100" valign="top">
                <p>
                    PIZZA
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Camping
</h2>
<p>
    As a young and ambitious manager of a camping ground you want to invent a
new system, which will keep track of the registered camper    <strong> </strong>vans (RVs).
</p>
<p>
    Until you receive the command “<strong>end</strong>”, you will receive
    commands in the format:
</p>
<ul>
    <li>
        {nameOfThePerson} {camperModel} {timeToStay}
    </li>
</ul>
<p>
If you receive <strong>already</strong> <strong>existing</strong><strong>name</strong> of a person è add the camper (only if it is    <strong>new</strong>) to the already <strong>owned</strong> by the person
campers and <strong>add</strong> the <strong>days</strong> to the already    <strong>accumulated</strong> days.
</p>
<p>
Your task is to print <strong>all</strong> people in the following    <strong>format</strong>:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="312" valign="top">
                <p>
                    *{nameOfThePerson}: {countOfCampers}
                </p>
                <p>
                    ***{1<sup>st</sup> camperModel}
                </p>
                <p>
                    ***{2<sup>nd</sup> camperModel}
                </p>
                <p>
                    …
                </p>
                <p>
                    ***{n<sup>th</sup> camperModel}
                </p>
                <p>
                    Total stay: {countOfNights} nights
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Print all the <strong>people</strong>, <strong>ordered</strong> by the<strong>count</strong> of their <strong>campers</strong>. If<strong>two people</strong> have an <strong>equal</strong><strong>count</strong> of campers, <strong>order</strong> them by the<strong>length</strong> of their <strong>names </strong>in    <strong> ascending</strong> <strong>order</strong>. <strong>Print</strong>
the <strong>campers</strong> for each person in <strong>order</strong> of    <strong>receiving</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
        The nights will be in the interval [0…255]
    </li>
    <li>
You will not receive the <strong>same</strong> camper<strong>model</strong> <strong>twice</strong> for a        <strong>single</strong> person.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="210" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Pesho BigTruck2000 20
                </p>
                <p>
                    Stefan HeliumV100 10
                </p>
                <p>
                    Pesho ILoveRVs100 5
                </p>
                <p>
                    Maria MyPrecious 20
                </p>
                <p>
                    Gesh BigTruck1500 7
                </p>
                <p>
                    Bibi Mercedes 3
                </p>
                <p>
                    Gesh AwesomeCamper1000 12
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    Gesh: 2
                </p>
                <p>
                    ***BigTruck1500
                </p>
                <p>
                    ***AwesomeCamper1000
                </p>
                <p>
                    Total stay: 19 nights
                </p>
                <p>
                    Pesho: 2
                </p>
                <p>
                    ***BigTruck2000
                </p>
                <p>
                    ***ILoveRVs100
                </p>
                <p>
                    Total stay: 25 nights
                </p>
                <p>
                    Bibi: 1
                </p>
                <p>
                    ***Mercedes
                </p>
                <p>
                    Total stay: 3 nights
                </p>
                <p>
                    Maria: 1
                </p>
                <p>
                    ***MyPrecious
                </p>
                <p>
                    Total stay: 20 nights
                </p>
                <p>
                    Stefan: 1
                </p>
                <p>
                    ***HeliumV100
                </p>
                <p>
                    Total stay: 10 nights
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Pesho BigTruck2000 20
                </p>
                <p>
                    Pesho HeliumV100 10
                </p>
                <p>
                    Pesho ILoveRVs100 5
                </p>
                <p>
                    Pesho MyPrecious 20
                </p>
                <p>
                    Stefan BigTruck1500 7
                </p>
                <p>
                    Pesho Mercedes 3
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="210" valign="top">
                <p>
                    Pesho: 5
                </p>
                <p>
                    ***BigTruck2000
                </p>
                <p>
                    ***HeliumV100
                </p>
                <p>
                    ***ILoveRVs100
                </p>
                <p>
                    ***MyPrecious
                </p>
                <p>
                    ***Mercedes
                </p>
                <p>
                    Total stay: 58 nights
                </p>
                <p>
                    Stefan: 1
                </p>
                <p>
                    ***BigTruck1500
                </p>
                <p>
                    Total stay: 7 nights
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Most Valued Customer
</h2>
<p>
    You are an assistant-manager at a local supermarket and you are given the
task to award a prize to your most dedicated customer. The<strong>dedication</strong> of your customers is measured by the    <strong>amount of money</strong> they have <strong>spent</strong> at your
    store.
</p>
<h3>
    Input
</h3>
<p>
Until you receive the command “Shop is open”, you will receive    <strong>products</strong> in the format:
</p>
<p>
    {productName} {productPrice}
</p>
<p>
    <strong>After</strong>
you receive “Shop is open”, you will start receiving    <strong>customers</strong> and <strong>products</strong>, which they bought
    in the following <strong>format</strong>:
</p>
<p>
    {nameOfCustomer}: {firstBoughtProduct}, {secondBoughtProduct}, …
    {nthBoughtProduct}
</p>
<p>
Every customer’s total <strong>spending</strong> is equal to the<strong>sum</strong> of the <strong>prices</strong> of <strong>all</strong><strong>products</strong> which they bought. If you receive a<strong>product</strong>, which you <strong>do</strong><strong>not</strong> <strong>sell</strong> – <strong>ignore</strong><strong>it</strong>. A customer can buy <strong>one</strong> product    <strong>more</strong> <strong>than</strong> <strong>once</strong>.
</p>
<p>
You might also receive the command “Discount”. When you receive it –<strong>decrease</strong> the prices of the top <strong>3</strong><strong>most</strong> <strong>expensive</strong> products by<strong>10%</strong>. Calculate the <strong>total</strong> sum, using the    <strong>prices</strong> <strong>after</strong> <strong>all</strong>
    discounts are made.
</p>
<p>
When you <strong>receive</strong> the command “Print”,    <strong>stop</strong> taking input.
</p>
<h3>
    Output
</h3>
<p>
After you receive “Print”, <strong>print</strong> the customer, which<strong>spent the</strong> <strong>most</strong> <strong>money</strong> and<strong>all</strong> of the products they <strong>bought</strong> (for the<strong>price</strong>, use the <strong>discounted</strong>    <strong>one</strong>) in the following <strong>format</strong>:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="310" valign="top">
                <p>
                    Biggest spender: {nameOfTheCustomer}
                </p>
                <p>
                    ^Products bought:
                </p>
                <p>
                    ^^^{1<sup>st</sup> Product}: {priceOfTheProduct}
                </p>
                <p>
                    ^^^{2<sup>nd</sup> Product}: {priceOfTheProduct}
                </p>
                <p>
                    ...
                </p>
                <p>
                    ^^^{n<sup>th</sup> Product}: {priceOfTheProduct}
                </p>
                <p>
                    Total: {priceOfAllProducts}
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
Print the <strong>products</strong> ordered by <strong>price</strong> in<strong>descending</strong> order. Print <strong>each</strong> product only<strong>once</strong>. Format <strong>all</strong> prices to the    <strong>2<sup>nd</sup></strong> <strong>decimal place</strong>.
</p>
<h3>
    Constraints
</h3>
<ul>
    <li>
When you are receiving the <strong>prices</strong> of the<strong>products</strong>, you will <strong>not</strong> receive        <strong>duplicate</strong> product <strong>names</strong>.
    </li>
    <li>
        There will never be <strong>two</strong> <strong>people</strong> with
        the <strong>same</strong> <strong>total</strong> <strong>sum</strong>.
    </li>
</ul>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Bread 1.20
                </p>
                <p>
                    Butter 3.60
                </p>
                <p>
                    Milk 4
                </p>
                <p>
                    Beer 1.40
                </p>
                <p>
                    Sweets 4.20
                </p>
                <p>
                    Shop is open
                </p>
                <p>
                    Gosho: Bread, Beer, Bread
                </p>
                <p>
                    Pesho: Sweets, Butter
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Biggest spender: Pesho
                </p>
                <p>
                    ^Products bought:
                </p>
                <p>
                    ^^^Sweets: 4.20
                </p>
                <p>
                    ^^^Butter: 3.60
                </p>
                <p>
                    Total: 7.80
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    Bread 1.20
                </p>
                <p>
                    Butter 3.60
                </p>
                <p>
                    Beer 1.40
                </p>
                <p>
                    Sweets 4.20
                </p>
                <p>
                    Shop is open
                </p>
                <p>
                    Gosho: Bread, Beer, Bread
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Discount
                </p>
                <p>
                    Pesho: Sweets, Butter
                </p>
                <p>
                    Print
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    Biggest spender: Gosho
                </p>
                <p>
                    ^Products bought:
                </p>
                <p>
                    ^^^Beer: 0.60
                </p>
                <p>
                    ^^^Bread: 0.57
                </p>
                <p>
                    Total: 1.75
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Lambada Expressions
</h2>
<p>
    IT Researchers at the MIT (Massachusetts Institute of Technology) have
    discovered that, at certain (room) temperatures, the lambda expressions in
    their code are acting strange. In particular, a dancing behavior has been
    observed in them. The specialists choose to call this phenomenon – The
    Lambada expressions.
</p>
<h3>
    Input
</h3>
<p>
    You will be given several input lines in the following format:
</p>
<p>
    {selector} =&gt; {selectorObject}.{property}
</p>
<p>
    All elements of the input are <strong>strings</strong>. You need to store
    every <strong>lambada expression</strong>, as it is <strong>given</strong>.
</p>
<p>
    In some rare cases, you will receive the input “<strong>dance</strong>”,
    which indicates that the lambada expressions are starting to dance. When
that happens, you must <strong>COPY</strong> the<strong>selectorObject ONCE</strong> with a <strong>dot</strong> (“    <strong>.</strong>”) <strong>between</strong> it., so that it becomes
    “{selectorObject}.{selectorObject}”
</p>
<p>
    in <strong>every</strong> lambada expression’s <strong>condition</strong>.
    <br/>
In other words, if you have “x =&gt; x.Value”, and you say “    <strong>dance</strong>”, you should get “x =&gt; x.x.Value”.
</p>
<p>
    Check the examples for more info.
</p>
<p>
If you meet a <strong>selectorObject</strong> which<strong>already exists</strong>, you must <strong>replace</strong> its    <strong>property</strong> with the <strong>given new one</strong>.
</p>
<p>
    When you receive the command “lambada”, you must <strong>stop </strong>
    reading input.
</p>
<h3>
    Output
</h3>
<p>
Print all <strong>lambada expressions </strong>in    <strong>order of insertion</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="221" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="274" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    x =&gt; x.Key
                </p>
                <p>
                    object =&gt; object.Property
                </p>
                <p>
                    entry =&gt; entry.Name
                </p>
                <p>
                    lambada
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    x =&gt; x.Key
                </p>
                <p>
                    object =&gt; object.Property
                </p>
                <p>
                    entry =&gt; entry.Name
                </p>
            </td>
        </tr>
        <tr>
            <td width="221" valign="top">
                <p>
                    x =&gt; x.Key
                </p>
                <p>
                    x =&gt; x.Value
                </p>
                <p>
                    x =&gt; x.Name
                </p>
                <p>
                    dance
                </p>
                <p>
                    dance
                </p>
                <p>
                    dance
                </p>
                <p>
                    lambada
                </p>
            </td>
            <td width="274" valign="top">
                <p>
                    x =&gt; x.x.x.x.Name
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Ordered Banking System
</h2>
<p>
    You have been given the task to write software for banking – in particular,
    an optimized program, which stores only the bank account’s name, the bank
    account’s balance and the bank it is stored at.
</p>
<h3>
    Input
</h3>
<p>
    You will be given several input lines in the following format:
</p>
<p>
    {bank} -&gt; {account} -&gt; {balance}
</p>
<p>
The <strong>bank</strong> and the <strong>account</strong> are<strong>strings</strong>, and the <strong>balance</strong> is a    <strong>VARIABLE TYPE</strong> which is <strong>SUITABLE</strong> for
    storing <strong>MONEY</strong>.
</p>
<p>
    You should store every bank, each of its accounts, and their balances.
</p>
<p>
If you are given a <strong>bank</strong> which<strong>already exists</strong>, you must <strong>ADD</strong> the    <strong>new account</strong> to it.
    <br/>
If <strong>EVEN</strong> the <strong>account</strong> which<strong>already exists</strong>, you must <strong>INCREASE</strong> the    <strong>old balance</strong>, with the new <strong>given one</strong>.
</p>
<p>
    When you receive the command “<strong>end</strong>”, you must end the input
    sequence. Then you must print the data in a specified ordered format.
</p>
<h3>
    Output
</h3>
<p>
You must print each bank’s accounts and balances, ordering the<strong>BANKS</strong> by the <strong>sum</strong> of    <strong>all account balances</strong>, in <strong>descending order</strong>
    . If <strong>2 banks</strong> have the <strong>same sum</strong>, you
should print the <strong>one</strong> with the<strong>highest maximum balance</strong> in its <strong>accounts</strong>,    <strong>first</strong>.
</p>
<p>
The <strong>bank’s accounts</strong> must be ordered in    <strong>descending order</strong>, by <strong>their balance</strong>.
</p>
<p>
    The balances, must be printed, as they are given. “<strong>500</strong>” =
“<strong>500</strong>” … “<strong>500.00</strong>” = “    <strong>500.00</strong>”.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="302" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="294" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="302" valign="top">
                <p>
                    RaifaizenBank -&gt; Toshko -&gt; 200.4456
                </p>
                <p>
                    DSK -&gt; Toshko -&gt; 500.00
                </p>
                <p>
                    PIB -&gt; Ivan -&gt; 400.521
                </p>
                <p>
                    Piraeus -&gt; Ivan -&gt; 212.345
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Toshko -&gt; 500.00 (DSK)
                </p>
                <p>
                    Ivan -&gt; 400.521 (PIB)
                </p>
                <p>
                    Ivan -&gt; 212.345 (Piraeus)
                </p>
                <p>
                    Toshko -&gt; 200.4456 (RaifaizenBank)
                </p>
            </td>
        </tr>
        <tr>
            <td width="302" valign="top">
                <p>
                    DSK -&gt; Tesla -&gt; 2015125.45623
                </p>
                <p>
                    DSK -&gt; Tesla -&gt; 2000000
                </p>
                <p>
                    DSK -&gt; Microsoft -&gt; 400000
                </p>
                <p>
                    DSK -&gt; Apple -&gt; 200000
                </p>
                <p>
                    DSK -&gt; Microsoft -&gt; 350000
                </p>
                <p>
                    DSK -&gt; Apple -&gt; 550000
                </p>
                <p>
                    end
                </p>
            </td>
            <td width="294" valign="top">
                <p>
                    Tesla -&gt; 4015125.45623 (DSK)
                </p>
                <p>
                    Microsoft -&gt; 750000 (DSK)
                </p>
                <p>
                    Apple -&gt; 750000 (DSK)
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. LINQuistics
</h2>
<p>
    LINQ is the greatest .NET component of all time. You can do almost anything
    with it. That’s why you have been tasked to do almost everything you can
    with it.
</p>
<h3>
    Input
</h3>
<p>
    You will be given several input lines containing information about
    collections, and LINQ methods that have been called on them, in the
    following format:
</p>
<p>
    {collection}.{method1}().{method2}()....{methodN}()
</p>
<p>
The <strong>count</strong> of <strong>methods</strong> may    <strong>vary</strong>. Your task is to <strong>store</strong> every
    collection and the <strong>methods</strong> that have been executed on it.
If the collection <strong>already exists</strong>, you must    <strong>ADD</strong> the new methods to it. <strong>Duplicate</strong>
    methods should be <strong>REMOVED</strong>.
</p>
<h3>
    Output
</h3>
<p>
    If you are given <strong>only</strong> a <strong>collection name</strong>,
you must <strong>print</strong> the <strong>methods</strong> that have been    <strong>executed</strong> on the collection, <strong>ordered</strong> by
their <strong>length</strong> in <strong>descending order</strong>. If<strong>2 methods</strong> have the <strong>same length</strong>,<strong>order</strong> them by the <strong>count</strong> of    <strong>unique symbols</strong> they have in <strong>their names</strong>
    in <strong>descending order</strong>.
</p>
<p>
Each method must be printed on a <strong>new line</strong>, with a prefixed    <strong>asterisk and space</strong> (“* ”).
</p>
<p>
If the collection name does <strong>NOT</strong> exist, you should    <strong>IGNORE</strong> that line of input.
</p>
<p>
If you are given <strong>only</strong> a <strong>digit</strong>, you must<strong>take</strong> <strong>the collection</strong> which<strong> has the most methods</strong>, and print the<strong>first N methods</strong>, with the <strong>lowest length</strong> (    <strong>N</strong> being the <strong>digit</strong> <strong>given</strong>
in the <strong>input</strong>). If there are <strong>less</strong> than    <strong>N</strong> methods you must print <strong>all</strong> of them in
    the <strong>same order</strong>.
</p>
<p>
    <strong>NOTE</strong>
: When printing, you must print <strong>only</strong> the    <strong>method name</strong>, <strong>without</strong> its brackets (e.g.
    “First”, <strong>not</strong> “First()”).
</p>
<p>
    The input sequence ends when you receive the command “<strong>exit</strong>
    ”. After the ending command, you will receive one last line in the
    following format:
    <br/>
    {method} {selection}
</p>
<p>
You must <strong>take all</strong> collections, which    <strong> CONTAIN</strong> the <strong>given method</strong>, and print
    them. The selection will either be “collection” or “all”.
    <br/>
If you have “collection”, you must <strong>print</strong> only the    <strong>collections’ names</strong> in the final output.
    <br/>
If you have “all”, you must <strong>print</strong> the    <strong>collections</strong> <strong>and their methods</strong> in the
    following format:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="123" valign="top">
                <p>
                    {collection}
                    <br/>
                    * {method1}
                    <br/>
                    * {method2}
                    <br/>
                    ...
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
The collections must be printed ordered by the<strong>count of their methods</strong> in    <strong>descending order</strong>.
</p>
<p>
If <strong>2 collections</strong> have the <strong>same</strong><strong>amount of methods</strong>, print the <strong>one</strong> whose    <strong>shortest method name</strong> is <strong>longer</strong> than the
    other one’s <strong>shortest method name</strong>.
</p>
<p>
The <strong>methods</strong> must be printed, ordered by their    <strong>length</strong> in <strong>descending order</strong>.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="310" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="153" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="310" valign="top">
                <p>
                    participants.Max().Reverse().ThenBy()
                </p>
                <p>
                    participants.OrderBy.Select()
                </p>
                <p>
                    participants
                </p>
                <p>
                    participants.ToDictionary()
                </p>
                <p>
                    collection.Max()
                </p>
                <p>
                    collection.Break()
                </p>
                <p>
                    exit
                </p>
                <p>
                    Max all
                </p>
            </td>
            <td width="153" valign="top">
                <p>
                    * OrderBy
                </p>
                <p>
                    * Reverse
                </p>
                <p>
                    * ThenBy
                </p>
                <p>
                    * Select
                </p>
                <p>
                    * Max
                </p>
                <p>
                    participants
                </p>
                <p>
                    * ToDictionary
                </p>
                <p>
                    * Reverse
                </p>
                <p>
                    * OrderBy
                </p>
                <p>
                    * ThenBy
                </p>
                <p>
                    * Select
                </p>
                <p>
                    * Max
                </p>
                <p>
                    collection
                </p>
                <p>
                    * Break
                </p>
                <p>
                    * Max
                </p>
            </td>
        </tr>
        <tr>
            <td width="310" valign="top">
                <p>
                    elements.Sort()
                </p>
                <p>
                    elements.OrderBy()
                </p>
                <p>
                    bound
                </p>
                <p>
                    elements.Reverse().Select().ThenBy()
                </p>
                <p>
                    keys.Reverse().OrderByDescending()
                </p>
                <p>
                    keys.Reverse().ThenByDescending()
                </p>
                <p>
                    3
                </p>
                <p>
                    keys.Reverse().OrderBy().ThenBy()
                </p>
                <p>
                    values.ToString().ToString().ThenBy()
                </p>
                <p>
                    exit
                </p>
                <p>
                    Reverse collection
                </p>
            </td>
            <td width="153" valign="top">
                <p>
                    * Sort
                </p>
                <p>
                    * Select
                </p>
                <p>
                    * ThenBy
                </p>
                <p>
                    keys
                </p>
                <p>
                    elements
                </p>
            </td>
        </tr>
    </tbody>
</table>