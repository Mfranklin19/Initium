using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    Transform transform;

    public bool settled = false;
    public Player owner;
    public Piece[] occupants = new Piece[8]; // max number of 8 occupants per tile, 4 buildings 4 people
    public int capturePoints = 0;
    public int neededCP;
    public bool isFull = false;

    public Tile(int neededCP)
    {
        this.neededCP = neededCP;
    }


    // Needs to run at the end of each phase, not each frame
    public void isSettled()
    {
        for (int i = 0; i < 4; i++)
        {
            // if (occupants[i] != null) capturePoints++;
        }
        if (capturePoints >= neededCP) settled = true;
        else capturePoints = 0;
    }

    Piece[] getOccupents()
    {
        return occupants;
    }

}
