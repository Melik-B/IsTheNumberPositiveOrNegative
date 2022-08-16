//Is The Number Positive Or Negative

//ALGORITHM

//1.1 Start.
//1.2 User can login again and again until they press the letter 'q', when they press the letter 'q' they exit the application.
//1.3 The user is prompted to enter a number.
//1.4 Calculate whether the number is negative or positive.
//1.5 If the number is positive, it will print positive to the screen.
//1.6 If the number is negative, it will print negative to the screen.
//1.7 If the number is neutral, it will print neutral to the screen.


//Sayı pozitif mi Negatif Mi

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
//1.3 Kullanıcıdan bir sayı girmesi istenir.
//1.4 Sayının negatif mi pozitif mi olduğu hesaplanır.
//1.5 Sayı pozitifse, ekrana pozitif yazdırılır.
//1.6 Sayı negatifse, ekrana negatif yazdırılır.
//1.7 Sayı nötr, ekrana nötr yazdırılır.



Console.Write("Enter a number (quit: q): ");
string login = Console.ReadLine();

while (login != "q")
{
    int number = Convert.ToInt32(login);

    if (number > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Number positive.");
        Console.ResetColor();
    }
    else if (number < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Number negative.");
        Console.ResetColor();
    }
    else
        Console.WriteLine("neutral.");

    Console.Write("\nEnter a number (quit: q): ");
    login = Console.ReadLine();
    number = Convert.ToInt32(login);
}