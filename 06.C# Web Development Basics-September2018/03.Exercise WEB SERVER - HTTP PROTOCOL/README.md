<h1 align="center">
    Lab: HTTP Protocol
</h1>
<p>
    This document defines the <strong>in-class exercises</strong> assignments
    for the
    <a href="https://softuni.bg/courses/csharp-web-development-basics">
        "C# Web Development Basics" course @ Software University
    </a>
    . You can submit your code in the course web site.
</p>
<p>
    For these exercises there will be no actual web development. These are just
    simple console application, which aim to train your newly learned knowledge
    of the HTTP Protocol and its essentials.
</p>
<p>
    <strong>1. </strong>
    <strong>URL Decode</strong>
</p>
<p>
    You have been tasked to write a simple Console URL Decoder. You will
    receive an encoded URL. Your job is to decode the URL and print its decoded
    version on the console.
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="339">
                <p>
                    <strong>Input</strong>
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
                    http://www.google.bg/search?q=C%23
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    http://www.google.bg/search?q=C#
                </p>
            </td>
        </tr>
        <tr>
            <td width="339" valign="top">
                <p>
                    https://mysite.com/show?n%40m3= p3%24h0
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    https://mysite/show?n@m3= p3$h0
                </p>
            </td>
        </tr>
        <tr>
            <td width="339" valign="top">
                <p>
                    http://url-decoder.com/i%23de%25?id=23
                </p>
            </td>
            <td width="340" valign="top">
                <p>
                    http://url-decoder.com/i#de%?id=23
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    Use one of the methods of the WebUtility class.<strong></strong>
</p>
<p>
    <strong>2. </strong>
    <strong>Validate </strong>
    <strong>URL</strong>
</p>
<p>
    You have been tasked to create a simple Console URL Validator. The
    validator works with custom rules though.
</p>
<p>
You will receive <strong>encoded URL</strong>.<strong> Decode</strong> the    <strong>URL</strong> and <strong>validate</strong> it.
</p>
<ul>
    <li>
If the URL is <strong>valid</strong>, you must<strong>break it</strong> into its <strong>composite</strong>        <strong>particles</strong> and <strong>print</strong> them.
    </li>
    <li>
        If the URL is <strong>invalid</strong>, you must <strong>print</strong>
        an <strong>error</strong>.
    </li>
</ul>
<h3>
    URL Validation
</h3>
<p>
    A URL is validated by the following rules:
</p>
<table border="1" cellspacing="0" cellpadding="0">
    <tbody>
        <tr>
            <td width="121">
                <p>
                    Protocol
                </p>
            </td>
            <td width="340">
                <p>
                    <strong>Required</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="121">
                <p>
                    Host
                </p>
            </td>
            <td width="340">
                <p>
                    <strong>Required</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="121">
                <p>
                    Port
                </p>
            </td>
            <td width="340">
                <p>
                    <strong>Required </strong>
(default value for http - <strong>80</strong>, for https -                    <strong>443</strong>)<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="121">
                <p>
                    Path
                </p>
            </td>
            <td width="340">
                <p>
                    <strong>Required </strong>
                    (default value: /)<strong></strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="121">
                <p>
                    Query Strings
                </p>
            </td>
            <td width="340">
                <p>
                    Optional (multiple query strings are separated by &amp;)
                </p>
            </td>
        </tr>
        <tr>
            <td width="121">
                <p>
                    Fragment
                </p>
            </td>
            <td width="340">
                <p>
                    Optional
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Example URLs
</h3>
<h4>
    Valid URLs
</h4>
<ul>
    <li>
        http://mysite.com:80/demo/index.aspx
    </li>
    <li>
        https://my-site.bg
    </li>
    <li>
        https://mysite.bg/demo/search?id=22o#go
    </li>
</ul>
<h4>
    Invalid URLs
</h4>
<ul>
    <li>
        https://mysite:80/demo/index.aspx
    </li>
    <li>
        somesite.com:80/search?
    </li>
    <li>
        https/mysite.bg?id=2
    </li>
</ul>
<h3>
    Output
</h3>
<h4>
    Valid URL
</h4>
<p>
    A valid URL’s parts should be printed in the following format:
</p>
<p>
    "Protocol: {protocol}"
</p>
<p>
    "Host: {host}"
</p>
<p>
    "Port: {port}"
</p>
<p>
    "Path: {path}"
</p>
<p>
    "Query: {query string}" (if any)
</p>
<p>
    "Fragment: {fragment}" (if any)
</p>
<h4>
    Invalid URL
</h4>
<p>
    An invalid URL input should produce the following result:
</p>
<p>
    "Invalid URL".
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="386">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="255">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="386" valign="top">
                <p>
                    http://softuni.bg/
                </p>
            </td>
            <td width="255" valign="top">
                <p>
                    Protocol: http
                </p>
                <p>
                    Host: softuni.bg
                </p>
                <p>
                    Port: 80
                </p>
                <p>
                    Path: /
                </p>
            </td>
        </tr>
        <tr>
            <td width="386" valign="top">
                <p>
                    https://softuni.bg:447/search?Query=pesho&amp;Users=true#go
                </p>
            </td>
            <td width="255" valign="top">
                <p>
                    Protocol: https
                </p>
                <p>
                    Host: softuni.bg
                </p>
                <p>
                    Port: 447
                </p>
                <p>
                    Path: /search
                </p>
                <p>
                    Query: Query=pesho&amp;Users=true
                </p>
                <p>
                    Fragment: go
                </p>
            </td>
        </tr>
        <tr>
            <td width="386" valign="top">
                <p>
                    http://google.com:443/
                </p>
            </td>
            <td width="255" valign="top">
                <p>
                    Invalid URL
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h3>
    Hints
</h3>
<p>
    URL value can be encoded, so it's a good idea to use WebUtility.UrlDecode
    to decode it.
</p>
<h2>
    3. Request Parser
</h2>
<p>
    You have been tasked to write a <strong>console application</strong> that
simulates an <strong>HTTP Server</strong>’s behavior. You will be receiving    <strong>HTTP requests</strong> and printing <strong>HTTP responses</strong>
    for them in a custom format.
</p>
<p>
You will receive <strong>several lines</strong> with<strong>valid paths</strong>. The <strong>last part</strong> of the    <strong>path</strong> will be the <strong>allowed method</strong>. Keep
    reading paths until you receive "END".
</p>
<p>
    After that, you will receive a <strong>HTTP request</strong>. You will have
to <strong>parse</strong> the <strong>request</strong> and    <strong>return</strong> a response based on that request.
</p>
<p>
If the <strong>path</strong> of the <strong>given</strong> request<strong>CANNOT</strong> be <strong>found</strong> in the<strong>received paths</strong> or the <strong>request method</strong> is    <strong>NOT allowed</strong> for the <strong>path</strong>, the result will
    be:
</p>
<ul>
    <li>
        Status: 404 Not Found
    </li>
</ul>
<p>
    · Response Text: NotFound
</p>
<p>
    In all other cases the result will be:
</p>
<ul>
    <li>
        Status: 200 OK
    </li>
</ul>
<p>
    · Response Text: OK
</p>
<h3>
    Input
</h3>
<p>
    The input comes in the format "{path}/{method}".
</p>
<h3>
    Output
</h3>
<p>
    Write the result on the console in the following format:
</p>
<p>
    "HTTP/1.1 {status code}"
</p>
<p>
    "Content-Length: {length of response text}"
</p>
<p>
    "Content-Type: text/plain"
</p>
<p>
    <em>"\n"</em>
</p>
<p>
    "{response text}"
</p>
<h3>
    Examples
</h3>
<table border="1" cellspacing="0" cellpadding="0" width="0">
    <tbody>
        <tr>
            <td width="205">
                <p align="center">
                    <strong>Input</strong>
                </p>
            </td>
            <td width="213">
                <p align="center">
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    /register/get
                </p>
                <p>
                    /register/post
                </p>
                <p>
                    END
                </p>
                <p>
                    GET /register HTTP/1.1
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    HTTP/1.1 200 OK
                </p>
                <p>
                    Content-Length: 2
                </p>
                <p>
                    Content-Type: text/plain
                </p>
                <p>
                    OK
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    /login/get
                </p>
                <p>
                    /register/get
                </p>
                <p>
                    /login/post
                </p>
                <p>
                    END
                </p>
                <p>
                    POST /register HTTP/1.1
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    HTTP/1.1 404 NotFound
                </p>
                <p>
                    Content-Length: 9
                </p>
                <p>
                    Content-Type: text/plain
                </p>
                <p>
                    NotFound
                </p>
            </td>
        </tr>
        <tr>
            <td width="205" valign="top">
                <p>
                    /index/get
                </p>
                <p>
                    /index/post
                </p>
                <p>
                    END
                </p>
                <p>
                    POST /login HTTP/1.1
                </p>
            </td>
            <td width="213" valign="top">
                <p>
                    HTTP/1.1 404 NotFound
                </p>
                <p>
                    Content-Length: 9
                </p>
                <p>
                    Content-Type: text/plain
                </p>
                <p>
                    NotFound
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>
</h2>