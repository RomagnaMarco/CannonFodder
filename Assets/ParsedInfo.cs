using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParsedInfo : MonoBehaviour {

    private int[] values;
    private string[] labels;
    private string flavor;

	// Use this for initialization
	void Start () {
		
	}

    public ParsedInfo(string flavor, string[] labels, int[] values)
    {
        flavor = this.flavor;
        labels = this.labels;
        values = this.values;

    }


    public string[] getLabel()
    {
        return labels;
    }

    public int[] getValue()
    {
        return values;
    }

    public string getFlavor()
    {
        return flavor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
