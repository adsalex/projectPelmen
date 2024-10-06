using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSwith : MonoBehaviour
{
    [SerializeField]
    bool trigIsOn = false;
    float timer = 0;
    [SerializeField]
    float time;
    MeshRenderer rend;
    Collider col;
    void Start()
    {
        col = GetComponent<Collider>();
        rend = GetComponent<MeshRenderer>();
        col.isTrigger = trigIsOn;
        rend.enabled = trigIsOn;     

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time) 
        {
            timer = 0;
            trigIsOn = !trigIsOn;
            col.isTrigger = !trigIsOn;
            rend.enabled = trigIsOn;
        }
    }
}
