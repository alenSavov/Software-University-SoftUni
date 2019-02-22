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
<!--Write your PHP Script here-->
<?php
$num = 0;
if(isset($_GET['num'])){
    $num = intval($_GET['num']);
}
for ($i = 1; $i <= $num; $i++) {
    $resutl = fibonachi($i);
    echo $resutl.' ';
}
function fibonachi(int $n): int{
    $a = 0;
    $b = 1;
    for ($i=0; $i < $n; $i++) {
        $temp = $a;
        $a = $b;
        $b = $temp + $b;
    }
    return $a;
}
?>
</body>
</html>