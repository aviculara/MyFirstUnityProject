using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;
using TMPro;


public class HelloWorld : MonoBehaviour
{
    public int speed = 10;
    int look = 1_000; //okunabilmesi için , yerine _ koyabilirsin
    byte levelNo = 1; //küçük sayılar için byte ile tutabilirsin
    string myText = "Hello World";

    public GameObject helloText;


    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
        //now i am writing from vs
        //i am writing this from github.com
        Application.targetFrameRate = 30;
        //framerate sabitlemek gerektiğinde
        helloText.GetComponent<TextMeshPro>().text = myText;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed); //istediğim bir hızda gidiyor şimdi
    }
}
