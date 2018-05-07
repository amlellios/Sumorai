using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    string nameText;
   
    [SerializeField]
    Pickup key;

    private Animator animator;
    private bool isLocked, isOpen;
    private List<Pickup> playerInventory;

    public string NameText
    {
        get
        {
            string toReturn = nameText;

            if (isOpen)
                toReturn = ""; 
            else if (isLocked && !HasKey)
                toReturn += " (LOCKED)";
            else if (isLocked && HasKey)
                toReturn += string.Format(" (use {0})", key);

            return toReturn;
        }
    }

    private bool HasKey
    {
        get
        {
            return playerInventory.Contains(key);
        }
    }

    public void DoActivate()
    {
        if (!isOpen)
        {
            if (!isLocked || HasKey)
            {
                animator.SetBool("isDoorOpen", true);
                isOpen = true;
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
   
        isLocked = key != null;
    }
}