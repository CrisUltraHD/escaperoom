using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CuartaHabitacio : MonoBehaviour
{

    public Canvas locker;

    public Canvas lockerCajon;


    private void Start()
    {
        //LOCKER
        locker.enabled = false;
        lockerCajon.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //LOCKER
        if (other.gameObject.tag == "lock2")
        {
            locker.enabled = true;
        }

        //CAJON
        if (other.gameObject.tag == "CAJONHABITACION4")
        {
            lockerCajon.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        locker.enabled = false;
        lockerCajon.enabled = false;
    }

}
