using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerceraHabitacio : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.F) && imagenLlave.isActiveAndEnabled)
        {
            puerta.transform.localRotation = Quaternion.Euler(0, (float)83.70901, 0);
            canvas.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "puertaHabitacion3" && imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Molt Be! \n Has trobat la clau per obrir aquesta porta! \n Presiona 1 cop la tecla 'F' per obrir la porta i continuar l'aventura";
        }

        else if (other.gameObject.tag == "puertaHabitacion3" && !imagenLlave.isActiveAndEnabled)
        {
            canvas.SetActive(true);
            textoPuerta.text = "Has de trobar una clau \n per poder obrir la porta i continuar l'aventura";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "puertaHabitacion3")
        {
            canvas.SetActive(false);
        }
    }


}
