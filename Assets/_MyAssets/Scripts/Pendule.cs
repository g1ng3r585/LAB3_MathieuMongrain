using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendule : MonoBehaviour
{
    [SerializeField]
    private GameObject target;



    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.back, 100 * Time.deltaTime);
    }
}
