using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorTarget : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    public Detector detector = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0.0f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.0f, -rotationSpeed * Time.deltaTime, 0.0f, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            detector.RotateTowards(transform.rotation);
        }
    }
}
