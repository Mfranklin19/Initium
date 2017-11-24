using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour {

    public int spaceNumber;
    public GameObject target;

    public void OnMouseDown()
    {
        if (!Turn.tilePlaced)
        {
            Debug.Log("Selected tile # " + this.gameObject.name);
            target.SetActive(true);
            Debug.Log("Tile number: " + spaceNumber + " created");
            this.gameObject.SetActive(false);
            Turn.tilePlaced = true;
        }
        else Debug.Log("You've already placed a tile this turn!");
    }


}
