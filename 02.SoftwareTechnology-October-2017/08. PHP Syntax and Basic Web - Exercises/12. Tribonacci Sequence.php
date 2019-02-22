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
if (isset($_GET['num'])) {
    $num = intval(htmlspecialchars($_GET['num']));
    if ($num > 0) {
        $fibMinus3 = 0;
        $fibMinus2 = 0;
        $fibMinus1 = 1;
        $fibonadcciN = 1;
        for ($i = 0; $i < $num; $i++) {
            $fibonadcciN = $fibMinus3 + $fibMinus2 + $fibMinus1;
            $fibArray[] = $fibMinus1;
            $fibMinus3 = $fibMinus2;
            $fibMinus2 = $fibMinus1;
            $fibMinus1 = $fibonadcciN;
        }
        echo implode(" ", $fibArray);
    }
}
?>
</body>
</html>