# Состояние нод кластера
```sql
SELECT * FROM sys.dm_os_cluster_nodes;

NodeName   status      status_description is_current_owner
---------- ----------- ------------------ ----------------
SQLCLS-N1  0           up                 1
SQLCLS-N2  0           up                 0
```
