using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timeText;
    float timeValue = 30;
    int timeInt;

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeValue > 0)
        {
            timeValue = timeValue - 1 * Time.deltaTime;
        }

        timeInt = (int)timeValue;

        timeText.text = ("Time: " + timeInt);
	}
}
