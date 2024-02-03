using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int hitpoint = 0;

    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.tag != "Hit")
        {
            hitpoint++;
            Debug.Log("you have bumped in obstacle : " + hitpoint);
        }
    }
}
