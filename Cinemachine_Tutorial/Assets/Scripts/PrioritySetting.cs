using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PrioritySetting : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1, vCam2, vCam3;

    public float time = 2.0f;

    public void GoToVCam3()
    {
        vCam3.Priority = 12;
    }

    public void SwitchCamera()
    {
        vCam2.Priority = 11;
        Invoke("GoToVCam3", time);
    }

    public void RollBack()
    {
        vCam1.Priority = 10;
        vCam2.Priority = 9;
        vCam3.Priority = 9;
    }
}
