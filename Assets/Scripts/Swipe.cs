using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject Player;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x < startTouchPosition.x)
            {
                Left();
            }
            if (endTouchPosition.x > startTouchPosition.x)
            {
                Right();
            }
        }
    }

    private void Right()
    {
        Player.transform.position = new Vector3(Player.transform.position.x + 1, Player.transform.position.y, Player.transform.position.z);
    }

    private void Left()
    {
        Player.transform.position = new Vector3(Player.transform.position.x - 1, Player.transform.position.y, Player.transform.position.z);
    }
}
