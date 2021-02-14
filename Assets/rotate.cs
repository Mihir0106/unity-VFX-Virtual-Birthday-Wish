using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float ySpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, ySpeed, 0f, Space.Self); 
    }
}
