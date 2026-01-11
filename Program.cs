// Copyright 2025 dah4k
// SPDX-License-Identifier: EPL-2.0

namespace Csharp.RcHello;

using System.IO;
using System.Reflection;
using System.Text;
using System;

class Program
{
    static private string LoadEmbeddedFile(string pathname)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var name = assembly.GetName().Name;
        using var stream = assembly.GetManifestResourceStream($"{name}.{pathname.Replace('/', '.')}")!;
        using var streamReader = new StreamReader(stream, Encoding.UTF8);
        return streamReader.ReadToEnd();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.Write(LoadEmbeddedFile("Files/greetings.txt"));
    }
}
