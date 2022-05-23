using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Camera camera;
    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveVector = transform.right * moveX + transform.forward * moveZ;
        //Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        camera.transform.position += moveVector;
        float lookX = Input.GetAxis("Mouse X") * 5;
        float lookY = Input.GetAxis("Mouse Y") * 5;
        xRotation -= lookY;
        yRotation += lookX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //camera.transform.Rotate(transform.up * lookX);
        camera.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
