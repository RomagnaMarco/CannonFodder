using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedSport : MonoBehaviour {

    public int year;
    public string sport;
	
    public SelectedSport(int year, string sport)
    {
        year = this.year;
        sport = this.sport;
    }
	
    public int getYear()
    {
        return year;
    }

    public string getSport()
    {
        return sport;
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
