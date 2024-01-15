# Missing Indexes
```sql
-- 1. Get database id
select database_id from sys.databases where name = 'DatabaseName'

-- 2. Get
select * from sys.dm_db_missing_index_details where database_id = 5

index_handle database_id object_id equality_columns                            inequality_columns included_columns statement
------------ ----------- --------- ------------------------------------------- ------------------ ---------------- --------------------------------
...
166974       5           622625261 [FirstName], [SecondName], [OrganizationId] [ID], [LastName]   NULL             [DatabaseName].[dbo].[Employees]
...

-- 3.
select * from.sys.dm_db_missing_index_columns(166974)

column_id column_name    column_usage
--------- -------------- ------------
2         FirstName      EQUALITY
3         SecondName     EQUALITY
22        OrganizationId EQUALITY
1         ID             INEQUALITY
4         LastName       INEQUALITY
```
