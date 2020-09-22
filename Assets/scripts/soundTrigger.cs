using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour
{
    public AudioSource playSound;

    void OntriggerEnter2D(Collider2D activator)
    {
        playSound.Play();
        Debug.Log("omg");
        Destroy(activator);
    }
}