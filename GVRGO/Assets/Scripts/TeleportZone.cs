using GoogleVR.Demos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportZone : MonoBehaviour {
    DemoSceneManager manager;
    
    // Use this for initialization
    void Start() {
        manager = FindObjectOfType<DemoSceneManager>();
    }

    // Update is called once per frame
    void Update() {

    }
    public void TeleportPlayer()
    {
        Vector3 position = new Vector3(
            transform.position.x,
            transform.position.y + manager.playerHeight,
            transform.position.z);
        manager.TeleportLocation(position);
    }
}

