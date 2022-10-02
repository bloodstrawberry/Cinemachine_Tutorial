using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PrioritySetting : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineBlendListCamera vCam2;
    public CinemachineFreeLook vCam3;

    public float time = 2.0f;

    public void GoToVCam1()
    {
        vCam1.MoveToTopOfPrioritySubqueue();
    }

    public void GoToVCam2()
    {
        vCam2.MoveToTopOfPrioritySubqueue();
    }

    public void GoToVCam3()
    {
        vCam3.MoveToTopOfPrioritySubqueue();
    }
}
