# Simple C# Datacass constructor with call "OnPropertyChanged"



## Instructions
1. Creatre a file named "input.txt" in the program folder. 
2. List the required properties in the file. Format [type] [name] [value] (if need). Each new property must be on a new line. 
Example
```
  string id  
  string Name SomeName  
  bool isComplete False  
```
3. Run app. As a result, you will get a block of code in the "out.txt" file. Just copy it into your class
Example
```
private string id;
public string Id
{
    get => id
    set
    {
        id = value;
        OnPropertyChanged(nameof(Id));
    }
}

private string Name = "SomeName";
public string Name
{
    get => Name
    set
    {
        Name = value;
        OnPropertyChanged(nameof(Name));
    }
}

private bool isComplete = False;
public bool IsComplete
{
    get => isComplete
    set
    {
        isComplete = value;
        OnPropertyChanged(nameof(IsComplete));
    }
}

```
