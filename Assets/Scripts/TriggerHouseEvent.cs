using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHouseEvent : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.tag == "Player")
        {
            Debug.Log("El jugador interactua con la casa");
        }

    }

}

