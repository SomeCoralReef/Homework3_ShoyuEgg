using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{
      public Transform cameraTransform;
      Transform cameraFocusTarget;

    void OnTriggerEnter2D(Collider2D activator){
        cameraFocusTarget =  activator.transform;
     }

        void OnTriggerExit2D(Collider2D activator){
        if(activator.transform == cameraFocusTarget){
            cameraFocusTarget = null;
        }
    }

    void Update() {
      if(cameraFocusTarget != null){
            cameraTransform.position = cameraFocusTarget.position + new Vector3 (0f,0f,-0.5f);
      }

}

}
