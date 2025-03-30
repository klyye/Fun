# Architecture Ideas
 * ~~AN UPGRADE WILL JUST BE A COST AND A LIST OF BEHAVIORS AND ACTIONS~~
 * ~~ACTIONS ARE THINGS THAT ARE TRIGGERED I.E. EXPLOSIONS, SPAWNING, ETC~~
 * ~~BEHAVIORS ARE THINGS THAT CONSTANTLY MODIFY BEHAVIOR, I.E. SPEED, DIRECTION, ETC~~
   * ~~BEHAVIORS MAY TRIGGER ACTIONS~~
 * no need to differentiate between actions and behaviors. just have upgrades with a cost that apply some thingy to the player
 * separate "upgrade" classes to store the cost and actually apply the upgrade
## upgrade ideas
- [ ] exploding bullets -> on hit
- [ ] poison/burn/dot -> on hit
- [ ] bullet fractures into more bullets -> on hit
- [ ] BIG bullet size -> on spawn
- [ ] slow effect -> on hit
- [ ] critical hits -> on hit
- [ ] GMP/LMP -> on spawn
- [x] heat seeking -> while traveling~~
- [x] piercing shot -> on hit
- [x] double shot -> on spawn~~
- [ ] spiral shot -> while traveling

# TODO list
- [ ] refactor shooter.cs to be a behavior (maybe?)
- [ ] add a basic + atk spd upgrade to make use of shooter.cs modularity
- [x] explore scriptableobject system
- ~~refactor upgrade.cs to use scriptableobjects instead of having a monobehavior per upgrade~~
- [ ] determine which upgrades are mutually exclusive