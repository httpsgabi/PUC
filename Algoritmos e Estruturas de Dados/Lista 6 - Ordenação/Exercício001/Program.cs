using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] sizes = { 1000, 500000 };
        Random rand = new Random();

        foreach (var size in sizes)
        {
            Console.WriteLine($"Teste com vetor de tamanho {size}");
            TestSortingAlgorithms(size, rand);
        }
    }

    static void TestSortingAlgorithms(int size, Random rand)
    {
        int[] ascendingInt = Enumerable.Range(1, size).ToArray();
        int[] descendingInt = ascendingInt.Reverse().ToArray();
        int[] randomInt = GenerateRandomArray(size, rand);

        decimal[] ascendingDecimal = ascendingInt.Select(x => (decimal)x).ToArray();
        decimal[] descendingDecimal = descendingInt.Select(x => (decimal)x).ToArray();
        decimal[] randomDecimal = randomInt.Select(x => (decimal)x).ToArray();

    }

    static int[] GenerateRandomArray(int size, Random rand)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(int.MinValue, int.MaxValue);
        }
        return array;
    }

    static void TestSortingAlgorithm(string name, Action<int[]> sort, int[] ascending, int[] descending, int[] random)
    {

        Console.WriteLine($"Teste {name} (int) - Crescente");
        TestAlgorithm(sort, ascending);

        Console.WriteLine($"Teste {name} (int) - Decrescente");
        TestAlgorithm(sort, descending);

        Console.WriteLine($"Teste {name} (int) - Aleatório");
        TestAlgorithm(sort, random);
    }

    static void TestSortingAlgorithm(string name, Action<decimal[]> sort, decimal[] ascending, decimal[] descending, decimal[] random)
    {

        Console.WriteLine($"Teste {name} (decimal) - Crescente");
        TestAlgorithm(sort, ascending);

        Console.WriteLine($"Teste {name} (decimal) - Decrescente");
        TestAlgorithm(sort, descending);

        Console.WriteLine($"Teste {name} (decimal) - Aleatório");
        TestAlgorithm(sort, random);
    }

    static void TestAlgorithm(Action<int[]> sort, int[] array)
    {
        var stopwatch = Stopwatch.StartNew();
        int comparisons = 0, movements = 0;
        sort(array);
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        Console.WriteLine($"Tempo: {elapsedTime}, Comparações: {comparisons}, Movimentações: {movements}");
    }

    static void TestAlgorithm(Action<decimal[]> sort, decimal[] array)
    {
        var stopwatch = Stopwatch.StartNew();
        int comparisons = 0, movements = 0;
        sort(array);
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        Console.WriteLine($"Tempo: {elapsedTime}, Comparações: {comparisons}, Movimentações: {movements}");
    }



    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        int comparisons = 0, movements = 0;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                comparisons++;
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
            }
            if (minIdx != i)
            {
                (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
                movements += 3;
            }
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        int comparisons = 0, movements = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                comparisons++;
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    movements += 3;
                }
            }
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        int comparisons = 0, movements = 0;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            comparisons++;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                movements++;
                j--;
            }
            arr[j + 1] = key;
            movements++;
        }
    }

    static void QuickSortInt(int[] arr)
    {
        QuickSortIntHelper(arr, 0, arr.Length - 1);
    }

    static void QuickSortIntHelper(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSortIntHelper(arr, low, pi - 1);
            QuickSortIntHelper(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    static void MergeSortInt(int[] arr)
    {
        MergeSortIntHelper(arr, 0, arr.Length - 1);
    }

    static void MergeSortIntHelper(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortIntHelper(arr, left, mid);
            MergeSortIntHelper(arr, mid + 1, right);
            MergeInt(arr, left, mid, right);
        }
    }

    static void MergeInt(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void HeapSortInt(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest])
            largest = left;
        if (right < n && arr[right] > arr[largest])
            largest = right;
        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }

    static void CountingSortInt(int[] arr)
    {
        int max = arr.Max();
        int[] count = new int[max + 1];
        foreach (var num in arr)
        {
            count[num]++;
        }
        int idx = 0;
        for (int i = 0; i <= max; i++)
        {
            while (count[i] > 0)
            {
                arr[idx++] = i;
                count[i]--;
            }
        }
    }

    // Os algoritmos de ordenação para decimal podem ser implementados de forma semelhante
    // a partir dos exemplos acima para int, substituindo o tipo de dados para decimal.
}
