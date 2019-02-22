<h1 align="center">
    Exercise: Streams and Files
</h1>
<p>
    This document defines the homework assignments from the
    <a href="https://softuni.bg/courses/csharp-advanced">
        "CSharp Advanced" course @ Software University
    </a>
    . Please submit as homework a single zip / rar / 7z archive holding the
    solutions (source code) of all below described problems. The solutions
    should be written in C#.
</p>
<h2>
    Problem 1. Odd Lines
</h2>
<p>
    Write a program that reads a <strong>text</strong> file and prints on the
    console its <strong>odd</strong> <strong>lines</strong>. Line numbers start
    from 0. Use <strong>StreamReader</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="282" valign="top">
                <p align="center">
                    <strong>text.txt</strong>
                </p>
            </td>
            <td width="276" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="282" valign="top">
                <p>
                    -I was quick to judge him, but it wasn't his fault.
                </p>
                <p>
                    -Is this some kind of joke?! Is it?
                </p>
                <p>
                    -Quick, hide here…It is safer.
                </p>
            </td>
            <td width="276" valign="top">
                <p>
                    -Is this some kind of joke?! Is it?
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 2. Line Numbers
</h2>
<p>
Write a program that <strong>reads</strong> a <strong>text</strong><strong>file</strong> and inserts <strong>line</strong><strong>numbers</strong> in front of <strong>each</strong> of its<strong>lines</strong>. The result should be <strong>written</strong> to    <strong>another</strong> text file. Use <strong>StreamReader</strong> in
    combination with <strong>StreamWriter</strong>.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="260" valign="top">
                <p align="center">
                    <strong>text.txt</strong>
                </p>
            </td>
            <td width="298" valign="top">
                <p align="center">
                    <strong>output.txt</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="260" valign="top">
                <p>
                    -I was quick to judge him, but it wasn't his fault.
                </p>
                <p>
                    -Is this some kind of joke?! Is it?
                </p>
                <p>
                    -Quick, hide here…It is safer.
                </p>
            </td>
            <td width="298" valign="top">
                <p>
                    Line 1: -I was quick to judge him, but it wasn't his fault.
                </p>
                <p>
                    Line 2: -Is this some kind of joke?! Is it?
                </p>
                <p>
                    Line 3: -Quick, hide here…It is safer.
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 3. Word Count
</h2>
<p>
Write a program that reads a <strong>list</strong> of<strong>words</strong> from the file<code><strong>words.txt</strong></code> and finds <strong>how</strong><strong>many</strong> <strong>times</strong> each of the words is<strong>contained</strong> in another file<code><strong>text.txt</strong></code>    <code>. Matching should be <strong>case-insensitive</strong>.</code>
</p>
<p>
    <code>
Write the results in file <strong>results.txt</strong>.<strong>Sort</strong> the words by <strong>frequency</strong> in        <strong>descending</strong> order.
    </code>
Use <strong>StreamReader</strong> in combination with    <strong>StreamWriter</strong>.<code></code>
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="114" valign="top">
                <p align="center">
                    <strong>words.txt</strong>
                </p>
            </td>
            <td width="258" valign="top">
                <p align="center">
                    <strong>text.txt</strong>
                </p>
            </td>
            <td width="96" valign="top">
                <p align="center">
                    <strong>result.txt</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="114" valign="top">
                <p>
                    quick
                </p>
                <p>
                    is
                </p>
                <p>
                    fault
                </p>
            </td>
            <td width="258" valign="top">
                <p>
                    -I was quick to judge him, but it wasn't his fault.
                </p>
                <p>
                    -Is this some kind of joke?! Is it?
                </p>
                <p>
                    -Quick, hide here…It is safer.
                </p>
            </td>
            <td width="96" valign="top">
                <p>
                    is - 3
                </p>
                <p>
                    quick - 2
                </p>
                <p>
                    fault - 1
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 4. Copy Binary File
</h2>
<p>
    Write a program that copies the contents of a binary file (e.g. image,
video, etc.) to another using <strong>FileStream</strong>. You are    <strong>not allowed</strong> to use the <strong>File </strong>class or
    similar helper classes.
</p>
<h2>
    Problem 5. Slicing File
</h2>
<p>
Write a program that takes <strong>any</strong> <strong>file</strong> and    <strong>slices</strong> it to <strong>n</strong> parts. Write the following
    methods:
</p>
<ul>
    <li>
        <strong>
            Slice(string sourceFile, string destinationDirectory, int parts)
        </strong>
        - <strong>slices</strong> the given source file into <strong>n</strong>
parts and <strong>saves</strong> them in        <strong>destinationDirectory</strong>.
    </li>
</ul>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="195" valign="top">
                <p align="center">
                    <strong>Source File</strong>
                </p>
            </td>
            <td width="283" valign="top">
                <p align="center">
                    <strong>Destination Directory</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="195" valign="top">
                <p>
                    parts = 5
                </p>
            </td>
            <td width="283" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<ul>
    <li>
        <strong>
            Assemble(List&lt;string&gt; files, string destinationDirectory)
        </strong>
-<strong> combines</strong> all files into one, in the<strong>order</strong> they are <strong>passed</strong>, and<strong>saves</strong> the result in        <strong>destinationDirectory</strong>.
    </li>
</ul>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="283" valign="top">
                <p align="center">
                    <strong>Source Files</strong>
                </p>
            </td>
            <td width="197" valign="top">
                <p align="center">
                    <strong>Destination Directory</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="283" valign="top">
            </td>
            <td width="197" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    Use <strong>FileStreams</strong>. You are <strong>not allowed</strong> to
    use the <strong>File</strong> class or similar helper classes.
</p>
<h2>
    Problem 6. Zipping Sliced Files
</h2>
<p>
    <strong>Modify</strong>
    your previous program to also <strong>compress</strong> the bytes while
    slicing parts and <strong>decompress</strong> them when assembling them
    back to the <strong>original</strong> file. Use <strong>GzipStream</strong>
    .
</p>
<p>
    <strong>Tip</strong>
: When getting files from directory, make sure you only get files with    <strong>.gz</strong> extension (there might be hidden files).
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="195">
                <p align="center">
                    <strong>Source File</strong>
                </p>
            </td>
            <td width="303">
                <p align="center">
                    <strong>Compressed &amp; Sliced</strong>
                </p>
            </td>
            <td width="169">
                <p align="center">
                    <strong>Decompressed &amp; Assembled</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="195" valign="top">
                <p>
                    parts = 5
                </p>
            </td>
            <td width="303" valign="top">
            </td>
            <td width="169" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 7. Directory Traversal
</h2>
<p>
Traverse a given <strong>directory</strong> for <strong>all</strong>    <strong>files</strong> with the given <strong>extension</strong>. Search
through the <strong>first</strong> <strong>level</strong> of the    <strong>directory</strong> <strong>only</strong> and write information
    about each <strong>found</strong> file in <strong>report.txt</strong>.
</p>
<p>
The files should be <strong>grouped</strong> by their<strong>extension</strong>. <strong>Extensions</strong> should be<strong>ordered</strong> by the<strong> count </strong>of their files    <strong>descending</strong>, then by <strong>name alphabetically</strong>.
</p>
<p>
    <strong>Files</strong>
under an extension should be <strong>ordered</strong> by their    <strong>size</strong>.
</p>
<p>
    <strong>report.txt</strong>
    should be saved on the <strong>Desktop</strong>. Ensure the desktop path is
    always valid, regardless of the user.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="78" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="240" valign="top">
                <p align="center">
                    <strong>Directory View</strong>
                </p>
            </td>
            <td width="240" valign="top">
                <p align="center">
                    <strong>report.txt</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="78" valign="top">
                <p>
                    .
                </p>
            </td>
            <td width="240" valign="top">
            </td>
            <td width="240" valign="top">
                <p>
                    .cs
                </p>
                <p>
                    --Mecanismo.cs - 0.994kb
                </p>
                <p>
                    --Program.cs - 1.108kb
                </p>
                <p>
                    --Nashmat.cs - 3.967kb
                </p>
                <p>
                    --Wedding.cs - 23.787kb
                </p>
                <p>
                    --Program - Copy.cs - 35.679kb
                </p>
                <p>
                    --Salimur.cs - 588.657kb
                </p>
                <p>
                    .txt
                </p>
                <p>
                    --backup.txt - 0.028kb
                </p>
                <p>
                    --log.txt - 6.72kb
                </p>
                <p>
                    .asm
                </p>
                <p>
                    --script.asm - 0.028kb
                </p>
                <p>
                    .config
                </p>
                <p>
                    --App.config - 0.187kb
                </p>
                <p>
                    .csproj
                </p>
                <p>
                    --01. Writing-To-Files.csproj - 2.57kb
                </p>
                <p>
                    .js
                </p>
                <p>
                    --controller.js - 1635.143kb
                </p>
                <p>
                    .php
                </p>
                <p>
                    --model.php - 0kb
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
    Problem 8. * Full Directory Traversal
</h2>
<p>
Modify your previous program to <strong>recursively traverse</strong> the    <strong>sub-directories</strong> of the starting directory as well.
</p>
<h2>
    Problem 9. ** HTTP Server
</h2>
<p>
Create a simple HTTP server that should be able to<strong>receive requests</strong> and<strong>return appropriate responses</strong> accordingly to the    <strong>request path</strong>. <strong>Read</strong> more on the internet
    to see what HTTP request and response should look like. Create a web site
    of 3 pages:
</p>
<ul>
    <li>
        <strong>1<sup>st</sup></strong>
        page should be accessible at localhost:{port}/ - (that is the root
directory). That page holds just <strong>welcome message</strong> and        <strong>link</strong> to the second page
    </li>
    <li>
        <strong>2<sup>nd</sup></strong>
        page should be accessible at localhost:{port}/info – that page shows
the <strong>current time</strong> and the        <strong>count of logical processors</strong> on the machine
    </li>
    <li>
        <strong>3<sup>rd</sup> </strong>
        page should be an <strong>error page</strong> if the user tries to
        access any other page return as response the error page.
    </li>
</ul>
<p>
    You are provided with some HTML files of the needed pages to make it easier
    for you. You are free to modify them and even use your own HTML files.
</p>
<h3>
    Examples
</h3>