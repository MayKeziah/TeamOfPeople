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
     public int oxygenCostPerSecond = 20;
     public int livingCostPerSecond = 1;

     // Timers
     public Timer tLivingCost = new Timer();
     public Timer tOxygenCost = new Timer();

     private void Start()
     {
         // Set living cost timer
         tLivingCost.setDuration(1f);

         // Set Oxygen cost timer info
         tOxygenCost.setDuration(1f);
         
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
         if (Input.GetKey(KeyCode.Space) && tOxygenCost.timeIsUp())
         {
            currentHealth -= oxygenCostPerSecond;
            tOxygenCost.startTimer();
         }
     }

     private void livingCost()
     {
         // Reduce health bar for living cost
         if (tLivingCost.timeIsUp())
         {
            currentHealth -= livingCostPerSecond;
            tLivingCost.startTimer();
         }
     }

     private void updateHealthBar()
     {
        if(originalHealth != currentHealth) healthBar.SetHealth(currentHealth);
     }
}
