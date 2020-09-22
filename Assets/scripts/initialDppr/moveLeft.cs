using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            GetComponent<ConstantForce2D>().relativeForce = new Vector3 (0f,0f,1f);
        }
    }
}
