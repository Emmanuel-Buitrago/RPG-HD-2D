using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHouseEvent : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GameObject.Find("CatSprite").GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.tag == "Player")
        {
            Debug.Log("El jugador interactua con la casa");
            animator.SetBool("Home",true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.tag == "Player")
        {
            Debug.Log("El jugador ya no interactua con la casa");
            animator.SetBool("Home", false);
        }

    }

}

