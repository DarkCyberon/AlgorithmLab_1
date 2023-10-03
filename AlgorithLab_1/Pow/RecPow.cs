namespace AlgorithLab_1.Pow;

public class RecPow : IPowable
{
    public int resultPow { get; private set; }

    public void Pow(int num, int degree)
    {
        if (degree == 0)
        {
            resultPow = 1;
        }
        else
        {
            RecPow pow = new RecPow();
            pow.Pow(num, degree / 2);
            int result = pow.resultPow;

            if (degree % 2 == 1)
            {
                result = result * result * num;
            }
            else
            {
                result *= result;
            }

            resultPow = result;
        }
    }
}