using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactDamager : MonoBehaviour
{
    [SerializeField]
    int Damage = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<hpController>().Hp-=Damage;
    }
}
