using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_controller_script : MonoBehaviour
{
    public KeyCode interact_key;
    public GameObject tap_spawn_obj;

    public Vector3 current_mouse_pos;

    void Update()
    {
        current_mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        current_mouse_pos.z = 0f;

        if (Input.GetKeyDown(interact_key))
        {
            Instantiate(tap_spawn_obj, current_mouse_pos, tap_spawn_obj.transform.rotation);
            GameObject.Find("score_controller").GetComponent<score_controller_script>().increase_global_score();
        }
    }
}
