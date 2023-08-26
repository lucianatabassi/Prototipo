using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLOR_CONTROLLER : MonoBehaviour
{
    CapsuleCollider florCC;

    public Transform equipSlot;

    void Start()
    {
        florCC = GetComponentInChildren<CapsuleCollider> ();
    }

    
    void Update()
    {
        
    }

    public void CollectItem()
    {
        florCC.enabled = false; //no esta constantemente agarrando el item

        transform.SetParent(equipSlot, false);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
