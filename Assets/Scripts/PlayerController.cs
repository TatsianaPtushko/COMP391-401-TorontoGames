using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Camera cam;

    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;
        //float rotation;


        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        Vector2 newVelocity = new Vector2(horiz, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        //    //rotation = vert * rotationSpeed;
        //    //transform.Rotate(Vector3.forward * rotation);
    }


    void FixedUpdate()
    {
        Vector2 lookDirection = mousePos - GetComponent<Rigidbody2D>().position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        GetComponent<Rigidbody2D>().rotation = angle;

    }


}