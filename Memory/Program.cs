using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace VirtualMemoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr p = Marshal.AllocHGlobal(4);
            Console.WriteLine($"PID: {Process.GetCurrentProcess().Id}, Address allocated: {p}");
            Marshal.WriteInt32(p, 0);
            while (true)
            {
                int currentValue = Marshal.ReadInt32(p);
                Console.WriteLine($"PID: {Process.GetCurrentProcess().Id}, Value: {currentValue}, Address : {p}");
                Marshal.WriteInt32(p, currentValue + 1);
                Thread.Sleep(1000);
            }

            /*
                When you press Control-C, the operating system sends an interrupt signal to your program, 
                which terminates it. When a process is terminated, the OS cleans up and reclaims all 
                resources allocated to that process, including any memory allocated using functions like Marshal.AllocHGlobal. 
                This means that even though your code didn't explicitly free the unmanaged memory, the OS will reclaim it once the process exits.
            */
        }
    }
}
