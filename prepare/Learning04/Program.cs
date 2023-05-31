using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment gregAssignment =  new MathAssignment("7.3","1-3", "Greg", "fractions");
        WritingAssignment gregWriting = new WritingAssignment("Why Greg is the Best", "Greg Evans", "English");
        Console.WriteLine(gregAssignment.getHomeworkList());
        Console.WriteLine(gregWriting.getWritingInformation());
    }
}