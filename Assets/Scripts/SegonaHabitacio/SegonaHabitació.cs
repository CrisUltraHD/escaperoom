using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SegonaHabitació : MonoBehaviour
{

    public GameObject panelLlaves;
    public GameObject imagenLlave;

    //EL NUMERO DE LA CLAU QUE USU INSEREIX
    public Text numClau;

    // Start is called before the first frame update
    void Start()
    {
        panelLlaves.SetActive(false);
        imagenLlave.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CAJONPARTE2") 
        {
            panelLlaves.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CAJONPARTE2")
        {
            panelLlaves.SetActive(false);
        }
    }

    //BOTÓ VALIDAR
    //CORRECTA ES 1
    public void Validar()
    {
        if (numClau.text.Equals("1"))
        {
            imagenLlave.SetActive(true);
        }

        else
        {
            numClau.text = "";
        }

    }
}
