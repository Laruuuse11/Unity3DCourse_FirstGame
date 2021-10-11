using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int iloscUderzen = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            iloscUderzen++;
            Debug.Log("Uderzyłeś w ścianę: " + iloscUderzen + " razy");
        }
    }
}
