using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public bool onTile = false;
    private Vector3 lastPos;
    public bool isDragging = false;
    Vector3 itemPosition;
    Transform objectTransform;
    private void OnMouseDown()
    {
        lastPos = transform.position;
        Debug.Log("mouseDown");
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        Debug.Log("isDragging");
        if (true)
        {

            Vector3 temp = new Vector3(0, 0, 9);
            objectTransform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + temp;
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("mouseUp");
        
        isDragging = false;
        if (!onTile)
        {
            transform.position = lastPos;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        objectTransform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
