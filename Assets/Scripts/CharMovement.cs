using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    public float laneDistance = 4;
    private int desiredLane = 1;


    public GameObject Player;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        direction.z = forwardSpeed;
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);
    
    
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x > startTouchPosition.x)
            {
                desiredLane++;
                if (desiredLane == 3)
                    desiredLane = 2;
            }
            if (endTouchPosition.x < startTouchPosition.x)
            {
                desiredLane--;
                if (desiredLane == -1)
                    desiredLane = 0;
            }

            Vector3 targetPosition = transform.position;


            if (desiredLane == 0)
            {
                targetPosition += Vector3.left * laneDistance;
            }
            else if (desiredLane == 2)
            {
                targetPosition += Vector3.right * laneDistance;
            }
        }   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obs") || collision.gameObject.CompareTag("collider"))
        {
            // Destroy the player object
            Destroy(gameObject);
        }
    }
}
