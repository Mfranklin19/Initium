using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    
    public Text turnText;
    public Text phaseText;
    public Text placementWarning;

    public void changeText(string newText)
    {
        turnText.text = newText;
    }

    public void changePhase(string newText)
    {
        phaseText.text = newText;
    }

    public void flashWarning()
    {

    }
}
