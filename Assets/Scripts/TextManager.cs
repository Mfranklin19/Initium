using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    
    public Text turnText;
    public Text phaseText;
    public Text placementWarning;
    public GameObject popPhaseCanvas;


    // Method that changes the text that indicates which player's turn it is
    public void changeText(string newText)
    {
        turnText.text = newText;
    }

    // Method that changes the text indicating which phase of the turn it is
    public void changePhase(string newText)
    {
        phaseText.text = newText;
    }

    // Method to flash a warning when a player attempts to perform an action that is not allowed or not possible
    public void flashWarning()
    {

    }


    // Method to active the UI elements necessary for the population phase
    public void activatePopCanvas()
    {
        popPhaseCanvas.SetActive(true);
    }


    // Method to deactivate the UI elements necessary for the populaton phase
    public void deactivatePopCanvas()
    {
        popPhaseCanvas.SetActive(false);
    }
}
