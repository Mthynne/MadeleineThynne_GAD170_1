using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level; //laps variable

    public float curXP = 0.0f; //curLapProgress
    public float reqXP = 100.0f; //req lap progress

    //stats variables (to be tracked and modified upon level up)
    public float health = 25.0f;
    public float defense = 20.0f;
    public float speed = 10.0f;
    public float attack = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check how much health we have
        // if we have more than zero health, continue
        if (health > 0)
        {
            //continue
        }
        else
        {
            //we don't have health
            Debug.Log("We don't have anymore health!");
        }
        //if our current xp is equal to or higher than the required xp
        if (curXP >= reqXP)
        {
            // if it is, increase level count and reset current progress
            level++; //increase level by 1
            curXP = 0; //reset the xp
        }
        
    }

    public void InitialStats()
    {
        //Initialised stats, level, xp, reqxp etc
    }

    public void Interaction(int exp)
    {
        //An interaction called by a button press
    }

    public void GainXP(int amount) //GainProgress
    {
        //increase our current xp
    }

    public void LevelUp() //Completed lap
    {
        //increase our level

    }


    public void IncreaseStats()
    {
        //increase stats
    }
}
