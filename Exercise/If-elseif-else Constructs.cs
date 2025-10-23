namespace TestProject.Challenge;

public class IfElseifElseConstructs
{
    public void Run()
    {
        string name = "steve";
        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve")
            Console.WriteLine("Found Steve");
        else
            Console.WriteLine("Found Chuck");
    }

}
