<h1 align="center">
    Exercises: Advanced Querying
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
    BookShop System
</h1>
<p>
    For the following tasks, use the
    <a
        href="http://svn.softuni.org/admin/svn/csharp-databases/2017-Sept/DB-Advanced-EF-Core/06.%20DB-Advanced-EF-Core-Advanced-Querying/BookShop.zip"
    >
        BookShop
    </a>
database. You can download the complete project or create it yourself in    <strong>task 0</strong>,<strong> </strong>but you should still use the
pre-defined Seed() method from the project to have the same    <strong>sample</strong> data.
</p>
<h2>
    0. Book Shop Database
</h2>
<p>
You must create a <strong>database</strong> for a <strong>book</strong>    <strong>shop</strong> <strong>system</strong>. It should look like this:
</p>
<h3>
    Constraints
</h3>
<p>
    Your <strong>namespaces</strong> should be:
</p>
<p>
    · BookShop.StartUp – for your <strong>StartUp</strong> class
</p>
<p>
    · BookShop.Data – for your DbContext
</p>
<p>
    · BookShop.Models – for your models
</p>
<p>
    Your <strong>models</strong> should be:
</p>
<p>
    · BookShopContext – your DbContext
</p>
<ul>
    <li>
        Author:
    </li>
</ul>
<p>
    o AuthorId
</p>
<p>
    o FirstName (up to 50 characters, unicode, not required)
</p>
<p>
    o LastName (up to 50 characters, unicode)
</p>
<ul>
    <li>
        Book:
    </li>
</ul>
<p>
    o BookId
</p>
<p>
    o Title (up to 50 characters, unicode)
</p>
<p>
    o Description (up to 1000 characters, unicode)
</p>
<p>
    o ReleaseDate (not required)
</p>
<p>
    o Copies (an integer)
</p>
<p>
    o Price
</p>
<p>
    o EditionType – enum (Normal, Promo, Gold)
</p>
<p>
    o AgeRestriction – enum (Minor, Teen, Adult)
</p>
<p>
    o Author
</p>
<p>
    o BookCategories
</p>
<ul>
    <li>
        Category:
    </li>
</ul>
<p>
    o CategoryId
</p>
<p>
    o Name (up to 50 characters, unicode)
</p>
<p>
    o CategoryBooks
</p>
<p>
    · BookCategory – mapping class
</p>
<p>
    For the following tasks, you will be creating methods that accept a
    BookShopContext as a parameter and use it to run some queries. Create those
    methods inside your <strong>StartUp</strong> class and upload your whole
    solution to <strong>Judge</strong>.
</p>
<h2>
    1. Age Restriction
</h2>
<p>
    Create a <strong>method GetBooksByAgeRestriction</strong>(BookShopContext
    context, <strong>string</strong> <strong>command</strong>), that returns in
a <strong>single</strong> <strong>string </strong>all<strong> </strong>book<strong>titles</strong>, each on a <strong>new line, </strong>that have<strong> age</strong> <strong>restriction</strong>, equal to the<strong>given</strong> <strong>command</strong>. Order the titles    <strong>alphabetically</strong>.
</p>
<p>
Read <strong>input</strong> from the console in your <strong>main</strong><strong>method</strong>, and call your <strong>method</strong> with the<strong>necessary</strong> <strong>arguments</strong>. Print the<strong>returned</strong> <strong>string</strong> to the console.    <strong>Ignore</strong> casing of the input.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="64" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    miNor
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    A Confederacy of Dunces
                </p>
                <p>
                    A Farewell to Arms
                </p>
                <p>
                    A Handful of Dust
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    teEN
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    A Passage to India
                </p>
                <p>
                    A Scanner Darkly
                </p>
                <p>
                    A Swiftly Tilting Planet
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    2. Golden Books
</h2>
<p>
    Just like in task 1, write a method <strong>GetGoldenBooks</strong>
(BookShopContext context), that returns in a <strong>single</strong> string<strong>titles of the golden edition books</strong> that have<strong>less than 5000 copies</strong>,<strong> </strong>each on a<strong> new line</strong>. Order them by <strong>book</strong>    <strong>id</strong> ascending.
</p>
<p>
Call the <strong>GetGoldenBooks()</strong> method in your    <strong>Main()</strong> and print the returned string to the console.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="313" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="313" valign="top">
                <p>
                    Lilies of the Field
                </p>
                <p>
                    Look Homeward
                </p>
                <p>
                    The Mirror Crack'd from Side to Side
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    3. Books by Price
</h2>
<p>
    Write a <strong>GetBooksByPrice</strong>(BookShopContext context) method
that returns in a single string all <strong>titles and prices</strong>    <strong>of books</strong> with <strong>price higher than 40</strong>, each
on a <strong>new</strong> <strong>row</strong> in the    <strong>format</strong> given below. Order them by <strong>price</strong>
    descending.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="284" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="284" valign="top">
                <p>
                    O Pioneers! - $49.90
                </p>
                <p>
                    That Hideous Strength - $48.63
                </p>
                <p>
                    A Handful of Dust - $48.63
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    4. Not Released In
</h2>
<p>
Write a <strong>GetBooksNotRealeasedIn</strong>(BookShopContext context<strong>, int year</strong>) method that returns in a    <strong>single</strong> string all <strong>titles of books</strong> that
are <strong>NOT released</strong> on a given year. Order them by    <strong>book</strong> <strong>id</strong> ascending.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="64" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    2000
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    Absalom
                </p>
                <p>
                    Nectar in a Sieve
                </p>
                <p>
                    Nine Coaches Waiting
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    1998
                </p>
            </td>
            <td width="286" valign="top">
                <p>
                    The Needle's Eye
                </p>
                <p>
                    No Country for Old Men
                </p>
                <p>
                    No Highway
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    5. Book Titles by Category
</h2>
<p>
    Write a <strong>GetBooksByCategory</strong>(BookShopContext context, string
    input) method that <strong>selects</strong> and <strong>returns </strong>in
a single string the<strong> titles of books</strong> by a given<strong>list of categories</strong>. The list of    <strong>categories</strong> will be given in a single line separated with
    one or more spaces. Ignore casing. Order by <strong>title</strong>
    alphabetically.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="198" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="198" valign="top">
                <p>
                    horror mystery drama
                </p>
            </td>
            <td width="246" valign="top">
                <p>
                    A Fanatic Heart
                </p>
                <p>
                    A Farewell to Arms
                </p>
                <p>
                    A Glass of Blessings
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    6. Released Before Date
</h2>
<p>
    Write a <strong>GetBooksReleasedBefore</strong>(BookShopContext context,
string date) method that    <strong>returns the title, edition type and price </strong>of all books
    that are <strong>released before a given date</strong>. The date will be a
    string
    <strong>
in format <a name="OLE_LINK3"></a><a name="OLE_LINK2"></a>        <a name="OLE_LINK1">dd-MM-yyyy</a>
    </strong>
    .
</p>
<p>
Return all of the rows in a <strong>single</strong> string, ordered by    <strong>release</strong> <strong>date</strong> <strong>descending</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="91" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="467" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="91" valign="top">
                <p>
                    12-04-1992
                </p>
            </td>
            <td width="467" valign="top">
                <p>
                    If I Forget Thee Jerusalem - Gold - $33.21
                </p>
                <p>
                    Oh! To be in England - Normal - $46.67
                </p>
                <p>
                    The Monkey's Raincoat - Normal - $46.93
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="91" valign="top">
                <p>
                    30-12-1989
                </p>
            </td>
            <td width="467" valign="top">
                <p>
                    A Fanatic Heart - Normal - $9.41
                </p>
                <p>
                    The Curious Incident of the Dog in the Night-Time - Normal
                    - $23.41
                </p>
                <p>
                    The Other Side of Silence - Gold - $46.26
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    7. Author Search
</h2>
<p>
    Write a <strong>GetAuthorNamesEndingIn</strong>(BookShopContext context,
string input) method that returns the <strong>full</strong><strong>names</strong> of <strong>authors</strong>, whose<strong>first</strong> <strong>name</strong> ends with a    <strong>given</strong> <strong>string</strong>.
</p>
<p>
Return all <strong>names</strong> in a <strong>single</strong><strong>string</strong>, each on a <strong>new</strong>    <strong>row</strong>, ordered alphabetically.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="64" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="191" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    e
                </p>
            </td>
            <td width="191" valign="top">
                <p>
                    George Powell
                </p>
                <p>
                    Jane Ortiz
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    dy
                </p>
            </td>
            <td width="191" valign="top">
                <p>
                    Randy Morales
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    8. Book Search
</h2>
<p>
    Write a <strong>GetBookTitlesContaining</strong>(BookShopContext context,
string input) method that returns the <strong>titles</strong> of<strong>book</strong>, which contain a <strong>given</strong>    <strong>string</strong>. Ignore casing.
</p>
<p>
Return all <strong>titles</strong> in a <strong>single</strong><strong>string</strong>, each on a <strong>new</strong>    <strong>row</strong>, ordered alphabetically.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="64" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    sK
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    A Catskill Eagle
                </p>
                <p>
                    The Daffodil Sky
                </p>
                <p>
                    The Skull Beneath the Skin
                </p>
            </td>
        </tr>
        <tr>
            <td width="64" valign="top">
                <p>
                    WOR
                </p>
            </td>
            <td width="229" valign="top">
                <p>
                    Great Work of Time
                </p>
                <p>
                    Terrible Swift Sword
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    9. Book Search by Author
</h2>
<p>
    Write a <strong>GetBooksByAuthor</strong>(BookShopContext context, string
input) method that    <strong>returns all titles of books and their authors’ names </strong>for
books, which are written by authors whose last names    <strong> start with the given string</strong>.
</p>
<p>
Return a single string with each title on a new row.<strong>Ignore</strong> casing. Order by <strong>book</strong>    <strong>id</strong> ascending.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="63" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="495" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="63" valign="top">
                <p>
                    R
                </p>
            </td>
            <td width="495" valign="top">
                <p>
                    The Heart Is Deceitful Above All Things (Bozhidara
                    Rysinova)
                </p>
                <p>
                    His Dark Materials (Bozhidara Rysinova)
                </p>
                <p>
                    The Heart Is a Lonely Hunter (Bozhidara Rysinova)
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
        <tr>
            <td width="63" valign="top">
                <p>
                    po
                </p>
            </td>
            <td width="495" valign="top">
                <p>
                    Postern of Fate (Stanko Popov)
                </p>
                <p>
                    Precious Bane (Stanko Popov)
                </p>
                <p>
                    The Proper Study (Stanko Popov)
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    10. Count Books
</h2>
<p>
    Write a <strong>CountBooks</strong>(BookShopContext context, int
    lengthCheck) method that <strong>returns the number of books, </strong>
    which have a <strong>title longer than the number</strong> given as an
    input.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="63" valign="top">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td width="429" valign="top">
                <p>
                    <strong>Comments</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="63" valign="top">
                <p>
                    12
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    169
                </p>
            </td>
            <td width="429" valign="top">
                <p>
                    There are 169 books with longer title than 12 symbols
                </p>
            </td>
        </tr>
        <tr>
            <td width="63" valign="top">
                <p>
                    40
                </p>
            </td>
            <td width="66" valign="top">
                <p>
                    2
                </p>
            </td>
            <td width="429" valign="top">
                <p>
                    There are 2 books with longer title than 40 symbols
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    11. Total Book Copies
</h2>
<p>
    Write a method <strong>CountCopiesByAuthor</strong>(BookShopContext
context) that <strong>returns</strong> the<strong>total number of book copies</strong><strong>for each author</strong>. Order the results    <strong>descending by total book copies</strong>.
</p>
<p>
    Return all results in a <strong>single</strong> <strong>string</strong>,
    each on a <strong>new</strong> <strong>line</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="208" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="208" valign="top">
                <p>
                    Stanko Popov - 117778
                </p>
                <p>
                    Lyubov Ivanova - 107391
                </p>
                <p>
                    Jane Ortiz – 103673
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    12. Profit by Category
</h2>
<p>
    Write a method <strong>GetTotalProfitByCategory</strong>(BookShopContext
context) that <strong>returns</strong> the    <strong>total profit of all books by category</strong>. Profit for a book
    can be calculated by multiplying its <strong>number of copies</strong> by
the <strong>price per single book</strong>. Order the results by<strong>descending by total profit</strong> for category and    <strong>ascending by category name</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="264" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="264" valign="top">
                <p>
                    Art $6428917.79
                </p>
                <p>
                    Fantasy $5291439.71
                </p>
                <p>
                    Adventure $5153920.77
                </p>
                <p>
                    Children's $4809746.22
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    13. Most Recent Books
</h2>
<p>
Get the most recent books by categories in a<strong>GetMostRecentBooks</strong>(BookShopContext context) method. The<strong>categories</strong> should be ordered by    <strong>name alphabetically</strong>. Only take the <strong>top 3</strong>
most recent books from each category - ordered by<strong>release date</strong> (descending). <strong>Select</strong> and<strong>print</strong> the <strong>category name</strong>, and for each<strong>book</strong> – its <strong>title</strong> and    <strong>release year</strong>.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="434">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="434" valign="top">
                <p>
                    --Action
                </p>
                <p>
                    Brandy of the Damned (2015)
                </p>
                <p>
                    Bonjour Tristesse (2013)
                </p>
                <p>
                    By Grand Central Station I Sat Down and Wept (2010)
                </p>
                <p>
                    --Adventure
                </p>
                <p>
                    The Cricket on the Hearth (2013)
                </p>
                <p>
                    Dance Dance Dance (2002)
                </p>
                <p>
                    Cover Her Face (2000)
                </p>
                <p>
                    …
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    14. Increase Prices
</h2>
<p>
    Write a method <strong>IncreasePrices</strong>(BookShopContext context)
that <strong>increases the prices of all books</strong>    <strong>released before 2010 by 5</strong>.
</p>
<h2>
    15. Remove Books
</h2>
<p>
Write a method <strong>RemoveBooks</strong>(BookShopContext context) that    <strong>removes from the database</strong> those <strong>books</strong>,
which have less than <strong>4200 copies</strong>. Return an<strong>int</strong> - the    <strong>number of books that were deleted</strong> from the database.
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="201" valign="top">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="201" valign="top">
                <p>
                    34 books were deleted
                </p>
            </td>
        </tr>
    </tbody>
</table>