# Final_Task
## Задача : 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:
### Изначально объявляем два массива одинаковой длины, далее используем метод в котором цикл соразмерен длине массива, внутри цикла происходит проверка условия ( <=3 ), если условие выполняется то элемент первого массива заносится в count элемент второго массива. Переменная count необходима чтобы поочередно переносить элементы из первого массива во второй и чтобы потом не было пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. Проверка производится до последнего элемента.

### Графическое представление метода в папке Schema.
### Реализация алгоритма по пути Task/Program.cs