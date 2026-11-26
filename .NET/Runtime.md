# Runtime

[Source](https://x.com/milan_milanovic/status/2125491436196122986)

Did you know that your .NET app recompiles itself every time it starts?

If you write C#, this is what happens when you run dotnet App.dll and your app shows the first line.

dotnet build stops at IL (Intermediate Language), a bytecode no CPU knows how to execute. The runtime turns it into machine code one method at a time while the app runs, and keeps it only in memory. So the work repeats on every start.

This is the full path:

𝟭. 𝗕𝘂𝗶𝗹𝗱

The C# compiler, called Roslyn, compiles Program.cs to IL and merges it, along with metadata, into App.dll. Next to it you get your NuGet .dlls, deps.json and runtimeconfig.json.

𝟮. 𝗦𝘁𝗮𝗿𝘁

dotnet App.dll invokes hostfxr, which picks the .NET version from runtimeconfig.json. hostpolicy then reads deps.json and builds the TPA list.

TPA means trusted platform assemblies, your dependencies plus the framework. Then it starts CoreCLR, the real .NET runtime.

𝟯. 𝗟𝗼𝗮𝗱

All assemblies get loaded into an AssemblyLoadContext. The Default context holds the TPA assemblies, and your own contexts can isolate plugins and unload them.

App.dll and the core library load right away. The rest loads lazily, when the JIT compiles a method that needs it.

𝟰. 𝗧𝘆𝗽𝗲𝘀

The type loader builds a MethodTable for each type, with its size and the v-table slots for virtual calls. Methods start as prestubs, placeholders that invoke the JIT on the first call. Static constructors run the first time a type gets used, not when it loads.

𝟱. 𝗘𝘅𝗲𝗰𝘂𝘁𝗲

The first JIT pass is Tier 0, fast with little to no optimization. After 30 calls, the runtime re-JITs the method with instrumentation to record which code paths and types show up most. This is called Dynamic PGO, and is default since .NET 8.

After 30 more calls, a background thread JITs it again as Tier 1, fully optimized. A hot loop doesn't wait for the method to return. OSR (on-stack replacement) switches it to optimized code mid-method.

𝟲. 𝗠𝗲𝗺𝗼𝗿𝘆

JITed code lives in the code heap. Objects start in Gen 0 on the managed heap and get promoted to Gen 1 and Gen 2 the longer they exist.

Objects of 85,000 bytes or more go to the Large Object Heap (LOH), arrays allocated as pinned to the Pinned Object Heap.

The GC (garbage collector) reclaims dead objects and compacts the survivors, except on the LOH, where it normally only sweeps. Every call adds a frame to its thread's stack.

𝟳. 𝗥𝘂𝗻

Everything now runs as good old-fashioned machine code. There's no interpreter on desktop and server CoreCLR. Native libraries (.dll, .so, .dylib) come in through P/Invoke.

Two publish options change this, both opt-in. ReadyToRun ships precompiled methods, so Tier 0 code is already there, but the JIT still re-JITs hot methods to Tier 1. Native AOT publishes one native executable with no JIT at all.
