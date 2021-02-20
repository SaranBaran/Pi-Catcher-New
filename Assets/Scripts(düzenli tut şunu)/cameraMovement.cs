using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    Vector3 lastpos;
    public float speedWASD = 0.05f;
    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    [SerializeField] private float zoomLerpSpeed = 10f;

    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    void Update()
    {
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");

        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 3f, 10f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);

        float xAxisValue = Input.GetAxis("Horizontal");
        float yAxisValue = Input.GetAxis("Vertical");
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue*speedWASD, yAxisValue*speedWASD, 0.0f));
        }

    }

    public void LateUpdate()
    {
        if (Input.GetMouseButton(2))
        {
            transform.position += lastpos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        lastpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }



}
