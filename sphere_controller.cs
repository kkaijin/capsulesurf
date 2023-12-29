using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public GameObject green_sphere;
    public GameObject purple_sphere;
    public GameObject cube_sphere;
    

    bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        green_sphere.SetActive(true);
        purple_sphere.SetActive(true);

        if (check == false){
            cube_sphere.SetActive(true);
            check = true;
        }else if (check == true){
            cube_sphere.SetActive(false);
            check = false;
        }
        


        
    }
}
