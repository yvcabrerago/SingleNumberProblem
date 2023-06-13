namespace SingleNumberProblem;
public static class GoodSolution
{
    public static int SingleNumber(int[] nums)
    {
        int number = 0;
        foreach (int i in nums)
        {
            number ^= i;
        }
        return number;
    }
}
