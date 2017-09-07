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
        $num = intval($_GET['num']);
        $factoralResult = 1;

        for ($i = 2; $i <= $num; $i++){
            $factoralResult *= $i;
        }

        echo htmlspecialchars($factoralResult);
    }
?>
</body>
</html>