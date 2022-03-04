# GTEgorss
Programming technologies (.NET: C#, F#; JVM: Java, Scala)

LAB-1: Interop and learning about new programming and developing tools

## Task 1
Процесс:
1. Написал на С++ две функции: sum(int a, int b) и int mult()
2. Добавил в заголовочный файл extern и __declspec(dllexport), чтобы функции в библиотеке после сборки соотвествовале по сигнатуре функциям из source-кода
3. Изменил в CMake файле add_executable на add_library, и добавил в аргументы имя заголовочного файла. В результате этого получил .dylib (macOS аналог .dll)

<ins>Что такое .dylib?</ins>

Файл с расширением файла DYLIB является файлом динамической библиотеки Mach-O (Mach Object), который приложение ссылается во время выполнения, чтобы выполнять определенные функции по мере необходимости.

Mach-O - это формат файла, который используется для различных типов файлов, включая объектный код, общие библиотеки, дампы ядра и исполняемые файлы, поэтому они могут содержать общие данные, которые несколько приложений могут повторно использовать с течением времени.

4. Сохранил файл .dylib в проекты на C# и на Java
5. В Используя атрибут DLLImport, "законнектил" декларацию функций в C# с их определением в .dylib
6. В Java с помощью внешне установленной библиотеки JNA создал .class на основе interface, содержащего функции, совпадающие по сигнатуре с функциями в .dylib

### Сложности и ограничения:

-Нужно подключать и настраивать дополнительные инструменты, которые обычно не используются
-Нет простого способа изменять .dylib/.dll. Нужно изменять source-код на C++, build-ить и только после этого получить новую .dylib/.dll
-Нельзя в качестве аргументов использовать не стандартные типы, ибо в другом языке не получится сопоставить сигнатуру и при интеропе линковка с .dylib/.dll не произойдёт

