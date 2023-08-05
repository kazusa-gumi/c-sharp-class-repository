namespace C_sharp_class_repositories;
class Program
{
    static void Main()
    {
        //Random rnd = new Random();
        //int secretNumber = rnd.Next(1, 11); //Maximum value must include 10, so set to 11
        //int numOfGuesses = 5;  

        //Console.WriteLine("Let's start a game, You can choose a number 1 to 10. You have five chances to answer. ");

        //for (int i = 0; i < numOfGuesses; i++)
        //{
        //    Console.Write("PLease input a number: ");
        //    int playerGuess = int.Parse(Console.ReadLine());

        //    if (playerGuess == secretNumber)  
        //    {
        //        Console.WriteLine("Congratulations! you are win!");
        //        return;  
        //    }
        //    else
        //    {
        //        Console.WriteLine("you are loose!");
        //    }
        //}


        //Console.WriteLine("This is the end of it. Answer is " + secretNumber + "！");

        //    Console.Write("Please put a number of students: ");
        //    int numOfStudents = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= numOfStudents; i++)
        //    {
        //        Console.Write($"Please put the {i}'s rating ");
        //        int marks = Convert.ToInt32(Console.ReadLine());
        //        string grade = ConvertMarksToGrade(marks);
        //        Console.WriteLine($"score: {marks}, grades: {grade}");
        //    }
        //}

        //public static string ConvertMarksToGrade(int marks)
        //{
        //    string grade;
        //    if (marks >= 90)
        //        grade = "A";
        //    else if (marks >= 80)
        //        grade = "B";
        //    else if (marks >= 70)
        //        grade = "C";
        //    else if (marks >= 60)
        //        grade = "D";
        //    else
        //        grade = "F";

        //    return grade;



        //{
        //    int numOfRows = 10;
        //    int numOfColumns = 10;

        //    for (int i = 1; i <= numOfRows; i++)
        //    {
        //        for (int j = 1; j <= numOfColumns; j++)
        //        {
        //            if (i == 1 || i == numOfRows || j == 1 || j == numOfColumns)
        //                Console.Write("*");
        //            else
        //                Console.Write(" ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        
            
            {
                for (int i = 1; i <= 20; i++)
                {
                    int asteriskCount = i <= 10 ? i : 21 - i;

                // 1 = 1
                // 18 = (21-18) = 3

                // when asteriskCount is 3, console.Write* is 3
                // same number
                for (int j = 0; j < asteriskCount; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }


}