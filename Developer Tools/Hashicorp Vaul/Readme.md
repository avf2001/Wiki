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
