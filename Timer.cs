using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    int time = 40;
    public TextMeshProUGUI timer_text;

    public movement move_script;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer_count", 1f, 1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Timer_count()
    {
        time--;
        timer_text.text = time.ToString();
        if(time <= 0)
        {
            CancelInvoke();
            if(move_script.collect >= 3){
                print("win");
            }else if(move_script.collect < 4){
                print("lose");
            }
        }
    }
}
