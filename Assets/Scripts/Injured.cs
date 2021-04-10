using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injured : MonoBehaviour
{
    
     
    public GameObject Damaged;
    public GameObject Player;
    public GameObject Died;
    public int health=5;
    private int minusHealth = 1;
    private int i = 0;

    private GameController gameControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameControllerScript = gameControllerObject.GetComponent<GameController>();
        }

        if (gameControllerScript == null)
        {
            Debug.Log("Cannot fint GameController script on GameController object");
        }


    }






    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Bullet"))
        {
            
            Destroy(other.gameObject);
            Instantiate(Damaged, transform.position, transform.rotation);
            
        }

        gameControllerScript.DecreaseHealth(minusHealth);
        ++i;

        if (i == health)
        {
            
                    Destroy(other.gameObject);
                    Instantiate(Died, transform.position, transform.rotation);
                   gameControllerScript.GameOver();
            Destroy(this.gameObject);
                    

        }
    } 

       
}

  



