using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    private Quaternion endRotation;
    private Quaternion startRotation;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RotateTowards(Quaternion target)
    {
        startRotation = transform.rotation;
        endRotation = target;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {      
        time += Time.deltaTime;
    }
}
