using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    int victoryPoints;
    Color color;
    string name;
    Stack<Tile> tileDeck;
    List<Tile> hand;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // Draws the top tile of the deck 
    void drawTile()
    {
        hand.Add(tileDeck.Pop());
    }
}
