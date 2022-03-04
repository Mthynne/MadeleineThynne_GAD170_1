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
        {
            //An interaction called by a button press
            if (Input.GetKeyDown(KeyCode.I))
            {
                Interaction();
            }
        }
        // check how much health we have
        // if we have more than zero health, continue
        if (health > 0)
        {
            //continue
            health += 5; //increase by 1
            level--;
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
        Debug.Log("Current health: " + health);
        Debug.Log("Completed Level: " + level);
    }

    public void InitialStats()
    {
        //Initialised stats, level, xp, reqxp etc
        health = 25.0f;
        defense = 20.0f;
        speed = 10.0f;
        attack = 20.0f;

        level = 0;
        curXP = 0f;
        reqXP = 100f;
    }
    public void Interaction()
    {
        //An interaction called by a button press
        if (Input.GetKeyDown(KeyCode.I))
        {
            GainXP();
            Debug.Log("You have drunk a mystery potion! Stats all increased.");
        }
    }

    public void GainXP() //GainProgress
    {
        //increase our current xp
        curXP += level;
        Debug.Log("XP Gained: " + level);
        Debug.Log("Current XP: " + curXP);

    }


    public void LevelUp() //Completed lap
    {
        //update our level
        level += 1;
        //update curxp
        curXP = 0f;
        //update reqxp
        reqXP *= 1.15f;
        //update stats
        health += 1;
        defense += 1;
        speed += 1;
        attack += 1;
        Debug.Log("Leveled up to level " + level);
        Debug.Log("Stats all increased!");
    }


    public void IncreaseStats()
    {
        //increase stats
        health += 2;
        defense += 2;
        speed += 2;
        attack += 2;
    }






}
