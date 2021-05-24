using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : MonoBehaviour
{
     // Healthbar fields
     public HealthBar healthBar;
     public int maxHealth = 100;
     public int currentHealth;

     // Cost fields
     public int oxygenCostPerSecond = 1; // BUG: value of 1 or 200 doesn't seem to make a difference
     public int livingCostPerSecond = 1;
     public int cost = 1;

     // Timers
     public Timer tLivingCost = new Timer();
     public Timer tOxygenCost = new Timer();

     private void Start()
     {
         // Set living cost timer
         tLivingCost.setDuration(1f);

         // Set Oxygen cost timer info
         tOxygenCost.setDuration(1f/(float)oxygenCostPerSecond);
         
         // Set slider values
         currentHealth = maxHealth;
         healthBar.SetMaxHealth(maxHealth);
     }

     private void Update()
     {   
         int originalHealth = currentHealth;
         checkUsingOxygen();
         livingCost();
         updateHealthBar(originalHealth);
         
     }

     private void checkUsingOxygen()
     {
         // Reduce health bar because using oxygen
         if (Input.GetMouseButton(0) && tOxygenCost.timeIsUp())
         {
            currentHealth -= cost;
            tOxygenCost.startTimer();
         }
     }

     private void livingCost()
     {
         // Reduce health bar for living cost
         if (tLivingCost.timeIsUp())
         {
            currentHealth -= cost;
            tLivingCost.startTimer();
         }
     }

     private void updateHealthBar(int originalHealth)
     {
        if(originalHealth != currentHealth) healthBar.SetHealth(currentHealth);
     }

    //this function will restore health/oxygen by the amount given.
    //if the amount given + the current amount is greater than the
    //max health, then the health will cap at the max amount
    public void replenishHealth(int amountToGive)
    {
        if(amountToGive + currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += amountToGive;
        }
    }

    //this function will automatically max out the current health
    //of the player
    public void replenishFullHealth()
    {
        currentHealth = maxHealth;
    }
}
