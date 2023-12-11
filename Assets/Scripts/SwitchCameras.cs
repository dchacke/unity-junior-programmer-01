using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public Camera mainCamera;
    public Camera alternativeCamera;

    // Start is called before the first frame update
    void Start()
    {
        alternativeCamera.enabled = false;
        Debug.Log("mainCamera: " + mainCamera.enabled + " alternativeCamera: " + alternativeCamera.enabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("x"))
        {
            mainCamera.enabled = !mainCamera.enabled;
            alternativeCamera.enabled = !alternativeCamera.enabled;
            Debug.Log("mainCamera: " + mainCamera.enabled + " alternativeCamera: " + alternativeCamera.enabled);
        }
    }
}
