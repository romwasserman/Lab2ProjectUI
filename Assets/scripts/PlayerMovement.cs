using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] public Rigidbody rb;
   [SerializeField] private Vector2 input;
    [SerializeField] public float power;
    [SerializeField] private GameObject UIItemPrefab;
    [SerializeField] private Transform Inventory;
    private Dictionary<string, int> itemDict = new Dictionary<string, int>();
    private List<UIItem> UIList = new List<UIItem>();
    private void Update()
    {
        input = new Vector2 (Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.AddForce(input * power);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       item hitItem = collision.GetComponent<item>();

        if (hitItem != null)
        {
            // Add item if not in dictionary
            if (!itemDict.ContainsKey(collision.gameObject.name))
            {
                GameObject uiItem = Instantiate(UIItemPrefab, Inventory);
                uiItem.GetComponent<UIItem>().SetDetail(collision.gameObject.name, hitItem.ItemSprite);

                UIList.Add(uiItem.GetComponent<UIItem>());
                itemDict.Add(collision.gameObject.name, 1);
       }
            else
            {

            }
        }
        //Destroy(collision.gameObject);
    }
}
