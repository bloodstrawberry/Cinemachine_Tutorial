using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PrioritySetting : MonoBehaviour
{
    public CinemachineVirtualCamera vCam;
    public CinemachineBlendListCamera blendListCam;
    public CinemachineFreeLook freeLookCam;

    public void buttonVirtual()
    {
        vCam.Priority = 11;
        blendListCam.Priority = 10;
        freeLookCam.Priority = 10;
    }

    public void buttonBlendList()
    {
        vCam.Priority = 10;
        blendListCam.Priority = 11;
        freeLookCam.Priority = 10;
    }

    public void buttonFreeLook()
    {
        vCam.Priority = 10;
        blendListCam.Priority = 10;
        freeLookCam.Priority = 11;
    }
}
