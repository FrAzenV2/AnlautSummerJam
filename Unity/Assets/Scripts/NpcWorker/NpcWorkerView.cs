using UnityEngine;
using UnityEngine.UI;

namespace NpcWorker
{
    public class NpcWorkerView : MonoBehaviour
    {
        //Animator
        [SerializeField] private GameObject _questDurationBarHolder;
        [SerializeField] private Image _questDurationBar;
        [SerializeField] private Image _staminaBar;

        public void SetQuestDuration(float fill)
        {
            _questDurationBarHolder.SetActive(fill != 0);
            _questDurationBar.fillAmount = fill;
        }

        public void SetStaminaBar(float fill)
        {
            _staminaBar.fillAmount = fill;
        }
        
    }
}