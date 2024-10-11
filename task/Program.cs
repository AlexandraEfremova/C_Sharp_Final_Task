void Main()
{
    // Задаём массив
    string[] array = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
    foreach(string i in array)
        System.Console.Write(i + ", ");
    System.Console.WriteLine();
    int number = GenerateNumber(0, 4);

}

int GenerateNumber(int firstVal = 0, int secondVal = 4)
{
    Random rnd = new Random();
    int number = rnd.Next(firstVal, secondVal);
    return number;
}

Main();

