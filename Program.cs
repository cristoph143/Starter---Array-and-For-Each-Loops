// initialize variables - graded assignments 

namespace Starter;

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
        Console.WriteLine("Student\t\tGrade\n");
// loop through student names
        foreach (var name in studentNames)
        {
            const int gradeAssignments = 0;
            var sumAssignmentScores = 0;
            var studentScores = GetStudentScore(name, sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores);
            // loop and add all score in studentScores
            sumAssignmentScores = GetSumAssignmentScores(studentScores, gradeAssignments, currentAssignments, sumAssignmentScores);
            var currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
            currentStudentLetterGrade = GetCurrentStudentLetterGrade(currentStudentGrade, currentStudentLetterGrade);
            Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

        int[] GetStudentScore(string s, int[] ints, int[] andrewScores1, int[] emmaScores1, int[] loganScores1,
            int[] beckyScores1, int[] chrisScores1, int[] ericScores1, int[] gregorScores1)
        {
            int[] studentScores1 = new int[] { };
            switch (s)
            {
                case "Sophia":
                    studentScores1 = ints;
                    break;
                case "Andrew":
                    studentScores1 = andrewScores1;
                    break;
                case "Emma":
                    studentScores1 = emmaScores1;
                    break;
                case "Logan":
                    studentScores1 = loganScores1;
                    break;
                case "Becky":
                    studentScores1 = beckyScores1;
                    break;
                case "Chris":
                    studentScores1 = chrisScores1;
                    break;
                case "Eric":
                    studentScores1 = ericScores1;
                    break;
                case "Gregor":
                    studentScores1 = gregorScores1;
                    break;
                default:
                    return studentScores1;
            }

            return studentScores1;
        }

        string GetCurrentStudentLetterGrade(decimal currentStudentGrade1, string currentStudentLetterGrade1)
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

        int GetSumAssignmentScores(int[] ints1, int i, int currentAssignments1, int sumAssignmentScores1)
        {
            foreach (var score in ints1)
            {
                i += 1;
                if (i <= currentAssignments1)
                    sumAssignmentScores1 += score;
                else
                    sumAssignmentScores1 += score / 10;
            }

            return sumAssignmentScores1;
        }
    }
}