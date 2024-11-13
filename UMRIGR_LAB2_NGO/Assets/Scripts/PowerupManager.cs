using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        //provjeri jel uso player u trigger
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player uso u powerup");
            other.GetComponent<PlayerManager>().PowerUpPlayerRpc();
            this.gameObject.SetActive(false);
        }
    }
}
