using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour
{
    [SerializeField] private float reveal;
    public float number;
    private GameObject manager;
 //   [SerializeField] private Manager manager;

    void Start()
    {
        manager = GameObject.Find("Manager");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("Fuck");
        rotate();
        manager.SendMessage("add", gameObject);
       // manager.SendMessage("add", number);
        //manager.add(number);

    }

    void rotate()
    {
        transform.Rotate(new Vector3(0, 0, reveal));

    }

    void reverse()
    {
        transform.Rotate(new Vector3(0, 0, -reveal));

    }

    void deactivate()
    {

    }
}
