using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

//[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]

public class UniversalInteraction : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnInteraction;
    public UnityEvent OnPress;
    public UnityEvent OnRelease;
    public UnityEvent OnHover;
    public UnityEvent OnLeave;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnInteraction.Invoke();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        OnPress.Invoke();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        OnRelease.Invoke();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHover.Invoke();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        OnLeave.Invoke();
    }
}
