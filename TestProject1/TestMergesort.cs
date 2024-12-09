using ConsoleApp1;
using Xunit;
using Assert = Xunit.Assert;

namespace TestProject1;

public static class TestMergesort
{
    [Fact]
    public static void TestSortedArray()
    {
        // Arrange
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestReverseSortedArray()
    {
        // Arrange
        int[] arr = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        int[] sorted = arr.OrderBy(x => x).ToArray();

        // Act
        var mergesortArray = Sort.Mergesort(arr);

        // Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestArrayWithDuplicates()
    {
        // Arrange
        int[] arr = [5, 1, 3, 3, 2, 2, 5, 1, 1, 3];
        int[] sorted = arr.OrderBy(x => x).ToArray();

        // Act
        var mergesortArray = Sort.Mergesort(arr);

        // Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestEmptyArray()
    {
        // Arrange
        int[] arr = [];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestSmall1()
    {
        // Arrange
        int[] arr = [1];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestSmall2()
    {
        // Arrange
        int[] arr = [2, 1];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestSmall3()
    {
        // Arrange
        int[] arr = [1, -1];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestEdgeCase()
    {
        // Arrange
        int[] arr = [ int.MaxValue ,0 , int.MinValue, -1, 1 ];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestMedium1()
    {
        // Arrange
        int[] arr = [73, 57, 49, 99, 133, 20, 1];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestMedium2()
    {
        // Arrange
        int[] arr = [-73, 57, 49, -99, 133, 20, -1];
        int[] sorted = arr.OrderBy(x => x).ToArray();
        
        //Act
        var mergesortArray = Sort.Mergesort(arr);

        //Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestLarge()
    {
        // Arrange
        int[] arr = Enumerable.Range(-100000, 200000).OrderByDescending(x => x).ToArray();
        int[] sorted = arr.OrderBy(x => x).ToArray();

        // Act
        var mergesortArray = Sort.Mergesort(arr);

        // Assert
        Assert.Equal(sorted, mergesortArray);
    }
    
    [Fact]
    public static void TestRandom()
    {
        // Arrange
        Random random = new Random();
        int[] arr = Enumerable.Range(0, 1000).Select(_ => random.Next(-10000, 10000)).ToArray();
        int[] sorted = arr.OrderBy(x => x).ToArray();

        // Act
        var mergesortArray = Sort.Mergesort(arr);

        // Assert
        Assert.Equal(sorted, mergesortArray);
    }
}