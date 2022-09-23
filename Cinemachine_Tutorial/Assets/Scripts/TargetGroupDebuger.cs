using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
public class TargetGroupDebuger : MonoBehaviour
{
    CinemachineTargetGroup targetGroup;

    void Start()
    {
        targetGroup = this.GetComponent<CinemachineTargetGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(CinemachineTargetGroup.Target tg in targetGroup.m_Targets)
        {
            if (tg.target == null) continue;
            tg.target.localScale = new Vector3(tg.radius, tg.radius, tg.radius);
        }
    }
}
