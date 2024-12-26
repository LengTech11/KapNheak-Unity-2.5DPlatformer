using UnityEngine;

public class BettleAI : BaseAI
{
    public GameUI gameUI; // Reference to the GameUI

    new void Start()
    {
        base.Start();

        var patrolState = new BasePatrolState(this);
        stateMachine.SetState(patrolState);
    }

    public override void DeathAnimation()
    {
        base.DeathAnimation();
        ShowVictoryPanel();
    }

    public void ShowVictoryPanel()
    {
        gameUI.ShowVictoryPanel();
    }
}