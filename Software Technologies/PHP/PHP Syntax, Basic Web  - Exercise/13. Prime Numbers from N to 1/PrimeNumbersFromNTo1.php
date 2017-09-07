<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
function isPrime($num) {
    if($num == 1)
        return false;
    if($num == 2 || $num == 3)
        return true;
    if($num % 2 == 0 || $num % 3 == 0) {
        return false;
    }
    $ceil = ceil(sqrt($num));
    for($i = 3; $i <= $ceil; $i++) {
        if($num % $i == 0)
            return false;
    }
    return true;
}
if(!isset($_GET['num']))
    exit(1);

$num = intval($_GET['num']);

if ($num == 3){
    echo htmlspecialchars("3 2");
    return;
}

for($i = $num; $i > 1; $i--){
    if(isPrime($i))
        echo htmlspecialchars($i . " ");
}
?>
</body>
</html>