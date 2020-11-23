using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccioPersonatje : MonoBehaviour
{

    public GameObject male;
    public GameObject female;
    public GameObject otherObjects;
    public GameObject camaraMenu;
    public GameObject panelPersonatje;


    private void Start()
    {
        panelPersonatje.SetActive(true);
        camaraMenu.SetActive(true);
        otherObjects.SetActiveRecursively(false);
        female.SetActive(false);
        male.SetActive(false);
    }

    public void maleEnable()
    {
        panelPersonatje.SetActive(false);
        camaraMenu.SetActive(false);
        otherObjects.SetActiveRecursively(true);
        male.SetActive(true);
        female.SetActive(false);
    }

    public void femaleEnable()
    {
        panelPersonatje.SetActive(false);
        camaraMenu.SetActive(false);
        otherObjects.SetActiveRecursively(true);
        female.SetActive(true);
        male.SetActive(false);
    }
}
