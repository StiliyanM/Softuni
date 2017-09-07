<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
    for ($row = 1; $row <= 9; $row++){
        for ($col = 1; $col <= 5; $col++){
            if ($row == 1 || $row == 5 || $row == 9){
                echo "<button style='background-color: blue'>1</button>";
            }
            else if (($row == 2 || $row == 3 || $row == 4) && $col == 1){
                echo "<button style='background-color: blue'>1</button>";
            }
            else if (($row == 6 || $row == 7 || $row == 8) && $col == 5){
                echo "<button style='background-color: blue'>1</button>";
            }
            else {
                echo "<button>0</button>";
            }
        } ?>
        <br> <?php
    }
?>
</body>
</html>