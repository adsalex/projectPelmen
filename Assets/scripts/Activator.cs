using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    
    void Start()
    {
                
    }

    
    private void OnTriggerEnter(Collider other)
    {
        timeCount component= other.gameObject.GetComponent<timeCount>();
        if(component != null) 
        {
            component.enabled = true;
        }
    }
}
