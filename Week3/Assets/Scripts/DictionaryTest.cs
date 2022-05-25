using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
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

            numCreated++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // TODO: if there are items on the stack
            // TODO: remove and destroy the top item from the stack
            // ...
        }
    }
}
