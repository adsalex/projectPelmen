using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject finalPan;
    [SerializeField]
    TextMeshProUGUI text;
    [SerializeField]
    string afterWord;
    GameObject cam;
    void Start()
    {
        //text = finalPan.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        cam = finalPan.transform.Find("Camera").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            finalPan.gameObject.SetActive(true);
            text.text = afterWord + $"\n твое время: {collision.gameObject.GetComponent<timeCount>().timer} секунд";
            Destroy(collision.gameObject);
        }

    }
    
}
