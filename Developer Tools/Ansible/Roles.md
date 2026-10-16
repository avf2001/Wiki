# Роли

## Создание роли
**Способ 1**. С помощью утилиты `ansible-galaxy`:
```shell
ansible-galaxy role init docker_remove
```
**Способ 2**. Вручную создать структуру папок:
```shell
mkdir -p roles/docker_removal/{tasks,handlers,templates,files,vars,defaults,meta}
```

```shell
ansible all -m ping
ansible all -o -m ping    # one line
```
Проверка есть ли root доступ к удаленным машинам:
```shell
ansible all -a "test -r /etc/shadow"

debian | FAILED | rc=1 >>
non-zero return code
...
```
