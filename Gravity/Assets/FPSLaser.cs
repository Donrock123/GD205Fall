using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLaser : MonoBehaviour
{
    public float boomAmt = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth/2, Camera.main.pixelHeight/2,0));

        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction * 100f, Color.cyan);
        if (Physics.Raycast(laser, out hit, 10000f) &&Input.GetMouseButton(0)){ 
            Debug.Log("you hit" + hit.transform.gameObject.name + "something with the ray");
            if (hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }        
        }
    }
}
