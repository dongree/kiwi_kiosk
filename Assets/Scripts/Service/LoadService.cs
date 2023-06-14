//����
//2017012488_��ǻ���к�_������
//2019040255_�����

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadService : MonoBehaviour
{
    public float fadeDuration = 2;
    public Color fadeColor;
    Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void LoadScene(int sceneNum)
    {
        StartCoroutine(FadeRoutine(0, 1, () => { SceneManager.LoadScene(sceneNum); }));
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    // ���� Fading�� �����ϴ� Coroutine
    // �ð� ����� ���� Fade ���ӽð��� ������ ���� Fade Color�� alpha���� ������Ʈ 
    IEnumerator FadeRoutine(float alphaIn, float alphaOut, Action fadeAction = null)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        rend.material.SetColor("_Color", newColor2);

        if (fadeAction != null)
            fadeAction.Invoke();
    }
}
