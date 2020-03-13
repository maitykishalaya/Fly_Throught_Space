using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform player;
    
    public float speed = 0.15f;
    private bool touchStart = false;

    private Vector2 pointA;
    private Vector2 pointB;

    public Transform circle;
    public Transform outerCircle;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x > 30 && Input.mousePosition.x < 350 && Input.mousePosition.y > 30 && Input.mousePosition.y < 330)
                pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, -3.95f, Camera.main.transform.position.z));

           
            outerCircle.transform.position = new Vector3(-1.85f, -4.1f, 0f);
            circle.transform.position = new Vector3(-1.85f, -4.1f, 0f);
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {


            if (Input.mousePosition.x > 30 && Input.mousePosition.x < 350 && Input.mousePosition.y > 30 && Input.mousePosition.y < 330)
            {
                touchStart = true;
                pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, -3.95f, Camera.main.transform.position.z));
                
            }
        }
        else
        {
            touchStart = false;
        }
        if (touchStart)
        {
            //Vector2 temp = pointA;

            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 0.5f);
            moveCharacter(direction);           
            circle.transform.position = new Vector2(-1.85f + direction.x, -4.1f + 0f);
        }
    }
   
    void moveCharacter(Vector2 direction)
    {
       player.Translate(direction * speed);
    }

   
} 