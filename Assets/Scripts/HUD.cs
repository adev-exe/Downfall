using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HUD : MonoBehaviour
{
     public TMP_Text textBox;
     public static int gas_Collected;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = gas_Collected + "/9";
    }
}
