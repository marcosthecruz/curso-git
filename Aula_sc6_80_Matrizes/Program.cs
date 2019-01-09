﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_sc6_80_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[]values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) 
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: "+count);
        }
    }
}


//            double[,] mat = new double[3, 4];

//            Console.WriteLine(mat.Length);
//            Console.WriteLine(mat.Rank);
//            Console.WriteLine(mat.GetLength(0)); // quantas linhas tem
//            Console.WriteLine(mat.GetLength(1)); // quantas colunas tem