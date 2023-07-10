            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            List<int> Mns = new List<int>();

            for (int i = M; i <= N; i++)
            {
                int cnt = 0;

                for (int j = 1; j <= i; j++)              
                    if (i % j == 0)
                        cnt++;

                if (cnt == 2)
                    Mns.Add(i);
            }

            int sum = 0;

            for (int i = 0; i < Mns.Count; i++)
                sum += Mns[i];

            if (Mns.Count != 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine(Mns[0]);
            }
            else
                Console.WriteLine(-1);