using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public string[] itemArray = { "Heart", "Sword", "Shield", "Potion", "Armor" };

    // Insert item at the back of the array
    private void InsertItemAtBack(string s)
    {
        // Create a new array with room for an extra item
        string[] newItemArray = new string[itemArray.Length + 1];

        // Copy the items from the "old" array to the new array
        for (int i = 0; i < itemArray.Length; i++)
        {
            newItemArray[i] = itemArray[i];
        }

        // Set the new item in the last spot of the array
        newItemArray[newItemArray.Length - 1] = s;

        // Set the new array as the current itemArray
        itemArray = newItemArray;
    }

    // Insert item at the front of the array
    private void InsertItemInFront(string s)
    {
        // TODO
    }

    // Insert item on a specific index
    // print error if index is out of bound
    private void InsertItemOnIndex(string s, int index)
    {
        // TODO
    }

    // Delete item at a specific index
    private void DeleteItem(int index)
    {
        // TODO
    }

    // Search item that is equal to "s", and return its index
    // return -1 if the item was not found
    private int FindItem(string s)
    {
        // TODO
        return -1;
    }

    private void PrintArray(string[] array)
    {
        Debug.Log(string.Join(",", array));
    }

    void TestItemArray()
    {
        PrintArray(itemArray);

        // Test 1
        Debug.Log("InsertItemAtBack(\"Egg\");");
        InsertItemAtBack("Egg");
        PrintArray(itemArray);

        // Test 2
        Debug.Log("InsertItemInFront(\"Cup\");");
        InsertItemInFront("Cup");
        PrintArray(itemArray);

        // Test 3
        Debug.Log("InsertItemOnIndex(\"Arrow\", 2);");
        InsertItemOnIndex("Arrow", 2);
        PrintArray(itemArray);

        // Test 4
        Debug.Log("DeleteItem(1);");
        DeleteItem(1);
        PrintArray(itemArray);

        // Test 5
        Debug.Log("FindItem(\"Potion\");");
        int index = FindItem("Potion");
        Debug.Log("Found Index: " + index);

        // Test 6
        Debug.Log("FindItem(\"Bow\");");
        index = FindItem("Bow");
        Debug.Log("Found Index: " + index);
    }

    // Start is called before the first frame update
    void Start()
    {
        TestItemArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
