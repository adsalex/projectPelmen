using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCount : MonoBehaviour
{
    public float timer  { get; private set; }
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}
