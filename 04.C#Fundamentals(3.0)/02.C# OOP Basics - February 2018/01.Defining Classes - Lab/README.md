<h1 align="center">
    Lab: Defining Classes
</h1>
<p>
    Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/csharp-oop-basics">
        "C# OOP Basics" course @ SoftUni
    </a>
    ".
</p>
<p>
    You can check your solutions here:
    <a href="https://judge.softuni.bg/Contests/674/Defining-Classes-Lab">
        https://judge.softuni.bg/Contests/674/Defining-Classes-Lab
    </a>
</p>
<h2>
    Problem 1. Bank Account
</h2>
<p>
    Create a <strong>class</strong> named BankAccount.
</p>
<p>
    The class should have <strong>private</strong> <strong>fields</strong> for:
</p>
<ul>
    <li>
        id: int
    </li>
    <li>
        balance: decimal
    </li>
</ul>
<p>
The class should also have <strong>public</strong>    <strong>properties</strong> for:
</p>
<ul>
    <li>
        Id: int
    </li>
    <li>
        Balance: decimal
    </li>
</ul>
<p>
    You should be able to use the class like this:
</p>
<h3>
    Solution
</h3>
<p>
Create a <strong>new class</strong> and ensure    <strong>proper naming</strong>
</p>
<h2>
    Problem 2. Bank Account Methods
</h2>
<p>
    Create a class BankAccount (you can use class from previous task)
</p>
<p>
    The class should have private fields for:
</p>
<ul>
    <li>
        id: int
    </li>
    <li>
        balance: decimal
    </li>
</ul>
<p>
    The class should also have properties for:
</p>
<ul>
    <li>
        Id: int
    </li>
    <li>
        Balance: decimal
    </li>
    <li>
        Deposit(decimal amount): void
    </li>
</ul>
<p>
    · Withdraw(decimal amount): void
</p>
<p>
    Override the method ToString().
</p>
<p>
    You should be able to use the class like this:
</p>
<h3>
    Solution
</h3>
<p>
    Create a method Deposit(decimal amount)
</p>
<p>
    Create a method Withdraw(decimal amount)
</p>
<p>
    <strong>Override</strong>
    the method ToString()
</p>
<h2>
    Problem 3. Test Client
</h2>
<p>
    Create a test client that tests your BankAccount class.
</p>
<p>
    Support the <strong>following commands</strong>:
</p>
<ul>
    <li>
        <strong>Create {Id}</strong>
    </li>
    <li>
        <strong>Deposit {Id} {amount}</strong>
    </li>
    <li>
        <strong>Withdraw {Id} {amount}</strong>
    </li>
    <li>
        <strong>Print {Id}</strong>
    </li>
    <li>
        <strong>End</strong>
    </li>
</ul>
<p>
If you try to create an account with an existing Id, print    <strong>"Account already exists".</strong>
</p>
<p>
If you try to perform an operation on a<strong>non-existing account</strong>, print    <strong>"<a name="OLE_LINK3">Account does not exist</a>"</strong>.
</p>
<p>
    If you try to withdraw an amount larger than the balance, print
    <strong>
        "<a name="OLE_LINK5"></a><a name="OLE_LINK4">Insufficient balance</a>"
    </strong>
    .
</p>
<p>
The Print command should print    <strong>"Account ID{id}, balance {balance}"</strong>. Round the balance to
    the second digit after the decimal separator.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="124" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="248" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="124" valign="top">
                <p>
                    Create 1
                </p>
                <p>
                    Create 1
                </p>
                <p>
                    Deposit 1 20
                </p>
                <p>
                    Withdraw 1 30
                </p>
                <p>
                    Withdraw 1 10
                </p>
                <p>
                    Print 1
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="248" valign="top">
                <p>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">Account already exists</a>
                </p>
                <p>
                    <a name="OLE_LINK9"></a>
                    <a name="OLE_LINK8">Insufficient balance</a>
                </p>
                <p>
                    <a name="OLE_LINK11"></a>
                    <a name="OLE_LINK10">Account ID1, balance 10.00</a>
                </p>
            </td>
        </tr>
        <tr>
            <td width="124" valign="top">
                <p>
                    Deposit 2 20
                </p>
                <p>
                    Withdraw 2 30
                </p>
                <p>
                    Print 2
                </p>
                <p>
                    End
                </p>
            </td>
            <td width="248" valign="top">
                <p>
                    <a name="OLE_LINK7"></a>
                    <a name="OLE_LINK6">Account does not exist</a>
                </p>
                <p>
                    Account does not exist
                </p>
                <p>
                    Account does not exist
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Solution
</h3>
<p>
    Create a Dictionary&lt;int, BankAccount&gt; to store existing accounts
</p>
<p>
    Create the input loop:
</p>
<p>
    Check the <strong>type of command</strong> and <strong>execute</strong>
accordingly (<strong><em>optional:</em></strong>    <em> you can create a separate method for each command</em>)
</p>
<p>
    Implement the <strong>Create</strong> command:
</p>
<p>
    Implement the rest of the commands following the same logic.
</p>
<h2>
    Problem 4. Person Class
</h2>
<p>
    Create a <strong>Person</strong> class.
</p>
<p>
    The class should have <strong>private fields</strong> for:
</p>
<ul>
    <li>
        name: <strong>string</strong>
    </li>
    <li>
        age: <strong>int</strong>
    </li>
    <li>
        accounts: List&lt;BankAccount&gt;
    </li>
</ul>
<p>
    The class should have <strong>constructors</strong>:
</p>
<p>
    · Person(string name, int age)
</p>
<p>
    · Person(string name, int age, List&lt;BankAccount&gt; accounts)
</p>
<p>
    The class should also have <strong>public methods</strong> for:
</p>
<ul>
    <li>
        GetBalance(): decimal
    </li>
</ul>
<h3>
    Solution
</h3>
<p>
    Create the class as usual:
</p>
<p>
    Create a constructor with two parameters:
</p>
<p>
    Create a constructor with three parameters:
</p>
<p>
    Create method GetBalance():
</p>
<p>
    <strong><em>Optional:</em></strong>
You can take advantage of <strong>constructor chaining</strong>:    <strong></strong>
</p>