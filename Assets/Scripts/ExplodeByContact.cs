using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject emptyPlant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //something collide

        int n = 0;
        // create explosion;
        while (n < 5)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            n++;
        }
        // delete other object
        Destroy(other.gameObject);
        Instantiate(emptyPlant, transform.position, transform.rotation);
        //delete object itself and all its scripts. The last action
        Destroy(this.gameObject);


    }



}
