using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SharpUI : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 originalPosition;
    //private GameObject childText;
    

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 记录原始位置
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 跟随鼠标移动
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 检查是否拖到目标点
        var targets = FindObjectsOfType<PuzzleTarget>();
        foreach (var target in targets)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(target.GetComponent<RectTransform>(), Input.mousePosition, canvas.worldCamera))
            {
                if (target.targetId == this.pieceId)
                {
                    // 吸附到目标点
                    rectTransform.anchoredPosition = target.GetComponent<RectTransform>().anchoredPosition;
                    target.canSeeInfo = true;
                    return;
                }
            }
        }
        // 否则回到原位
        rectTransform.anchoredPosition = originalPosition;
    }

    

    public int pieceId; // 在Inspector中设置，每个拼图块唯一编号
}