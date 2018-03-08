using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropEgg : MonoBehaviour {

    public GameObject Egg;
    public GameObject Dragon;
    public Text counterText;
    public Button DropEggbtn;
    int counter;
    int eggTotal = 30;
    Vector3 spawnpoint = new Vector3(0.0f, 0.0f, 0.0f);



    // Use this for initialization
    void Start () {

        Button btn = DropEggbtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        counterText.text = ("Eggs: " + (eggTotal - counter));
            }

    void TaskOnClick() {
        if(counter< eggTotal)
        {

        spawnpoint = Dragon.transform.position;

        GameObject rpinstance = UnityEngine.Object.Instantiate(Egg, spawnpoint, Quaternion.identity);


        counter++;
        counterText.text = ("Eggs: " + (eggTotal - counter));



        Debug.Log("Egg Counter " + counter);
    }

    }

    // Update is called once per frame
    void Update () {

        

        

    }

    
}
