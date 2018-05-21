using UnityEngine;
using System.Collections;

public class diespace : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();

        if (unit && unit is Character)
        {
            unit.ReceiveDamage();
            collider.transform.position = respawn.transform.position;
        }
    }
}
