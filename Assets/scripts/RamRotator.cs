using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamRotator : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
    }
}
