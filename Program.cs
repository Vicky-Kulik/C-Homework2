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
