﻿namespace Collections
{
    class Collections
    {
        private Random random = new Random();

        private List<List<int>> Data = new List<List<int>>();
        private Dictionary<int, int> Dict = new Dictionary<int, int>();
        
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
                    foreach (var item1 in item)
                    {
                        if (Dict.ContainsKey(item1))
                            Dict[item1]++;
                        else
                            Dict.Add(item1, 1);
                    }
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
                    Console.ForegroundColor = (ConsoleColor)item1;
                    Console.Write(item1 + "\t");
                    Console.ResetColor();
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
            Console.WriteLine("{0, -10}{1,-20}", "Число:", "Кол-во:");
            foreach (KeyValuePair<int, int> it in Dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0, -10}{1,-20}", it.Key, it.Value);
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
