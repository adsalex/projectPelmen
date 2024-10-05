using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class blowTrigger : MonoBehaviour
{
    [SerializeField]
    float windForce = 20;
    [SerializeField]
    float minDirectionSeed = 1;
    [SerializeField]
    float maxDirectionSeed = 10;
    Vector3 direction;
    float timer = 0;
    float timer2 = 0;
    void Start()
    {
        direction = new Vector3(Random.Range(minDirectionSeed, maxDirectionSeed), 0, Random.Range(minDirectionSeed, maxDirectionSeed));
        direction = direction.normalized; 
        //Debug.Log(direction);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            direction = new Vector3(Random.Range(minDirectionSeed, maxDirectionSeed), 0, Random.Range(minDirectionSeed, maxDirectionSeed));
            direction = direction.normalized;
            //Debug.Log(direction);
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
