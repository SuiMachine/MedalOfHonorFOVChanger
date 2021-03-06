﻿/* C# trainer class.
 * Author : Cless
 */

/*How to use pointer read/write.
 * ////// Example Read ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 *      this.Text = Trainer.ReadPointerInteger("Game exe name here",0xPointer here,new int[offset count] {0xOffset}).Tostring();
 *      Ex Read.
 *      this.Text = Trainer.ReadPointerInteger("gta_sa",0xB71A38,new int[1]{ 0x5412 }).Tostring();
 *      Or
 *      this.Text = Trainer.ReadPointerInteger("gta_sa",0xB71A38,new int[5]{ 0x540, 0x541, 0x542, 0x543, 0x544, 0x545 }).Tostring();
 * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 * ///// Example Write ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
 *      Trainer.WritePointerInteger("Game exe name here", 0xPointer here, new int[offset count] {0xoffset});
 *      Trainer.WritePointerInteger("gta_sa", 0xB71A38, new int[1] { 0x540 }, 1000);
 *      Or
 *      Trainer.WritePointerInteger("gta_sa",0xB71A38,new int[5]{ 0x540, 0x541, 0x542, 0x543, 0x544, 0x545 },10000);
 * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////     
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;


public class Trainer
{
    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
    [DllImport("kernel32")]
    private static extern int OpenProcess(int AccessType, int InheritHandle, int ProcessId);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern int WriteProcessMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesWritten);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern float WriteProcessMemoryFloat(int Handle, int Address, ref float Value, int Size, ref int BytesWritten);

    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern int ReadProcessMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern float ReadProcessMemoryFloat(int Handle, int Address, ref float Value, int Size, ref int BytesRead);
    [DllImport("kernel32")]
    private static extern int CloseHandle(int Handle);



    public static int ReadInteger(Process[] Proc, int Address)
    {
        int Value = 0;
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryInteger(Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadFloat(Process[] Proc, int Address)
    {
        float Value = 0;
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryFloat((int)Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }

    public static int ReadPointerInteger(Process[] Proc, int Pointer, int[] Offset)
    {
        int Value = 0;
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryInteger((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadPointerFloat(Process[] Proc, int Pointer, int[] Offset)
    {
        float Value = 0;
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryFloat((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static void WriteInteger(Process[] Proc, int Address, int Value)
    {
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryInteger(Handle, Address, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WriteFloat(Process[] Proc, int Address, float Value)
    {
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryFloat(Handle, Address, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }

            }
            catch
            { }
        }
    }

    public static void WritePointerInteger(Process[] Proc, int Pointer, int[] Offset, int Value)
    {
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryInteger(Handle, Pointer, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WritePointerFloat(Process[] Proc, int Pointer, int[] Offset, float Value)
    {
        checked
        {
            try
            {
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryFloat(Handle, Pointer, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
}