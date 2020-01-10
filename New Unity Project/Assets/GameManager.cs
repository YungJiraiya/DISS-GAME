using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> target = new List<GameObject>();
    public int score = -1;
    int randomNumber;
    int randomHold;

    //timer variables
    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    public float currentSeconds;


    // Start is called before the first frame update



    void Start()
    {

        for (int i = 0; i < 24; i++)
        {
            target[i] = GameObject.FindGameObjectsWithTag("target")[i];
        }

      
    }


    // Update is called once per frame
    void Update()
    {
        int scoreCap = 10;
        if (score < scoreCap && score >= 0)
        {
            UpdateTimerUI();
        }
        else{
            StopTimerUI();
        }
        if (Input.GetKeyDown("return"))
        {
            setTarget();
        }
    }

    public void setTarget()
    {
        do
        {
            randomNumber = Random.Range(0, 24);
        } while (randomNumber == randomHold);
        target[randomNumber].GetComponent<targetActive>().activeTarget = true;
        Debug.Log("The chosen target is " + randomNumber);
        randomHold = randomNumber;
        score++;
    }

    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        timerText.text = minuteCount + ":" + (int)secondsCount + "";
        currentSeconds = secondsCount;
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }

    public void StopTimerUI()
    {
        timerText.text = "Time = " + (int)currentSeconds;
    }
}

