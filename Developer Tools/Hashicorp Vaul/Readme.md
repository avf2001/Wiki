# Hashicorp Vault

## Запуск в docker container в режиме production
**`docker-compose.yml`**
```yaml
services:
  vault:
    image: hashicorp/vault:1.19
    container_name: vault
    restart: unless-stopped
    cap_add:
      - IPC_LOCK
    ports:
      - "8200:8200"
    volumes:
      - ./vault/config:/vault/config:ro
      - ./vault/data:/vault/data
    environment:
      VAULT_ADDR: "http://127.0.0.1:8200"
    command: server
    healthcheck:
      test: ["CMD", "vault", "status"]
      interval: 10s
      timeout: 5s
      retries: 5
```
Создать файл конфигурации **`./vault/config/vault.hcl`**:
```hcl
ui = true
disable_mlock = true

storage "raft" {
  path    = "/vault/data"
  node_id = "node1"
}

listener "tcp" {
  address     = "0.0.0.0:8200"
  tls_disable = true
}

api_addr = "http://127.0.0.1:8200"
cluster_addr = "http://127.0.0.1:8201"
```
```shell
mkdir -p vault/data
sudo chown -R 100:100 vault/data
```
