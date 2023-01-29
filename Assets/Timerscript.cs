using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerscript : MonoBehaviour
{
    public static float timeValue = 10;
    public Text timeText;
    public GameManagerScript gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
        Debug.Log("Script: " + gameManagerScript);
    }

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
        Debug.Log("timeValue: " + timeValue);
        displayTime(timeValue);
        if (timeValue == 0)
        {
            //trigger game over screen
            Debug.Log("timeValue inside if: " + timeValue);
            gameManagerScript.GameOver();
        }

    }

    void displayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;
        timeText.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, milliseconds);
    }
}
