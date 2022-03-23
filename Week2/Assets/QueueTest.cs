using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    public GameObject itemPrefab = null;
    public Queue<GameObject> itemQueue = new Queue<GameObject>();
    public int numCreated = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject newItem = Instantiate(itemPrefab, transform, false);
            newItem.transform.localPosition = Random.insideUnitSphere;
            newItem.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            newItem.name = "item: " + numCreated.ToString();

            // TODO: place newItem on the queue
            // ...

            numCreated++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // TODO: if there are items in the queue
            // TODO: remove and destroy the last item from the queue
            // ...
        }
    }
}
