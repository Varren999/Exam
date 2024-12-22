//===========================================================================================================
// Составить словарь частот чисел в каждой строке (Dictionary<int, int>) и упорядочить его по убыванию
// (для этого уменьшите max для генератора случайных и чисел и дайте побольше размер матрицы).
//===========================================================================================================
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, cols, max;
            rows = InputText("Введите количество строк: ");
            cols = InputText("Введите количество столбцов: ");
            max = InputText("Введите максимальное значение числа для генератора случайных чисел: ");
            Collections matrix = new Collections(rows, cols, max);
            matrix.GetInfo();          
        }

        static int InputText(string msg)
        {
            int a = 0;
            bool cycle = true;
            while (cycle)
            {
                cycle = false;
                try
                {
                    Console.Write(msg);
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0)
                    {
                        cycle = true;
                        throw new Exception("Введеное число не может быть меньше 1.");
                    }             
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
            return a;
        }
    }
}
