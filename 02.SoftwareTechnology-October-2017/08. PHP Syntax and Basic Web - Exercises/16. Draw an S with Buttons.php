<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<!--Write your PHP Script here-->
<?php
for ($i = 1; $i <= 9; $i++) {
    for ($j= 0; $j < 5; $j++) {
        if($i === 1 || $i === 5 || $i === 9){
            echo "<button style='background-color: blue'>1</button>";
        } else if ($i < 5){
            if($j === 0){
                echo "<button style='background-color: blue'>1</button>";
            }else {
                echo "<button>0</button>";
            }
        }else if ($i < 9){
            if($j === 4){
                echo "<button style='background-color: blue'>1</button>";
            }else {
                echo "<button>0</button>";
            }
        }
    }
    echo "<br/>";
}
?>
</body>
</html>