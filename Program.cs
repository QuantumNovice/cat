// See https://aka.ms/new-console-template for more information

using System;




string[] arguments = Environment.GetCommandLineArgs();



if (arguments.Length > 0)
{
    WriteType writetype = WriteType.Plain;

    foreach (string arg in arguments.Skip(1))
    {
        if (arg.StartsWith("-"))
        {
            if (arg == "-n")
            {
                writetype = WriteType.WithLineNumbers;
                

            }
        }
        else
        {
            string[] content = File.ReadAllLines(arg);
            Write(writetype, content);
        }
       
    }
}

void Write(WriteType writetype, string[] content)
{
    switch (writetype)
    {
        case WriteType.Plain:;

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }

            break;

        case WriteType.WithLineNumbers:
            ;

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine($"{i} {content[i]}");
            }

            break;
    }
}
enum WriteType
{
    WithLineNumbers,
    Plain
}