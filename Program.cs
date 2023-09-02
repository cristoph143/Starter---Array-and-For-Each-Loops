// initialize variables - graded assignments 
var currentAssignments = 5;

// initialize variables - scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 91, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// initialize studentScores array
var studentScores = new int[10];

var sophiaSum = 0;
var andrewSum = 0;
var emmaSum = 0;
var loganSum = 0;

// calculate the sum inside a foreach for sophia
foreach (var score in sophiaScores)
{
    sophiaSum += score;
}

var sophiaScore = (decimal)sophiaSum / currentAssignments;
var andrewScore = (decimal)andrewSum / currentAssignments;
var emmaScore = (decimal)emmaSum / currentAssignments;
var loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
