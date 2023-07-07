            string ABs = Console.ReadLine();
            string[] AB = ABs.Split();

            int A = Convert.ToInt32(AB[0]);
            int B = Convert.ToInt32(AB[1]);

            List<int> aa = new List<int>();

            for (int i = A; i >=1 ; i--)
            {
                if (A % i == 0)
                    aa.Add(A / i);
            }
            if (B - 1 >= aa.Count)
                Console.WriteLine(0);
            else
                Console.WriteLine(aa[B - 1]);