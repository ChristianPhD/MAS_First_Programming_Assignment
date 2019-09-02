using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class update_UI : MonoBehaviour
{
    public TextMeshProUGUI score_text_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //updates UI to the score, pulled from another gameobject
        score_text_UI.text = GameObject.Find("score_controller").GetComponent<score_controller_script>().local_score.ToString();
    }
}
