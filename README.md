# Ark Engrams Override
 Tool I made to make 'Game.ini' entries for overriding engram settings. Tools are great when there are almost 600 engrams!
 
Visual Studio 2019, Community

Setup to use a local MSSQL database. You can change the 'DBConn' string in Properties\Settings.

Sql files included in Properties (as a zip) to create tables and data:
*	Engrams table and data
*	EngramCategories table and data

Database name is **ARK**. There is no auto-increment on the primary keys.

Changes could be made to work from xsd and xml files, since DataSet supports it.

Xsd and Xml files are also supplied, but you will need to modify the project to use them.

To accept changes, you -have- to hit the 'Save' button, by design.

Could be modified to update when you end a row edit.

I created categories to make filtering the engrams easier. It has no bearing on the game.

List of categories:
* Addons  (Chair, Bench, etc.)
* Ammo
* Attatchments
* Beds
* Boots
* Catwalks
* Ceilings
* Container
* Crafting Station
* Doorframes
* Doors
* Electricity
* Elevators
* Fencing
* Foundations
* Gates
* Gateways
* Gloves
* Harvester
* Hatchframes
* Hats
* Irrigation
* Ladders
* Materials
* Mek
* Melee Weapon
* Painting
* Pants
* Pillars
* Platforms
* Railings
* Ramps
* Ranged Weapon
* Roofs
* Saddles
* Shields
* Shirts
* Signs
* Stairs
* Substances
* Thrown Weapon
* Tool
* Trapdoors
* Traps/SpikedWalls
* Turrets
* Vehicles
* Walls
* Water Bottles
* Windows
* Windowframes
