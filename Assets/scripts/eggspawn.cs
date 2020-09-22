using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggspawn : MonoBehaviour
{

    public GameObject egg;


    // Update is called once per frame
    void Update()
    {
           if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate (egg, transform.position, transform.rotation);
        }
    }
}
