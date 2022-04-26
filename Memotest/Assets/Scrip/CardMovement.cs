using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour
{
    [SerializeField] private float reveal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("Fuck");
        transform.Rotate(new Vector3(0, 0, reveal) /** Time.deltaTime*/);
    }
}
