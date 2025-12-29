// Copyright 2025 dah4k
// SPDX-License-Identifier: EPL-2.0

using System.IO;
using System.Reflection;
using System.Text;
using System;

namespace RcHello;
class Program
{
    static private string LoadEmbeddedFile(string pathname)
    {
        // https://khalidabuhakmeh.com/how-to-use-embedded-resources-in-dotnet
        var info = Assembly.GetExecutingAssembly().GetName();
        var name = info.Name;
        using var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream($"{name}.{pathname.Replace('/', '.')}")!;
        using var streamReader = new StreamReader(stream, Encoding.UTF8);
        return streamReader.ReadToEnd();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.Write(LoadEmbeddedFile("Files/greetings.txt"));
    }
}
