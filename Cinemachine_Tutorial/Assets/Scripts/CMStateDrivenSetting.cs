using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEditor.Animations;

public class CMStateDrivenSetting : MonoBehaviour
{
    public GameObject player, ground;

    Animator animator;

    CinemachineStateDrivenCamera stateDriven;

    GameObject vCamObj1;
    GameObject vCamObj2;
    CinemachineVirtualCameraBase vCam1;
    CinemachineVirtualCameraBase vCam2;

    void Start()
    {
        animator = player.GetComponent<Animator>();
        stateDriven = this.GetComponent<CinemachineStateDrivenCamera>();

        vCamObj1 = GameObject.Find("CM vcam1");
        vCamObj2 = GameObject.Find("CM vcam2");

        vCam1 = vCamObj1.GetComponent<CinemachineVirtualCameraBase>();
        vCam2 = vCamObj2.GetComponent<CinemachineVirtualCameraBase>();

        vCam1.Follow = ground.transform;
        vCam1.LookAt = ground.transform;
        vCam2.LookAt = player.transform;

        vCamObj1.transform.SetParent(this.transform);
        vCamObj2.transform.SetParent(this.transform);
        
        //stateDriven.m_Instructions[0].m_FullHash = Animator.StringToHash("Base Layer.InAir");
        //stateDriven.m_Instructions[1].m_FullHash = Animator.StringToHash("Base Layer.Idle Walk Run Blend");

        stateDriven.m_Instructions[0].m_FullHash = -1184316583;
        stateDriven.m_Instructions[1].m_FullHash = 2133340701;

        stateDriven.m_Instructions[0].m_VirtualCamera = vCam1;
        stateDriven.m_Instructions[1].m_VirtualCamera = vCam2;

        stateDriven.m_Instructions[0].m_ActivateAfter = 1.0f;
        stateDriven.m_Instructions[1].m_ActivateAfter = 1.0f;

        stateDriven.m_Instructions[0].m_MinDuration = 2.0f;
        stateDriven.m_Instructions[1].m_MinDuration = 2.0f;
    }

    private void Update()
    {
        //Debug.Log(stateDriven.m_Instructions[0].m_FullHash);
        //Debug.Log(stateDriven.m_Instructions[1].m_FullHash);
    }
}