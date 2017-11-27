using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPopulator : MonoBehaviour {

    public int newValue;

	public void onClick()
    {
        Turn.populatingValue = newValue;
        Debug.Log("Populating value: " + Turn.populatingValue);
    }

}
