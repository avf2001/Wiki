* [First commit to remote](#first-commit-to-remote)
* [Remote Branches](#remote-branches)
  * [View Remote Branches](#view-remote-branches)
  * [Create Remote Branch](#create-remote-branch)
  * [Change Remote Origin](#change-remote-origin)
# First commit to remote
```shell
$ git remote add origin https://github.com/user/repository_name
$ git push -u origin master # push master branch to remote server named origin
$ git push -u --all origin # push all branches to remote server named origin
```
# Remote Branches
## View Remote Branches
```shell
$ git branch -r
```
## Create Remote Branch
1. Create local branch named **`development`**
```shell
$ git branch development
```
2. Push created branch to remote server
```shell
$ git push -u origin development
```

## Change Remote Origin
```shell
$ $ git remote set-url <remote_name> <remote_url>

# example
$ git remote set-url origin https://git-repo/new-repository.git
```
