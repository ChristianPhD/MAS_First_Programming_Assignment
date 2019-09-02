using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_controller_script : MonoBehaviour
{
    public int local_score;
    public int global_score;

    // Start is called before the first frame update
    void Start()
    {
        //at start this script needs to pull the global_score from AWS
        //set local_score to global_score
    }

    // Update is called once per frame
    void Update()
    {
        //keep local_score and global_score in sync
    }

    //public function used to increase local score by 1
    public void increase_local_score()
    {
        local_score++;
    }
}
