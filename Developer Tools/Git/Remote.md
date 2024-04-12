* [First commit to remote](#first-commit-to-remote)
* [Remote Branches](#remote-branches)
  * [View Remote Branches](#view-remote-branches)
  * [Create Remote Branch](#create-remote-branch)
  * [Change Remote Origin](#change-remote-origin)
  * [Delete Remote](#delete-remote)
  * [Rename Remote](#rename-remote)
  * [Switch to Remote Branch](#switch-to-remote-branch)
# First commit to remote
```shell
$ git remote add origin https://github.com/user/repository_name

# option: push master branch to remote server named origin
$ git push -u origin master

# option: push all branches to remote server named origin
$ git push -u --all origin
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
$ git remote set-url <remote_name> <remote_url>

# example
$ git remote set-url origin https://git-repo/new-repository.git
```

## Delete Remote
```shell
$ git remote rm origin
```

## Rename Remote
```shell
$ git remote rename beanstalk origin # rename beanstalk to origin
```

## Switch to Remote Branch
```shell
$ git switch -c origin/somebranch
```
