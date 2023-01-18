# Итоговая проверочная работа. 1-я четверть

## Задание

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

## Описание

### Ввод массива

Реализован через терминал с клавиатуры в методе **CreateStrArray**

### Формирование нового массива

* Сначала подсчитывается количество элементов в введённом массиве, длина которых меньше, либо равна 3 символам и записывается в счётчик **count**.
* Затем создаётся пустой массив с количеством элементов равное **count**.
* В новый массив записываются элементы, длина которых меньше, либо равна 3 символам.
* Это всё реализовано в методе **Create3SymblArray**

### Вывод массивов в терминал

С помощью метода **PrintArray** производится вывод обоих массивов в терминал.


## Автор

Александр Дащенко

dashch@inbox.ru