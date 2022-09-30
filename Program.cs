// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

void Holidays ()
{
    Console.Write("Введите число, обозначающее день недели: ") ;
    int day = Convert.ToInt32(Console.ReadLine ()) ;
    
    if ( day < 6)
            Console.WriteLine($"Это будний день");
    else
            Console.WriteLine($"Это выходной день");
    
}

Holidays ();

//-----------------------------------------------------------

// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

void ThirdNum ()
{
    Console.Write("Введите число: ") ;
    string str = (Console.ReadLine ()) ;
    
    try 
        {
            Console.WriteLine(str[2]);
        }
    catch
        {
            Console.WriteLine($"Третьей цифры нет");
        }
    
}

ThirdNum ();
