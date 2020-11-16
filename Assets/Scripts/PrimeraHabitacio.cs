using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrimeraHabitacio : MonoBehaviour
{

    public Canvas clipboard;

    public Canvas locker;

    private void Start()
    {
        //CLIPBOARD
        clipboard.enabled = false;

        //LOCKER
        locker.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {   //CLIPBOARD
        if (other.gameObject.tag == "clipboard")
        {
            clipboard.enabled = true;
        }

        //LOCKER
        if (other.gameObject.tag == "lock1")
        {
            locker.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        clipboard.enabled = false;

        locker.enabled = false;
    }

}
