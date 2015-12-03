# Inheritance and virtual functions in `C#`
It is my laboratory work - program to demonstrate inheritance and virtual functions in C#

...

# Наследование и виртуальные функции в `C#`
Это моя лабораторная работа для демонстрации наследования и виртуальных функций в C#

## Подготовка
Перед запуском необходимо установить [Mono](http://www.mono-project.com/)
```
git clone git@github.com:artem-russkikh/inheritance-virtual-functions.git
cd inheritance-virtual-functions
./bin/run
```
Файл [./bin/run](../master/bin/run) всего лишь bash скрипт для вызова команд mcs и mono, которые компилируют и запускают код проекта

## Часть 1

Иерархия классов, виртуальные функции
```
Республика, монархия, королевство, государство;
государство -> монархия -> королевство
государство -> республика
```

## Часть 2

Запросы:

 * Имена всех государств, которые существуют менее 1000 лет
 * Количество государств - королевств
 * Средний возраст всех государств
 * Наименование старейшего государства

## Часть 3

Интерфейсы

 * Иерархия должна содержать хотя бы один интерфейс и хотя бы один абстрактный класс.
 * Создать массив интерфейсных элементов и поместить в него экземпляры различных классов иерархии.
 * Реализовать сортировку элементов массива, используя стандартные интерфейсы и методы класса Array.
 * Реализовать поиск элемента в массиве, используя стандартные интерфейсы и методы класса Array.
 * Реализовать в одном из классов метод клонирования объектов. Показать клонирование объектов.
