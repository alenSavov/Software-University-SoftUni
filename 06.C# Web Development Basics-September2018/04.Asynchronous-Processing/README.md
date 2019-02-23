<h1 align="center">
    Lab: Asynchronous Programming
</h1>
<p>
    This document defines the <strong>in-class exercises</strong> assignments
    for the
    <a href="https://softuni.bg/courses/csharp-web-development-basics">
        "C# Web Development Basics" course @ Software University
    </a>
    .
</p>
<p>
    <strong>1. </strong>
    <strong>Even Numbers Thread</strong>
</p>
<p>
    Print all even numbers in a given range. Printing should be executed on a
    separate thread. After finishing print "Thread finished work".
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="339">
                <p>
                    <a name="_Hlk492405192"><strong>Input</strong></a>
                </p>
            </td>
            <td width="340">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="339" valign="top">
                <p>
                    1 10
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    2
                </p>
                <p>
                    4
                </p>
                <p>
                    6
                </p>
                <p>
                    8
                </p>
                <p>
                    10
                </p>
                <p>
                    Thread finished work
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    Use the Thread class and its methods Start() and Join().
</p>
<p>
    <strong>2. </strong>
    <strong>Slice File</strong>
</p>
<p>
    Slice given file into given number of pieces. You will receive the name of
    the file, the destination folder to keep the pieces and the number of
    pieces.
</p>
<p>
    While executing the operation the console interface should stay responsive.
</p>
<h3>
    Examples
</h3>
<table border="0" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="325" valign="top">
            </td>
            <td width="343" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    Implement the slicing logic
</p>
<p>
    Inside this method check if the destination folder exists and if not –
    create it.
</p>
<p>
    Open FileStream to read the source file and create FileInfo object to keep
    the source file data.
</p>
<p>
    Start processing each new piece by creating its name.
</p>
<p>
    Open new stream to write the piece in the destination folder.
</p>
<p>
    Print a message when the slicing is over.
</p>
<p>
    Write a method that runs a task with the slicing logic.
</p>
<p>
    Read the input and call the method, that runs the task.
</p>
<h2>
    3. Simple Web Server
</h2>
<p>
    Write a simple web server that receives requests from a client. Print the
    request to the console and send a message to the client.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="234">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="476">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="234" rowspan="2" valign="top">
            </td>
            <td width="476" valign="top">
            </td>
        </tr>
        <tr>
            <td width="476" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    Note: Sent data may not be accepted by every browser (cough *chrome*
    cough).
</p>
<h3>
    Hints
</h3>
<p>
    Write a task to connect with the client
</p>
<p>
    Read the request and print it on the console.
</p>
<p>
    Send a greeting to the client.
</p>
<p>
    Close the connection.
</p>
<p>
    Create a TcpListener object a start the connection task.
</p>