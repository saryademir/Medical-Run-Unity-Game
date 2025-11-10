using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownCounter : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 3f;
    public bool keepTiming = true;
    public float timer;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {

        countdownText.text = currentTime.ToString("0");

        
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 3)
            {
                countdownText.color = Color.red;
            }
            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        

    }
    float StopTimer()
    {
        keepTiming = false;
        return timer;
    }
    void ResumeTimer()
    {
        keepTiming = true;
        startingTime = currentTime;
    }

    /*void StartTimer()
    {
        keepTiming = true;
        startTime = Time.time;
    }*/

}
