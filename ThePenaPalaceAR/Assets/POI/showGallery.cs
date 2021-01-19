using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGallery : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject canvasGallery;
    // Start is called before the first frame update
    void Start()
    {
        canvasGallery.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)) {
                if(hit.collider.tag == "sundial") {
                    if(canvasGallery.activeSelf) {
                        canvasGallery.SetActive(false);
                    } 
                    else {
                        canvasGallery.SetActive(true);
                    }
                }
            }
        }
    }
}
