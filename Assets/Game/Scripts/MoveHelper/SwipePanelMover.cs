using UnityEngine;
using UnityEngine.EventSystems;

public class SwipePanelMover : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private RectTransform panelRectTransform;
    private Vector2 currentOffset;
    private Vector2 velocity;
    public float decelerationRate = 0.95f;
    public float smoothTime = 0.1f;
    private Vector2 targetPosition;
    private bool isDragging = false;

    private void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
        currentOffset = panelRectTransform.anchoredPosition;
        velocity = Vector2.zero;
        targetPosition = currentOffset;
    }

    public void OnDrag(PointerEventData eventData)
    {
        isDragging = true;
        
        Vector2 delta = eventData.delta / CanvasScaleFactor();
        currentOffset += delta;

        panelRectTransform.anchoredPosition += delta;

        velocity = delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        targetPosition = panelRectTransform.anchoredPosition;
    }

    private void Update()
    {
        if (!isDragging)
        {

            if (Mathf.Abs(velocity.magnitude) > 0.01f)
            {

                targetPosition += velocity;
                panelRectTransform.anchoredPosition = Vector2.Lerp(panelRectTransform.anchoredPosition, targetPosition, smoothTime);

                velocity *= decelerationRate;

                if (Mathf.Abs(velocity.magnitude) < 0.01f)
                {
                    velocity = Vector2.zero;
                }
            }
        }
    }

    private float CanvasScaleFactor()
    {
        Canvas canvas = GetComponentInParent<Canvas>();
        return canvas.scaleFactor;
    }
}
