using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObjectInfo : MonoBehaviour
{
    public GameObject infoSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showInfo() {
        infoSprite.SetActive(!infoSprite.activeSelf);
    }
}
