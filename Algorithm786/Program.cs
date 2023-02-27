using MySelectionSort;
using Algorithm786.Tests;
using Algorithm786.LessonTopicsAlgorithm;
using MergeSortN;
using Algorithm786;



//RemoveElementMethod();
//Palindrome();
//CheckNForDoubleExist();
//HasCycleLinkedList();
MySelectionSort();

try
{
    //StackHeap();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Korot chatogh:)");
}


void StackHeap()
{
    StackImplimantWithHeap stackImplimantWithHeap = new StackImplimantWithHeap();
    stackImplimantWithHeap.Push(10);
    stackImplimantWithHeap.Push(5);
    stackImplimantWithHeap.Push(8);
    stackImplimantWithHeap.Push(2);
    stackImplimantWithHeap.Push(3);
    stackImplimantWithHeap.Push(4);
    stackImplimantWithHeap.Push(9);
    stackImplimantWithHeap.Push(7);
    stackImplimantWithHeap.Push(12);

    
    var result = stackImplimantWithHeap.Pop();
    var result1 = stackImplimantWithHeap.Pop();
    var result2 = stackImplimantWithHeap.Pop();
    //var result3 = stackImplimantWithHeap.Pop();
    //var result4 = stackImplimantWithHeap.Pop();
    //var result5 = stackImplimantWithHeap.Pop();
    //var result6 = stackImplimantWithHeap.Pop();
    //var result7 = stackImplimantWithHeap.Pop();
    //var result8 = stackImplimantWithHeap.Pop();


    //Console.WriteLine(result.Value);
    //Console.WriteLine(result1.Value);
    //Console.WriteLine(result2.Value);
    //Console.WriteLine(result3.Value);
    //Console.WriteLine(result4.Value);

    var prelist = stackImplimantWithHeap.PreOrder();
    foreach (var item in prelist)
    {
        Console.Write(item + ", ");
    }
    Console.ReadLine();
}

void MySelectionSort()
{
    int[] ints = new int[9] { 15, 10, 22, 13, 5, 16, 8, 26, 17 };
    

    MergeSort mergeSort = new MergeSort();
    mergeSort.MergeSorting(ints);
    foreach (var item in ints)
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine();


    //SelectionSort selectionSort = new SelectionSort();
    //selectionSort.SelectSort(ints: ints);
    //foreach (var item in ints)
    //{
    //    Console.Write(item + ", ");
    //}
    //Console.WriteLine();
    //
    //TwoPointers twoPointers = new TwoPointers();
    //var result = twoPointers.TwoPointer(ints, 15);
    //
    //Console.WriteLine(result);
    //
    //LeanerSearch leanerSearch = new LeanerSearch();
    //Console.WriteLine(leanerSearch.LeanerSearching(ints, 15));
    //
    //BinarySearch binarySearch = new BinarySearch();
    //Console.WriteLine(binarySearch.BinarySearching(ints, 8));


}











void HasCycleLinkedList()
{
    HasCycleLinkedList ff = new HasCycleLinkedList();
    ListNode list = new ListNode();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add(4);

    var get2 = list.GetNode(2);
    list.AddCycle(get2, 5);
    var rr = ff.HasCycle(list.Head);
    Console.WriteLine(rr);



}


void CheckNForDoubleExist()
{
    CheckNForDoubleExist llll = new CheckNForDoubleExist();
    var array = new int[4] { 10, 2, 5, 3 };
    var arrayFalse = new int[4] { 3, 1, 7, 11 };
    var rr = llll.CheckForDouble(array);
    Console.WriteLine(rr);
    var rrr = llll.CheckForDouble(arrayFalse);
    Console.WriteLine(rrr);

}
void Palindrome()
{
    IsPalindrome isPalindrome = new IsPalindrome();
    var bb = isPalindrome.Palindrome("pepep pepep");
    Console.WriteLine(bb);
    var ab = isPalindrome.PalindromeAB("ababa");
    Console.WriteLine(ab);
    var abb = isPalindrome.PalindromeAB("abb");
    Console.WriteLine(abb);


}


void RemoveElementMethod()
{
    int[] ints = new int[5] { 5, 7, 9, 5, 4 };


    RemoveElementTest<int> removeElementTest = new RemoveElementTest<int>();

    var (newArray, count) = removeElementTest.Method(array: ints, 5);

    Console.WriteLine($"Count - {count}");
    Console.WriteLine(new string('-', 10));

    foreach (int i in newArray)
        Console.WriteLine(i);
}


