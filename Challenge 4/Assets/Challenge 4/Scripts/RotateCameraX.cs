using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*(Christopher Green) 
 * (RotateCameraX.cs) 
 * (Assignment 6) 
 * (This script handles the rotation of the camera in the game.) 
 */

public class RotateCameraX : MonoBehaviour
{
    private float speed = 200;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        transform.position = player.transform.position; // Move focal point with player

    }
}
