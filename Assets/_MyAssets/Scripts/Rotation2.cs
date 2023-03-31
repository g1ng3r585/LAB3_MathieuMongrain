using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    [SerializeField]
    private GameObject target;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 100 * Time.deltaTime);

        transform.RotateAround(target.transform.position, Vector3.back, 28 * Time.deltaTime);
    }
}
