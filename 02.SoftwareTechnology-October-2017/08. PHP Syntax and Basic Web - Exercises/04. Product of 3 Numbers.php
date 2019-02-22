<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
    <?php
    if (isset($_GET['num1']) && (isset($_GET['num2']) && (isset($_GET['num3'])))) {
        $numbers[] = floatval(htmlspecialchars($_GET['num1']));
        $numbers[] = floatval(htmlspecialchars($_GET['num2']));
        $numbers[] = floatval(htmlspecialchars($_GET['num3']));

        $isPositive = true;
        foreach ($numbers as $num) {
            $isPositive = $num < 0 ? !$isPositive : $isPositive;
            if ($num == 0) {
                $isPositive = true;
                break;
            }
        }

        echo $isPositive ?
            "Positive" :
            "Negative";

    }
    ?>
</body>
</html>