using System.Collections;
using UnityEngine;

public class PlateformesTombantes1 : MonoBehaviour
{

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        _rb.AddForce(0,1, 0);
    }



    


}