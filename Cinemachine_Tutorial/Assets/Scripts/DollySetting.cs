using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DollySetting : MonoBehaviour
{
    CinemachineVirtualCamera vCam;

    void Start()
    {
        vCam = this.GetComponent<CinemachineVirtualCamera>();
        
        CinemachineTrackedDolly dolly = vCam.GetCinemachineComponent<CinemachineTrackedDolly>();
        
        dolly.m_AutoDolly.m_Enabled = true;
    }
}
