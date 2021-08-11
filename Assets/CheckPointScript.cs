using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointScript : MonoBehaviour
{
    //Init variables
    public bool StartTime;
    private int CheckPointCount;
    public int LapCount;
    private int MaxCP = 19;
    public Text Timer;
    public Text CP;
    private float timerInfo;
    public GameHandler GH;

    // Start is called before the first frame update
    void Start()
    {
        //Starting stuff
        Timer.text = "0:00";
        StartTime = false;
        CheckPointCount = 0;
        LapCount = 0;
        timerInfo = 0;
        CP.text = CheckPointCount.ToString();
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {

        //Start timer
        if ((GH.checkpointCount == 1))
        {
            StartTime = true;
        }//Check for start timer
        //End Game
        if (GH.checkpointCount == 19)
        {
            StartTime = false;
        }
        if (StartTime == true)
        {
            timerInfo += Time.deltaTime;
            //125
            //2 = minutes
            // (60 * 2) - 125 = 120 - 125 = 5
            float minutes = Mathf.Floor(timerInfo / 60);
            float seconds = Mathf.RoundToInt(timerInfo % 60);
            if (seconds < 10)
            {
                Timer.text = minutes.ToString() + ":" + "0" + seconds.ToString();
            }
            else
                Timer.text = minutes.ToString() + ":" + seconds.ToString();
        }//Records time if true


    }//Update
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GH.checkpointCount++;


    }//OnTriggerEnter

}