using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using UnityEngine.UI;
using TMPro;

public class ItemService : MonoBehaviour
{
    Image image;
    //TextMeshProUGUI menuNameTMPro;

    ItemData itemData;

    void Awake()
    {
        itemData = GetComponent<ItemData>();
        image = GetComponent<Image>();
        //menuNameTMPro = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void UpdateIcon()
    {
        UpdateGameObjectName();
        UpdateImage();
        //UpdateMenuName();
    }

    void UpdateGameObjectName()
    {
        gameObject.name = itemData.menuName;
    }

    void UpdateImage()
    {
        image.sprite = itemData.sprite;
    }

    /*
    void UpdateMenuName()
    {
        menuNameTMPro.text = itemData.menuName;
    }
    */
}