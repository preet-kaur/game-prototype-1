using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerscript : MonoBehaviour
{
    public static float timeValue = 10;
    public Text timeText;
    public GameManagerScript gameManagerScript;
  
    void Start()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
        Debug.Log("Script: " + gameManagerScript);
    }

    // Update is called once per frame
    public void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
    
        displayTime(timeValue);
     
        if (timeValue == 0)
        {
            
            gameManagerScript.GameOver();
        }

    }


    public void displayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //float milliseconds = timeToDisplay % 1 * 1000;
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void restartTime()
    {
        timeValue = 10;
        if (gameManagerScript.isGameActive == false)
        {
            gameManagerScript.restartGame();
        }
       
    }

}
