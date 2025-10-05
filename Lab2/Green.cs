using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double i = 2;
            while (i <= n)
            {
                answer += i / (i + 1);
                i = i + 2;
            }
            //for (int i = 2; i <= n; i++) {
                //answer = answer + i / (i + 1);
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 1;

            // code here
            double a = 1 / x;
            for (int i = 1; i <= n; i++)
            {
                answer += a;
                a = a * (1 / x);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            // в теории все правильно, но надо добавить скорее всего +0 в начале
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                answer += fact;
                //fact *= i;
            }
            // end
            answer += 1;

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) >= 1)
                throw new ArgumentException("|x| должен быть меньше 1");
                //throw x;
            const double eps = 1.0 / 10000;
            int n = 1;
            double powerx = x;

            while (true)
            {
                double sinnx = Math.Sin(n * powerx);

                //answer += sinnx;
                if (Math.Abs(sinnx) < eps)
                {
                    break;
                }
                answer += sinnx;
                powerx *= x;
                if ( x == 0)
                {
                    answer = 0;
                    break;
                }
                //n++;
                /*if (n > 1000)
                {
                    Console.WriteLine("Вход в бесконечный цикл");
                    break;
                }*/
                n++;
                //Console.WriteLine(answer);
            }

            
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
                throw new ArgumentException("не тот дапазон");

            const double eps = 1.0 / 10000;
            int n = 1;
            //стартовое и следующее значение задать
            double prev = 1.0;        //|1/x^0|
            double current = 1.0 / Math.Abs(x); //|1/x^1|

            while (Math.Abs(current - prev) >= eps)
            {
                prev = current;
                current /= x;
                n++;
            }
            answer = n;
            //Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            for (int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
            }
            // end
            //answer += 2;
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            for (int i = 0; L >= Da; i++)
            {
                L /= 2.0;
                answer += 1;
            }
                // end

                return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            
            // end

            return (SS, SY);
        }
    }
}