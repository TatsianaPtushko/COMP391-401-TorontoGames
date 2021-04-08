using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Died;

    private void OnTriggerEnter2D(Collider2D other)
    
    
    { if (other.CompareTag("Bullet"))
        { 
        Destroy(other.gameObject);
        Instantiate(Died, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

    }

}
