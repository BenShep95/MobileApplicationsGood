using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

    public bool GameState = false;

	public float timer = 0;
	public float minutes = 0;
	public float seconds = 0;
	float milliseconds = 100;

    float CTimer=4f;
    float CTimerMax = 4f;

	public Text timerText;
    public GameObject Countdown;

	// Use this for initialization
	void Start () 
	{
        CTimer = 4f;
		//Countdown.SetActive (false);
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{
        if (GameState == true)
        {
            CTimer -= Time.deltaTime;
            //this is purely for animation purposes xD
            if (CTimer > 0)
            {
                QAnimation();
                Debug.Log(CTimer);
            }
            else
            {
                Timer();
            }
        }
        
    }


	void GameOver()
	{
		print ("GameOver");
		//freezes the game when gameover
		Time.timeScale = 0.0f;
	}

    void Timer()
    {
        timer -= Time.deltaTime;

        minutes = Mathf.FloorToInt(timer / 60); //calculates amount of minutesby dividing total time by 60
        seconds = Mathf.FloorToInt(timer - minutes * 60);

        //Checks to see if game over
        if (timer <= 0)
        {
            GameOver();
        }

        //countdown timer 
        if (milliseconds <= 0)
        {
            if (seconds <= 0)
            {
                minutes--;
                seconds = 59;
            }
            else if (seconds >= 0)
            {
                seconds--;
            }
            milliseconds = 100;
        }

        milliseconds -= Time.deltaTime * 100;

        //sets the stringfromat so that there will always be a "0" for a blank space eg. "00:00:00"
        timerText.text = String.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, (int)milliseconds);
    }

    void QAnimation()
    {
        //Instantiate(Countdown, transform.position = new Vector3(0f,0f), Quaternion.identity);
       // Destroy(gameObject);
		//Countdown.SetActive(true);
    }
}
