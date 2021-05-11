using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rotatecube : MonoBehaviour
{
    public Vector3 EditRotate;

    void Start()
    { }
    void Update()
    {
        if(Input.GetKey("a"))
        {
            transform.Rotate(2, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(-1, 3, -1);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, 3);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, 0.01f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -0.01f);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.01f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.01f, 0, 0);
        }
    }
       

}
