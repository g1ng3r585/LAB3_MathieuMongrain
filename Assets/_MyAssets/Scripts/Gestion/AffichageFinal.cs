using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AffichageFinal : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtNbrAccrochage = default;
    [SerializeField] private TMP_Text _txtPointageFinal = default;
    private GestionJeu _gestionJeu;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _gestionJeu.SetTempsFinal(Time.time);
        _txtTempsTotal.text = "Temps Total : " + _gestionJeu.GetTempsFinal().ToString("f2") + " sec.";
        _txtNbrAccrochage.text = "Nombres d'accrochages : " + _gestionJeu.GetPointage().ToString();
        float pointageTotal = _gestionJeu.GetTempsFinal() + _gestionJeu.GetPointage();
        _txtPointageFinal.text = "Pointage Final : " + pointageTotal.ToString("f2") + " sec.";
    }
}
