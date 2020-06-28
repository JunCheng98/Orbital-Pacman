using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviourPunCallbacks
{
    [Header("Prefabs")]
    [SerializeField] private GameObject pacManPlayerPrefab = null;

    // use round robin or something to spawn players
    [Header("Positions")]
    [SerializeField] private Vector3[] pacManPosition = null;

    void Start() {
        int currentLevel = Int32.Parse(SceneManager.GetActiveScene().name.Substring(5));

        var player = PhotonNetwork.Instantiate(pacManPlayerPrefab.name, 
        pacManPosition[currentLevel - 1], 
        Quaternion.identity);
        
    }

}
