using UnityEngine;

public sealed class StrategyAnimationPlayer : AbstractStrategy<AbstractAnimationPlayer>
{
    private AbstractScenePlayable playableScene;

    private int directionIndex;

    private void Awake() => playableScene = GetComponentInParent<AbstractScenePlayable>();

    public override void SetStrategy(AbstractAnimationPlayer strategy)
    {
        this.strategy.GetComponent<SpriteRenderer>().enabled = false;
        base.SetStrategy(strategy);
        strategy.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void Update()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical);
        if (direction.normalized.magnitude > 0f) directionIndex = Index(direction);
        strategy.Play(directionIndex);
    }

    private int Index(Vector2 direction)
    {
        var directionAngle = Vector2.SignedAngle(from: Vector2.down, to: direction);
        if (directionAngle < 0f) directionAngle += 360f;
        var directionIndex = Mathf.FloorToInt(f: directionAngle / 45f);
        return directionIndex;
    }
}