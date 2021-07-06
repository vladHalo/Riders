using DG.Tweening;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public float duration;

    void Start()
    {
        transform.DOLocalMoveY(-50, duration).
        SetLoops(-1, LoopType.Yoyo);
    }
}
