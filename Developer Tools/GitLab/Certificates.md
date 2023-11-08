# View Certificate Details
Location: /opt/gitlab/config/ssl
```shell
$ openssl x509 -in -text -noout some.server.domain.com.crt
```
# Generate New Self-Signed Certificate
Domain: some.server.domain.com

1. Generate no password-protected 2048-bit RSA private key
```
$ openssl genrsa 2048 -out some.server.domain.com.key
```
2. Generate self-signed certificate with private key only
```
$ openssl req -key some.server.domain.com.key -new -x509 -days 365 -addext "subjectAltName = DNS:foo.co.uk" -out some.server.domain.com.crt
```
[Source](https://www.baeldung.com/openssl-self-signed-cert)
