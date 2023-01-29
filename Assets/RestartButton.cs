using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    
    public Timerscript ts;
    public PlayerScript ps;
    // Start is called before the first frame update
    void Start()
    {
        ts = GameObject.FindObjectOfType<Timerscript>();
        ps = GameObject.FindObjectOfType<PlayerScript>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public void RestartGame()
    {
        ts.restartTime();
        ps.resetPosition();
    }
}
