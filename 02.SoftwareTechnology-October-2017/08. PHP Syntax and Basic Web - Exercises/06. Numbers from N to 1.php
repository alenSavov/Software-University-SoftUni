<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $startNum = intval(htmlspecialchars($_GET['num']));
    echo $startNum;
    $startNum--;
    for (; $startNum > 0; $startNum--){
        echo " ".$startNum;
    }
}
?>
</body>
</html>