using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{

    public GameObject ball;


    // Update is called once per frame
    void Update()
    {
           if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate (ball, transform.position, transform.rotation);
        }
    }
}
