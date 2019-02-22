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
for ($i = $num; $i > 3; $i--) {
    if($i % 2 === 0 || $i % 3 === 0){
        continue;
    }else{
        echo $i.' ';
    }
}
$a = 2;
$b = 3;
echo $b.' '.$a.' ';
?>
</body>
</html>