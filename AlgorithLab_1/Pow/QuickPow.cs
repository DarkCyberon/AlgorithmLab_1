namespace AlgorithLab_1.Pow;

public class QuickPow : IPowable
{
    public int resultPow { get; private set; }
    
    public void Pow(int num, int degree)
    {
        int c = num;
        int k = degree;
        int result;

        if (k % 2 == 1)
        {
            result = c;
        }
        else
        {
            result = 1;
        }

        do
        {
            k /= 2;
            c *= c;

            if (k % 2 == 1)
            {
                result *= c;
            }

        }
        while (k != 0);

        resultPow = result;
    }
}