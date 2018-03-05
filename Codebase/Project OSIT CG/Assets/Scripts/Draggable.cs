using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public Transform ParentReturn = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        ParentReturn = transform.parent;
        //Debug.Log("Began drag");
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("being drag");
        this.transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("end drag");
        this.transform.SetParent(ParentReturn);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
