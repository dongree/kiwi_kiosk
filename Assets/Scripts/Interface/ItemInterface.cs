//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInterface : MonoBehaviour
{
    ItemService itemService;

    void Awake()
    {
        itemService = GetComponent<ItemService>();
    }

    void Start()
    {
        UpdateIcon();
    }

    public void UpdateIcon()
    {
        itemService.UpdateIcon();
    }
}