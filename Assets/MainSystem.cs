using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour {

    

    GameObject[] Screens;


    // Use this for initialization
    void Start() {
        Debug.Log("MainSystem Booting up.");

        Debug.Log("Fetching Display Screens.");
        Screens = new GameObject[5];

       Screens[0] = GameObject.FindGameObjectWithTag("MenuScreen");
       Screens[1] = GameObject.FindGameObjectWithTag("CreateCharPg1");
       Screens[2] = GameObject.FindGameObjectWithTag("CreateCharPg2");
       Screens[3] = GameObject.FindGameObjectWithTag("CreateCharPg3");
       Screens[4] = GameObject.FindGameObjectWithTag("CreateCharPg4");
        Debug.Log("Display Screens Retrieved."); // does not actually indicate whether we succesfully got them or not.

       

        Debug.Log("Deactivating Unecessary Screens.");
        StartGame();


        Debug.Log("MainSystem Booted up.");
    }

    // Update is called once per frame
    void Update() {


    }

    public void StartGame()
    {

        for(int i = 1; i < Screens.Length; i++) //set everything but menuscreen to not active
        {
            // Debug.Log("Screen's array index: " + i); // if Null pointer exception for reference, 
                                                        // its because the objects in the array
                                                        // are not active at the start and thus can not be referenced.
                                                        // rememeber to turn them back on.
            Screens[i].SetActive(false);
        }
    }



    public void DisplayMenu(bool value) //sets whether or not you can see the menu by changing whether or not it's active
    {
        Screens[0].SetActive(value);
    }

    public void DisplayCharCreate(int num, bool value) //changes display according to page num entered 
    {                                                 //and its value of being off or on.
        Screens[num].SetActive(value);
    }

}
