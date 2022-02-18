using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //variables up top
    /*
     multi line power
    */
    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqlapProgress = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuel we have
        //if we still have more than zero fuel, let's go
        if(fuel > 0)
        {
            //we have fuel
            //increase our progress and decerase our fuel
            lapProgress += 5; //increase by 1
            fuel--;
        }
        else
        {
            //we don't have fuel
            Debug.Log("We've run out of fuel!");
        }
        //is our current progress, equal to or higher than the required progress
        if (lapProgress >= reqlapProgress)
        {
            //if it is, increase our lap count and reset our current progress
            laps++; //increase laps by 1
            lapProgress = 0; //reset our lap
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Completed Laps: " + laps);
    }

}
