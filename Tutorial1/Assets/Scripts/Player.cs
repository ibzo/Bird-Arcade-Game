using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LevelManager levelManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var weapon = collision.transform.GetComponent<Weapon>();
        if(weapon != null)
        {
            weapon.ResetPosition();

            var player = transform.name;
            levelManager.UpdateScore(player);
        }
    }
}
