using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public enum OperatorType
    {
        Add,
        Multiply
    };

    public OperatorType operatorType = OperatorType.Add;
    public InputField input1Field = null;
    public InputField input2Field = null;
    public Text answerField = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void updateAnswer()
    {
        float input1 = 0;
        float input2 = 0;
        float answer = 0;

        if (!float.TryParse(input1Field.text, out input1))
        {
            answerField.text = "input not valid";
            return;
        }
        if (!float.TryParse(input2Field.text, out input2))
        {
            answerField.text = "input not valid";
            return;
        }
        if (operatorType == OperatorType.Add)
        {
            answer = input1 + input2;
        }
        if (operatorType == OperatorType.Multiply)
        {
            answer = input1 * input2;
        }
        answerField.text = answer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
