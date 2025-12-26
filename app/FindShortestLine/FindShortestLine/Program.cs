using FindShortestLine.Classes;

string input;
int firstP, secondP;
int choise, num;

Console.WriteLine("Введите количество точек");
input = Console.ReadLine();

while (!int.TryParse(input, out num) || num<1)
{
    Console.WriteLine("Вы совершии ошибку!");
    Console.WriteLine("Введите количество точек");
    input = Console.ReadLine();
}

Graph graph = new Graph(num);

graph.CreateGraph();

///Вывод матрицы для проеврки
//for (int i = 0; i < num; i++)
//{
//    for (int j = 0; j < num; j++)
//    {
//        Console.Write(graph.incidenceMatrix[i, j] + "\t");
//    }

//    Console.WriteLine();
//}

Console.WriteLine("---КАРТА УСПЕШНО ВВЕДЕНА---");



while (true)
{
    Console.WriteLine("\t1 - Найти кратчайшее расстояние между точками\n\t0 - Завершение работы программы");
    input = Console.ReadLine();

    bool rightInput = int.TryParse(input, out choise);

    while (!rightInput || (choise != 0 && choise != 1))
    {
        Console.WriteLine("Вы совершии ошибку!");
        Console.WriteLine("\t1 - Найти кратчайшее расстояние между точками\n\t0 - Завершение работы программы");
        input = Console.ReadLine();
        rightInput = int.TryParse(input, out choise);
    }

    switch (choise)
    {
        case 0:
            {
                return 0;
            }
        case 1:
            {
                Console.WriteLine($"Введите номер первой точки (от 1 до {num})");
                input = Console.ReadLine();

                rightInput = int.TryParse(input, out firstP);

                while (!rightInput || firstP < 1 || firstP > num)
                {

                    Console.WriteLine("Вы совершии ошибку!");
                    Console.WriteLine($"Введите номер первой точки (от 1 до {num})");

                    input = Console.ReadLine();
                    rightInput = int.TryParse(input, out firstP);
                }

                Console.WriteLine($"Введите номер второй точки (от 1 до {num})");
                input = Console.ReadLine();

                rightInput = int.TryParse(input, out secondP);


                while (!rightInput || secondP < 1 || secondP > num)
                {
                    Console.WriteLine("Вы совершии ошибку!");
                    Console.WriteLine($"Введите номер второй точки (от 1 до {num})");

                    input = Console.ReadLine();
                }

                Console.WriteLine($"Кратчайшее расстояние от точки {firstP} до точки {secondP} = {graph.ComparePoints(firstP - 1, secondP - 1)}");

                break;
            }
    }

}




