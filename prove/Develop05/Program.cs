using System;

class Program
{
    static void Main(string[] args)
    {   Level Stats = new Level();
        
        
        List<string> mainOptions = new List<string>();
        mainOptions.Add("Create Goal");
        mainOptions.Add("List Goals");
        mainOptions.Add("Save Goals");
        mainOptions.Add("Load Goals");
        mainOptions.Add("Record Event");
        mainOptions.Add("Quit");
        List<string> creationOptions = new List<string>();
        creationOptions.Add("Simple Goal");
        creationOptions.Add("Eternal Goal");
        creationOptions.Add("Checklist Goal");

        Main mainMenu = new Main(mainOptions, "Please Choose an Option");
        Create creationMenu = new Create(creationOptions, "Please choose an option.");


    

        int choice = 0;
        while (choice != mainOptions.Count()){
            mainMenu.displayMenu(Stats);
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice){
            case 1: 
                choice = 0;
                Console.WriteLine("What kind of goal is it?");
                creationMenu.displayMenu(Stats);
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice){
                    case 1: 
                        Simple newSimple = new Simple();
                        newSimple.setGoal(newSimple.getGoal());
                        Stats.addGoal(newSimple);

                    break;
                    case 2:
                        Eternal newEternal= new Eternal();
                        newEternal.setGoal(newEternal.getGoal());
                        Stats.addGoal(newEternal);
                        break;
                    case 3:
                        Checklist newCheck= new Checklist();
                        newCheck.setGoal(newCheck.getGoal());
                        Stats.addGoal(newCheck);
                    break;
                }
                break;
                case 2: Stats.showGoals();
                break;
                case 3: Stats.saveGoals();
                break;
                case 4: Stats.loadGoals();
                break;
                case 5: 
                    Stats.showGoals();
                    Console.WriteLine("Which Goal to record for?");
                    int selection = Convert.ToInt16(Console.ReadLine());
                    List<Goal> goals = Stats.getGoals();
                    int count = 1;
                    foreach (Goal goal in goals){
                        if (count== selection){
                            goal.recordEvent(Stats);
                        }
                        count +=1;
                    }
                break;


                case 6: System.Environment.Exit(0);
                break;
        }
        }

    }
    
}