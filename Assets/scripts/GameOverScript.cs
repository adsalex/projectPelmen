using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    GameObject finalPan;
    [SerializeField]
    TextMeshProUGUI text;
    [SerializeField]
    string afterWord;
    GameObject cam;
    void Start()
    {
        text = finalPan.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        cam = finalPan.transform.Find("Camera").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void DefeatGame()
    {
        finalPan.gameObject.SetActive(true);
        text.text = afterWord;
        Destroy(this.gameObject);
        Debug.Log("lek");
        
        
        
    }
}
