# View Certificate Details
Location: /opt/gitlab/config/ssl
```shell
$ openssl x509 -in -text -noout some.server.domain.com.crt
```
# Generate New Certificate
Domain: some.server.domain.com

1. Generate password-protected 2048-bit RSA private key
```
$ openssl genrsa -des3 -out some.server.domain.com.key 2048
```
