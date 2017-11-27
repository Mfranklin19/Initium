using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSelected : MonoBehaviour {

	public void OnMouseDown()
    {
        if (Turn.populatingValue == 1 && Turn.resources > 0)
        {
            Turn.resources--;
            Debug.Log("Resources remaining: " + Turn.resources);
            this.gameObject.SetActive(false);
        }
    }

}
