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
    void Start()
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
    public void modifySurvival(int num)
    {
        survival += num; // if negative, it adds a negative, so it covers subtraction.
    }
    public int getSurvival()
    {
        return survival;
    }

    public void modifyAtheltics(int num)
    {
        Athletics += Athletics;
    }
    public int getAtheletics()
    {
        return Athletics;
    }

    public void modifyStealth(int num)
    {
        Stealth += num;
    }
    public int getStealth()
    {
        return Stealth;
    }

    public void modifyDodge(int num)
    {
       Dodge += num;
    }
    public int getDodge()
    {
        return Dodge;
    }

    public void modifySprint(int num)
    {
       Sprint += num;
    }
    public int getSprint()
    {
        return Sprint;
    }

    public void modifyThrow(int num)
    {
       Throw += num;
    }
    public int getThrow()
    {
        return Throw;
    }

    public void modifyGrapple(int num)
    {
       Grapple += num;
    }
    public int getGrapple()
    {
        return Grapple;
    }

    public void modifyIntimidate(int num)
    {
       Intimidate += num;
    }
    public int getIntimidate()
    {
        return Intimidate;
    }

    public void modifySenseMotive(int num)
    {
       SenseMotive += num;
    }
    public int getSenseMotive()
    {
        return SenseMotive;
    }

    public void modifyPersuade(int num)
    {
       Persuade += num;
    }
    public int getPersuade()
    {
        return Persuade;
    }

    public void modifyLie(int num)
    {
       Lie += num;
    }
    public int getLie()
    {
        return Lie;
    }

    public void modifyCrafting(int num)
    {
       Crafting += num;
    }
    public int getCrafting()
    {
        return Crafting;
    }

    public void modifyRepair(int num)
    {
       Repair += num;
    }
    public int getRepair()
    {
        return Repair;
    }

    public void modifyDefuse(int num)
    {
       Defuse += num;
    }
    public int getDefuse()
    {
        return Defuse;
    }

    public void modifyPerception(int num)
    {
       Perception += num;
    }
    public int getPerception()
    {
        return Perception;
    }

    public void modifyShootBig(int num)
    {
       ShootBig += num;
    }
    public int get()
    {
        return ShootBig;
    }

    public void modifyShootSmall(int num)
    {
        ShootSmall += num;
    }
    public int getShootSmall()
    {
        return ShootSmall;
    }


}

