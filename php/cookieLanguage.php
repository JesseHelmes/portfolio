<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 28-11-2018
 * Time: 11:18
 */

// misschien moet de setcookie hier egens komen staan want hij controleerd steeds maar
// de $cookie_value toch?

//dit is de cookie naam
$cookie_name = "cookie_taal";

//dit pakt de cookie taal uit de cookie
if(!isset($_COOKIE[$cookie_name]))// of dit moet dit worrden $cookie_value
{
    $taal = "any";
}

else{
    //$taal = $_GET["taal"];
    $taal = $_COOKIE[$cookie_name]; //dit was de oplossing
}

// dit zorgt er voor dat je de taal krijgt van de form
if (!empty($_GET["taal"]))
{
    $taal = $_GET["taal"];
}

$cookie_value = $taal;
setcookie($cookie_name, $cookie_value, time() + (86400 *1));// 86400 = 1 dag



// dit kan https://stackoverflow.com/questions/38909766/list-of-all-country-languages-for-dropdown-select-menu-html-form
?>


<html>
<head></head>
<body>

<h1>Set Language Preference</h1>
 <p>The currentle selected language is: <?php echo $cookie_value ?></p>

<form action="" method="get">
    <!--kan dit niet korter en makkelijker? -->
    <select name="taal" >
        <option value="Afrikanns">Afrikanns</option>
        <option value="Albanian">Albanian</option>
        <option value="Arabic">Arabic</option>
        <option value="Armenian">Armenian</option>
        <option value="Basque">Basque</option>
        <option value="Bengali">Bengali</option>
        <option value="Bulgarian">Bulgarian</option>
        <option value="Catalan">Catalan</option>
        <option value="Cambodian">Cambodian</option>
        <option value="Chinese (Mandarin)">Chinese (Mandarin)</option>
        <option value="Croation">Croation</option>
        <option value="Czech">Czech</option>
        <option value="Danish">Danish</option>
        <option value="Dutch">Dutch</option>
        <option value="English">English</option>
        <option value="Estonian">Estonian</option>
        <option value="Fiji">Fiji</option>
        <option value="Finnish">Finnish</option>
        <option value="French">French</option>
        <option value="Georgian">Georgian</option>
        <option value="German">German</option>
        <option value="Greek">Greek</option>
        <option value="Gujarati">Gujarati</option>
        <option value="Hebrew">Hebrew</option>
        <option value="Hindi">Hindi</option>
        <option value="Hungarian">Hungarian</option>
        <option value="Icelandic">Icelandic</option>
        <option value="Indonesian">Indonesian</option>
        <option value="Irish">Irish</option>
        <option value="Italian">Italian</option>
        <option value="Japanese">Japanese</option>
        <option value="Javanese">Javanese</option>
        <option value="Korean">Korean</option>
        <option value="Latin">Latin</option>
        <option value="Latvian">Latvian</option>
        <option value="Lithuanian">Lithuanian</option>
        <option value="Macedonian">Macedonian</option>
        <option value="Malay">Malay</option>
        <option value="Malayalam">Malayalam</option>
        <option value="Maltese">Maltese</option>
        <option value="Maori">Maori</option>
        <option value="Marathi">Marathi</option>
        <option value="Mongolian">Mongolian</option>
        <option value="Nepali">Nepali</option>
        <option value="Norwegian">Norwegian</option>
        <option value="Persian">Persian</option>
        <option value="Polish">Polish</option>
        <option value="Portuguese">Portuguese</option>
        <option value="Punjabi">Punjabi</option>
        <option value="Quechua">Quechua</option>
        <option value="Romanian">Romanian</option>
        <option value="Russian">Russian</option>
        <option value="Samoan">Samoan</option>
        <option value="Serbian">Serbian</option>
        <option value="Slovak">Slovak</option>
        <option value="Slovenian">Slovenian</option>
        <option value="Spanish">Spanish</option>
        <option value="Swahili">Swahili</option>
        <option value="Swedish ">Swedish </option>
        <option value="Tamil">Tamil</option>
        <option value="Tatar">Tatar</option>
        <option value="Telugu">Telugu</option>
        <option value="Thai">Thai</option>
        <option value="Tibetan">Tibetan</option>
        <option value="Tonga">Tonga</option>
        <option value="Turkish">Turkish</option>
        <option value="Ukranian">Ukranian</option>
        <option value="Urdu">Urdu</option>
        <option value="Uzbek">Uzbek</option>
        <option value="Vietnamese">Vietnamese</option>
        <option value="Welsh">Welsh</option>
        <option value="Xhosa">Xhosa</option>
    </select>
    <br>
    <br>
    <input type="submit" value="Set Preference">
</form>

<!--<b>Minuten:</b> <?php echo $differenceInMinutes ?> <br>-->
</body>
</html>