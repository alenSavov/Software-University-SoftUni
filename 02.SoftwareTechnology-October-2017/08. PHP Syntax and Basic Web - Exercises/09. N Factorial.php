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
    $num = intval(htmlspecialchars($_GET['num']));
    if ($num > 0){
        $factorial = 1;
        for ($i = 2; $i <= $num; $i++){
            $factorial *= $i;
        }
        echo $factorial;
    }
}
?>
</body>
</html>