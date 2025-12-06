using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("碎片配置")]
    public int pieceID; // 碎片编号（0-5），需与目标位置ID对应
    public Transform targetTransform; // 对应目标吸附位置
    private RectTransform rectTrans;
    public Canvas canvas;
    private Vector2 originalPos; // 拖拽前的初始位置
    private bool isCorrect = false; // 是否已归位
    public PuzzleManager manager;

    void Awake()
    {
        rectTrans = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        originalPos = rectTrans.anchoredPosition;
    }

    // 开始拖拽
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isCorrect) return; // 已归位则不允许拖拽
        originalPos = rectTrans.anchoredPosition;
    }

    // 拖拽中
    public void OnDrag(PointerEventData eventData)
    {
        if (isCorrect) return;
        // 转换鼠标坐标到Canvas局部坐标
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            eventData.position,
            canvas.worldCamera,
            out localPos
        );
        rectTrans.anchoredPosition = localPos;
    }

    // 结束拖拽
    public void OnEndDrag(PointerEventData eventData)
    {
        if (isCorrect) return;
        // 计算碎片与目标位置的距离
        float distance = Vector2.Distance(
            rectTrans.anchoredPosition,
            targetTransform.GetComponent<RectTransform>().anchoredPosition
        );

        // 距离阈值（可根据UI大小调整，建议50左右）
        float snapThreshold = 50f;
        if (distance < snapThreshold)
        {
            // 吸附到目标位置
            rectTrans.anchoredPosition = targetTransform.GetComponent<RectTransform>().anchoredPosition;
            isCorrect = true;
            manager.CheckPuzzleComplete(); // 通知管理器检查是否完成
        }
        else
        {
            // 回到初始位置
            rectTrans.anchoredPosition = originalPos;
        }
    }
}