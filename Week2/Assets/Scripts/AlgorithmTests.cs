using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgorithmTests : MonoBehaviour
{
    // https://en.wikipedia.org/wiki/Bubble_sort
    // TODO: implement BubbleSort algorithm in this function 
    // and return a new list with the sorted values
    public List<int> BubbleSort(List<int> list)
    {
        // TODO: implement code to sort the integers in the list
        // ...

        return list;
    }

    public void TestAlgorithms()
    {
        // create list filled with random numbers
        List<int> randomNumbers = new List<int>();
        for (int i = 0; i < 1000; i++) {
            randomNumbers.Add(Random.Range(0, 2500));
        }

        // copy the random number list and sort it for comparison later
        List<int> sortedListOriginal = new List<int>(randomNumbers);
        sortedListOriginal.Sort();

        // execute student sort function
        List<int> sortedList = BubbleSort(randomNumbers);

        // compare original sorted list with the one from the student function
        if (sortedListOriginal.Count == sortedList.Count)
        {
            for (int i = 0; i < sortedListOriginal.Count; i++)
            {
                if (sortedListOriginal[i] != sortedList[i])
                {
                    Debug.Log("Error in sorting: The value at index " + i + " is not correct");
                    break;
                }
            }
        }
        else
        {
            Debug.Log("Error in sorting: List<int> is not the same size");
        }
    }

    void Start()
    {
        TestAlgorithms();
    }
}
