using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update

      
    private void OnTriggerEnter2D(Collider2D other)
    {    
        if (other.tag =="Player" )
        {
           
                Destroy(other.gameObject);
                Flight();
           
             
        }
        
    }

    void Flight()
    {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(4.0f, 2.0f) * speed;
    }

    



    }
