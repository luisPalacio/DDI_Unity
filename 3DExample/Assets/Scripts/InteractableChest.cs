using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChest : MonoBehaviour
{
    public Color color;
    public GameObject inPanel;
    private bool isPlayerIn = false;
    

    private void Start()
    {
        inPanel.SetActive(false);
    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.O) && isPlayerIn)
        {
            Open();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inPanel.SetActive(true);
            isPlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inPanel.SetActive(false);
            isPlayerIn = false;
        }
    }
    public void Open ()
    {
            Destroy(this.gameObject);
        }
    
}
