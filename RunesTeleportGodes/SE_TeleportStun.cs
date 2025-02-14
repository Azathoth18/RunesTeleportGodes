using UnityEngine;

public class SE_TeleportStun : SE_Stats
{
    private float _origWalkSpeed;
    private float _origRunSpeed;
    private float _origSpeed;
    private float _origAcceleration;
    private float _origJumpStaminaUsage;

    public SE_TeleportStun()
    {
        m_name = "TeleportStun";
        m_tooltip = "You are frozen by teleport magic!";
        m_ttl = 0f;
    }

    public override void Setup(Character character)
    {
        base.Setup(character);
        if (m_character == null) return;

        // Guardar valores originales
        _origWalkSpeed = m_character.m_walkSpeed;
        _origRunSpeed = m_character.m_runSpeed;
        _origSpeed = m_character.m_speed;
        _origAcceleration = m_character.m_acceleration;
        _origJumpStaminaUsage = m_character.m_jumpStaminaUsage;
    }

    public override void UpdateStatusEffect(float dt)
    {
        base.UpdateStatusEffect(dt);
        if (m_character == null) return;

        // Congelar
        m_character.m_walkSpeed = 0f;
        m_character.m_runSpeed = 0f;
        m_character.m_speed = 0f;
        m_character.m_acceleration = 0f;
        m_character.m_jumpStaminaUsage = 9999f;
    }

    public void RestoreSpeedValues()
    {
        if (m_character == null) return;

        m_character.m_walkSpeed = _origWalkSpeed;
        m_character.m_runSpeed = _origRunSpeed;
        m_character.m_speed = _origSpeed;
        m_character.m_acceleration = _origAcceleration;
        m_character.m_jumpStaminaUsage = _origJumpStaminaUsage;
    }
}
