using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CuartaHabitacio : MonoBehaviour
{

    public Canvas locker;

    private void Start()
    {
        //LOCKER
        locker.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        //LOCKER
        if (other.gameObject.tag == "lock2")
        {
            locker.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        locker.enabled = false;
    }

}
