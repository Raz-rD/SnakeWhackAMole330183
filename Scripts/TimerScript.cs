using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static float timeLeft = (Mathf.Round(20f));
    Text Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //manages timer, makes it count down and rounds it down
        if (timeLeft > 0)
        {
            timeLeft -= 0.01f;
            Timer.text = " " + (Mathf.Round(timeLeft));
            Debug.Log(timeLeft);
        }
        //if time reaches 0, pause game and display score in console
        if (timeLeft <= 0f)
        {
            PauseGame();
            Debug.Log("Score =" + ScoreScript.scoreValue);
        }


    }
    // pause and resume game statements
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
