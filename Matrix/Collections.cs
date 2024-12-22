using System.Linq;

namespace Collections
{
    class Collections
    {
        private Random random = new Random();

        private List<List<int>> Data = new List<List<int>>();
        private List<Dictionary<int, int>> Dict = new List<Dictionary<int, int>>();
        
        public Collections(int m, int n, int max)
        {
            //Заполняем коллекцию данными
            for (int i = 0; i < m; i++)
            {
                Data.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    Data[i].Add(random.Next(1, max));
                }
            }
            GetDictionary();
        }
        
        // Метод для создания словаря частот.
        public void GetDictionary()
        {
            try
            {
                if (Data is null)
                    throw new Exception("Была передана пустая коллекция!");
                foreach (var item in Data)
                {
                    var item2 = new Dictionary<int, int>();
                    foreach (var item1 in item)
                    {
                        if (item2.ContainsKey(item1))
                            item2[item1]++;
                        else
                            item2.Add(item1, 1);
                    }
                    Dict.Add(item2);
                }
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        //метод получения информации об объекте
        public void GetInfo()
        {
            //for (int i = 0; i < Data.Count; i++)
            //{
            //    for (int j = 0; j < Data[i].Count; j++)
            //    {
            //        Console.Write(Data[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // Исходный массив.
            Console.WriteLine("Исходный массив: ");
            foreach (var item in Data)
            {
                foreach (var item1 in item)
                {
                    //Console.ForegroundColor = (ConsoleColor)item1;
                    Console.Write(item1 + "\t");
                    //Console.ResetColor();
                }
                Console.WriteLine();
            }

            // Сумма всех чисел.
            //int sum = 0;
            //foreach (var item in Data)
            //{
            //    sum += item.Sum();
            //}
            //Console.WriteLine("Сумма всех чисел: " + sum);

            // Словарь частот.
            Console.WriteLine("Словарь частот: ");
            //Console.WriteLine("{0, -10}{1,-20}", "Число:", "Кол-во:");
            foreach (var item in Dict)
            {
                foreach (KeyValuePair<int, int> it in item.OrderByDescending(x => x.Value))
                {
                    Console.Write($"{it.Key} = {it.Value}\t");
                }
                Console.WriteLine();
            }
            

        }

        //private void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
