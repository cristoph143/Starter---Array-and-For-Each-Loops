# Guided-project-foreach-if-array-CSharp
Starter and Solution code for the Guided project: "Develop foreach and if-elseif-else structures to process array data in C#" from the Microsoft Learn collection "Getting started with C#"

## Project overview
You're developing a Student Grading application that automates the calculation of current grades for each student in a class. The parameters for your application are:

You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.
Currently, the teachers grade book shows the graded assignments for each student as follows:

This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades:
                       
| Student | Grade |    |
|---------|-------|----|
| Sophia  | 92.2  | A- |
| Andrew  | 89.6  | B+ |
| Emma    | 85.6  | B  |
| Logan   | 91.2  | A- |

------------------------------

This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades:
   
| Student | Exam Score | Overall Grade | Extra Credit  |
|---------|------------|---------------|---------------|
| Sophia  | 92.2       | 95.88         | 92 (3.68 pts) |
