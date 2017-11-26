using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

  
    public int victoryPoints;
    public Color color;
    public List<Tile> hand = new List<Tile>();

    string name;
    int playerNumber;
    Stack<Tile> tileDeck = new Stack<Tile>();
    static System.Random rng = new System.Random();

    public Player(int playerNumber)
    {
        this.playerNumber = playerNumber;
        name = "Player " + playerNumber;
    }

    //generates the deck of tiles for the player.
    public void generateDeck()
    {
        for (int i = 0; i < 8; i++)
        {
            tileDeck.Push(new Tile(i));
            Debug.Log(tileDeck.Peek().ToString());
        }

        shuffleDeck();

    }


    // Draws the top tile of the deck 
    public void drawTile()
    {
        Tile temp = tileDeck.Pop();
        hand.Add(temp);
        Debug.Log(temp.neededCP + " tile drawn");
        Debug.Log("Player " + playerNumber + "'s hand size: " + hand.Count);
    }

    //public method to return the name of the player
    public string getName()
    {
        return name;
    }

    // public method for getting the number value of the player
    public int getNumber()
    {
        return playerNumber;
    }

    // called after each draw phase and on creation of the player to shuffle the elements in their deck
    public void shuffleDeck() 
    {
        List<Tile> temp = new List<Tile>();
        
        while (tileDeck.Count != 0)
        {
            
            temp.Add(tileDeck.Pop());
        }

        temp = Shuffle(temp);

        foreach (Tile t in temp) tileDeck.Push(t);

    }

    // method for shffling elements in a list. called from shuffleDeck() to shuffle the temp list created in that method
    public List<Tile> Shuffle(List<Tile> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Tile value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

        return list;

    }
}