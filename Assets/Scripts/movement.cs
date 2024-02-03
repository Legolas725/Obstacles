using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField]
    float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        float Xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;

        float Zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(Xvalue,0,Zvalue);
    }
}
