using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private float[] values;
    private int pos;
    private float one;
    private float two;
    
    void Start()
    {
        values = new float[2];
        pos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pos >= 2)
        {
            Debug.Log("Merde");
            
            pos = 0;
            compare();
        }
    }

    public void add(float a)
    {
        values[pos] = a;
        pos++;
    }

    void compare()
    {
        //for (int i = 0; i < values.Length; i++)
        //{

        //}
    }
}
