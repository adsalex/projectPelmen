using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HpIndicator : MonoBehaviour
{
    [SerializeField]
    hpController playerHp;
    TextMeshProUGUI text;
    void Start()
    {
        playerHp = GameObject.Find("Player").GetComponent<hpController>();
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = $"hp: {playerHp.Hp}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onHpChange() 
    {
        text.text = $"hp: {playerHp.Hp}";
    }

}
