# Перевести БД в режим Offline
```sql
USE master
GO
ALTER DATABASE [DatabaseName] SET OFFLINE WITH ROLLBACK IMMEDIATE
GO
```
