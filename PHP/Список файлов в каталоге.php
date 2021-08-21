
$dir = '/tmp';
$files1 = myscandir($dir);
$files2 = myscandir($dir, 1);

function myscandir($dir, $sort=0)
{
	$list = scandir($dir, $sort);
	
	// если директории не существует
	if (!$list) return false;
	
	// удаляем . и .. (я думаю редко кто использует)
	if ($sort == 0) unset($list[0],$list[1]);
	else unset($list[count($list)-1], $list[count($list)-1]);
	return $list;
}