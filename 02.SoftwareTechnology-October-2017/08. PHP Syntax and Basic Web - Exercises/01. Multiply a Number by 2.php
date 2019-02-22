<?php
$result = "";
if (isset($_GET['num'])){
    if ($num = floatval(htmlspecialchars($_GET['num']))){
        $result = $num * 2;
    }
}
?>
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
    <div><?= $result ?></div>
</form>
</body>
</html>