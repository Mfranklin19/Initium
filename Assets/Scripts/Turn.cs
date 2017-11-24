using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{

    static Player player;
    public static int phase = 0;
    static bool looping = true;
    public static bool tilePlaced = false;

    private void Start()
    {
        gameObject.AddComponent<TextManager>();
    }
    

    // receives a Player object from the GameManager script, and initializes a turn for that player.
    public void initializeTurn(Player p)
    {
        player = p;
        StartCoroutine(drawPhase());
    }



    // players draw a tile and place a tile on the board. this phase is skipped if the player has no more tiles to place
    IEnumerator drawPhase()
    {
        gameObject.GetComponent<TextManager>().changePhase("Draw Phase");
        phase++;
        while (looping)
        {

            yield return null;
        }
        

        yield return new WaitForSeconds(1f);
        StartCoroutine(populatingPhase());

    }

    // Phase where players populate their board, based on how many population points they have
    IEnumerator populatingPhase()
    {
        looping = true;
        gameObject.GetComponent<TextManager>().changePhase("Populating Phase");
        phase++;
        while (looping)
        { 
            yield return null;
        }
        

        yield return new WaitForSeconds(1f);

        StartCoroutine(movementPhase());
    }

    // Phase where players move their tokens and attempt to capture tiles on the board. Combat subphase is called from
    // within the movement phase
    IEnumerator movementPhase()
    {
        phase++;
        looping = true;
        gameObject.GetComponent<TextManager>().changePhase("Movement Phase");

        while (looping)
        {
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        resetTurn();

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
        phase = 0;
    }
}
