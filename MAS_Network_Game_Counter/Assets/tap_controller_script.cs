using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_controller_script : MonoBehaviour
{
    //key used for input
    public KeyCode interact_key;

    //object to spawn on tap
    public GameObject tap_spawn_obj;

    private Vector3 current_mouse_pos;

    void Update()
    {
        //store the current mouse position in a variable
        current_mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        current_mouse_pos.z = 0f;

        //if the interact button is pressed
        if (Input.GetKeyDown(interact_key))
        {
            //spawn gameobject
            Instantiate(tap_spawn_obj, current_mouse_pos, tap_spawn_obj.transform.rotation);

            //increase score
            GameObject.Find("score_controller").GetComponent<score_controller_script>().increase_local_score();
        }
    }
}
