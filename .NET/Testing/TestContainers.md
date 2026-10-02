# Настройка использования только локальных образов (Linux)
```shell
touch ~/.testcontainers.properties
code ~/.testcontainers.properties
```
```
pull.policy=never
ryuk.disabled=true
```
