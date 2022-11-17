# Simple C# Dataclass constructor with call "OnPropertyChanged"


I wrote it for myself, but maybe someone will need it. The code there is very ugly :)


## Instructions
1. Unzip the archive, then creatre a file named "input.txt" in the program folder, if it does not exist. 
2. List the required properties in the file. Format [type] [name] [value] (if need). Each new property must be on a new line. 
Example
```
string id  
string Name "Some name" 
bool isComplete False  
```
3. Run app. As a result, you will get a block of code in the "out.txt" file. Just copy it into your class
Example
```
private string id;
public string Id
{
    get => id;
    set
    {
        id = value;
        OnPropertyChanged(nameof(Id));
    }
}

private string name = "Some name";
public string Name
{
    get => name;
    set
    {
        name = value;
        OnPropertyChanged(nameof(Name));
    }
}

private bool isComplete = False;
public bool IsComplete
{
    get => isComplete;
    set
    {
        isComplete = value;
        OnPropertyChanged(nameof(IsComplete));
    }
}
```
