```mermaid
classDiagram
    class CompareByName 
    class Controller
    <<interface>> IView 
    class Player 
    class PlayerOrder 
    class Program 
    class View
    

    Cat ..|> IMammal
    Dog ..|> IMammal
    Bat ..|> IMammal
    Bat ..|> ICanFly
    Bee ..|> ICanFly
    Cat --|> Animal 
    Bee --|> Animal
    Bat --|> Animal
    Dog --|> Animal
    Program --> Animal