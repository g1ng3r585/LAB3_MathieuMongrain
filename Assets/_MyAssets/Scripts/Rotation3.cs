using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation3 : MonoBehaviour
{
    [SerializeField]
    private GameObject target;



    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.left, 50 * Time.deltaTime);
    }
}
