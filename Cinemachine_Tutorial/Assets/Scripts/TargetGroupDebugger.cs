using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
public class TargetGroupDebugger : MonoBehaviour
{
    CinemachineTargetGroup targetGroup;

    void Start()
    {
        targetGroup = this.GetComponent<CinemachineTargetGroup>();
    }

    void Update()
    {
        foreach(CinemachineTargetGroup.Target tg in targetGroup.m_Targets)
        {
            if (tg.target == null) continue;
            tg.target.localScale = new Vector3(tg.radius, tg.radius, tg.radius);
        }
    }
}
