using System;
using System.Collections.Generic;
using UnityEngine;


namespace TheEscort
{
    public partial class Escort
    {
        /// <summary>
        /// Is this Barbarian? YES OR NO ANSWER THE GODDAMN QUESTION YOU PLEB
        /// </summary>
        public bool Barbarian;

        /// <summary>
        /// THe color of barbarian
        /// </summary>
        public Color BarbarianColor;

        /// <summary>
        /// Contains true/false whether player is holding a creature in each grasp
        /// </summary>
        public bool[] BarCretin;

        /// <summary>
        /// How many times a different player (presumably in arena mode) tries to wiggle out of Barbarian's grasp
        /// </summary>
        public int BarWiggle;

        /// <summary>
        /// Delay before shield is active (hold Grab for 10-20 frames maybe)
        /// </summary>
        public int BarShieldDelay;

        /// <summary>
        /// -1 if shielding left side, 1 if shielding right side, 0 if not shielding
        /// </summary>
        public int BarShieldState;

        public void EscortBB(Player player)
        {
            BarbarianColor = new(1f, 0, 0);  // Fukin red for now
            BarCretin = new int[player.grasps.Length];
            BarWiggle = 0;
            BarShieldDelay = -1;
            BarShieldState = 0;
        }
    }
}