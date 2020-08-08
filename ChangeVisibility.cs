using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisibility : MonoBehaviour
{
    MeshRenderer renderer;
    bool visibility = true;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("t")){
            visibility = !visibility;
            renderer.enabled = visibility;
        }
    }
}
