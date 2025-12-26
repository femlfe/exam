using System;
using System.Collections.Generic;
using System.Text;

namespace FindShortestLine.Classes
{
    public class Graph
    {
        public static int n;

        public Graph(int _n)
        {
            n = _n;
        }
        /* Реализация алгоритма Дейкстры для поиска кратчайших путей во взвешенном графе.
         * Входные данные:      а - матрица инцидентности взвешенного графа
         *                      v0 - номер вершины, для которой вычисляются кратчайшие расстояния
         *                           до остальных вершин
         * Выходные данные:     одномерный массив кратчайших расстояний от вершины а 
         *                      до каждой из вершин графа (включая саму вершину а)
         */
        private static double[] Dijkstra(double[,] a, int v0)
        {
            double[] dist = new double[n];
            bool[] vis = new bool[n];
            int unvis = n;
            int v;

            for (int i = 0; i < n; i++)
                dist[i] = Double.MaxValue;
            dist[v0] = 0.0;

            while (unvis > 0)
            {
                v = -1;
                for (int i = 0; i < n; i++)
                {
                    if (vis[i])
                        continue;
                    if ((v == -1) || (dist[v] > dist[i]))
                        v = i;
                }
                vis[v] = true;
                unvis--;
                for (int i = 0; i < n; i++)
                {
                    if (dist[i] > dist[v] + a[v, i])
                        dist[i] = dist[v] + a[v, i];
                }
            }
            return dist;
        }

        public double[,] CreateGraph()
        {
            double[,] matrix = new double[n,n];

            for (int i = 0;i < n; i++)
            {
                for(int j = i; j<n; j++)
                {
                    Console.WriteLine($"Введите расстояние от точки {i+1} до точки {j+1}\n\tЕсли точки не связаны введите 0");

                    double distance = 0;
                    bool rightInput = false;

                    string input = Console.ReadLine();
                    rightInput = double.TryParse(input, out distance);

                    while (!rightInput)
                    {
                        Console.WriteLine($"Вы допустили ошибку!");
                        Console.WriteLine($"Введите расстояние от точки {i + 1} до точки {j + 1}\n\tЕсли точки не связаны введите 0");

                        input = Console.ReadLine();
                        rightInput = double.TryParse(input, out distance);
                    }

                    matrix[i,j] = distance;
                }
            }

            return matrix;
        }
    }
}
