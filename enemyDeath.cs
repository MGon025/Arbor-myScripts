using System.Collections;
using UnityEngine;

public class enemyDeath : MonoBehaviour
{
    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
