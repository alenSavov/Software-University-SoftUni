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
if(isset($_GET['num'])){
    $num = intval($_GET['num']);
    for ($i = $num; $i > 0; $i--) {
        if($i % 2 !== 0){
            echo $i.' ';
        }
    }
}
?>
</body>
</html>