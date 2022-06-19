using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSigment platfirmSigment))
        {
            other.GetComponentInParent<Platform>().Break();
        }
    }
}
