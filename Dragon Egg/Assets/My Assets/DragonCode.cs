gusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCode : MonoBehaviour {

    public GameObject Dragon;
    Vector3 dragPosition;
    float counter = 0.0f;
    float ocilator = 0.0f;


    // Use this for initialization
    void Start()
    {

        dragPosition = Dragon.transform.position;

    }






    // Update is called once per frame
    void Update() {

        dragPosition = Dragon.transform.position;

        counter = counter + 5*Time.deltaTime;
        ocilator = Mathf.Sin(counter);

        //Debug.Log("Ocilator: " + ocilator + "  Counter: " + counter);
        //the value of the ocilator deternmines the direction of the dragon

        if (ocilator > 0)
        {
            dragPosition[1] = dragPosition[1] + 0.01f;

        }
        else
        {
            dragPosition[1] = dragPosition[1] - 0.01f;

        }
            

           


            Dragon.transform.position = dragPosition;

        }



    }



