//����
//2017016935_�߱��а�_������
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CartSlotData : MonoBehaviour
{
    public List<CartSlotData> optionSlots = new List<CartSlotData>();

    public TextMeshProUGUI menuNameTMPro;
    public TextMeshProUGUI priceTMPro;
    public Button removeButton;

    public int index;
    public bool isSet;
    public bool isOption;
    public ItemData itemData;
}
