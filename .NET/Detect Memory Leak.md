* [Using dotnet-counters](#using-dotnet-counters)

# Using dotnet-counters
Installation:
```cmd
> dotnet tool install --global dotnet-counters
```
View processes
```cmd
> dotnet-counters ps
28420  ConsoleApp7  ...\ConsoleApp7\bin\Debug\net5.0\ConsoleApp7.exe  "...\ConsoleApp7\bin\Debug\net5.0\ConsoleApp7.exe"
```
View detailed information of the process:
```cmd
> dotnet-counters monitor -p 28420

[System.Runtime]
    % Time in GC since last GC (%)                                 0
    Allocation Rate (B / 1 sec)                               93 712
    CPU Usage (%)                                                  0
    Exception Count (Count / 1 sec)                                1
    GC Fragmentation (%)                                           0,768
    GC Heap Size (MB)                                          3 057        # Pay attention
    Gen 0 GC Count (Count / 1 sec)                                 0
    Gen 0 Size (B)                                                24
    Gen 1 GC Count (Count / 1 sec)                                 0
    Gen 1 Size (B)                                         6 298 712
    Gen 2 GC Count (Count / 1 sec)                                 0
    Gen 2 Size (B)                                            3,0661e+09
    IL Bytes Jitted (B)                                       34 154
    LOH Size (B)                                           4 063 536
    Monitor Lock Contention Count (Count / 1 sec)                  0
    Number of Active Timers                                        0
    Number of Assemblies Loaded                                    5
    Number of Methods Jitted                                     297
    POH (Pinned Object Heap) Size (B)                         19 512
    ThreadPool Completed Work Item Count (Count / 1 sec)           0
    ThreadPool Queue Length                                        0
    ThreadPool Thread Count                                        2
    Working Set (MB)                                           3 132
```
Pay attention to "GC Heap Size (MB)" parameter.
