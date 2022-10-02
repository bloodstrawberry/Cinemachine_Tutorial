using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FreeLookTarget : MonoBehaviour
{
    void Awake()
    {
        CinemachineCore.GetInputAxis = clickControl;
    }

    public float clickControl(string axis)
    {
        if (Input.GetMouseButton(0))
            return UnityEngine.Input.GetAxis(axis);

        return 0;
    }
}
