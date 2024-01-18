using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class AnimationEvenHelper : MonoBehaviour
{
   public UnityEvent OnAnimationEventTriggered, OnAttackPerformed;
   public void TriggerEvent()
   {
      OnAnimationEventTriggered.Invoke();
   }

   public void TriggerAttack()
   {
      OnAttackPerformed.Invoke();
   }
}
