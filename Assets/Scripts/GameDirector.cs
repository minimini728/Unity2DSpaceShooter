using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject playerPrefab;
    public PlayerController playerController;
    void Start()
    {

        this.playerController.onDie = () => {
            var go = Instantiate(playerPrefab, new Vector3(0, -1.4f, 0), transform.rotation);
        };

    }

    void Update()
    {
        
    }
}
