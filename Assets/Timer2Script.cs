using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2Script : MonoBehaviour
{
    public float timeValue = 10;
    public Text timeText;
    //public GameManagerScript gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        //gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
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
        displayTime(timeValue);

    }

    void displayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            SceneManager.LoadScene("SampleScene");
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //float milliseconds = timeToDisplay % 1 * 1000;
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
