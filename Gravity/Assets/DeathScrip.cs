using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScrip : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    public float forceAmt = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
  
    void OnCollisionEnter(Collision colReport)
    {
        if (colReport.gameObject.CompareTag("collectible"))
        {
            Destroy(colReport.gameObject);
        }
    }
}