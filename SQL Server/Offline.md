# Перевести БД в режим Offline
```sql
USE master
GO
ALTER DATABASE [SKZPortal] SET OFFLINE WITH ROLLBACK IMMEDIATE
GO
```
