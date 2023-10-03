namespace AlgorithLab_1.Pow;

public class ClassicQuickPow : IPowable
{
    public int resultPow { get; private set; }

    public void Pow(int num, int degree)
    {
        int c = num;
        int result = 1;
        int k = degree;

        while (k != 0)
        {
            if (k % 2 == 0)
            {
                c *= c;
                k /= 2;
            }
            else
            {
                result *= c;
                k--;
            }
        }

        resultPow = result;
    }
}