using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GestionChute : MonoBehaviour
{

    public float Threshold;

    private void Start()
    {
        Threshold = -2;
    }

    private void FixedUpdate()
    {
        if(transform.position.y < Threshold)
        {
            transform.position = new Vector3(0f, 0.51f, -3f);
        }
    }
}





