<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 1-1-2019
 * Time: 18:01
 */

$year = date("Y");;

setlocale(LC_TIME, 'NL_nl');
$msg = 'veel geluk op ';
//$monthDays = array(31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);
//$monthNames = array(' januari ', ' februari ' , ' maart ' , ' april ', ' mei ', ' juni ' , ' juli ' ,' augustus ', ' september', ' oktober ', ' november', ' december ');

$monthDays = array();
$monthNames = array();
for($i = 1; $i <= 12; $i++) {
    $monthDays[$i -1] = cal_days_in_month(CAL_GREGORIAN, $i, $year);
    $monthNames[$i - 1] = " " . strftime('%B', mktime(0, 0, 0, $i)) . " ";
}

//$dayNames = array('maanday ', 'dinsday ', 'woensday ', 'donderday ', 'vrijday ', 'zaterday ', 'zonday ');

//$year = ' 2019!';

$i = 0;
$day = 1;


/*
For($m = 0; $m <= 11; $m++)
{
    For($d = 1; $d <= $monthDays[$i]; $d++)
    {
        Echo $msg . $dayNames[$day] . $d . $monthNames[$m] . $year . '<br>';
        $day++;
        If ($day == 7)
        {
            $day = 0;
            echo '<br>';
        }

    }
    echo '<br><br>';
    $i++;

}*/

For($m = 0; $m <= 11; $m++)
{
    For($d = 1; $d <= $monthDays[$i]; $d++)
    {
        Echo $msg . strftime("%A", ( mktime(0,0,0,$m + 1,$d,$year))) . " " . $d . $monthNames[$m] . " " . $year . "!". '<br>';
        $day++;
        If ($day == 7)
        {
            $day = 0;
            echo '<br>';
        }

    }
    echo '<br><br>';
    $i++;

}


?>
