using System;

class Program
{
    static void Main(string[] args)
    {
        // Video #1
        Video howTo = new Video("How to eat waffles", "Ronald McDonald", 3);
        howTo.addComment(new Comment("Grimace", "I love Waffles!"));
        howTo.addComment(new Comment("Wendy", "Can I do this with Pancakes?"));
        howTo.addComment(new Comment("Burger King", "Waffles are gross, eat a burger instead!!"));
        howTo.addComment(new Comment("Duolingo", "Hablas Español?"));
        // Video #2
        Video workout = new Video("Dance for 1 hour", "Alayna the Dancer", 3600);
        workout.addComment(new Comment("Joe", "This is too hard for me!"));
        workout.addComment(new Comment("Bill", "Can I do it for 1o minutes instead?"));
        workout.addComment(new Comment("Ronny", "I think the music could be better"));
        workout.addComment(new Comment("Fred", "First!"));
        // Video #3
        Video monkey = new Video("Monkey screans then falls asleep", "MonkeyLover 34", 60);
        monkey.addComment(new Comment("Carol Baskin", "This is animal abuse!"));
        monkey.addComment(new Comment("King Kong", "Ooh Ooh Ahh Ahh!"));
        monkey.addComment(new Comment("Diego", "Lets take him to the animal shelter!"));
        // List of Videos
        List<Video> videos = new List<Video>();
        videos.Add(howTo);
        videos.Add(workout);
        videos.Add(monkey);

        foreach (Video video in videos){
            Console.WriteLine(video.getFormatedInfo());
            Console.WriteLine($"There are {video.countComments()} comments");
            Console.WriteLine();
            video.displayComments();
            Console.WriteLine();
        }
    }
}