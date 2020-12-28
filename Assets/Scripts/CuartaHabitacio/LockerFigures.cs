using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LockerFigures : MonoBehaviour
{
    //SOLUCION ENIGMA MATEMATICO
    private string codi = "39456";

    //TEXTO QUE MOSTRARA VALOR INTRODUCIDO Y RESULTADO CORRECTO O NO
    public Text pantalla;

    //Gameobject de la llave
    public GameObject llave;


    private void Start()
    {
        pantalla.text = "";
        llave.SetActive(false);
    }

    private void Update()
    {
        //Si el codigo que introduce es correcto cambia la posicion de la puerta para que se abra
        if (pantalla.text.Equals(codi))
        {
            llave.SetActive(true);
        }
    }


    public void boton3()
    {
        pantalla.text = pantalla.text + "3";
    }

    public void boton4()
    {
        pantalla.text = pantalla.text + "4";
    }

    public void boton5()
    {
        pantalla.text = pantalla.text + "5";
    }

    public void boton6()
    {
        pantalla.text = pantalla.text + "6";
    }

    public void boton7()
    {
        pantalla.text = pantalla.text + "7";
    }

    public void boton8()
    {
        pantalla.text = pantalla.text + "8";
    }

    public void boton9()
    {
        pantalla.text = pantalla.text + "9";
    }

    public void botonBorrar()
    {
        pantalla.text = "";
    }


}
