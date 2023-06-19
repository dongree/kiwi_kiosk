//����
//2017012488_��ǻ���к�_������
//2019040255_�����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInterface : MonoBehaviour
{
    public bool fadeOnStart;
    LoadService loadService;

    void Awake()
    {
        loadService = GetComponent<LoadService>();
    }

    // ù ��° ������ ������Ʈ�� �ϱ� �� Start�� ȣ��
    // Scene ���� �� FadeIn �� scene ǥ��
    void Start()
    {
        if (fadeOnStart)
            FadeIn();
    }

    public void LoadScene(int sceneNum)
    {
        loadService.LoadScene(sceneNum);
    }

    // �������� �������� FadeIn ��ȯ
    public void FadeIn()
    {
        loadService.Fade(1, 0);
    }

    // ������ ���������� FadeOut ��ȯ
    public void FadeOut()
    {
        loadService.Fade(0, 1);
    }
}
