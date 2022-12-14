using System;

namespace DataClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //reset out file
            File.WriteAllText("out.txt", "");

            //open file with properties and read it
            var input = File.ReadAllText("input.txt").Split('\n');

            foreach (var l in input)
            {
                string line = l;

                if (line.Length == 0)
                    continue;
                //remove the unnecessary end of the string 
                while (line.Last().ToString() == " " || line.Last().ToString() == "\r" || line.Last().ToString() == "\n")
                {
                    line = line.Substring(0, line.Length - 1);
                    if (line.Length == 0 || line.Split(" ").Length < 2)
                        break;
                }
                if (line.Length == 0 || line.Split(" ").Length < 2)
                    continue;
                var item = line.Split(' ');

                //check, is property does not has default value
                if (item.Count() == 2)
                {
                    string type = item[0];
                    string name = item[1][0].ToString().ToLower() + item[1].Substring(1);
                    string Name = name[0].ToString().ToUpper() + name.Substring(1);
                    string s =
$"\n\nprivate {type} {name};" + "\n" +
$"public {type} {Name}\n" +
"{\n" +
$"    get => {name};\n" +
$"    set\n" +
"    {\n" +
$"        {name} = value;\n" +
$"        OnPropertyChanged(nameof({Name}));\n" +
"    }\n" +
"}";

                    File.AppendAllText("out.txt", s);
                }

                //check, is property has default value
                else
                {
                    string type = item[0];
                    string name = item[1][0].ToString().ToLower() + item[1].Substring(1);
                    string Name = name[0].ToString().ToUpper() + name.Substring(1);
                    string value = line.Replace(item[0] + " " + item[1] + " ", "");
                    string s =
$"\n\nprivate {type} {name} = {value};" + "\n" +
$"public {type} {Name}\n" +
"{\n" +
$"    get => {name};\n" +
$"    set\n" +
"    {\n" +
$"        {name} = value;\n" +
$"        OnPropertyChanged(nameof({Name}));\n" +
"    }\n" +
"}";
                    //write property to out file
                    File.AppendAllText("out.txt", s);
                }
            }
        }
    }
}