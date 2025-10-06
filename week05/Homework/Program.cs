using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Gualter Santos", "History");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Gualter Santos", "Fractions", "7.3", "8–19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Gualter Santos", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}