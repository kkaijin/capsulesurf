using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller2 : MonoBehaviour
{

    static int fallen = 0;

    static int clicked = 0;
    public GameObject winImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(fallen >= 3){
            print("you lose");
        }
        
    }

    void OnCollisionEnter(Collision obj){
        if(obj.gameObject.tag == "ground"){
            gameObject.SetActive(false);
            fallen = fallen + 1;
            print(fallen);
        }
    }

    void OnMouseDown(){
        clicked = clicked + 1;
        print(fallen);
        if(clicked >= 3){
            print("you win");
            winImage.SetActive(true);
        }
        gameObject.SetActive(false);
    }
}
