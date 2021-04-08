using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public Transform Player;
    public float speed;
    public float rotate;
    private Rigidbody2D rBody;
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + rotate;
        rBody.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveEnemy(movement);
    }

   void MoveEnemy(Vector2 direction)
    {
        rBody.MovePosition((Vector2)transform.position +(direction*speed*Time.deltaTime));
    }
}
