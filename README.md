# Ark Engrams Override
 Tool to make 'Game.ini' entries for overriding engram settings.
 
Visual Studio 2019, Community

Setup to use a local MSSQL database. You can change the 'DBConn' string in Properties\Settings.
Changes could be made to work from an xml file, since DataSet supports it.

Sql files are included in Properties to create database tables and fill in data:
    Engrams table and data
    EngramCategories table and data
Database name:  ARK
NOTE: There is no auto-increment on the primary keys. Also by design.

To commit changes you make, you -have- to hit the 'Save Changes' button.
This is by design.
Could be modified to update changes as you end a row edit.

I created categories to make filtering the engrams easier.
It has no bearing on the game.



I created this because I couldn't find a suitable tool.

List of categories (yes, first one is blank):

Addons
Ammo
Attatchments
Beds
Boots
Catwalks
Ceilings
Container
Crafting Station
Doorframes
Doors
Electricity
Elevators
Fencing
Foundations
Gates
Gateways
Gloves
Harvester
Hatchframes
Hats
Irrigation
Ladders
Materials
Mek
Melee Weapon
Painting
Pants
Pillars
Platforms
Railings
Ramps
Ranged Weapon
Roofs
Saddles
Shields
Shirts
Signs
Stairs
Substances
Thrown Weapon
Tool
Trapdoors
Traps/SpikedWalls
Turrets
Vehicles
Walls
Water Bottles
Windows
Windowframes
