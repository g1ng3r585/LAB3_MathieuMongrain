using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenduleTest : MonoBehaviour
{
    public float amplitude = 1f; // Amplitude du mouvement de la hache
    public float speed = 1f; // Vitesse de rotation de la hache
    public float arcHeight = 2f; // Hauteur maximale de l'arc
    public float arcLength = 4f; // Longueur de l'arc
    public Vector3 axis = Vector3.up; // Axe de pivot

    private Quaternion startRotation; // Rotation de départ de la hache

    void Start()
    {
        startRotation = transform.rotation; // Sauvegarde de la rotation de départ de la hache
    }

    void Update()
    {
        float angle = amplitude * Mathf.Sin(speed * Time.time); // Calcul de l'angle de rotation de la hache

        float t = Time.time % (Mathf.PI / speed) * speed; // Calcul du temps écoulé depuis le début du mouvement

        Vector3 pos = new Vector3(t / (Mathf.PI / speed) * arcLength - arcLength / 2f, Mathf.Sin(t) * arcHeight, 0f); // Calcul de la position de la hache

        Quaternion rotation = Quaternion.AngleAxis(angle, axis.normalized); // Calcul de la rotation de la hache

        transform.rotation = startRotation * rotation; // Mise à jour de la rotation de la hache
        transform.localPosition = pos; // Mise à jour de la position de la hache
    }

}
