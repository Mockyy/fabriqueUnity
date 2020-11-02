using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrique : MonoBehaviour
{
    //Le script de fabrique qui posséde la méthode virtuelle SpawnPrefab()

    public virtual void SpawnPrefab()
    {
        Instantiate(this);
    }
}
