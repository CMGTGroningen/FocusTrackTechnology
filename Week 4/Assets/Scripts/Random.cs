using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Output 10 random numbers");
        UnityEngine.Random.InitState(1000);
        for (int i = 0; i < 10; i++)
        {
            int rnd = UnityEngine.Random.Range(0, 100);
            Debug.Log(rnd);
        }
        Debug.Log("Lets try again");
        UnityEngine.Random.InitState(1000);
        for (int i = 0; i < 10; i++)
        {
            int rnd = UnityEngine.Random.Range(0, 100);
            Debug.Log(rnd);
        }
        Debug.Log("Now with a different seed");
        UnityEngine.Random.InitState(2000);
        for (int i = 0; i < 10; i++)
        {
            int rnd = UnityEngine.Random.Range(0, 100);
            Debug.Log(rnd);
        }

        float chance = 0.8f;
        float random = UnityEngine.Random.value;
        if (random < chance)
        {
            Debug.Log("Event happens");
        }
        else
        {
            Debug.Log("Event does not happen");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
