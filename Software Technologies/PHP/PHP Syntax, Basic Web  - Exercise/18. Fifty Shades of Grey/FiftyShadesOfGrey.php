<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php
    $color = 0;
    for ($row = 1; $row <= 5; $row++){

        for ($col = 1; $col <= 10; $col++){

            $rbg = "rgb($color, $color, $color)";

            echo "<div style='background-color: $rbg'></div>";

            $color += 5;
        }
        ?> <br> <?php
        $color += 1;
    }
?>
</body>
</html>