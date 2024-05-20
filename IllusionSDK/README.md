# IllusionSDK
 Crossframework api coming very soon for vulkan and possibly later glsl support.
 
 ## Welcome to -  
# Illusion Engine
![Illusion Game Engine Logo](https://github.com/gamedev44/IE/blob/main/illusionlogo.png?raw=true)

## by: Mr. Asterisk
  so far you can load in 3d scenes via obj or fbx 
  as well as models 
  and script them as game objects using cpp.
  Basic Fucntionality so far
  

# --INFO

--DIRECTORY FOLDER STRUCTURE (TRUNCATED FOR BETTER UNDERSTANDING)


## RootDir Structure below

                                       /Illusion-Engine

    /docs            (Documentation)
    /tests       (Testing scripts and benchmarks)
    
    /src
                 /Engine        # Core engine functionalities (needs updating but works)
        /Common
       /Components
       /EngineApi
       /Utilities
       /physics     # Physics Simulation (not added yet)
       /audio       # Audio Management (not added yet)
      /graphics    # DirectX Splat Engine based Fleck Like Froxel Graphics rendering using 
	                 Sparse Voxel Octrees (Coming Soon)
      /input       # Input handling               (basic input features added)
      /networking  # Networking                   (not added yet)
      /scripting   # C++                          (Added)
      /include        # Header files need to be included
      /tools          # Simple templates Added   (needs improving and adding more features)
      
        /Editor
    /common
    /components
    /dictoonaries
    /editors
    /mainwindow
  

  //



  
    


The engine's pipeline commences with an edit list brimming with 3D environment instructions. This list is intricately processed through a series of 40 compute shaders, transforming the data into a meticulously optimized sparse distance field. This field, akin to the principles of the Marching Cubes algorithm, represents the 3D mesh data and is visualized within a vast voxel space, generally starting with a grid of 1000x1000x1000 voxels. Managing such an extensive array of voxels efficiently poses a significant challenge.

In this voxel realm, a hierarchical voxel space strategy is deployed. It involves the careful splitting and refining of the space, specifically focusing on areas proximal to surfaces. This hierarchical Froxel Space method dynamically refines regions featuring characters or solid objects, thereby enhancing soft shadows and blending effects. It sidesteps the need for resource-intensive CPU and GPU work, proving its efficiency.

The engine's core is its ability to handle intricate object transitions and surface interactions. Distance norms, particularly L2 distance norms, are used to achieve seamless transitions between objects and surfaces. Techniques like dual contouring are explored to optimize polygon count while preserving sharp features, although this method faces its own set of challenges, especially in handling intersections and non-manifold meshes. Moreover, the introduction of subpixel polygons, inspired by volumetric fuzzy billboards, allows for a soft, voxel-based representation, adept at managing multiple overlapping objects with independent transparency.

For rendering, the engine employs GPU rasterization, a choice that favors processing small voxel cells smoothly and adapting to different levels of detail. This is complemented by the use of Order-Independent Transparency (OIT), a technique that conceptually traces rays through voxel-like cells, accumulating "fuzz" during traversal. Rasterization and order-independent transparency are harnessed for efficient rendering, resulting in the engine's distinctive capability to produce painterly shadows and breathtaking visuals.

The engine also boasts a splat engine, creating a 4x4x4 distance field voxel representation. In this setup, each voxel gives rise to a single splat. These splats are then grouped and organized within a bounding volume hierarchy, streamlining the rendering process.

In the final stages, the engine applies a sophisticated 3D radial blurring process, utilizing a series of compute shaders. This blurring technique plays a pivotal role in mitigating artifacts and elevating the rendering quality, particularly enhancing lighting effects.

The culmination of this intricate pipeline results in a unique rendering style, marked by its reminiscent painterly shadows and striking visuals. This innovative approach sets the engine apart, offering a fresh and artistic perspective in the realm of 3D rendering.

Empowering creators to turn dreams into reality!

**Website:** [Visit Website](https://pgd-developments.w3spaces.com/)

**GitHub:** [GitHub Repository](https://github.com/gamedev44/Illusion-Engine/blob/main/README.md)

**Discord:** [Join our Discord](https://discord.gg/AxG76TVUJa)

Craft immersive experiences with our game engine, once it releases.

**License:** This project is semi-open source. Access will be granted to selected individuals and organizations after its initial release.

**Contact:** For inquiries and collaborations, please contact Mr. Asterisk at [herrell4@gmail.com](mailto:herrell4@gmail.com).

---
[GitHub](https://github.com/gamedev44)  
gamedev44 - Overview  
gamedev44 has 34 repositories available. Follow their code on GitHub.



# Illusion Engine v2 - Built using the Primal Engine Bare Framework
A Game Engine by Mr.Asterisk Following the Primal Framework to later Incorperate a Froxel Based Overhaul Mode and New UI to resemble that of Dreams , Game builder garage , uchronia project bge , or Hammer editor

At the moment we have the following features:
-  ability to create a project based on 4 game types: Empty, First Person, Third Person, Top Down
-  Give a name of the project with a path (there is a default path)
-  Tells you if the project exists so that it does not allow you to make a project
-  If no projects exist cannot open a project
-  Opening a project where you are brought into an editor mode
-  Editor mode very very rudimentary, can add scenes and game entities (all empty for now)
-  Has an undo/redo system and a basic history and logging system



## todo

[for: hash-buoy] do as much as you can please its hard to do this on my own because of time limitations.  at least do step 1 please! and confirm its finished.

step 1: Change All Reference Ocurrances of the Name Primal To illusion and all instances of PrimalEditor to IllusionEditor making sure when finished to-
,check for references once more before re-building.

step 2: Implement the Needed GUI Based on the references found in the GUI channel in the R&D Catagory on the discord server (devs only).

step 3: Implement the Needed icons by using https://www.calligraphr.com/en/  to make our custom logos and custom font.

step 4: Implement Primitive shapes via CSG 

step 5: Refine editor functionalities and mechanics like translate adding things like scale recolor etc basing the functionality and features-
,of the editor on Unreal Engine Whilst Keeping the UI Thats Been Discussed.

step 6: Implement Model Importation

step 7: Refine Open / Create Project UI to be more proffessional in design and functionality
step 8: watch and follow along starting from here at episode 6 : https://youtube.com/playlist?list=PL85wXcWAp0HU5HIBHRuUWTLxB2UDDC1Fh&si=1Obtgjw0GnhhPhIy

step 9: implement this if you havent already https://github.com/TheGameEngineers/PrimalPlus via following the videos above in the guide before proeeding any further.


step 10: Add The necessary Voxel Octree Dependencies & Files Needed and there necessary- 
,Inlcudes in the corrosponding c# and c++ files making sure to be able to be able to access the octree parameters within the scene via the xaml.cs-
,Additonally Make sure that when adding a button that can activate the Octree that you ensure to link the button from the xaml.cs to the engine.cpp via editing the .dll-



 

