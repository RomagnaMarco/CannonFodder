using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedSport : MonoBehaviour {

    public int year;
    public string sport;
    public int RNGlevel;
	
    public SelectedSport(int year, string sport, int RNGlevel)
    {
        year = this.year;
        sport = this.sport;
        RNGlevel = this.RNGlevel;
    }
	
    public int getRNGlevel()
    {
        return RNGlevel;
    }

    public int getYear()
    {
        return year;
    }

    public string getSport()
    {
        return sport;
    }

    public void setRNGlevel(int newRNG)
    {
        RNGlevel = newRNG;
    }

    public void setYear(int newYear)
    {
         year = newYear;
    }

    public void setSport(string newSport)
    {
         sport = newSport;
    }
}
