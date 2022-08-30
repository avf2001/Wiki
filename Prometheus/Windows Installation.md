# 1. Скачать Prometheus
# 2. Распаковать в папку D:\Tools\prometheus-2.37.0.windows-amd64. Назовем ее PROMETHEUS_HOME
# 3. Из папки PROMETHEUS_HOME выполнить команду
prometheus.exe --config.file prometheus.yml --web.listen-address ":9090" --storage.tsdb.path "data"
# 4. Проверить работу Prometheus
Открыть в браузере страницу http://localhost:9090
# 5. Проверить рабуту метрик Prometheus
Открыть в браузере страницу http://localhost:9090/targets
