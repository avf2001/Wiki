* Pods

# Pods
## View All Pods
```
$ sudo k3s kubectl get pods --all-namespaces
```
## Delete Pod
```
$ sudo k3s kubectl delete pod <pod_name> -n <namespace>
$ sudo k3s kubectl delete pod <pod_name> -n <namespace> --grace-period=0 --force
```
## View Logs
```
$ sudo k3s kubectl get events --all-namespaces
$ sudo k3s kubectl get events -n <namespace>
```
