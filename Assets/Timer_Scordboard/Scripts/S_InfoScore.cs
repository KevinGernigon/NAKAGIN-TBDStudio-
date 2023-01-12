using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class S_InfoScore : MonoBehaviour
{
    [SerializeField]
    private S_Timer ScriptTimer;

    public bool _runStart; 

    [SerializeField] private TMP_Text _challengeTimerTxt;
    [SerializeField] private TMP_Text _bestTimeTxt;

    [SerializeField] private float _challengeTime = 10f;
    
    private float _bestTime = 0f;
    

    private float _challengeTimeminutes, _challengeTimeseconds, _challengeTimemilliseconds;
    private float _bestTimeminutes, _bestTimeseconds, _bestTimemilliseconds;




    private void Start()
    {
        ShowTimerChallenge();
        
    }

    private void Update()
    {

    }


    private void ShowTimerChallenge()
    {

        _challengeTimeminutes = (int)(_challengeTime / 60f) % 60;
        _challengeTimeseconds = (int)(_challengeTime % 60f);
        _challengeTimemilliseconds = (int)(_challengeTime * 1000f) % 1000;

        _challengeTimerTxt.text = "0" + _challengeTimeminutes + ":" + _challengeTimeseconds + ":" + "00" + _challengeTimemilliseconds;

    }


   

    public void SendTimeChallengeToTimer()         //fonction lancé au passage de la trigger box start de la run 
    {

        ScriptTimer.SetTimerRef(_challengeTime);
        _runStart = true;
    }

    public void GetBestTimePlayer()                //fonction lancé au passage de la trigger box stop de la run
    {
        _runStart = false;

        float timePlayer = ScriptTimer._timerTime;


        if (timePlayer < _challengeTime)
        {
            // ajout chemin vers les recompenses en cas de victoire 
            


            if(timePlayer < _bestTime || _bestTime == 0f)
            {
                _bestTime = timePlayer;

                _bestTimeminutes = ScriptTimer._minutes;
                _bestTimeseconds = ScriptTimer._seconds;
                _bestTimemilliseconds = ScriptTimer._milliseconds;

                _bestTimeTxt.text =  _bestTimeminutes + ":" + _bestTimeseconds + ":" + _bestTimemilliseconds;
            }

        }
        else
        {
            //Concequence de défaite 

           
            
        }

    }

    public void RewardWinRun()
    {

    }


 }
