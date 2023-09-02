// initialize variables - graded assignments 

namespace Starter;
public class StudentScores
{
    public int[] SophiaScores { get; set; }
    public int[] AndrewScores { get; set; }
    public int[] EmmaScores { get; set; }
    public int[] LoganScores { get; set; }
    public int[] BeckyScores { get; set; }
    public int[] ChrisScores { get; set; }
    public int[] EricScores { get; set; }
    public int[] GregorScores { get; set; }
}

internal abstract class Starter
{
    public static void Main(string[] args)
    {
        int currentAssignments = 5;

// create a string array named studentNames
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// initialize variables - scores for each student
        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
// initialize studentScores array
        string currentStudentLetterGrade = "";
        Console.WriteLine("Student\t\tExam Score\t\tGrade\t\tExtra Credit\n");
// loop through student names
        foreach (var name in studentNames)
        {
            int gradedExtraCreditAssignments = 0;
            int examAssignments = 5;
            int sumExamScores = 0;
            int sumExtraCreditScores = 0;
            int gradedAssignments = 0;

            var studentScoresObj = new StudentScores
            {
                SophiaScores = sophiaScores,
                AndrewScores = andrewScores,
                EmmaScores = emmaScores,
                LoganScores = loganScores,
                BeckyScores = beckyScores,
                ChrisScores = chrisScores,
                EricScores = ericScores,
                GregorScores = gregorScores
            };
            var studentScores = GetStudentScores(name, studentScoresObj);

            // loop and add all score in studentScores
            (sumExamScores, gradedExtraCreditAssignments, sumExtraCreditScores) = GetSumExamScores(studentScores, gradedAssignments, examAssignments, sumExamScores, gradedExtraCreditAssignments, sumExtraCreditScores); 
            decimal currentStudentExamScore = (decimal)sumExamScores / examAssignments;
            decimal currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;
            decimal currentStudentGrade = (sumExamScores + (decimal)sumExtraCreditScores / 10) / examAssignments;
            currentStudentLetterGrade = GetCurrentStudentLetterGrade(currentStudentGrade, currentStudentLetterGrade);
            Console.WriteLine($"{name}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / currentAssignments)} pts)");
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
    private static string GetCurrentStudentLetterGrade(decimal currentStudentGrade1, string currentStudentLetterGrade1)
    {
        currentStudentLetterGrade1 = currentStudentGrade1 switch
        {
            >= 97 => "A+",
            >= 93 => "A",
            >= 90 => "A-",
            >= 87 => "B+",
            >= 83 => "B",
            >= 80 => "B-",
            >= 77 => "C+",
            >= 73 => "C",
            >= 70 => "C-",
            >= 67 => "D+",
            >= 63 => "D",
            >= 60 => "D-",
            _ => currentStudentLetterGrade1
        };

        return currentStudentLetterGrade1;
    }
    private static (int sumExamScores, int gradedExtraCreditAssignments, int sumExtraCreditScores) GetSumExamScores(
        int[] studentScores, int gradedAssignments, int examAssignments, int sumExamScores,
        int gradedExtraCreditAssignments, int sumExtraCreditScores)
    {
        foreach (int score in studentScores)
        {
            gradedAssignments += 1;

            if (gradedAssignments <= examAssignments)
            {
                sumExamScores = sumExamScores + score;
            }
            else
            {
                gradedExtraCreditAssignments += 1;
                sumExtraCreditScores += score;
            }
        }

        return (sumExamScores, gradedExtraCreditAssignments, sumExtraCreditScores);
    }
    private static int[] GetStudentScores(string name, StudentScores studentScores)
    {
        return name switch
        {
            "Sophia" => studentScores.SophiaScores,
            "Andrew" => studentScores.AndrewScores,
            "Emma" => studentScores.EmmaScores,
            "Logan" => studentScores.LoganScores,
            "Becky" => studentScores.BeckyScores,
            "Chris" => studentScores.ChrisScores,
            "Eric" => studentScores.EricScores,
            "Gregor" => studentScores.GregorScores,
            _ => throw new ArgumentException($"Invalid name: {name}")
        };
    }
}