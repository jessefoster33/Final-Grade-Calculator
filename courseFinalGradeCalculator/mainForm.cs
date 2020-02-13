//Assignment 2: Final Grades Calculator
//
//Author: Jesse Foster
// November 18, 2019
//
//Purpose: Calculating a student's final grades
//
//Description: This application will allow the user to enter a number of quiz marks, as well as a midterm and final exam mark,
// grade them appropiately, and allow the user to deduct the highest/lowest marks if required. Requires a minimum of one quiz mark,
// a midterm mark, and a final exam mark to run. Deducting the highest and lowest marks only works if number of quizzes input is
// five or greater.

//remember to return this from Console Application to Windows Form App
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseFinalGradeCalculator
{
    public partial class mainForm : Form
    {
        //declare your variables here
        
        double quizMarksAverage;            //this will represent the total for marks to use in the Calculate Grade button calculations, should equal 
                                            //the quizzes added together, divided by the number of quizzes, then multiplied by 0.20.
        int quizTransferCounter = 0;        //this is to track the number of quizzes added to the readonly textbox per click on transfer button
        string letterGrade;
        double lowestMark = 100;            // the reason this starts at 100 is because the default value is starting at 0; no values are allowed to go below this
        double highestMark;
        double sumOfQuizzes = 0;
        double midTermMark;
        double finalExamMark;
        double totalGrade;

        public mainForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // when the transferQuizMarkButton is pressed, grab the text in the associated
        // textbox and convert it to an integer, quizMark. This should appear in the readonly textbox.

        private void TransferQuizMarkButton_Click(object sender, EventArgs e)

        {
            string lineOfInput;
            int convertedQuizValue;
            bool valueIsGood;

            do
            {
                lineOfInput = quizMarkInputTextbox.Text;
                valueIsGood = int.TryParse(lineOfInput, out convertedQuizValue);
                if (!valueIsGood)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Quiz Mark Input Box.");
                    return;
                }
               if (convertedQuizValue < 0 || convertedQuizValue > 100)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Quiz Mark Input Box.");
                    return;
                }
            }
            while (!valueIsGood);

            quizMarksReadOnlyTextbox.AppendText(quizMarkInputTextbox.Text + Environment.NewLine); //this will add a new line for each input

            quizTransferCounter++;                                  //counts number of quizzes added
            
            Console.WriteLine($"{quizTransferCounter}");            //check if the clicks are being counted

            sumOfQuizzes = sumOfQuizzes + convertedQuizValue;       //total value of quiz marks are added per input

            Console.WriteLine($"{sumOfQuizzes}");                   //check if sumOfQuizzes is being added on each click

            quizMarkInputTextbox.Clear();                           //clears input box to allow next value to be entered


            if (convertedQuizValue > highestMark)                   //track highest mark continuously
            {
                highestMark = convertedQuizValue;
            }

            if (convertedQuizValue < lowestMark)                    //track lowest mark continuously
            {
                lowestMark = convertedQuizValue;
            }

            Console.WriteLine($"Highest Mark:{highestMark}");       //test if highest mark is tracking
            Console.WriteLine($"Lowest Mark:{lowestMark}");         //test if lowest mark is tracking

        }

        private void ResetQuizButton_Click(object sender, EventArgs e)
        {
            quizMarkInputTextbox.Clear();
            quizMarksReadOnlyTextbox.Clear();
            percentageReadOnlyTextbox.Clear();
            letterGradeReadOnlyTextbox.Clear();
            quizTransferCounter = 0;
            sumOfQuizzes = 0;
        }

        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            quizMarkInputTextbox.Clear();
            quizMarksReadOnlyTextbox.Clear();
            midtermInputTextbox.Clear();
            finalExamInputTextbox.Clear();
            percentageReadOnlyTextbox.Clear();
            letterGradeReadOnlyTextbox.Clear();
            quizTransferCounter = 0;
            sumOfQuizzes = 0;
            dropHighLowQuizMarksCheckbox.Checked = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string lineOfInput;
            int convertedMidTermValue;
            int convertedFinalExamValue;
            bool valueIsGood;

            if (sumOfQuizzes <= 0)
            {
                MessageBox.Show("Please enter a numeric value between 0 and 100 in the Quiz Mark Input box and transfer.");
                return;
            }

            do
            {
                lineOfInput = midtermInputTextbox.Text;
                valueIsGood = int.TryParse(lineOfInput, out convertedMidTermValue);
                if (!valueIsGood)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Midterm Mark Input Box.");
                    return;
                }
                if (convertedMidTermValue < 0 || convertedMidTermValue > 100)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Midterm Mark Input Box.");
                    return;
                }
            }
            while (!valueIsGood);

            midTermMark = convertedMidTermValue * 0.30;

            do
            {
                lineOfInput = finalExamInputTextbox.Text;
                valueIsGood = int.TryParse(lineOfInput, out convertedFinalExamValue);



                if (!valueIsGood)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Final Exam Mark Input Box.");
                    return;
                }
                if (convertedFinalExamValue < 0 || convertedFinalExamValue > 100)
                {
                    MessageBox.Show("Please enter a numeric value between 0 and 100 in the Final Exam Mark Input Box.");
                    return;
                }
            }
            while (!valueIsGood);

            finalExamMark = convertedFinalExamValue * 0.50;


            if (dropHighLowQuizMarksCheckbox.Checked == true && quizTransferCounter >= 5)
            {
                sumOfQuizzes = sumOfQuizzes - highestMark - lowestMark;
                quizMarksAverage = sumOfQuizzes / (quizTransferCounter - 2) * 0.20; //calculates average minus the highest/lowest marks, including the 2 counter totals (because there are now 2 fewer quizzes to divide by)
                Console.WriteLine($"{quizMarksAverage}");                           //check if quizMarksAverage is calculated
                //quizTransferCounter cannot go below 3 after this

            }
            else if (dropHighLowQuizMarksCheckbox.Checked == true && quizTransferCounter < 5)

            {
                MessageBox.Show("Please enter at least 5 or more quiz marks to drop highest and lowest grade.");
                return;
            }

            //else if (dropHighLowQuizMarksCheckbox.Checked == false)
            //{
            //    quizMarksAverage = sumOfQuizzes / quizTransferCounter * 0.20;       //calculates average of total grades and weighs them at 20% value for final grade
            //    Console.WriteLine($"{quizMarksAverage}");                           //check if quizMarksAverage is calculated  

            //}
            Console.WriteLine($"{midTermMark}");                                    //check if midTermMark calculates
            Console.WriteLine($"{finalExamMark}");                                  //check if finalExamMark calculates

            totalGrade = quizMarksAverage + midTermMark + finalExamMark;
            totalGrade = Math.Round(totalGrade, 0, MidpointRounding.AwayFromZero); //rounds decimal value back to a whole number

            if (totalGrade < 0 || totalGrade > 100)
            { MessageBox.Show("Final grade cannot be below 0% or above 100%.");
               return;
            }

            Console.WriteLine($"{quizTransferCounter}");
           
            Console.WriteLine($"{totalGrade}");                                    //check if totalGrade calculates

            percentageReadOnlyTextbox.Text = totalGrade.ToString();                //converts the totalGrade value to string for output

            if (totalGrade >= 95)
            {
                letterGrade = "A+";
            }
            else if (totalGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (totalGrade >= 85)
            {
                letterGrade = "A-";
            }
            else if (totalGrade >= 80)
            {
                letterGrade = "B+";
            }
            else if (totalGrade >= 75)
            {
                letterGrade = "B";
            }
            else if (totalGrade >= 70)
            {
                letterGrade = "B-";
            }
            else if (totalGrade >= 67)
            {
                letterGrade = "C+";
            }
            else if (totalGrade >= 64)
            {
                letterGrade = "C";
            }
            else if (totalGrade >= 60)
            {
                letterGrade = "C-";
            }
            else if (totalGrade >= 55)
            {
                letterGrade = "D+";
            }
            else if (totalGrade >= 50)
            {
                letterGrade = "D";
            }
            else if (totalGrade <= 49)
            {
                letterGrade = "F";
            }

            letterGradeReadOnlyTextbox.Text = letterGrade.ToString();
        }
    }
}
