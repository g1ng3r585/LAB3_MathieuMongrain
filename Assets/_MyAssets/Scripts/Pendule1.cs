using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendule1 : MonoBehaviour
{
    [SerializeField]
    private GameObject target;



    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.back, 200 * Time.deltaTime);
    }
}
