using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class hpController : MonoBehaviour
{
    
    public UnityEvent eolSignal;
    public UnityEvent onHpChange;
    [SerializeField]
    int hp=1;
    public int Hp 
    { 
        get{ return hp; }
        set{ hp = value;
            if(hp <= 0) 
            {if(eolSignal != null) eolSignal.Invoke();}
            if (onHpChange != null) onHpChange.Invoke();

            }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
