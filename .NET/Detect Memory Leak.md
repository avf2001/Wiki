* [Using dotnet-counters](#using-dotnet-counters)
* [Using dotnet-dump](#using-dotnet-dump)
* [Using dotnet-gcdump](#using-dotnet-gcdump)

# Using dotnet-counters
Installation:
```cmd
> dotnet tool install --global dotnet-counters
```
View processes:
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

# Using dotnet-dump
Installation:
```cmd
> dotnet tool install --global dotnet-dump
```
View processes:
```cmd
> dotnet-dump ps
28420  ConsoleApp7  ...\ConsoleApp7\bin\Debug\net5.0\ConsoleApp7.exe  "...\ConsoleApp7\bin\Debug\net5.0\ConsoleApp7.exe"
```
Create dump:
```cmd
> dotnet-dump collect -p 28112

Writing full to D:\dump_20240119_110252.dmp Complete
```
Analyze dump:
```cmd
> dotnet-dump analyze D:\dump_20240119_110252.dmp
Loading core dump: D:\Users\flinalev\source\projects\SBIntranetPortal.git\dump_20240119_110252.dmp ...
Ready to process analysis commands. Type 'help' to list available commands or 'help [command]' to get detailed help on a command.
Type 'quit' or 'exit' to exit the session.
>
```
```cmd
> dumpheap -stat
...
7ff7e0a46028     57         1824 System.Collections.Generic.List<System.Char>
7ff7e0a47990     56         2240 System.Collections.Generic.List<System.Char>+Enumerator
7ff7e09f24a8     91         4048 System.SByte[]
7ff7e09f2990      9         4488 System.Int32[]
7ff7e0936860      7        19000 System.Object[]
7ff7e0a13a28      4      1048680 System.String[]
7ff7e0a46880    727      3776624 System.Char[]
004ad4308cf0  54044     11000208 Free
7ff7e09f7a90  67866   1358224330 System.String                       # MOST USED MEMORY
Total 122945 objects, 1374086995 bytes
```
Most used memory is at the end of the list.
```
> dumheap -mt 7ff7e09f7a90
...
    004ae6270be8     7ff7e09f7a90         20022
    004ae6275a20     7ff7e09f7a90         20022
    004ae627a858     7ff7e09f7a90         20022
    004ae627f690     7ff7e09f7a90         20022
    004ae62844c8     7ff7e09f7a90         20022
    004ae6289300     7ff7e09f7a90         20022
    004ae628e138     7ff7e09f7a90         20022
    004ae6292f70     7ff7e09f7a90         20022
    004ae6297da8     7ff7e09f7a90         20022

Statistics:
          MT  Count     TotalSize Class Name
7ff7e09f7a90 67866 1358224330 System.String
Total 67866 objects, 1358224330 bytes
```
```cmd
> gcroot 004ae6297da8
HandleTable:
    0000004ad40a13e8 (strong handle)
          -> 004aee2a1018     System.Object[]
          -> 004ad62aaf38     System.Collections.Generic.List<System.String>
          -> 004ae63810e0     System.String[]
          -> 004ae6297da8     System.String

Found 1 unique roots.
```

# Using dotnet-gcdump
Installation:
```cmd
> dotnet tool install --global dotnet-gcdump
```
