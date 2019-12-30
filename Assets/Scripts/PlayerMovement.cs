using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // photon related var here

    // Start is called before the first frame update
    void Start()
    {
        // photon code here
    }

    // Update is called once per frame
    void Update()
    {
        // photon code here

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void Movement()
    {
        float yMov = Input.GetAxis("Vertical");
        float xMov = Input.GetAxis("Horizontal");
        transform.position += new Vector3(xMov / 7.5f, yMov / 7.5f, 0);
    }
}
