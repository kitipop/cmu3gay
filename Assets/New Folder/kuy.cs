using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class kuy : MonoBehaviour
{
    int countDownStartValue = 90;
    public TextMeshProUGUI timetUi;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue >= 0)
        {
            TimeSpan SpanTime = TimeSpan.FromSeconds(countDownStartValue);
            timetUi.text = "Timer : " + SpanTime.Minutes + " : " + SpanTime.Seconds;
            countDownStartValue -- ;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timetUi.text = "GameOver";
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
