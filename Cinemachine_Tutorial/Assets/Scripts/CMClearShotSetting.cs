using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMClearShotSetting : MonoBehaviour
{
    public GameObject vCam1, vCam2, player;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(vCam1.transform.position, player.transform.position);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(vCam2.transform.position, player.transform.position);
    }
}
