using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighSchoolSlot : MonoBehaviour {

    string[] sports;

    string ObservedSport;

    int sportIndex;

    // Use this for initialization
    void Start () {
        sports = new string[13];
        sports[0] = "Football";
        sports[1] = "Boxing";
        sports[2] = "Lifting";
        sports[3] = "Track & Field";
        sports[4] = "BaseBall";
        sports[5] = "Debate Club";
        sports[6] = "Drama";
        sports[7] = "Chess Club";
        sports[8] = "Academics";
        sports[9] = "Hunting";
        sports[10] = "Boy Scouts";
        sports[11] = "Marching Band";
        sports[12] = "Language Class";
        sports[13] = "LifeGuard";

        sportIndex = 0;
        ObservedSport = sports[sportIndex];
 

    }

    // Update is called once per frame
    void Update() {
        ObservedSport = sports[sportIndex];

        /*
        if i does not equal i, change  visual to new i
        clicking left and right in UI change i, by adding or subtracting 1.
        >if i = 0 and goes down one, make i = 13
        >if i = 13 and goes up one, make i = 0

        if they add the sport
            if sport[i], add sport[i] to selected list
                add values of sport[i] to overall stats.

        if they remove the sport
            if sport[i], delete sport[i] from selected list
                delete values of sport[i] from overall values

        */
    }

    private void checkSport(string sport)
    {
        switch(sport)
        {
            case "Football":

                break;
            
            case "Boxing":

                break;
            case "Lifting":

                break;
            case "BaseBall":

                break;
            case "Track & Field":

                break;
            case "Debate Club":

                break;
            case "Drama":

                break;
            case "Chess Club":

                break;
            case "Academics":

                break;
            case "Hunting":

                break;
            case "Boy Scouts":

                break;
            case "Marching Band":

                break;
            case "Language Class":

                break;
            case "LifeGuard":

                break;

        }

    }
    
    /*
        STR + END
           FootBall
           Boxing
           Lifting
        Dex
           BaseBall
           Track & Feild
        CHA
            Debate Club
            Drama
        INT
            Chess Club
            Academics
        Survival
            Hunting
            Boy Scouts
        Misc
            Marching Band
            Langauge class
            LifeGuard


     */
}
