using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameWon : MonoBehaviour
{
     public TMP_Text finalTimeString;

    // Start is called before the first frame update
    void Start()
    {
        finalTimeString.text = "Time: " + Timer.finalTime;

    }

    // Update is called once per frame
    void Update()
    {
        // finalTimeString.text = "Time: " + Timer.finalTime;

    }
}
