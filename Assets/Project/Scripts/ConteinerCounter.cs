using UnityEngine;
using System;

public class ConteinerCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public event EventHandler OnPlayerGrabObject;

    public override void Interact(Player player)
    {
        Transform kitchenObjectSOTransform = Instantiate(kitchenObjectSO.prefab);
        kitchenObjectSOTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

        OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
    }
}
