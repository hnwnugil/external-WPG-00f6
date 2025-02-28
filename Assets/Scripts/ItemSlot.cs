using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    DragAndDrop dragAndDropItem;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Droped to Slot");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<DragAndDrop>().ParentAfterDrag = transform;

        }
    }
}