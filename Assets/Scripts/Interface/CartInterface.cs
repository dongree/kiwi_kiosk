//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CartInterface : MonoBehaviour
{
    CartService cartService;

    void Awake()
    {
        cartService = GetComponent<CartService>();
    }

    public void AddCart(ItemData itemData)
    {
        cartService.AddCart(itemData);
    }

    public void AddCart(InfoData infoData)
    {
        cartService.AddCart(infoData);
    }

    public void RemoveCart(int index)
    {
        cartService.RemoveCart(index);
    }
}
