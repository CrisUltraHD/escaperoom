using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ordenador : MonoBehaviour
{
    //Windows Pass
    public GameObject panelContra;
    public InputField resposta;

    public GameObject panelTxt;
    //Ordinador escritori
    public GameObject wallpaper;


    // Start is called before the first frame update
    void Start()
    {
        panelContra.SetActive(false);
        panelTxt.SetActive(false);
        panelContra.SetActive(false);
        wallpaper.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (resposta.text.Equals("28"))
        {
            wallpaper.SetActive(true);
            resposta.text = "";
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ordenador")
        {
            panelContra.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Ordenador")
        {
            panelContra.SetActive(false);
            panelTxt.SetActive(false);
            panelContra.SetActive(false);
            wallpaper.SetActive(false);
        }
    }

    public void OpenTxt()
    {
        panelTxt.SetActive(true);
    }
}
