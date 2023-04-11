using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    [SerializeField] private GameObject _menuInstruction = default;
    bool _active = false;


    public void ChangerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
        SceneManager.LoadScene(noScene + 1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    public void Instruction()
    {
        if (_active == false)
        {
            _menuInstruction.SetActive(true);
            _active = true;
        }
        else
        {
            _menuInstruction.SetActive(false);
            _active = false;
        }
    }

 

}
