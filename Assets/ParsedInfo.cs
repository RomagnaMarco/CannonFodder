using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParsedInfo : MonoBehaviour {

    private int[] values;
    private string[] labels;
    private string flavor;
    private string[] Svalues; //string values

	// Use this for initialization
	void Start () {
		
	}

    public ParsedInfo(string flavor, string[] labels, int[] values) // when we want the int values from the text
    {
        flavor = this.flavor;
        labels = this.labels;
        values = this.values;

    }

    public ParsedInfo(string flavor, string[]labels, string[] Svalues) //for when we just want string values from the text
    {
        flavor = this.flavor;
        labels = this.labels;
        Svalues = this.Svalues;

    }


    public string[] getLabel()
    {
        return labels;
    }

    public int[] getValue()
    {
        return values;
    }

    public string[] getSValue()
    {
        return Svalues;
    }

    public string getFlavor()
    {
        return flavor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
