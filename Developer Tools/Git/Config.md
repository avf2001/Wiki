# Получить версию git
```shell
$ git --version
```
# Получить список настроек
```shell
$ git config --list
$ git config --list --show-origin
```
# Начальная настройка
```shell
$ git config --global user.name "ваше имя или ник латиницей" 
$ git config --global user.email "ваша электронная почта"
$ git config --global core.editor "code --wait"
```
## Рекомендуемые настройки
Source: https://blog.gitbutler.com/how-git-core-devs-configure-git/
```shell
git config --global column.ui auto
git config --global branch.sort -committerdate

git config --global tag.sort version:refname

git config --global init.defaultBranch main

git config --global diff.algorithm histogram

git config --global diff.colorMoved plain
git config --global diff.mnemonicPrefix true
git config --global diff.renames true

git config --global push.default simple # (default since 2.0)
git config --global push.autoSetupRemote true
git config --global push.followTags true

git config --global fetch.prune true
git config --global fetch.pruneTags true
git config --global fetch.all true

git config --global help.autocorrect prompt

git config --global commit.verbose true

git config --global rerere.enabled true
git config --global rerere.autoupdate true

git config --global core.excludesfile ~/.gitignore

git config --global rebase.autoSquash true
git config --global rebase.autoStash true
git config --global rebase.updateRefs true

git config --global merge.conflictstyle zdiff3

git config --global pull.rebase true

git config --global core.fsmonitor true
git config --global core.untrackedCache true
```
или
```
# clearly makes git better

[column]
        ui = auto
[branch]
        sort = -committerdate
[tag]
        sort = version:refname
[init]
        defaultBranch = main
[diff]
        algorithm = histogram
        colorMoved = plain
        mnemonicPrefix = true
        renames = true
[push]
        default = simple
        autoSetupRemote = true
        followTags = true
[fetch]
        prune = true
        pruneTags = true
        all = true

# why the hell not?

[help]
        autocorrect = prompt
[commit]
        verbose = true
[rerere]
        enabled = true
        autoupdate = true
[core]
        excludesfile = ~/.gitignore
[rebase]
        autoSquash = true
        autoStash = true
        updateRefs = true

# a matter of taste (uncomment if you dare)

[core]
        # fsmonitor = true
        # untrackedCache = true
[merge]
        # (just 'diff3' if git version < 2.3)
        # conflictstyle = zdiff3 
[pull]
        # rebase = true
```
