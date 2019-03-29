﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parse : MonoBehaviour
{

    string file;

    // Use this for initialization
    void Start()
    {
        file = "";


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ParseTxt(string file, int year, int roll)
    {
        //high = 1
        //avg = 2
        //low = 3

        int lineNumData; //line to parse data values such as stats and skills and feats from
        int lineNumFlavor; //line to parse flavor text from
        lineNumData = (year - 1) * 6 + 1; //accounts for year
        lineNumData += (2 * roll) - 1; //acounts for roll
        lineNumFlavor = lineNumData - 1; // go up 1 line for flavor text

        //grabs relevant strings from file.
        string[] lines = file.Split('\n');
        string lineFlavor = lines[lineNumFlavor-1]; //must -1 because index shift from start 1 to start index 0
        string lineData = lines[lineNumData-1]; //same as above

        //Flavor line is fine as is at this point
        // must now indentify skills/stats/feats/ and values
    }

    /*
     1    Y1 High Flavor Text
     2    Y1 High Stats
     3    Y1 Avg Flavor Text
     4    Y1 Avg Stats
     5    Y1 Low Flavor text
     6    Y1 Low Stats
     7    Y2 High Flavor Text
     8    Y2 High Stats
     9    Y2 Avg Flavor Text
    10    Y2 Avg Stats
    11    Y2 Low Flavor text
    12    Y2 Low Stats
    13    Y3 High Flavor Text
    14    Y3 High Stats
    15    Y3 Avg Flavor Text
    16    Y3 Avg Stats
    17    Y3 Low Flavor text
    18    Y3 Low Stats
    19    Y4 High Flavor Text
    20    Y4 High Stats
    21    Y4 Avg Flavor Text
    22    Y4 Avg Stats
    23    Y4 Low Flavor text
    24    Y4 Low Stats
    */


}