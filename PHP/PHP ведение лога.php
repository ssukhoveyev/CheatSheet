<?php
    $fd = fopen("log\\".date("Y-m-d").".txt", 'a') or die("не удалось создать файл");
    fwrite($fd, date("Y-m-d G:i:s"). " ".$text."\r\n");
    fclose($fd);
?>