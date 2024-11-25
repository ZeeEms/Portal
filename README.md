Portal but worse…
af Emma Ravnbeck Kristiansen

Overview:
This project is based on the puzzle game called Portal. The player is able to spawn portals and pass through them, teleporting them to the other portal. The player has to solve a mini puzzle to get to the end prize.

Found in this project:
Scripts;
cameraLook : 
makes object where the script is placed, look at the player
Lazeer : 
uses raycast to make a lazer if hit player takes damage
Platemanager:
ontrigger - if collided then button goes down and door is open
Player movement: 
uses charactercontroller
makes player able to walk/run
controls direction of camera
uses gravity to stay on ground
Player interact : 
makes player able to lift and let go of an object by using the e button
if e is pressed on cake then application quits
makes object be in front and follow camera
PortalManager : 
if collided with portal player is transformed position to the other portal while also rotating player to match portal
disables cc to avoid physics in between
Portalspawner:
spans portals by pressing right or left mouse button
uses raycast to spawn them from where player is looking
target: 
sets health and controls damage
if dead respawn to start position
WaterDamage:
checks if player is under threshold and if under, respawn

Objects;
Player;
Character controller
playermovement/portalmanager/spawnmanager/playerinteract/waterdamage/target scripts
collider
Enemy; has lazer script
Portals; particle system, collider, spawns anywhere in the building by player mous input
Companion cubes; made in blender, Liftable, used to block lazer and placed on
Pressure plate; Platemanager script
Cake; when pressed - exist application, made in blender
Background objects; various prefabs from different unity assets packages 


Time schedule:
Sep; 
19 - 1 hour idea sketching and basic setup
21 - 2 hours playermovement and basic setup
29 - 1 hour camera follow player script and lighting
Okt;
5 - 3 timer respawning and portal
6 - 1 hour portal and player interact
10 - 1 hour lazer and raycast
17 - 2 hour platemanager, rework map in probuilder
31 - 1 hour particle for portals
Nov;
10 - 1 hour fixing scripts and finding assets
12 - 2 hours sound and lighting
25 - Export to github and finalizing game


Reference;
SpawnManager, PortalManager;https://www.youtube.com/watch?v=WQAaiI-E12s&t=1106s&ab_channel=WitherWhisperer
https://www.youtube.com/watch?v=RVU9nc0bm9o&ab_channel=WitherWhisperer
CameraLook;https://www.youtube.com/watch?v=e9Lt7mXhs6E&ab_channel=Omogonix
WaterDamage; https://www.youtube.com/watch?v=Mic9ERhr0HA&ab_channel=KozmobotGames
Lazeer;https://www.youtube.com/watch?v=yY73hy44NfU&ab_channel=Navarone
PlateManager;https://www.youtube.com/watch?v=6vj_Ie9i-Ak&ab_channel=SingleSaplingGames
PLayerMovement; https://www.youtube.com/watch?v=1uW-GbHrtQc&t=2s&ab_channel=Brogrammer
PLayerInteract; https://www.youtube.com/watch?v=jqbrq-EIypk&t=18s&ab_channel=Noblob
Background sound; https://www.youtube.com/watch?v=aqGXCQ_5WOc&ab_channel=Toskweeze
Background objects:
table https://assetstore.unity.com/publishers/88104
gun https://assetstore.unity.com/packages/3d/props/guns/sci-fi-futuristic-hand-gun-90249
door https://assetstore.unity.com/packages/3d/props/metal-door-5397
window https://assetstore.unity.com/packages/3d/props/industrial/steel-window-650
other background assets https://assetstore.unity.com/packages/3d/environments/industrial/unity-warehouse-276394
bot :https://sketchfab.com/3d-models/turret-from-portal-2-original-35821cb3ae284537bc0ab06b7be73a09


link to unity project files:
