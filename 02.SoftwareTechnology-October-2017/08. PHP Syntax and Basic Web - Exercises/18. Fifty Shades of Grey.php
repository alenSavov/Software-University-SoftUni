<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<!--Write your PHP Script here-->
<?php
$rows = 0;
while ( $rows != 255) {
    for ($i= $rows; $i < $rows + 50; $i += 5) {
        echo "<div style='background-color: rgb($i,$i,$i)'></div>";
    }
    $rows += 51;
    echo "<br/>";
}
?>
</body>
</html>