in folder Assets/Scripts you can find programming part of the project
- right now, we have feald with rows, on which we can place turrets(red square). **(Node.cs)**
- turrets shoot bullets, that destroy enemies(red dots) **(Turret.cs, Bullet.cs)**
- enemies can spawn in specified time perioud(every five seconds, or four etc) **(wave_spawner.cs)**
- enemies move by folowing waypoints, that are placed by developers **(waypoints.cs)**

- shop is finished, you can buy a turret, place it and loose money.if you dont have money turret is not placed
- remad shop, for future iterations
- **TurretBl.cs** (turret blueprint) setup your turret. its model and cost. 
- **BuildManager.cs** takes this blueprint and places it on map, when player presses on one of white squares (**Node.cs**))
- **PlayerStats.cs** setUps players money and now lets us address player in future. 

### next: 
- add loose/win scenario(five enemies reach you-you dead / survive 3 minutes)
- add player controler component and computer to interact with tower defence portion of prototype


example:
![alt text](https://github.com/Bessonica/towerDefPrototype/blob/master/Assets/ImagesGit/example.PNG)
