using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player is Carrying Something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // Player not Carrying Anything
            }
        }
        else
        {
            // There is a KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player Carrying Something 
            }
            else
            {
                // Player not Carrying Anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
   
}
