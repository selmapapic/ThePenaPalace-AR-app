using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikaPOI : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
        if (Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)) {
                if(hit.collider.tag == "zastava") {
                    if(audioSource.isPlaying) {
                        audioSource.Pause();
                    } 
                    else {
                        audioSource.Play();
                    }
                }
            }
        }
    }
}
