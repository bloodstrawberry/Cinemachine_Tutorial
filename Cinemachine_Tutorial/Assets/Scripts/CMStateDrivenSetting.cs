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


    //int AddState(int hash, int parentHash, string displayName)
    //{
    //    if (parentHash != 0)
    //        mStateParentLookup[hash] = parentHash;
    //    mStateIndexLookup[hash] = mStates.Count;
    //    mStateNames.Add(displayName);
    //    mStates.Add(hash);
    //    return hash;
    //}

    //void CollectStatesFromFSM(
    //AnimatorStateMachine fsm, string hashPrefix, int parentHash, string displayPrefix)
    //{
    //    ChildAnimatorState[] states = fsm.states;
    //    for (int i = 0; i < states.Length; i++)
    //    {
    //        AnimatorState state = states[i].state;
    //        int hash = AddState(Animator.StringToHash(hashPrefix + state.name),
    //            parentHash, displayPrefix + state.name);

    //        Debug.Log(hash + " Base Layer " + state.name);
    //        // Also process clips as pseudo-states, if more than 1 is present.
    //        // Since they don't have hashes, we can manufacture some.
    //        var clips = CollectClips(state.motion);
    //        if (clips.Count > 1)
    //        {
    //            string substatePrefix = displayPrefix + state.name + ".";
    //            foreach (AnimationClip c in clips)
    //            {


    //                AddState(
    //                CinemachineStateDrivenCamera.CreateFakeHash(hash, c),
    //                hash, substatePrefix + c.name);

    //                Debug.Log(hash + " Sex Layer " + c.name);
    //            }
    //        }
    //    }
    //}
    private void Update()
    {
        //Debug.Log(stateDriven.m_Instructions[0].m_FullHash);
        //Debug.Log(stateDriven.m_Instructions[1].m_FullHash);
    }
}