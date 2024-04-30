using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float verticalInput;
    [SerializeField] TextMeshProUGUI speedText;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    private Rigidbody playerRb;
    private float speedV;

    // Update is called once per frame
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        //horizontalInput = Input.GetAxis("Horisontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        speedV = Mathf.Round(playerRb.velocity.magnitude * 3.6f);
        speedText.text = "Speed = " + speedV + "+ " + speed;

    }
}
