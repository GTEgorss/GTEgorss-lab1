#ifndef FILE_H
#define FILE_H

#if defined(MYLIBRARY)
#define LIBRARY_EXPORT __declspec(dllexport)
#else
#define LIBRARY_EXPORT
#endif

extern "C" int LIBRARY_EXPORT sum(int a, int b);

extern "C" int LIBRARY_EXPORT mult();

#endif // FILE_H
