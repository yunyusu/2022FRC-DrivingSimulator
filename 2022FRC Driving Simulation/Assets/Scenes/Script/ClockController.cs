using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    private Transform ClockHandTransform;
    private Text timeText;
    private float day;
    private bool timeUp;
    // Start is called before the first frame update
    private void Awake(){
        ClockHandTransform = transform.Find("clock hand");
        timeText = transform.Find("timeText").GetComponent<Text>();
    }
    // Update is called once per frame
    void Start() {
        timeUp = false;    
    }
    void Update()
    {
        day += Time.deltaTime / (24*60*60);
        float daynormalized = day % 1f;

        if(!timeUp){
        ClockHandTransform.eulerAngles = new Vector3(0, 0, -daynormalized * 24 * 60 * 60 * 6);
                
        string minuteString = Mathf.Floor(daynormalized * 24f).ToString("00");
        string secondString = Mathf.Floor(daynormalized * 24*60*60f).ToString("00");
        /*float minString = 2;
        float secondString = 30;
        if(secondString>0) secondString -= daynormalized * 24*60*60f;
        else if(secondString==0 && minString>0){
            secondString = 60;
            minString -= 1;
        }
        else{        }*/
        timeText.text = minuteString + ":" + secondString;}
        if(daynormalized * 24 * 60 * 60 >=150) timeUp = true;
    }
}
