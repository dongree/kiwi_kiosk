//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartService : MonoBehaviour
{
    CartInterface cartInterface;
    CartData cartData;

    void Awake()
    {
        cartInterface = GetComponent<CartInterface>();
        cartData = GetComponent<CartData>();
    }

    public void AddCart(InfoData infoData)
    {
        cartData.cart.Add(InstantiateCartSlot(infoData));
        UpdateTotalPrice();
    }

    public void RemoveCart(int index)
    {
        CartSlotData cartSlotData = cartData.cart[index];

        cartData.cart.RemoveAt(index);
        UpdateCartSlotIndex(index);
        UpdateTotalPrice();

        Destroy(cartSlotData.gameObject);
    }

    CartSlotData InstantiateCartSlot(InfoData infoData)
    {
        GameObject cartSlot = Instantiate(cartData.cartSlotPrefab, cartData.cartSlotGroup);
        CartSlotData cartSlotData = cartSlot.GetComponent<CartSlotData>();

        cartSlotData.index = cartData.cart.Count;
        cartSlotData.menuName = infoData.itemData.menuName;
        cartSlotData.price = infoData.itemData.price;

        cartSlotData.menuNameTMPro.text = cartSlotData.menuName;
        cartSlotData.priceTMPro.text = $"{cartSlotData.price} ��";
        cartSlotData.removeButton.onClick.AddListener(
            () => cartInterface.RemoveCart(cartSlotData.index));

        return cartSlotData;
    }

    void UpdateCartSlotIndex(int index)
    {
        for (int i = index; i < cartData.cart.Count; i++)
            cartData.cart[i].index = i;
    }

    void UpdateTotalPrice()
    {
        cartData.totalPrice = 0;

        foreach (CartSlotData cartSlotData in cartData.cart)
            cartData.totalPrice += cartSlotData.price;

        cartData.totalPriceTMPro.text = $"{cartData.totalPrice} ��";
    }
}
