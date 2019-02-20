using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gamemanger gameManager;

    private void OnTriggerEnter()
    {
        gameManager.completelevel();
    }

}
