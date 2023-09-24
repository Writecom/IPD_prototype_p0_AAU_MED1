using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webcamVideoPlayer : MonoBehaviour
{
    public RawImage rawImage; // Reference to the RawImage component where you'll display the webcam feed

    private WebCamTexture webcamTexture; // Reference to the webcam texture

    void Start()
    {
        // Check if there is a webcam available
        if (WebCamTexture.devices.Length > 0)
        {
            // Get the first available webcam
            webcamTexture = new WebCamTexture(WebCamTexture.devices[0].name);

            // Start capturing from the webcam
            webcamTexture.Play();

            // Flip the webcam texture horizontally
            rawImage.transform.localScale = new Vector3(-1, 1, 1); // This line flips the texture

            // Assign the webcam texture to the RawImage
            rawImage.texture = webcamTexture;
        }
        else
        {
            Debug.LogError("No webcam found.");
        }
    }

    void Update()
    {
        // You can add any additional logic here if needed
    }
}
