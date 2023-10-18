//using System;

//class Task_1
//{
//    static void Main()
//    {
//        Console.Write("Введiть розмiр масиву N: ");
//        int N = int.Parse(Console.ReadLine());

//        double[] array = new double[N];

//        
//        for (int i = 0; i < N; i++)
//        {
//            Console.Write($"Введiть {i + 1}-й елемент масиву: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//       
//        Console.Write("Введiть кiлькiсть елементiв для перестановки M: ");
//        int M = int.Parse(Console.ReadLine());

//        
//        double sumOfOddElements = 0;
//        for (int i = 0; i < N; i++)
//        {
//            if (i % 2 != 0)
//            {
//                sumOfOddElements += array[i];
//            }
//        }

//        
//        int firstNegativeIndex = -1;
//        int lastNegativeIndex = -1;

//        for (int i = 0; i < N; i++)
//        {
//            if (array[i] < 0)
//            {
//                if (firstNegativeIndex == -1)
//                {
//                    firstNegativeIndex = i;
//                }
//                lastNegativeIndex = i;
//            }
//        }

//        
//        double sumBetweenNegatives = 0;
//        if (firstNegativeIndex != -1 && lastNegativeIndex != -1)
//        {
//            for (int i = firstNegativeIndex + 1; i < lastNegativeIndex; i++)
//            {
//                sumBetweenNegatives += array[i];
//            }
//        }

//        
//        if (M > 0 && M < N)
//        {
//            double[] tempArray = new double[M];
//            Array.Copy(array, 0, tempArray, 0, M);
//            Array.Copy(array, M, array, 0, N - M);
//            Array.Copy(tempArray, 0, array, N - M, M);
//        }

//        
//        Console.WriteLine("Сума непарних елементiв: " + sumOfOddElements);
//        Console.WriteLine("Сума елементiв мiж першим i останнiм вiд'ємними: " + sumBetweenNegatives);

//        Console.WriteLine("Масив пiсля перестановки перших M елементiв:");
//        for (int i = 0; i < N; i++)
//        {
//            Console.Write(array[i] + " ");
//        }

//        Console.ReadLine();
//    }
//}





//using System;

//class Task_3
//{
//    static void Main()
//    {
//        Console.WriteLine("Введiть текстовий рядок:");
//        string inputText = Console.ReadLine();

//       
//        int wordCount = CountWords(inputText);
//        Console.WriteLine("Кiлькiсть слiв у текстi: " + wordCount);

//        
//        string wordWithMostVowels = FindWordWithMostVowels(inputText);
//        Console.WriteLine($"Слово з найбiльшою кiлькiстю голосних лiтер: {wordWithMostVowels}");

//      
//        string cleanedText = RemoveExtraSpaces(inputText);
//        Console.WriteLine("Текст без непотрiбних пробiлiв: " + cleanedText);
//    }

//    
//    static int CountWords(string text)
//    {
//        string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
//        return words.Length;
//    }

//    
//    static string FindWordWithMostVowels(string text)
//    {
//        string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
//        string wordWithMostVowels = "";
//        int maxVowelCount = 0;

//        foreach (string word in words)
//        {
//            int vowelCount = CountVowels(word);
//            if (vowelCount > maxVowelCount)
//            {
//                maxVowelCount = vowelCount;
//                wordWithMostVowels = word;
//            }
//        }

//        return wordWithMostVowels;
//    }

//    
//    static int CountVowels(string word)
//    {
//        char[] vowels = { 'а', 'е', 'и', 'о', 'у', 'я', 'ю', 'є', 'і', 'ї' };
//        int count = 0;

//        foreach (char letter in word.ToLower())
//        {
//            if (Array.IndexOf(vowels, letter) != -1)
//            {
//                count++;
//            }
//        }

//        return count;
//    }

//    
//    static string RemoveExtraSpaces(string text)
//    {
//        return string.Join(" ", text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
//    }
//}



using System;

class Apartment
{
    public string TenantName { get; set; }
    public int NumberOfResidents { get; set; }
    public double GasMeterReading { get; set; }
    public double GasRatePerCubicMeter { get; set; }

    public Apartment(string tenantName, int numberOfResidents, double gasRatePerCubicMeter)
    {
        TenantName = tenantName;
        NumberOfResidents = numberOfResidents;
        GasRatePerCubicMeter = gasRatePerCubicMeter;
    }

    public double CalculateGasPayment()
    {
        if (GasMeterReading > 0)
        {
            
            return GasMeterReading * GasRatePerCubicMeter;
        }
        else
        {
            
            return NumberOfResidents * 30; 
        }
    }

    public void PerformGasStoveMaintenance()
    {
        
        Console.WriteLine("Огляд та ремонт газової плити для квартири орендаря " + TenantName);
        
        Console.WriteLine("Роботи зi змiни деталей i обслуговування газової плити.");
        Console.WriteLine("Роботи завершено.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Apartment apartment1 = new Apartment("Тарабанович Iван", 2, 1.5);

        apartment1.GasMeterReading = 50;

        double gasPayment = apartment1.CalculateGasPayment();
        Console.WriteLine($"Плата за газ для квартири орендаря {apartment1.TenantName}: {gasPayment} грн");

       
        apartment1.PerformGasStoveMaintenance();

        
        Console.ReadLine();
    }
}

