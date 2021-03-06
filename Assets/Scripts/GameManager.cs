﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool turnValue = true;
    public static bool inTurn = false;

    Player p1;
    Player p2;

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Turn>();
        gameObject.AddComponent<TextManager>();
        p1 = new Player(1);
        p2 = new Player(2);
        p1.generateDeck();
        p2.generateDeck();
    }

    // Update is called once per frame
    void Update()
    {
        if (turnValue && !inTurn) player1Turn();
        else if (!turnValue && !inTurn) player2Turn();
    }


    void player1Turn()
    {
        inTurn = true;
        gameObject.GetComponent<TextManager>().changeText("Player 1's turn");
        gameObject.GetComponent<Turn>().initializeTurn(p1);
    }


    void player2Turn()
    {
        inTurn = true;
        gameObject.GetComponent<TextManager>().changeText("Player 2's turn");
        gameObject.GetComponent<Turn>().initializeTurn(p2);
    }

    
}