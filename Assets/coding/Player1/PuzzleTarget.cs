using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzleTarget : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int targetId; // 在Inspector中设置，每个目标点唯一编号
    public bool canSeeInfo = false;
    public GameObject infoPanel; // 关联的UI面板

    private void Start()
    {
        infoPanel = transform.GetChild(0).gameObject;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(canSeeInfo)
            infoPanel.SetActive(true);  
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (canSeeInfo)
            infoPanel.SetActive(false);
    }
}
