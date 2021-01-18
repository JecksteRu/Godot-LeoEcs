using Godot;
using System;
using Leopotam.Ecs;

public class PlayerMoveSystem : IEcsSystem, IEcsRunSystem
{

    private EcsFilter<PlayerInputComponent, MoveableComponent> _filter;

    public void Run(float delta)
    {
        foreach (int i in _filter)
        {
            ref PlayerInputComponent playerInputComponent = ref _filter.Get1(i);
            ref MoveableComponent moveableComponent = ref _filter.Get2(i);
            moveableComponent.Body.MoveAndSlide(playerInputComponent.MoveDirection * moveableComponent.Speed);

        }
    }
}
