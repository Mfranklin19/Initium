using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    int victoryPoints;
    Color color;
    string name;
    Stack<Tile> tileDeck;
    public List<Tile> hand;
    int playerNumber;

    public Player(int playerNumber)
    {
        this.playerNumber = playerNumber;
        name = "Player " + playerNumber;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    // Draws the top tile of the deck 
    void drawTile()
    {
        hand.Add(tileDeck.Pop());
    }

    public string getName()
    {
        return name;
    }

    public int getNumber()
    {
        return playerNumber;
    }
}
