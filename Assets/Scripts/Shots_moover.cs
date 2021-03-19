using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots_moover : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float directionX, directionY;
        

        
        directionX = Random.Range(-1, 1);
        directionY = Random.Range(-1, 1);
        if (directionX == 0 && directionY == 0)
            directionX++;
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed* directionX, speed* directionY);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
