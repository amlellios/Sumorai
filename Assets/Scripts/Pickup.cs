using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private string nameText;

    //[name of editor tag thing]
    


    private MeshRenderer meshRenderer;
    private Collider collider;
    private List<Pickup> playerInventory;


   
    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void Ontrigger()
    {
        playerInventory.Add(this);
        meshRenderer.enabled = false;
        collider.enabled = false;
    }

    // Use this for initialization
    void Start()
    {
       // playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        collider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
