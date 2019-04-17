using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighSchoolSlot : MonoBehaviour {

    private List<SelectedSport> selections;
    private string ObservedSport;
    private int ObservedYear;

    private int selectionCAP;

    private int sportIndex;
    private int yearIndex;
    private int selectionIndex;

    private string[] sports;
    private int[] sportYears;

    Parse parser;

    int[] valuesHigh;
    string[] labelsHigh;

    int[] valuesAvg;
    string[] labelsAvg;

    int[] valuesLow;
    string[] labelsLow;

    string[] taggedName;


    // Use this for initialization
    void Start () {
        parser = new Parse();

        selections = new List<SelectedSport>();
        selectionCAP = 7;

        taggedName = new string[7];  //name for selection Text (buttons that show whats in the selections list and if you push them, they are removed from the list)
        taggedName[0] = "Selection 1";
        taggedName[1] = "Selection 2";
        taggedName[2] = "Selection 3";
        taggedName[3] = "Selection 4";
        taggedName[4] = "Selection 5";
        taggedName[5] = "Selection 6";
        taggedName[6] = "Selection 7";
        taggedName[7] = "Selection 8";


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
            sportYears[i] = 0;
            //note that 0 and 15 dont matter and are just for reference of the sports string array.
        }

        //index 0 and 15 is so when the buttons go up and down, we dont risk out of bound errors

        sportIndex = 1;
        ObservedSport = sports[sportIndex];
        yearIndex = 1;
        ObservedYear = sportYears[yearIndex];
        selectionIndex = 0;
        


    }

    // Update is called once per frame
    void Update()
    {

      //need to update values upon deletion and addition of selections
    }
    

    //UI buttons
    public void pushNext() 
    {
        sportIndex++;

        if (sportIndex == 15)
        {
            sportIndex = 1;
        }

        ObservedSport = sports[sportIndex]; //change ObservedSport to new sport
        DisplaySport(ObservedSport);
    }

    public void pushPrevious()
    {
        sportIndex--;

        if (sportIndex == 0)
        {
            sportIndex = 14;
        }

        ObservedSport = sports[sportIndex]; //change ObservedSport to new sport
        DisplaySport(ObservedSport);
    }

    public void YearAdvance(int RNG) //click on avg, high, or low, settings
    {
        //High == 3
        //Avg  == 2
        //Low  == 1
        if (selectionIndex == selectionCAP)
        {
            //do nothing when pushed basically. It wont activate if selection list is full.

            //maybe later have an pop up telling them to either delete a choice, or continue on.
        }
        else
        {
            if(yearIndex == 4)
            {
                //do nothing as year for this sport is maxed.
            }
            else
            {
                
                    selections.Add(new SelectedSport(ObservedYear, ObservedSport, RNG));
                    selectionIndex++;
                    ObservedYear += 1;
                
            }
            
        }
        DisplaySelections();


    }

    public void SportDelete(int selectedSelection) // 3 => sport 2 in array.
    {
        //check if deleted sport year was a prereq for another sport year on the list
        // if it was a prereq, remove preceding years.

        if (selectionIndex == 0)
        {
            //do nothing when pushed basically. It wont activate if selection list is empty
        }
        else
        {
            //go through list from 0 to selection index basically and see if any number Year greater than it exists. IF there is one. Delete that one too. 
            //for each delete, selectionIndex goes down by 1.
            List<int> deletedSelections = new List<int>();

            for( int i = 0; i < selectionIndex; i++)
            {
                if(selections[i].getYear() < yearIndex) //collects indexes to be deleted. Can't directly delete or there is risk of a concurrent modification error
                {
                    deletedSelections.Add(i);
                }

            }
            
            for (int i = 0; i < deletedSelections.Count;i++) //now delete each part 1 by 1. Mostly will just delete one thing.
            {
                //recall what was stored in that selection
                string rememberIndexName = selections[deletedSelections[i]].getSport();
                int rememberIndex = 0; // 0 is default and will change
                //check what index it is in the array.
                for (int j = 0; j < sports.Length; j++)
                {
                    if(sports[j] == rememberIndexName) //if names match
                    {
                        rememberIndex = j;
                    }
                }
                //now decremement the year by one of that sport's index
                sportYears[rememberIndex]--;

                selections.RemoveAt(deletedSelections[i]); //deletes stored indexes assigned to be removed that we got in the deletedSelections list
                selectionIndex--; // each time you delete a sport, the index goes down.

            }
        }
        DisplaySelections();
    }

    //end of UI Buttons

    private void DisplaySelections()
    {
        for(int i = 0; i < selections.Count; i++) //fills selected sports in 
        {
            GameObject.Find(taggedName[i]).GetComponentInChildren<Text>().text =  selections[i].getSport();
            //re-displays selections
        }
        if ( selections.Count < taggedName.Length) //if we didnt have all selections filled, fill the rest with their choice Number
        {
            for(int i = selections.Count; i < taggedName.Length;i++)
            {
                GameObject.Find(taggedName[i]).GetComponentInChildren<Text>().text = "Selection " + i;
            }
        }
    }

    private void DisplaySport(string sport)
    {

        switch (sport)
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

    private void determineDisplay(string file, string name) //grabs Information in the form of Strings and int Arrays.
    {
        //note that name = Name of sport.

        valuesHigh = parser.ParseTxt(file, ObservedYear, 1, true).getValue();
        labelsHigh = parser.ParseTxt(file, ObservedYear, 1, true).getLabel();

        valuesAvg = parser.ParseTxt(file, ObservedYear, 2, true).getValue();
        labelsAvg = parser.ParseTxt(file, ObservedYear, 2, true).getLabel();

        valuesLow = parser.ParseTxt(file, ObservedYear, 3, true).getValue();
        labelsLow = parser.ParseTxt(file, ObservedYear, 3, true).getLabel();

    }

}
