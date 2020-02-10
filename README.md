# HomeTask
Задание на нахождение площадей фигур находится в папке AreaOfShapes

SQL ЗАДАНИЕ

Для составления отношения многие ко многим нужно создать 3 таблицы : продукт, категория и категория_продукт.

Продукт_id первичный ключ в Первой таблице, категория_id первичный ключ во второй таблице. Таблица категория_продукт состоит из 2ух колонок - вторичных ключей Продукт_id и категория_id

Для получения всех комбинаций:
* нужно соотвтственно выбрать все данные с таблицы категория_продукт (select * from продукт_категория)
* либо, если нужны все комбинации еще и с полями таблицы Продукт,то 

SELECT p.Продукт_id, pc.категория_id, p.НазваниеПродукта (можно добавить любые поля которые нужны)
FROM Продукт p
INNER JOIN категория_продукт pc
        ON p.Продукт_id = pc.Продукт_id
