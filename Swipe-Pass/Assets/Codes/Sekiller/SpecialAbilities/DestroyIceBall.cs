using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIceBall : MonoBehaviour
{
    public GameObject IceBall;
    public IceBall iceBallScript;

    private void OnMouseDown()
    {
        IceBall = GameObject.FindGameObjectWithTag("Freeze");
        iceBallScript.getHit();
        iceBallScript.destroyIceBall();
    }
}
