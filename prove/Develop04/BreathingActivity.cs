using System;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }

    protected override void OnStart() { }

    protected override void OnRun()
    {
        CountdownInlineOverwrite("Breathe in...", 4);
        CountdownInlineOverwrite("Now breathe out...", 6);
    }


    protected override void OnEnd() { }
}
