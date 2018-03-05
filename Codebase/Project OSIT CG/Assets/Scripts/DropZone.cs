using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler,IPointerExitHandler {
    Manager PManager;
    private void Start()
    {
        PManager = GameObject.Find("PlayManager").GetComponent<Manager>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
    }
    public void OnPointerExit(PointerEventData eventData)
    {
    }
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag.name + " Was Dropped on " + gameObject.name);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        CardInfoPlug Info = eventData.pointerDrag.GetComponent<CardInfoPlug>();
        if (d != null && d.ParentReturn != this.transform)
        {
            if (PManager.CostCheck(Info.cost))
                d.ParentReturn = this.transform;
        }
        else
            d.ParentReturn = this.transform;
    }
}
