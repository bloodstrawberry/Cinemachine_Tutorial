using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShowCurrentCamera : MonoBehaviour
{
    [Range(10, 150)]
    public int fontSize = 30;
    public Color color = new Color(.0f, .0f, .0f, 1.0f);
    public float width, height;

    void OnGUI()
    {
        Rect position = new Rect(width, height, Screen.width, Screen.height);

        float fps = 1.0f / Time.deltaTime;
        float ms = Time.deltaTime * 1000.0f;

        ICinemachineCamera currentCam 
            = CinemachineCore.Instance.GetActiveBrain(0).ActiveVirtualCamera;
        Debug.Log(currentCam.Priority);


        GameObject sex = currentCam.VirtualCameraGameObject;
        Debug.Log( "zz" + sex.name);

        string text = $"Current Camera : {currentCam.Name}";

        GUIStyle style = new GUIStyle();

        style.fontSize = fontSize;
        style.normal.textColor = color;

        GUI.Label(position, text, style);
    }
}
