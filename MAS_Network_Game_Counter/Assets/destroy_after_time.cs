using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_after_time : MonoBehaviour
{
    public float Destroy_After_x_Seconds;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, Destroy_After_x_Seconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
