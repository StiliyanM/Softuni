<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
     <table> <?php
        for ($color = 51; $color <= 255; $color += 51){
            ?> <tr> <?php
                $rgb = "rgb($color, 0, 0)";
                echo "<td style='background-color: $rgb'></td>";

                $rgb = "rgb(0, $color, 0)";
                echo "<td style='background-color: $rgb'></td>";


                $rgb = "rgb(0, 0, $color)";
                echo "<td style='background-color: $rgb'></td>";

            ?> </tr> <?php
        }
        ?>
     </table>

</table>
</body>
</html>