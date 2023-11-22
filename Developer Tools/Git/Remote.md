* First commit to remote
* [Remote Branches](#remote-branches)
  * [View Remote Branches](#view-remote-branches)
  * [Create Remote Branch](#create-remote-branch)
# First commit to remote
```shell
$ git remote add origin https://github.com/user/repository_name
$ git push -u origin master
```
# Remote Branches
## View Remote Branches
```shell
$ get branch -r
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
