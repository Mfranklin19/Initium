using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    bool settled = false;
    string owner;
    string[] occupants = new string[4];
    int capturePoints = 0;
    public int neededCP;
	
	// Update is called once per frame
	void Update () {
        if (!settled) isSettled();
	}

    void isSettled()
    {
        for (int i = 0; i < 4; i++)
        {
            if (occupants[i] != null) capturePoints++;
        }
        if (capturePoints >= neededCP) settled = true;
        else capturePoints = 0;
    }

}
