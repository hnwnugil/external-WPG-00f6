using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private void Awake()
    {
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("StartDragging");
    }

    public void OnDrag(PointerEventData eventData)
    {
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDragging");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

}

