<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num1" />
    M: <input type="number" name="num2" />
    <input type="submit" />
</form>
<?php
    if (isset($_GET['num1']) && isset($_GET['num2'])){
        $num1 = intval($_GET['num1']);
        $num2 = intval($_GET['num2']);
        $result = $num1 * $num2;

        echo htmlspecialchars($result);
    }
?>
</body>
</html>