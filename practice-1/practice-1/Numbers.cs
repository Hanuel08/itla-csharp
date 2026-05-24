namespace practice_1;

public class Numbers
{
    public static void Even(int from = 1, int to = 100)
    {
        for (int i = from; i <= to; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    public static void Odd(int from = 1, int to = 100)
    {
        for (int i = from; i <= to; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static List<int> PrimeNumbers(int from = 1, int to = 30)
    {
        List<int> primaryPrimeNumbers = new List<int> {2, 3, 5, 7, 11, 13, 17, 19};
        List<int> primeNumbers = new List<int> { };

        int number;
        int divisor;
        bool isPrime;
        
        for (int i = from; i <= to; i++)
        {
            isPrime = true;
            number = i;
            if (number <= 1) continue;
            for (int j = 0; j < primaryPrimeNumbers.Count; j++)
            {
                if (primeNumbers.Contains(number)) break;
                divisor =  primaryPrimeNumbers[j];
                if (number == divisor) continue;
                if (number % divisor == 0) isPrime = false;
                if (!isPrime) break;
            }
            if (isPrime) primeNumbers.Add(number);
        }

        for (int i = 0; i < primeNumbers.Count; i++)
        {
            Console.WriteLine(primeNumbers[i]);
        }
        return primeNumbers;
    }

    private static List<int> GetDivisors(int number)
    {
        List<int> divisors = new List<int> {};
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) divisors.Add(i);
        }
        return divisors;
    }

    private static int SumDivisors(int number)
    {
        int count = 0;
        List<int> divisors = GetDivisors(number);
        
        for (int i = 0; i < divisors.Count; i++)
        {
            count += divisors[i];
        }
        return count;
    }

    public static List<int> PerfectNumbers(int to = 5)
    {
        List<int> perfectNumbers = new List<int> {};
        int index = 2;
        while (true)
        {
            if (perfectNumbers.Count == to) break;
            if (SumDivisors(index) == index)
            {
                perfectNumbers.Add(index);
                Console.WriteLine(index);
            }
            index += 2;
        }
        return perfectNumbers;
    }
}