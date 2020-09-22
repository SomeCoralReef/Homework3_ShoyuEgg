using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalScript : MonoBehaviour
{   
    int numberOfEggs = 0;
    public GameObject egg;
 void OnTriggerEnter2D(Collider2D activator){
        if(numberOfEggs < 10){
            Instantiate (egg, transform.position, transform.rotation);
            numberOfEggs++;
        }
     }

    // Update is called once per frame
}
