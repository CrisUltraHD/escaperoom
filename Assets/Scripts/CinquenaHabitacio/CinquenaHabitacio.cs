using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinquenaHabitacio : MonoBehaviour
{
    public Text textoPuerta;
    public GameObject canvas;
    public Image imagenLlave;
    public GameObject puerta;

    //Caja Fuerte
    public Canvas locker;
    public GameObject llaveInsideCaja;
    public GameObject imagenLlaveCajaFuerte;

    //Enigma
    public GameObject enigmaGameObject;
    public Text enigmaText;
    public Text enunciatEnigma;



    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        textoPuerta.text = "";
        //LOCKER
        locker.enabled = false;
        imagenLlaveCajaFuerte.SetActive(false);
        //Enigma GameObject
        enigmaGameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && imagenLlave.isActiveAndEnabled)
        {
            puerta.transform.localRotation = Quaternion.Euler(0, -(float)83.70901, 0);
            canvas.SetActive(false);
        }

        //SI ENCERTA L'ENIGMA ET DONA EL CODI PER OBRIR LA CAIXA FORTA
        if (enigmaText.text.Equals("10"))
        {
            enunciatEnigma.text = "Codi Caixa Forta: 4698";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PUERTAHABITACION5" && imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Molt Be! \n Has trobat la clau per obrir aquesta porta! \n Presiona 1 cop la tecla 'E' per obrir la porta i continuar l'aventura";
        }

        else if (other.gameObject.tag == "PUERTAHABITACION5" && !imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Has de trobar una clau \n per poder obrir la porta i continuar l'aventura";
        }

        //LOCKER
        if (other.gameObject.tag == "lock3")
        {
            locker.enabled = true;
        }

        //Si choca con el collider de la llave desaparece y aparece en el inventario
        if (other.gameObject.tag == "ColliderLlave")
        {
            Destroy(llaveInsideCaja);
            imagenLlaveCajaFuerte.SetActive(true);
        }

        //Si choca con el collider de la llave desaparece y aparece en el inventario
        if (other.gameObject.tag == "ColliderCajaFuerteEnigma")
        {
            enigmaGameObject.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PUERTAHABITACION5")
        {
            canvas.SetActive(false);
        }
        locker.enabled = false;
        enigmaGameObject.SetActive(false);

    }
}
