using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{

    static Player player;
    static bool looping = true;
    public static bool tilePlaced = false;

   
    // receives a Player object from the GameManager script, and initializes a turn for that player.
    public void initializeTurn(Player p)
    {
        player = p;
        StartCoroutine(drawPhase());
    }



    // players draw a tile and place a tile on the board. this phase is skipped if the player has no more tiles to place
    IEnumerator drawPhase()
    {
        Debug.Log("Entering Draw Phase");
        

        while (looping)
        {
            Debug.Log(looping);
            yield return null;
        }
        

        yield return new WaitForSeconds(1f);

        Debug.Log("Draw Phase Finished");

        StartCoroutine(populatingPhase());

    }

    // Phase where players populate their board, based on how many population points they have
    IEnumerator populatingPhase()
    {
        looping = true;

        Debug.Log("Entering Population Phase");

        while (looping)
        { 
            yield return null;
        }
        

        yield return new WaitForSeconds(1f);

        Debug.Log("Populating Phase Finished");

        StartCoroutine(movementPhase());
    }

    // Phase where players move their tokens and attempt to capture tiles on the board. Combat subphase is called from
    // within the movement phase
    IEnumerator movementPhase()
    {

        looping = true;

        Debug.Log("Entering Movement Phase");

        while (looping)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        resetTurn();
        Debug.Log("Movement Phase Finished");
        Debug.Log("Turn is now finished");

    }
    

    // called when players initiate combat by moving to a tile occupied by the opponent
    void combatPhase()
    {

    }


    // simple get function for the player object
    public Player getPlayer()
    {
        return player;
    }


    // Called when the advance phase button is clicked
    public void onClick()
    {
        looping = false;
    }


    // Resets the static values to prepare for the next player's turn
    public void resetTurn()
    {
        if (player.getNumber() == 1) GameManager.turnValue = false;
        else GameManager.turnValue = true;
        GameManager.inTurn = false;
        looping = true;
        tilePlaced = false;
        Debug.Log("Values Reset");
    }
}
