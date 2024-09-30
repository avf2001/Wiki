Статистика количества строк во всех таблицах базs данных **DatabaseName**  
Источник: https://www.mssqltips.com/sqlservertip/2537/sql-server-row-count-for-all-tables-in-a-database/
```sql
USE DatabaseName
GO

SELECT
      QUOTENAME(SCHEMA_NAME(sOBJ.schema_id)) + '.' + QUOTENAME(sOBJ.name) AS [TableName]
      , SUM(sPTN.Rows) AS [RowCount]
FROM 
      sys.objects AS sOBJ
      INNER JOIN sys.partitions AS sPTN
            ON sOBJ.object_id = sPTN.object_id
WHERE
      sOBJ.type = 'U'
      AND sOBJ.is_ms_shipped = 0x0
      AND index_id < 2 -- 0:Heap, 1:Clustered
GROUP BY 
      sOBJ.schema_id
      , sOBJ.name
ORDER BY [RowCount] DESC
GO
```
# Как собрать несколько значений в одну строку
```
STRING_AGG
```
# Как найти N-ю строку
## Вариант 1
С помощью ROW_NUMBER(), RANK(), или DENSE_RANK().
```sql
WITH RankedEmployees AS (
    SELECT 
        EmployeeID, 
        FirstName, 
        LastName, 
        Salary,
        ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum
    FROM Employees
)
SELECT 
    EmployeeID, 
    FirstName, 
    LastName, 
    Salary
FROM RankedEmployees
WHERE RowNum = 3;
```
## Вариант 2
С помощью OFFSET FETCH
```sql
SELECT 
    EmployeeID, 
    FirstName, 
    LastName, 
    Salary
FROM Employees
ORDER BY Salary DESC
OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY;
```
Заключение:

Оба подхода позволяют найти N-ю строку в результирующем наборе. Использование ROW_NUMBER() более гибко и подходит для более сложных сценариев, в то время как OFFSET FETCH более простой и удобный для базовых задач. Выбор метода зависит от конкретных требований и версии SQL Server, которую вы используете.
