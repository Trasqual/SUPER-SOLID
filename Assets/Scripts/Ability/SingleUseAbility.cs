using UnityEngine;

public class SingleUseAbility : AbilityBase
{
    InputBase input;

    private void Awake()
    {
        input = GetComponent<InputBase>();
    }

    public override void UseAbility()
    {
        Debug.Log("Ability used.");
    }

    private void OnEnable()
    {
        input.OnInputPressed += UseAbility;
    }

    private void OnDisable()
    {
        input.OnInputPressed -= UseAbility;
    }
}
