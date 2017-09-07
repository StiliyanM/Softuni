<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num" />
    <input type="submit" />
</form>
<?php
    if (isset($_GET['num'])){
        $n = intval($_GET['num']);

        $fibonacciFirsNUmber = 1;
        $fibonacciSecondNumber = 1;

        echo htmlspecialchars($fibonacciFirsNUmber . " " . $fibonacciSecondNumber . " ");
        for ($i = 2; $i < $n; $i++)
        {
            $sum = $fibonacciFirsNUmber + $fibonacciSecondNumber;
            $fibonacciFirsNUmber = $fibonacciSecondNumber;
            $fibonacciSecondNumber = $sum;

            echo htmlspecialchars($fibonacciSecondNumber . " ");
        }
    }
?>
</body>
</html>