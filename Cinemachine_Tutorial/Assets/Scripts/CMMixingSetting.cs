using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CMMixingSetting : MonoBehaviour
{
    CinemachineMixingCamera mix;

    void Start()
    {
        mix = this.GetComponent<CinemachineMixingCamera>();

        mix.m_Weight0 = 1;
        mix.m_Weight1 = 2;
    }
}
