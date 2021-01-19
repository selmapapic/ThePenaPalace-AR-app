using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagFlutter : MonoBehaviour
{
    public Animation anim;
    public AnimationClip clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim.AddClip(clip, "flutter");
        anim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
