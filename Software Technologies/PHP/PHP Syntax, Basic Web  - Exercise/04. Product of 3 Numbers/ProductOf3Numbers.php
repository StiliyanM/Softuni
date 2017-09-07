<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    X: <input type="number" name="num1" />
    Y: <input type="number" name="num2" />
    Z: <input type="number" name="num3" />
    <input type="submit" />
</form>
<?php
    if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
        $arrNumbers = [floatval($_GET['num1']), floatval($_GET['num2']), floatval($_GET['num3'])];

        $counter = 0;
        foreach ($arrNumbers as $number){
            if ($number == 0){
                echo htmlspecialchars("Positive");
                return;
            }
            elseif ($number < 0){
                $counter++;
            }
        }
        if ($counter % 2 == 1){
            echo htmlspecialchars("Negative");
        }
        else{
            echo htmlspecialchars("Positive");
        }
    }
?>
</body>
</html>