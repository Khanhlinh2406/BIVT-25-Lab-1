namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            bool answer = d > 0;
            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            bool answee = n % 2 == 0;
            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a>b)
            {answer = a;}
            if (a<b)
            {  answer = b; }
            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (d < 0) d = -d;
            if (f < 0) f = -f;
            if (d < f) { answer = d; }
            if (d > f) { answer = f; }
            
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > 1) answer = 1;
            if (x < -1) answer = 1;
            if (-1 < x < 1) answer = 0;
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            double xyr = x * x + y * y - r * r;
            bool answer = xyr <= 0.0001;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
            int s = n * n;
            if (s - n > 2 * n)
            {
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            bool answer = (L < 30 && T + M >= 5 && M % 2 == 0);
            // end

            return answer;
        }
    }
}
