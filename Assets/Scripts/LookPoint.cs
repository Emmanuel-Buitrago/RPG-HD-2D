using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPoint : MonoBehaviour
{
    public GameObject point;
    public float rotacionExtra;
    private GameObject attach;
    private void Start()
    {
        attach = GameObject.Find("Attach");
    }

    void Update()
    {
        attach.transform.LookAt(point.transform);
        gameObject.transform.rotation = Quaternion.Euler(0, attach.transform.rotation.eulerAngles.y+rotacionExtra, 0) ;

    }
}
