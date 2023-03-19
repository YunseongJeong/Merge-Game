using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeItem : MonoBehaviour
{
    public int itemType;
    public GameObject overItem;
    Transform transform;
    DragAndDrop dragAndDrop;
    private void OnTriggerStay2D(Collider2D collision)
    { 
        Debug.Log("MergeItem.cs : onTriggerStay running");
        Debug.Log("MergeItem.cs : " + collision.gameObject.name + " and " + gameObject.name);
        if (collision.gameObject.name == gameObject.name && (!dragAndDrop.isDragging && !collision.gameObject.GetComponent<DragAndDrop>().isDragging))
        {
            Debug.Log("MergeItem.cs : onTrigger get same itemType");
            Vector3 myPos = transform.position;
            Vector3 pos = collision.gameObject.transform.position;

            if (myPos.x <= pos.x)
            {
                Debug.Log("MergeItem.cs : start merge item");
                GameObject overItem1 = Instantiate(overItem, pos, transform.rotation) as GameObject;
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MergeItem.cs started");
        transform = gameObject.GetComponent<Transform>();
        dragAndDrop = gameObject.GetComponent<DragAndDrop>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
