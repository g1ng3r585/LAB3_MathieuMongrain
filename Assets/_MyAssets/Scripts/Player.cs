using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs
    [SerializeField]
    private float _vitesse = 150.0f;
    private Rigidbody _rb;



    public float decompte = 0f; // Définir la variable de décompte à 0
    public float forceY = 8000f; // Définir la force à appliquer dans l'axe Y


    bool jouer;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0f, 0.51f, -3f);
        _rb = GetComponent<Rigidbody>();
        jouer = true;
    }

    private void Update()
    {
        if (jouer == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _vitesse *= 2;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _vitesse /= 2;
            }

            if (decompte > 0) // Si le décompte est en cours
            {
                decompte -= Time.deltaTime; // Soustraire le temps écoulé depuis la dernière frame au décompte    
            }

            if (Input.GetKeyDown(KeyCode.Space) && decompte <= 0) // Si la touche espace est enfoncée et le décompte est à zéro
            {
                _rb.AddForce(0, forceY, 0); // Ajouter une force à l'objet Rigidbody dans l'axe Y
                decompte = 0.8f; // Définir le décompte à 3 secondes
            }
        }
    }

    private void FixedUpdate()
    {
        if (jouer == true)
        {
            _rb.AddForce(0, -20, 0);

            float positionX = Input.GetAxis("Horizontal");
            float positionZ = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(positionX, 0f, positionZ);
            direction.Normalize();

            //TP
            //transform.Translate(direction * Time.deltaTime * _vitesse);

            //Normal
            _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;

            //Glace
            //_rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);

            if (direction != Vector3.zero)
            {
                transform.forward = direction;
            }
        }
    }

    // Update is called once per frame
    public void Arret()
    {
        jouer = false;
    }
}
