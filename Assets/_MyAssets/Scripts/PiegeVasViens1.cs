using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeVasViens1 : MonoBehaviour
{
    [SerializeField]
    float distanceToCover = 0.5f;
    [SerializeField]
    float speed = 1.5f;

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void Update()
    {
        Vector3 v = startingPosition;
        v.x += distanceToCover * Mathf.Sin(Time.time*speed);
        transform.position = v;
    }
}
