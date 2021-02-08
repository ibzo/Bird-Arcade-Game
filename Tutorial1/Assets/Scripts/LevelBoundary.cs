using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var weapon = collision.GetComponent<Weapon>();

        if(weapon != null)
        {
            weapon.ResetPosition();
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
