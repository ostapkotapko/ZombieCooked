using UnityEngine;
using System;

public class ConteinerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        Transform kitchenObjectSOTransform = Instantiate(kitchenObjectSO.prefab);
        kitchenObjectSOTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

        OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
    }
}
