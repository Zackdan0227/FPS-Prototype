# FPS-Prototype

Basic FPS room clearing prototype:

Use WASD to move and aim with mouse. Left click to shoot bullets. Player has 10 bullets and 0 scores. Weapon uses inheritance from a parent class "Gun" that is structured to have "fire" function.
Added child object Pistol that shoots semi-automatic with a low fire rate. 
Player may explore the map and find two targets marked with green and red paint. Red indicates Enemy target and green is friendly. Hit on enemy will award Player 1 point 
and hit on friendly target will result in point reduction.

Singleton GameManager is used at the left of the map for player to reset and retry. 

Possible implementations:
- time trial system, beat ur record
- more variations of enemy and friendly targets
- adding automatic guns.
