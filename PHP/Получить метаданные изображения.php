<?php
echo "test1.jpg:<br />\n";

$exif = exif_read_data('img\album09\001.jpg', 'IFD0');
echo $exif===false ? "Не найдено данных заголовка.<br />\n" : "Изображение содержит заголовки<br />\n";

$exif = exif_read_data('img\album09\001.jpg', 0, true);
echo "test2.jpg:<br />\n";

//print_r($exif);

foreach ($exif as $key)
{
    print_r($key);
    /*
    foreach ($section as $name => $val)
    {
        echo "$key.$name: $val<br />\n";
    }*/
}
?>