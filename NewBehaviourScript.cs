using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public int scale = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello scale:" + scale);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")){
            this.transform.position += new Vector3(0,1,0);
        }
        Debug.Log(scale);
    }
}
