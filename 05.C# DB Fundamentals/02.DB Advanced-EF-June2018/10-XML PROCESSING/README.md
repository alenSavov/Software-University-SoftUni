<h1 align="center">
    Exercises: XML Processing
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a
        href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017"
    >
        "Databases Advanced – EF Core" course @ Software University
    </a>
    .
</p>
<h1>
    XML Format
</h1>
<h2>
    1. Students XML
</h2>
<p>
    Create a XML document students.xml in your favorite editor, which contains
    structured description of students. For each student you should enter
information for his <strong>name</strong>, <strong>gender</strong>,<strong>birth date</strong> (in ISO 8601 format),<strong>phone number </strong>(optional), <strong>email</strong>,<strong>university</strong>, <strong>specialty</strong>,<strong>faculty number</strong> (optional) and a list of taken    <strong>exams</strong> (exam name, date taken, grade). Use only elements
    (tags).
</p>
<p>
    Create a new file students.xml and insert some xml with a structure similar
    to this one:
</p>
<h2>
    2. Catalog of Musical Albums
</h2>
<p>
Create a XML file catalog.xml representing a catalog of musical    <strong>albums</strong>. For each album you should define name, artist,
    year, producer, price and a list of songs. Each song should be described by
    title and duration.
</p>
<p>
    Hint: You can take sample data from
    <a href="https://gist.github.com/jasonbaldridge/2597611">
        https://gist.github.com/jasonbaldridge/2597611
    </a>
    .
</p>
<h1>
    Product Shop Database
</h1>
<h2>
    1. Setup Database
</h2>
<p>
A products shop holds <strong>users</strong>, <strong>products</strong> and<strong>categories</strong> for the products. Users can    <strong>sell</strong> and <strong>buy</strong> products.
</p>
<ul type="disc">
    <li>
Users have an <strong>id</strong>, <strong>first</strong><strong>name</strong> (optional) and <strong>last</strong>        <strong>name</strong> (at least 3 characters) and <strong>age </strong>
        (optional).
    </li>
    <li>
        Products have an <strong>id</strong>, <strong>name</strong> (at least 3
        characters), <strong>price</strong>, <strong>buyerId </strong>
        (optional) and <strong>sellerId</strong> as IDs of users.
    </li>
    <li>
Categories have an <strong>id</strong> and <strong>name</strong> (from        <strong>3</strong> to <strong>15</strong> characters)
    </li>
</ul>
<p>
    Using Entity Framework Code First create a database following the above
    description.
</p>
<p>
    Configure the following relations in your EF models:
</p>
<ul type="disc">
    <li>
        <strong>Users</strong>
should have <strong>many products sold</strong> and        <strong>many products bought</strong>.
    </li>
    <li>
        <strong>Products</strong>
        should have<strong> many categories</strong>
    </li>
    <li>
        <strong>Categories</strong>
        should have <strong>many products</strong>
    </li>
    <li>
        <strong>CategoryProducts </strong>
        should<strong> map products </strong>and<strong> categories</strong>
    </li>
</ul>
<h2>
    2. Import Data
</h2>
<p>
    <strong>Import</strong>
the data from the provided files (<strong>users.xml</strong>,    <strong>products.xml</strong>,<strong> categories.xml</strong>).
</p>
<p>
Import the <strong>users</strong> first. When importing products, randomly    <strong>select the buyer</strong> and <strong>seller</strong> from the
existing users. Leave out some <strong>products</strong> that have    <strong>not been sold</strong> (i.e. buyer is null).
</p>
<p>
    Randomly <strong>generate categories</strong> for each product from the
    existing categories.
</p>
<h2>
    3. Query and Export Data
</h2>
<p>
    Write the below described queries and <strong>export</strong> the returned
    data to the specified <strong>format</strong>. Make sure that Entity
    Framework generates only a <strong>single query</strong> for each task.
</p>
<h3>
    Query 1. Products In Range
</h3>
<p>
    Get all products in a specified <strong>price range</strong> between 1000
    and 2000 (inclusive) which have <strong>buyer</strong>. Order them by price
(from lowest to highest). Select only the <strong>product name</strong>,<strong>price</strong> and the <strong>full name</strong>    <strong>of the buyer</strong>. Export the result to XML.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>products-in-range.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;products&gt;
                    </p>
                    <p>
                        &lt;product name="TYLENOL COLD MULTI-SYMPTOM DAYTIME"
                        price="1010.81" buyer="Sandra Riley" /&gt;
                    </p>
                    <p>
                        &lt;product name="Butalbital, Aspirin and Caffeine"
                        price="1010.98" buyer=" Bennett" /&gt;
                    </p>
                    <p>
                        &lt;product name="SEPHORA Acne-Fighting Mattifying
                        Moisturizer" price="1019.28" buyer="Patricia Cooper"
                        /&gt;
                    </p>
                    <p>
                        &lt;/products&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 2. Sold Products
</h3>
<p>
Get all users who have <strong>at least 1 sold item</strong>. Order them by    <strong>last name</strong>, then by <strong>first name</strong>. Select the
    person's <strong>first</strong> and <strong>last name</strong>. For each of
the <strong>sold products</strong>, select the product's    <strong>name</strong> and <strong>price</strong>.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>users-sold-products.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;users&gt;
                    </p>
                    <p>
                        &lt;user first-name="Carl" last-name="Daniels"&gt;
                    </p>
                    <p>
                        &lt;sold-products&gt;
                    </p>
                    <p>
                        &lt;product&gt;
                    </p>
                    <p>
                        &lt;name&gt;Peter Island Continous sunscreen
                        kids&lt;/name&gt;
                    </p>
                    <p>
                        &lt;price&gt;471.30&lt;/price&gt;
                    </p>
                    <p>
                        &lt;/product&gt;
                    </p>
                    <p>
                        &lt;product&gt;
                    </p>
                    <p>
                        &lt;name&gt;Warfarin Sodium&lt;/name&gt;
                    </p>
                    <p>
                        &lt;price&gt;1379.79&lt;/price&gt;
                    </p>
                    <p>
                        &lt;/product&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/sold-products&gt;
                    </p>
                    <p>
                        &lt;/user&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/users&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 3. Categories By Products Count
</h3>
<p>
Get <strong>all</strong> <strong>categories</strong>. Order them by the    <strong>number of products</strong> in that category (a product can be in
many categories). For each category select its <strong>name</strong>, the<strong>number of products</strong>, the<strong>average price of those products</strong> and the    <strong>total revenue</strong> (total price sum) of those products
    (regardless if they have a buyer or not).
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="518" valign="top">
                    <p align="center">
                        <strong>categories-by-products.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="518" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;categories&gt;
                    </p>
                    <p>
                        &lt;category name="Sports"&gt;
                    </p>
                    <p>
                        &lt;products-count&gt;49&lt;/products-count&gt;
                    </p>
                    <p>
                        &lt;average-price&gt;754.327755&lt;/average-price&gt;
                    </p>
                    <p>
                        &lt;total-revenue&gt;36962.06&lt;/total-revenue&gt;
                    </p>
                    <p>
                        &lt;/category&gt;
                    </p>
                    <p>
                        &lt;category name="Adult"&gt;
                    </p>
                    <p>
                        &lt;products-count&gt;46&lt;/products-count&gt;
                    </p>
                    <p>
                        &lt;average-price&gt;905.283478&lt;/average-price&gt;
                    </p>
                    <p>
                        &lt;total-revenue&gt;41643.04&lt;/total-revenue&gt;
                    </p>
                    <p>
                        &lt;/category&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/categories&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 4. Users and Products
</h3>
<p>
    Get all users who have <strong>at least 1 sold product</strong>. Order them
    by the <strong>number of sold products</strong> (from highest to lowest),
then by <strong>last name</strong> (ascending). Select only their    <strong>first</strong> and <strong>last name</strong>, <strong>age</strong>
    and for each product - <strong>name</strong> and <strong>price</strong>.
</p>
<p>
    Export the results to <strong>XML</strong>. Follow the format below to
    better understand how to structure your data.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>users-and-products.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;users count="35"&gt;
                    </p>
                    <p>
                        &lt;user first-name="Carl" last-name="Daniels"
                        age="59"&gt;
                    </p>
                    <p>
                        &lt;sold-products count="10"&gt;
                    </p>
                    <p>
                        &lt;product name="Finasteride" price="1374.01" /&gt;
                    </p>
                    <p>
                        &lt;product name="Peter Island Continous sunscreen
                        kids" price="471.30" /&gt;
                    </p>
                    <p>
                        &lt;product name="Warfarin Sodium" price="1379.79"
                        /&gt;
                    </p>
                    <p>
                        &lt;product name="Gilotrif" price="1454.77" /&gt;
                    </p>
                    <p>
                        &lt;product name="Cold and Cough" price="218.14" /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/sold-products&gt;
                    </p>
                    <p>
                        &lt;/user&gt;
                    </p>
                    <p>
                        &lt;user last-name="Harris"&gt;
                    </p>
                    <p>
                        &lt;sold-products count="9"&gt;
                    </p>
                    <p>
                        &lt;product name="Clarins Paris Skin Illusion - 114
                        cappuccino" price="811.42" /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/sold-products&gt;
                    </p>
                    <p>
                        &lt;/user&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/users&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h1>
    Car Dealer Database
</h1>
<h2>
    1. Setup Database
</h2>
<p>
    A car dealer needs information about cars, their parts, parts suppliers,
    customers and sales.
</p>
<ul>
    <li>
        <strong>Cars</strong>
        have <strong>make, model</strong>, travelled distance in kilometers
    </li>
    <li>
        <strong>Parts</strong>
have <strong>name</strong>, <strong>price</strong> and        <strong>quantity</strong>
    </li>
    <li>
        Part <strong>supplier</strong> have <strong>name</strong> and info
        whether he <strong>uses imported parts</strong>
    </li>
    <li>
        <strong>Customer</strong>
        has <strong>name</strong>, <strong>date of birth</strong> and info
        whether he <strong>is young driver</strong> (Young driver is a driver
that has <strong>less than 2 years</strong><strong> of experience</strong>. Those customers get        <strong>additional 5% off</strong> for the sale.)
    </li>
    <li>
        <strong>Sale</strong>
has <strong>car</strong>, <strong>customer </strong>and        <strong>discount percentage</strong>
    </li>
</ul>
<p>
A <strong>price of a car</strong> is formed by    <strong>total price of its parts</strong>.
</p>
<p>
    Using Entity Framework Code First create a database following the above
    description.
</p>
<p>
    Configure the following relations in your EF models:
</p>
<ul>
    <li>
A <strong>car</strong> has <strong>many parts</strong> and        <strong>one part</strong> can be placed <strong>in many cars</strong>
    </li>
    <li>
        <strong>One supplier</strong>
        can supply <strong>many parts</strong> and each <strong>part </strong>
        can be delivered by <strong>only one supplier</strong>
    </li>
    <li>
        In <strong>one sale</strong>, only <strong>one car</strong> can be sold
    </li>
    <li>
        <strong>Each sale</strong>
        has <strong>one customer</strong> and <strong>a customer</strong> can
        buy <strong>many cars</strong>
    </li>
</ul>
<h2>
    2. Import Data
</h2>
<p>
Import data from the provided files (    <strong>suppliers.xml, parts.xml, cars.xml, customers.xml</strong>).
</p>
<p>
First import <strong>suppliers</strong>. When importing    <strong>parts</strong> set to each part <strong>random supplier</strong>
from already imported suppliers. Then, when importing cars add<strong>between 10 and 20 random parts</strong> to each car. Then import<strong>all customers</strong>. Finally, import<strong>sales records</strong> by <strong>random </strong>selecting a<strong> car, customer </strong>and the amount of    <strong> discount to be applied </strong>(discounts can be 0%, 5%, 10%,
    15%, 20%, 30%, 40% or 50%).
</p>
<h2>
    3. Query and Export Data
</h2>
<p>
    Write the below described queries and <strong>export</strong> the returned
    data to the specified <strong>format</strong>. Make sure that Entity
    Framework generates only a <strong>single query</strong> for each task.
</p>
<h3>
    Query 1. Cars with Distance
</h3>
<p>
    Get all <strong>cars</strong> with distance more than 2,000,000. Order them
    by make, then by model alphabetically. <strong>Export </strong>the list of
    cars <strong>to XML</strong> in the format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="454" valign="top">
                    <p align="center">
                        <strong>cars.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="454" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;cars&gt;
                    </p>
                    <p>
                        &lt;car&gt;
                    </p>
                    <p>
                        &lt;make&gt;Alfa Romeo&lt;/make&gt;
                    </p>
                    <p>
                        &lt;model&gt;156&lt;/model&gt;
                    </p>
                    <p>
                        &lt;travelled-distance&gt;92233720368547&lt;/travelled-distance&gt;
                    </p>
                    <p>
                        &lt;/car&gt;
                    </p>
                    <p>
                        &lt;car&gt;
                    </p>
                    <p>
                        &lt;make&gt;Alfa Romeo&lt;/make&gt;
                    </p>
                    <p>
                        &lt;model&gt;156&lt;/model&gt;
                    </p>
                    <p>
                        &lt;travelled-distance&gt;92036854775807&lt;/travelled-distance&gt;
                    </p>
                    <p>
                        &lt;/car&gt;
                    </p>
                    <p>
                        &lt;car&gt;
                    </p>
                    <p>
                        &lt;make&gt;Alfa Romeo&lt;/make&gt;
                    </p>
                    <p>
                        &lt;model&gt;164&lt;/model&gt;
                    </p>
                    <p>
                        &lt;travelled-distance&gt;92233775807&lt;/travelled-distance&gt;
                    </p>
                    <p>
                        &lt;/car&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/cars&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 2. Cars from make Ferrari
</h3>
<p>
Get all <strong>cars</strong> from make <strong>Ferrari</strong> and<strong>order them by model alphabetically</strong> and by    <strong>travelled distance descending</strong>. <strong>Export</strong> the
    list of <strong>cars to XML</strong> in the format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="491" valign="top">
                    <p align="center">
                        <strong>ferrari-cars.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="491" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;cars&gt;
                    </p>
                    <p>
                        &lt;car id="232" model="250 GTO"
                        travelled-distance="214747" /&gt;
                    </p>
                    <p>
                        &lt;car id="237" model="250 GTO"
                        travelled-distance="214747" /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/cars&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 3. Local Suppliers
</h3>
<p>
Get all <strong>suppliers</strong> that<strong>do not import parts from abroad</strong>. Get their<strong>id</strong>, <strong>name</strong> and<strong>the number of parts they can offer to supply</strong>.    <strong>Export </strong>the list of suppliers <strong>to XML</strong> in
    the format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="489" valign="top">
                    <p align="center">
                        <strong>local-suppliers.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="489" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;suppliers&gt;
                    </p>
                    <p>
                        &lt;suplier id="2" name="Agway Inc." parts-count="6"
                        /&gt;
                    </p>
                    <p>
                        &lt;suplier id="4" name="Airgas, Inc." parts-count="5"
                        /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/suppliers&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 4. Cars with Their List of Parts
</h3>
<p>
Get all <strong>cars along with their list of parts</strong>. For the<strong>car</strong> get only <strong>make, model </strong>and    <strong>travelled distance</strong> and for the <strong>parts</strong> get
only <strong>name</strong> and <strong>price</strong>.<strong>Export</strong> the list of    <strong>cars and their parts to XML</strong> in the format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>cars-and-parts.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;cars&gt;
                    </p>
                    <p>
                        &lt;car make="Opel" model="Omega"
                        travelled-distance="2147483647" /&gt;
                    </p>
                    <p>
                        &lt;parts&gt;
                    </p>
                    <p>
                        &lt;part name="Front Left Side Outer door handle"
                        price="999.99" /&gt;
                    </p>
                    <p>
                        &lt;part name="Gudgeon pin" price="44.99" /&gt;
                    </p>
                    <p>
                        &lt;part name="Oil pump" price="100.19" /&gt;
                    </p>
                    <p>
                        &lt;part name="Transmission pan" price="106.99" /&gt;
                    </p>
                    <p>
                        &lt;/parts&gt;
                    </p>
                    <p>
                        &lt;/car&gt;
                    </p>
                    <p>
                        &lt;car make="Opel" model="Astra"
                        travelled-distance="9223372036854775807" /&gt;
                    </p>
                    <p>
                        &lt;parts&gt;
                    </p>
                    <p>
                        &lt;part name="Overflow tank" price="1200.99" /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/parts&gt;
                    </p>
                    <p>
                        &lt;/car&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/cars&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 5. Total Sales by Customer
</h3>
<p>
Get all <strong>customers</strong> that have bought<strong>at least 1 car</strong> and get their <strong>names</strong>,<strong>bought cars</strong> <strong>count</strong> and    <strong>total spent money</strong> on cars. <strong>Order</strong> the
result list <strong>by total spent money descending</strong> then by    <strong>total bought cars</strong> again in <strong>descending</strong>
order. <strong>Export</strong> the list of customers <strong>to</strong>    <strong>XML</strong> in the format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>customers-total-sales.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;customers&gt;
                    </p>
                    <p>
                        &lt;customer full-name="Hipolito Lamoreaux"
                        bought-cars="5" spent-money="8360.48" /&gt;
                    </p>
                    <p>
                        &lt;customer full-name="Francis Mckim" bought-cars="4"
                        spent-money="7115.50" /&gt;
                    </p>
                    <p>
                        &lt;customer full-name="Johnette Derryberry"
                        bought-cars="4" spent-money="5337.72" /&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/customer&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>
<h3>
    Query 6. Sales with Applied Discount
</h3>
<p>
Get all <strong>sales</strong> with information about the    <strong>car</strong>, <strong>customer</strong> and <strong>price</strong>
of the sale <strong>with and without discount</strong>.    <strong>Export</strong> the list of sales <strong>to XML</strong> in the
    format provided below.
</p>
<div align="center">
    <table border="1" cellspacing="0" cellpadding="0">
        <tbody>
            <tr>
                <td width="566" valign="top">
                    <p align="center">
                        <strong>sales-discounts.xml</strong>
                    </p>
                </td>
            </tr>
            <tr>
                <td width="566" valign="top">
                    <p>
                        &lt;?xml version="1.0" encoding="utf-8"?&gt;
                    </p>
                    <p>
                        &lt;sales&gt;
                    </p>
                    <p>
                        &lt;sale&gt;
                    </p>
                    <p>
                        &lt;car make="Peugeot" model="405"
                        travelled-distance="92036854775807" /&gt;
                    </p>
                    <p>
                        &lt;customer-name&gt;Donnetta
                        Soliz&lt;/customer-name&gt;
                    </p>
                    <p>
                        &lt;discount&gt;0.3&lt;/discount&gt;
                    </p>
                    <p>
                        &lt;price&gt;1402.53&lt;/price&gt;
                    </p>
                    <p>
                        &lt;price-with-discount&gt;981.771&lt;/price-with-discount&gt;
                    </p>
                    <p>
                        &lt;/sale&gt;<strong></strong>
                    </p>
                    <p>
                        &lt;sale&gt;
                    </p>
                    <p>
                        ...
                    </p>
                    <p>
                        &lt;/sales&gt;
                    </p>
                </td>
            </tr>
        </tbody>
    </table>
</div>