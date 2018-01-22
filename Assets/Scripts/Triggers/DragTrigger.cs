using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragTrigger : MonoBehaviour, IPointerDownHandler, IDragHandler,
    IBeginDragHandler, IEndDragHandler
{
    //得到图片的ugui坐标
    private RectTransform bound;
    //用来得到鼠标和图片的差值
    Vector2 offset = new Vector3();

    // Use this for initialization
    void Start()
    {
        bound = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //计算图片中心和鼠标点的差值
        offset = bound.anchoredPosition - eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //设置图片的ugui坐标与鼠标的ugui坐标保持不变
        bound.anchoredPosition = offset + eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
