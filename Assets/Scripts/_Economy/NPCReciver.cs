using UnityEngine;
using UnityEngine.EventSystems;

public class NPCReceiver : MonoBehaviour, IDropHandler
{
    public int itemValue = 10; // Nilai uang per item

    public void OnDrop(PointerEventData eventData)
    {
        // Pastikan objek yang di-drag adalah item
        DragAndDrop draggedItem = eventData.pointerDrag.GetComponent<DragAndDrop>();
        if (draggedItem != null)
        {
            // Tambahkan uang
            Money moneySystem = GameObject.Find("Money").GetComponent<Money>();
            moneySystem.AddMoney(itemValue);
            
            // Hancurkan item yang di-drag
            Debug.Log("Item dijual ke NPC! Uang +" + itemValue);
        }
    }
}