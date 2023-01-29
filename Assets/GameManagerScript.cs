using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public TextMeshProUGUI gameOverText;
    public bool isGameActive = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        //Time.timeScale = 0;
    }

    public void restartGame()
    {
        gameOverText.gameObject.SetActive(false);
        isGameActive = true;
    }
}
