using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFood : MonoBehaviour
{


    private MeshRenderer meshRenderer;

    private Collider collider;



    private void Start()
    {

        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
    }
    public void OnTriggerEnter()
    {
        //PlayerInventory.Add(this);


        meshRenderer.enabled = false;
        collider.enabled = false;
    }
}