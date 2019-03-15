using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Skills : MonoBehaviour {
    
    // skill list
    //END
    public int survival;
    //DEX
    private int Athletics;
    private int Stealth;
    private int Dodge;
    private int Sprint;
    //DEX and STR
    private int Throw;
    //STR
    private int Grapple;
    //STR or CHA
    private int Intimidate;
    //CHA
    private int SenseMotive;
    private int Persuade;
    private int Lie;
    //INT
    private int Crafting;
    private int Repair;
    //FOC or INT
    private int Defuse;
    private int Perception;
    //FOC
    private int ShootSmall;
    private int ShootBig;


    // Use this for initialization
    void Start ()
    {
        //initialize skills to 0.
        survival = 0; 
        Athletics = 0;
        Stealth = 0;
        Dodge = 0;
        Sprint = 0;
        Throw = 0;
        Grapple = 0;
        Intimidate = 0;
        SenseMotive = 0;
        Persuade = 0;
        Lie = 0;
        Crafting = 0;
        Repair = 0;
        Defuse = 0;
        Perception = 0;
        ShootSmall = 0;
        ShootBig = 0;



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
