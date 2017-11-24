using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{


    public Text turnText;

    public void changeText(string newText)
    {
        turnText.text = newText;
    }

}
