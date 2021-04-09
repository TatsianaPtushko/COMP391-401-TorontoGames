using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injured : MonoBehaviour
{
    
     
    public GameObject Damaged;
    public GameObject Player;
    public GameObject Died;
    public int health;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    

   


    public void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
                Instantiate(Damaged, transform.position, transform.rotation);

            }

            ++i;

        if (i == health)
        {
            
                    Destroy(other.gameObject);
                    Instantiate(Died, transform.position, transform.rotation);
                    Destroy(this.gameObject);
                

        }
    } 

       
}

  



