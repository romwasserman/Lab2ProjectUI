using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIItem : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Image img;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SetDetail(string name, Sprite sprite)
    {
        text.text = name;
        img.sprite = sprite;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
