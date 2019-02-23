<h1 align="center">
    Exercises: Advanced Relations
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
<h2>
    1. Bills Payment System
</h2>
<p>
    Your task is to create a database for <strong>Bills Payment System</strong>
    , using the <strong>Code First </strong>approach. In the database, we
should keep information about the <strong>users</strong> (    <strong>first name, last name, email, password, payment methods</strong>).
    Every <strong>payment method</strong> should have an <strong>id</strong>,
an <strong>owner</strong>, a <strong>type</strong> and a<strong>credit</strong> <strong>card</strong> or a <strong>bank</strong><strong>account</strong> connected to it. There are<strong>two types</strong> of billing details –    <strong>credit card</strong> and <strong>bank account</strong>. The credit
card has <strong>expiration date</strong>, a<strong> limit </strong>and<strong> </strong>an<strong> </strong>amount<strong> </strong>of<strong> money owed</strong>. The <strong>bank</strong><strong>account</strong> has a <strong>balance</strong>, a<strong>bank name</strong> and a <strong>SWIFT</strong>    <strong>code</strong>.
</p>
<p>
    Create the configuration of each model in a new class, implementing the
    IEntityTypeConfiguration interface. Your solution should look similar to
    this:
</p>
<h3>
    Constraints
</h3>
<p>
    Your <strong>namespaces</strong> should be:
</p>
<p>
    · P01_BillsPaymentSystem – for your Startup class, if you have one
</p>
<p>
    · P01_BillsPaymentSystem.Data – for your DbContext
</p>
<p>
    · P01_BillsPaymentSystem.Data.Models – for your models
</p>
<p>
    Your <strong>models</strong> should be:
</p>
<p>
    · BillsPaymentSystemContext – your DbContext
</p>
<ul>
    <li>
        User:
    </li>
</ul>
<p>
    o UserId
</p>
<p>
    o FirstName (up to 50 characters, unicode)
</p>
<p>
    o LastName (up to 50 characters, unicode)
</p>
<p>
    o Email (up to 80 characters, non-unicode)
</p>
<p>
    o Password (up to 25 characters, non-unicode)
</p>
<ul>
    <li>
        CreditCard:
    </li>
</ul>
<p>
    o CreditCardId
</p>
<p>
    o Limit
</p>
<p>
    o MoneyOwed
</p>
<p>
    o LimitLeft (calculated property, not included in the database)
</p>
<p>
    o ExpirationDate
</p>
<ul>
    <li>
        BankAccount:
    </li>
</ul>
<p>
    o BankAccountId
</p>
<p>
    o Balance
</p>
<p>
    o BankName (up to 50 characters, unicode)
</p>
<p>
    o SWIFT Code (up to 20 characters, non-unicode)
</p>
<ul>
    <li>
        PaymentMethod:
    </li>
</ul>
<p>
    o Id - PK
</p>
<p>
    o Type – enum (BankAccount, CreditCard)
</p>
<p>
    o UserId
</p>
<p>
    o BankAccountId
</p>
<p>
    o CreditCardId
</p>
<p>
    <strong>Everything</strong>
is required! Only <strong>PaymentMethod</strong>’s<strong>BankAccountId</strong> and <strong>CreditCardId </strong>should be    <strong>nullable</strong>,<strong> </strong>and you should make sure that
always <strong>one</strong> of them <strong>is</strong>    <strong>null</strong> and the <strong>other</strong> <strong>one</strong>
    is <strong>not </strong>(add a <strong>CHECK</strong> constraint).
</p>
<p>
Make sure that <strong>every</strong> <strong>record</strong> in the<strong>PaymentMethods</strong> table has a unique combination of<strong>UserId</strong>, <strong>BankAccountId</strong> and    <strong>CreditCardId</strong>!
</p>
<h2>
    2. Seed Some Data
</h2>
<p>
Make a <strong>Seed</strong>() method to seed some data into the    <strong>BillsPaymentSystem</strong> database.
</p>
<h2>
    3. User Details
</h2>
<p>
    Create a <strong>console</strong> <strong>app</strong> that retrieves from
the database a <strong>user</strong> and all of his<strong>payment</strong> <strong>methods </strong>by a given    <strong> user id</strong>, and prints them on the console in the format:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="566" valign="top">
                <p>
                    User: Guy Gilbert
                </p>
                <p>
                    Bank Accounts:
                </p>
                <p>
                    -- ID: 1
                </p>
                <p>
                    --- Balance: 2000.00
                </p>
                <p>
                    --- Bank: Unicredit Bulbank
                </p>
                <p>
                    --- SWIFT: UNCRBGSF
                </p>
                <p>
                    -- ID: 2
                </p>
                <p>
                    --- Balance: 1000.00
                </p>
                <p>
                    --- Bank: First Investment Bank
                </p>
                <p>
                    --- SWIFT: FINVBGSF
                </p>
                <p>
                    Credit Cards:
                </p>
                <p>
                    -- ID: 1
                </p>
                <p>
                    --- Limit: 800.00
                </p>
                <p>
                    --- Money Owed: 100.00
                </p>
                <p>
                    --- Limit Left:: 700.00
                </p>
                <p>
                    --- Expiration Date: 2020/03
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    First, list the user’s <strong>bank</strong> <strong>accounts</strong> and
then – his <strong>credit</strong> <strong>cards</strong>. If<strong>no</strong> such <strong>user</strong> exist, print "User with id {    <strong>userId</strong>} not found!" instead.
</p>
<h2>
    4. Pay Bills
</h2>
<p>
    Add <strong>Withdraw</strong>() and <strong>Deposit</strong>() methods to
    the <strong>BankAccount</strong> and <strong>CreditCard</strong> classes,
and make sure they are the only way you can change the<strong>Balance</strong>, <strong>MoneyOwed</strong> and    <strong>Limit</strong> properties. Then create a <strong>PayBills</strong>
    (int userId, decimal amount) method that uses all of a user’s payment
methods to pay his bills. Start with his <strong>bank</strong><strong>accounts</strong>, ordered by id, and then his<strong>credit</strong> <strong>cards</strong>, ordered by    <strong> id</strong>. If the user doesn’t have enough money available,
    don’t withdraw anything and print "Insufficient funds!" to the console.
</p>