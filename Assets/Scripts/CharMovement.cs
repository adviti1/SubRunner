using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -5, 0);
        }

        if (Input.GetKey("left"))
        {
            if (Input.GetKeyUp("left"))
            {
                transform.Rotate(0, 10, 0);
            }
        }
        if (Input.GetKey("right"))
        {
            if (Input.GetKeyUp("right"))
            {
                transform.Rotate(0, -10, 0);
            }
        }
    }
}