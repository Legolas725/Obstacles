using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            int currentSceaneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceaneIndex);

        }

    }

    



}
