using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltimaPart : MonoBehaviour
{
    public Text textoPuerta;
    public GameObject canvas;
    public Image imagenLlave;
    public GameObject puerta;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        textoPuerta.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && imagenLlave.isActiveAndEnabled)
        {
            puerta.transform.localRotation = Quaternion.Euler(0, (float)83.70901, 0);
            canvas.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PuertaFinal" && imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Felicitats! Has trobat la clau final per poder acabar aquesta aventura! \n El teu personatge ja no necessitarà els llibres per estudiar, ja que \n ha après tot el que necessitava per al examen! \n Apreta 'P' per obrir la porta";
        }

        else if (other.gameObject.tag == "PuertaFinal" && !imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Has de trobar una clau \n per poder obrir la porta";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PuertaFinal")
        {
            canvas.SetActive(false);
        }
    }

}
