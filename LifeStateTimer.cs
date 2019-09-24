using System;

using UnityEngine;
namespace Utility
{
    public class LifeStateTimer
    {

        private float state = 0;
        private bool isDead = false;
        private float startTime = 0;
        private float lifeSpan;

        public LifeStateTimer(float ls)
        {
            lifeSpan = ls;
            reset();
        }
        public bool IsDead()
        {
            return isDead;
        }

        public void reset()
        {
            state = 0;
            startTime = Time.time;
            isDead = false;
        }

        public void Update()
        {
            if (isDead) return;
            state = (Time.time - startTime)  / lifeSpan;
            isDead = state > 1;
            state = Mathf.Min(state, 1);
        }

        public float getState()
        {
            return state;
        }
    }

}
