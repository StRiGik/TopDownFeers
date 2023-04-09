using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PredmetsScript : MonoBehaviour
{
    public Transform _container;
    public Assetitem zz;
    public List<Assetitem> Items;
    




    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Inventory.itemList.Add(zz);
                
                Destroy(gameObject);
            }
        }
    }
    



}
