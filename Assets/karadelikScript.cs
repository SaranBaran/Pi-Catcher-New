using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karadelikScript : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    
    void Update()
    {

        if (isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
        }


        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Destroy");
        }
    }    

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0)) {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
            }
        }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
