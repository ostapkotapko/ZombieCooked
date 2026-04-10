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
            Transform kitchenObjectSOTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectSOTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

            OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            //Player have object
        }
    }
}
