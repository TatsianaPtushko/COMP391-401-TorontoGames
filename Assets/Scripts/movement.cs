using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    public float rotatespeed = 5f;
    // Update is called once per frame



    void Update()
    {
        float hori;
        float vert;
        hori = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        Vector2 newVelocity = new Vector2(hori, vert);

        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;

        if (Input.GetAxis("Vertical") > 0)
        {
            characterScale.y = 1;
        }
        transform.localScale = characterScale;

        void Rotation()
        {
            float rotation = vert * rotatespeed;
            transform.Rotate(Vector3.forward * rotation);
        }
    }
}
