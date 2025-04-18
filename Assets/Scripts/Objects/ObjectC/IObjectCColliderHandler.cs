using UnityEngine;

public interface IObjectCColliderHandler
{
    void OnPlayerInteraction(Collider other);
    
    void OnPlayerExitInteraction(Collider other);
}