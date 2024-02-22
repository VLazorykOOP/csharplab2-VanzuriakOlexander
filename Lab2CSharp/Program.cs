static int[] Input()
{
    Console.WriteLine("Enter array length ");
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];
    for (int i = 0; i < n; ++i)
    {
        Console.Write("a[{0}]= ", i);
        a[i] = int.Parse(Console.ReadLine());
    }
    return a;
}

static int[][] Input2()
{
    Console.WriteLine("Enter array length ");
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int[][] a = new int[n][];
    for (int i = 0; i < n; ++i)
    {
        a[i] = new int[n];
        for (int j = 0; j < n; ++j)
        {
            Console.Write("a[{0},{1}]= ", i, j);
            a[i][j] = int.Parse(Console.ReadLine());
        }
    }
    return a;
}

static void Print1(int[] a)
{
    for (int i = 0; i < a.Length; ++i)
    {
        Console.Write("{0,1} ", a[i]);
    }
    Console.WriteLine("");
}


static void Print2(int[][] a)
{
    for (int i = 0; i < a.Length; ++i, Console.WriteLine())
        for (int j = 0; j < a[i].Length; ++j)
            Console.Write("{0,1} ", a[i][j]);
}

static void task1()
{
    Console.WriteLine("Task1");

    Console.WriteLine("Enter the a variable");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the b variable");
    int b = int.Parse(Console.ReadLine());

    int[] first = Input();

    Print1(first);

    for (int i = 0; i < first.Length; ++i)
    {
        if (first[i] > a && first[i] < b)
        {
            first[i] = 0;
        }
    }

    Console.WriteLine("After");

    Print1(first);

    int[][] second = Input2();

    Print2(second);

    for (int i = 0; i < second.Length; ++i)
    {
        for (int j = 0; j < second.Length; ++j)
        {
            if (second[i][j] > a && second[i][j] < b)
            {
                second[i][j] = 0;
            }
        }
    }

    Console.WriteLine("After");

    Print2(second);

}

static void task2()
{
    Console.WriteLine("Task2");

    int[] array = Input();

    Print1(array);

    int max = array.Max();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == max)
        {
            array[i] = 0;
        }
    }

    Console.WriteLine("After");
    Print1(array);
}

static void task3()
{
    Console.WriteLine("Task3");

    int[][] array = Input2();

    Print2(array);

    int sum = 0;

    for (int i = 0; i < array.Length; ++i)
    {
        sum += array[i][array.Length - i - 1];
    }

    Console.WriteLine("The sum {0}", sum);
}

static void task4()
{
    Console.WriteLine("Task4");
    Console.WriteLine("Enter array length ");
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    int[][] a = new int[n][];

    for (int i = 0; i < n; i++)
    {   
        Console.WriteLine("Enter m");
        int m = int.Parse(Console.ReadLine());
        a[i] = new int[m];
        for (int j = 0; j < m; ++j)
        {
            Console.Write("a[{0},{1}]= ", i, j);
            a[i][j] = int.Parse(Console.ReadLine());
        }
    }

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < a[i].Length; j++)
        {
            Console.Write("{0,1} ", a[i][j]);
        }
    }

    int[] result = new int[n];
    Console.WriteLine("");
    for (int i = 0; i < n; i++)
    {   

        for (int j = 0; j < a[i].Length; j++)
        {   
            if (a[i][j] > 0) {
                result[i] += 1;
            }
        }
    }
    Console.WriteLine("Result");
    Print1(result);
}

// task1();
// task2();
// task3();
task4();