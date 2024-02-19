using System.Numerics;

namespace Labor1
{
    class Program
    {
        static int Main(string[] args)
        {
            var tanks = GetTanks();
            var units = GetUnits();
            var factories = GetFactories();
            Console.WriteLine($"Количество резервуаров: {tanks.Length}, установок: {units.Length}");

            var foundUnit = FindUnit(units, tanks, "Резервуар 2");
            var factory = FindFactory(factories, foundUnit);

            Console.WriteLine($"Резервуар 2 принадлежит установке {foundUnit.Name} и заводу {factory.Name}");

            var totalVolume = GetTotalVolume(tanks);
            Console.WriteLine($"Общий объем резервуаров: {totalVolume}");

            PrintAllTanks(tanks,units,factories);//вывод всех резервуаров

            var TheFactories = new List<Factory> //создание коллекций для 6 задания (без использования конструктора)
            {
            new (){ Id=1, Name="НПЗ№1", Description="Первый нефтеперерабатывающий завод"},
            new (){ Id=2, Name="НПЗ№2", Description = "Второй нефтеперерабатывающий завод"}
            };

            var TheUnits = new List<Unit>
            {
            new (){ Id=1, Name="ГФУ-2", Description="Газофракционирующая установка", FactoryId=1},
            new (){ Id=2, Name="АВТ-6", Description = "Атмосферно-вакуумная трубчатка", FactoryId=1},
            new (){ Id=3, Name="АВТ-10", Description = "Атмосферно-вакуумная трубчатка", FactoryId=2}
            };

            var TheTanks = new List<Tank>
            {
            new (){ Id=1, Name="Резервуар 1", Description="Надземный-вертикальный", Volume=1500, MaxVolume=2000, UnitId=1},
            new (){ Id=2, Name="Резервуар 2", Description="Надземный-горизонтальный", Volume=2500, MaxVolume=3000, UnitId=1},
            new (){ Id=3, Name="Дополнительный резервуар 24", Description="Надземный-горизонтальный", Volume=3000, MaxVolume=3000, UnitId=2},
            new (){ Id=4, Name="Резервуар 35", Description="Надземный-вертикальный", Volume=3000, MaxVolume=3000, UnitId=2},
            new (){ Id=5, Name="Резервуар 47", Description="Подземный-двустенный", Volume=4000, MaxVolume=5000, UnitId=2},
            new (){ Id=6, Name="Резервуар 256", Description="Подводный", Volume=500, MaxVolume=500, UnitId=3}
            };

            int choice=0; //переменная для switch case
            Console.WriteLine("Что вы хотите найти: 1-завод, 2-установку, 3-резервуар");
            if (!int.TryParse(Console.ReadLine(), out choice) | choice<1 | choice>3) { Console.WriteLine("Ошибка"); return 0; } // Считывание информации с клавиатуры

            Console.WriteLine("Введите наименование объекта:");
            string? input=Console.ReadLine();// Считывание информации с клавиатуры

            
            if (!string.IsNullOrEmpty(input))// Проверка не введена ли пустая строка
            {
                switch (choice)
                {
                    case 1:
                        var fact = TheFactories.Find(x => x.Name == input);
                        if (fact != null) Console.WriteLine($"Name: {fact.Name}, Id: {fact.Id}, Description: {fact.Description}");
                        else { Console.WriteLine("объект не найден"); }
                        break;

                    case 2:
                        var unt = TheUnits.Find(x => x.Name == input);
                        if (unt != null) Console.WriteLine($"Name: {unt.Name}, Id: {unt.Id}, Description: {unt.Description}, FactoryId: {unt.FactoryId}");
                        else { Console.WriteLine("объект не найден"); }
                        break;

                    case 3:
                        var tnk = TheTanks.Find(x => x.Name == input);
                        if (tnk != null) Console.WriteLine($"Name: {tnk.Name}, Id: {tnk.Id}, Description: {tnk.Description}, Volume: {tnk.Volume}, MaxVolume: {tnk.MaxVolume}, UnitId: {tnk.UnitId}");
                        else { Console.WriteLine("объект не найден"); }
                        break;

                }
            }
            else { Console.WriteLine("Не введено название объекта"); }
            return 1;
        }

        // реализуйте этот метод, чтобы он возвращал массив резервуаров, согласно приложенным таблицам
        // можно использовать создание объектов прямо в C# коде через new, или читать из файла (на своё усмотрение)
        public static Tank[] GetTanks()
        {
            Tank[] tanks = new Tank[6];
            for (int i = 0; i < 6; i++)
            {
                string text = File.ReadLines("tanks.txt").ElementAt(i);//файл находится в bin/Debug/net6.0
                //проходимся по файлу построчно
                string[] mystring = text.Split(',');//делим строку
                tanks[i] = new Tank(int.Parse(mystring[0]), mystring[1], mystring[2], int.Parse(mystring[3]), int.Parse(mystring[4]), int.Parse(mystring[5]));//при создании объекта класса используем конструктор с параметрами
            }
            return tanks;
        }

        // реализуйте этот метод, чтобы он возвращал массив установок, согласно приложенным таблицам
        public static Unit[] GetUnits()
        {
            Unit[] units = new Unit[3];
            for (int i = 0; i < 3; i++)
            {
                string text = File.ReadLines("units.txt").ElementAt(i);//файл находится в bin/Debug/net6.0
                //проходимся по файлу построчно
                string[] mystring = text.Split(',');//делим строку
                units[i] = new Unit(int.Parse(mystring[0]), mystring[1], mystring[2], int.Parse(mystring[3]));//при создании объекта класса используем конструктор с параметрами
            }
            return units;
        }
        // реализуйте этот метод, чтобы он возвращал массив заводов, согласно приложенным таблицам
        public static Factory[] GetFactories()
        {
            Factory[] factories = new Factory[2];
            for (int i = 0; i < 2; i++)
            {
                string text = File.ReadLines("factories.txt").ElementAt(i);//файл находится в bin/Debug/net6.0
                //проходимся по файлу построчно
                string[] mystring = text.Split(',');//делим строку
                factories[i] = new Factory(int.Parse(mystring[0]), mystring[1], mystring[2]);//при создании объекта класса используем конструктор с параметрами
            }
            return factories;
        }

        // реализуйте этот метод, чтобы он возвращал установку (Unit), которой
        // принадлежит резервуар (Tank), найденный в массиве резервуаров по имени
        // учтите, что по заданному имени может быть не найден резервуар
        public static Unit FindUnit(Unit[] units, Tank[] tanks, string tankName)
        {
            int FoundUnitId=0;
            for (int i = 0;i < tanks.Length;i++) 
            {
                if (tanks[i].Name == tankName) 
                {
                    FoundUnitId = tanks[i].UnitId;
                    break;
                }
            
            }
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i].Id == FoundUnitId)
                {
                    return units[i];
                }

            }
            return new Unit();//если заданного имени резервуара не существует то создаем пустую установку со стандартными свойствами и возвращаем её
        }

        // реализуйте этот метод, чтобы он возвращал объект завода, соответствующий установке
        public static Factory FindFactory(Factory[] factories, Unit unit)
        {
            for (int i = 0; i < factories.Length; i++)
            {
                if (unit.FactoryId == factories[i].Id)
                {
                    return factories[i];
                } 
            }
            return new Factory();//если в массиве не существует заданной установки то создаем пустой завод со стандартными свойствами и возвращаем его
        }

        // реализуйте этот метод, чтобы он возвращал суммарный объем резервуаров в массиве
        public static int GetTotalVolume(Tank[] units)
        {
            int totalVolume = 0;
            for(int i = 0;i<units.Length;i++) { totalVolume += units[i].Volume; }
            return totalVolume;
        }

        public static void PrintAllTanks(Tank[] tanks, Unit[] units, Factory[] factories) //вывод в консоль всех резервуаров, включая имена цеха и фабрики, в которых они числятся.
        {
            for(int i = 0; i<tanks.Length; i++)
            {
                var foundUnit = FindUnit(units, tanks, tanks[i].Name);
                var factory = FindFactory(factories, foundUnit);

                Console.WriteLine($"{tanks[i].Name} принадлежит установке {foundUnit.Name} и заводу {factory.Name}");
            }
        }

    }



}