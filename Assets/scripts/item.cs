using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private SpriteRenderer sprRend;
    public Sprite ItemSprite { get { return sprRend.sprite; } }


    private void Start()
    {
        
            sprRend = GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        
    }
}
