namespace AlgorithLab_1.Pow;

public class ObviousPow : IPowable
{
    public int resultPow { get; private set; }

    public void Pow(int num, int degree)
    {
        int result = 1;
        int k = 0;

        while (k < degree)
        {
            result *= num;
            k++;
        }

        resultPow = result;
    }
}