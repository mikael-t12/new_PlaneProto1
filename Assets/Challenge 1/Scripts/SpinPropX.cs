using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropX : MonoBehaviour
{
    //Definte the rotation speed of the propeller
    float rotationSpeed = 3000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the propeller
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
