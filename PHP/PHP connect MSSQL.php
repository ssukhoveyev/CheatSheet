<?php 
phpinfo();

$serverName = "192.168.0.1"; //serverName\instanceName
$connectionInfo = array( "Database"=>"db_name", "UID"=>"sa", "PWD"=>"123123",'CharacterSet' => 'UTF-8');
$conn = sqlsrv_connect( $serverName, $connectionInfo);

if( $conn ) {
     echo "Connection established.<br />";
}else{
     echo "Connection could not be established.<br />";
     die( print_r( sqlsrv_errors(), true));
}

$q = "SELECT * FROM table_name";
$r = sqlsrv_query($conn, $q);
$row = sqlsrv_fetch_array($r);

print_r ($row);

sqlsrv_close( $conn );
?>