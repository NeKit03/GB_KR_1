/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.*/
using System;

public class KR
{
    public static void PrintMatrix(string[] array)
    {
    foreach(string i in array){
            Console.Write($"{i}, ");
        
      }Console.Write("\n");
    
    }


    public static void SortSize(string[] array)
    {
        Console.WriteLine("\nМатрица с упорядоченными по колличеству символов в строках:");
    foreach(string i in array){
        if (i.Length<=3)
            Console.Write($"{i}, ");
    }

        

    }

    public static void Main()
    {
       string[] words = Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Исходная строка:");
        PrintMatrix(words);

        SortSize(words);

        
        
    }
}