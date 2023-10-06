Bad
```
$ docker run -it apline sh # bad - run container from root
```
Good
```
$ docker run -it --user 1001:1001 alpine sh # good - run container from specific user
```
or use `USER username` in `dockerfile`
```dockerfile
RUN addgroup -S user && adduser -S user -G user
RUN chown -R user:user /app && chmod -R 755 /app
USER user
```
