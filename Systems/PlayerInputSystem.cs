using Godot;
using System;
using Leopotam.Ecs;

public class PlayerInputSystem : IEcsSystem, IEcsRunSystem
{

    EcsFilter<PlayerInputComponent> _filter = null;


    public void Run(float delta)
    {
        float y = Convert.ToSingle( Input.IsActionPressed("action_down")) - Convert.ToSingle(Input.IsActionPressed("action_up"));
        float x = Convert.ToSingle( Input.IsActionPressed("action_right")) - Convert.ToSingle(Input.IsActionPressed("action_left"));

        foreach (int i in _filter)
        {
            ref PlayerInputComponent component = ref _filter.Get1(i);
            component.MoveDirection = new Vector2(x, y).Normalized();
        }

    }



}
