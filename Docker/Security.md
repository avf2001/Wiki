```
$ docker run -it apline sh # bad - run container from root
$ docker run -it --user 1001:1001 alpine sh # good - run container from specific user
```
