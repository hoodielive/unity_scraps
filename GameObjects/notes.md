# GameObjects

1. Every object in your game is a GameObject!
2. A GameObject is an empty container that can hold different Components.
3. These components are used to implement the functionality of the GameObject.
4. Contingent upon the kind of object you want to create, you will add different combo(s) of 
   components to the GameObject.

### Cube GameObject:
1. Name
2. Tag
3. Layer
4. Transform
5. Mesh Filter
6. Box Collider
7. Mesh Renderer
8. Material

Note: Every GameObject will have the first 3 attributes and the Transform components attached to it as Mandatory.

The Transform component is one of the most important Components - it defines the GameObject's position, rotation and scale in the game world.

The Tag property - you will define a Tag word to link or precisely identify, one or more GameObjects. For example, you can have a Tag defined to associate with a player character, or enemies and so forth. It another way to identify to query GameObjects in your scene during runtime. So GameObjects is a container for Components which in return define what that GameObject will look like and how it will behave. Even programs we write are attached to Components to the GameObject to give it extended functions and features.

Components add flexibility.
When you attach a Component to a GameObject, there are different properties in the Component that can be adjusted in the editor while designing a game, or by scripts when running the game.

2 Types of Properties:
1. Values - value properties can be adjusted through the designer or at runtime. They can be of any type.
2. References - reference properties are like pointers to other GameObjects, audio, scripts, material, Prefabs and etc.

Scripts are components.
Scripts compile to a type of Component and is treated like any other Component in Unity.
Scripts are user-defined Components.

```csharp
[SerializeField]
private string make;

[SerializeField]
private string model;

[SerializeField]
private int year;

[SerializeField]
private string color;
```

These expose private fields to the UnityEngine Inspector Window.


Static GameObjects

Many optimizations need to know if an object can move during gameplay.

Information about a Static, non-moving, object can often be precomputed in the editor assumingthat it will not be invalidated by a change in the object's position.

This helps with rendering and frame-rate of your game.

Such techniques are used for optimization and it is a good idea to learn about the benefits of them as you design and develop your game. 

To identify a GameObject as Static or Non-Static, there is a checkbox in the Inspector Window. If the checkbox is marked, the Unity will inform various internal systems that the object will not move. The whole idea here is performance enhancement! These internal systems are as follows:

1. Global Illumination: advanced lighting for a scene.
2. Occulder and Occludee: rendering optimization based on the visibility of objects from specific camera positions.
3. Batching: rendering optimization that combines several objects into one larger object.
4. Navigation: the system that enables characters to negotiate in the scene.
5. Off-Mesh Links: connections made by the Navigation system between discontinuous areas of the scene.
6. Reflection Probe: captures a spherical view of its surroundings in all directions.
