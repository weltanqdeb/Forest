using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool _isRange;
    [HideInInspector] public Rigidbody rb;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isRange == true)
        {
            UpItem();
        }
    }

    private void UpItem()
    {
        
        Inventory.instance.AddItem(this);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isRange = false;
        }
    }
}