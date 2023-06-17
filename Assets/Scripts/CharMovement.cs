using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    private bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                isMoving = true;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isMoving = false;
            }
        }

        if (isMoving)
        {
            float translation = moveSpeed * Time.deltaTime;
            transform.Translate(Vector3.right * translation);
        }
    }
}
