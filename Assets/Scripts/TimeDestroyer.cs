using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyer : MonoBehaviour
{
    public float time;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Injuries());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator Injuries()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
         
    }
}
