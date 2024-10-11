void Main()
{
    // Задаём массив
    string[] array = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
    foreach(string i in array)
        System.Console.Write(i + ", ");
    System.Console.WriteLine();
    int number = GenerateNumber(0, 4);
    int lengthArray = array.Length;
    NewArray(array, number, lengthArray);
}

// метод генерации числа
int GenerateNumber(int firstVal = 0, int secondVal = 4)
{
    Random rnd = new Random();
    int number = rnd.Next(firstVal, secondVal);
    return number;
}

// метод вывода рандомных элементов из массива в количестве сгенерированного числа
void NewArray(string[] array, int number, int lengthArr)
{
    Random rnd = new Random();
    System.Console.Write("[");
    for (int count = 0; count < number; count++)
    {
        string element = array[rnd.Next(0, lengthArr)];
        Console.Write(element + ", ");
    }
    System.Console.Write("]");
}

Main();

