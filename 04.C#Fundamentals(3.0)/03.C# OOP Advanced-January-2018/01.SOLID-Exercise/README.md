<h1 align="center">
    Exercises: Open / Closed and Liskov
</h1>
<p>
    This document defines the exercises for
    <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">
        "C# OOP Advanced" course @ Software University
    </a>
    .
</p>
<h2>
    1. Logger
</h2>
<p>
    Write a logging library for logging messages. The interface for the
    end-user should be as follows:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="202" valign="top">
                <p align="center">
                    <strong>Sample Source Code</strong>
                </p>
            </td>
            <td width="369" valign="top">
                <p align="center">
                    <strong>Sample Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="202" valign="top">
                <p>
                    <a name="OLE_LINK11"></a>
                    <a name="OLE_LINK2"></a>
                    <a name="OLE_LINK1">ILayout</a>
                    simpleLayout = new SimpleLayout();
                </p>
                <p>
                    IAppender consoleAppender =
                </p>
                <p>
                    new ConsoleAppender(simpleLayout);
                </p>
                <p>
                    ILogger logger = new Logger(consoleAppender);
                </p>
                <p>
                    logger.Error("3/26/2015 2:08:11 PM", "Error parsing
                    JSON.");
                </p>
                <p>
                    logger.Info("3/26/2015 2:08:11 PM", "User Pesho
                    successfully registered.");
                </p>
            </td>
            <td width="369">
            </td>
        </tr>
    </tbody>
</table>
<p>
    Logger logs data and time (string) and a message (string).
</p>
<h3>
    Library Architecture
</h3>
<p>
    The library should have the following components:
</p>
<ul>
    <li>
        <strong>Layouts</strong>
- define the format in which messages should be appended (e.g.<strong>SimpleLayout</strong> displays logs in the format        <a name="OLE_LINK4"></a>
        <a name="OLE_LINK3">
            "
            <strong>
                &lt;date-time&gt; - &lt;report level&gt; - &lt;message&gt;
            </strong>
            ")
        </a>
    </li>
    <li>
        <strong>Appenders -</strong>
        responsible for appending the messages somewhere (e.g. Console, File,
        etc.)
    </li>
    <li>
        <strong>Loggers</strong>
        - hold methods for various kinds of logging (warnings, errors, info,
        etc.)
    </li>
</ul>
<p>
    Whenever a logger is told to log something, it calls all of its appenders
    and tells them to append the message. In turn, the appenders append the
    message (e.g. to the console or a file) according to the layout they have.
</p>
<h3>
    Requirements
</h3>
<p>
    You library should correctly follow all <strong>SOLID</strong> principles:
</p>
<ul>
    <li>
        <strong>Single Responsibility Principle</strong>
        - no class or method should do more than one thing at once
    </li>
    <li>
        <strong>Open-Closed Principle</strong>
        - the library should be open for extension (i.e. its user should be
        able to create his own layouts/appenders/loggers)
    </li>
    <li>
        <strong>Liskov Substitution Principle -</strong>
children classes should not break the behavior of their parent        <strong></strong>
    </li>
    <li>
        <strong>Interface Segregation Principle</strong>
        - the library should provide simple interfaces for the client to
        implement
    </li>
    <li>
        <strong>Dependency Inversion</strong>
        - no class/method should directly depend on concretions (only on
        abstractions)
    </li>
</ul>
<p>
    Avoid code repetition. Name everything accordingly.
</p>
<h3>
    Implementations
</h3>
<p>
    The library should provide the following ready classes for the client:
</p>
<ul>
    <li>
        <strong>SimpleLayout</strong>
        - defines the format "
        <strong>
            &lt;date-time&gt; - &lt;report level&gt; - &lt;message&gt;
        </strong>
        "
    </li>
    <li>
        <strong>ConsoleAppender</strong>
        - appends a log to the console using the provided layout
    </li>
    <li>
        <strong>FileAppender</strong>
        - appends a log to a file using the provided layout
    </li>
    <li>
        <strong>LogFile </strong>
        - a custom file class which logs messages in a string builder using a
method <strong>Write()</strong>. It should have a        <strong>getter</strong> for its <strong>size</strong> which is the sum
        of the ascii codes of all alphabet characters it contains (e.g. a-z and
        A-Z)
    </li>
    <li>
        <strong>Logger </strong>
        - a logger class which is used to log messages. Calls each of its
        appenders when something needs to be logged
    </li>
</ul>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="552" valign="top">
                <p align="center">
                    <strong>Sample Source Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
                <p>
                    <a name="OLE_LINK12"></a>
                    <a name="OLE_LINK6"></a>
                    <a name="OLE_LINK5">var</a>
                    simpleLayout = new SimpleLayout();
                </p>
                <p>
                    var consoleAppender = new ConsoleAppender(simpleLayout);
                </p>
                <p>
                    var file = new LogFile();
                </p>
                <p>
                    var fileAppender = new FileAppender(simpleLayout);
                </p>
                <p>
                    fileAppender.File = file;
                </p>
                <p>
                    var logger = new Logger(consoleAppender, fileAppender);
                </p>
                <p>
                    logger.Error("3/26/2015 2:08:11 PM", "Error parsing
                    JSON.");
                </p>
                <p>
                    logger.Info("3/26/2015 2:08:11 PM", "User Pesho
                    successfully registered.");
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>
    The above code should log the messages both on the <strong>console</strong>
    and in <strong>log.txt</strong> in the format <strong>SimpleLayout</strong>
    provides.
</p>
<h3>
    Extensibility
</h3>
<p>
The end-user should be able to add his own <strong>layouts</strong>/    <strong>appenders</strong>/<strong>loggers</strong> and use them. For
    example, he should be able to create his own <strong>XmlLayout</strong> and
make the appenders use it, <strong>without directly</strong>    <strong> editing</strong> the library source code.
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="552" valign="top">
                <p align="center">
                    <strong>Sample Source Code</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
                <p>
                    <a name="OLE_LINK13"></a>
                    <a name="OLE_LINK8"></a>
                    <a name="OLE_LINK7">var</a>
                    xmlLayout = new XmlLayout();
                </p>
                <p>
                    var consoleAppender = new ConsoleAppender(xmlLayout);
                </p>
                <p>
                    var logger = new Logger(consoleAppender);
                </p>
                <p>
                    logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not
                    respond");
                </p>
                <p>
                    logger.Critical("3/31/2015 5:23:54 PM", "No connection
                    string found in App.config");
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
                <p align="center">
                    <strong>Console Output</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="552">
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Report Threshold
</h3>
<p>
    Implement a <strong>report level threshold</strong> in all appenders. The
appender should append only messages with report level    <strong>above or equal to </strong>its report level threshold (by default
    all messages are appended). The report level is in the order
    <a name="OLE_LINK15">
        Info &gt; Warning &gt; Error &gt; Critical &gt; Fatal.
    </a>
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="552" valign="top">
                <p align="center">
                    <strong>Sample Source Code</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
                <p>
                    <a name="OLE_LINK16"></a>
                    <a name="OLE_LINK14"></a>
                    <a name="OLE_LINK10"></a>
                    <a name="OLE_LINK9">var</a>
                    simpleLayout = new SimpleLayout();
                </p>
                <p>
                    var consoleAppender = new ConsoleAppender(simpleLayout);
                </p>
                <p>
                    consoleAppender.ReportLevel = ReportLevel.Error;
                </p>
                <p>
                    var logger = new Logger(consoleAppender);
                </p>
                <p>
                    logger.Info("3/31/2015 5:33:07 PM", "Everything seems
                    fine");
                </p>
                <p>
                    logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too
                    high - disconnect imminent");
                </p>
                <p>
                    logger.Error("3/31/2015 5:33:07 PM", "Error parsing
                    request");
                </p>
                <p>
                    logger.Critical("3/31/2015 5:33:07 PM", "No connection
                    string found in App.config");
                </p>
                <p>
                    logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not
                    respond");
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
                <p align="center">
                    <strong>Console Output</strong>
                    <strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="552" valign="top">
            </td>
        </tr>
    </tbody>
</table>
<p>
    Only messages from error and above are appended.
</p>
<h3>
    File
</h3>
<p>
    A file should write all messages internally and it should keep information
    about its size.
</p>
<p>
    Size of a file is calculated by summing ASCII codes of all alphabet
    characters (a-Z). For example, a file appender with simple layout and a
single message    <strong>"3/31/2015 5:33:07 PM - ERROR - Error parsing request" </strong>has
    size 2606 (including all characters in PM, ERROR, Error, parsing, request).
    In case of Xml layout, the file would have size 6632, because of the extra
    characters within the tags.
</p>
<h3>
    Controller
</h3>
<p>
    Implement a Controller which reads all appenders that a Logger will have
    and input messages from the console. Every message should be evaluated by
    all the appenders and logged if they meet the report level. Console
    appenders should write directly on the console. File appenders write (save)
    the messages but do not print them.
</p>
<h3>
    Input
</h3>
<p>
    On the first line, you will get <strong>N</strong> - the number of
    appenders. On the next N lines, you will get information about the
    appenders in one of the formats below:
</p>
<ul>
    <li>
        <strong>
            "&lt;appender type&gt; &lt;layout type&gt; &lt;REPORT LEVEL&gt;"
        </strong>
    </li>
    <li>
        <strong>"&lt;appender type&gt; &lt;layout type&gt;"</strong>
    </li>
</ul>
<p>
    If no report level is provided, the appender should be set to record all
    messages.
</p>
<p>
    Next, until you get the "END" command you will receive messages containing
    report level, time and message separated by pipe "<strong>|</strong>":
</p>
<ul>
    <li>
        <strong>"&lt;REPORT LEVEL&gt;|&lt;time&gt;|&lt;message&gt;"</strong>
    </li>
</ul>
<h3>
    Output
</h3>
<p>
    Console appenders should print directly at the console in the layout they
    are provided:
</p>
<ul>
    <li>
Simple layout example -        <strong>"3/31/2015 5:33:07 PM - ERROR - Error parsing request"</strong>
    </li>
</ul>
<p>
    · Xml layout example (date, level and message tags are indented by 1
    tabulation):
</p>
<p>
    <strong>&lt;log&gt;</strong>
</p>
<p>
    <strong>&lt;date&gt;3/31/2015 5:33:07 PM&lt;/date&gt;</strong>
</p>
<p>
    <strong>&lt;level&gt;ERROR&lt;/level&gt;</strong>
</p>
<p>
    <strong>&lt;message&gt;Error parsing request&lt;/message&gt;</strong>
</p>
<p>
    <strong>&lt;/log&gt;</strong>
</p>
<p>
    After the "END" command you should print Logger info which includes
    statistics about every appender (its type, layout, report level, messages
    appended and file size for file appenders):
</p>
<p>
    <strong>"Logger info</strong>
</p>
<p>
    <strong>
        Appender type: &lt;appender type&gt;, Layout type: &lt;layout type&gt;,
        Report level: &lt;REPORT LEVEL&gt;, Messages appended: &lt;count&gt;,
        File size &lt;size&gt;"
    </strong>
    <strong></strong>
</p>
<h3>
    Example
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="690" valign="top">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="690" valign="top">
                <p>
                    2
                </p>
                <p>
                    ConsoleAppender SimpleLayout CRITICAL
                </p>
                <p>
                    FileAppender XmlLayout
                </p>
                <p>
                    INFO|3/26/2015 2:08:11 PM|Everything seems fine
                </p>
                <p>
                    WARNING|3/26/2015 2:22:13 PM|Warning: ping is too high -
                    disconnect imminent
                </p>
                <p>
                    ERROR|3/26/2015 2:32:44 PM|Error parsing request
                </p>
                <p>
                    CRITICAL|3/26/2015 2:38:01 PM|No connection string found in
                    App.config
                </p>
                <p>
                    FATAL|3/26/2015 2:39:19 PM|mscorlib.dll does not respond
                </p>
                <p>
                    END
                </p>
            </td>
        </tr>
        <tr>
            <td width="690" valign="top">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="690" valign="top">
                <p>
                    3/26/2015 2:38:01 PM - CRITICAL - No connection string
                    found in App.config
                </p>
                <p>
                    3/26/2015 2:39:19 PM - FATAL - mscorlib.dll does not
                    respond
                </p>
                <p>
                    Logger info
                </p>
                <p>
                    Appender type: ConsoleAppender, Layout type: SimpleLayout,
                    Report level: CRITICAL, Messages appended: 2
                </p>
                <p>
                    Appender type: FileAppender, Layout type: XmlLayout, Report
                    level: INFO, Messages appended: 5, File size: 37526
                </p>
            </td>
        </tr>
    </tbody>
</table>