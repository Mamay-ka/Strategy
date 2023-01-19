using UnityEngine;
using Zenject;
public class UiModelInstaller : MonoInstaller
{
    [SerializeField] private Sprite _chomperSprite;
    
    public override void InstallBindings()
    {
        


        Container.Bind<CommandCreatorBase<IProduceUnitCommand>>()
        .To<ProduceUnitCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>()
        .To<AttackCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>()
        .To<MoveCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>()
        .To<PatrolCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>()
        .To<StopCommandCommandCreator>().AsTransient();

        Container.Bind<CommandButtonsModel>().AsTransient();

        Container.Bind<float>().WithId("Chomper Variant 1").FromInstance(5f);
        Container.Bind<string>().WithId("Chomper Variant 1").FromInstance("Chomper Variant 1");
        Container.Bind<Sprite>().WithId("Chomper Variant 1").FromInstance(_chomperSprite);

        Container.Bind<BottomCenterModel>().AsSingle();
    }
}
