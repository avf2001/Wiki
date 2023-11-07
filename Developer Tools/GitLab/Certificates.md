# View Certificate Details
Location: /opt/gitlab/config/ssl
```shell
$ openssl x509 -in -text -noout some.server.domain.com.crt
```
# Generate New Self-Signed Certificate
Domain: some.server.domain.com

1. Generate password-protected 2048-bit RSA private key
```
$ openssl genrsa -des3 -out some.server.domain.com.key 2048
```
2. Creating a Certificate Signing Request
```
$ openssl req -key some.server.domain.com.key -new -out some.server.domain.com.csr
```
