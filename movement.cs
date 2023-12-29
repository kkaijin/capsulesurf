using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{
    public int collect = 0;

    public int chance = 3;

    public TextMeshProUGUI coin_text;

    public TextMeshProUGUI live_text;

    public movement move_script;

    float x;

    public GameObject cube;

    float y;

    float space;

    Rigidbody rb;

    public GameObject loseImage;
    public GameObject winImage;

    bool isGround = false;
    bool car = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
       x = Input.GetAxis("Horizontal");
       y = Input.GetAxis("Vertical");
       space = Input.GetAxis("Jump");

       transform.Rotate(0, x, 0);
       
        

        if (car == true)
        {
            transform.Translate(Vector3.forward * y * Time.deltaTime * 20);
            transform.Translate(Vector3.forward * x * Time.deltaTime * 20);
        }

        if (isGround == true) {    
        rb.AddForce(transform.up * space * 300);
        
        }
        if(space > 0)
        {
            isGround = false;
        }
    }
    void OnCollisionEnter(Collision obj)
        {
            if (obj.gameObject.tag == "cube")
            {
                obj.gameObject.SetActive(false);
                collect = collect + 1;
                coin_text.text = collect.ToString();
            if (collect >= 10) {
                    winImage.SetActive(true);
                    car = false;
            }

            print("yes");
            }
            if (obj.gameObject.tag == "ground") {
                isGround = true;
            }

            if (obj.gameObject.tag == "car")
            {
                chance--;
                live_text.text = chance.ToString();
                if (chance < 1) { 
                    loseImage.SetActive(true);
                    car = false;
                    }
            }

    }
}   
