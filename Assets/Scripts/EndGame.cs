using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
     
            //If a gameObject with the tag "Player" enters this trigger, load a scene.
            if (gameObject.tag == "Player")
            {
                Application.LoadLevel("Credits");
            }
    }


}

