using System;

namespace DataClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("out.txt", "");
            var input = File.ReadAllText("input.txt").Split('\n');
            foreach( var line in input)
            {
                var item = line.Split(' ');
                if (item.Count() == 2)
                {
                    string type = item[0].Replace("\n", "").Replace("\r", "");
                    string name = item[1].Replace("\n", "").Replace("\r", "");
                    string Name = name[0].ToString().ToUpper() + name.Substring(1);
                    string s =
$"\n\nprivate {type} {name};" + "\n" +
$"public {type} {Name}\n" +
"{\n"+
$"    get => {name}\n" +
$"    set\n" +
"    {\n"  +
$"        {name} = value;\n"  +
$"        OnPropertyChanged(nameof({Name}));\n" +
"    }\n"+
"}";

                    File.AppendAllText("out.txt", s);
                }
                if (item.Count() == 3)
                {
                    string type = item[0].Replace("\n", "").Replace("\r", "");
                    string name = item[1].Replace("\n", "").Replace("\r", "");
                    string Name = name[0].ToString().ToUpper() + name.Substring(1);
                    string value = item[2].Replace("\n", "").Replace("\r", "");
                    string s =
$"\n\nprivate {type} {name} = {value};" + "\n" +
$"public {type} {Name}\n" +
"{\n" +
$"    get => {name}\n" +
$"    set\n" +
"    {\n" +
$"        {name} = value;\n" +
$"        OnPropertyChanged(nameof({Name}));\n" +
"    }\n" +
"}";
                    File.AppendAllText("out.txt", s);
                }
            }
        }
    }
}