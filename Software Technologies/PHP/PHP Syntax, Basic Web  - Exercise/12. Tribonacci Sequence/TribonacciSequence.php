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
    $fibonacciThirdNumber = 2;

    echo htmlspecialchars($fibonacciFirsNUmber . " " . $fibonacciSecondNumber . " " . $fibonacciThirdNumber . " ");
    for ($i = 3; $i < $n; $i++)
    {
        $sum = $fibonacciFirsNUmber + $fibonacciSecondNumber + $fibonacciThirdNumber;
        $fibonacciFirsNUmber = $fibonacciSecondNumber;
        $fibonacciSecondNumber = $fibonacciThirdNumber;
        $fibonacciThirdNumber = $sum;

        echo htmlspecialchars($fibonacciThirdNumber . " ");
    }
}
?>
</body>
</html>