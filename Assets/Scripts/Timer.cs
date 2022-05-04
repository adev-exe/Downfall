using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
     public TMP_Text timer_TMP;

     int current_time = 0;
     float minutes = 0;
     float seconds = 0;
     public static string finalTime;

     void Start()
    {
        //This updates the text feild once every second.
        //  timer_TMP = GetComponent<TMP_Text>();
        timer_TMP.text = current_time.ToString();
        StartCoroutine(RunEverySecond());
     }


     void Update()
     {
         RunEverySecond();
    }

    //increases the current time value by one every second
    //then calculates the time in mins:seconds
     public IEnumerator RunEverySecond()
     {
        while (true)
        {
            current_time += 1;
            minutes = Mathf.FloorToInt(current_time / 60);
            seconds = Mathf.FloorToInt(current_time % 60);
            finalTime = string.Format("{0:00}:{1:00}", minutes, seconds);
            timer_TMP.text = finalTime;

            // textBox.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);

            yield return new WaitForSeconds(1.0f);

         }

     }
}
