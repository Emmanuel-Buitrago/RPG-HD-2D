using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamaraPlaneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public new GameObject camera;
    float alturaCamara;
    float wtfx; 
    float wtfz;

    void Start()
    {
        alturaCamara = 31.2f;
        camera.transform.position = new Vector3(camera.transform.localPosition.x + transform.position.x, alturaCamara, camera.transform.localPosition.z + transform.position.z);
        wtfx = camera.transform.localPosition.x;
        wtfz = camera.transform.localPosition.z;
    }


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.transform.position);
        transform.Rotate(-90f, 0f, 180f, Space.Self);
        Debug.Log("inicial "+camera.transform.position.x);

            Debug.Log("final " + camera.transform.position.x);
    }
}
