using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinComparer : IComparer<GameObject>
{
    public GameObject myGameObject;
     public int Compare(GameObject x, GameObject y)
     {
         return Vector2.Distance(myGameObject.transform.position, x.transform.position).CompareTo(Vector2.Distance(myGameObject.transform.position, y.transform.position));
     }
}
