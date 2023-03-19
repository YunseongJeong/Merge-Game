using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool empty = true;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Tile.cs : onTriggerStay2D running");
        if (collision.gameObject.tag == "Item" && empty)
        {
            if (!collision.gameObject.GetComponent<DragAndDrop>().isDragging)
            {
                empty = false;
                collision.gameObject.GetComponent<DragAndDrop>().onTile = true;
                collision.gameObject.transform.position = gameObject.transform.position+new Vector3(0, 0, -1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item" && !empty)
        {
            collision.gameObject.GetComponent<DragAndDrop>().onTile = false;
            empty = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
