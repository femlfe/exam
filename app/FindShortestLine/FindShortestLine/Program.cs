using FindShortestLine.Classes;

string input;
int firstP, secondP;
int choise, num;

Console.WriteLine("Введите количество точек");
input = Console.ReadLine();

while (!int.TryParse(input, out num) && num<1)
{
    Console.WriteLine("Вы совершии ошибку!");
    Console.WriteLine("Введите количество точек");
    input = Console.ReadLine();
}

Graph graph = new Graph(num);

graph.CreateGraph();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(graph.incidenceMatrix[i, j] + "\t");
    }

    Console.WriteLine();
}

Console.WriteLine("---КАРТА УСПЕШНО ВВЕДЕНА---");



while (true)
{
    Console.WriteLine("\t1 - Найти кратчайшее расстояние между точками\n\t0 - Завершение работы программы");
    input = Console.ReadLine();

    while (!int.TryParse(input, out choise) && (choise != 0 || choise != 1))
    {
        Console.WriteLine("Вы совершии ошибку!");
        Console.WriteLine("\t1 - Найти кратчайшее расстояние между точками\n\t0 - Завершение работы программы");
        input = Console.ReadLine();
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

                while (!int.TryParse(input, out firstP) && (firstP < 1 || firstP > 9))
                {
                    Console.WriteLine("Вы совершии ошибку!");
                    Console.WriteLine($"Введите номер первой точки (от 1 до {num})");

                    input = Console.ReadLine();
                }

                Console.WriteLine($"Введите номер второй точки (от 1 до {num})");
                input = Console.ReadLine();

                while (!int.TryParse(input, out secondP) && (secondP < 1 || secondP > 9))
                {
                    Console.WriteLine("Вы совершии ошибку!");
                    Console.WriteLine($"Введите номер первой точки (от 1 до {num})");

                    input = Console.ReadLine();
                }

                Console.WriteLine($"Кратчайшее расстояние от точки {firstP} до точки {secondP} = {graph.ComparePoints(firstP - 1, secondP - 1)}");

                break;
            }
    }

}




