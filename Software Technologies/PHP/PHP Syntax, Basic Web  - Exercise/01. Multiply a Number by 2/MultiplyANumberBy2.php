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
</body>
</html>
<?php
if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    $result = $num * 2;
    echo htmlspecialchars($result);
}

