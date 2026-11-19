using UnityEngine;

public class WaterDispense : MonoBehaviour
{
   public void GivePlayerWaterBottles()
   {
      SurvivalMod survival = FindFirstObjectByType<SurvivalMod>();
      if (survival != null)
      {
         survival.AddWater();
      }
      else
      {
         Debug.LogWarning("No Survival Mod found!");
      }
   }
}
