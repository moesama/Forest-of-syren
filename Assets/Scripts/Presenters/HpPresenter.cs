using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HpPresenter : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private float animateDuring = 0.2f;
    
    private Tweener tweener = null;

    private MaxHp maxHp;
    private Hp hp;

    private void Start()
    {
        maxHp = GetComponent<MaxHp>();
        hp = GetComponent<Hp>();
        if (slider != null && maxHp != null && hp != null)
        {
            slider.maxValue = maxHp.GetValue();
            slider.value = hp.GetValue();
        }
    }
    
    private void Update ()
    {
        if (slider == null || maxHp == null || hp == null) return;
        if (slider.maxValue != maxHp.GetValue())
        {
            slider.maxValue = maxHp.GetValue();
        }
        if (tweener == null && slider.value != hp.GetValue())
        {
            tweener = slider.DOValue(hp.GetValue(), animateDuring);
            //设置这个Tween不受Time.scale影响
            tweener.SetUpdate(true);
            //设置缓动类型
            tweener.SetEase(Ease.OutQuad);
            tweener.onComplete = delegate ()
            {
                tweener = null;
            };
        }
    }

    private void OnDestroy()
    {
        if (tweener != null)
        {
            tweener.Kill();
            tweener = null;
        }
    }
}
