using SingleNumberProblem;

namespace SingleNumberProblemUnitTest;

public class BadSolutionUnitTest
{
    [Fact]
    public void SingleNumber_SmallArray_SingleNumber()
    {
        int[] array = { 1, 3, 2, 7, 3, 4, 7, 1, 4 };
        int expected = 2;
        int actual = BadSolution.SingleNumber(array);

        Assert.Equal<int>(expected, actual);
    }
    
}