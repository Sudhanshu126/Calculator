using System;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private string displayText = "0";
        private bool canWork = true;

        public Form1()
        {
            InitializeComponent();
        }

        //Display
        private void Display_TextChanged(object sender, EventArgs e)
        {
            displayText = display.Text;
            if (display.Text.Length > 20)
            {
                back_Click(sender, e);
            }
        }

        //Clear
        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            canWork = true;
        }

        //Numbers button
        private void number_Click(object sender, EventArgs e)
        {
            if (displayText == "0" && canWork)
            {
                display.Text = ((Button)sender).Text;
            }
            else if (canWork)
            {
                display.Text += ((Button)sender).Text;
            }
        }

        //Zero button
        private void zero_Click(object sender, EventArgs e)
        {
            if (displayText != "0" && canWork)
            {
                display.Text += "0";
            }
        }

        //Operations button
        private void operation_Click(object sender, EventArgs e)
        {
            if (!displayText.EndsWith(((Button)sender).Text) && canWork)
            {
                string text = ((Button)sender).Text;
                if (text == "√")
                {
                    display.Text = ((Button)sender).Text;
                }
                else
                {
                    display.Text += ((Button)sender).Text;
                }
            }
        }

        //Back button
        private void back_Click(object sender, EventArgs e)
        {
            if (canWork)
            {
                display.Text = displayText.Substring(0, displayText.Length - 1);
                if (displayText.Length == 0)
                {
                    display.Text = "0";
                }
            }
        }

        //Dot button
        private void dot_Click(object sender, EventArgs e)
        {
            if (!displayText.Contains(".") && canWork)
            {
                display.Text += ".";
            }
        }

        //Brackets button
        private void brackets_Click(object sender, EventArgs e)
        {
            string bracket = ((Button)sender).Text;
            if (displayText == "0")
            {
                display.Text = bracket;
            }
            else
            {
                display.Text += bracket;
            }
        }

        //Equal button 
        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                string result = CheckBrackets(ProcessExpression(displayText));
                display.Text = result;
            }
            catch (Exception ex)
            {
                string errorMsg = ex.Message;
                if(errorMsg != "Brackets unequal")
                {
                    errorMsg = "Syntax error";
                }
                display.Text = errorMsg;
                canWork = false;
            }
        }

        //Checks if brackets exist and if yes solves bracket and if no evaluates expression
        private string CheckBrackets(string expression)
        {
            int openBrackets = expression.Count(c => c == '(');
            int closeBrackets = expression.Count(c => c == ')');
            if (openBrackets != closeBrackets)
            {
                throw new Exception("Brackets unequal");
            }
            else
            {
                if (openBrackets == 0)
                {
                    return EvaluateExpression(expression);
                }
                else
                {
                    return SolveBracket(expression);
                }
            }
        }

        //Checks for sub expressions in a bracket and solves them
        private string SolveBracket(string expression)
        {
            string finalExpression = expression;
            string processExpression = expression;

            char[] input = expression.ToCharArray();
            int index = 0;
            int startIndex = 0, endIndex;
            int startBracketCount = 0, endBracketCount = 0;

            bool foundStart = false;

            while (index < input.Length)
            {
                if (input[index] == '(')
                {
                    if (!foundStart)
                    {
                        foundStart = true;
                        startIndex = index;
                    }
                    startBracketCount++;
                }

                if (input[index] == ')')
                {
                    endBracketCount++;
                    if (startBracketCount == endBracketCount)
                    {
                        endIndex = index;
                        processExpression = expression.Substring(startIndex + 1, endIndex - startIndex - 1);
                        string result = CheckBrackets(processExpression);
                        finalExpression = finalExpression.Replace(processExpression, result);
                        finalExpression = RemoveBracket(finalExpression);
                        foundStart = false;
                    }
                }
                index++;
            }
            return EvaluateExpression(finalExpression);
        }

        private string RemoveBracket(string expression)
        {
            StringBuilder input = new StringBuilder(expression);
            for (int index = 0; index < input.Length; index++)
            {
                if (input[index] == '(')
                {
                    if (index == 0 || (index != 0 && !char.IsDigit(input[index - 1])))
                    {
                        input.Remove(index, 1);
                    }
                    else
                    {
                        input.Replace('(', '*');
                    }
                }
                else if (input[index] == ')')
                {
                    if (index == input.Length - 1 || (index != input.Length - 1 && !char.IsDigit(input[index + 1])))
                    {
                        input.Remove(index, 1);
                    }
                    else if (index != expression.Length && input[index + 1] == '(')
                    {
                        input.Replace(')', '*');
                    }
                    else
                    {
                        input.Replace(')', '*');
                    }
                }
            }
            return input.ToString();
        }

        private string EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);

            DataRow row = table.NewRow();
            table.Rows.Add(row);

            return double.Parse((string)row["expression"]).ToString();
        }

        private string ProcessExpression(string expression)
        {
            expression = expression.Replace("%", "/100");

            return expression;
        }
    }
}
