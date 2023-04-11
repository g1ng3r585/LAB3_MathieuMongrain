using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private bool _finPartie = false;
    private GestionJeu _gestionJeu;
    private Player _player;
    private GestionJeu _pointage;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
        _pointage = FindObjectOfType<GestionJeu>();
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Player") && !_finPartie)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
            if (noScene == (SceneManager.sceneCountInBuildSettings - 2))  // Si nous somme sur le dernier niveau de jeu
            {
                _gestionJeu.SetTempsFinal(Time.time);
                SceneManager.LoadScene(noScene + 1);
            }
            else
            {
                // Appelle la méthode publique dans gestion jeu pour conserver les informations du niveau 1
                //_gestionJeu.SetNiveau1(_gestionJeu.GetPointage(), Time.time);
                // Charge la scène suivante
                SceneManager.LoadScene(noScene + 1);
            }
        }
    }
}
