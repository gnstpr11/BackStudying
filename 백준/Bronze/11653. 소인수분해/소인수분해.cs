            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 2;; i++)
            {
                while (true)
                {
                    if (N % i == 0)
                    {
                        Console.WriteLine(i);
                        N = N / i;
                    }
                    else
                        break;
                }
                if (N == 1)
                    break;
            }