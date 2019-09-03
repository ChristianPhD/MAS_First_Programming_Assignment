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
        //continually pull global score from AWS and put it into local score
    }

    //public function used to increase local score by 1
    public void increase_local_score()
    {
        //increase local score
        local_score++;

        //update global score to local score
    }
}
