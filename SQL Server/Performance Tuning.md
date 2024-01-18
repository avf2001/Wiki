# Performance Tuning
* [Missing Indexes](#missing-indexes)
* [Unused Indexes](#unused-indexes)

## Missing Indexes
```sql
-- 1. Get database id
select database_id from sys.databases where name = 'DatabaseName'

-- 2. Get detailed info about missing indexes
select * from sys.dm_db_missing_index_details where database_id = 5

index_handle database_id object_id equality_columns                            inequality_columns included_columns statement
------------ ----------- --------- ------------------------------------------- ------------------ ---------------- --------------------------------
...
166974       5           622625261 [FirstName], [SecondName], [OrganizationId] [ID], [LastName]   NULL             [DatabaseName].[dbo].[Employees]
...

-- 3. Get information about columns that are missing an index
select * from.sys.dm_db_missing_index_columns(166974)

column_id column_name    column_usage
--------- -------------- ------------
2         FirstName      EQUALITY
3         SecondName     EQUALITY
22        OrganizationId EQUALITY
1         ID             INEQUALITY
4         LastName       INEQUALITY
```

## Unused Indexes
sys.dm_db_index_usage_stats
```sql
-- Source: https://www.sqltreeo.com/docs/finding-unused-indexes

SELECT 
	o.name AS TableName
	, i.type_desc
	, i.name AS IndexName
	, dm_ius.user_seeks AS UserSeek
	, dm_ius.user_scans AS UserScans
	, dm_ius.user_lookups AS UserLookups
	, dm_ius.user_updates AS UserUpdates
	, p.TableRows
	, 8 * p.TableRows / 1024 as [Table Size, MB]
	, dm_ius.last_user_scan
	, dm_ius.last_user_seek
	, dm_ius.last_user_update	
FROM sys.dm_db_index_usage_stats dm_ius
	INNER JOIN sys.indexes i ON i.index_id = dm_ius.index_id and dm_ius.object_id = i.object_id
	INNER JOIN sys.objects o ON dm_ius.object_id = o.object_id	
	INNER JOIN (
		SELECT SUM(p.rows) TableRows, p.index_id, p.object_id
		FROM sys.partitions p 
		GROUP BY p.index_id, p.object_id
	) p ON p.index_id = dm_ius.index_id and dm_ius.object_id = p.object_id	
WHERE
	OBJECTPROPERTY(dm_ius.object_id,'IsUserTable') = 1
	and dm_ius.database_id = DB_ID()
	and i.type_desc = 'nonclustered'
	and i.is_primary_key = 0
	and i.is_unique_constraint = 0
	and i.is_unique = 0

	and dm_ius.user_lookups = 0
	and dm_ius.user_scans = 0
	and dm_ius.user_seeks = 0
ORDER BY
	last_user_seek,
	last_user_scan
```
