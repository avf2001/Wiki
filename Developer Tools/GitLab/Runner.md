# Register Runner
```shell
#!/bin/bash
docker run --rm -it -v /opt/gitlab-runner/config:/etc/gitlab-runner reponexus.sb.*****.ru:8182/gitlab/gitlab-runner:alpine-v15.0.0 register \
  --non-interactive \
  --url "https://vcs.sb.*****.ru:9443/" \
  --token "RUNNER_TOKEN" \
  --description "docker-runner" \
  --executor "docker" \
  --docker-image reponexus.sb.*****.ru:8182/gitlab/gitlab-runner:alpine-v15.0.0 \
  --tls-ca-file /opt/gitlab/config/ssl/vcs.sb.*****.ru.crt
```
