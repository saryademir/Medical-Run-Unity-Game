using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCounterToStop : MonoBehaviour
{
    public Counter obj;
    public float currentTime = 0f;
   // public float startingTime = 36f;
   // public bool keepTiming = true;
    public float timer;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = obj.currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        //currentTime -= 1 * Time.deltaTime;

        countdownText.text = currentTime.ToString("0");
        StopTimer();
        currentTime = obj.currentTime;
       
        /*if (keepTiming == true)
        {
            if (currentTime <= 30)
            {
                countdownText.color = Color.red;
            }
            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }*/


    }
    float StopTimer()
    {
        obj.keepTiming = false;
        return timer;
    }
    void ResumeTimer()
    {
        obj.keepTiming = true;
        obj.startingTime = currentTime;
    }

    /*void StartTimer()
    {
        keepTiming = true;
        startTime = Time.time;
    }*/
}

    

