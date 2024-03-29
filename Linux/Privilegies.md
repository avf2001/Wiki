https://linuxize.com/post/su-command-in-linux/

Чем отличается su от sudo?

# SU
su «substitute user» — заменить пользователя. su требует пароль целевой учетной записи, на кого переключаемся.

Например, мы сидим под пользователем user и хотим войти под John:
```
user@dev:/$ su john
```
Будет запрошен пароль, нужно ввести пароль именно от учетной записи john, а не от user.

# SUDO
sudo «substitute user and do» — подменить пользователя и выполнить. sudo требует пароль текущего пользователя и запускает от его имени команды, которым требуются права суперюзера.

Пример с sudo:
```
user@dev:/$ sudo -u john whoami
```
А здесь нужно ввести пароль от учетной записи user, а не от John или рута.

Посмотреть список пользователей, входящих в группу sudo, можно командой (Debian):
```shell
$ getent group sudo # Option 1

$ cat /etc/group | grep '^sudo:' # Option 2
```
Чтобы добавить пользователя в группу **`sudo`** необходимо выполнить команду:
```shell
# usermod -aG sudo username
```
А для чего нужен дефис после su?

Для очистки переменных и чтобы пользоваться чистой оболочкой при переключении на другого пользователя.

Авторизуемся под пользователем user и экспортируем переменную:

ssh user@pc
export a="test"

Теперь у пользователя user есть переменная "a" которая = test.

Переключаемся на пользователя John и смотрим переменную "a"

su john
echo $a

Вывелась строчка test. То есть все что мы задали под user, перекочевало в оболочку john. А теперь добавим дефис:

su - john
echo $a

Переменная $a больше не выводится. Чистая оболочка. Кстати с этим дефисом часто косячат и потом долго не могут понять в чем причина. Переменные вроде были заданы, а потом куда-то пропали.

su (с дефисом) — сначала переключается пользователь, а затем запускается shell, зачищаются все переменные.

su (без дефиса) — переключает пользователя, оставляя переменные окружения старого пользователя.

У sudo есть подобные ключи -s -i

user@pc:/$ sudo -s

Запустится оболочка с правами root

user@pc:/$ sudo -i

Запустится оболочка, но уже с чтением файлов root/.profile/.bashrc и т.п. Можно попробовать добавить экспорт переменной в .profile, сделать sudo -s/-i и увидеть что с ключом -i переменная выведется на экран.

По сути sudo -i = команде sudo su -. Но обычно за sudo su - в приличных местах можно получить по шапке. Это плохая практика! Так как это порождает дополнительный процесс и больше гемора с набором самой команды.
