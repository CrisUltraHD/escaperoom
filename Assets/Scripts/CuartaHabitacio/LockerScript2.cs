﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LockerScript2 : MonoBehaviour
{
    //SOLUCION ENIGMA MATEMATICO
    private string codi = "1879";

    //TEXTO QUE MOSTRARA VALOR INTRODUCIDO Y RESULTADO CORRECTO O NO
    public Text pantalla;

    //Gameobject de la puerta
    public GameObject puerta1;


    private void Start()
    {
        pantalla.text = "";
    }

    private void Update()
    {
        //Si el codigo que introduce es correcto cambia la posicion de la puerta para que se abra
        if (pantalla.text.Equals(codi))
        {
            Debug.Log("adasdsadasdsad");
            puerta1.transform.localRotation = Quaternion.Euler(0, (float)83.70901, 0);
        }
    }


    public void boton1()
    {
        pantalla.text = pantalla.text + "1";
    }

    public void boton2()
    {
        pantalla.text = pantalla.text + "2";
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

    public void boton0()
    {
        pantalla.text = pantalla.text + "0";
    }

    public void botonBorrar()
    {
        pantalla.text = "";
    }


}

