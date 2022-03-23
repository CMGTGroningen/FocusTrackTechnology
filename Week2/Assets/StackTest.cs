using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
    public GameObject stackItemPrefab = null;
    public Stack<GameObject> myStack = new Stack<GameObject>();
    public int numCreated = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject newItem = Instantiate(stackItemPrefab, transform, false);
            newItem.transform.localPosition = Random.insideUnitSphere;
            newItem.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            newItem.name = "item: " + numCreated.ToString();

            // TODO: place newItem on the stack
            // ...
            myStack.Push(newItem);

            numCreated++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // TODO: if there are items on the stack
            // TODO: remove and destroy the top item from the stack
            // ...
            Destroy(myStack.Pop());
        }
    }
}
