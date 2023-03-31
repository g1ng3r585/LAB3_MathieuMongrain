using System.Collections;
using UnityEngine;

public class PlateformesTombantes : MonoBehaviour
{
    public float tempsAvantChute = 1.0f; // Temps avant que la dalle tombe après contact (en secondes)
    public float vitesseChute = 10.0f; // Vitesse de chute de la dalle (en unités par seconde)
    public bool estTombee = false; // Indique si la dalle est tombée ou non

    public class Dalle : MonoBehaviour
    {
        public float delay = 1.0f; // Délai avant d'activer la gravité
        private bool isTriggered = false; // Booléen pour vérifier si le joueur a déjà touché l'objet

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && !isTriggered)
            {
                StartCoroutine(ActivateGravity());
                isTriggered = true;
            }
        }

        IEnumerator ActivateGravity()
        {
            yield return new WaitForSeconds(delay);
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}