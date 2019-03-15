using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chararcter_Attributes : MonoBehaviour {

    private int STR;
    private int DEX;
    private int CON;
    private int INT;
    private int FOC;
    private int CHA;

    //need to be set after changes done to attributes.
    private int STRmod;
    private int DEXmod;
    private int CONmod;
    private int INTmod;
    private int FOCmod;
    private int CHAmod;


    // Use this for initialization
    void Start () {

        STR = 10; DEX = 10; CON = 10;  //initialize character stats to 10.
        INT = 10; FOC = 10; CHA = 10;

        STRmod = 0; DEXmod = 0; CONmod = 0;  //initialize character mods to 0.
        INTmod = 0; FOCmod = 0; CHAmod = 0;



    }
	
	// Update is called once per frame
	void Update () {
		
	}


    //addValues double as subtract values due to incrementing a negative number?
    public void addSTRValue(int increment)
    {
        STR += increment;
    }
    public void addDEXValue(int increment)
    {
        DEX += increment;
    }
    public void addCONValue(int increment)
    {
        CON += increment;
    }
    public void addINTValue(int increment)
    {
        INT += increment;
    }
    public void addFOCValue(int increment)
    {
        FOC += increment;
    }
    public void addCHAValue(int increment)
    {
        CHA += increment;
    }

    
    public void FinalModCalc() //calcs all attribute modifers and updates them.
    {
        STRmod = CalcMod(STR);
        DEXmod = CalcMod(DEX);
        CONmod = CalcMod(CON);  
        INTmod = CalcMod(INT);
        FOCmod = CalcMod(FOC);
        CHAmod = CalcMod(CHA);
    }

    public int CalcMod(int Attribute) //finds value of modifer.
    {
        int mod = 0;
        int value = Attribute - 10;
        if (Attribute < 0) //determines if odd or even and if neg or positive. Groups accordingly.
        {
            if (Attribute % 2 == 1)
            {
                value += 1;
            }
        }
        else
        {

            if (Attribute % 2 == 1)
            {
                value -= 1;
            }
        }
        mod = value / 2;

        return mod;
    }



    //GETTER METHODS
    public int getSTRmod()
    {
       return STRmod;
    }
    public int getDEXmod()
    {
        return DEXmod;
    }
    public int getCONmod()
    {
        return CONmod;
    }
    public int getINTmod()
    {
        return INTmod;
    }
    public int getFOCmod()
    {
        return FOCmod;
    }
    public int getCHAmod()
    {
        return CHAmod;
    }

    public int getSTR()
    {
        return STR;
    }
    public int getDEX()
    {
        return DEX;
    }
    public int getCON()
    {
        return CON;
    }
    public int getINT()
    {
        return INT;
    }
    public int getFOC()
    {
        return FOC;
    }
    public int getCHA()
    {
        return CHA;
    }

}
