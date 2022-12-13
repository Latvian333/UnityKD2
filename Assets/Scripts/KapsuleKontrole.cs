using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsuleKontrole : MonoBehaviour
{
    int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        System.Random rnd = new System.Random();
        i++;
        if(i >= 60){
            i = 0;
            float Red = (float)rnd.NextDouble();
            float Green = (float)rnd.NextDouble();
            float Blue = (float)rnd.NextDouble();
            Color randomColor = new Color(Red, Green, Blue, 1.0f);
            GetComponent<Renderer>().material.SetColor("_Color", randomColor);
        }
    }
}
