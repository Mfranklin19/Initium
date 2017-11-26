using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour {

    public int spaceNumber;
    public GameObject target;

    public void OnMouseDown()
    {
        if (!Turn.tilePlaced && Turn.phase == 2)
        {
            Debug.Log("Selected tile # " + this.gameObject.name);
            target.SetActive(true);
            Debug.Log("Tile number: " + spaceNumber + " created");
            this.gameObject.SetActive(false);
            Turn.tilePlaced = true;
            Turn.player.hand.RemoveAt(0);
            Debug.Log("Player " + Turn.player.getNumber() + "'s hand Size: " + Turn.player.hand.Count);
        }
        else if (Turn.phase == 2) Debug.Log("You've already placed a tile this turn!");
    }


}
