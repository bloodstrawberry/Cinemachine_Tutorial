using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DollySetting : MonoBehaviour
{
    CinemachineVirtualCamera vCam;
    public CinemachineDollyCart cart;

    void Start()
    {
        vCam = this.GetComponent<CinemachineVirtualCamera>();
        
        CinemachineTrackedDolly dolly = vCam.GetCinemachineComponent<CinemachineTrackedDolly>();
        
        dolly.m_AutoDolly.m_Enabled = true;

        cart.m_Speed = 5.0f; // 카트 속도 조정
    }
}
