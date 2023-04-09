using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fireballScript : MonoBehaviour
{
    public float timeDethEffect;
    private void Update()
    {
        
        
            Destroy(gameObject, timeDethEffect);
        
    }

}
