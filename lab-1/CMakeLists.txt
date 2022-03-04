cmake_minimum_required(VERSION 3.15)
project(Csharp_interop)

set(CMAKE_CXX_STANDARD 17)

add_library(Csharp_interop SHARED sum.h sum.cpp)

SET(CMAKE_CXX_FLAGS -fdeclspec)
