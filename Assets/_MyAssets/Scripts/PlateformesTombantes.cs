using System.Collections;
using UnityEngine;

public class PlateformesTombantes : MonoBehaviour
{
    public float tempsAvantChute = 1.0f; // Temps avant que la dalle tombe apr�s contact (en secondes)
    public float vitesseChute = 10.0f; // Vitesse de chute de la dalle (en unit�s par seconde)
    public bool estTombee = false; // Indique si la dalle est tomb�e ou non

    public class Dalle : MonoBehaviour
    {
        public float delay = 1.0f; // D�lai avant d'activer la gravit�
        private bool isTriggered = false; // Bool�en pour v�rifier si le joueur a d�j� touch� l'objet

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