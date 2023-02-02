using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject playerPrefab;
    private PlayerController playerController;
    void Start()
    {
        playerController = playerPrefab.GetComponent<PlayerController>();
        this.playerController.onDie = () => {
            var go = Instantiate(playerPrefab, new Vector3(0, -1.4f, 0), transform.rotation);
        };

    }

    void Update()
    {
        
    }
}
