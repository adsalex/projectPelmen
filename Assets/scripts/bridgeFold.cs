using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeFold : MonoBehaviour
{
    [SerializeField]
    float lowerBorder;

    [SerializeField]
    float upperBorder;

    [SerializeField]
    float speed;
    sbyte direction = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float buff = transform.rotation.eulerAngles.z;
        if (buff > 180) { buff -= 360; }
        if(buff<= lowerBorder) {direction = 1;}

        if (buff>= upperBorder) { direction = -1; }
        transform.Rotate(direction*Time.deltaTime*speed*Vector3.forward);
        Debug.Log(transform.rotation.eulerAngles.z);
        //Vector3 rotation = transform.rotation.eulerAngles;
        //rotation.y = Mathf.Clamp(rotation.y+speed*Time.deltaTime);
    }
}
