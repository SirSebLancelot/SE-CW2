using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform teleportTarget;

    void OnTriggerEnter(Collider player)
    {
        Debug.Log("Teleport");
        player.transform.position = teleportTarget.transform.position;
    }
}
 