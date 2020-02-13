using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.5f;
    public float gravity = 10f;
    public CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        Debug.Log("PlayerController");
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var direction = new Vector3(horizontal, 0f, vertical);
        var velocity = direction * speed;

        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;

        controller.Move(velocity * Time.deltaTime);
    }
}
