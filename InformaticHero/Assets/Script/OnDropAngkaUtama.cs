using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class OnDropAngkaUtama : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI angkaDisplay;
    public NumbersSo nomor;
    public int angkaUtama, angkaTujuan ;
    public void Awake()
    {
        angkaUtama = nomor.getMainNumber();
        angkaTujuan = nomor.getGoalNumber();
    }
    void Start()
    {
        angkaDisplay.text = ""+ angkaUtama;
    }
    public void OnDrop(PointerEventData eventData)
    {
        
        if (eventData.pointerDrag != null)
        {
            GameObject droppedObject = eventData.pointerDrag;
            if (droppedObject.GetComponent<DragAndDropEvent>().ModOp == "X")
            {
                angkaUtama = angkaUtama * droppedObject.GetComponent<DragAndDropEvent>().ModNumb;
            }
            if (droppedObject.GetComponent<DragAndDropEvent>().ModOp == "+")
            {
                angkaUtama = angkaUtama + droppedObject.GetComponent<DragAndDropEvent>().ModNumb;
            }
            if (droppedObject.GetComponent<DragAndDropEvent>().ModOp == "-")
            {
                angkaUtama = angkaUtama - droppedObject.GetComponent<DragAndDropEvent>().ModNumb;
            }
            if (droppedObject.GetComponent<DragAndDropEvent>().ModOp == "/")
            {
                angkaUtama = angkaUtama / droppedObject.GetComponent<DragAndDropEvent>().ModNumb;
            }
            droppedObject.GetComponent<DragAndDropEvent>().canvasGroup.blocksRaycasts = true; ;
            droppedObject.GetComponent<RectTransform>().anchoredPosition = droppedObject.GetComponent<DragAndDropEvent>().initialPosition;
            droppedObject.SetActive(false);
        }
    }
    void Update()
    {
       angkaDisplay.text = ""+ angkaUtama;
    }
    
}
