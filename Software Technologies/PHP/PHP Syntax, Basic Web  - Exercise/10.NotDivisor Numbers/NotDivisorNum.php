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
if(isset($_GET['num'])){
    $num = intval($_GET['num']);

    for ($i = $num - 1;$i >= 2;$i--) {
        $normalDiv = $num / $i;
        $intDiv = (int)($num / $i);

        if ($normalDiv != $intDiv)
            echo htmlspecialchars($i . ' ');
    }
}
?>
</body>
</html>