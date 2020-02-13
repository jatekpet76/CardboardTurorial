using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
 public void Red() {
        Debug.Log("Change color to RED");
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Green() {
        Debug.Log("Change color to GREEN");
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void Blue() {
        Debug.Log("Change color to BLUE");
        GetComponent<Renderer>().material.color = Color.blue;
    }
        // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ChangeColor START");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
