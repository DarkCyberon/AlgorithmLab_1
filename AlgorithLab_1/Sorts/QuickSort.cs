using AlgorithLab_1;
using System.Diagnostics;

namespace AlgorythmLab1;

public class QuickSort : ISortable
{
    public void Sort(int[] arr)
    {
        int[] answ = SortArray(arr, 0, arr.Length-1);
    }
    
    private static int[] SortArray(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
        
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
    
        if (leftIndex < j)
            SortArray(array, leftIndex, j);
        if (i < rightIndex)
            SortArray(array, i, rightIndex);
        return array;
    }
    public static long Timer(int variableCount)
    {
        int[] randomArray = Program.RandomArray(variableCount);
        Stopwatch timer = new();

        timer.Start();
        new QuickSort().Sort(randomArray);
        timer.Stop();

        return timer.ElapsedMilliseconds;
    }
}