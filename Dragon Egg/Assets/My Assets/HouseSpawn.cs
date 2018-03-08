using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSpawn : MonoBehaviour {

    // Random rand = new Random();
    public GameObject House1;
    public GameObject HouseSpawner;


    float randNum;
    int randNumInt;
    float counterFloat;
    int counterInt;


	// Use this for initialization
	void Start () {
		
	}
    
    
	
	// Update is called once per frame
	void Update () {

        randNum = Random.Range(0, 2);

        counterFloat = counterFloat + 1 * randNum * Time.deltaTime;

        counterInt = (int)counterFloat;

        if (counterInt > 1)
        {

                
            randNum = Random.Range(1, 5);
            randNumInt = (int)randNum;
            counterFloat = 0.0f;

            GameObject rpinstance = UnityEngine.Object.Instantiate(House1, HouseSpawner.transform.position, Quaternion.identity);

            if (randNumInt == 1)
            {
               // GameObject rpinstance = UnityEngine.Object.Instantiate(House1, HouseSpawner.transform.position, Quaternion.identity);
            }

            //if certain number generate certain house

            



        }

		
	}
}
