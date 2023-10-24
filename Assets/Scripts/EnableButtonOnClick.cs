using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnableButtonOnClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button button;

    public void OnPointerClick(PointerEventData eventData)
    {
        button.interactable = true;
    }
}
