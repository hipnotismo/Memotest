using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameObject card1;
    public static GameObject card2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void add(GameObject card)
    {
        if (card1 == null)
        {
            card1 = card;
        }

        if (card2 == null)
        {
            card2 = card;
        }
    }

    void compare()
    {
        //for (int i = 0; i < values.Length; i++)
        //{

        //}
    }
}
