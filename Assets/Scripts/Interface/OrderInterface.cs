//����
//2017012488_��ǻ���к�_������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInterface : MonoBehaviour
{
    OrderService orderService;

    void Awake()
    {
        orderService = GetComponent<OrderService>();
    }

    public void ReadyOrderNum(PayData payData)
    {
        orderService.ReadyOrderNum(payData);
    }
    
    public void ReadyOrderNum(int orderNumber)
    {
        orderService.ReadyOrderNum(orderNumber);
    }

    public void MoveCustomer(PayData payData)
    {
        StartCoroutine(orderService.MoveCustomer(payData.isTakeOut));
    }
    
    public void MoveCustomer(bool isTakeOut)
    {
        StartCoroutine(orderService.MoveCustomer(isTakeOut));
    }
}
