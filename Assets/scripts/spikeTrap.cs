using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrap : MonoBehaviour
{
    [SerializeField]
    bool spikesIsOn = false;
    Renderer rend;
    [SerializeField]
    Material spikeMat;
    [SerializeField]
    Material clearMat;
    float timer = 0;
    [SerializeField]
    float time;

    List<hpController> controllers = new List<hpController>();

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (spikesIsOn)
        {
            rend.material = spikeMat;
        }
        else 
        {
            rend .material = clearMat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time) 
        {
            timer = 0;
            spikesIsOn = !spikesIsOn;
            if (spikesIsOn)
            {
                rend.material = spikeMat;
                
            }
            else
            {
                rend.material = clearMat;
            }
        }
        if (spikesIsOn) 
        {
            foreach (hpController controller in controllers)
            {
                controller.Hp--;
            }
            controllers.Clear();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        hpController buff = collision.gameObject.GetComponent<hpController>();
        if (buff != null)
            controllers.Add(buff);

    }
    private void OnCollisionExit(Collision collision)
    {
        hpController buff = collision.gameObject.GetComponent<hpController>();
        controllers.Remove(buff);

    }
}
