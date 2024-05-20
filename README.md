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

--DIRECTORY FOLDER STRUCTURE (TRUNCATED FOR BETTER UNDERSTANDING & TO SAVE SIZE ON THIS README LOL)

ALSO WE STILL NEED TO FIX SOME CONFIGURATION LAUNCH OPTIONS AND JSONS AS WELL AS POINTERS BEFORE THIS WILL WORK AGAIN.


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

## Feature's
At the moment we have the following features:
-  ability to create a project based on 4 game types: Empty, First Person, Third Person, Top Down
-  Give a name of the project with a path (there is a default path)
-  Tells you if the project exists so that it does not allow you to make a project
-  If no projects exist cannot open a project
-  Opening a project where you are brought into an editor mode
-  Editor mode very very rudimentary, can add scenes and game entities (all empty for now)
-  Has an undo/redo system and a basic history and logging system



## Todo List

Fix a few simple launch configs and pointers and get it back up and showing editor screen so we can continue.

after fixing first configs and pointers implement the new Xaml & Associated Xaml.Cs UI files
 - Found as SceneEditorViewLayout.Xaml and SceneEditorViewLayout.Xaml.cs
 

