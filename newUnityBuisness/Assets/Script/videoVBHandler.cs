using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class videoVBHandler : MonoBehaviour , IVirtualButtonEventHandler {

    public GameObject videoGO;

   

    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        videoGO.SetActive(false);
        GameObject.Find("VideoPlane").SetActive(false);
        Debug.Log("Plane Deactivated");


    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       
            videoGO.SetActive(true);
        GameObject.Find("VideoPlane").SetActive(true);

        Debug.Log("Video Plane Activated");

       

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("virtual button relased");
    }

}
