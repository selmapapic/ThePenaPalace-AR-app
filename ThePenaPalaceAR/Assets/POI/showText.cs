using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showText : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject text, plane;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        plane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)) {
                if(hit.collider.tag == "fontana") {
                    if(text.activeSelf) {
                        text.SetActive(false);
                        plane.SetActive(false);
                    } 
                    else {
                        text.SetActive(true);
                        plane.SetActive(true);
                    }
                }
            }
        }
    }
}

