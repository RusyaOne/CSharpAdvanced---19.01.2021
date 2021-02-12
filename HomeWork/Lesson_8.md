Теория:
1. AsNoTracking для Core: https://entityframeworkcore.com/querying-data-asnotracking
2. Обновление записи без предварительной подгрузки: https://entityframework.net/update-without-loading
3. Почему необходимо указывать первичный ключ в OnModelCreating: https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding#limitations-of-model-seed-data
4. Вызов SQL функции из EF Core: https://rramname.medium.com/call-sql-scalar-function-from-ef-core-3-without-linq-queries-mapping-and-translation-8cbde2c7de3e

Практика:
1. В созданном нами проекте для EF Core, добавьте новую модель - Author (автор истории). Установите нужные ссылочные связи со существующими моделями. 
При этом не удаляйте данные добавленные ранее в другие таблицы.
2. Заполните Author таблицу несколькими значениями через OnModelCreating.
3. Выведите имя персонажа, название истории и имя автора для каждого персонажа. При этом напрямую обращайтесь к DbSet'у Characters. Остальные характеристики получите через навигационные свойства.
