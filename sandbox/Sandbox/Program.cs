using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello World! This is the Sandbox Project.");
    // }
    
}

public class Person
{
        // The C# convention is to start member variables with an underscore _
    public string _givenName = "";
    public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
    public Person()
    {
    }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
   
    static void Main(string[] args)
    {
        Person myObj = new Person();
        Console.WriteLine();
        myObj._givenName = "Joseph";
        myObj._familyName = "Smith";
        myObj.ShowWesternName();
        myObj.ShowEasternName();
        

        Person person2 = new Person();
        person2._givenName = "JMK";
        person2._familyName = "AGER";
        person2.ShowWesternName();
    }
}
    

