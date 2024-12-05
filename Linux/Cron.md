# Настройка задач

## Просмотр списка задач текущего пользователя
```bash
$ crontab -l
```

## Редактирование списка задач текущего пользователя
```bash
$ crontab -e
```
`/var/spool/cron/$USER`

## Примеры настроек расписания
```crontab
00 16 * * /some/script.sh   # выполнять скрипт ежедневно в 16:00
```

# Логи
Файл `/var/log/cron`

# Создание резервной копии
```bash
$ crontab -l > /path/to/backup/crontab_backup.txt
```
