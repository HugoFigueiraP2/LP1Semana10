```mermaid
classDiagram

    class CompareByName 
    class Controller

    class IView
    <<interface>> IView 

    class Player 
    class PlayerOrder
    <<enum>> PlayerOrder 
    
    class Program 
    class View
    

    View ..|> IView
    CompareByName <.. Player
    View --> Program
    Controller --> Program
    PlayerOrder ..> Player
    Player --> Program





    