using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmove : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control the speed

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collider"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            // Calculate the movement vector in the negative Z direction
            Vector3 movement = -transform.forward * speed * Time.deltaTime;

            // Apply the movement to the object's position
            rb.MovePosition(rb.position + movement);
        }
    }
}
