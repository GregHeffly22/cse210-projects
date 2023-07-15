using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateOne = new DateTime(5/5/24);
        Running activityOne = new Running(dateOne, 30, 6, "miles");

        DateTime dateTwo = new DateTime(5/12/26);
        Cycling activityTwo = new Cycling(dateTwo, 60, 20, "miles");

        DateTime dateThree = new DateTime(23/2/24);
        Swimming activityThree = new Swimming (dateThree, 45, 60, "kilometers");

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(activityOne);
        exercises.Add(activityTwo);
        exercises.Add(activityThree);

        foreach( Exercise exercise in exercises){
            Console.WriteLine(exercise.getSummary());
        }

    }
}