﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здесь написан класс осуществляющий некоторые операции над матрицами!");

public class MatrixOp
{
    double[,] first;
    double[,] second;
    public MatrixOp(double[,] first, double[,] second)
    {
        this.first = first;
        this.second = second;
    }

    public double[,] Multiple()
    {
        if (first.GetLength(1) != second.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        double[,] r = new double[first.GetLength(0), second.GetLength(1)];
        for (int i = 0; i < r.GetLength(0); i++)
        {
            for (int j = 0; j < r.GetLength(1); j++)
            { 
                for (int k = 0; k < first.GetLength(1); k++)
                {
                    r[i, j] += first[i, k] * second[k, j];
                }
            }
        }
        return r;
    }

    public double[,] Sum()
    {
        double[,] t =  new double[first.GetLength(0), first.GetLength(1)];
        for (int i = 0; i < t.GetLength(0); i++) 
        {
            for (int j = 0; j < t.GetLength(1); j++) 
            {
                t[i, j] = first[i, j];
            }
        }
        if (first.GetLength(1) != second.GetLength(1) && first.GetLength(0) != second.GetLength(0)) throw new Exception("Матрицы нельзя сложить");
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < first.GetLength(1); j++)
            {
                t[i, j] += second[i, j];
            }
        }
        return t;
    }

    public double[,] Subtract()
    {
        double[,] t = new double[first.GetLength(0), first.GetLength(1)];
        for (int i = 0; i < t.GetLength(0); i++)
        {
            for (int j = 0; j < t.GetLength(1); j++)
            {
                t[i, j] = first[i, j];
            }
        }
        if (first.GetLength(1) != second.GetLength(1) && first.GetLength(0) != second.GetLength(0)) throw new Exception("Матрицы нельзя сложить");
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < first.GetLength(1); j++)
            {
                t[i, j] -= second[i, j];
            }
        }
        return t;
    }

};
