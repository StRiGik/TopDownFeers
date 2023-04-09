using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    [SerializeField]public static List<Assetitem> itemList = new List<Assetitem>();
    [SerializeField] private InventoryCell inventoryCellTemplate;
    [SerializeField] private Transform _container;
    [SerializeField] private Transform _dragginParent;
    


   
    public void OnEnable()
    {
        Render(itemList);
    }

    public void Render(List<Assetitem> items)
    {
        if(Instantiate(inventoryCellTemplate, _container))
        {
            
            foreach (Transform child in _container)
                Destroy(child.gameObject);
            items.ForEach(item =>
            {
                var cell = Instantiate(inventoryCellTemplate, _container);
                cell.Render(item);
                cell.Init(_dragginParent);
            });
        }
        

        
    }
}    
