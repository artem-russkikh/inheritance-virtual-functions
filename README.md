# Inheritance and virtual functions in `C#`
Demonstration of inheritance and virtual functions in C#

## Getting Started

1. Install [Mono](http://www.mono-project.com/)
2. Clone: 
    ```bash
    
    git clone git@github.com:artem-russkikh/inheritance-virtual-functions.git
    cd inheritance-virtual-functions
    
    ```
3. Start app by running bash script: `./bin/run`

Bash script [./bin/run](../master/bin/run) will compile and run code of project

## Description
### Part 1
Class ierarchy, virtual functions:
```
Republic, Monarchy, Kingdom, State;

State -> Monarchy -> Kingdom
State -> Republic
```

### Part 2
Object initialization and performing queries:

 * Names of all states, that age is smaller than 1000
 * Kingdoms count
 * Average age all states
 * Name of oldest state

### Part 3
Interfaces

* Required: interface and abstract class
* Create an array of interface elements and place the various instances of the class hierarchy.
* Implement sorting array elements using standard interfaces and methods of the Array class.
* Implement a search element in the array, using standard interfaces and methods of the Array class.
* Implement in one of the classes of objects cloning method. Show cloning of objects.
