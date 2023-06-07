//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemService : MonoBehaviour
{
    ItemData itemData;

    void Awake()
    {
        itemData = GetComponent<ItemData>();
    }

    public void UpdateIcon()
    {
        UpdateGameObjectName();
        UpdateImage();
    }

    void UpdateGameObjectName()
    {
        gameObject.name = itemData.menuName;
    }

    void UpdateImage()
    {
        if (itemData.itemSprite != null)
            GetComponent<Image>().sprite = itemData.itemSprite;
    }
}