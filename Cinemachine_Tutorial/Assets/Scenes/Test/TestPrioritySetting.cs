using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TestPrioritySetting : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1, vCam2;

    bool toggle;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 2.5f)
        {
            timer = 0.0f;
            toggle = !toggle;

            if (toggle) vCam2.MoveToTopOfPrioritySubqueue();
            else vCam1.MoveToTopOfPrioritySubqueue();
        }
    }
}
