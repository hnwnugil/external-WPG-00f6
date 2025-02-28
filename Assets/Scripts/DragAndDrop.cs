using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,IEndDragHandler,IDragHandler
{
    CanvasGroup canvasGroup;
    RectTransform rectTransform;
    [SerializeField] Transform Root;
    public Transform ParentAfterDrag;
    Transform ParentBeforeDrag;
    [SerializeField] Canvas canvas;
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("StartDragging");
        ParentBeforeDrag = ParentAfterDrag;
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

        if (ParentAfterDrag != ParentBeforeDrag)
        {
            transform.SetParent(ParentAfterDrag);
            transform.position = ParentAfterDrag.position;
        }
        else
        {
            transform.SetParent(ParentBeforeDrag);
            transform.position = ParentBeforeDrag.position;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

}
