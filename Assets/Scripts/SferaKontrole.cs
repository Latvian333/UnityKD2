using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SferaKontrole : MonoBehaviour
{

    
    public TMP_Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kapsula")
        {
           text.text = "Tu Uzvareji!";
        }
    }
}
