using System;

internal class falldamage : ConsoleSystem
{
    [Admin, Help("enable/disable fall damage", "")]
    public static bool enabled = true;
    [Help("Average amount of time a leg injury lasts", ""), Admin]
    public static float injury_length = 40f;
    [Admin, Help("Fall Velocity when damage of maxhealth will be applied", "")]
    public static float max_vel = 38f;
    [Admin, Help("Fall velocity to begin fall damage calculations - min 18", "")]
    public static float min_vel = 24f;
}

