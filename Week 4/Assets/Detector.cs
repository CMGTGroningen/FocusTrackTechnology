using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    private Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RotateTowards(Quaternion target)
    {
        targetRotation = target;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.02f);
    }
}
