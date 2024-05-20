// By: Asterisk
#pragma once

#include "CommonHeaders.h"
#include <string>
#include <wrl.h>

#ifndef NOMINMAX
#define NOMINMAX
#endif
#include <vector>

#ifndef EDITOR_INTERFACE
#define EDITOR_INTERFACE extern "C" __declspec(dllexport)
#endif // !EDITOR_INTERFACE

inline bool file_exists(const char* file)
{
    const DWORD attr{ GetFileAttributesA(file) };
    return attr != INVALID_FILE_ATTRIBUTES && !(attr & FILE_ATTRIBUTE_DIRECTORY);
}

inline std::wstring to_wstring(const char* cstr)
{
    std::string s{ cstr };
    return std::wstring(s.begin(), s.end());
}

inline std::vector<std::string> split(std::string s, char delimiter)
{
    size_t start{ 0 };
    size_t end{ 0 };
    std::string substring;
    std::vector<std::string> strings;

    while ((end = s.find(delimiter, start)) != std::string::npos)
    {
        substring = s.substr(start, end - start);
        start = end + sizeof(char);
        strings.emplace_back(substring);
    }

    strings.emplace_back(s.substr(start));
    return strings;
}