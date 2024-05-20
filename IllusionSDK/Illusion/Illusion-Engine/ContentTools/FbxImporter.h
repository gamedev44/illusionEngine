// By: Asterisk

#pragma once

#include "ToolsCommon.h"
#include <fbxsdk.h>
#include <assert.h>
#include <vector>

namespace illusion::tools {

    struct scene_data;
    struct scene;
    struct mesh;
    struct geometry_import_settings;

    class fbx_context {
    public:
        fbx_context(const char* file, scene* scene, scene_data* data)
            :_scene{ scene }, _scene_data{ data }, _fbx_manager{ nullptr }, _fbx_scene{ nullptr }, _scene_scale{ 1.0f }
        {
            assert(file && _scene && _scene_data);
            if (initialize_fbx())
            {
                load_fbx_file(file);
                assert(is_valid());
            }
        }

        ~fbx_context()
        {
            if (_fbx_scene) {
                _fbx_scene->Destroy();
            }
            if (_fbx_manager) {
                _fbx_manager->Destroy();
            }
            ZeroMemory(this, sizeof(fbx_context));
        }

        void get_scene(FbxNode* root = nullptr);

        constexpr bool is_valid() const { return _fbx_manager && _fbx_scene; }
        constexpr float scene_scale() const { return _scene_scale; }
    private:

        bool initialize_fbx();
        void load_fbx_file(const char* file);
        void get_meshes(FbxNode* node, std::vector<mesh>& meshes, uint32_t lod_id, float lod_threshold);
        void get_mesh(FbxNodeAttribute* attribute, std::vector<mesh>& meshes, uint32_t lod_id, float lod_threshold);
        void get_lod_group(FbxNodeAttribute* attribute);
        bool get_mesh_data(FbxMesh* fbx_mesh, mesh& m);

        scene* _scene{ nullptr };
        scene_data* _scene_data{ nullptr };
        FbxManager* _fbx_manager{ nullptr };
        FbxScene* _fbx_scene{ nullptr };
        float _scene_scale{ 1.0f };
    };

}