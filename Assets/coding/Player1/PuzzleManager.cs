using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    [Header("游戏配置")]
    public PuzzlePiece[] puzzlePieces; // 赋值6个碎片
    public TMP_Text completeText; // 完成提示文本（可选）

    private int correctPieceCount = 0; // 已归位的碎片数

    void Start()
    {
        // 初始化
        completeText?.gameObject.SetActive(false);
    }

    // 检查拼图是否完成
    public void CheckPuzzleComplete()
    {
        correctPieceCount++;
        if (correctPieceCount == puzzlePieces.Length)
        {
            completeText?.gameObject.SetActive(true);
        }
    }
}