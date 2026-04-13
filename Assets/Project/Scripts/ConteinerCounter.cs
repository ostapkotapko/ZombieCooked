using UnityEngine;
using System;

public class ConteinerCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public event EventHandler OnPlayerGrabObject;

    public override void Interact(Player player)
    {
        if(!player.HasKitchenObject())
        {
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);

            OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            //Player have object
        }
    }
}
