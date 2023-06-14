using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int MyInt = 5;

    void Start()
    {
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log (MyInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
