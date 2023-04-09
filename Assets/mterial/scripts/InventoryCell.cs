using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class InventoryCell : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
   
    [SerializeField] private Text _nameField;
    [SerializeField] private Image _iconField;
    

    private Transform _dragginParrent;
    private Transform _originalParrent;

    public void Init(Transform dragginParent)
    {
        _dragginParrent = dragginParent;
        _originalParrent = transform.parent;
    }

    public void Render(IItems item)
    {
        
        _nameField.text = item.Name;
        _iconField.sprite = item.UIIcon;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
        transform.parent = _dragginParrent;
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        int closestIndex = 0;
        for (int i = 0; i < _originalParrent.transform.childCount; i++)
        {
            if(Vector3.Distance(transform.position, _originalParrent.GetChild(i).position) < 
                Vector3.Distance(transform.position, _originalParrent.GetChild(closestIndex).position))
            {
                closestIndex = i;
            }
        }
        
        transform.parent = _originalParrent;
        transform.SetSiblingIndex(closestIndex);
    }



}


