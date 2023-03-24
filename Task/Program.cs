// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых <= 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

using System;
using static System.Console;

Clear ();
string[] array1 = new string[5] { "123", "23", "hello", "hi", ";)" };
string[] array2 = new string[ array1.Length ];
void SecondArrayWithIF( string[] array1, string[] array2 )
{
    int count = 0;
    for ( int i = 0; i < array1.Length; i++ )
    {
    if( array1[i].Length <= 3 )
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray( string[] array )
{
    for ( int i = 0; i < array.Length; i++ )
    {
        Write( $"{array[i]} " );
    }
    WriteLine();
}
SecondArrayWithIF( array1, array2 );
PrintArray( array2 );