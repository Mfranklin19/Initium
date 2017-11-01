using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    bool settled = false;
    Player owner;
    Piece[] occupants = new Piece[8]; // max number of 8 occupants per tile, 4 buildings 4 people
    int capturePoints = 0;
    public int neededCP;
    bool isFull = false;
	
	// Update is called once per frame
	void Update () {
        if (!settled) isSettled(); 
	}


    // Needs to run at the end of each phase, not each frame
    void isSettled()
    {
        for (int i = 0; i < 4; i++)
        {
            if (occupants[i] != null) capturePoints++;
        }
        if (capturePoints >= neededCP) settled = true;
        else capturePoints = 0;
    }

    Piece[] getOccupents()
    {
        return occupants;
    }

}
