public class Developer : Employee {
    string[] LanguagesKnown {get; set;}

    public Developer() {
        base("Test", "Google", 123);
        LanguagesKnown = new [] {"C#", "Java", "C++"};
    }
}