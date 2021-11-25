using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float verticalInput ;
    public float horizontalInput;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
      // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        // get the users horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

    }
}
