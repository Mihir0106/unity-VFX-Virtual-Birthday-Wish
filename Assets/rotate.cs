using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     //   StartCoroutine("Rotate");
    }
/*
    IEnumerator Rotate()
    {
        Vector3 rotate = transform.rotation.eulerAngles;
        rotate.y += 0.1f;

        gameObject.GetComponent<Transform>().rotation.y =  rotate.y;
    }*/
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0.5f, 0f, Space.Self); 
    }
}
