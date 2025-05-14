
void printMessage()
{
    int point = 5;
    string message = "message";
    Console.WriteLine($"The message is:\n{message}\n")
    if (point > 0 && point < 6)
    {
        Console.WriteLine($"WARNING!WARNING!WARNING!\nThe number of point:\n{point}\n");
    }
    if (point > 5 && point < 11)
    {
        Console.WriteLine($"DANGER!DANGER!DANGER!\nThe number of point:\n{point}\n");
    }
    if (point > 10 && point < 16)
    {
        Console.WriteLine($"ULTRA ALERT!ULTRA ALERT!ULTRA ALERT!\nThe number of point:\n{point}\n");
    }
}
printMessage();




