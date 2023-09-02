// initialize variables - graded assignments 
var currentAssignments = 5;

// create a string array named studentNames
var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// initialize variables - scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 91, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// initialize studentScores array
var studentScores = new int[10];

var sophiaSum = 0;
var andrewSum = 0;
var emmaSum = 0;
var loganSum = 0;

decimal sophiaScore = 0;
decimal andrewScore = 0;
decimal emmaScore = 0;
decimal loganScore = 0;

Console.WriteLine("Student\t\tGrade\n");
// loop through student names
foreach (var name in studentNames)
{
    if (name == "Sophia")
    {
        // calculate the sum inside a foreach for sophia
        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }
        sophiaScore = (decimal)(sophiaSum) / currentAssignments;
        andrewScore = (decimal)andrewSum / currentAssignments;
        emmaScore = (decimal)emmaSum / currentAssignments;
        loganScore = (decimal)loganSum / currentAssignments;
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}



