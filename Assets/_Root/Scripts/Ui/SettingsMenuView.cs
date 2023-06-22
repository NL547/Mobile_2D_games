using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsMenuView : MonoBehaviour
{
    [SerializeField] private Button _buttonBack;

    public void Init(UnityAction closeSettings) =>
        _buttonBack.onClick.AddListener(closeSettings);

    public void OnDestroy() =>
        _buttonBack.onClick.RemoveAllListeners();
}
