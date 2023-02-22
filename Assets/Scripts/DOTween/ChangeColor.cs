using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.blue, 2).SetLoops(-1, LoopType.Yoyo) ;   
        _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo) ;   
    }
}
