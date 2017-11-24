using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool turnValue = true;
    public static bool inTurn = false;

    Player p1 = new Player(1);
    Player p2 = new Player(2);

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Turn>();
        
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
        gameObject.GetComponent<Turn>().initializeTurn(p1);
    }


    void player2Turn()
    {
        inTurn = true;
        gameObject.GetComponent<Turn>().initializeTurn(p2);
    }

    
}