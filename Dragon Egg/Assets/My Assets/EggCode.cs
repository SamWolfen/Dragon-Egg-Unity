using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCode : MonoBehaviour {

    public GameObject Egg;
    public GameObject Dragon;

    Vector3 eggPosition;
    Quaternion eggRotation;
    float counter = 0;
    bool firstRun = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (firstRun == true)
        {
            //Egg.transform.position = Dragon.transform.position;

            firstRun = false;
        }

        eggPosition = Egg.transform.position;
        eggRotation = Egg.transform.rotation;

        counter = counter + 0.1f * Time.deltaTime;

        eggPosition[0] = eggPosition[0] - 1.5f * Time.deltaTime;
        eggPosition[1] = eggPosition[1] -  counter + 2 * Time.deltaTime;
        //eggRotation[1] = eggRotation[1] + 1f * Time.deltaTime;
        eggRotation[2] = eggRotation[2] + 1f * Time.deltaTime;




        Egg.transform.position = eggPosition;
        Egg.transform.rotation = eggRotation;
    }
}
