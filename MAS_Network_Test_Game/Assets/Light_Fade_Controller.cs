using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Fade_Controller : MonoBehaviour
{
    //the rate at which the light should decay
    public float Light_Decay_Rate = 0f;

    //the rate at which the light should grow
    public float Add_Light_Rate = 1f;

    //the max amount of light intensity able to be achieved - pulled from current intensity value on first frame in Start function.
    private float Max_Light_Intensity;

    //timer tick rate in seconds
    private float timer_tick_rate = 1f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //store the current intensity value - to be used later
        Max_Light_Intensity = GetComponent<Light>().intensity;
    }

    // Update is called once per frame
    void Update()
    {
        decay_light_intensity_over_time();

        if (Input.GetKeyDown(KeyCode.Mouse0) && can_add_light())
        {
            add_light();
        }
    }

    //function used to decay light intensity over time - should be called once per frame in the Update function.
    private void decay_light_intensity_over_time()
    {
        //setting up timer based on frame data
        timer += Time.deltaTime;

        //perform function ever "timer_tick_rate" seconds.
        if (timer > timer_tick_rate)
        {
            //decay the light intensity on current game_object
            GetComponent<Light>().intensity -= Light_Decay_Rate;

            //reset timer
            timer = 0f;
        }
    }

    //function to be called when a user wants to add intensity to the light.
    public void add_light()
    {
            GetComponent<Light>().intensity += Add_Light_Rate;
    }

    //function that returns whether light intensity is below or above the cap
    //returns true if light is below cap
    //returns false if light is above cap
    private bool can_add_light()
    {
        if (GetComponent<Light>().intensity > Max_Light_Intensity)
        {
            return false;
        }
        return true;
    }
}
