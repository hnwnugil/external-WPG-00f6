using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,IEndDragHandler,IDragHandler
{
    CanvasGroup canvasGroup;
    RectTransform rectTransform;
    [SerializeField] Transform Root;
    [HideInInspector] public Transform ParentAfterDrag;
    [SerializeField] Canvas canvas;
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("StartDragging");
        ParentAfterDrag = Root;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.5f;
        transform.SetParent(Root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition  += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDragging");
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        if (ParentAfterDrag != null)
        {
            transform.SetParent(ParentAfterDrag);
        }
        else
        {
            transform.SetParent(Root);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

}
