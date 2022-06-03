using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropEvent : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    public CanvasGroup canvasGroup;
    public Vector2 initialPosition;
    public ModifierSO modifier;
    public int ModNumb;
    public string ModOp;

    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        ModNumb = modifier.number;
        ModOp = modifier.operators;

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("onBeginDrag");
        canvasGroup.blocksRaycasts = false;
        initialPosition = GetComponent<RectTransform>().anchoredPosition;

    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("onDrag");
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.blocksRaycasts = true;
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = initialPosition;
        }
    }
}
