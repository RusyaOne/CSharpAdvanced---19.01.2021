Теория:
1. Про преимущества .NET Core: https://www.tutorialsteacher.com/core/dotnet-core
2. Новые возожности С# 8/9, которые можно использовать на .NET Core: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8, https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9

Практика:
1. Создайте новое консольное приложение, настройте в нем EF/EF Core.
2. Создайте свою модель (класс содержащий набор свойств), с помощью миграций создайте БД и таблицу на основе модели.
3. Заполните таблицу значениями из приложения.
4. Поместите строку подключения к БД в app.config и в DbContext берите ее из конфигурации. Удостоверьтесь, что добавление новой миграции работает.