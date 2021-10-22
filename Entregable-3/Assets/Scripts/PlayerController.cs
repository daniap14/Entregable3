using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0, y: 0, z: 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += new Vector3(0.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += new Vector3(0, 0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += new Vector3(0, 0, 0.5f);
        }

    }

}

