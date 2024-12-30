class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        double[] array = new double[8];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * (10 - (-10)) + (-10);
        }

        double sumOfNegatives = 0;
        double minElement = array[0];
        int maxElementIndex = 0;
        double maxElementByMagnitude = Math.Abs(array[0]);
        double maxElement = array[0];
        int sumOfPositiveIndices = 0;
        int integerCount = 0;

        for (int i = 0; i < array.Length; i++)
        {

            Console.Write(array[i] + " ");

            if (array[i] < 0)
            {
                sumOfNegatives += array[i];
            }

            if (array[i] < minElement)
            {
                minElement = array[i];
            }

            if (Math.Abs(array[i]) > Math.Abs(maxElementByMagnitude))
            {
                maxElementByMagnitude = array[i];
            }

            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxElementIndex = i;
            }

            if (array[i] > 0)
            {
                sumOfPositiveIndices += i;
            }

            if (array[i] % 1 == 0)
            {
                integerCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Сума від'ємних елементів: {sumOfNegatives}");
        Console.WriteLine($"Мінімальний елемент: {minElement}");
        Console.WriteLine($"Номер максимального елемента: {maxElementIndex}");
        Console.WriteLine($"Максимальний за модулем елемент: {maxElementByMagnitude}");
        Console.WriteLine($"Сума індексів додатних елементів: {sumOfPositiveIndices}");
        Console.WriteLine($"Кількість цілих чисел: {integerCount}");
    }
}
