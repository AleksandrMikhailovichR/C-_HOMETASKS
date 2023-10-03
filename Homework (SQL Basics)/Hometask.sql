--  Напишите SQL-запрос, который выберет все данные из таблицы "student", отсортированные по столбцу "name" 
--  в алфавитном порядке. Ограничить выборку только 5 строками. 
--  Кроме того, выполните алиасинг для столбца "age" и назовите его "student_age

SELECT id, name, age AS student_age, grade FROM students
ORDER BY name
LIMIT 5