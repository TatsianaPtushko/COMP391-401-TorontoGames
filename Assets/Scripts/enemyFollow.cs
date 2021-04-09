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

    public GameObject bullet, BulletSpawn;
    public float bulletSpeed = 7f;
    public float stepTime = 0.8f;
    public float delay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        InvokeRepeating("Shot", delay, stepTime);
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
        if (Player != null)
            MoveEnemy(movement);
    }


    public void Shot()

    {
        if (Player != null)
        {
            GameObject bulletObj;
            bulletObj = GameObject.Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);

            Rigidbody2D bulletRB = bulletObj.GetComponent<Rigidbody2D>();
            bulletRB.AddForce(BulletSpawn.transform.up * bulletSpeed, ForceMode2D.Impulse);
        }
    }  
    
    
    void MoveEnemy(Vector2 direction)
    {
        rBody.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

}




