using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

    Player player;


    // method that calls each phase of the turn sequentially
    void initializeTurn(Player p)
    {
        player = p;
        drawPhase();
        populatingPhase();
        movementPhase();
    }

    // players draw a tile and place a tile on the board. this phase is skipped if the player has no more tiles to place
    void drawPhase()
    {

    }

    // Phase where players populate their board, based on how many population points they have
    void populatingPhase()
    {

    }

    // Phase where players move their tokens and attempt to capture tiles on the board. Combat subphase is called from
    // within the movement phase
    void movementPhase()
    {

    }

    // called when players initiate combat by moving to a tile occupied by the opponent
    void combatPhase()
    {

    }
}
