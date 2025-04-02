# Memory Virtualization

each process spun ends up getting its own virtual memory space. hence its quite common for 2 processes to share same virtual address but os works with hardware 
by mapping virtual space to physical space ensuring isolation and security


# Managed vs. Unmanaged Memory

1) Managed Memory:
Languages like C# use managed memory, where the runtime (CLR) automatically handles memory allocation and deallocation through garbage collection (GC). This simplifies development by freeing you from the need to explicitly release memory, reducing the risk of memory leaks.

2) In unmanaged scenarios (as in C or using interop in C#), memory is allocated manually (e.g., via malloc() in C or Marshal.AllocHGlobal in C#). You must explicitly free this memory when it's no longer needed. Although the OS will reclaim this memory if a process terminates, failing to free unmanaged memory during the process's lifetime can lead to leaks and other issues

