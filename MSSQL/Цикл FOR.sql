--объявляем переменные
   DECLARE @number bigint
   DECLARE @pole1 varchar(50)
   DECLARE @pole2 varchar(50)
   
   --объявляем курсор
   DECLARE my_cur CURSOR FOR 
     SELECT number, pole1, pole2 
     FROM test_table_vrem
   
   --открываем курсор
   OPEN my_cur
   --считываем данные первой строки в наши переменные
   FETCH NEXT FROM my_cur INTO @number, @pole1, @pole2
   --если данные в курсоре есть, то заходим в цикл
   --и крутимся там до тех пор, пока не закончатся строки в курсоре
   WHILE @@FETCH_STATUS = 0
   BEGIN
        --на каждую итерацию цикла запускаем нашу основную процедуру с нужными параметрами   
        exec dbo.my_proc_test @number, @pole1, @pole2
        --считываем следующую строку курсора
        FETCH NEXT FROM my_cur INTO @number, @pole1, @pole2
   END
   
   --закрываем курсор
   CLOSE my_cur
   DEALLOCATE my_cur