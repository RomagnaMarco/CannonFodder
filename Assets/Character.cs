using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    
    //basic information
    public string firstName;
    public string middleInitial;
    public string lastName;
    public int age; //years

    public Chararcter_Attributes charAtts;
    public Character_Skills charSkills;
    public Character_Equipment charEquips;
    public Character_Feats charFeats;




    // Use this for initialization
    void Start () {

        //default info
        firstName = "Robert";
        middleInitial = "J";
        lastName = "Smith";
        age = 18;

        charSkills = new Character_Skills();
        charAtts = new Chararcter_Attributes();
        charEquips = new Character_Equipment();
        charFeats = new Character_Feats();


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //basic editors. 

    public void EditFirstName(string newFirst)
    {
        firstName = newFirst;
    }

    public void EditMiddleI(string newMiddle)
    {
        middleInitial = newMiddle;
    }

    public void EditLastName(string newLast)
    {
        lastName = newLast;
    }

    public void EditAge(int newAge)
    {
        age = newAge;
    }
}
