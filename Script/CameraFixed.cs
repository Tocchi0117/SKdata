using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixed : MonoBehaviour
{
    public GameObject VRCamera;
    public GameObject VRScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //VRCamera.transform.position = new Vector3(0, 0, 0);
        VRScreen.transform.position = VRCamera.transform.position;
    }
}
