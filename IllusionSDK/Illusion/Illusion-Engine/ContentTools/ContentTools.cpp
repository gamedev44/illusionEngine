// By: Asterisk
#include "ToolsCommon.h"

namespace illusion::tools {
extern void ShutDownTextureTools();
}

EDITOR_INTERFACE void
ShutDownContentTools()
{
    using namespace illusion::tools;
    ShutDownTextureTools();
}