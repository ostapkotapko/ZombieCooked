using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObject;

    public override void Interact(Player player)
    {
        if(!HasKitchenObject())
        {
            if(player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //Player don't have object
            }
        }
        else
        {
            if(player.HasKitchenObject())
            {
                //Player have object and can't place it
            }
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if(HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();

            Transform kitchenObjectSOTransform = Instantiate(cutKitchenObject.prefab);
            kitchenObjectSOTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }
    }
}
