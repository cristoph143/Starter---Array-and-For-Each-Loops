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

Console.WriteLine("Student\t\tGrade\n");
// loop through student names
foreach (var name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    // loop and add all score in studentScores
    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
    // Console.ReadLine();
}
Console.WriteLine("Press the Enter key to continue");


