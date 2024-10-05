using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expoder : MonoBehaviour
{
    //standby
    //attention
    //explosion
    //recharge
    Renderer rend;
    [SerializeField]
    Material[] materials;
    float timer =0;
    [SerializeField]
    float rechargeTime = 5;
    [SerializeField]
    float attentionTime = 1;
    [SerializeField]
    float afterExplode = 1;
    List<hpController> controllers=new List<hpController>();
    int state 
    { 
        get { return _state; } 
        set {_state = value; rend.material = materials[value]; }
    }
    int _state = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    
    // Update is called once per frame
    void Update()
    {

        
        switch (state) 
        {
            case 1: 
                { 
                    timer += Time.deltaTime;
                    if (timer >= attentionTime)
                    {
                        foreach (hpController controller in controllers)
                        { 
                            controller.Hp--;
                        }
                        
                        state = 2;
                        timer = 0;
                        controllers.Clear();
                    } 
                    break; 
                }
            case 2: 
                {
                    timer += Time.deltaTime;
                    if (timer >= afterExplode)
                    {
                        state = 3;
                        timer = 0;
                    }
                    break;
                }
            case 3:
                {
                    timer += Time.deltaTime;
                    if (timer >= rechargeTime)
                    {
                        state = 0;
                        timer = 0;
                    }
                    break;
                }
        }
    }
    
   
    private void OnCollisionEnter(Collision collision)
    {
        hpController buff = collision.gameObject.GetComponent<hpController>();
        if (buff != null)
        controllers.Add(buff);

        if (state == 0) 
        { state = 1; }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        hpController buff = collision.gameObject.GetComponent<hpController>();
        controllers.Remove(buff);
    }


}
