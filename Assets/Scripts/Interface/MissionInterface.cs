//����
//2017012488_��ǻ���к�_������
//2019040255_�����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionInterface : MonoBehaviour
{
    MissionService missionService;

    void Awake()
    {
        missionService = GetComponent<MissionService>();
    }

    public void CheckMission(PayData payData)
    {
        missionService.CheckMission(payData);
    }

    public void PrintResult()
    {
        missionService.PrintResult();
    }
}
