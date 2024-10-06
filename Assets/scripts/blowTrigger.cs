using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class blowTrigger : MonoBehaviour
{
    [SerializeField]
    float windForce = 20;
    
    Vector3 direction;
    float timer = 0;
    float timer2 = 0;
    void Start()
    {

        direction = new Vector3( Mathf.Sin(Random.Range(0, 360f)), 0, Mathf.Cos(Random.Range(0, 360f)));
        //direction = direction.normalized; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            direction = new Vector3(Mathf.Sin(Random.Range(0, 360f)), 0, Mathf.Cos(Random.Range(0, 360f)));
            //direction = direction.normalized;
            timer = 0;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        timer2 = 0;
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(direction*windForce);
            
        }

    }
}
