using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegonaHabitació : MonoBehaviour
{

    public GameObject panelLlaves;

    // Start is called before the first frame update
    void Start()
    {
        panelLlaves.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player") 
        {
            panelLlaves.SetActive(true);
        }
    }
}
