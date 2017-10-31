using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    public Player owner;
    int captureValue;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // takes a tile object and attempts to move the selected piece to that tile.
    // Does not work if the tile is full.
    public void movePiece(Tile tile)
    {
        
    }
}
