using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using UnityEngine.SceneManagement;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class ToLevel3Zone : MonoBehaviour
    {
        public string areaToLoad = "Level 3";
        public int requiredTokens = 5;
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null && p.tokenCount >= requiredTokens)
            {
                SceneManager.LoadScene(areaToLoad);
            }
        }
    }
}