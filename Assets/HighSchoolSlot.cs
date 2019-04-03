using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighSchoolSlot : MonoBehaviour {

    private string[] sports;
    private int[] sportYears;

    private string ObservedSport;
    private int ObservedYear;

    private int sportIndex;
    private int yearIndex;

    Parse parser;

    int[] valuesHigh;
    string[] labelsHigh;

    int[] valuesAvg;
    string[] labelsAvg;

    int[] valuesLow;
    string[] labelsLow;


    // Use this for initialization
    void Start () {
        parser = new Parse();

        sports = new string[15];
        
        sports[0] = ""; //will need to shift to 14
        sports[1] = "Football";
        sports[2] = "Boxing";
        sports[3] = "Lifting";
        sports[4] = "Track & Field";
        sports[5] = "BaseBall";
        sports[6] = "Debate Club";
        sports[7] = "Drama";
        sports[8] = "Chess Club";
        sports[9] = "Academics";
        sports[10] = "Hunting";
        sports[11] = "Boy Scouts";
        sports[12] = "Marching Band";
        sports[13] = "Language Class";
        sports[14] = "LifeGuard";
        sports[15] = ""; // will need to shift to 1

        sportYears = new int[15];
        for(int i = 0; i < sportYears.Length; i++)
        {
            sportYears[i] = 1;
            //note that 0 and 15 dont matter and are just for reference of the sports string array.
        }

        //index 0 and 15 is so when the buttons go up and down, we dont risk out of bound errors

        sportIndex = 1;
        ObservedSport = sports[sportIndex];
        yearIndex = 1;
        ObservedYear = sportYears[yearIndex];

    }

    // Update is called once per frame
    void Update()
    {

       
       


        /*
        if they add the sport
            if sport[i], add sport[i] to selected list
                add values of sport[i] to overall stats.

        if they remove the sport
            if sport[i], delete sport[i] from selected list
                delete values of sport[i] from overall values

        */
    }

    private void determineDisplay(string file, string name)
    {
        
        valuesHigh = parser.ParseTxt(file, ObservedYear, 1).getValue(); 
        labelsHigh = parser.ParseTxt(file, ObservedYear, 1).getLabel();

        valuesAvg = parser.ParseTxt(file, ObservedYear, 2).getValue();
        labelsAvg = parser.ParseTxt(file, ObservedYear, 2).getLabel();

        valuesLow = parser.ParseTxt(file, ObservedYear, 3).getValue();
        labelsLow = parser.ParseTxt(file, ObservedYear, 3).getLabel();
        
    }

    private void DisplaySport(string sport)
    {

        switch(sport)
        {
            case "Football":
                //show sport/club label
                //show year

               //determineDisplay Method

                //for High Avg Low
                //  show skills
                //  show stats
                //  show feats
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


    //UI buttons
    public void pushNext() 
    {
        sportIndex++;

        if (sportIndex == 15)
        {
            sportIndex = 1;
        }

        ObservedSport = sports[sportIndex]; //change ObservedSport to new sport
        DisplaySport(sports[sportIndex]);
    }

    public void pushPrevious()
    {
        sportIndex--;

        if (sportIndex == 0)
        {
            sportIndex = 14;
        }

        ObservedSport = sports[sportIndex]; //change ObservedSport to new sport
        DisplaySport(sports[sportIndex]);
    }

    public void YearAdvance() //click on avg, high, or low, settings
    {

    }

    public void YearDelete()
    {

    }
}
