using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimOnClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _animation_name;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.Play(_animation_name);
    }
}
