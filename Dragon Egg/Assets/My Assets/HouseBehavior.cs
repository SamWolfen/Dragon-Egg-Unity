using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBehavior : MonoBehaviour {
    public GameObject House;
    Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        pos = House.transform.position;
        pos[0] = pos[0] - 5 * Time.deltaTime;


        House.transform.position = pos;
    }
}
