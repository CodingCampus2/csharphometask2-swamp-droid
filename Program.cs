using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                const int halfPadding = Task2.Padding / 2;
                string decorativeSigns = new string(task.DecorativeSign, halfPadding);

                return $"{decorativeSigns, -Task2.Padding}{task.Balance:C2}{decorativeSigns, Task2.Padding}";
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
