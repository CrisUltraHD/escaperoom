﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimacion : MonoBehaviour
{
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerAnimacionFinal")
        {
            anim.SetBool("personajeLlegado",true);
       
        }
    }

}
