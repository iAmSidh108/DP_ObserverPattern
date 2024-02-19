# **Observer Pattern in Unity:**

## **What is the Observer Pattern?**

The Observer Pattern is a behavioral design pattern where an object, known as the subject, maintains a list of its dependents, known as observers, that are notified of any state changes, typically by calling one of their methods. This pattern is used to establish a one-to-many relationship between objects, allowing multiple observers to react to changes in the subject's state.

![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/62694dee-153a-4534-8f1c-686a920e6401)

![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/a7f91e4b-ef3e-41e9-85ff-51cc7ce168fa)

## **Examples of using the Observer Pattern in game development:**

1. **Health System:**
   - **Subject:** Represents a game character's health status.
   - **Observers:** Components or systems that need to react to changes in the character's health (e.g., UI health bar, special effects).
   - **Notification:** When the character's health changes, the observers are notified to update their respective elements.

2. **Event System:**
   - **Subject:** Represents an event dispatcher.
   - **Observers:** Various game elements interested in specific events (e.g., completing a quest, picking up an item).
   - **Notification:** The subject notifies observers when the specified event occurs.

## **Drawbacks of using Observer Pattern:**

1. **Performance Overhead:**
   - Frequent updates or a large number of observers may result in performance overhead.

2. **Potential Memory Leaks:**
   - Improper management of observers may lead to memory leaks if not properly handled or removed when no longer needed.

3. **Complexity:**
   - In scenarios where there are numerous observers and complex dependencies, the system may become harder to understand and maintain.

## **How to implement Observer Pattern:**

1. **Define Subject and Observer Interfaces:**
   - Clearly define interfaces for the subject and observers to establish communication protocols.

2. **Register and Deregister Observers:**
   - Implement methods for observers to register and deregister themselves with the subject.

3. **Notify Observers:**
   - When the state changes, iterate through the list of registered observers and notify them accordingly.

4. **Use Unity Events:**
   - Leverage Unity's Event System or custom event classes to implement the observer pattern efficiently.

5. **Handle Dependencies Carefully:**
   - Be mindful of dependencies between subjects and observers, and avoid introducing tight coupling.

6. **Clean Up Unused Observers:**
   - Ensure that observers are properly removed when they are no longer needed to prevent memory leaks.

7. **Documentation:**
   - Document the implementation to provide clarity on the observer relationships and their purposes.

Implementing the Observer Pattern in Unity can enhance the flexibility and extensibility of your game systems by allowing loosely coupled components to react to changes in a decoupled manner.

## How I implemented MVC pattern in Unity?

In this project, The system is that when we hit play The health reduces by 2 points and experience point increases by 10 points. And every 200 experience points levels you up. And whenever we level up Health resets.
Now the problem is how do we notify Health class to reset its value. So, in Level script we create an Event called OnLevelUp which will be invoked whenever we level up. So, in OnEnable we subscribe to the event in Health script and also unsubscribe in OnDisable with ResetHealth. This is how the health will be reset everytime levelUP event is invoked.

![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/131dd6c2-952f-4b73-bb36-6ba1d2786045)
===================================================================================================================
![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/5667f1f8-5732-4d70-bc26-33a3f71db2d8)
