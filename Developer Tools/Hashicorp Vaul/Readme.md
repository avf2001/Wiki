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
Назначить права на папку:
```shell
mkdir -p vault/data
sudo chown -R 100:100 vault/data
```
Запустить docker container:
```shell
docker compose up -d
```
Провести инициализацию:
```shell
# Initialize (will output unseal key and root token, please save them securely)
docker exec -it vault vault operator init

Unseal Key 1: gzsNkS51PBfyiHZPtmGDFmUqi0g6spSvr+74ma2KZkcS         # !!!
Unseal Key 2: UpHEUdXKsFQILe+wfPo2+heNwyfa8fda1K5jPZxSyTFU         # !!!
Unseal Key 3: k2yJf/o83H6ledm7REChi3qhiCZ/8KuR0VOm1WfYQi3b         # !!!
Unseal Key 4: rcivfez6kr+vcpf27B/xqUDoi5Jf9x/nhdjm+e9t4rI0
Unseal Key 5: gMTj6fKAUXdSf8tjTpygBQcqXAqW3srl5TfyZsYMzdLh

Initial Root Token: hvs.c5tRlS16BbCu1KAoprWQDxS4                   # !!!

Vault initialized with 5 key shares and a key threshold of 3. Please securely
distribute the key shares printed above. When the Vault is re-sealed,
restarted, or stopped, you must supply at least 3 of these keys to unseal it
before it can start servicing requests.

Vault does not store the generated root key. Without at least 3 keys to
reconstruct the root key, Vault will remain permanently sealed!

It is possible to generate new unseal keys, provided you have a quorum of
existing unseal keys shares. See "vault operator rekey" for more information.
```
```shell
# Unseal using the output unseal key (need to execute 3 times, using 3 different keys)
docker exec -it vault vault operator unseal <unseal_key_1>
docker exec -it vault vault operator unseal <unseal_key_2>
docker exec -it vault vault operator unseal <unseal_key_3>

# Verify status
docker exec -it vault vault status
```
