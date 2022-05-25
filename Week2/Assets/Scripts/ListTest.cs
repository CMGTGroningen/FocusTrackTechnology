using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<string> itemList = new List<string>() { "Heart", "Sword", "Shield", "Potion", "Armor" };
    public Stack<string> itemStack = new Stack<string>();
    public Queue<string> itemQueue = new Queue<string>();

    private void PrintList(List<string> list)
    {
        Debug.Log(string.Join(",", list.ToArray()));
    }

    void TestItemArray()
    {
        PrintList(itemList);

        // Test 1
        Debug.Log("InsertItemAtBack(\"Egg\");");
        itemList.Add("Egg");
        PrintList(itemList);

        // Test 2
        Debug.Log("InsertItemInFront(\"Cup\");");
        itemList.Insert(0, "Cup");
        PrintList(itemList);

        // Test 3
        Debug.Log("InsertItemOnIndex(\"Arrow\", 2);");
        itemList.Insert(2, "Arrow");
        PrintList(itemList);

        // Test 4
        Debug.Log("DeleteItem(1);");
        itemList.RemoveAt(1);
        PrintList(itemList);

        // Test 5
        Debug.Log("FindItem(\"Potion\");");
        int index = itemList.FindIndex(i => i == "Potion");
        Debug.Log("Found Index: " + index);

        // Test 6
        Debug.Log("FindItem(\"Bow\");");
        index = itemList.FindIndex(i => i == "Bow");
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
