using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public float timeValue = 90;
    public Text countdownTimer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    
    }

    void DisplayTime(float timeToDisplay)
    {
            if( timeToDisplay < 0)
            {
                timeValue = 0;
            }
            else if (timeToDisplay > 0)
            {
            timeToDisplay += 1;
            }

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            countdownTimer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    
    }




    

}
