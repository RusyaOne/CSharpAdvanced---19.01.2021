Детальная инструкция от Microsoft:
https://docs.microsoft.com/en-us/dotnet/core/porting/

1. Составляем граф зависимостей, для того чтоб сначала импортировать проекты, которые не имеют зависимостей.
msbuild "D:/Courses/CSharpAdvanced - 19.01.2021/1.Collections/Collections/" /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=graph.dg.json

2. Переводим все nuget пакеты в проекте на projectReference.

3. Переводим проекты на .NET Framework 4.7.2 или выше.
4. Перестраиваем csproj файл на .NET Core лад. 
dotnet tool install -g try-convert
try-convert -w "D:\Courses\CSharpAdvanced - 19.01.2021\1.Collections\Collections\Collections\Collections.csproj"

5. Если есть ошибки при конвертации исправляем с помощью специальных приложений или вручную

6. Переводим проекты на .NET Core или .NET Standard.